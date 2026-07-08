using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;
using System.Data;
using Microsoft.Data.SqlClient;

namespace S26W9DisconnectedModel
{
    public class Data
    {
        public static string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["Northwind"].ConnectionString;
        }
    }
}
