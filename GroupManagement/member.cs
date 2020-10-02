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
using System.Diagnostics;
using CoolSms; // nuget 설치후 추가

namespace GroupManagement
{
    public partial class Member : Form
    {
        SQLiteConnection conn;
        SQLiteCommand cmd;
        SQLiteDataAdapter da;
        DataSet ds;
        DataTable dt;



        public Member()
        {

            InitializeComponent();
            conn = new SQLiteConnection();
            cmd = new SQLiteCommand();

            conn.ConnectionString = @"Data Source=D:\testdb.db";

            conn.Open();
            cmd.Connection = conn;
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.Load += Form1_Load;


        }
        void Form1_Load(object sender, EventArgs e)
        {
            LoadButton_Click(null, null); //전체조회 이벤트
        }




        private void Member_Load(object sender, EventArgs e)
        {


        }
        private void ToolStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void ToolStripDropDownButton1_Click(object sender, EventArgs e)
        {

        }

        private void ToolStripDropDownButton1_Click_1(object sender, EventArgs e)
        {

        }

        private void ToolStripDropDownButton1_Click_2(object sender, EventArgs e)
        {
            this.Visible = false; // 현재 폼 안보이게 하기

            Register frm = new Register(); // 새 폼 생성

            frm.Owner = this; // 새 폼의 오너를 현재 폼으로


            frm.Show(); // 새폼 보여 주 기

        }

        private void ListView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ToolStripContainer1_TopToolStripPanel_Click_1(object sender, EventArgs e)
        {

        }

        private void ToolStripButton1_Click(object sender, EventArgs e)
        {
            this.Visible = false; // 현재 폼 안보이게 하기

            Register frm = new Register(); // 새 폼 생성

            frm.Owner = this; // 새 폼의 오너를 현재 폼으로


            frm.Show(); // 새폼 보여 주 기
        }

        private void ToolStripButton2_Click(object sender, EventArgs e)
        {
            string search = "\"%" + toolStripTextBox1.Text + "%\"";
            //SQL DB와 연결
            SQLiteConnection conn = new SQLiteConnection();
            conn.ConnectionString = @"Data Source=D:\testdb.db";
            conn.Open();


            //SQL 명령어
            SQLiteCommand cmd = new SQLiteCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT name '이름', studentId '학번', birthDate '생년월일', phoneNumber '전화번호', groupNumber '기수', major '전공', sex '성별' FROM INFO_TB WHERE name LIKE " + search;

            SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView2.DataSource = dt.DefaultView;



        }

        private void ToolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Visible = false; // 현재 폼 안보이게 하기

            Main frm = new Main(); // 새 폼 생성

            frm.Owner = this; // 새 폼의 오너를 현재 폼으로

            frm.Show(); // 새폼 보여 주 기
        }

        private void ToolStripButton3_Click(object sender, EventArgs e)
        {
            DataTable dtChanges;
            DataView dvScore = (DataView)dataGridView2.DataSource;
            //DataTable dtScore = (DataTable)dataGridView2.DataSource;

            dtChanges = dvScore.Table.GetChanges(DataRowState.Modified);
            if (dtChanges != null)
            {
                for (int i = 0; i < dtChanges.Rows.Count; i++)
                {

                    string sql = "UPDATE INFO_TB"
                                    + " SET name= '" + dtChanges.Rows[i][0].ToString() + "'"
                                    + ", birthDate= '" + dtChanges.Rows[i][2].ToString() + "'"
                                    + ", phoneNumber= '" + dtChanges.Rows[i][3].ToString() + "'"
                                    + ", groupNumber= '" + dtChanges.Rows[i][4].ToString() + "'"
                                    + ", major= '" + dtChanges.Rows[i][5].ToString() + "'" +
                                    "WHERE studentId= '" + dtChanges.Rows[i][1].ToString() + "'";

                    Debug.WriteLine(sql);
                    cmd.CommandText = sql;
                    cmd.ExecuteNonQuery();
                }
            }
            // conn.Close();
            dtChanges = null;
            LoadButton_Click(null, null);
        }

        private void DataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            cmd.CommandText = "SELECT name '이름', studentId '학번', birthDate '생년월일', phoneNumber '전화번호', groupNumber '기수', major '전공', sex '성별' FROM INFO_TB";

            SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView2.DataSource = dt.DefaultView;




        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Name_TextChanged(object sender, EventArgs e)
        {

        }

        private void DataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show("셀 위에는 누르지 마세요!", "종료", MessageBoxButtons.OK, MessageBoxIcon.None);
            }





        }

        private void Button3_Click(object sender, EventArgs e)
        {

        

        }

        private void Label4_Click_1(object sender, EventArgs e)
        {

        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void RichTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void DataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString();
            number2.Text = dataGridView2.Rows[e.RowIndex].Cells[3].Value.ToString();


        }

        private void ToolStripButton4_Click(object sender, EventArgs e)
        {
            DataTable dtChanges;
            DataView dvScore = (DataView)dataGridView2.DataSource;
            //DataTable dtScore = (DataTable)dataGridView2.DataSource;

            dtChanges = dvScore.Table.GetChanges(DataRowState.Modified);
            

                for (int i = 0; i < dataGridView2.Rows.Count - 1; i++)
                {

                    dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    if (dataGridView2.Rows[i].Selected == true)
                    {
                       
                            dataGridView2.Rows.Remove(dataGridView2.Rows[i]);
                        }
                    
                

            }
        }           

        private void Button2_Click(object sender, EventArgs e)
        {

            string number1 = number2.Text;
            string content1 = content2.Text;

            SmsApi api = new SmsApi(new SmsApiOptions
            {
               ApiKey = "NCS0X42JIWMM1KMA",
               ApiSecret = "SAVGX35RJAC5H67QKSGYPQKLJAYHUGCW",
                DefaultSenderId = "01064260470" // 문자 보내는 사람 번호, coolsms 홈페이지에서 발신자 등록한 번호 필수
           });



           void SendSMS(string number, string text)
           {
                var result = api.SendMessageAsync(number, text);
            }

            SendSMS(number1, content1);
            MessageBox.Show("전송완료", "종료", MessageBoxButtons.OK, MessageBoxIcon.None);
        }

            

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ToolStripLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
