namespace DUAN1_CS
{
    partial class form_qlll
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.calam_ip = new System.Windows.Forms.TextBox();
            this.ngaylam_ip = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.xoa_bt = new System.Windows.Forms.Button();
            this.sua_bt = new System.Windows.Forms.Button();
            this.them_bt = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.manv_ip = new System.Windows.Forms.ComboBox();
            this.nHANVIENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dU_AN_1DataSet5 = new DUAN1_CS.DU_AN_1DataSet5();
            this.dU_AN_1DataSet = new DUAN1_CS.DU_AN_1DataSet();
            this.mENUBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mENUTableAdapter = new DUAN1_CS.DU_AN_1DataSetTableAdapters.MENUTableAdapter();
            this.nHANVIENTableAdapter = new DUAN1_CS.DU_AN_1DataSet5TableAdapters.NHANVIENTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHANVIENBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dU_AN_1DataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dU_AN_1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mENUBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // calam_ip
            // 
            this.calam_ip.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.calam_ip.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.calam_ip.Location = new System.Drawing.Point(558, 66);
            this.calam_ip.Multiline = true;
            this.calam_ip.Name = "calam_ip";
            this.calam_ip.Size = new System.Drawing.Size(207, 37);
            this.calam_ip.TabIndex = 19;
            // 
            // ngaylam_ip
            // 
            this.ngaylam_ip.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ngaylam_ip.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ngaylam_ip.Location = new System.Drawing.Point(312, 66);
            this.ngaylam_ip.Multiline = true;
            this.ngaylam_ip.Name = "ngaylam_ip";
            this.ngaylam_ip.Size = new System.Drawing.Size(207, 37);
            this.ngaylam_ip.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(553, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 25);
            this.label3.TabIndex = 16;
            this.label3.Text = "Ca làm";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(307, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 25);
            this.label2.TabIndex = 15;
            this.label2.Text = "Ngày làm";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(64, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 25);
            this.label1.TabIndex = 14;
            this.label1.Text = "Mã nhân viên ";
            // 
            // xoa_bt
            // 
            this.xoa_bt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.xoa_bt.BackColor = System.Drawing.Color.LightSteelBlue;
            this.xoa_bt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.xoa_bt.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.xoa_bt.Location = new System.Drawing.Point(15, 236);
            this.xoa_bt.Name = "xoa_bt";
            this.xoa_bt.Size = new System.Drawing.Size(136, 77);
            this.xoa_bt.TabIndex = 13;
            this.xoa_bt.Text = "Xóa";
            this.xoa_bt.UseVisualStyleBackColor = false;
            this.xoa_bt.Click += new System.EventHandler(this.xoa_bt_Click_1);
            // 
            // sua_bt
            // 
            this.sua_bt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sua_bt.BackColor = System.Drawing.Color.LightSteelBlue;
            this.sua_bt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.sua_bt.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.sua_bt.Location = new System.Drawing.Point(15, 144);
            this.sua_bt.Name = "sua_bt";
            this.sua_bt.Size = new System.Drawing.Size(136, 77);
            this.sua_bt.TabIndex = 12;
            this.sua_bt.Text = "Sửa ";
            this.sua_bt.UseVisualStyleBackColor = false;
            // 
            // them_bt
            // 
            this.them_bt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.them_bt.BackColor = System.Drawing.Color.LightSteelBlue;
            this.them_bt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.them_bt.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.them_bt.Location = new System.Drawing.Point(15, 51);
            this.them_bt.Name = "them_bt";
            this.them_bt.Size = new System.Drawing.Size(136, 77);
            this.them_bt.TabIndex = 11;
            this.them_bt.Text = "Thêm";
            this.them_bt.UseVisualStyleBackColor = false;
            this.them_bt.Click += new System.EventHandler(this.them_bt_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(19, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(783, 351);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(15, 375);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 78);
            this.button1.TabIndex = 20;
            this.button1.Text = "DUYỆT";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(15, 375);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(136, 78);
            this.button2.TabIndex = 21;
            this.button2.Text = "TỪ CHỐI DUYỆT";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // manv_ip
            // 
            this.manv_ip.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.manv_ip.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.nHANVIENBindingSource, "manv", true));
            this.manv_ip.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.manv_ip.FormattingEnabled = true;
            this.manv_ip.Location = new System.Drawing.Point(69, 66);
            this.manv_ip.Name = "manv_ip";
            this.manv_ip.Size = new System.Drawing.Size(207, 37);
            this.manv_ip.TabIndex = 22;
            // 
            // nHANVIENBindingSource
            // 
            this.nHANVIENBindingSource.DataMember = "NHANVIEN";
            this.nHANVIENBindingSource.DataSource = this.dU_AN_1DataSet5;
            // 
            // dU_AN_1DataSet5
            // 
            this.dU_AN_1DataSet5.DataSetName = "DU_AN_1DataSet5";
            this.dU_AN_1DataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dU_AN_1DataSet
            // 
            this.dU_AN_1DataSet.DataSetName = "DU_AN_1DataSet";
            this.dU_AN_1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mENUBindingSource
            // 
            this.mENUBindingSource.DataMember = "MENU";
            this.mENUBindingSource.DataSource = this.dU_AN_1DataSet;
            // 
            // mENUTableAdapter
            // 
            this.mENUTableAdapter.ClearBeforeFill = true;
            // 
            // nHANVIENTableAdapter
            // 
            this.nHANVIENTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.ngaylam_ip);
            this.groupBox1.Controls.Add(this.manv_ip);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.calam_ip);
            this.groupBox1.Location = new System.Drawing.Point(58, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(823, 128);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(58, 204);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(823, 396);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dữ Liệu Lịch Làm Nhân Viên";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox3.Controls.Add(this.them_bt);
            this.groupBox3.Controls.Add(this.sua_bt);
            this.groupBox3.Controls.Add(this.xoa_bt);
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Location = new System.Drawing.Point(931, 38);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(164, 562);
            this.groupBox3.TabIndex = 25;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chức Năng";
            // 
            // form_qlll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(1181, 689);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "form_qlll";
            this.Text = "QUẢN LÝ LỊCH LÀM";
            this.Load += new System.EventHandler(this.form_qlll_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHANVIENBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dU_AN_1DataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dU_AN_1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mENUBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox calam_ip;
        private System.Windows.Forms.TextBox ngaylam_ip;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button xoa_bt;
        private System.Windows.Forms.Button sua_bt;
        private System.Windows.Forms.Button them_bt;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox manv_ip;
        private DU_AN_1DataSet dU_AN_1DataSet;
        private System.Windows.Forms.BindingSource mENUBindingSource;
        private DU_AN_1DataSetTableAdapters.MENUTableAdapter mENUTableAdapter;
        private DU_AN_1DataSet5 dU_AN_1DataSet5;
        private System.Windows.Forms.BindingSource nHANVIENBindingSource;
        private DU_AN_1DataSet5TableAdapters.NHANVIENTableAdapter nHANVIENTableAdapter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}