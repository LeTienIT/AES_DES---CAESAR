﻿namespace AES_DES
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.rdDES = new System.Windows.Forms.RadioButton();
            this.rdAES = new System.Windows.Forms.RadioButton();
            this.btnSoSanh = new System.Windows.Forms.Button();
            this.btnMaHoa = new System.Windows.Forms.Button();
            this.btnGiaiMa = new System.Windows.Forms.Button();
            this.txtBanRo = new System.Windows.Forms.TextBox();
            this.txtKhoaK = new System.Windows.Forms.TextBox();
            this.txtMaHoa = new System.Windows.Forms.TextBox();
            this.txtKetQua = new System.Windows.Forms.RichTextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtAESbanro = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtAESbanma = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txtAEStocdoGM = new System.Windows.Forms.TextBox();
            this.txtAEStocdoMH = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.gb2 = new System.Windows.Forms.GroupBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDESbanro = new System.Windows.Forms.TextBox();
            this.txtDESbanma = new System.Windows.Forms.TextBox();
            this.txtDEStocdoMH = new System.Windows.Forms.TextBox();
            this.txtDEStocdoGM = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.gb1 = new System.Windows.Forms.GroupBox();
            this.label22 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnOPBro = new System.Windows.Forms.Button();
            this.btnOPK = new System.Windows.Forms.Button();
            this.btnOPBma = new System.Windows.Forms.Button();
            this.gb2.SuspendLayout();
            this.gb1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Input:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(357, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Output:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Bản rõ:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Khóa K:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(10, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Bản mã:";
            // 
            // rdDES
            // 
            this.rdDES.AutoSize = true;
            this.rdDES.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdDES.Location = new System.Drawing.Point(47, 264);
            this.rdDES.Name = "rdDES";
            this.rdDES.Size = new System.Drawing.Size(61, 24);
            this.rdDES.TabIndex = 5;
            this.rdDES.TabStop = true;
            this.rdDES.Text = "DES";
            this.rdDES.UseVisualStyleBackColor = true;
            // 
            // rdAES
            // 
            this.rdAES.AutoSize = true;
            this.rdAES.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdAES.Location = new System.Drawing.Point(178, 264);
            this.rdAES.Name = "rdAES";
            this.rdAES.Size = new System.Drawing.Size(60, 24);
            this.rdAES.TabIndex = 6;
            this.rdAES.TabStop = true;
            this.rdAES.Text = "AES";
            this.rdAES.UseVisualStyleBackColor = true;
            this.rdAES.CheckedChanged += new System.EventHandler(this.rdAES_CheckedChanged);
            // 
            // btnSoSanh
            // 
            this.btnSoSanh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSoSanh.Location = new System.Drawing.Point(8, 313);
            this.btnSoSanh.Name = "btnSoSanh";
            this.btnSoSanh.Size = new System.Drawing.Size(105, 49);
            this.btnSoSanh.TabIndex = 7;
            this.btnSoSanh.Text = "SO SÁNH";
            this.btnSoSanh.UseVisualStyleBackColor = true;
            this.btnSoSanh.Click += new System.EventHandler(this.btnSoSanh_Click);
            // 
            // btnMaHoa
            // 
            this.btnMaHoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaHoa.Location = new System.Drawing.Point(119, 313);
            this.btnMaHoa.Name = "btnMaHoa";
            this.btnMaHoa.Size = new System.Drawing.Size(91, 49);
            this.btnMaHoa.TabIndex = 8;
            this.btnMaHoa.Text = "Mã hóa";
            this.btnMaHoa.UseVisualStyleBackColor = true;
            this.btnMaHoa.Click += new System.EventHandler(this.btnMaHoa_Click);
            // 
            // btnGiaiMa
            // 
            this.btnGiaiMa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGiaiMa.Location = new System.Drawing.Point(216, 313);
            this.btnGiaiMa.Name = "btnGiaiMa";
            this.btnGiaiMa.Size = new System.Drawing.Size(102, 49);
            this.btnGiaiMa.TabIndex = 9;
            this.btnGiaiMa.Text = "Giải mã";
            this.btnGiaiMa.UseVisualStyleBackColor = true;
            this.btnGiaiMa.Click += new System.EventHandler(this.btnGiaiMa_Click);
            // 
            // txtBanRo
            // 
            this.txtBanRo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBanRo.Location = new System.Drawing.Point(77, 83);
            this.txtBanRo.Name = "txtBanRo";
            this.txtBanRo.Size = new System.Drawing.Size(198, 26);
            this.txtBanRo.TabIndex = 11;
            // 
            // txtKhoaK
            // 
            this.txtKhoaK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKhoaK.Location = new System.Drawing.Point(77, 148);
            this.txtKhoaK.Name = "txtKhoaK";
            this.txtKhoaK.Size = new System.Drawing.Size(198, 26);
            this.txtKhoaK.TabIndex = 12;
            this.txtKhoaK.TextChanged += new System.EventHandler(this.txtKhoaK_TextChanged);
            // 
            // txtMaHoa
            // 
            this.txtMaHoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaHoa.Location = new System.Drawing.Point(77, 211);
            this.txtMaHoa.Name = "txtMaHoa";
            this.txtMaHoa.Size = new System.Drawing.Size(198, 26);
            this.txtMaHoa.TabIndex = 13;
            this.txtMaHoa.TextChanged += new System.EventHandler(this.txtMaHoa_TextChanged);
            // 
            // txtKetQua
            // 
            this.txtKetQua.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtKetQua.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtKetQua.Location = new System.Drawing.Point(332, 42);
            this.txtKetQua.Name = "txtKetQua";
            this.txtKetQua.Size = new System.Drawing.Size(620, 372);
            this.txtKetQua.TabIndex = 10;
            this.txtKetQua.Text = "";
            this.txtKetQua.TextChanged += new System.EventHandler(this.txtKetQua_TextChanged);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(779, 42);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(28, 13);
            this.label20.TabIndex = 19;
            this.label20.Text = "AES";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(463, 42);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(29, 13);
            this.label21.TabIndex = 18;
            this.label21.Text = "DES";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(217, 176);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(22, 13);
            this.label12.TabIndex = 15;
            this.label12.Text = "mis";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(217, 210);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(22, 13);
            this.label11.TabIndex = 16;
            this.label11.Text = "mis";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(20, 210);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(78, 13);
            this.label13.TabIndex = 14;
            this.label13.Text = "Tốc độ giải mã";
            // 
            // txtAESbanro
            // 
            this.txtAESbanro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAESbanro.Location = new System.Drawing.Point(81, 34);
            this.txtAESbanro.Name = "txtAESbanro";
            this.txtAESbanro.Size = new System.Drawing.Size(158, 22);
            this.txtAESbanro.TabIndex = 17;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(20, 176);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(80, 13);
            this.label14.TabIndex = 13;
            this.label14.Text = "Tốc độ mã hóa";
            // 
            // txtAESbanma
            // 
            this.txtAESbanma.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAESbanma.Location = new System.Drawing.Point(81, 96);
            this.txtAESbanma.Name = "txtAESbanma";
            this.txtAESbanma.Size = new System.Drawing.Size(158, 22);
            this.txtAESbanma.TabIndex = 18;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(20, 99);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(43, 13);
            this.label15.TabIndex = 12;
            this.label15.Text = "Bản mã";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(20, 37);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(38, 13);
            this.label17.TabIndex = 11;
            this.label17.Text = "Bản rõ";
            // 
            // txtAEStocdoGM
            // 
            this.txtAEStocdoGM.Location = new System.Drawing.Point(111, 207);
            this.txtAEStocdoGM.Name = "txtAEStocdoGM";
            this.txtAEStocdoGM.Size = new System.Drawing.Size(100, 20);
            this.txtAEStocdoGM.TabIndex = 20;
            // 
            // txtAEStocdoMH
            // 
            this.txtAEStocdoMH.Location = new System.Drawing.Point(111, 173);
            this.txtAEStocdoMH.Name = "txtAEStocdoMH";
            this.txtAEStocdoMH.Size = new System.Drawing.Size(100, 20);
            this.txtAEStocdoMH.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(108, 142);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Thời gian chạy";
            // 
            // gb2
            // 
            this.gb2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gb2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gb2.Controls.Add(this.label10);
            this.gb2.Controls.Add(this.txtAEStocdoMH);
            this.gb2.Controls.Add(this.txtAEStocdoGM);
            this.gb2.Controls.Add(this.label17);
            this.gb2.Controls.Add(this.label15);
            this.gb2.Controls.Add(this.txtAESbanma);
            this.gb2.Controls.Add(this.label14);
            this.gb2.Controls.Add(this.txtAESbanro);
            this.gb2.Controls.Add(this.label13);
            this.gb2.Controls.Add(this.label11);
            this.gb2.Controls.Add(this.label12);
            this.gb2.Cursor = System.Windows.Forms.Cursors.Default;
            this.gb2.Location = new System.Drawing.Point(655, 54);
            this.gb2.Name = "gb2";
            this.gb2.Size = new System.Drawing.Size(297, 360);
            this.gb2.TabIndex = 21;
            this.gb2.TabStop = false;
            this.gb2.Enter += new System.EventHandler(this.gb2_Enter_1);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(22, 37);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(38, 13);
            this.label19.TabIndex = 0;
            this.label19.Text = "Bản rõ";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(22, 99);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(43, 13);
            this.label18.TabIndex = 1;
            this.label18.Text = "Bản mã";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Tốc độ mã hóa";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 210);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Tốc độ giải mã";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(219, 176);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(22, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "mis";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(219, 210);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(22, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "mis";
            // 
            // txtDESbanro
            // 
            this.txtDESbanro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDESbanro.Location = new System.Drawing.Point(83, 34);
            this.txtDESbanro.Name = "txtDESbanro";
            this.txtDESbanro.Size = new System.Drawing.Size(158, 22);
            this.txtDESbanro.TabIndex = 6;
            // 
            // txtDESbanma
            // 
            this.txtDESbanma.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDESbanma.Location = new System.Drawing.Point(83, 96);
            this.txtDESbanma.Name = "txtDESbanma";
            this.txtDESbanma.Size = new System.Drawing.Size(158, 22);
            this.txtDESbanma.TabIndex = 7;
            // 
            // txtDEStocdoMH
            // 
            this.txtDEStocdoMH.Location = new System.Drawing.Point(113, 173);
            this.txtDEStocdoMH.Name = "txtDEStocdoMH";
            this.txtDEStocdoMH.Size = new System.Drawing.Size(100, 20);
            this.txtDEStocdoMH.TabIndex = 8;
            // 
            // txtDEStocdoGM
            // 
            this.txtDEStocdoGM.Location = new System.Drawing.Point(113, 207);
            this.txtDEStocdoGM.Name = "txtDEStocdoGM";
            this.txtDEStocdoGM.Size = new System.Drawing.Size(100, 20);
            this.txtDEStocdoGM.TabIndex = 9;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(108, 142);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(77, 13);
            this.label16.TabIndex = 10;
            this.label16.Text = "Thời gian chạy";
            // 
            // gb1
            // 
            this.gb1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gb1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gb1.Controls.Add(this.label16);
            this.gb1.Controls.Add(this.txtDEStocdoGM);
            this.gb1.Controls.Add(this.txtDEStocdoMH);
            this.gb1.Controls.Add(this.txtDESbanma);
            this.gb1.Controls.Add(this.txtDESbanro);
            this.gb1.Controls.Add(this.label9);
            this.gb1.Controls.Add(this.label8);
            this.gb1.Controls.Add(this.label7);
            this.gb1.Controls.Add(this.label6);
            this.gb1.Controls.Add(this.label18);
            this.gb1.Controls.Add(this.label19);
            this.gb1.Cursor = System.Windows.Forms.Cursors.Default;
            this.gb1.Location = new System.Drawing.Point(341, 54);
            this.gb1.Name = "gb1";
            this.gb1.Size = new System.Drawing.Size(297, 360);
            this.gb1.TabIndex = 20;
            this.gb1.TabStop = false;
            this.gb1.Enter += new System.EventHandler(this.gb1_Enter);
            // 
            // label22
            // 
            this.label22.BackColor = System.Drawing.SystemColors.Desktop;
            this.label22.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label22.Location = new System.Drawing.Point(0, 435);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(988, 92);
            this.label22.TabIndex = 22;
            this.label22.Text = "Mã hóa Và Giải Mã DES - AES";
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 383);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(306, 31);
            this.button1.TabIndex = 23;
            this.button1.Text = "THOÁT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnOPBro
            // 
            this.btnOPBro.Location = new System.Drawing.Point(281, 83);
            this.btnOPBro.Name = "btnOPBro";
            this.btnOPBro.Size = new System.Drawing.Size(48, 23);
            this.btnOPBro.TabIndex = 24;
            this.btnOPBro.Text = "OP";
            this.btnOPBro.UseVisualStyleBackColor = true;
            this.btnOPBro.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnOPK
            // 
            this.btnOPK.Location = new System.Drawing.Point(281, 148);
            this.btnOPK.Name = "btnOPK";
            this.btnOPK.Size = new System.Drawing.Size(48, 23);
            this.btnOPK.TabIndex = 25;
            this.btnOPK.Text = "OP";
            this.btnOPK.UseVisualStyleBackColor = true;
            this.btnOPK.Click += new System.EventHandler(this.btnOPK_Click);
            // 
            // btnOPBma
            // 
            this.btnOPBma.Location = new System.Drawing.Point(281, 214);
            this.btnOPBma.Name = "btnOPBma";
            this.btnOPBma.Size = new System.Drawing.Size(48, 23);
            this.btnOPBma.TabIndex = 26;
            this.btnOPBma.Text = "OP";
            this.btnOPBma.UseVisualStyleBackColor = true;
            this.btnOPBma.Click += new System.EventHandler(this.btnOPBma_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(988, 527);
            this.Controls.Add(this.btnOPBma);
            this.Controls.Add(this.btnOPK);
            this.Controls.Add(this.btnOPBro);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.txtKetQua);
            this.Controls.Add(this.txtMaHoa);
            this.Controls.Add(this.txtKhoaK);
            this.Controls.Add(this.txtBanRo);
            this.Controls.Add(this.btnGiaiMa);
            this.Controls.Add(this.btnMaHoa);
            this.Controls.Add(this.btnSoSanh);
            this.Controls.Add(this.rdAES);
            this.Controls.Add(this.rdDES);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gb1);
            this.Controls.Add(this.gb2);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label20);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1004, 566);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1004, 566);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AES_DES_LeDacTien";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gb2.ResumeLayout(false);
            this.gb2.PerformLayout();
            this.gb1.ResumeLayout(false);
            this.gb1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rdDES;
        private System.Windows.Forms.RadioButton rdAES;
        private System.Windows.Forms.Button btnSoSanh;
        private System.Windows.Forms.Button btnMaHoa;
        private System.Windows.Forms.Button btnGiaiMa;
        private System.Windows.Forms.TextBox txtBanRo;
        private System.Windows.Forms.TextBox txtKhoaK;
        private System.Windows.Forms.TextBox txtMaHoa;
        private System.Windows.Forms.RichTextBox txtKetQua;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtAESbanro;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtAESbanma;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtAEStocdoGM;
        private System.Windows.Forms.TextBox txtAEStocdoMH;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox gb2;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtDESbanro;
        private System.Windows.Forms.TextBox txtDESbanma;
        private System.Windows.Forms.TextBox txtDEStocdoMH;
        private System.Windows.Forms.TextBox txtDEStocdoGM;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.GroupBox gb1;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnOPBro;
        private System.Windows.Forms.Button btnOPK;
        private System.Windows.Forms.Button btnOPBma;
    }
}

