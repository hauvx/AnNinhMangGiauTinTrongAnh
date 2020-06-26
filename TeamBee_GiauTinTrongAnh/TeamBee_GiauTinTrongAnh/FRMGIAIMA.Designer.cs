namespace TeamBee_GiauTinTrongAnh
{
    partial class FRMGIAIMA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRMGIAIMA));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mENUToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cHỌNẢNHToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tHOÁTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TXTMATKHẨU = new System.Windows.Forms.TextBox();
            this.TXTTHONGTIN = new System.Windows.Forms.TextBox();
            this.BTNGIAIMA = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ANHGIAIMA = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ANHGIAIMA)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mENUToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(718, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mENUToolStripMenuItem
            // 
            this.mENUToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cHỌNẢNHToolStripMenuItem,
            this.tHOÁTToolStripMenuItem});
            this.mENUToolStripMenuItem.Name = "mENUToolStripMenuItem";
            this.mENUToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F4)));
            this.mENUToolStripMenuItem.Size = new System.Drawing.Size(63, 24);
            this.mENUToolStripMenuItem.Text = "MENU";
            // 
            // cHỌNẢNHToolStripMenuItem
            // 
            this.cHỌNẢNHToolStripMenuItem.Name = "cHỌNẢNHToolStripMenuItem";
            this.cHỌNẢNHToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.cHỌNẢNHToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.cHỌNẢNHToolStripMenuItem.Text = "CHỌN ẢNH";
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
            this.label1.Location = new System.Drawing.Point(68, 552);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "MẬT KHẨU";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 629);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "THÔNG TIN";
            // 
            // TXTMATKHẨU
            // 
            this.TXTMATKHẨU.Location = new System.Drawing.Point(159, 552);
            this.TXTMATKHẨU.Name = "TXTMATKHẨU";
            this.TXTMATKHẨU.PasswordChar = '*';
            this.TXTMATKHẨU.Size = new System.Drawing.Size(480, 22);
            this.TXTMATKHẨU.TabIndex = 3;
            // 
            // TXTTHONGTIN
            // 
            this.TXTTHONGTIN.Location = new System.Drawing.Point(159, 605);
            this.TXTTHONGTIN.Multiline = true;
            this.TXTTHONGTIN.Name = "TXTTHONGTIN";
            this.TXTTHONGTIN.Size = new System.Drawing.Size(480, 64);
            this.TXTTHONGTIN.TabIndex = 3;
            // 
            // BTNGIAIMA
            // 
            this.BTNGIAIMA.Location = new System.Drawing.Point(268, 691);
            this.BTNGIAIMA.Name = "BTNGIAIMA";
            this.BTNGIAIMA.Size = new System.Drawing.Size(172, 23);
            this.BTNGIAIMA.TabIndex = 4;
            this.BTNGIAIMA.Text = "GIẢI MÃ ẢNH";
            this.BTNGIAIMA.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ANHGIAIMA);
            this.groupBox1.Location = new System.Drawing.Point(35, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(641, 488);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ẢNH CHỨA THÔNG TIN";
            // 
            // ANHGIAIMA
            // 
            this.ANHGIAIMA.Location = new System.Drawing.Point(6, 21);
            this.ANHGIAIMA.Name = "ANHGIAIMA";
            this.ANHGIAIMA.Size = new System.Drawing.Size(629, 461);
            this.ANHGIAIMA.TabIndex = 2;
            this.ANHGIAIMA.TabStop = false;
            // 
            // FRMGIAIMA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 726);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BTNGIAIMA);
            this.Controls.Add(this.TXTTHONGTIN);
            this.Controls.Add(this.TXTMATKHẨU);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FRMGIAIMA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GIẢI MÃ ẢNH";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FRMGIAIMA_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ANHGIAIMA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mENUToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cHỌNẢNHToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tHOÁTToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TXTMATKHẨU;
        private System.Windows.Forms.TextBox TXTTHONGTIN;
        private System.Windows.Forms.Button BTNGIAIMA;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox ANHGIAIMA;
    }
}