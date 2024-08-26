namespace DUAN1_CS
{
    partial class form_doimk
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
            this.doimt_bt = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.mkc_ip = new System.Windows.Forms.TextBox();
            this.mkm_ip = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // doimt_bt
            // 
            this.doimt_bt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.doimt_bt.BackColor = System.Drawing.Color.LightSlateGray;
            this.doimt_bt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.doimt_bt.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.doimt_bt.Location = new System.Drawing.Point(230, 451);
            this.doimt_bt.Name = "doimt_bt";
            this.doimt_bt.Size = new System.Drawing.Size(198, 60);
            this.doimt_bt.TabIndex = 0;
            this.doimt_bt.Text = "Đổi Mật Khẩu";
            this.doimt_bt.UseVisualStyleBackColor = false;
            this.doimt_bt.Click += new System.EventHandler(this.doimt_bt_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(195, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mật Khẩu Cũ";
            // 
            // mkc_ip
            // 
            this.mkc_ip.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mkc_ip.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.mkc_ip.Location = new System.Drawing.Point(201, 223);
            this.mkc_ip.Multiline = true;
            this.mkc_ip.Name = "mkc_ip";
            this.mkc_ip.Size = new System.Drawing.Size(255, 41);
            this.mkc_ip.TabIndex = 4;
            // 
            // mkm_ip
            // 
            this.mkm_ip.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mkm_ip.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.mkm_ip.Location = new System.Drawing.Point(201, 350);
            this.mkm_ip.Multiline = true;
            this.mkm_ip.Name = "mkm_ip";
            this.mkm_ip.Size = new System.Drawing.Size(255, 41);
            this.mkm_ip.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(195, 315);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(188, 32);
            this.label3.TabIndex = 5;
            this.label3.Text = "Mật Khẩu Mới";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(194, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(254, 38);
            this.label4.TabIndex = 7;
            this.label4.Text = "ĐỔI MẬT KHẨU";
            // 
            // form_doimk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(671, 586);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.mkm_ip);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.mkc_ip);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.doimt_bt);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "form_doimk";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ĐỔI MẬT KHẨU";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button doimt_bt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox mkc_ip;
        private System.Windows.Forms.TextBox mkm_ip;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}