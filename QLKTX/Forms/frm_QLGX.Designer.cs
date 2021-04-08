
namespace QLKTX.Forms
{
    partial class frm_QLGX
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cbMonthlyTicket = new System.Windows.Forms.CheckBox();
            this.btnOut = new System.Windows.Forms.Button();
            this.rtbNote = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbStudentCode4 = new System.Windows.Forms.TextBox();
            this.btnIn = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvTicket = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnDelTicket = new System.Windows.Forms.Button();
            this.btnUpdateTicket = new System.Windows.Forms.Button();
            this.btnAddTicket = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpToDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpFromDate = new System.Windows.Forms.DateTimePicker();
            this.tbNoteTicket = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbStudentCode1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbActiveTicket = new System.Windows.Forms.CheckBox();
            this.tbStudentCode = new System.Windows.Forms.TextBox();
            this.btnSearchTicket = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTicket)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.cbMonthlyTicket);
            this.tabPage1.Controls.Add(this.btnOut);
            this.tabPage1.Controls.Add(this.rtbNote);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.tbStudentCode4);
            this.tabPage1.Controls.Add(this.btnIn);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 417);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Quản lý xe ra vào";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // cbMonthlyTicket
            // 
            this.cbMonthlyTicket.AutoSize = true;
            this.cbMonthlyTicket.Location = new System.Drawing.Point(65, 220);
            this.cbMonthlyTicket.Name = "cbMonthlyTicket";
            this.cbMonthlyTicket.Size = new System.Drawing.Size(89, 24);
            this.cbMonthlyTicket.TabIndex = 25;
            this.cbMonthlyTicket.Text = "Vé tháng";
            this.cbMonthlyTicket.UseVisualStyleBackColor = true;
            // 
            // btnOut
            // 
            this.btnOut.Location = new System.Drawing.Point(415, 313);
            this.btnOut.Name = "btnOut";
            this.btnOut.Size = new System.Drawing.Size(165, 61);
            this.btnOut.TabIndex = 24;
            this.btnOut.Text = "Xe ra";
            this.btnOut.UseVisualStyleBackColor = true;
            this.btnOut.Click += new System.EventHandler(this.btnOut_Click);
            // 
            // rtbNote
            // 
            this.rtbNote.Location = new System.Drawing.Point(385, 79);
            this.rtbNote.Name = "rtbNote";
            this.rtbNote.Size = new System.Drawing.Size(265, 179);
            this.rtbNote.TabIndex = 23;
            this.rtbNote.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(480, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 20);
            this.label6.TabIndex = 22;
            this.label6.Text = "Ghi chú";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(65, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(235, 20);
            this.label7.TabIndex = 21;
            this.label7.Text = "Mã sinh viên ( Nếu dùng vé tháng)";
            // 
            // tbStudentCode4
            // 
            this.tbStudentCode4.Location = new System.Drawing.Point(65, 115);
            this.tbStudentCode4.Name = "tbStudentCode4";
            this.tbStudentCode4.Size = new System.Drawing.Size(235, 27);
            this.tbStudentCode4.TabIndex = 19;
            // 
            // btnIn
            // 
            this.btnIn.Location = new System.Drawing.Point(96, 313);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(165, 61);
            this.btnIn.TabIndex = 17;
            this.btnIn.Text = "Xe vào";
            this.btnIn.UseVisualStyleBackColor = true;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel3);
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 417);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Quản lý vé tháng";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgvTicket);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 51);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(536, 363);
            this.panel3.TabIndex = 2;
            // 
            // dgvTicket
            // 
            this.dgvTicket.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTicket.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTicket.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTicket.Location = new System.Drawing.Point(0, 0);
            this.dgvTicket.Name = "dgvTicket";
            this.dgvTicket.RowHeadersWidth = 51;
            this.dgvTicket.RowTemplate.Height = 29;
            this.dgvTicket.Size = new System.Drawing.Size(536, 363);
            this.dgvTicket.TabIndex = 0;
            this.dgvTicket.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTicket_CellClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnDelTicket);
            this.panel2.Controls.Add(this.btnUpdateTicket);
            this.panel2.Controls.Add(this.btnAddTicket);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.dtpToDate);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.dtpFromDate);
            this.panel2.Controls.Add(this.tbNoteTicket);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.tbStudentCode1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(539, 51);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(250, 363);
            this.panel2.TabIndex = 1;
            // 
            // btnDelTicket
            // 
            this.btnDelTicket.Location = new System.Drawing.Point(78, 318);
            this.btnDelTicket.Name = "btnDelTicket";
            this.btnDelTicket.Size = new System.Drawing.Size(94, 29);
            this.btnDelTicket.TabIndex = 11;
            this.btnDelTicket.Text = "Xóa";
            this.btnDelTicket.UseVisualStyleBackColor = true;
            this.btnDelTicket.Click += new System.EventHandler(this.btnDelTicket_Click);
            // 
            // btnUpdateTicket
            // 
            this.btnUpdateTicket.Location = new System.Drawing.Point(125, 283);
            this.btnUpdateTicket.Name = "btnUpdateTicket";
            this.btnUpdateTicket.Size = new System.Drawing.Size(94, 29);
            this.btnUpdateTicket.TabIndex = 10;
            this.btnUpdateTicket.Text = "Sửa";
            this.btnUpdateTicket.UseVisualStyleBackColor = true;
            this.btnUpdateTicket.Click += new System.EventHandler(this.btnUpdateTicket_Click);
            // 
            // btnAddTicket
            // 
            this.btnAddTicket.Location = new System.Drawing.Point(25, 283);
            this.btnAddTicket.Name = "btnAddTicket";
            this.btnAddTicket.Size = new System.Drawing.Size(94, 29);
            this.btnAddTicket.TabIndex = 9;
            this.btnAddTicket.Text = "Thêm";
            this.btnAddTicket.UseVisualStyleBackColor = true;
            this.btnAddTicket.Click += new System.EventHandler(this.btnAddTicket_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Đến";
            // 
            // dtpToDate
            // 
            this.dtpToDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpToDate.Location = new System.Drawing.Point(18, 233);
            this.dtpToDate.Name = "dtpToDate";
            this.dtpToDate.Size = new System.Drawing.Size(210, 27);
            this.dtpToDate.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Từ";
            // 
            // dtpFromDate
            // 
            this.dtpFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFromDate.Location = new System.Drawing.Point(18, 166);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.Size = new System.Drawing.Size(210, 27);
            this.dtpFromDate.TabIndex = 5;
            // 
            // tbNoteTicket
            // 
            this.tbNoteTicket.Location = new System.Drawing.Point(18, 100);
            this.tbNoteTicket.Name = "tbNoteTicket";
            this.tbNoteTicket.Size = new System.Drawing.Size(210, 27);
            this.tbNoteTicket.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ghi chú";
            // 
            // tbStudentCode1
            // 
            this.tbStudentCode1.Location = new System.Drawing.Point(18, 35);
            this.tbStudentCode1.Name = "tbStudentCode1";
            this.tbStudentCode1.Size = new System.Drawing.Size(210, 27);
            this.tbStudentCode1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã sinh viên";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbActiveTicket);
            this.panel1.Controls.Add(this.tbStudentCode);
            this.panel1.Controls.Add(this.btnSearchTicket);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(786, 48);
            this.panel1.TabIndex = 0;
            // 
            // cbActiveTicket
            // 
            this.cbActiveTicket.AutoSize = true;
            this.cbActiveTicket.Location = new System.Drawing.Point(343, 13);
            this.cbActiveTicket.Name = "cbActiveTicket";
            this.cbActiveTicket.Size = new System.Drawing.Size(103, 24);
            this.cbActiveTicket.TabIndex = 5;
            this.cbActiveTicket.Text = "Vé hiệu lực";
            this.cbActiveTicket.UseVisualStyleBackColor = true;
            // 
            // tbStudentCode
            // 
            this.tbStudentCode.Location = new System.Drawing.Point(114, 14);
            this.tbStudentCode.Name = "tbStudentCode";
            this.tbStudentCode.Size = new System.Drawing.Size(125, 27);
            this.tbStudentCode.TabIndex = 4;
            // 
            // btnSearchTicket
            // 
            this.btnSearchTicket.Location = new System.Drawing.Point(569, 10);
            this.btnSearchTicket.Name = "btnSearchTicket";
            this.btnSearchTicket.Size = new System.Drawing.Size(94, 29);
            this.btnSearchTicket.TabIndex = 3;
            this.btnSearchTicket.Text = "Tìm kiếm";
            this.btnSearchTicket.UseVisualStyleBackColor = true;
            this.btnSearchTicket.Click += new System.EventHandler(this.btnSearchTicket_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã sinh viên";
            // 
            // frm_QLGX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "frm_QLGX";
            this.Text = "frm_QLGX";
            this.Load += new System.EventHandler(this.frm_QLGX_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTicket)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgvTicket;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox cbActiveTicket;
        private System.Windows.Forms.TextBox tbStudentCode;
        private System.Windows.Forms.Button btnSearchTicket;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDelTicket;
        private System.Windows.Forms.Button btnUpdateTicket;
        private System.Windows.Forms.Button btnAddTicket;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpToDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpFromDate;
        private System.Windows.Forms.TextBox tbNoteTicket;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox tbStudentCode1;
        private System.Windows.Forms.CheckBox cbMonthlyTicket;
        private System.Windows.Forms.Button btnOut;
        private System.Windows.Forms.RichTextBox rtbNote;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbStudentCode4;
        private System.Windows.Forms.Button btnIn;
    }
}