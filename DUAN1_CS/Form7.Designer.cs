namespace DUAN1_CS
{
    partial class form_order
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mon_cbb = new System.Windows.Forms.ComboBox();
            this.mENUBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dU_AN_1DataSet = new DUAN1_CS.DU_AN_1DataSet();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.them_bt = new System.Windows.Forms.Button();
            this.sua_bt = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.xoa_bt = new System.Windows.Forms.Button();
            this.mENUTableAdapter = new DUAN1_CS.DU_AN_1DataSetTableAdapters.MENUTableAdapter();
            this.maban_ip = new System.Windows.Forms.ComboBox();
            this.bANBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dU_AN_1DataSet6 = new DUAN1_CS.DU_AN_1DataSet6();
            this.bANTableAdapter = new DUAN1_CS.DU_AN_1DataSet6TableAdapters.BANTableAdapter();
            this.soluong_ip = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.mENUBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dU_AN_1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bANBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dU_AN_1DataSet6)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(21, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Mã Bàn";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(7, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Chọn Món";
            // 
            // mon_cbb
            // 
            this.mon_cbb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mon_cbb.DataSource = this.mENUBindingSource;
            this.mon_cbb.DisplayMember = "tenMon";
            this.mon_cbb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.mon_cbb.FormattingEnabled = true;
            this.mon_cbb.Location = new System.Drawing.Point(144, 129);
            this.mon_cbb.Name = "mon_cbb";
            this.mon_cbb.Size = new System.Drawing.Size(226, 33);
            this.mon_cbb.TabIndex = 7;
            this.mon_cbb.ValueMember = "tenMon";
            // 
            // mENUBindingSource
            // 
            this.mENUBindingSource.DataMember = "MENU";
            this.mENUBindingSource.DataSource = this.dU_AN_1DataSet;
            // 
            // dU_AN_1DataSet
            // 
            this.dU_AN_1DataSet.DataSetName = "DU_AN_1DataSet";
            this.dU_AN_1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridView1.Location = new System.Drawing.Point(23, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(559, 421);
            this.dataGridView1.TabIndex = 8;
            // 
            // them_bt
            // 
            this.them_bt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.them_bt.BackColor = System.Drawing.Color.LightSteelBlue;
            this.them_bt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.them_bt.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.them_bt.Location = new System.Drawing.Point(16, 54);
            this.them_bt.Name = "them_bt";
            this.them_bt.Size = new System.Drawing.Size(103, 71);
            this.them_bt.TabIndex = 9;
            this.them_bt.Text = "THÊM";
            this.them_bt.UseVisualStyleBackColor = false;
            this.them_bt.Click += new System.EventHandler(this.them_bt_Click);
            // 
            // sua_bt
            // 
            this.sua_bt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sua_bt.BackColor = System.Drawing.Color.LightSteelBlue;
            this.sua_bt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.sua_bt.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.sua_bt.Location = new System.Drawing.Point(144, 54);
            this.sua_bt.Name = "sua_bt";
            this.sua_bt.Size = new System.Drawing.Size(109, 71);
            this.sua_bt.TabIndex = 10;
            this.sua_bt.Text = "SỬA";
            this.sua_bt.UseVisualStyleBackColor = false;
            this.sua_bt.Click += new System.EventHandler(this.sua_bt_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(7, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "Số Lượng";
            // 
            // xoa_bt
            // 
            this.xoa_bt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.xoa_bt.BackColor = System.Drawing.Color.LightSteelBlue;
            this.xoa_bt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.xoa_bt.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.xoa_bt.Location = new System.Drawing.Point(277, 54);
            this.xoa_bt.Name = "xoa_bt";
            this.xoa_bt.Size = new System.Drawing.Size(102, 71);
            this.xoa_bt.TabIndex = 13;
            this.xoa_bt.Text = "XÓA";
            this.xoa_bt.UseVisualStyleBackColor = false;
            this.xoa_bt.Click += new System.EventHandler(this.xoa_bt_Click);
            // 
            // mENUTableAdapter
            // 
            this.mENUTableAdapter.ClearBeforeFill = true;
            // 
            // maban_ip
            // 
            this.maban_ip.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.maban_ip.DataSource = this.bANBindingSource;
            this.maban_ip.DisplayMember = "maBan";
            this.maban_ip.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.maban_ip.FormattingEnabled = true;
            this.maban_ip.Location = new System.Drawing.Point(144, 55);
            this.maban_ip.Name = "maban_ip";
            this.maban_ip.Size = new System.Drawing.Size(226, 33);
            this.maban_ip.TabIndex = 14;
            this.maban_ip.ValueMember = "maBan";
            // 
            // bANBindingSource
            // 
            this.bANBindingSource.DataMember = "BAN";
            this.bANBindingSource.DataSource = this.dU_AN_1DataSet6;
            // 
            // dU_AN_1DataSet6
            // 
            this.dU_AN_1DataSet6.DataSetName = "DU_AN_1DataSet6";
            this.dU_AN_1DataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bANTableAdapter
            // 
            this.bANTableAdapter.ClearBeforeFill = true;
            // 
            // soluong_ip
            // 
            this.soluong_ip.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.soluong_ip.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.soluong_ip.FormattingEnabled = true;
            this.soluong_ip.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.soluong_ip.Location = new System.Drawing.Point(144, 189);
            this.soluong_ip.Name = "soluong_ip";
            this.soluong_ip.Size = new System.Drawing.Size(226, 33);
            this.soluong_ip.TabIndex = 16;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.soluong_ip);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.maban_ip);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.mon_cbb);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(12, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(401, 270);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chức Năng";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox2.Location = new System.Drawing.Point(482, 23);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(588, 476);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dữ Liệu";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox3.Controls.Add(this.sua_bt);
            this.groupBox3.Controls.Add(this.xoa_bt);
            this.groupBox3.Controls.Add(this.them_bt);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox3.Location = new System.Drawing.Point(12, 332);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(401, 167);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chức Năng";
            // 
            // form_order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(1082, 531);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "form_order";
            this.Text = "ORDER";
            this.Load += new System.EventHandler(this.form_order_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mENUBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dU_AN_1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bANBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dU_AN_1DataSet6)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox mon_cbb;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button them_bt;
        private System.Windows.Forms.Button sua_bt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button xoa_bt;
        private DU_AN_1DataSet dU_AN_1DataSet;
        private System.Windows.Forms.BindingSource mENUBindingSource;
        private DU_AN_1DataSetTableAdapters.MENUTableAdapter mENUTableAdapter;
        private System.Windows.Forms.ComboBox maban_ip;
        private DU_AN_1DataSet6 dU_AN_1DataSet6;
        private System.Windows.Forms.BindingSource bANBindingSource;
        private DU_AN_1DataSet6TableAdapters.BANTableAdapter bANTableAdapter;
        private System.Windows.Forms.ComboBox soluong_ip;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}