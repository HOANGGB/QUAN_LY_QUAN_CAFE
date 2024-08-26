namespace DUAN1_CS
{
    partial class form_tinhtien
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tinhtien_bt = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dsmon = new System.Windows.Forms.ListBox();
            this.bILLBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dU_AN_1DataSet2 = new DUAN1_CS.DU_AN_1DataSet2();
            this.bILLTableAdapter = new DUAN1_CS.DU_AN_1DataSet2TableAdapters.BILLTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.nam_cbb = new System.Windows.Forms.ComboBox();
            this.thang_cbb = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ngay_cbb = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bILLBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dU_AN_1DataSet2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(26, 52);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(330, 387);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // tinhtien_bt
            // 
            this.tinhtien_bt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tinhtien_bt.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tinhtien_bt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tinhtien_bt.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tinhtien_bt.Location = new System.Drawing.Point(114, 384);
            this.tinhtien_bt.Name = "tinhtien_bt";
            this.tinhtien_bt.Size = new System.Drawing.Size(228, 55);
            this.tinhtien_bt.TabIndex = 1;
            this.tinhtien_bt.Text = "Tính Tiền";
            this.tinhtien_bt.UseVisualStyleBackColor = false;
            this.tinhtien_bt.Click += new System.EventHandler(this.tinhtien_bt_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(63, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Danh Sách Món";
            // 
            // dsmon
            // 
            this.dsmon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dsmon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dsmon.FormattingEnabled = true;
            this.dsmon.ItemHeight = 25;
            this.dsmon.Location = new System.Drawing.Point(73, 61);
            this.dsmon.Name = "dsmon";
            this.dsmon.Size = new System.Drawing.Size(313, 204);
            this.dsmon.TabIndex = 6;
            // 
            // bILLBindingSource
            // 
            this.bILLBindingSource.DataMember = "BILL";
            this.bILLBindingSource.DataSource = this.dU_AN_1DataSet2;
            // 
            // dU_AN_1DataSet2
            // 
            this.dU_AN_1DataSet2.DataSetName = "DU_AN_1DataSet2";
            this.dU_AN_1DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bILLTableAdapter
            // 
            this.bILLTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.nam_cbb);
            this.groupBox1.Controls.Add(this.thang_cbb);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.ngay_cbb);
            this.groupBox1.Controls.Add(this.dsmon);
            this.groupBox1.Controls.Add(this.tinhtien_bt);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(102, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(440, 474);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh Sách Món Và Tính Tiền";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox2.Location = new System.Drawing.Point(604, 68);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(395, 474);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dữ liệu";
            // 
            // nam_cbb
            // 
            this.nam_cbb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nam_cbb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.nam_cbb.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.nam_cbb.FormattingEnabled = true;
            this.nam_cbb.Items.AddRange(new object[] {
            "2023",
            "2024"});
            this.nam_cbb.Location = new System.Drawing.Point(275, 323);
            this.nam_cbb.Name = "nam_cbb";
            this.nam_cbb.Size = new System.Drawing.Size(106, 37);
            this.nam_cbb.TabIndex = 17;
            // 
            // thang_cbb
            // 
            this.thang_cbb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.thang_cbb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.thang_cbb.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.thang_cbb.FormattingEnabled = true;
            this.thang_cbb.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.thang_cbb.Location = new System.Drawing.Point(168, 323);
            this.thang_cbb.Name = "thang_cbb";
            this.thang_cbb.Size = new System.Drawing.Size(89, 37);
            this.thang_cbb.TabIndex = 16;
            this.thang_cbb.SelectedIndexChanged += new System.EventHandler(this.thang_cbb_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(280, 277);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 32);
            this.label5.TabIndex = 15;
            this.label5.Text = "Năm";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(162, 277);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 32);
            this.label4.TabIndex = 14;
            this.label4.Text = "Tháng";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(67, 277);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 32);
            this.label3.TabIndex = 12;
            this.label3.Text = "Ngày";
            // 
            // ngay_cbb
            // 
            this.ngay_cbb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ngay_cbb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ngay_cbb.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ngay_cbb.FormattingEnabled = true;
            this.ngay_cbb.Location = new System.Drawing.Point(68, 323);
            this.ngay_cbb.Name = "ngay_cbb";
            this.ngay_cbb.Size = new System.Drawing.Size(79, 37);
            this.ngay_cbb.TabIndex = 13;
            // 
            // form_tinhtien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(1060, 643);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Name = "form_tinhtien";
            this.Text = "TÍNH TIỀN";
            this.Load += new System.EventHandler(this.form_tinhtien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bILLBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dU_AN_1DataSet2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button tinhtien_bt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox dsmon;
        private DU_AN_1DataSet2 dU_AN_1DataSet2;
        private System.Windows.Forms.BindingSource bILLBindingSource;
        private DU_AN_1DataSet2TableAdapters.BILLTableAdapter bILLTableAdapter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox nam_cbb;
        private System.Windows.Forms.ComboBox thang_cbb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox ngay_cbb;
    }
}