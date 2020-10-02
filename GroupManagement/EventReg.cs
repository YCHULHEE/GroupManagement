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
    public partial class EventReg : Form
    {
        static int orderNumber =1;
        public EventReg()
        {
            InitializeComponent();
        }

        private void RichTextBox1_TextChanged(object sender, EventArgs e)
        {









        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Visible = false; // 현재 폼 안보이게 하기

            Event frm = new Event(); // 새 폼 생성

            frm.Owner = this; // 새 폼의 오너를 현재 폼으로

            frm.Show(); // 새폼 보여 주 기
        }
        //등록버튼
        private void Button1_Click(object sender, EventArgs e)
        {
            string strConn = @"Data Source=D:\testdb.db";
            SQLiteConnection conn = new SQLiteConnection(strConn);
            SQLiteCommand cmd = new SQLiteCommand();

            conn.Open();

            cmd.CommandText = "INSERT INTO EVENT_DB(orderNumber, name, studentId, feeDate, contentDate) VALUES(@orderNumber, @name, @studentId, @feeDate, @contentDate)";

            // 텍스트파일 내장DB에 저장 
            cmd.Parameters.Add("@orderNumber", DbType.Int32).Value = orderNumber;
            cmd.Parameters.Add("@name", DbType.String).Value = name.Text;
            cmd.Parameters.Add("@studentId", DbType.String).Value = studentId.Text;
            cmd.Parameters.Add("@feeDate", DbType.String).Value = feeDate.Text;
            cmd.Parameters.Add("@contentDate", DbType.String).Value = contentDate.Text;
            cmd.Connection = conn;

            
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("등록완료", "종료", MessageBoxButtons.OK, MessageBoxIcon.None);
                orderNumber++;
                this.Visible = false; // 현재 폼 안보이게 하기
                Event frm = new Event(); // 새 폼 생성
                frm.Owner = this; // 새 폼의 오너를 현재 폼으로
                frm.Show(); // 새폼 보여 주 기
            }
            catch (Exception ex)
            {
                orderNumber++;
                MessageBox.Show("항목을 채워주세요.", "종료", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            finally
            {
                conn.Close();
                conn.Dispose();
            }
        }
    }
}
