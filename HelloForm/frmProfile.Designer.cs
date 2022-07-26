
namespace HelloForm
{
    partial class frmProfile
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProfile));
            this.label1 = new System.Windows.Forms.Label();
            this.picAva = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtQueQuan = new System.Windows.Forms.TextBox();
            this.txtNoiSinh = new System.Windows.Forms.TextBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.txtHoDem = new System.Windows.Forms.TextBox();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.rdbNam = new System.Windows.Forms.RadioButton();
            this.rdbNu = new System.Windows.Forms.RadioButton();
            this.rdbKhac = new System.Windows.Forms.RadioButton();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnBoQua = new System.Windows.Forms.Button();
            this.txtMSV = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.lbMSV = new System.Windows.Forms.Label();
            this.lbTextMSV = new System.Windows.Forms.Label();
            this.lbHoDem = new System.Windows.Forms.Label();
            this.lbTen = new System.Windows.Forms.Label();
            this.lbNoiSinh = new System.Windows.Forms.Label();
            this.lbQueQuan = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbSDT = new System.Windows.Forms.Label();
            this.lbTextHoDem = new System.Windows.Forms.Label();
            this.lbTextTen = new System.Windows.Forms.Label();
            this.lbTextNoiSinh = new System.Windows.Forms.Label();
            this.lbTextQueQuan = new System.Windows.Forms.Label();
            this.lbTextSDT = new System.Windows.Forms.Label();
            this.lbTextEmail = new System.Windows.Forms.Label();
            this.lbTextGioiTinh = new System.Windows.Forms.Label();
            this.lbGioiTinh = new System.Windows.Forms.Label();
            this.btnXML = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picAva)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(246, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thông tin sinh viên";
            // 
            // picAva
            // 
            this.picAva.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picAva.Image = ((System.Drawing.Image)(resources.GetObject("picAva.Image")));
            this.picAva.Location = new System.Drawing.Point(28, 107);
            this.picAva.Name = "picAva";
            this.picAva.Size = new System.Drawing.Size(165, 238);
            this.picAva.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAva.TabIndex = 1;
            this.picAva.TabStop = false;
            this.picAva.Click += new System.EventHandler(this.picAva_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(218, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Họ đệm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(218, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(218, 271);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 29);
            this.label4.TabIndex = 4;
            this.label4.Text = "Ngày sinh";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(218, 334);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 29);
            this.label5.TabIndex = 5;
            this.label5.Text = "Nơi sinh";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(218, 478);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 29);
            this.label6.TabIndex = 6;
            this.label6.Text = "Quê quán";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(218, 588);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(154, 29);
            this.label7.TabIndex = 7;
            this.label7.Text = "Số điện thoại";
            // 
            // txtSDT
            // 
            this.txtSDT.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSDT.Location = new System.Drawing.Point(378, 583);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(341, 34);
            this.txtSDT.TabIndex = 9;
            // 
            // txtQueQuan
            // 
            this.txtQueQuan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtQueQuan.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQueQuan.Location = new System.Drawing.Point(378, 473);
            this.txtQueQuan.Multiline = true;
            this.txtQueQuan.Name = "txtQueQuan";
            this.txtQueQuan.Size = new System.Drawing.Size(341, 79);
            this.txtQueQuan.TabIndex = 8;
            // 
            // txtNoiSinh
            // 
            this.txtNoiSinh.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNoiSinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNoiSinh.Location = new System.Drawing.Point(378, 306);
            this.txtNoiSinh.Multiline = true;
            this.txtNoiSinh.Name = "txtNoiSinh";
            this.txtNoiSinh.Size = new System.Drawing.Size(341, 80);
            this.txtNoiSinh.TabIndex = 4;
            // 
            // txtTen
            // 
            this.txtTen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTen.Location = new System.Drawing.Point(378, 204);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(341, 34);
            this.txtTen.TabIndex = 2;
            // 
            // txtHoDem
            // 
            this.txtHoDem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtHoDem.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoDem.Location = new System.Drawing.Point(378, 141);
            this.txtHoDem.Name = "txtHoDem";
            this.txtHoDem.Size = new System.Drawing.Size(341, 34);
            this.txtHoDem.TabIndex = 1;
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.CustomFormat = "dd/MM/yyyy";
            this.dtpNgaySinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgaySinh.Location = new System.Drawing.Point(378, 266);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(169, 34);
            this.dtpNgaySinh.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(218, 423);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 29);
            this.label8.TabIndex = 15;
            this.label8.Text = "Giới tính";
            // 
            // rdbNam
            // 
            this.rdbNam.AutoSize = true;
            this.rdbNam.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbNam.Location = new System.Drawing.Point(378, 419);
            this.rdbNam.Name = "rdbNam";
            this.rdbNam.Size = new System.Drawing.Size(85, 33);
            this.rdbNam.TabIndex = 5;
            this.rdbNam.TabStop = true;
            this.rdbNam.Text = "Nam";
            this.rdbNam.UseVisualStyleBackColor = true;
            // 
            // rdbNu
            // 
            this.rdbNu.AutoSize = true;
            this.rdbNu.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbNu.Location = new System.Drawing.Point(469, 419);
            this.rdbNu.Name = "rdbNu";
            this.rdbNu.Size = new System.Drawing.Size(65, 33);
            this.rdbNu.TabIndex = 6;
            this.rdbNu.TabStop = true;
            this.rdbNu.Text = "Nữ";
            this.rdbNu.UseVisualStyleBackColor = true;
            // 
            // rdbKhac
            // 
            this.rdbKhac.AutoSize = true;
            this.rdbKhac.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbKhac.Location = new System.Drawing.Point(540, 421);
            this.rdbKhac.Name = "rdbKhac";
            this.rdbKhac.Size = new System.Drawing.Size(88, 33);
            this.rdbKhac.TabIndex = 7;
            this.rdbKhac.TabStop = true;
            this.rdbKhac.Text = "Khác";
            this.rdbKhac.UseVisualStyleBackColor = true;
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(378, 646);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(341, 34);
            this.txtEmail.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(218, 651);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 29);
            this.label9.TabIndex = 20;
            this.label9.Text = "Email";
            // 
            // btnLuu
            // 
            this.btnLuu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Location = new System.Drawing.Point(429, 736);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(141, 36);
            this.btnLuu.TabIndex = 11;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnBoQua
            // 
            this.btnBoQua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBoQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBoQua.Location = new System.Drawing.Point(590, 736);
            this.btnBoQua.Name = "btnBoQua";
            this.btnBoQua.Size = new System.Drawing.Size(129, 36);
            this.btnBoQua.TabIndex = 12;
            this.btnBoQua.Text = "Bỏ qua";
            this.btnBoQua.UseVisualStyleBackColor = true;
            this.btnBoQua.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtMSV
            // 
            this.txtMSV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMSV.Location = new System.Drawing.Point(378, 71);
            this.txtMSV.Name = "txtMSV";
            this.txtMSV.Size = new System.Drawing.Size(341, 34);
            this.txtMSV.TabIndex = 0;
            this.txtMSV.Validating += new System.ComponentModel.CancelEventHandler(this.txtMSV_Validating);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(218, 81);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(146, 29);
            this.label10.TabIndex = 22;
            this.label10.Text = "Mã sinh viên";
            // 
            // lbMSV
            // 
            this.lbMSV.AutoSize = true;
            this.lbMSV.BackColor = System.Drawing.Color.White;
            this.lbMSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMSV.ForeColor = System.Drawing.Color.Red;
            this.lbMSV.Location = new System.Drawing.Point(698, 75);
            this.lbMSV.Name = "lbMSV";
            this.lbMSV.Size = new System.Drawing.Size(20, 29);
            this.lbMSV.TabIndex = 23;
            this.lbMSV.Text = "!";
            this.lbMSV.Visible = false;
            // 
            // lbTextMSV
            // 
            this.lbTextMSV.AutoSize = true;
            this.lbTextMSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTextMSV.ForeColor = System.Drawing.Color.Red;
            this.lbTextMSV.Location = new System.Drawing.Point(378, 110);
            this.lbTextMSV.Name = "lbTextMSV";
            this.lbTextMSV.Size = new System.Drawing.Size(239, 24);
            this.lbTextMSV.TabIndex = 24;
            this.lbTextMSV.Text = "Vui lòng nhập mã sinh viên";
            this.lbTextMSV.Visible = false;
            // 
            // lbHoDem
            // 
            this.lbHoDem.AutoSize = true;
            this.lbHoDem.BackColor = System.Drawing.Color.White;
            this.lbHoDem.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHoDem.ForeColor = System.Drawing.Color.Red;
            this.lbHoDem.Location = new System.Drawing.Point(698, 143);
            this.lbHoDem.Name = "lbHoDem";
            this.lbHoDem.Size = new System.Drawing.Size(20, 29);
            this.lbHoDem.TabIndex = 25;
            this.lbHoDem.Text = "!";
            this.lbHoDem.Visible = false;
            // 
            // lbTen
            // 
            this.lbTen.AutoSize = true;
            this.lbTen.BackColor = System.Drawing.Color.White;
            this.lbTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTen.ForeColor = System.Drawing.Color.Red;
            this.lbTen.Location = new System.Drawing.Point(698, 208);
            this.lbTen.Name = "lbTen";
            this.lbTen.Size = new System.Drawing.Size(20, 29);
            this.lbTen.TabIndex = 26;
            this.lbTen.Text = "!";
            this.lbTen.Visible = false;
            // 
            // lbNoiSinh
            // 
            this.lbNoiSinh.AutoSize = true;
            this.lbNoiSinh.BackColor = System.Drawing.Color.White;
            this.lbNoiSinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNoiSinh.ForeColor = System.Drawing.Color.Red;
            this.lbNoiSinh.Location = new System.Drawing.Point(698, 334);
            this.lbNoiSinh.Name = "lbNoiSinh";
            this.lbNoiSinh.Size = new System.Drawing.Size(20, 29);
            this.lbNoiSinh.TabIndex = 27;
            this.lbNoiSinh.Text = "!";
            this.lbNoiSinh.Visible = false;
            // 
            // lbQueQuan
            // 
            this.lbQueQuan.AutoSize = true;
            this.lbQueQuan.BackColor = System.Drawing.Color.White;
            this.lbQueQuan.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQueQuan.ForeColor = System.Drawing.Color.Red;
            this.lbQueQuan.Location = new System.Drawing.Point(697, 491);
            this.lbQueQuan.Name = "lbQueQuan";
            this.lbQueQuan.Size = new System.Drawing.Size(20, 29);
            this.lbQueQuan.TabIndex = 28;
            this.lbQueQuan.Text = "!";
            this.lbQueQuan.Visible = false;
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.BackColor = System.Drawing.Color.White;
            this.lbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmail.ForeColor = System.Drawing.Color.Red;
            this.lbEmail.Location = new System.Drawing.Point(698, 650);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(20, 29);
            this.lbEmail.TabIndex = 29;
            this.lbEmail.Text = "!";
            this.lbEmail.Visible = false;
            // 
            // lbSDT
            // 
            this.lbSDT.AutoSize = true;
            this.lbSDT.BackColor = System.Drawing.Color.White;
            this.lbSDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSDT.ForeColor = System.Drawing.Color.Red;
            this.lbSDT.Location = new System.Drawing.Point(697, 587);
            this.lbSDT.Name = "lbSDT";
            this.lbSDT.Size = new System.Drawing.Size(20, 29);
            this.lbSDT.TabIndex = 30;
            this.lbSDT.Text = "!";
            this.lbSDT.Visible = false;
            // 
            // lbTextHoDem
            // 
            this.lbTextHoDem.AutoSize = true;
            this.lbTextHoDem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTextHoDem.ForeColor = System.Drawing.Color.Red;
            this.lbTextHoDem.Location = new System.Drawing.Point(378, 177);
            this.lbTextHoDem.Name = "lbTextHoDem";
            this.lbTextHoDem.Size = new System.Drawing.Size(199, 24);
            this.lbTextHoDem.TabIndex = 31;
            this.lbTextHoDem.Text = "Vui lòng nhập họ đệm";
            this.lbTextHoDem.Visible = false;
            // 
            // lbTextTen
            // 
            this.lbTextTen.AutoSize = true;
            this.lbTextTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTextTen.ForeColor = System.Drawing.Color.Red;
            this.lbTextTen.Location = new System.Drawing.Point(378, 241);
            this.lbTextTen.Name = "lbTextTen";
            this.lbTextTen.Size = new System.Drawing.Size(167, 24);
            this.lbTextTen.TabIndex = 32;
            this.lbTextTen.Text = "Vui lòng nhập Tên";
            this.lbTextTen.Visible = false;
            // 
            // lbTextNoiSinh
            // 
            this.lbTextNoiSinh.AutoSize = true;
            this.lbTextNoiSinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTextNoiSinh.ForeColor = System.Drawing.Color.Red;
            this.lbTextNoiSinh.Location = new System.Drawing.Point(378, 392);
            this.lbTextNoiSinh.Name = "lbTextNoiSinh";
            this.lbTextNoiSinh.Size = new System.Drawing.Size(199, 24);
            this.lbTextNoiSinh.TabIndex = 33;
            this.lbTextNoiSinh.Text = "Vui lòng nhập nơi sinh";
            this.lbTextNoiSinh.Visible = false;
            // 
            // lbTextQueQuan
            // 
            this.lbTextQueQuan.AutoSize = true;
            this.lbTextQueQuan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTextQueQuan.ForeColor = System.Drawing.Color.Red;
            this.lbTextQueQuan.Location = new System.Drawing.Point(378, 557);
            this.lbTextQueQuan.Name = "lbTextQueQuan";
            this.lbTextQueQuan.Size = new System.Drawing.Size(214, 24);
            this.lbTextQueQuan.TabIndex = 34;
            this.lbTextQueQuan.Text = "Vui lòng nhập quê quán";
            this.lbTextQueQuan.Visible = false;
            // 
            // lbTextSDT
            // 
            this.lbTextSDT.AutoSize = true;
            this.lbTextSDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTextSDT.ForeColor = System.Drawing.Color.Red;
            this.lbTextSDT.Location = new System.Drawing.Point(378, 619);
            this.lbTextSDT.Name = "lbTextSDT";
            this.lbTextSDT.Size = new System.Drawing.Size(241, 24);
            this.lbTextSDT.TabIndex = 35;
            this.lbTextSDT.Text = "Vui lòng nhập số điện thoại";
            this.lbTextSDT.Visible = false;
            // 
            // lbTextEmail
            // 
            this.lbTextEmail.AutoSize = true;
            this.lbTextEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTextEmail.ForeColor = System.Drawing.Color.Red;
            this.lbTextEmail.Location = new System.Drawing.Point(378, 684);
            this.lbTextEmail.Name = "lbTextEmail";
            this.lbTextEmail.Size = new System.Drawing.Size(178, 24);
            this.lbTextEmail.TabIndex = 36;
            this.lbTextEmail.Text = "Vui lòng nhập email";
            this.lbTextEmail.Visible = false;
            // 
            // lbTextGioiTinh
            // 
            this.lbTextGioiTinh.AutoSize = true;
            this.lbTextGioiTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTextGioiTinh.ForeColor = System.Drawing.Color.Red;
            this.lbTextGioiTinh.Location = new System.Drawing.Point(378, 446);
            this.lbTextGioiTinh.Name = "lbTextGioiTinh";
            this.lbTextGioiTinh.Size = new System.Drawing.Size(198, 24);
            this.lbTextGioiTinh.TabIndex = 37;
            this.lbTextGioiTinh.Text = "Vui lòng chọn giới tính";
            this.lbTextGioiTinh.Visible = false;
            // 
            // lbGioiTinh
            // 
            this.lbGioiTinh.AutoSize = true;
            this.lbGioiTinh.BackColor = System.Drawing.SystemColors.Control;
            this.lbGioiTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGioiTinh.ForeColor = System.Drawing.Color.Red;
            this.lbGioiTinh.Location = new System.Drawing.Point(625, 421);
            this.lbGioiTinh.Name = "lbGioiTinh";
            this.lbGioiTinh.Size = new System.Drawing.Size(20, 29);
            this.lbGioiTinh.TabIndex = 38;
            this.lbGioiTinh.Text = "!";
            this.lbGioiTinh.Visible = false;
            // 
            // btnXML
            // 
            this.btnXML.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXML.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXML.Location = new System.Drawing.Point(241, 736);
            this.btnXML.Name = "btnXML";
            this.btnXML.Size = new System.Drawing.Size(168, 36);
            this.btnXML.TabIndex = 39;
            this.btnXML.Text = "Lưu với XML";
            this.btnXML.UseVisualStyleBackColor = true;
            this.btnXML.Visible = false;
            this.btnXML.Click += new System.EventHandler(this.btnXML_Click);
            // 
            // frmProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 783);
            this.Controls.Add(this.btnXML);
            this.Controls.Add(this.lbGioiTinh);
            this.Controls.Add(this.lbTextGioiTinh);
            this.Controls.Add(this.lbTextEmail);
            this.Controls.Add(this.lbTextSDT);
            this.Controls.Add(this.lbTextQueQuan);
            this.Controls.Add(this.lbTextNoiSinh);
            this.Controls.Add(this.lbTextTen);
            this.Controls.Add(this.lbTextHoDem);
            this.Controls.Add(this.lbSDT);
            this.Controls.Add(this.lbEmail);
            this.Controls.Add(this.lbQueQuan);
            this.Controls.Add(this.lbNoiSinh);
            this.Controls.Add(this.lbTen);
            this.Controls.Add(this.lbHoDem);
            this.Controls.Add(this.lbTextMSV);
            this.Controls.Add(this.lbMSV);
            this.Controls.Add(this.txtMSV);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnBoQua);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.rdbKhac);
            this.Controls.Add(this.rdbNu);
            this.Controls.Add(this.rdbNam);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dtpNgaySinh);
            this.Controls.Add(this.txtHoDem);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.txtNoiSinh);
            this.Controls.Add(this.txtQueQuan);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.picAva);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "frmProfile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "---";
            this.Load += new System.EventHandler(this.frmProfile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picAva)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picAva;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtQueQuan;
        private System.Windows.Forms.TextBox txtNoiSinh;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.TextBox txtHoDem;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton rdbNam;
        private System.Windows.Forms.RadioButton rdbNu;
        private System.Windows.Forms.RadioButton rdbKhac;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnBoQua;
        private System.Windows.Forms.TextBox txtMSV;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbMSV;
        private System.Windows.Forms.Label lbTextMSV;
        private System.Windows.Forms.Label lbHoDem;
        private System.Windows.Forms.Label lbTen;
        private System.Windows.Forms.Label lbNoiSinh;
        private System.Windows.Forms.Label lbQueQuan;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label lbSDT;
        private System.Windows.Forms.Label lbTextHoDem;
        private System.Windows.Forms.Label lbTextTen;
        private System.Windows.Forms.Label lbTextNoiSinh;
        private System.Windows.Forms.Label lbTextQueQuan;
        private System.Windows.Forms.Label lbTextSDT;
        private System.Windows.Forms.Label lbTextEmail;
        private System.Windows.Forms.Label lbTextGioiTinh;
        private System.Windows.Forms.Label lbGioiTinh;
        private System.Windows.Forms.Button btnXML;
    }
}