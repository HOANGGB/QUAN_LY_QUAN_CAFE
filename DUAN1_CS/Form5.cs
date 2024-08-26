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
    public partial class form_qlmenu : Form
    {
        duan1 db = new duan1();
        public form_qlmenu()
        {
            InitializeComponent();
        }

        private void form_qlmenu_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.MENUs.ToList();
        }

        private void them_bt_Click(object sender, EventArgs e)
        {
            string maMon = MaMonRamdom();
            string ten = tenmon_ip.Text;
            string gia = gia_ip.Text;
            var checkTenMon = db.MENUs.Any(x=>x.tenMon== ten);
            double number;

            if (string.IsNullOrWhiteSpace(ten))
            {
                MessageBox.Show("NHẬP TÊN MÓN!");
            }else if (checkTenMon)
            {
                MessageBox.Show("TÊN MÓN ĐÃ TỒN TẠI!");
            }
            else if(string.IsNullOrWhiteSpace(gia))
            {
                MessageBox.Show("NHẬP GIÁ MÓN");
            }else if(!double.TryParse(gia, out number)) 
            {
                MessageBox.Show("NHẬP GIÁ TIỀN LÀ SỐ!");
            }
            else
            {
                var newMenu = new MENU
                {
                    maMon = maMon,
                    tenMon = ten,
                    gia =Convert.ToDouble(gia),
                };
                db.MENUs.Add(newMenu);
                db.SaveChanges();
                MessageBox.Show("ĐÃ THÊM  MÓN MỚI VÀO MENU!");
                dataGridView1.DataSource = db.MENUs.ToList();
                
            }

            
        }
        private void sua_bt_Click(object sender, EventArgs e)
        {
            string ten = tenmon_ip.Text;
            string gia = gia_ip.Text;
            double number;
            var checkTen = db.MENUs.Any(x => x.tenMon == ten);

            if (string.IsNullOrWhiteSpace(ten))
            {
                MessageBox.Show("NHẬP TÊN MÓN!");
            }
            else if (string.IsNullOrWhiteSpace(gia))
            {
                MessageBox.Show("NHẬP GIÁ MÓN");
            }
            else if (!double.TryParse(gia, out number))
            {
                MessageBox.Show("NHẬP GIÁ TIỀN LÀ SỐ!");
            }else if (!checkTen)
            {
                MessageBox.Show("TÊN MÓN KHÔNG TỒN TẠI\r NHẬP TÊN MÓN CÓ TRONG MENU");
            }
            else
            {
                var changMENU = db.MENUs.FirstOrDefault(x => x.tenMon == ten);
                changMENU.gia = Convert.ToDouble(gia);
                db.SaveChanges();
                dataGridView1.DataSource = db.MENUs.ToList();
                MessageBox.Show("ĐÃ SỬA MÓN "+ten);

            }
        }

        private void xoa_bt_Click(object sender, EventArgs e)
        {
            string ten = tenmon_ip.Text;
            var checkten = db.MENUs.Any(x=> x.tenMon == ten);
            if (string.IsNullOrWhiteSpace(ten))
            {
                MessageBox.Show("NHẬP TÊN MÓN CẦN XÓA!");
            }else if(!checkten)
            {
                MessageBox.Show("TÊN MÓN KHÔNG CÓ TRONG MENU!\r VUI LÒNG CHỌN MÓN TỪ MENU HOẶC NHẬP TÊN MÓN");
            }
            else
            {
                var removeMON = db.MENUs.FirstOrDefault(x => x.tenMon == ten);
                db.MENUs.Remove(removeMON);
                db.SaveChanges();
                dataGridView1.DataSource = db.MENUs.ToList();
                MessageBox.Show("MÓN ĐÃ ĐƯỢC XÓA KHỎI MENU!");
            }
        }
        public string MaMonRamdom()
        {
            Random random = new Random();
            const string chars = "0123456789";
            string randomString = "";

            while (true)
            {
                StringBuilder result = new StringBuilder(); // Reset StringBuilder
                for (int i = 0; i < 3; i++)
                {
                    result.Append(chars[random.Next(chars.Length)]);
                }

                randomString = "MM_" + result.ToString(); // Tạo mã nhân viên từ kết quả ngẫu nhiên

                var check = db.MENUs.Any(x => x.maMon == randomString);

                if (!check)
                {
                    break; // Thoát khỏi vòng lặp nếu mã không trùng lặp
                }
            }

            return randomString;
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count > 0) 
            {
                DataGridViewRow dr = dataGridView1.SelectedRows[0];
                tenmon_ip.Text = dr.Cells[1].Value.ToString();
                gia_ip.Text = dr.Cells[2].Value.ToString();
                                        
            }
        }
    }
}
