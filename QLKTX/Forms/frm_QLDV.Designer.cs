
namespace QLKTX.Forms
{
    partial class frm_QLDV
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
            this.label18 = new System.Windows.Forms.Label();
            this.dtpToDate = new System.Windows.Forms.DateTimePicker();
            this.label19 = new System.Windows.Forms.Label();
            this.dtpFromDate = new System.Windows.Forms.DateTimePicker();
            this.rtbNote = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbbService = new System.Windows.Forms.ComboBox();
            this.tbStudentCode = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvService = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.tbDescService = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbPriceService = new System.Windows.Forms.TextBox();
            this.tbNameService = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDelService = new System.Windows.Forms.Button();
            this.btnUpdateService = new System.Windows.Forms.Button();
            this.btnAddService = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dgvSumarySvc = new System.Windows.Forms.DataGridView();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.tbStudentCode3 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnShow = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvService)).BeginInit();
            this.panel1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSumarySvc)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label18);
            this.tabPage1.Controls.Add(this.dtpToDate);
            this.tabPage1.Controls.Add(this.label19);
            this.tabPage1.Controls.Add(this.dtpFromDate);
            this.tabPage1.Controls.Add(this.rtbNote);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.cbbService);
            this.tabPage1.Controls.Add(this.tbStudentCode);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.btnSave);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 417);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Sử dụng dịch vụ";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(127, 250);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(36, 20);
            this.label18.TabIndex = 16;
            this.label18.Text = "Đến";
            // 
            // dtpToDate
            // 
            this.dtpToDate.CustomFormat = "HH:mm dd/MM/yyyy";
            this.dtpToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpToDate.Location = new System.Drawing.Point(55, 299);
            this.dtpToDate.Name = "dtpToDate";
            this.dtpToDate.Size = new System.Drawing.Size(210, 27);
            this.dtpToDate.TabIndex = 15;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(127, 156);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(26, 20);
            this.label19.TabIndex = 14;
            this.label19.Text = "Từ";
            // 
            // dtpFromDate
            // 
            this.dtpFromDate.CustomFormat = "HH:mm dd/MM/yyyy";
            this.dtpFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFromDate.Location = new System.Drawing.Point(55, 204);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.Size = new System.Drawing.Size(210, 27);
            this.dtpFromDate.TabIndex = 13;
            // 
            // rtbNote
            // 
            this.rtbNote.Location = new System.Drawing.Point(503, 91);
            this.rtbNote.Name = "rtbNote";
            this.rtbNote.Size = new System.Drawing.Size(265, 179);
            this.rtbNote.TabIndex = 6;
            this.rtbNote.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(598, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Ghi chú";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(285, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Mã sinh viên";
            // 
            // cbbService
            // 
            this.cbbService.FormattingEnabled = true;
            this.cbbService.Location = new System.Drawing.Point(27, 91);
            this.cbbService.Name = "cbbService";
            this.cbbService.Size = new System.Drawing.Size(180, 28);
            this.cbbService.TabIndex = 3;
            // 
            // tbStudentCode
            // 
            this.tbStudentCode.Location = new System.Drawing.Point(265, 91);
            this.tbStudentCode.Name = "tbStudentCode";
            this.tbStudentCode.Size = new System.Drawing.Size(180, 27);
            this.tbStudentCode.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Loại dịch vụ";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(552, 319);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(165, 61);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Lưu thông tin";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 417);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Quản lí dịch vụ";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvService);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(536, 411);
            this.panel2.TabIndex = 1;
            // 
            // dgvService
            // 
            this.dgvService.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvService.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvService.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvService.Location = new System.Drawing.Point(0, 0);
            this.dgvService.Name = "dgvService";
            this.dgvService.RowHeadersWidth = 51;
            this.dgvService.RowTemplate.Height = 29;
            this.dgvService.Size = new System.Drawing.Size(536, 411);
            this.dgvService.TabIndex = 0;
            this.dgvService.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvService_CellClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.tbDescService);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tbPriceService);
            this.panel1.Controls.Add(this.tbNameService);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnDelService);
            this.panel1.Controls.Add(this.btnUpdateService);
            this.panel1.Controls.Add(this.btnAddService);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(539, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 411);
            this.panel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Mô tả";
            // 
            // tbDescService
            // 
            this.tbDescService.Location = new System.Drawing.Point(6, 112);
            this.tbDescService.Name = "tbDescService";
            this.tbDescService.Size = new System.Drawing.Size(238, 27);
            this.tbDescService.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Giá tiền";
            // 
            // tbPriceService
            // 
            this.tbPriceService.Location = new System.Drawing.Point(6, 181);
            this.tbPriceService.Name = "tbPriceService";
            this.tbPriceService.Size = new System.Drawing.Size(238, 27);
            this.tbPriceService.TabIndex = 5;
            // 
            // tbNameService
            // 
            this.tbNameService.Location = new System.Drawing.Point(6, 44);
            this.tbNameService.Name = "tbNameService";
            this.tbNameService.Size = new System.Drawing.Size(239, 27);
            this.tbNameService.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tên dịch vụ";
            // 
            // btnDelService
            // 
            this.btnDelService.Location = new System.Drawing.Point(53, 365);
            this.btnDelService.Name = "btnDelService";
            this.btnDelService.Size = new System.Drawing.Size(163, 42);
            this.btnDelService.TabIndex = 2;
            this.btnDelService.Text = "Xóa";
            this.btnDelService.UseVisualStyleBackColor = true;
            this.btnDelService.Click += new System.EventHandler(this.btnDelService_Click);
            // 
            // btnUpdateService
            // 
            this.btnUpdateService.Location = new System.Drawing.Point(53, 301);
            this.btnUpdateService.Name = "btnUpdateService";
            this.btnUpdateService.Size = new System.Drawing.Size(163, 42);
            this.btnUpdateService.TabIndex = 1;
            this.btnUpdateService.Text = "Cập nhật";
            this.btnUpdateService.UseVisualStyleBackColor = true;
            this.btnUpdateService.Click += new System.EventHandler(this.btnUpdateService_Click);
            // 
            // btnAddService
            // 
            this.btnAddService.Location = new System.Drawing.Point(53, 240);
            this.btnAddService.Name = "btnAddService";
            this.btnAddService.Size = new System.Drawing.Size(163, 42);
            this.btnAddService.TabIndex = 0;
            this.btnAddService.Text = "Thêm";
            this.btnAddService.UseVisualStyleBackColor = true;
            this.btnAddService.Click += new System.EventHandler(this.btnAddService_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.panel4);
            this.tabPage3.Controls.Add(this.panel3);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(792, 417);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Thống kê sinh viên dùng DV";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dgvSumarySvc);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 70);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(792, 347);
            this.panel4.TabIndex = 1;
            // 
            // dgvSumarySvc
            // 
            this.dgvSumarySvc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSumarySvc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSumarySvc.Location = new System.Drawing.Point(0, 0);
            this.dgvSumarySvc.Name = "dgvSumarySvc";
            this.dgvSumarySvc.RowHeadersWidth = 51;
            this.dgvSumarySvc.RowTemplate.Height = 29;
            this.dgvSumarySvc.Size = new System.Drawing.Size(792, 284);
            this.dgvSumarySvc.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 284);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(792, 63);
            this.panel5.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.dtpEndDate);
            this.panel3.Controls.Add(this.dtpStartDate);
            this.panel3.Controls.Add(this.tbStudentCode3);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.btnShow);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(792, 70);
            this.panel3.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(393, 2);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 20);
            this.label9.TabIndex = 6;
            this.label9.Text = "Đến";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(203, 7);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 20);
            this.label8.TabIndex = 5;
            this.label8.Text = "Từ";
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEndDate.Location = new System.Drawing.Point(393, 25);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(128, 27);
            this.dtpEndDate.TabIndex = 4;
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStartDate.Location = new System.Drawing.Point(203, 28);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(128, 27);
            this.dtpStartDate.TabIndex = 3;
            // 
            // tbStudentCode3
            // 
            this.tbStudentCode3.Location = new System.Drawing.Point(8, 27);
            this.tbStudentCode3.Name = "tbStudentCode3";
            this.tbStudentCode3.Size = new System.Drawing.Size(125, 27);
            this.tbStudentCode3.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 4);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 20);
            this.label7.TabIndex = 1;
            this.label7.Text = "Mã sinh viên";
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(632, 7);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(135, 48);
            this.btnShow.TabIndex = 0;
            this.btnShow.Text = "Thống kê";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // frm_QLDV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "frm_QLDV";
            this.Text = "frm_QLDV";
            this.Load += new System.EventHandler(this.frm_QLDV_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvService)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSumarySvc)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvService;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbDescService;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbPriceService;
        private System.Windows.Forms.TextBox tbNameService;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDelService;
        private System.Windows.Forms.Button btnUpdateService;
        private System.Windows.Forms.Button btnAddService;
        private System.Windows.Forms.RichTextBox rtbNote;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbbService;
        private System.Windows.Forms.TextBox tbStudentCode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.DateTimePicker dtpToDate;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.DateTimePicker dtpFromDate;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dgvSumarySvc;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.TextBox tbStudentCode3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnShow;
    }
}