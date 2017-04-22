using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartDocMVC.Models
{
    public class FieldValues
    {
        public string FieldName { get; set; }
        public string FieldValue { get; set; }

        public FieldValues() { }

        public FieldValues(string FieldName, string FieldValue)
        {
            this.FieldName = FieldName;
            this.FieldValue = FieldValue;
        }
    }
}
