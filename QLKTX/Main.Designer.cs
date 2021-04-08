
namespace QLKTX
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnQLSV = new System.Windows.Forms.Button();
            this.btnQLTN = new System.Windows.Forms.Button();
            this.btnQLP = new System.Windows.Forms.Button();
            this.btnQLDV = new System.Windows.Forms.Button();
            this.btnQLGX = new System.Windows.Forms.Button();
            this.panelBtn = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.panelBtn.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnQLSV
            // 
            this.btnQLSV.Location = new System.Drawing.Point(0, 200);
            this.btnQLSV.Name = "btnQLSV";
            this.btnQLSV.Size = new System.Drawing.Size(206, 64);
            this.btnQLSV.TabIndex = 0;
            this.btnQLSV.Text = "Quản lý sinh viên";
            this.btnQLSV.UseVisualStyleBackColor = true;
            this.btnQLSV.Click += new System.EventHandler(this.btnQLSV_Click);
            // 
            // btnQLTN
            // 
            this.btnQLTN.Location = new System.Drawing.Point(0, 340);
            this.btnQLTN.Name = "btnQLTN";
            this.btnQLTN.Size = new System.Drawing.Size(206, 64);
            this.btnQLTN.TabIndex = 1;
            this.btnQLTN.Text = "Quản lý tòa nhà";
            this.btnQLTN.UseVisualStyleBackColor = true;
            this.btnQLTN.Click += new System.EventHandler(this.btnQLTN_Click);
            // 
            // btnQLP
            // 
            this.btnQLP.Location = new System.Drawing.Point(0, 270);
            this.btnQLP.Name = "btnQLP";
            this.btnQLP.Size = new System.Drawing.Size(206, 64);
            this.btnQLP.TabIndex = 2;
            this.btnQLP.Text = "Quản lý phòng";
            this.btnQLP.UseVisualStyleBackColor = true;
            this.btnQLP.Click += new System.EventHandler(this.btnQLP_Click);
            // 
            // btnQLDV
            // 
            this.btnQLDV.Location = new System.Drawing.Point(0, 410);
            this.btnQLDV.Name = "btnQLDV";
            this.btnQLDV.Size = new System.Drawing.Size(206, 64);
            this.btnQLDV.TabIndex = 3;
            this.btnQLDV.Text = "Quản lý dịch vụ";
            this.btnQLDV.UseVisualStyleBackColor = true;
            this.btnQLDV.Click += new System.EventHandler(this.btnQLDV_Click);
            // 
            // btnQLGX
            // 
            this.btnQLGX.Location = new System.Drawing.Point(0, 480);
            this.btnQLGX.Name = "btnQLGX";
            this.btnQLGX.Size = new System.Drawing.Size(206, 64);
            this.btnQLGX.TabIndex = 4;
            this.btnQLGX.Text = "Quản lý gửi xe";
            this.btnQLGX.UseVisualStyleBackColor = true;
            this.btnQLGX.Click += new System.EventHandler(this.btnQLGX_Click);
            // 
            // panelBtn
            // 
            this.panelBtn.Controls.Add(this.btnQLSV);
            this.panelBtn.Controls.Add(this.btnQLGX);
            this.panelBtn.Controls.Add(this.panel2);
            this.panelBtn.Controls.Add(this.btnQLP);
            this.panelBtn.Controls.Add(this.btnQLDV);
            this.panelBtn.Controls.Add(this.btnQLTN);
            this.panelBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelBtn.Location = new System.Drawing.Point(0, 0);
            this.panelBtn.Name = "panelBtn";
            this.panelBtn.Size = new System.Drawing.Size(206, 553);
            this.panelBtn.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(206, 194);
            this.panel2.TabIndex = 0;
            // 
            // panelDesktop
            // 
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(206, 0);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(776, 553);
            this.panelDesktop.TabIndex = 6;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 553);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Main";
            this.Text = "Quản lý kí túc xá";
            this.Load += new System.EventHandler(this.Main_Load);
            this.panelBtn.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnQLSV;
        private System.Windows.Forms.Button btnQLTN;
        private System.Windows.Forms.Button btnQLP;
        private System.Windows.Forms.Button btnQLDV;
        private System.Windows.Forms.Button btnQLGX;
        private System.Windows.Forms.Panel panelBtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelDesktop;
    }
}

