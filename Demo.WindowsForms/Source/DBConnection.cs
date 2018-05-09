using System;
using System.Collections.Generic;
using System.Data.SqlClient;



namespace Demo.WindowsForms
{
    class DBConnection
    {
        public DBConnection()
        {
        }

       
        public static SqlConnection Instance()
        {
            string connetionString = null;
            SqlConnection connection;
            SqlCommand command;
            string sql = null;
            SqlDataReader dataReader;
            connetionString = @"Data Source=THANGVQ\SQLEXPRESS;Initial Catalog=quanlydat;User ID=root3;Password=111111";
            sql = "SELECT * FROM users";
            connection = new SqlConnection(connetionString);

            return connection;
        }

        
    }
}
