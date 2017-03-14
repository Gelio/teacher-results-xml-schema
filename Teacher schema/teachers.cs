namespace Teacher_schema {
    using System;
    using System.Collections.Generic;
    
    
    /// <uwagi/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.mini.pw.edu.pl/ood")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.mini.pw.edu.pl/ood", IsNullable=false)]
    public partial class Teacher1Results {
        
        private Teacher1Task task1Field;
        
        private Teacher1Task task2Field;
        
        /// <uwagi/>
        public Teacher1Task Task1 {
            get {
                return this.task1Field;
            }
            set {
                this.task1Field = value;
            }
        }
        
        /// <uwagi/>
        public Teacher1Task Task2 {
            get {
                return this.task2Field;
            }
            set {
                this.task2Field = value;
            }
        }
    }
    
    /// <uwagi/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.mini.pw.edu.pl/ood")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.mini.pw.edu.pl/ood", IsNullable=true)]
    public partial class Teacher1Task : BaseTask {
        
        private Teacher1Result[] resultField;
        
        /// <uwagi/>
        [System.Xml.Serialization.XmlElementAttribute("Result")]
        public Teacher1Result[] Result {
            get {
                return this.resultField;
            }
            set {
                this.resultField = value;
            }
        }
    }
    
    /// <uwagi/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.mini.pw.edu.pl/ood")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.mini.pw.edu.pl/ood", IsNullable=true)]
    public partial class Teacher1Result {
        
        private BaseStudent studentField;
        
        private decimal pointsField;
        
        /// <uwagi/>
        public BaseStudent Student {
            get {
                return this.studentField;
            }
            set {
                this.studentField = value;
            }
        }
        
        /// <uwagi/>
        public decimal Points {
            get {
                return this.pointsField;
            }
            set {
                this.pointsField = value;
            }
        }
    }
    
    /// <uwagi/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Teacher2Student))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.mini.pw.edu.pl/ood")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.mini.pw.edu.pl/ood", IsNullable=true)]
    public partial class BaseStudent {
        
        private string nameField;
        
        private string surnameField;
        
        private ulong idField;
        
        private bool idFieldSpecified;
        
        /// <uwagi/>
        public string Name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        
        /// <uwagi/>
        public string Surname {
            get {
                return this.surnameField;
            }
            set {
                this.surnameField = value;
            }
        }
        
        /// <uwagi/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ulong id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
        
        /// <uwagi/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool idSpecified {
            get {
                return this.idFieldSpecified;
            }
            set {
                this.idFieldSpecified = value;
            }
        }
    }
    
    /// <uwagi/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Teacher2Task))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Teacher1Task))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.mini.pw.edu.pl/ood")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.mini.pw.edu.pl/ood", IsNullable=true)]
    public partial class BaseTask {
        
        private string descriptionField;
        
        private decimal maxPointsField;
        
        private bool maxPointsFieldSpecified;
        
        /// <uwagi/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string description {
            get {
                return this.descriptionField;
            }
            set {
                this.descriptionField = value;
            }
        }
        
        /// <uwagi/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal maxPoints {
            get {
                return this.maxPointsField;
            }
            set {
                this.maxPointsField = value;
            }
        }
        
        /// <uwagi/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool maxPointsSpecified {
            get {
                return this.maxPointsFieldSpecified;
            }
            set {
                this.maxPointsFieldSpecified = value;
            }
        }
    }
    
    /// <uwagi/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.mini.pw.edu.pl/ood")]
    [System.Xml.Serialization.XmlRootAttribute("Teacher2Results", Namespace="http://www.mini.pw.edu.pl/ood", IsNullable=false)]
    public partial class Teacher2Results1 {
        
        private Teacher2Student[] studentField;
        
        /// <uwagi/>
        [System.Xml.Serialization.XmlElementAttribute("Student")]
        public Teacher2Student[] Student {
            get {
                return this.studentField;
            }
            set {
                this.studentField = value;
            }
        }
    }
    
    /// <uwagi/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.mini.pw.edu.pl/ood")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.mini.pw.edu.pl/ood", IsNullable=true)]
    public partial class Teacher2Student : BaseStudent {
        
        private Teacher2Results resultsField;
        
        /// <uwagi/>
        public Teacher2Results Results {
            get {
                return this.resultsField;
            }
            set {
                this.resultsField = value;
            }
        }
    }
    
    /// <uwagi/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.mini.pw.edu.pl/ood")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.mini.pw.edu.pl/ood", IsNullable=true)]
    public partial class Teacher2Results {
        
        private Teacher2Task task3Field;
        
        private Teacher2Task task4Field;
        
        /// <uwagi/>
        public Teacher2Task Task3 {
            get {
                return this.task3Field;
            }
            set {
                this.task3Field = value;
            }
        }
        
        /// <uwagi/>
        public Teacher2Task Task4 {
            get {
                return this.task4Field;
            }
            set {
                this.task4Field = value;
            }
        }
    }
    
    /// <uwagi/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.mini.pw.edu.pl/ood")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.mini.pw.edu.pl/ood", IsNullable=true)]
    public partial class Teacher2Task : BaseTask {
        
        private decimal pointsField;
        
        /// <uwagi/>
        public decimal Points {
            get {
                return this.pointsField;
            }
            set {
                this.pointsField = value;
            }
        }
    }
}
