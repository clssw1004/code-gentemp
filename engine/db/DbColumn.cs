using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace engine.db
{
    public class DbColumn
    {
        public String TableName { get; set; }
        public String ColumnName { get; set; }
        public String ColumnType { get; set; }
        public long ColumnLength { get; set; }
        public String IsNullable { get; set; }
        public String ColumnComment { get; set; }
    }
}
