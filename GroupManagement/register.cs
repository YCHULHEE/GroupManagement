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
    public partial class Register : Form
    {
        
        public Register()
        {
            
            InitializeComponent();

        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void GroupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Visible = false; // 현재 폼 안보이게 하기

            Member frm = new Member(); // 새 폼 생성

            frm.Owner = this; // 새 폼의 오너를 현재 폼으로

            frm.Show(); // 새폼 보여 주 기
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        // 등록버튼
        private void Button1_Click(object sender, EventArgs e)
        {
            string strConn = @"Data Source=D:\testdb.db";
            SQLiteConnection conn = new SQLiteConnection(strConn);
            SQLiteCommand cmd = new SQLiteCommand();

            conn.Open();

            cmd.CommandText = "INSERT INTO INFO_TB(name, studentId, birthDate, phoneNumber, groupNumber, major, sex) VALUES(@name, @studentId, @birthDate, @phoneNumber, @groupNumber, @major, @sex)";

            // 텍스트파일 내장DB에 저장 
            cmd.Parameters.Add("@name", DbType.String).Value = name.Text;
            cmd.Parameters.Add("@studentId", DbType.String).Value = studentId.Text;
            cmd.Parameters.Add("@birthDate", DbType.String).Value = birthDate.Text;
            cmd.Parameters.Add("@phoneNumber", DbType.String).Value = phoneNumber.Text;
            cmd.Parameters.Add("@groupNumber", DbType.String).Value = groupNumber.Text;
            cmd.Parameters.Add("@major", DbType.String).Value = major.Text;
            
            // 라디오 버튼 선택
            if (radiob1.Checked)
                cmd.Parameters.Add("@sex", DbType.String).Value = radiob1.Text;
            else if(radiob2.Checked)
                cmd.Parameters.Add("@sex", DbType.String).Value = radiob2.Text;


            cmd.Connection = conn;

            
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("등록완료", "종료", MessageBoxButtons.OK, MessageBoxIcon.None);

                this.Visible = false; // 현재 폼 안보이게 하기
                Member frm = new Member(); // 새 폼 생성
                frm.Owner = this; // 새 폼의 오너를 현재 폼으로
                frm.Show(); // 새폼 보여 주 기
            }
            catch (Exception ex)
            {
                MessageBox.Show("항목을 채워주세요.", "종료", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            finally
            {
                conn.Close();
                conn.Dispose();
            }

            
        }

        private void StudentId_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void RadioButton1_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void Label8_Click(object sender, EventArgs e)
        {

        }
    }
}
