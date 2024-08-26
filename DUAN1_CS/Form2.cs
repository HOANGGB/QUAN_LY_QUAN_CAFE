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
    public partial class form_home : Form
    {
        private Form acform;
        private bool checkAdd = false;
        private List<Button> listBT = new List<Button>();

        public form_home()
        {
            InitializeComponent();
        }
        private void form_home_Load(object sender, EventArgs e)
        {
            setTenCN();
            cn1_bt.BackColor = Color.LightSlateGray;
        }
        public void setTenCN()
        {
            if(valll.nhanvien.chucVu =="Quản lý")
            {
                htform(new form_qlnv());
                cn1_bt.Text = "QUẢN LÝ NHÂN VIÊN";
                cn2_bt.Text = "QUẢN LÝ TỒN KHO";
                cn3_bt.Text = "QUẢN LÝ MENU";
                cn4_bt.Text = "QUẢN LÝ LỊCH LÀM";
                cn5_bt.Text = "BÁO CÁO";
            }else if (valll.nhanvien.chucVu == "Nhân viên thu ngân")
            {
                htform(new form_tinhtien());
                cn1_bt.Text = "TÍNH TIỀN";
                cn2_bt.Text = "BÁO CÁO CUỐI NGÀY";
                cn3_bt.Text = "LỊCH LÀM";
                cn4_bt.Text = "ĐANG CẬP NHẬT";
                cn5_bt.Text = "ĐANG CẬP NHẬT";

            }
            else if (valll.nhanvien.chucVu == "Nhân viên pha chế")
            {
                htform(new form_dsmon());
                cn1_bt.Text = "MÓN CẦN LÀM";
                cn2_bt.Text = "BÁO CÁO KHO";
                cn3_bt.Text = "LỊCH LÀM";
                cn4_bt.Text = "ĐANG CẬP NHẬT";
                cn5_bt.Text = "ĐANG CẬP NHẬT";
            }
            else if (valll.nhanvien.chucVu == "Nhân viên phục vụ")
            {
                htform(new form_order());
                cn1_bt.Text = "ORDER";
                cn2_bt.Text = "LỊCH LÀM";
                cn3_bt.Text = "ĐANG CẬP NHẬT";
                cn4_bt.Text = "ĐANG CẬP NHẬT";
                cn5_bt.Text = "ĐANG CẬP NHẬT";

            }
        }
        public void setOnclickCN1(string chucvu)
        {
            if(chucvu == "Quản lý")
            {
                htform(new form_qlnv());
            }else if(chucvu =="Nhân viên thu ngân")
            {
                htform(new form_tinhtien());
            }
            else if (chucvu == "Nhân viên pha chế")
            {
                htform(new form_dsmon());
            }
            else if (chucvu == "Nhân viên phục vụ")
            {
                htform(new form_order());
            }
        }
        public void setOnclickCN2(string chucvu)
        {
            if (chucvu == "Quản lý")
            {
                htform(new form_qltk());
            }
            else if (chucvu == "Nhân viên thu ngân")
            {
                htform(new form_baocaocuoingay());
            }
            else if (chucvu == "Nhân viên pha chế")
            {
                htform(new form_baocaokho());
            }
            else if (chucvu == "Nhân viên phục vụ")
            {
                htform(new form_dkll());
            }
        }
        public void setOnclickCN3(string chucvu)
        {
            if (chucvu == "Quản lý")
            {
                htform(new form_qlmenu());
            }
            else if (chucvu == "Nhân viên thu ngân")
            {
                htform(new form_dkll());
            }
            else if (chucvu == "Nhân viên pha chế")
            {
                htform(new form_dkll());
            }
            else if (chucvu == "Nhân viên phục vụ")
            {

            }
        }
        public void setOnclickCN4(string chucvu)
        {
            if(chucvu == "Quản lý")
            {
                htform(new form_qlll());
            }
        }
        public void setOnclickCN5(string chucvu)
        {
            if(chucvu == "Quản lý")
            {
                htform(new form_thongke());
            }
        }
        public void CNChon(Button bt)
        {
            if (!checkAdd)
            {
                listBT.Add(cn1_bt);
                listBT.Add(cn2_bt);
                listBT.Add(cn3_bt);
                listBT.Add(cn4_bt);
                listBT.Add(cn5_bt);
            }
            foreach(var a in listBT)
            {
                if (a == bt)
                {
                    if (a.Text == "ĐANG CẬP NHẬT")
                    {
                        return;
                    }
                    else
                    {
                        a.BackColor = Color.LightSlateGray;
                    }
                }
                else
                {
                    a.BackColor = Color.LightSteelBlue;
                }
            }
        }
        public void htform(Form f)
        {
            if (acform != null)
            {
                acform.Close();
            }
            f.TopLevel = false;
            acform = f;
            f.Parent = hienthiform_pn;

            f.Size = hienthiform_pn.Size;
            f.Location = new Point(0, 0);
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;

            hienthiform_pn.Controls.Add(f);
            tenchucnang_lb.Text = f.Text;
            f.Show();
        }

        private void cn1_bt_Click(object sender, EventArgs e)
        {
            CNChon(cn1_bt);
            setOnclickCN1(valll.nhanvien.chucVu);
        }

        private void cn2_bt_Click(object sender, EventArgs e)
        {
            CNChon(cn2_bt);
            setOnclickCN2(valll.nhanvien.chucVu);
        }

        private void cn3_bt_Click(object sender, EventArgs e)
        {
            CNChon(cn3_bt);
            setOnclickCN3(valll.nhanvien.chucVu);
        }

        private void cn4_bt_Click(object sender, EventArgs e)
        {
            CNChon(cn4_bt);
            setOnclickCN4(valll.nhanvien.chucVu);
        }

        private void cn5_bt_Click(object sender, EventArgs e)
        {
            CNChon(cn5_bt);
            setOnclickCN5(valll.nhanvien.chucVu);
        }

        private void hienthiform_pn_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Click(object sender, EventArgs e)
        {
            form_doimk htf = new form_doimk();
            htf.ShowDialog();
        }
    }

    public static class valll
    {
        public static NHANVIEN nhanvien { get; set; }

    }




}
