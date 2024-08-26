namespace DUAN1_CS
{
    partial class form_qlmenu
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.them_bt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tenmon_ip = new System.Windows.Forms.TextBox();
            this.gia_ip = new System.Windows.Forms.TextBox();
            this.sua_bt = new System.Windows.Forms.Button();
            this.xoa_bt = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(28, 33);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(452, 335);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.UseWaitCursor = true;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // them_bt
            // 
            this.them_bt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.them_bt.BackColor = System.Drawing.Color.LightSteelBlue;
            this.them_bt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.them_bt.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.them_bt.Location = new System.Drawing.Point(11, 34);
            this.them_bt.Name = "them_bt";
            this.them_bt.Size = new System.Drawing.Size(104, 77);
            this.them_bt.TabIndex = 1;
            this.them_bt.Text = "THÊM";
            this.them_bt.UseVisualStyleBackColor = false;
            this.them_bt.UseWaitCursor = true;
            this.them_bt.Click += new System.EventHandler(this.them_bt_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(29, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tên Món";
            this.label1.UseWaitCursor = true;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(77, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Giá";
            this.label2.UseWaitCursor = true;
            // 
            // tenmon_ip
            // 
            this.tenmon_ip.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tenmon_ip.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tenmon_ip.Location = new System.Drawing.Point(139, 51);
            this.tenmon_ip.Multiline = true;
            this.tenmon_ip.Name = "tenmon_ip";
            this.tenmon_ip.Size = new System.Drawing.Size(193, 43);
            this.tenmon_ip.TabIndex = 4;
            this.tenmon_ip.UseWaitCursor = true;
            // 
            // gia_ip
            // 
            this.gia_ip.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gia_ip.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gia_ip.Location = new System.Drawing.Point(139, 129);
            this.gia_ip.Multiline = true;
            this.gia_ip.Name = "gia_ip";
            this.gia_ip.Size = new System.Drawing.Size(193, 43);
            this.gia_ip.TabIndex = 5;
            this.gia_ip.UseWaitCursor = true;
            // 
            // sua_bt
            // 
            this.sua_bt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sua_bt.BackColor = System.Drawing.Color.LightSteelBlue;
            this.sua_bt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.sua_bt.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.sua_bt.Location = new System.Drawing.Point(139, 34);
            this.sua_bt.Name = "sua_bt";
            this.sua_bt.Size = new System.Drawing.Size(104, 77);
            this.sua_bt.TabIndex = 6;
            this.sua_bt.Text = "SỬA";
            this.sua_bt.UseVisualStyleBackColor = false;
            this.sua_bt.UseWaitCursor = true;
            this.sua_bt.Click += new System.EventHandler(this.sua_bt_Click);
            // 
            // xoa_bt
            // 
            this.xoa_bt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.xoa_bt.BackColor = System.Drawing.Color.LightSteelBlue;
            this.xoa_bt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.xoa_bt.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.xoa_bt.Location = new System.Drawing.Point(274, 34);
            this.xoa_bt.Name = "xoa_bt";
            this.xoa_bt.Size = new System.Drawing.Size(104, 77);
            this.xoa_bt.TabIndex = 7;
            this.xoa_bt.Text = "XÓA";
            this.xoa_bt.UseVisualStyleBackColor = false;
            this.xoa_bt.UseWaitCursor = true;
            this.xoa_bt.Click += new System.EventHandler(this.xoa_bt_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.them_bt);
            this.groupBox1.Controls.Add(this.xoa_bt);
            this.groupBox1.Controls.Add(this.sua_bt);
            this.groupBox1.Location = new System.Drawing.Point(30, 312);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(398, 137);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chức Năng";
            this.groupBox1.UseWaitCursor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox2.Controls.Add(this.tenmon_ip);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.gia_ip);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(30, 60);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(398, 218);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông Tin Menu";
            this.groupBox2.UseWaitCursor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(468, 60);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(522, 389);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Dư Liệu Menu";
            this.groupBox3.UseWaitCursor = true;
            // 
            // form_qlmenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(1002, 553);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.Name = "form_qlmenu";
            this.Text = "QUẢN LÝ MENU";
            this.UseWaitCursor = true;
            this.Load += new System.EventHandler(this.form_qlmenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button them_bt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tenmon_ip;
        private System.Windows.Forms.TextBox gia_ip;
        private System.Windows.Forms.Button sua_bt;
        private System.Windows.Forms.Button xoa_bt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}