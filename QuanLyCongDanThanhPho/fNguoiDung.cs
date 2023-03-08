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
    public partial class fNguoiDung : Form
    {
        CongDan ob = new CongDan();
        public fNguoiDung(CongDan cd)
        {
            InitializeComponent();
            ob = cd;
            HienThongTinNguoiDung();
        }

        void HienThongTinNguoiDung()
        {
            tbTenNguoiDung.Text = ob.Hoten;
            HienThongTinCongDan();
        }

        void HienThongTinCongDan()
        {
            tbMaCD_CN.Text = ob.Macd.ToString();
            tbHoTen_CN.Text = ob.Hoten;
            dtpkNgaySinh_CN.Text = ob.Ngaysinh;
            tbNoiSinh_CN.Text = ob.Noisinh;
            tbGioiTinh_CN.Text = ob.Gioitinh;
            tbNgheNghiep_CN.Text = ob.Nghenghiep;
            tbTTHN_CN.Text = ob.Tinhtranghonnhan;
            tbDanToc_CN.Text = ob.Dantoc;
            tbTonGiao_CN.Text = ob.Tongiao;
        }

        void HienThongTinHoKhau()
        {
            
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
