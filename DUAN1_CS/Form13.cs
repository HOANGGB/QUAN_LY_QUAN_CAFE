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
    public partial class form_thongke : Form
    {
        duan1 db = new duan1();
        private int tbIndex;
        private int dataIndex;

        public form_thongke()
        {
            InitializeComponent();
        }

        private void form_thongke_Load(object sender, EventArgs e)
        {
            tbIndex= 0;
            dataIndex = 0;
            dataGridView1.DataSource = db.THONGKEs.ToList();
        }


        private void doi_bt_Click(object sender, EventArgs e)
        {
            if (dataIndex == 0)
            {
                //THỐNG KÊ THEO THÁNG
                hTBANGDTT();
                doi_bt.Text = "Thống Kê Tháng";
                dataIndex = 1;
            }
            else
            {
                dataGridView1.DataSource = db.THONGKEs.ToList();
                doi_bt.Text = "Thống Kê Ngày";
                dataIndex = 0;
            }
        }

        private void doibang_bt_Click(object sender, EventArgs e)
        {
            if(tbIndex == 0)
            {
                doi_bt.Hide();
                tbIndex= 1;
                doibang_bt.Text = "Xem Doanh Thu";
                dataGridView1.DataSource = db.KHOes.ToList();
            }
            else
            {
                doi_bt.Show();
                tbIndex = 0;
                doibang_bt.Text = "Xem Kho";
                dataGridView1.DataSource = db.THONGKEs.ToList();
            }

        }
        void hTBANGDTT()
        {
            var query = from tk in db.THONGKEs
                        group tk by new { tk.thang, tk.nam } into g
                        select new
                        {
                            Thang = g.Key.thang,
                            Nam = g.Key.nam,
                            DoanhThuThangThucTe = g.Sum(x => x.doanhThuThucTe),
                            DoanhThuThangHeThong = g.Sum(x => x.doanhThuHeThong)
                        };
            // Hiển thị dữ liệu trên DataGridView
            dataGridView1.DataSource = query.ToList();
        }
    }
}
