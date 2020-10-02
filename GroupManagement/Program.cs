using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;



namespace GroupManagement
{
   
    

    class Program
    {
        private static string strConn;
        private SQLiteConnection conn = null;


        /// <summary>
        /// 해당 애플리케이션의 주 진입점입니다.
        /// </summary>
        [STAThread]
        static void Main()
        {
            SQLiteConnection conn = new SQLiteConnection(strConn);
            conn = new SQLiteConnection("Data Source=D:/a.sqlite;Version=3;");
            conn.Open();



            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main());

        }
    }
}
