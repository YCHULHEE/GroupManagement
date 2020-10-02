using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;


namespace GroupManagement
{
    class ConDatabase
    {
        string strConn = @"Data Source=D:\testdb.db";
        SQLiteConnection conn = new SQLiteConnection();
        private string sConnString = "";

        public void ConnectDB()
        {
            try
            {
                sConnString = strConn;
            }
            catch
            {
            }

            if (conn.State.ToString().Equals("Closed"))
            {
                conn.ConnectionString = sConnString;
                conn.Open();
            }
        }
        public void CloseDB()
        {
            if ( conn != null)
            {
                conn.Close();
            }
        }


    }
}

