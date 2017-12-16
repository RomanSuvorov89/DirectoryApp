using System;
using System.Data.Entity.Core.EntityClient;
using System.Data.SqlClient;

namespace NsiViewerDevExpress.Common
{
    public class DbConnectionHelper
    {

        //<connectionStrings>
        //    <add name = "FormulaModelCs" connectionString="data source=LENOVO-B50-AX3;initial catalog=DB153013;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework" providerName="System.Data.SqlClient" />
        //</connectionStrings>

        public static string BuildConnection(string databaseName)
        {
            //string providerName = "System.Data.EntityClient";
            //string serverName = Environment.MachineName;

            SqlConnectionStringBuilder sqlBuilder = new SqlConnectionStringBuilder();

          //  sqlBuilder.DataSource = Environment.MachineName;
            sqlBuilder.DataSource = "DESKTOP-GST63KB\\SQLEXPRESS";
            sqlBuilder.InitialCatalog = databaseName;
            sqlBuilder.IntegratedSecurity = true;
            sqlBuilder.MultipleActiveResultSets = true;
            sqlBuilder.ApplicationName = "EntityFramework";

            //string providerString = sqlBuilder.ToString();

            //EntityConnectionStringBuilder entityBuilder = new EntityConnectionStringBuilder();
            //entityBuilder.Provider = providerName;
            //entityBuilder.ProviderConnectionString = providerString;

            return sqlBuilder.ToString();//entityBuilder.ProviderConnectionString;//ConnectionString;
        }
    }
}