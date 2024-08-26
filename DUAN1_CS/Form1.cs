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
    public partial class form_dangnhap : Form
    {
        duan1 db = new duan1();
        public form_dangnhap()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string tenNV = ten_ip.Text;
            string mk = mk_ip.Text;
            var checkTen = db.NHANVIENs.Any(x=>x.tenNV== tenNV);
            var checkMK = (from x in db.NHANVIENs
                          where x.tenNV == tenNV
                          select x.matKhau).Any();

            if (string.IsNullOrWhiteSpace(tenNV))
            {
                MessageBox.Show("NHẬP TÊN NHÂN VIÊN!");
            }
            else if(string.IsNullOrWhiteSpace(mk))
            {
                MessageBox.Show("NHẬP MẬT KHẨU!");
            }else if(!checkTen)
            {
                MessageBox.Show("TÊN NHÂN VIÊN KHÔNG TỒN TẠI?");
            }else if (!checkMK)
            {
                MessageBox.Show("MẬT KHẨU KHÔNG CHÍNH XÁC!");
            }
            else
            {
                MessageBox.Show("ĐĂNG NHẬP THÀNH CÔNG");
                this.Hide();
                var saveNV = db.NHANVIENs.FirstOrDefault(x=>x.tenNV == tenNV);
                valll.nhanvien = saveNV;
                form_home home = new form_home();
                home.ShowDialog();
            }

        }
    }
}
