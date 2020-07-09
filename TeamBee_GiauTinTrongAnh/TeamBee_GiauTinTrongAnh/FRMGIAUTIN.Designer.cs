namespace TeamBee_GiauTinTrongAnh
{
    partial class FRMGIAUTIN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRMGIAUTIN));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cHỌNẢNHToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tHOÁTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BTNGIAUTIN = new System.Windows.Forms.Button();
            this.TXTTHONGTIN = new System.Windows.Forms.TextBox();
            this.TXTMATKHAU = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ANHTRUOC = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ANHSAU = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ANHTRUOC)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ANHSAU)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1478, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cHỌNẢNHToolStripMenuItem,
            this.tHOÁTToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(63, 24);
            this.toolStripMenuItem1.Text = "MENU";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // cHỌNẢNHToolStripMenuItem
            // 
            this.cHỌNẢNHToolStripMenuItem.Name = "cHỌNẢNHToolStripMenuItem";
            this.cHỌNẢNHToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.cHỌNẢNHToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.cHỌNẢNHToolStripMenuItem.Text = "CHỌN ẢNH";
            this.cHỌNẢNHToolStripMenuItem.Click += new System.EventHandler(this.cHỌNẢNHToolStripMenuItem_Click);
            // 
            // tHOÁTToolStripMenuItem
            // 
            this.tHOÁTToolStripMenuItem.Name = "tHOÁTToolStripMenuItem";
            this.tHOÁTToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F4)));
            this.tHOÁTToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.tHOÁTToolStripMenuItem.Text = "THOÁT";
            this.tHOÁTToolStripMenuItem.Click += new System.EventHandler(this.tHOÁTToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 712);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "THÔNG TIN CẦN GIẤU";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 801);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "MẬT KHẨU";
            // 
            // BTNGIAUTIN
            // 
            this.BTNGIAUTIN.Location = new System.Drawing.Point(1169, 726);
            this.BTNGIAUTIN.Name = "BTNGIAUTIN";
            this.BTNGIAUTIN.Size = new System.Drawing.Size(193, 61);
            this.BTNGIAUTIN.TabIndex = 3;
            this.BTNGIAUTIN.Text = "GIẤU TIN";
            this.BTNGIAUTIN.UseVisualStyleBackColor = true;
            this.BTNGIAUTIN.Click += new System.EventHandler(this.BTNGIAUTIN_Click);
            // 
            // TXTTHONGTIN
            // 
            this.TXTTHONGTIN.Location = new System.Drawing.Point(282, 690);
            this.TXTTHONGTIN.Multiline = true;
            this.TXTTHONGTIN.Name = "TXTTHONGTIN";
            this.TXTTHONGTIN.Size = new System.Drawing.Size(784, 72);
            this.TXTTHONGTIN.TabIndex = 1;
            // 
            // TXTMATKHAU
            // 
            this.TXTMATKHAU.Location = new System.Drawing.Point(282, 801);
            this.TXTMATKHAU.Multiline = true;
            this.TXTMATKHAU.Name = "TXTMATKHAU";
            this.TXTMATKHAU.PasswordChar = '*';
            this.TXTMATKHAU.Size = new System.Drawing.Size(784, 34);
            this.TXTMATKHAU.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(168, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 17);
            this.label3.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ANHTRUOC);
            this.groupBox1.Location = new System.Drawing.Point(12, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(683, 618);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ẢNH TRƯỚC KHI GIẤU TIN";
            // 
            // ANHTRUOC
            // 
            this.ANHTRUOC.Location = new System.Drawing.Point(10, 21);
            this.ANHTRUOC.Name = "ANHTRUOC";
            this.ANHTRUOC.Size = new System.Drawing.Size(667, 587);
            this.ANHTRUOC.TabIndex = 2;
            this.ANHTRUOC.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ANHSAU);
            this.groupBox2.Location = new System.Drawing.Point(748, 52);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(683, 618);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ẢNH SAU KHI GIẤU TIN";
            // 
            // ANHSAU
            // 
            this.ANHSAU.Location = new System.Drawing.Point(10, 21);
            this.ANHSAU.Name = "ANHSAU";
            this.ANHSAU.Size = new System.Drawing.Size(667, 587);
            this.ANHSAU.TabIndex = 2;
            this.ANHSAU.TabStop = false;
            // 
            // FRMGIAUTIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1478, 914);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TXTMATKHAU);
            this.Controls.Add(this.TXTTHONGTIN);
            this.Controls.Add(this.BTNGIAUTIN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FRMGIAUTIN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GIẤU TIN TRONG ẢNH";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FRMGIAUTIN_FormClosing);
            this.Load += new System.EventHandler(this.FRMGIAUTIN_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ANHTRUOC)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ANHSAU)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cHỌNẢNHToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tHOÁTToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BTNGIAUTIN;
        private System.Windows.Forms.TextBox TXTTHONGTIN;
        private System.Windows.Forms.TextBox TXTMATKHAU;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox ANHTRUOC;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox ANHSAU;
    }
}