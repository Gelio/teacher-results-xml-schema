using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Schema;
using System.IO;
using System.Xml.Linq;

namespace Teacher_schema
{
    static class Teacher_schema
    {
        static void Main(string[] args)
        {
            XmlSchema schema = new XmlSchema();
            XmlSchema.Read(new StreamReader("teachers.xsd"), (o, e) =>
            {
                if (e.Severity == XmlSeverityType.Error)
                    throw e.Exception;
            });

            XmlSchemaSet schemas = new XmlSchemaSet();
            schemas.Add(schema);

            List<Teacher1Results> teacher1 = new List<Teacher1Results>();
            List<Teacher2Results> teacher2 = new List<Teacher2Results>();

            foreach (string filename in args)
            {
                XDocument doc = XDocument.Load(filename);
                doc.Validate(schemas, (o, e) => {
                    if (e.Severity == XmlSeverityType.Error)
                        throw e.Exception;
                });
            }

            Console.WriteLine("Documents are valid");
        }
    }

    class ResultsTable
    {
    }
}
