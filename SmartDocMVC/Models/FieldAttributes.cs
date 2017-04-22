using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartDocMVC.Models
{
    public class FieldAttributes
    {
        public string FieldName { get; set; }
        public string DataType { get; set; }
        public bool IsRequired { get; set; }

        public FieldAttributes() { }

        public FieldAttributes(string FieldName, string DataType, bool IsRequired)
        {
            this.FieldName = FieldName;
            this.DataType = DataType;
            this.IsRequired = IsRequired;
        }
    }
}
