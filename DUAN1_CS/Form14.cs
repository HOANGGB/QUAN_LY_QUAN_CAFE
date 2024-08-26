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
    public partial class form_doimk : Form
    {
        duan1 db = new duan1();
        public form_doimk()
        {
            InitializeComponent();
        }

        private void doimt_bt_Click(object sender, EventArgs e)
        {
            string MKC = mkc_ip.Text;
            string MKM = mkm_ip.Text;

            var NVChange = db.NHANVIENs.FirstOrDefault(x=>x.manv == valll.nhanvien.manv);
            if(string.IsNullOrWhiteSpace(MKC))
            {
                MessageBox.Show("NHẬP MẬT KHẨU CŨ");
            }
            else if (string.IsNullOrWhiteSpace(MKM))
            {
                MessageBox.Show("NHẬP MẬT KHẨU MỚI");
            }
            else if(NVChange == null){
                MessageBox.Show("NHÂN VIÊN KHÔNG TỒN TẠI!");
            }else if(NVChange.matKhau != MKC)
            {
                MessageBox.Show("MẬT KHẨU CŨ KHÔNG ĐÚNG!");
            }
            else
            {
                NVChange.matKhau = MKM;
                db.SaveChanges();
                MessageBox.Show("ĐÃ ĐỔI MẬT KHẨU THÀNH CÔNG!");
                this.Close();
            }
        }
    }
}
