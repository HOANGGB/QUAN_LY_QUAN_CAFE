using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DUAN1_CS
{
    public partial class form_tinhtien : Form
    {
        duan1 db = new duan1();
        List<string> listMon = new List<string>();
        List<int?> listSL = new List<int?>();
        List<double?> listGia = new List<double?>();
        string banTT = "";


        public form_tinhtien()
        {
            InitializeComponent();
        }

        private void form_tinhtien_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.BANs.ToList();

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow dr = dataGridView1.SelectedRows[0];
                banTT = dr.Cells[0].Value.ToString();
                htMOn(banTT);

                dsmon.Items.Clear();
                if(listMon == null)
                {
                    dsmon.Items.Add("BÀN NÀY KHÔNG CÓ MÓN");
                }
                else
                {
                    foreach(var x in listMon)
                    {
                        dsmon.Items.Add(x.ToString());
                    }
                }
                
            }
        }

        private void tinhtien_bt_Click(object sender, EventArgs e)
        {
            string bill = "";
            double? sum = 0;
            string ngay = ngay_cbb.SelectedItem?.ToString();
            string thang = thang_cbb.SelectedItem?.ToString();
            string nam = nam_cbb.SelectedItem?.ToString();

            int ngayINT = Convert.ToInt32(ngay);
            int thangINT = Convert.ToInt32(thang);
            int namINT = Convert.ToInt32(nam);
            if (ngay == null || thang == null || nam == null)
            {
                MessageBox.Show("NHẬP ĐẦY ĐỦ NGÀY THÁNG NĂM!");
            }
            else
            {
                for (int i = 0; i < listMon.Count; i++)
                {
                    bill += listMon[i] + "\t\t" + listGia[i] + "\t\t" + listSL[i] + "\t\t" + (listGia[i] * listSL[i]) + "\r";
                    var temp = listGia[i] * listSL[i];
                    sum += temp;
                };
                if (banTT == "")
                {
                    MessageBox.Show("CHỌN BÀN CẦN TÍNH TIỀN!");
                }else if (listMon == null)
                {
                    MessageBox.Show("BÀN NÀY HIỆN KHÔNG CÓ NGƯỜI!");
                }
                else 
                {
                    //Xóa món khỏi bàn
/*                    foreach(var a in db.BILLs)
                    {
                       if(a.maBan == banTT)
                        {
                            db.BILLs.Remove(a);
                            db.SaveChanges();
                        }

                    }*/

                    //hiển thị BILL của bàn
                    MessageBox.Show("\t\t\tHÓA ĐƠN BÀN " + banTT +
                        "\rTÊN MÓN  \t   GIÁ MÓN   \t  SỐ LƯỢNG   \t  TỔNG TIỀN\r" + bill + "\r " +
                        "--------------------------------------------------------------------------------------------\r" +
                        "\t\t\t\t\tTỔNG : " + sum + " VND");
                    //thêm vào doanh thu ngày vào hệ thống
                    var checkNgay = db.THONGKEs.FirstOrDefault(x => x.ngay == ngayINT && x.thang == thangINT && x.nam == namINT);
                    

                    if (checkNgay == null)
                    {
                        var addDTN = new THONGKE
                        {
                            manv = valll.nhanvien.manv,
                            ngay = ngayINT,
                            thang = thangINT,
                            nam = namINT,
                            doanhThuHeThong = sum
                        };
                        db.THONGKEs.Add(addDTN);
                        db.SaveChanges();

                    }
                    else
                    {
                        checkNgay.doanhThuHeThong += sum;
                        db.SaveChanges();

                    }
                    //thêm vào doanh thu tháng vào hệ thống

                }
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

                randomString = "ID_"+ result.ToString(); // Tạo mã nhân viên từ kết quả ngẫu nhiên

                var check = db.MENUs.Any(x => x.maMon == randomString);

                if (!check)
                {
                    break; // Thoát khỏi vòng lặp nếu mã không trùng lặp
                }
            }

            return randomString;
        }
        public void htMOn(string ban)
        {
            listMon = (from x in db.MENUs
                        join b in db.BILLs on x.maMon equals b.maMon
                        where b.maBan == ban
                        select x.tenMon).ToList();

            listGia = (from x in db.MENUs
                       join b in db.BILLs on x.maMon equals b.maMon
                       where b.maBan == ban
                       select x.gia).ToList();

            listSL = (from x in db.MENUs
                       join b in db.BILLs on x.maMon equals b.maMon
                       where b.maBan == ban
                       select b.soluong).ToList();
        }

        private void thang_cbb_SelectedIndexChanged(object sender, EventArgs e)
        {

            int monthSelect = thang_cbb.SelectedIndex + 1;
            if (monthSelect == 1 || monthSelect == 3 || monthSelect == 5 || monthSelect == 7 ||
                monthSelect == 8 || monthSelect == 10 || monthSelect == 12)
            {
                ngay_cbb.Items.Clear();
                for (int i = 1; i <= 31; i++)
                {
                    ngay_cbb.Items.Add(i);
                }
            }
            else if (monthSelect == 4 || monthSelect == 6 || monthSelect == 9 || monthSelect == 11)
            {
                ngay_cbb.Items.Clear();
                for (int i = 1; i <= 30; i++)
                {
                    ngay_cbb.Items.Add(i);
                }
            }
            else if (monthSelect == 2)
            {
                ngay_cbb.Items.Clear();
                for (int i = 1; i <= 28; i++)
                {
                    ngay_cbb.Items.Add(i);
                }
            }
        }
    }
}
