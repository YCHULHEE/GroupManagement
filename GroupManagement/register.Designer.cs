namespace GroupManagement
{
    partial class Register
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.major = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupNumber = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radiob2 = new System.Windows.Forms.RadioButton();
            this.radiob1 = new System.Windows.Forms.RadioButton();
            this.phoneNumber = new System.Windows.Forms.TextBox();
            this.birthDate = new System.Windows.Forms.TextBox();
            this.studentId = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.major);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.groupNumber);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.phoneNumber);
            this.groupBox1.Controls.Add(this.birthDate);
            this.groupBox1.Controls.Add(this.studentId);
            this.groupBox1.Controls.Add(this.name);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(630, 340);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "회원정보";
            this.groupBox1.Enter += new System.EventHandler(this.GroupBox1_Enter);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("나눔고딕", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.Location = new System.Drawing.Point(125, 151);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "학번 중복 안됩니다.";
            this.label8.Click += new System.EventHandler(this.Label8_Click);
            // 
            // major
            // 
            this.major.Location = new System.Drawing.Point(128, 171);
            this.major.Name = "major";
            this.major.Size = new System.Drawing.Size(150, 26);
            this.major.TabIndex = 21;
            this.major.TextChanged += new System.EventHandler(this.TextBox5_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(58, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 19);
            this.label5.TabIndex = 20;
            this.label5.Text = "학과";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(501, 267);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(78, 27);
            this.button2.TabIndex = 19;
            this.button2.Text = "돌아가기";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(398, 267);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(78, 27);
            this.button1.TabIndex = 18;
            this.button1.Text = "등록";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // groupNumber
            // 
            this.groupNumber.Location = new System.Drawing.Point(438, 171);
            this.groupNumber.Name = "groupNumber";
            this.groupNumber.Size = new System.Drawing.Size(150, 26);
            this.groupNumber.TabIndex = 17;
            this.groupNumber.TextChanged += new System.EventHandler(this.TextBox3_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(368, 174);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 19);
            this.label7.TabIndex = 13;
            this.label7.Text = "기수";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(368, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "성별";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radiob2);
            this.groupBox2.Controls.Add(this.radiob1);
            this.groupBox2.Location = new System.Drawing.Point(438, 61);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(150, 37);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Enter += new System.EventHandler(this.GroupBox2_Enter);
            // 
            // radiob2
            // 
            this.radiob2.AutoSize = true;
            this.radiob2.Location = new System.Drawing.Point(87, 12);
            this.radiob2.Name = "radiob2";
            this.radiob2.Size = new System.Drawing.Size(57, 23);
            this.radiob2.TabIndex = 1;
            this.radiob2.TabStop = true;
            this.radiob2.Text = "여성";
            this.radiob2.UseVisualStyleBackColor = true;
            this.radiob2.CheckedChanged += new System.EventHandler(this.RadioButton2_CheckedChanged);
            // 
            // radiob1
            // 
            this.radiob1.AutoSize = true;
            this.radiob1.Location = new System.Drawing.Point(15, 12);
            this.radiob1.Name = "radiob1";
            this.radiob1.Size = new System.Drawing.Size(57, 23);
            this.radiob1.TabIndex = 0;
            this.radiob1.TabStop = true;
            this.radiob1.Text = "남성";
            this.radiob1.UseVisualStyleBackColor = true;
            this.radiob1.CheckedChanged += new System.EventHandler(this.RadioButton1_CheckedChanged_1);
            // 
            // phoneNumber
            // 
            this.phoneNumber.Location = new System.Drawing.Point(438, 122);
            this.phoneNumber.Name = "phoneNumber";
            this.phoneNumber.Size = new System.Drawing.Size(150, 26);
            this.phoneNumber.TabIndex = 11;
            this.phoneNumber.TextChanged += new System.EventHandler(this.TextBox6_TextChanged);
            // 
            // birthDate
            // 
            this.birthDate.Location = new System.Drawing.Point(128, 222);
            this.birthDate.Name = "birthDate";
            this.birthDate.Size = new System.Drawing.Size(150, 26);
            this.birthDate.TabIndex = 9;
            // 
            // studentId
            // 
            this.studentId.Location = new System.Drawing.Point(128, 122);
            this.studentId.Name = "studentId";
            this.studentId.Size = new System.Drawing.Size(150, 26);
            this.studentId.TabIndex = 7;
            this.studentId.TextChanged += new System.EventHandler(this.StudentId_TextChanged);
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(128, 72);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(150, 26);
            this.name.TabIndex = 6;
            this.name.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(368, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 19);
            this.label6.TabIndex = 5;
            this.label6.Text = "전화번호";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "생년월일";
            this.label4.Click += new System.EventHandler(this.Label4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "학번";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "이름";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 371);
            this.Controls.Add(this.groupBox1);
            this.Name = "Register";
            this.Text = "회원등록";
            this.Load += new System.EventHandler(this.Register_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox phoneNumber;
        private System.Windows.Forms.TextBox birthDate;
        private System.Windows.Forms.TextBox studentId;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radiob1;
        private System.Windows.Forms.RadioButton radiob2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox groupNumber;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox major;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
    }
}