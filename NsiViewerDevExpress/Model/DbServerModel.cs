using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NsiViewerDevExpress.Model
{
    public class DbServerModel
    {
        public DbServerModel(string dbName)
        {
            DbName = dbName;
        }

        public string DbName { get; set; }

    }
}
