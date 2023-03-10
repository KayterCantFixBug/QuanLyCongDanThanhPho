using System.Windows.Forms;

namespace FormHonNhan
{
    partial class FormKetHon
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCheck = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.label10 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.txtSDTB = new System.Windows.Forms.TextBox();
            this.txtAddressB = new System.Windows.Forms.TextBox();
            this.txtAddressA = new System.Windows.Forms.TextBox();
            this.dtBirthA = new System.Windows.Forms.DateTimePicker();
            this.dtBirthB = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.txtSDTA = new System.Windows.Forms.TextBox();
            this.cbProvinceA = new System.Windows.Forms.ComboBox();
            this.cbDistrictA = new System.Windows.Forms.ComboBox();
            this.cbWardA = new System.Windows.Forms.ComboBox();
            this.cbProvinceB = new System.Windows.Forms.ComboBox();
            this.cbWardB = new System.Windows.Forms.ComboBox();
            this.cbDistrictB = new System.Windows.Forms.ComboBox();
            this.label21 = new System.Windows.Forms.Label();
            this.txtNameA = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.txtNameB = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtCCCDA = new System.Windows.Forms.TextBox();
            this.txtCCCDB = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtMaCDB = new System.Windows.Forms.TextBox();
            this.txtMaCDA = new System.Windows.Forms.TextBox();
            this.pnA = new System.Windows.Forms.Panel();
            this.rdoNuA = new System.Windows.Forms.RadioButton();
            this.rdoNamA = new System.Windows.Forms.RadioButton();
            this.pnB = new System.Windows.Forms.Panel();
            this.rdoNuB = new System.Windows.Forms.RadioButton();
            this.rdoNamB = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSendError = new System.Windows.Forms.Button();
            this.btnState = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.dtRegister = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.lbCode = new System.Windows.Forms.Label();
            this.tableLayoutPanel4.SuspendLayout();
            this.pnA.SuspendLayout();
            this.pnB.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCheck
            // 
            this.btnCheck.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCheck.Location = new System.Drawing.Point(3, 53);
            this.btnCheck.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(133, 47);
            this.btnCheck.TabIndex = 4;
            this.btnCheck.Text = "Kiểm tra thông tin";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // btnSend
            // 
            this.btnSend.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSend.Enabled = false;
            this.btnSend.Location = new System.Drawing.Point(3, 2);
            this.btnSend.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(133, 47);
            this.btnSend.TabIndex = 3;
            this.btnSend.Text = "Gửi yêu cầu đăng ký";
            this.btnSend.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tableLayoutPanel4.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetDouble;
            this.tableLayoutPanel4.ColumnCount = 4;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.14005F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.85995F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 180F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 221F));
            this.tableLayoutPanel4.Controls.Add(this.label10, 0, 10);
            this.tableLayoutPanel4.Controls.Add(this.label20, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.label23, 0, 5);
            this.tableLayoutPanel4.Controls.Add(this.label22, 0, 6);
            this.tableLayoutPanel4.Controls.Add(this.label24, 0, 7);
            this.tableLayoutPanel4.Controls.Add(this.label29, 2, 5);
            this.tableLayoutPanel4.Controls.Add(this.label30, 2, 6);
            this.tableLayoutPanel4.Controls.Add(this.label31, 2, 7);
            this.tableLayoutPanel4.Controls.Add(this.txtSDTB, 3, 6);
            this.tableLayoutPanel4.Controls.Add(this.txtAddressB, 3, 7);
            this.tableLayoutPanel4.Controls.Add(this.txtAddressA, 1, 7);
            this.tableLayoutPanel4.Controls.Add(this.dtBirthA, 1, 5);
            this.tableLayoutPanel4.Controls.Add(this.dtBirthB, 3, 5);
            this.tableLayoutPanel4.Controls.Add(this.label5, 0, 8);
            this.tableLayoutPanel4.Controls.Add(this.label6, 0, 9);
            this.tableLayoutPanel4.Controls.Add(this.label8, 2, 8);
            this.tableLayoutPanel4.Controls.Add(this.label7, 2, 10);
            this.tableLayoutPanel4.Controls.Add(this.label9, 2, 9);
            this.tableLayoutPanel4.Controls.Add(this.label25, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.txtSDTA, 1, 6);
            this.tableLayoutPanel4.Controls.Add(this.cbProvinceA, 1, 8);
            this.tableLayoutPanel4.Controls.Add(this.cbDistrictA, 1, 9);
            this.tableLayoutPanel4.Controls.Add(this.cbWardA, 1, 10);
            this.tableLayoutPanel4.Controls.Add(this.cbProvinceB, 3, 8);
            this.tableLayoutPanel4.Controls.Add(this.cbWardB, 3, 10);
            this.tableLayoutPanel4.Controls.Add(this.cbDistrictB, 3, 9);
            this.tableLayoutPanel4.Controls.Add(this.label21, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.txtNameA, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.label26, 2, 1);
            this.tableLayoutPanel4.Controls.Add(this.txtNameB, 3, 1);
            this.tableLayoutPanel4.Controls.Add(this.label11, 0, 4);
            this.tableLayoutPanel4.Controls.Add(this.label12, 2, 4);
            this.tableLayoutPanel4.Controls.Add(this.txtCCCDA, 1, 4);
            this.tableLayoutPanel4.Controls.Add(this.txtCCCDB, 3, 4);
            this.tableLayoutPanel4.Controls.Add(this.label13, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.label14, 0, 3);
            this.tableLayoutPanel4.Controls.Add(this.label15, 2, 2);
            this.tableLayoutPanel4.Controls.Add(this.label16, 2, 3);
            this.tableLayoutPanel4.Controls.Add(this.txtMaCDB, 3, 2);
            this.tableLayoutPanel4.Controls.Add(this.txtMaCDA, 1, 2);
            this.tableLayoutPanel4.Controls.Add(this.pnA, 1, 3);
            this.tableLayoutPanel4.Controls.Add(this.pnB, 3, 3);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(58, 147);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 11;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(760, 345);
            this.tableLayoutPanel4.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 313);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 16);
            this.label10.TabIndex = 7;
            this.label10.Text = "Xã, phường:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(6, 3);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(140, 28);
            this.label20.TabIndex = 0;
            this.label20.Text = "Thông tin cá nhân của người đăng ký:";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(6, 158);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(70, 16);
            this.label23.TabIndex = 2;
            this.label23.Text = "Ngày sinh:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(6, 189);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(37, 16);
            this.label22.TabIndex = 1;
            this.label22.Text = "SĐT:";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(6, 220);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(50, 16);
            this.label24.TabIndex = 1;
            this.label24.Text = "Địa chỉ:";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(355, 158);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(70, 16);
            this.label29.TabIndex = 2;
            this.label29.Text = "Ngày sinh:";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(355, 189);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(37, 16);
            this.label30.TabIndex = 1;
            this.label30.Text = "SĐT:";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(355, 220);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(50, 16);
            this.label31.TabIndex = 1;
            this.label31.Text = "Địa chỉ:";
            // 
            // txtSDTB
            // 
            this.txtSDTB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSDTB.Location = new System.Drawing.Point(538, 191);
            this.txtSDTB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSDTB.Name = "txtSDTB";
            this.txtSDTB.Size = new System.Drawing.Size(216, 22);
            this.txtSDTB.TabIndex = 3;
            // 
            // txtAddressB
            // 
            this.txtAddressB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtAddressB.Location = new System.Drawing.Point(538, 222);
            this.txtAddressB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAddressB.Name = "txtAddressB";
            this.txtAddressB.Size = new System.Drawing.Size(216, 22);
            this.txtAddressB.TabIndex = 3;
            // 
            // txtAddressA
            // 
            this.txtAddressA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtAddressA.Location = new System.Drawing.Point(174, 222);
            this.txtAddressA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAddressA.Name = "txtAddressA";
            this.txtAddressA.Size = new System.Drawing.Size(172, 22);
            this.txtAddressA.TabIndex = 3;
            // 
            // dtBirthA
            // 
            this.dtBirthA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtBirthA.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtBirthA.Location = new System.Drawing.Point(174, 160);
            this.dtBirthA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtBirthA.Name = "dtBirthA";
            this.dtBirthA.Size = new System.Drawing.Size(172, 22);
            this.dtBirthA.TabIndex = 4;
            this.dtBirthA.Value = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);
            // 
            // dtBirthB
            // 
            this.dtBirthB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtBirthB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtBirthB.Location = new System.Drawing.Point(538, 160);
            this.dtBirthB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtBirthB.Name = "dtBirthB";
            this.dtBirthB.Size = new System.Drawing.Size(216, 22);
            this.dtBirthB.TabIndex = 4;
            this.dtBirthB.Value = new System.DateTime(1995, 5, 5, 0, 0, 0, 0);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 251);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "Tỉnh thành:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 282);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 16);
            this.label6.TabIndex = 1;
            this.label6.Text = "Quận, huyện:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(355, 251);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 16);
            this.label8.TabIndex = 5;
            this.label8.Text = "Tỉnh thành:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(355, 313);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 16);
            this.label7.TabIndex = 1;
            this.label7.Text = "Xã, phường:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(355, 282);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 16);
            this.label9.TabIndex = 6;
            this.label9.Text = "Quận, huyện:";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(355, 3);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(162, 28);
            this.label25.TabIndex = 0;
            this.label25.Text = "Thông tin cá nhân của đối tượng kết hôn:";
            // 
            // txtSDTA
            // 
            this.txtSDTA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSDTA.Location = new System.Drawing.Point(174, 191);
            this.txtSDTA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSDTA.Name = "txtSDTA";
            this.txtSDTA.Size = new System.Drawing.Size(172, 22);
            this.txtSDTA.TabIndex = 3;
            // 
            // cbProvinceA
            // 
            this.cbProvinceA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbProvinceA.FormattingEnabled = true;
            this.cbProvinceA.Location = new System.Drawing.Point(174, 253);
            this.cbProvinceA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbProvinceA.Name = "cbProvinceA";
            this.cbProvinceA.Size = new System.Drawing.Size(172, 24);
            this.cbProvinceA.TabIndex = 8;
            // 
            // cbDistrictA
            // 
            this.cbDistrictA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbDistrictA.FormattingEnabled = true;
            this.cbDistrictA.Location = new System.Drawing.Point(174, 284);
            this.cbDistrictA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbDistrictA.Name = "cbDistrictA";
            this.cbDistrictA.Size = new System.Drawing.Size(172, 24);
            this.cbDistrictA.TabIndex = 8;
            // 
            // cbWardA
            // 
            this.cbWardA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbWardA.FormattingEnabled = true;
            this.cbWardA.Location = new System.Drawing.Point(174, 315);
            this.cbWardA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbWardA.Name = "cbWardA";
            this.cbWardA.Size = new System.Drawing.Size(172, 24);
            this.cbWardA.TabIndex = 8;
            // 
            // cbProvinceB
            // 
            this.cbProvinceB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbProvinceB.FormattingEnabled = true;
            this.cbProvinceB.Location = new System.Drawing.Point(538, 253);
            this.cbProvinceB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbProvinceB.Name = "cbProvinceB";
            this.cbProvinceB.Size = new System.Drawing.Size(216, 24);
            this.cbProvinceB.TabIndex = 8;
            // 
            // cbWardB
            // 
            this.cbWardB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbWardB.FormattingEnabled = true;
            this.cbWardB.Location = new System.Drawing.Point(538, 315);
            this.cbWardB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbWardB.Name = "cbWardB";
            this.cbWardB.Size = new System.Drawing.Size(216, 24);
            this.cbWardB.TabIndex = 8;
            // 
            // cbDistrictB
            // 
            this.cbDistrictB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbDistrictB.FormattingEnabled = true;
            this.cbDistrictB.Location = new System.Drawing.Point(538, 284);
            this.cbDistrictB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbDistrictB.Name = "cbDistrictB";
            this.cbDistrictB.Size = new System.Drawing.Size(216, 24);
            this.cbDistrictB.TabIndex = 8;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(6, 34);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(67, 16);
            this.label21.TabIndex = 0;
            this.label21.Text = "Họ và tên:";
            // 
            // txtNameA
            // 
            this.txtNameA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNameA.Location = new System.Drawing.Point(174, 36);
            this.txtNameA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNameA.Name = "txtNameA";
            this.txtNameA.Size = new System.Drawing.Size(172, 22);
            this.txtNameA.TabIndex = 3;
            this.txtNameA.Text = "Nguyễn Văn A";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(355, 34);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(67, 16);
            this.label26.TabIndex = 0;
            this.label26.Text = "Họ và tên:";
            // 
            // txtNameB
            // 
            this.txtNameB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNameB.Location = new System.Drawing.Point(538, 36);
            this.txtNameB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNameB.Name = "txtNameB";
            this.txtNameB.Size = new System.Drawing.Size(216, 22);
            this.txtNameB.TabIndex = 3;
            this.txtNameB.Text = "Trần Thị B";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 127);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 16);
            this.label11.TabIndex = 0;
            this.label11.Text = "Số CCCD:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(355, 127);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(67, 16);
            this.label12.TabIndex = 0;
            this.label12.Text = "Số CCCD:";
            // 
            // txtCCCDA
            // 
            this.txtCCCDA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCCCDA.Location = new System.Drawing.Point(174, 129);
            this.txtCCCDA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCCCDA.Name = "txtCCCDA";
            this.txtCCCDA.Size = new System.Drawing.Size(172, 22);
            this.txtCCCDA.TabIndex = 3;
            // 
            // txtCCCDB
            // 
            this.txtCCCDB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCCCDB.Location = new System.Drawing.Point(538, 129);
            this.txtCCCDB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCCCDB.Name = "txtCCCDB";
            this.txtCCCDB.Size = new System.Drawing.Size(216, 22);
            this.txtCCCDB.TabIndex = 3;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 65);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(88, 16);
            this.label13.TabIndex = 0;
            this.label13.Text = "Mã công dân:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 96);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(57, 16);
            this.label14.TabIndex = 0;
            this.label14.Text = "Giới tính:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(355, 65);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(88, 16);
            this.label15.TabIndex = 0;
            this.label15.Text = "Mã công dân:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(355, 96);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(57, 16);
            this.label16.TabIndex = 0;
            this.label16.Text = "Giới tính:";
            // 
            // txtMaCDB
            // 
            this.txtMaCDB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMaCDB.Location = new System.Drawing.Point(538, 68);
            this.txtMaCDB.Name = "txtMaCDB";
            this.txtMaCDB.Size = new System.Drawing.Size(216, 22);
            this.txtMaCDB.TabIndex = 9;
            this.txtMaCDB.Text = "2";
            // 
            // txtMaCDA
            // 
            this.txtMaCDA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMaCDA.Location = new System.Drawing.Point(174, 68);
            this.txtMaCDA.Name = "txtMaCDA";
            this.txtMaCDA.Size = new System.Drawing.Size(172, 22);
            this.txtMaCDA.TabIndex = 9;
            this.txtMaCDA.Text = "1";
            // 
            // pnA
            // 
            this.pnA.Controls.Add(this.rdoNuA);
            this.pnA.Controls.Add(this.rdoNamA);
            this.pnA.Location = new System.Drawing.Point(174, 99);
            this.pnA.Name = "pnA";
            this.pnA.Size = new System.Drawing.Size(172, 22);
            this.pnA.TabIndex = 10;
            // 
            // rdoNuA
            // 
            this.rdoNuA.AutoSize = true;
            this.rdoNuA.Dock = System.Windows.Forms.DockStyle.Right;
            this.rdoNuA.Location = new System.Drawing.Point(127, 0);
            this.rdoNuA.Name = "rdoNuA";
            this.rdoNuA.Size = new System.Drawing.Size(45, 22);
            this.rdoNuA.TabIndex = 10;
            this.rdoNuA.TabStop = true;
            this.rdoNuA.Text = "Nữ";
            this.rdoNuA.UseVisualStyleBackColor = true;
            // 
            // rdoNamA
            // 
            this.rdoNamA.AutoSize = true;
            this.rdoNamA.Checked = true;
            this.rdoNamA.Dock = System.Windows.Forms.DockStyle.Left;
            this.rdoNamA.Location = new System.Drawing.Point(0, 0);
            this.rdoNamA.Name = "rdoNamA";
            this.rdoNamA.Size = new System.Drawing.Size(57, 22);
            this.rdoNamA.TabIndex = 10;
            this.rdoNamA.TabStop = true;
            this.rdoNamA.Text = "Nam";
            this.rdoNamA.UseVisualStyleBackColor = true;
            // 
            // pnB
            // 
            this.pnB.Controls.Add(this.rdoNuB);
            this.pnB.Controls.Add(this.rdoNamB);
            this.pnB.Location = new System.Drawing.Point(538, 99);
            this.pnB.Name = "pnB";
            this.pnB.Size = new System.Drawing.Size(182, 22);
            this.pnB.TabIndex = 11;
            // 
            // rdoNuB
            // 
            this.rdoNuB.AutoSize = true;
            this.rdoNuB.Checked = true;
            this.rdoNuB.Dock = System.Windows.Forms.DockStyle.Right;
            this.rdoNuB.Location = new System.Drawing.Point(137, 0);
            this.rdoNuB.Name = "rdoNuB";
            this.rdoNuB.Size = new System.Drawing.Size(45, 22);
            this.rdoNuB.TabIndex = 10;
            this.rdoNuB.TabStop = true;
            this.rdoNuB.Text = "Nữ";
            this.rdoNuB.UseVisualStyleBackColor = true;
            // 
            // rdoNamB
            // 
            this.rdoNamB.AutoSize = true;
            this.rdoNamB.Dock = System.Windows.Forms.DockStyle.Left;
            this.rdoNamB.Location = new System.Drawing.Point(0, 0);
            this.rdoNamB.Name = "rdoNamB";
            this.rdoNamB.Size = new System.Drawing.Size(57, 22);
            this.rdoNamB.TabIndex = 10;
            this.rdoNamB.Text = "Nam";
            this.rdoNamB.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.button1, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnSendError, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnSend, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnCheck, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnState, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(836, 114);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(139, 257);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Location = new System.Drawing.Point(3, 206);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 49);
            this.button1.TabIndex = 6;
            this.button1.Text = "Làm mới";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnSendError
            // 
            this.btnSendError.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSendError.Location = new System.Drawing.Point(3, 155);
            this.btnSendError.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSendError.Name = "btnSendError";
            this.btnSendError.Size = new System.Drawing.Size(133, 47);
            this.btnSendError.TabIndex = 5;
            this.btnSendError.Text = "Báo lỗi";
            this.btnSendError.UseVisualStyleBackColor = true;
            // 
            // btnState
            // 
            this.btnState.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnState.Location = new System.Drawing.Point(3, 104);
            this.btnState.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnState.Name = "btnState";
            this.btnState.Size = new System.Drawing.Size(133, 47);
            this.btnState.TabIndex = 4;
            this.btnState.Text = "Trạng thái đăng ký";
            this.btnState.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetDouble;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.98925F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68.01075F));
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.dtRegister, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtAddress, 1, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(58, 496);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(760, 77);
            this.tableLayoutPanel2.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ngày đăng ký:";
            // 
            // dtRegister
            // 
            this.dtRegister.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtRegister.Location = new System.Drawing.Point(249, 5);
            this.dtRegister.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtRegister.Name = "dtRegister";
            this.dtRegister.Size = new System.Drawing.Size(250, 22);
            this.dtRegister.TabIndex = 7;
            this.dtRegister.Value = new System.DateTime(2023, 3, 10, 0, 0, 0, 0);
            this.dtRegister.ValueChanged += new System.EventHandler(this.dtRegister_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Địa điểm:";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(249, 42);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(250, 22);
            this.txtAddress.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(62, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(563, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Chú ý: Thông tin cần phải đúng với thông tin trong sổ hộ khẩu!!!";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 25.8F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(58, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(634, 59);
            this.label1.TabIndex = 9;
            this.label1.Text = "THÔNG TIN ĐĂNG KÝ KẾT HÔN";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(3, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(29, 16);
            this.label17.TabIndex = 10;
            this.label17.Text = "Mã:";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel3.Controls.Add(this.lbCode, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.label17, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(58, 121);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(200, 26);
            this.tableLayoutPanel3.TabIndex = 11;
            // 
            // lbCode
            // 
            this.lbCode.AutoSize = true;
            this.lbCode.Location = new System.Drawing.Point(43, 0);
            this.lbCode.Name = "lbCode";
            this.lbCode.Size = new System.Drawing.Size(0, 16);
            this.lbCode.TabIndex = 12;
            // 
            // FormKetHon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 584);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.tableLayoutPanel4);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormKetHon";
            this.Text = "FormKetHon";
            this.Load += new System.EventHandler(this.FormKetHon_Load);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.pnA.ResumeLayout(false);
            this.pnA.PerformLayout();
            this.pnB.ResumeLayout(false);
            this.pnB.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnCheck;
        private Button btnSend;
        private TableLayoutPanel tableLayoutPanel4;
        private Label label20;
        private Label label21;
        private Label label23;
        private Label label22;
        private Label label24;
        private Label label25;
        private Label label26;
        private Label label29;
        private Label label30;
        private Label label31;
        private TextBox txtNameA;
        private TextBox txtNameB;
        private TextBox txtSDTB;
        private TextBox txtAddressB;
        private TextBox txtAddressA;
        private TextBox txtSDTA;
        private DateTimePicker dtBirthA;
        private DateTimePicker dtBirthB;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label3;
        private Label label2;
        private Button btnState;
        private TextBox txtAddress;
        private DateTimePicker dtRegister;
        private Label label10;
        private Label label5;
        private Label label6;
        private Label label8;
        private Label label7;
        private Label label9;
        private Label label4;
        private Label label1;
        private ComboBox cbProvinceA;
        private ComboBox cbDistrictA;
        private ComboBox cbWardA;
        private ComboBox cbProvinceB;
        private ComboBox cbWardB;
        private ComboBox cbDistrictB;
        private Label label11;
        private Label label12;
        private TextBox txtCCCDA;
        private TextBox txtCCCDB;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label16;
        private TextBox txtMaCDB;
        private TextBox txtMaCDA;
        private RadioButton rdoNamA;
        private Panel pnA;
        private RadioButton rdoNuA;
        private Panel pnB;
        private RadioButton rdoNuB;
        private RadioButton rdoNamB;
        private Button btnSendError;
        private Button button1;
        private Label label17;
        private TableLayoutPanel tableLayoutPanel3;
        private Label lbCode;
    }
}