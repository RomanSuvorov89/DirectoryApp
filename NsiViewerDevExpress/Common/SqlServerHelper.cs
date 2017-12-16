using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace NsiViewerDevExpress.Common
{
    public class SqlServerHelper
    {
        public static List<string> GetAllSqlServerList()
        {
            List<string> list = new List<string>();
            SqlDataSourceEnumerator instance = SqlDataSourceEnumerator.Instance;
            DataTable table = instance.GetDataSources();
            foreach (DataRow row in table.Rows)
            {
                if (row["ServerName"] != DBNull.Value && Environment.MachineName.Equals(row["ServerName"].ToString()))
                {
                    string item = row["ServerName"].ToString();
                    if (row["InstanceName"] != DBNull.Value || !string.IsNullOrEmpty(Convert.ToString(row["InstanceName"]).Trim()))
                    {
                        item += @"\" + Convert.ToString(row["InstanceName"]).Trim();
                    }
                    list.Add(item);
                }
            }
            return list;
        }
        
        public static List<string> GetSqlServerList()
        {
            List<string> serverNames = new List<string>();

            SqlDataSourceEnumerator servers = SqlDataSourceEnumerator.Instance;
            DataTable serversTable = servers.GetDataSources();

            foreach (DataRow row in serversTable.Rows)
            {
                string serverName = row[0].ToString();

                try
                {
                    if (row[1].ToString() != "")
                        serverName += "\\" + row[1].ToString();
                }
                catch
                {
                }
                serverNames.Add(serverName);
            }
            return serverNames;
        }

        public static List<string> GetDatabaseList(string serverName) //Environment.MachineName
        {
            List<string> databases = new List<string>();

            SqlConnectionStringBuilder connection = new SqlConnectionStringBuilder();

            connection.DataSource = "DESKTOP-GST63KB\\SQLEXPRESS"; //servername
         //   connection.DataSource = serverName; //servername
            connection.IntegratedSecurity = true;

            string strConn = connection.ToString();

            using (SqlConnection sqlConn = new SqlConnection(strConn))
            {
                sqlConn.Open();
                DataTable tblDatabases = sqlConn.GetSchema("Databases");
                sqlConn.Close();
                foreach (DataRow row in tblDatabases.Rows)
                {
                    string dbName = row["database_name"].ToString();
                    if(dbName != "master" &&
                       dbName != "tempdb" &&
                       dbName != "model" &&
                       dbName != "msdb" &&
                       dbName != "ReportServer" &&
                       dbName != "ReportServerTempDB")
                        databases.Add(row["database_name"].ToString());
                }
            }
            return databases;
        }
    }
}