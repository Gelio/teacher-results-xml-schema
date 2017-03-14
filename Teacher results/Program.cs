using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Schema;
using System.IO;
using System.Xml.Linq;
using System.Xml.Serialization;
using Teacher_schema;

namespace Teacher_results
{
    class Program
    {
        static void Main(string[] args)
        {
            string xsdData = File.ReadAllText(args[0]);
            XmlSchemaSet schemaSet = PrepareSchemaSet(xsdData);

            List<Teacher1Results> teacher1 = new List<Teacher1Results>();
            List<Teacher2Results1> teacher2 = new List<Teacher2Results1>();

            XmlSerializer teacher1Serializer = new XmlSerializer(typeof(Teacher1Results));
            XmlSerializer teacher2Serializer = new XmlSerializer(typeof(Teacher2Results1));

            foreach (string filename in args.Skip(1))
            {
                string xmlData;
                try
                {
                    xmlData = Validate(schemaSet, File.ReadAllText(filename));
                }
                catch (Exception e)
                {
                    Console.WriteLine("Dokument {0} zawiera błędy", filename);
                    Console.WriteLine(e.Message);
                    return;
                }

                if (teacher1Serializer.CanDeserialize(XmlReader.Create(new StringReader(xmlData))))
                {
                    Teacher1Results t1Results = teacher1Serializer.Deserialize(new StringReader(xmlData)) as Teacher1Results;
                    teacher1.Add(t1Results);
                }
                else
                {
                    Teacher2Results1 t2Results = teacher2Serializer.Deserialize(new StringReader(xmlData)) as Teacher2Results1;
                    teacher2.Add(t2Results);
                }
            }

            Dictionary<string, List<decimal>> students = new Dictionary<string, List<decimal>>();
            foreach (var t1Result in teacher1)
            {
                foreach (var result in t1Result.Task1.Result)
                {
                    List<decimal> points;
                    if (students.ContainsKey(StudentName(result.Student)))
                        points = students[StudentName(result.Student)];
                    else
                        points = new List<decimal>(new decimal[5] { 0, 0, 0, 0, 0 });
                    points[1] = result.Points;
                    if (!students.ContainsKey(StudentName(result.Student)))
                        students.Add(StudentName(result.Student), points);
                }

                foreach (var result in t1Result.Task2.Result)
                {
                    List<decimal> points;
                    if (students.ContainsKey(StudentName(result.Student)))
                        points = students[StudentName(result.Student)];
                    else
                        points = new List<decimal>(new decimal[5] { 0, 0, 0, 0, 0 });
                    //points.Insert(2, result.Points);
                    points[2] = result.Points;
                    if (!students.ContainsKey(StudentName(result.Student)))
                        students.Add(StudentName(result.Student), points);
                }
            }

            foreach (var t2Result in teacher2)
            {
                foreach (var student in t2Result.Student)
                {
                    List<decimal> points;
                    if (students.ContainsKey(StudentName(student)))
                        points = students[StudentName(student)];
                    else
                        points = new List<decimal>(new decimal[5] { 0, 0, 0, 0, 0 });

                    if (student.Results.Task3 != null)
                        points[3] = student.Results.Task3.Points;
                    if (student.Results.Task4 != null)
                        points[4] = student.Results.Task4.Points;

                    if (!students.ContainsKey(StudentName(student)))
                        students.Add(StudentName(student), points);
                }
            }

            Console.WriteLine("Imie\tNazwisko\t\tZadanie1\tZadanie2\tZadanie3\tZadanie4\tSuma");
            Console.WriteLine("--------------------------------------------------------");

            foreach (var student in students.OrderBy(student => student.Key))
            {
                string name = student.Key;
                string[] splitName = name.Split(' ');
                Console.WriteLine("{0}\t{1}\t\t\t{2}\t\t{3}\t\t{4}\t\t{5}\t\t{6}", splitName[0], splitName[1], student.Value[1], student.Value[2], student.Value[3], student.Value[4], student.Value.Sum());
            }
            Console.WriteLine("--------------------------------------------------------");

        }

        static string StudentName(BaseStudent student)
        {
            return student.Name + " " + student.Surname;
        }

        public static XmlSchemaSet PrepareSchemaSet(string xsdData)
        {
            XmlSchemaSet schemaSet = new XmlSchemaSet();
            schemaSet.Add(XmlSchema.Read(new StringReader(xsdData), (o, e) =>
            {
                if (e.Exception != null) throw e.Exception;
            }));

            return schemaSet;
        }

        public static string Validate(XmlSchemaSet schemaSet, string xmlData)
        {
            //string xsdData = File.ReadAllText("Bookstore.xsd");
            //string xmlData = File.ReadAllText(xmlFilename);

            XDocument document = XDocument.Parse(xmlData);

            document.Validate(schemaSet, (o, e) =>
            {
                if (e.Severity == XmlSeverityType.Error) throw e.Exception;
            });
            return xmlData;
        }
    }
}
