namespace TeamBee_GiauTinTrongAnh
{
    partial class frmmenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmmenu));
            this.label1 = new System.Windows.Forms.Label();
            this.BTNGIAUTIN = new System.Windows.Forms.Button();
            this.BTNGIAIMA = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(24, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(477, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "AN NINH MẠNG GIẤU TIN TRONG ẢNH";
            // 
            // BTNGIAUTIN
            // 
            this.BTNGIAUTIN.Location = new System.Drawing.Point(90, 62);
            this.BTNGIAUTIN.Name = "BTNGIAUTIN";
            this.BTNGIAUTIN.Size = new System.Drawing.Size(128, 35);
            this.BTNGIAUTIN.TabIndex = 1;
            this.BTNGIAUTIN.Text = "GIẤU TIN";
            this.BTNGIAUTIN.UseVisualStyleBackColor = true;
            this.BTNGIAUTIN.Click += new System.EventHandler(this.BTNGIAUTIN_Click);
            // 
            // BTNGIAIMA
            // 
            this.BTNGIAIMA.Location = new System.Drawing.Point(283, 62);
            this.BTNGIAIMA.Name = "BTNGIAIMA";
            this.BTNGIAIMA.Size = new System.Drawing.Size(128, 35);
            this.BTNGIAIMA.TabIndex = 1;
            this.BTNGIAIMA.Text = "GIẢI MÃ ẢNH";
            this.BTNGIAIMA.UseVisualStyleBackColor = true;
            this.BTNGIAIMA.Click += new System.EventHandler(this.BTNGIAIMA_Click);
            // 
            // frmmenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 158);
            this.Controls.Add(this.BTNGIAIMA);
            this.Controls.Add(this.BTNGIAUTIN);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmmenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DEMO GIẤU TIN TRONG ẢNH";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BTNGIAUTIN;
        private System.Windows.Forms.Button BTNGIAIMA;
    }
}

