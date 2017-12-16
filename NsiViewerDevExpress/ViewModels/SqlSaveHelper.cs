using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NsiViewerDevExpress.ViewModels
{
    class SqlSaveHelper
    {
        static SqlSaveHelper _instance;

        public static SqlSaveHelper Instance
        {
            get { return _instance ?? (_instance = new SqlSaveHelper()); }
        }

        public SaveSqlCommand SaveSqlCommand { get; set; }


        public SqlSaveHelper()
        {
            SaveSqlCommand = new SaveSqlCommand();
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
