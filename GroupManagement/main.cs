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
    public partial class Main : Form
    {

        public Main()
        {
            InitializeComponent();

            

            DataTable table = new DataTable();
            string strConn = @"Data Source=D:\testdb.db";

            using (SQLiteConnection conn = new SQLiteConnection(strConn))


            {
                conn.Open();
            }

                // column을 추가합니다.
                table.Columns.Add("ID", typeof(string));
            table.Columns.Add("제목", typeof(string));
            table.Columns.Add("구분", typeof(string));
            table.Columns.Add("생성일", typeof(string));
            table.Columns.Add("수정일", typeof(string));

            // 각각의 행에 내용을 입력합니다.
            table.Rows.Add("ID 1", "제목 1번", "사용중", "2019/03/11", "2019/03/18");
            table.Rows.Add("ID 2", "제목 2번", "미사용", "2019/03/12", "2019/03/18");
            table.Rows.Add("ID 3", "제목 3번", "미사용", "2019/03/13", "2019/03/18");
            table.Rows.Add("ID 4", "제목 4번", "사용중", "2019/03/14", "2019/03/18");

           
            // 값들이 입력된 테이블을 DataGridView에 입력합니다.
        }

       

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Visible = false; // 현재 폼 안보이게 하기
            
            Member frm = new Member(); // 새 폼 생성
            
            frm.Owner = this; // 새 폼의 오너를 현재 폼으로
           
            frm.Show(); // 새폼 보여 주 기

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Visible = false; // 현재 폼 안보이게 하기

            Event frm = new Event(); // 새 폼 생성

            frm.Owner = this; // 새 폼의 오너를 현재 폼으로

            frm.Show(); // 새폼 보여 주 기
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            

            
            
        }
    }
}


       