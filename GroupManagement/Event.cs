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


namespace GroupManagement
{
    public partial class Event : Form
    {
        SQLiteConnection conn;
        SQLiteCommand cmd;
        SQLiteDataAdapter da;
        DataSet ds;
        DataTable dt;

        public Event()
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
            LoadButton2_Click(null, null); //전체조회 이벤트
        }
        private void ToolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void ToolStripButton1_Click(object sender, EventArgs e)
        {
            this.Visible = false; // 현재 폼 안보이게 하기

            EventReg frm = new EventReg(); // 새 폼 생성

            frm.Owner = this; // 새 폼의 오너를 현재 폼으로

            frm.Show(); // 새폼 보여 주 기
        }

        private void DataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Delete_Click(object sender, EventArgs e)
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

                    string sql = "UPDATE EVENT_DB"
                                    + " SET name= '" + dtChanges.Rows[i][1].ToString() + "'"
                                    + ", student= '" + dtChanges.Rows[i][2].ToString() + "'"
                                    + ", feeDate= '" + dtChanges.Rows[i][3].ToString() + "'"
                                    + ", contentDate= '" + dtChanges.Rows[i][4].ToString() + "'" +
                                    "WHERE orderNumber= '" + dtChanges.Rows[i][0].ToString() + "'";

                    Debug.WriteLine(sql);
                    cmd.CommandText = sql;
                    cmd.ExecuteNonQuery();
                }
            }
            // conn.Close();
            dtChanges = null;
            LoadButton2_Click(null, null);

        }

        private void LoadButton2_Click(object sender, EventArgs e)
        {
            cmd.CommandText = "SELECT orderNumber '번호', name '이름', studentId '학번', feeDate '회비여부', contentDate '내용' FROM EVENT_DB";

            SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView2.DataSource = dt.DefaultView;
            
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
            cmd.CommandText = "SELECT orderNumber '번호', name '이름', studentId '학번', feeDate '회비여부', contentDate '내용' FROM EVENT_DB WHERE name LIKE " + search;

            SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView2.DataSource = dt.DefaultView;
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

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Visible = false; // 현재 폼 안보이게 하기

            Main frm = new Main(); // 새 폼 생성

            frm.Owner = this; // 새 폼의 오너를 현재 폼으로

            frm.Show(); // 새폼 보여 주 기
        }
    }
    }
