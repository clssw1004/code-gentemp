using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace engine.db
{
    public interface IDbAdapter
    {
        List<String> GetTables();
        List<DbColumn> GetColumns(String tableName);
    }
}
