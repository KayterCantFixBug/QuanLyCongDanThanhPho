using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCongDanThanhPho
{
    public class CongDan
    {
        int macd;
        string hoten;
        string ngaysinh;
        string noisinh;
        string gioitinh;
        string nghenghiep;
        string tinhtranghonnhan;
        string dantoc;
        string tongiao;

        public int Macd { get => macd; set => macd = value; }
        public string Hoten { get => hoten; set => hoten = value; }
        public string Ngaysinh { get => ngaysinh; set => ngaysinh = value; }
        public string Noisinh { get => noisinh; set => noisinh = value; }
        public string Gioitinh { get => gioitinh; set => gioitinh = value; }
        public string Nghenghiep { get => nghenghiep; set => nghenghiep = value; }
        public string Tinhtranghonnhan { get => tinhtranghonnhan; set => tinhtranghonnhan = value; }
        public string Dantoc { get => dantoc; set => dantoc = value; }
        public string Tongiao { get => tongiao; set => tongiao = value; }

        public CongDan() { }

        public CongDan(int macd, string hoten, string ngaysinh, string noisinh, string gioitinh, string nghenghiep, string tinhtranghonnhan, string dantoc, string tongiao)
        {
            this.macd = macd;
            this.hoten = hoten;
            this.ngaysinh = ngaysinh;
            this.noisinh = noisinh;
            this.gioitinh = gioitinh;
            this.nghenghiep = nghenghiep;
            this.tinhtranghonnhan = tinhtranghonnhan;
            this.dantoc = dantoc;
            this.tongiao = tongiao;
        }

        public CongDan(DataRow row)
        {
            this.macd = (int)row["MaCD"];
            this.hoten = (string)row["HoTen"];
            this.ngaysinh = row["NgaySinh"].ToString();
            this.noisinh = (string)row["NoiSinh"];
            this.gioitinh = (string)row["GioiTinh"];
            this.nghenghiep = (string)row["NgheNghiep"];
            this.tinhtranghonnhan = (string)row["TinhTrangHonNhan"];
            this.dantoc = (string)row["DanToc"];
            this.tongiao = (string)row["TonGiao"];
        }

        public override bool Equals(object obj)
        {
            if (obj == null || !(obj is CongDan))
                return false;
            CongDan other = (CongDan)obj;
            return this.macd.Equals(other.macd) &&
                this.hoten.Equals(other.hoten) &&
                this.ngaysinh.Equals(other.ngaysinh) &&
                this.noisinh.Equals(other.noisinh) &&
                this.gioitinh.Equals(other.gioitinh) &&
                this.nghenghiep.Equals(other.nghenghiep) &&
                this.tinhtranghonnhan.Equals(other.tinhtranghonnhan) &&
                this.dantoc.Equals(other.dantoc) &&
                this.tongiao.Equals(other.tongiao);

        }
    }
}
