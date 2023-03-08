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
            this.cbProvinceMan = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.label21 = new System.Windows.Forms.Label();
            this.txtNameA = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.txtNameB = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtCCCDA = new System.Windows.Forms.TextBox();
            this.txtCCCDB = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnState = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCheck
            // 
            this.btnCheck.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCheck.Location = new System.Drawing.Point(3, 68);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(133, 59);
            this.btnCheck.TabIndex = 4;
            this.btnCheck.Text = "Kiểm tra thông tin";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // btnSend
            // 
            this.btnSend.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSend.Enabled = false;
            this.btnSend.Location = new System.Drawing.Point(3, 3);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(133, 59);
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
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 193F));
            this.tableLayoutPanel4.Controls.Add(this.label10, 0, 8);
            this.tableLayoutPanel4.Controls.Add(this.label20, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.label23, 0, 3);
            this.tableLayoutPanel4.Controls.Add(this.label22, 0, 4);
            this.tableLayoutPanel4.Controls.Add(this.label24, 0, 5);
            this.tableLayoutPanel4.Controls.Add(this.label29, 2, 3);
            this.tableLayoutPanel4.Controls.Add(this.label30, 2, 4);
            this.tableLayoutPanel4.Controls.Add(this.label31, 2, 5);
            this.tableLayoutPanel4.Controls.Add(this.txtSDTB, 3, 4);
            this.tableLayoutPanel4.Controls.Add(this.txtAddressB, 3, 5);
            this.tableLayoutPanel4.Controls.Add(this.txtAddressA, 1, 5);
            this.tableLayoutPanel4.Controls.Add(this.dtBirthA, 1, 3);
            this.tableLayoutPanel4.Controls.Add(this.dtBirthB, 3, 3);
            this.tableLayoutPanel4.Controls.Add(this.label5, 0, 6);
            this.tableLayoutPanel4.Controls.Add(this.label6, 0, 7);
            this.tableLayoutPanel4.Controls.Add(this.label8, 2, 6);
            this.tableLayoutPanel4.Controls.Add(this.label7, 2, 8);
            this.tableLayoutPanel4.Controls.Add(this.label9, 2, 7);
            this.tableLayoutPanel4.Controls.Add(this.label25, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.txtSDTA, 1, 4);
            this.tableLayoutPanel4.Controls.Add(this.cbProvinceMan, 1, 6);
            this.tableLayoutPanel4.Controls.Add(this.comboBox2, 1, 7);
            this.tableLayoutPanel4.Controls.Add(this.comboBox3, 1, 8);
            this.tableLayoutPanel4.Controls.Add(this.comboBox4, 3, 6);
            this.tableLayoutPanel4.Controls.Add(this.comboBox5, 3, 8);
            this.tableLayoutPanel4.Controls.Add(this.comboBox6, 3, 7);
            this.tableLayoutPanel4.Controls.Add(this.label21, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.txtNameA, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.label26, 2, 1);
            this.tableLayoutPanel4.Controls.Add(this.txtNameB, 3, 1);
            this.tableLayoutPanel4.Controls.Add(this.label11, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.label12, 2, 2);
            this.tableLayoutPanel4.Controls.Add(this.txtCCCDA, 1, 2);
            this.tableLayoutPanel4.Controls.Add(this.txtCCCDB, 3, 2);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(58, 96);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 9;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(760, 404);
            this.tableLayoutPanel4.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 355);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 20);
            this.label10.TabIndex = 7;
            this.label10.Text = "Xã, phường:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(6, 3);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(158, 40);
            this.label20.TabIndex = 0;
            this.label20.Text = "Thông tin cá nhân của người đăng ký:";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(6, 135);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(77, 20);
            this.label23.TabIndex = 2;
            this.label23.Text = "Ngày sinh:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(6, 179);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(39, 20);
            this.label22.TabIndex = 1;
            this.label22.Text = "SĐT:";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(6, 223);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(58, 20);
            this.label24.TabIndex = 1;
            this.label24.Text = "Địa chỉ:";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(383, 135);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(77, 20);
            this.label29.TabIndex = 2;
            this.label29.Text = "Ngày sinh:";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(383, 179);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(39, 20);
            this.label30.TabIndex = 1;
            this.label30.Text = "SĐT:";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(383, 223);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(58, 20);
            this.label31.TabIndex = 1;
            this.label31.Text = "Địa chỉ:";
            // 
            // txtSDTB
            // 
            this.txtSDTB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSDTB.Location = new System.Drawing.Point(566, 182);
            this.txtSDTB.Name = "txtSDTB";
            this.txtSDTB.Size = new System.Drawing.Size(188, 27);
            this.txtSDTB.TabIndex = 3;
            // 
            // txtAddressB
            // 
            this.txtAddressB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtAddressB.Location = new System.Drawing.Point(566, 226);
            this.txtAddressB.Name = "txtAddressB";
            this.txtAddressB.Size = new System.Drawing.Size(188, 27);
            this.txtAddressB.TabIndex = 3;
            // 
            // txtAddressA
            // 
            this.txtAddressA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtAddressA.Location = new System.Drawing.Point(188, 226);
            this.txtAddressA.Name = "txtAddressA";
            this.txtAddressA.Size = new System.Drawing.Size(186, 27);
            this.txtAddressA.TabIndex = 3;
            // 
            // dtBirthA
            // 
            this.dtBirthA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtBirthA.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtBirthA.Location = new System.Drawing.Point(188, 138);
            this.dtBirthA.Name = "dtBirthA";
            this.dtBirthA.Size = new System.Drawing.Size(186, 27);
            this.dtBirthA.TabIndex = 4;
            // 
            // dtBirthB
            // 
            this.dtBirthB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtBirthB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtBirthB.Location = new System.Drawing.Point(566, 138);
            this.dtBirthB.Name = "dtBirthB";
            this.dtBirthB.Size = new System.Drawing.Size(188, 27);
            this.dtBirthB.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 267);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Tỉnh thành:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 311);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Quận, huyện:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(383, 267);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 20);
            this.label8.TabIndex = 5;
            this.label8.Text = "Tỉnh thành:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(383, 355);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 20);
            this.label7.TabIndex = 1;
            this.label7.Text = "Xã, phường:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(383, 311);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 20);
            this.label9.TabIndex = 6;
            this.label9.Text = "Quận, huyện:";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(383, 3);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(158, 40);
            this.label25.TabIndex = 0;
            this.label25.Text = "Thông tin cá nhân của đối tượng kết hôn:";
            // 
            // txtSDTA
            // 
            this.txtSDTA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSDTA.Location = new System.Drawing.Point(188, 182);
            this.txtSDTA.Name = "txtSDTA";
            this.txtSDTA.Size = new System.Drawing.Size(186, 27);
            this.txtSDTA.TabIndex = 3;
            // 
            // cbProvinceMan
            // 
            this.cbProvinceMan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbProvinceMan.FormattingEnabled = true;
            this.cbProvinceMan.Location = new System.Drawing.Point(188, 270);
            this.cbProvinceMan.Name = "cbProvinceMan";
            this.cbProvinceMan.Size = new System.Drawing.Size(186, 28);
            this.cbProvinceMan.TabIndex = 8;
            // 
            // comboBox2
            // 
            this.comboBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(188, 314);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(186, 28);
            this.comboBox2.TabIndex = 8;
            // 
            // comboBox3
            // 
            this.comboBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(188, 358);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(186, 28);
            this.comboBox3.TabIndex = 8;
            // 
            // comboBox4
            // 
            this.comboBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(566, 270);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(188, 28);
            this.comboBox4.TabIndex = 8;
            // 
            // comboBox5
            // 
            this.comboBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(566, 358);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(188, 28);
            this.comboBox5.TabIndex = 8;
            // 
            // comboBox6
            // 
            this.comboBox6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Location = new System.Drawing.Point(566, 314);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(188, 28);
            this.comboBox6.TabIndex = 8;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(6, 47);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(76, 20);
            this.label21.TabIndex = 0;
            this.label21.Text = "Họ và tên:";
            // 
            // txtNameA
            // 
            this.txtNameA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNameA.Location = new System.Drawing.Point(188, 50);
            this.txtNameA.Name = "txtNameA";
            this.txtNameA.Size = new System.Drawing.Size(186, 27);
            this.txtNameA.TabIndex = 3;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(383, 47);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(76, 20);
            this.label26.TabIndex = 0;
            this.label26.Text = "Họ và tên:";
            // 
            // txtNameB
            // 
            this.txtNameB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNameB.Location = new System.Drawing.Point(566, 50);
            this.txtNameB.Name = "txtNameB";
            this.txtNameB.Size = new System.Drawing.Size(188, 27);
            this.txtNameB.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 91);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 20);
            this.label11.TabIndex = 0;
            this.label11.Text = "Số CCCD:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(383, 91);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(71, 20);
            this.label12.TabIndex = 0;
            this.label12.Text = "Số CCCD:";
            // 
            // txtCCCDA
            // 
            this.txtCCCDA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCCCDA.Location = new System.Drawing.Point(188, 94);
            this.txtCCCDA.Name = "txtCCCDA";
            this.txtCCCDA.Size = new System.Drawing.Size(186, 27);
            this.txtCCCDA.TabIndex = 3;
            // 
            // txtCCCDB
            // 
            this.txtCCCDB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCCCDB.Location = new System.Drawing.Point(566, 94);
            this.txtCCCDB.Name = "txtCCCDB";
            this.txtCCCDB.Size = new System.Drawing.Size(188, 27);
            this.txtCCCDB.TabIndex = 3;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.btnSend, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnCheck, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnState, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(837, 127);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(139, 197);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // btnState
            // 
            this.btnState.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnState.Location = new System.Drawing.Point(3, 133);
            this.btnState.Name = "btnState";
            this.btnState.Size = new System.Drawing.Size(133, 61);
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
            this.tableLayoutPanel2.Controls.Add(this.dateTimePicker1, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.textBox2, 1, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(58, 506);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(760, 96);
            this.tableLayoutPanel2.TabIndex = 7;
            this.tableLayoutPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel2_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ngày đăng ký:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(249, 6);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(250, 27);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Địa điểm:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(249, 52);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(250, 27);
            this.textBox2.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(58, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(563, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Chú ý: Thông tin cần phải đúng với thông tin trong sổ hộ khẩu!!!";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(58, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(634, 59);
            this.label1.TabIndex = 9;
            this.label1.Text = "THÔNG TIN ĐĂNG KÝ KẾT HÔN";
            // 
            // FormKetHon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 627);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.tableLayoutPanel4);
            this.Name = "FormKetHon";
            this.Text = "FormKetHon";
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
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
        private TextBox textBox2;
        private DateTimePicker dateTimePicker1;
        private Label label10;
        private Label label5;
        private Label label6;
        private Label label8;
        private Label label7;
        private Label label9;
        private Label label4;
        private Label label1;
        private ComboBox cbProvinceMan;
        private ComboBox comboBox2;
        private ComboBox comboBox3;
        private ComboBox comboBox4;
        private ComboBox comboBox5;
        private ComboBox comboBox6;
        private Label label11;
        private Label label12;
        private TextBox txtCCCDA;
        private TextBox txtCCCDB;
    }
}