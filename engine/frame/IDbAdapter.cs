using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace engine
{
    public interface IDbAdapter
    {
        List<String> getTables();
        List<Dictionary<String,Object>> getColumns();
    }
}
