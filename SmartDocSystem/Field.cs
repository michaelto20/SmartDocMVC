using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartDocSystem
{
    class Field
    {
        public string FieldName { get; set; }
        public string DisplayName { get; set; }
        public string DataType { get; set; }
        public bool IsRequired { get; set; }

        public Field() { }

        public Field(string FieldName, string DisplayName, string DataType, bool IsRequired)
        {
            this.FieldName = FieldName;
            this.DisplayName = DisplayName;
            this.DataType = DataType;
            this.IsRequired = IsRequired;
        }
    }
}
