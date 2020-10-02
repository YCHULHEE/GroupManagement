using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace GroupManagement
{
    public partial class hi : Form
    {
        public hi()
        {
            InitializeComponent();
        }

        private void DataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string strConn = @"Data Source=D:\testdb.db";
            SQLiteConnection conn = new SQLiteConnection(strConn);
            SQLiteCommand cmd = new SQLiteCommand();
            conn.Open();
            cmd.CommandText = "SELECT name, studentId, birthDate, phoneNumber, groupNumber, major, sex FROM INFO_TB";

            //DataAdapter와 DataSet으로 DB table 불러오기
            SQLiteDataAdapter da = new SQLiteDataAdapter(cmd); //select 구문이 들어감
            DataSet ds = new DataSet();
            da.Fill(ds, "INFO_TB");

            dataGridView2.DataSource = ds;
            dataGridView2.DataMember = "INFO_TB";
        }
    }
}
