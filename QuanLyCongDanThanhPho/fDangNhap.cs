using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCongDanThanhPho
{
    public partial class fDangNhap : Form
    {
        TaiKhoanDAO daoTK = new TaiKhoanDAO();
        CongDanDAO daoCD = new CongDanDAO();

        public fDangNhap()
        {
            InitializeComponent();
        }

        public bool DangNhap(TaiKhoan ob)
        {
            return daoTK.DangNhap(ob);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            TaiKhoan ob = new TaiKhoan(tbxUserName.Text, tbxPassword.Text);

            if (DangNhap(ob) == true)
            {
                ob.Macd = daoTK.LayMaCDBangTenTK(ob.Tentk);
                CongDan cd = daoCD.LayThongTinCongDanBangMaCD(ob.Macd);
                fNguoiDung form = new fNguoiDung(cd);
                this.Hide();
                form.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có thật sự muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
