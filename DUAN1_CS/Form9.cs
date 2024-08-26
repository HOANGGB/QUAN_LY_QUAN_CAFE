using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DUAN1_CS
{
    public partial class form_baocaocuoingay : Form
    {
        duan1 db = new duan1();
        private Timer timer;
        private string a, b, c;
        public form_baocaocuoingay()
        {
            InitializeComponent();
        }
        private void form_baocaocuoingay_Load(object sender, EventArgs e)
        {
            ngay_cbb.SelectedItem = "1";
            comboBox1.SelectedItem = "1";
            comboBox2.SelectedItem = "2023";
            chuy_lb.ForeColor = Color.Black;
            chuy_lb.Text = "CHÚ Ý:\r  Vui Lòng Kiểm Tra Kĩ Số Dư Hiện Tại Trong Quầy," +
                " Trung Thực  Báo Cáo Mọi Hành Vi Gian Lận Sẽ Có Biện Pháp Sử Lý Theo Quy Định ";
            timer = new Timer();
            timer.Interval = 1000; // 1000 milliseconds = 1 second
            timer.Tick += Timer_Tick;
            timer.Start();
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int? ngay,thang,nam;
            int monthSelect = comboBox1.SelectedIndex+1;
            if (monthSelect == 1 || monthSelect == 3 || monthSelect == 5 || monthSelect == 7|| 
                monthSelect == 8 || monthSelect == 10 || monthSelect == 12) 
            { 
                ngay_cbb.Items.Clear();
                for(int i = 1; i<= 31; i++)
                {
                    ngay_cbb.Items.Add(i);
                }
                ngay_cbb.SelectedItem = "1";
            }else if (monthSelect == 4 || monthSelect == 6 || monthSelect == 9 || monthSelect == 11)
            {
                ngay_cbb.Items.Clear();
                for (int i = 1; i <= 30; i++)
                {
                    ngay_cbb.Items.Add(i);
                }
            }else if(monthSelect == 2)
            {
                ngay_cbb.Items.Clear();
                for (int i = 1; i <= 28; i++)
                {
                    ngay_cbb.Items.Add(i);
                }
            }

            //hiển thị doanh thu ngày theo hệ thống
            ngay = Convert.ToInt32(ngay_cbb.SelectedItem?.ToString());
            thang = Convert.ToInt32(comboBox1.SelectedItem?.ToString());
            nam = Convert.ToInt32(comboBox2.SelectedItem?.ToString());

            var checkDTN = db.THONGKEs.FirstOrDefault(x => x.ngay == ngay && x.thang == thang && x.nam == nam);
            if(checkDTN != null)
            {
                dtHeThong_lb.Text = checkDTN.doanhThuHeThong.ToString();
            }
            else return;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string d = tienDauCa_ip.Text;
            string c = tienCuoiCa_ip.Text;
            string ngay = ngay_cbb.SelectedItem?.ToString();
            string thang = comboBox1.SelectedItem?.ToString();
            string nam = comboBox2.SelectedItem?.ToString();

            
            int ngayINT = Convert.ToInt32(ngay);
            int thangINT = Convert.ToInt32(thang);
            int namINT = Convert.ToInt32(nam);

            var checkNgay = db.THONGKEs.FirstOrDefault(x=>x.ngay == ngayINT 
                                                           && x.thang == thangINT 
                                                           && x.nam == namINT);
            

            int number;
            if (ngay == null || thang == null || nam == null)
            {
                MessageBox.Show("NHẬP ĐẦY ĐỦ NGÀY THÁNG NĂM!");
            }
            else if (string.IsNullOrWhiteSpace(d) || string.IsNullOrWhiteSpace(c))
            {
                MessageBox.Show("NHẬP ĐẦY ĐỦ THÔNG TIN TIỀN ĐẦU CA VÀ TIỀN CUỐI CA!");
            }
            else if(!int.TryParse(d,out number)){
                MessageBox.Show("NHẬP TIỀN ĐẦU CA LÀ SỐ!");
            }else if(!int.TryParse(c,out number))
            {
                MessageBox.Show("NHẬP TIỀN CUỐI CA LÀ SỐ!");    
            }else if (checkNgay.doanhThuThucTe != null)
            {
                MessageBox.Show("DOANH THU NGÀY NÀY ĐÃ ĐƯỢC BÁO CÁO!");
            }
            else
            {
                int tienDauCa = Convert.ToInt32(tienDauCa_ip.Text);
                int tienCuoiCa = Convert.ToInt32(tienCuoiCa_ip.Text);
                int sum = tienCuoiCa - tienDauCa;
                if (tienDauCa>tienCuoiCa)
                {
                    MessageBox.Show("TIỀN CUỐI CA KHÔNG THỂ NHỎ HƠN TIỀN ĐẦU CA!");
                }else
                {
                   
                    if(checkNgay == null)
                    { 
                        var tkn = new THONGKE
                        {
                            manv = valll.nhanvien.manv,
                            ngay = ngayINT,
                            thang = thangINT,
                            nam = namINT,
                            doanhThuThucTe = sum,
                        };
                        db.THONGKEs.Add(tkn);
                        db.SaveChanges();
                        MessageBox.Show("ĐÃ GỬI BÁO CÁO THÀNH CÔNG!");

                    }
                    else if(checkNgay.doanhThuThucTe == null)
                    {
                        checkNgay.doanhThuThucTe = sum;
                        MessageBox.Show("ĐÃ GỬI BÁO CÁO THÀNH CÔNG!");
                        db.SaveChanges();
                    }
                   
                    
                }
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {

            // Lưu giá trị từ ComboBox vào biến tương ứng
            a = ngay_cbb.SelectedItem?.ToString() ?? "1";
            b = comboBox1.SelectedItem?.ToString() ?? "N/A";
            c = comboBox2.SelectedItem?.ToString() ?? "N/A";


            int ngay = int.Parse(a);
            int thang = int.Parse(b);
            int nam = int.Parse(c);

            var doanhThu = db.THONGKEs.FirstOrDefault(x => x.ngay == ngay
                                                            && x.thang == thang
                                                            && x.nam == nam);
            if (doanhThu == null)
            {
                dtHeThong_lb.Text = "Không Có Doanh Thu!";
            }
            else
            {
                dtHeThong_lb.Text = doanhThu.doanhThuHeThong.ToString();
            }
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
