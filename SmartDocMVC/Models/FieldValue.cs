using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartDocMVC.Model
{
    public class FieldValue
    {
        public string Name { get; set; }
        public string Value { get; set; }

        public FieldValue() { }

        public FieldValue(string FieldName, string FieldValue)
        {
            this.Name = FieldName;
            this.Value = FieldValue;
        }
    }
}
