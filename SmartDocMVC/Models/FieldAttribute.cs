using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartDocMVC.Model
{
    public class FieldAttribute
    {
        public string FieldName { get; set; }
        public string DataType { get; set; }
        public bool IsRequired { get; set; }

        public FieldAttribute() { }

        public FieldAttribute(string FieldName, string DataType, bool IsRequired)
        {
            this.FieldName = FieldName;
            this.DataType = DataType;
            this.IsRequired = IsRequired;
        }
    }
}
