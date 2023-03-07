using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCongDanThanhPho
{
    internal class CongDanDAO
    {
        DBConnection exec = new DBConnection();
        
        public CongDan LayThongTinCongDanBangMaCD(int macd)
        {
            DataTable dt = exec.LayDanhSach("SELECT * FROM dbo.CongDan WHERE MaCD = " + macd);
            foreach(DataRow dr in dt.Rows)
            {
                return new CongDan(dr);
            }
            return null;
        }
    }
}
