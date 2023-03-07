using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCongDanThanhPho
{
    public class TaiKhoan
    {
        string tentk;
        string matkhau;
        int macd;

        public string Tentk { get => tentk; set => tentk = value; }
        public string Matkhau { get => matkhau; set => matkhau = value; }
        public int Macd { get => macd; set => macd = value; }

        public TaiKhoan() { }

        public TaiKhoan(string tentk, string matkhau, int macd)
        {
            this.tentk = tentk;
            this.matkhau = matkhau;
            this.macd = macd;
        }

        public TaiKhoan(string tentk, string matkhau)
        {
            this.tentk = tentk;
            this.matkhau = matkhau;
        }
    }
}
