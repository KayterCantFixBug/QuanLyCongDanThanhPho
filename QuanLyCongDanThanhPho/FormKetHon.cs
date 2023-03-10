using QuanLyCongDanThanhPho;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FormHonNhan
{
    public partial class FormKetHon : Form
    {
        DBConnection db = new DBConnection();
        public FormKetHon()
        {
            InitializeComponent();
            WireEvents(this);
        }
        public void InFormationIsCorrect()
        {
            MessageBox.Show("Xac minh thanh cong!");
        }
        public void InFormationIsWrong()
        {
            MessageBox.Show("Thong tin khong chinh xac!!!");
        }
        public bool Check(CongDan cd)
        {
            try
            {
                db.conn.Open();
                int Macd = cd.Macd;
                string sqlStr = string.Format(
                    "SELECT CongDan.MaCD, HoTen, NgaySinh " +
                    "FROM CongDan " +
                    "WHERE " +
                    $"CongDan.MaCD = {Macd} ");
                //string sqlStr = string.Format(
                //    "SELECT CongDan.MaCD, HoTen, NgaySinh " +
                //    "FROM CongDan, CanCuocCongDan " +
                //    "WHERE CanCuocCongDan.MaCD = CongDan.MaCD AND " +
                //    $"CongDan.MaCD = {Macd} ");
                SqlCommand cmd = new SqlCommand(sqlStr, db.conn);
                SqlDataReader reader = cmd.ExecuteReader();
                CongDan CD = new CongDan();
                while (reader.Read())
                {
                    string str = reader.GetDateTime(2).ToString("d/M/yyyy");
                    CD = new CongDan(reader.GetInt32(0), reader.GetString(1), str, "", "", "", "", "", "");
                }
                if (cd.Equals(CD))
                    return true;
                return false;
            }
            catch (Exception exc)
            {
                InFormationIsWrong();
            }
            finally
            {
                db.conn.Close();
            }
            return true;
        }
        private void btnCheck_Click(object sender, EventArgs e)
        {
            try
            {
                CongDan cdNam = new CongDan(int.Parse(txtMaCDA.Text), txtNameA.Text, dtBirthA.Text, "", "", "", "", "", "");
                CongDan cdNu = new CongDan(int.Parse(txtMaCDB.Text), txtNameB.Text, dtBirthB.Text, "", "", "", "", "", "");
                if (Check(cdNam) && Check(cdNu) && !string.IsNullOrEmpty(txtAddress.Text))
                {
                    InFormationIsCorrect();
                    btnSend.Enabled = true;
                }
                else
                {
                    InFormationIsWrong();
                }
            }
            catch (Exception exc)
            {
                InFormationIsWrong();
            }
        }
        private void dtRegister_ValueChanged(object sender, EventArgs e)
        {
            if (DateTime.Compare(dtRegister.Value, DateTime.Now) < 0)
            {
                dtRegister.Value = DateTime.Now;
                MessageBox.Show("Khong duoc chon ngay be hon ngay hien tai!!");
            }
        }
        public void WireEvents(Control Controls)
        {
            foreach(Control control in Controls.Controls)
            {
                if (control is TableLayoutPanel tableLayoutPanel)
                {
                    WireEvents(tableLayoutPanel);
                }
                if (control is TextBox textBox)
                {
                    textBox.TextChanged += AnyControl_ValueChanged;
                }else if(control is RadioButton radioButton)
                {
                    radioButton.CheckedChanged += AnyControl_ValueChanged;
                }else if( control is ComboBox comboBox)
                {
                    comboBox.SelectedIndexChanged += AnyControl_ValueChanged;
                }else if(control is DateTimePicker dateTimePicker)
                {
                    dateTimePicker.ValueChanged += AnyControl_ValueChanged;
                }
            }
        }
        private void AnyControl_ValueChanged(object sender, EventArgs e)
        {
            btnSend.Enabled = false;
        }

        private void FormKetHon_Load(object sender, EventArgs e)
        {
            Random random = new Random();
            int code = random.Next(10000000);
            lbCode.Text = code.ToString();
        }
    }
}