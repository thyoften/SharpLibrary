using System;
using System.Data.SqlClient;

namespace MSSQL_Library
{
    public static class Common
    {
        public static SqlConnection SqlConnection = null;

        public static string Sanitize(string str)
        {
            return new string(str.Where(x => x != ';' || x != '\"' || x != '\'' || x != ' ').ToArray());
        }
    }
}
