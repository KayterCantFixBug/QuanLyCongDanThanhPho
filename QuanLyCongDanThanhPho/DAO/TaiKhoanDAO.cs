using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCongDanThanhPho
{
    internal class TaiKhoanDAO
    {
        DBConnection exec = new DBConnection();

        public bool DangNhap(TaiKhoan ob)
        {
            string query = string.Format("SELECT * FROM dbo.TaiKhoan WHERE TenTK = N'{0}' AND MatKhau = N'{1}'", ob.Tentk, ob.Matkhau);
            DataTable result = exec.LayDanhSach(query);
            return result.Rows.Count > 0;
        }

        public int LayMaCDBangTenTK(string username)
        {
            string query = string.Format("SELECT * FROM dbo.TaiKhoan WHERE TenTK = N'{0}'", username);
            DataTable result = exec.LayDanhSach(query);
            foreach(DataRow row in result.Rows)
            {
                return (int)row["MaCD"];
            }
            return -1;
        }
    }
}
