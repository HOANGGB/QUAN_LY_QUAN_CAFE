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
    public partial class form_baocaokho : Form
    {
        duan1 db = new duan1 ();
        public form_baocaokho()
        {
            InitializeComponent();
        }

        private void form_baocaokho_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dU_AN_1DataSet8.KHO' table. You can move, or remove it, as needed.
            this.kHOTableAdapter.Fill(this.dU_AN_1DataSet8.KHO);
            dataGridView1.DataSource = db.KHOes.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ten = ten_ip.Text;
            string soluong = soluong_ip.Text;
            string HSD = "";
            if (han1.Checked)
            {
                HSD = "< 10 Ngày";
            }else if(han2.Checked)
            {
                HSD = "> 1 Tháng";
            }

            if (string.IsNullOrWhiteSpace(ten)){
                MessageBox.Show("CHỌN TÊN NGUYÊN LIỆU!");
            }else if (string.IsNullOrWhiteSpace(soluong))
            {
                MessageBox.Show("NHẬP SỐ LƯỢNG!");
            }else if(!han1.Checked && !han2.Checked)
            {
                MessageBox.Show("CHỌN HẠN SỬ DỤNG CÒN CỦA NGUYÊN LIỆU!");
            }
            else
            {
                var NLBC = db.KHOes.FirstOrDefault(x=>x.tenNL ==ten);
                NLBC.soluong = soluong;
                NLBC.HanSuDungCon = HSD;
                NLBC.manv = valll.nhanvien.manv;
                db.SaveChanges();
                MessageBox.Show("ĐÃ BÁO CÁO THÀNH CÔNG!");
                dataGridView1.DataSource = db.KHOes.ToList();
            }
        }
    }
}
