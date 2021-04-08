
namespace QLKTX.Forms
{
    partial class frm_AddUser
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.tbUserEmail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbStudentCode = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbSchoolYear = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpBirthDay = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(251, 382);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 42);
            this.button1.TabIndex = 0;
            this.button1.Text = "Tạo mới";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên sinh viên";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tbUserName
            // 
            this.tbUserName.Location = new System.Drawing.Point(65, 76);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(212, 27);
            this.tbUserName.TabIndex = 2;
            this.tbUserName.TextChanged += new System.EventHandler(this.tbUserName_TextChanged);
            // 
            // tbUserEmail
            // 
            this.tbUserEmail.Location = new System.Drawing.Point(65, 148);
            this.tbUserEmail.Name = "tbUserEmail";
            this.tbUserEmail.Size = new System.Drawing.Size(212, 27);
            this.tbUserEmail.TabIndex = 4;
            this.tbUserEmail.TextChanged += new System.EventHandler(this.tbUserEmail_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Email";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // tbPhone
            // 
            this.tbPhone.Location = new System.Drawing.Point(65, 221);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(212, 27);
            this.tbPhone.TabIndex = 6;
            this.tbPhone.TextChanged += new System.EventHandler(this.tbPhone_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Số điện thoại";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // tbStudentCode
            // 
            this.tbStudentCode.Location = new System.Drawing.Point(364, 76);
            this.tbStudentCode.Name = "tbStudentCode";
            this.tbStudentCode.Size = new System.Drawing.Size(212, 27);
            this.tbStudentCode.TabIndex = 8;
            this.tbStudentCode.TextChanged += new System.EventHandler(this.tbStudentCode_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(364, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Mã sinh viên";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // tbAddress
            // 
            this.tbAddress.Location = new System.Drawing.Point(364, 148);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(212, 27);
            this.tbAddress.TabIndex = 10;
            this.tbAddress.TextChanged += new System.EventHandler(this.tbAddress_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(364, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Địa chỉ";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // tbSchoolYear
            // 
            this.tbSchoolYear.Location = new System.Drawing.Point(364, 221);
            this.tbSchoolYear.Name = "tbSchoolYear";
            this.tbSchoolYear.Size = new System.Drawing.Size(212, 27);
            this.tbSchoolYear.TabIndex = 12;
            this.tbSchoolYear.TextChanged += new System.EventHandler(this.tbSchoolYear_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(364, 198);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Khóa";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // dtpBirthDay
            // 
            this.dtpBirthDay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBirthDay.Location = new System.Drawing.Point(65, 302);
            this.dtpBirthDay.Name = "dtpBirthDay";
            this.dtpBirthDay.Size = new System.Drawing.Size(212, 27);
            this.dtpBirthDay.TabIndex = 13;
            this.dtpBirthDay.ValueChanged += new System.EventHandler(this.dtpBirthDay_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(65, 271);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(149, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Ngày tháng năm sinh";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(364, 271);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 20);
            this.label8.TabIndex = 15;
            this.label8.Text = "Giới tính";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Location = new System.Drawing.Point(364, 305);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(62, 24);
            this.rbMale.TabIndex = 16;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Nam";
            this.rbMale.UseVisualStyleBackColor = true;
            this.rbMale.CheckedChanged += new System.EventHandler(this.rbMale_CheckedChanged);
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Location = new System.Drawing.Point(499, 305);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(50, 24);
            this.rbFemale.TabIndex = 17;
            this.rbFemale.TabStop = true;
            this.rbFemale.Text = "Nữ";
            this.rbFemale.UseVisualStyleBackColor = true;
            this.rbFemale.CheckedChanged += new System.EventHandler(this.rbFemale_CheckedChanged);
            // 
            // frm_AddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 453);
            this.Controls.Add(this.rbFemale);
            this.Controls.Add(this.rbMale);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtpBirthDay);
            this.Controls.Add(this.tbSchoolYear);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbAddress);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbStudentCode);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbPhone);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbUserEmail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbUserName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "frm_AddUser";
            this.Text = "Thêm mới sinh viên";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbUserName;
        private System.Windows.Forms.TextBox tbUserEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbStudentCode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbSchoolYear;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpBirthDay;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.RadioButton rbFemale;
    }
}