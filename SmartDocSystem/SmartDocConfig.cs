using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartDocSystem
{
    class SmartDocConfig
    {
        public List<Field> Fields = new List<Field>();

        public string TableName { get; set; }
        public string DatabaseName { get; set; }


        public SmartDocConfig() { }
        public SmartDocConfig(List<Field> Fields, string DatabaseName, string TableName)
        {
            this.Fields = Fields;
            this.TableName = TableName;
            this.DatabaseName = DatabaseName;
        }
    }
}
