using System;
using System.Configuration;

namespace ClinicManagementDB_DataAccess
{
    static class clsDataAccessSettings
    {
        public static string ConnectionString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
    }
}
