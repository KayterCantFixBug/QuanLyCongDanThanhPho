using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCongDanThanhPho
{
    public class HoKhau
    {
        int maho;
        int chuho;
        string tinhthanh;
        string quanhuyen;
        string phuongxa;

        public string Tinhthanh { get => tinhthanh; set => tinhthanh = value; }
        public string Quanhuyen { get => quanhuyen; set => quanhuyen = value; }
        public string Phuongxa { get => phuongxa; set => phuongxa = value; }
        public int Maho { get => maho; set => maho = value; }
        public int Chuho { get => chuho; set => chuho = value; }

        public HoKhau() { }

        public HoKhau(int maho, int chuho, string tinhthanh, string quanhuyen, string phuongxa)
        {
            this.maho= maho;
            this.chuho = chuho;
            this.tinhthanh = tinhthanh;
            this.quanhuyen = quanhuyen;
            this.phuongxa = phuongxa;
        }
    }
}
