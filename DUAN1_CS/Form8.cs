using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DUAN1_CS
{
    public partial class form_dsmon : Form
    {
        duan1 db = new duan1();
        DataTable dt = new DataTable();
        public form_dsmon()
        {
            InitializeComponent();
        }

        private void form_dsmon_Load(object sender, EventArgs e)
        {
            dt.Columns.Add("Mã bàn", typeof(string));
            dt.Columns.Add("Tên món", typeof(string));
            dt.Columns.Add("Số lượng", typeof(int));
            foreach (var x in db.BILLs)
            {
                var tenmon = (from a in db.MENUs
                              where a.maMon == x.maMon
                              select a.tenMon).FirstOrDefault();
                dt.Rows.Add(x.maBan, tenmon, x.soluong);
            }
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow dr = dataGridView1.SelectedRows[0];
                
                maban_lb.Text = dr.Cells[0].Value.ToString();
                tenmon_lb.Text = dr.Cells[1].Value.ToString();
                soluong_lb.Text = dr.Cells[2].Value.ToString();
            }
        }

        private void xacnhan_bt_Click(object sender, EventArgs e)
        {
            string maBan = maban_lb.Text;
            string tenMon = tenmon_lb.Text;

            if (string.IsNullOrWhiteSpace(maBan))
            {
                MessageBox.Show("CHỌN BÀN CẦN RA MÓN");
            }
            else
            {
                
                int soluong = Convert.ToInt32(soluong_lb.Text);
                XoaDuLieu(maBan, tenMon, soluong);
                MessageBox.Show("RA MÓN THÀNH CÔNG!");
                dataGridView1.DataSource = dt;
            }

        }
        private void XoaDuLieu(string maBan, string tenMon, int soLuong)
        {
            DataRow[] rows = dt.Select($"[Mã bàn] = '{maBan}' AND [Tên món] = '{tenMon}' AND [Số lượng] = {soLuong}");
            if (rows.Length > 0)
            {
                foreach (DataRow row in rows)
                {
                    dt.Rows.Remove(row);
                }
            }
            else MessageBox.Show("KHÔNG THỂ RA MÓN");
        } 
    }
}
