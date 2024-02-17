using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.OleDb;
using System.Diagnostics;
using System.Security.Cryptography;
using Rijndael256;


namespace AES_DES
{

    public partial class Form1 : Form
    {
        AES aes = new AES();
        public Form1()
        {
            InitializeComponent();
        }
        // DES
        public string[] stringArr_NhiPhan(string key)
        {

            string[] keyBinaryArray = DES.HexToBin4bit(key);
            return keyBinaryArray;
        }

        public void Key_Binary()
        {
            string temp = "";
            foreach (var item in stringArr_NhiPhan(TextToHex(txtKhoaK.Text)))
            {
                temp += (item + " ");
            }
            txtKetQua.AppendText("  K nhị phân: " + temp + Environment.NewLine);
        }

        public void tim_K_table(string[] matranPC02_Array)
        {
            for (int i = 0; i < 16; i++)
            {
                string[] key_Array = new string[56];
                key_Array = DES.hoanVi(matranPC02_Array, DES.listCnDn[i], 48);
                DES.key_List.Add(key_Array);
            }

            for (int k = 0; k < 16; k++)
            {
                txtKetQua.AppendText("  K" + (k + 1) + " :");
                if (k < 9) txtKetQua.AppendText("  ");
                for (int j = 0; j < 48; j++)
                {
                    txtKetQua.AppendText(DES.key_List[k][j].ToString() + " ");

                }
                txtKetQua.AppendText(Environment.NewLine);
            }
        }

        public void HoanViKey()
        {
            string[] binaryStr64 = DES.Convert_16unit4bit_To_64unit1bit(stringArr_NhiPhan(TextToHex(txtKhoaK.Text)));
            string[] strArray = DES.hoanVi(DES.MT_PC1, binaryStr64, 56);
            string temp = "";

            for (int i = 0; i < strArray.Length; i++)
            {
                temp += strArray[i];
                if ((i + 1) % 4 == 0) temp += " ";
            }

            txtKetQua.AppendText("  K hoán vị  : " + temp + Environment.NewLine);
        }

        public void CnDnTable()
        {
            string[] binaryStr64 = DES.Convert_16unit4bit_To_64unit1bit(stringArr_NhiPhan(TextToHex(txtKhoaK.Text)));
            string[] keyHoanVi = DES.hoanVi(DES.MT_PC1, binaryStr64, 56);
            DES.CnDnTable(DES.Dich_CnDn, keyHoanVi);

            txtKetQua.AppendText(Environment.NewLine);
            for (int i = 0; i <= 16; i++)
            {

                txtKetQua.AppendText("  C" + i + ": ");
                if (i <= 9) txtKetQua.AppendText("  ");
                for (int j = 0; j < 28; j++)
                {

                    txtKetQua.AppendText((DES.listCn[i][j] + " "));
                }
                txtKetQua.AppendText("|D" + i + ": ");
                if (i <= 9) txtKetQua.AppendText("  ");
                for (int j = 0; j < 28; j++)
                {

                    txtKetQua.AppendText((DES.listDn[i][j] + " "));

                }
                txtKetQua.AppendText(Environment.NewLine);
            }
        }
        public void TimLnRn_MaHoa(string plainText)
        {
            tim_K_table(DES.MT_PC2);
            for (int i = 0; i < 16; i++)
            {

                DES.L0R0(stringArr_NhiPhan(plainText));
                string[] f = DES.KeyXorER(DES.key_List[i], DES.listRn[i]);

                string[] Bn_array = DES.Bn(f);
                DES.listSboxOut.Add(Bn_array);
                DES.timXY(Bn_array);
                DES.hoanViFquaSBox(Bn_array);
                string[] tempSnBn = DES.DecimalToBin4bit(DES.SnBnArray);
                DES.listSnBnArray.Add(tempSnBn);
                string[] binaryStr = DES.Convert_8unit4bit_To_32unit1bit(tempSnBn);
                string[] F_RK = DES.hoanVi(DES.MT_P, binaryStr, 32);
                DES.listFRK.Add(F_RK);
                string[] temp = DES.listRn[i];
                DES.listLn.Insert(i + 1, temp);

                string[] temp2 = DES.L_Xor_F_RK(DES.listLn[i], F_RK);
                DES.listRn.Insert(i + 1, temp2);

            }

        }

        public void TimLR_GiaiMa(string cypher)
        {

            Key_Binary();

            HoanViKey();

            CnDnTable();
            tim_K_table(DES.MT_PC2);
            string cypherText = cypher;
            string[] ipNegative1 = DES.HexToBin4bit(cypherText);
            ipNegative1 = DES.Convert_16unit4bit_To_64unit1bit(ipNegative1);
            string[] L16R16 = DES.hoanViNguoc(DES.MT_IP_negative1, ipNegative1);
            string[] temp = new string[32];

            for (int j = 0; j < 32; j++)
            {
                temp[j] = L16R16[j];
            }
            DES.listLn.Add(temp);
            temp = new string[32];
            int index = 0;
            for (int j = 32; j < 64; j++)
            {
                temp[index] = L16R16[j];
                index++;
            }
            DES.listRn.Add(temp);
            int ind = 0;
            for (int i = 15; i >= 0; i--)
            {


                string[] f = DES.KeyXorER(DES.key_List[i], DES.listRn[ind]);

                string[] Bn_array = DES.Bn(f);
                DES.listSboxOut.Add(Bn_array);
                DES.timXY(Bn_array);
                DES.hoanViFquaSBox(Bn_array);
                string[] tempSnBn = DES.DecimalToBin4bit(DES.SnBnArray);
                DES.listSnBnArray.Add(tempSnBn);
                string[] binaryStr = DES.Convert_8unit4bit_To_32unit1bit(tempSnBn);
                string[] F_RK = DES.hoanVi(DES.MT_P, binaryStr, 32);
                DES.listFRK.Add(F_RK);
                string[] temp1 = DES.listRn[ind];

                DES.listLn.Insert(ind + 1, temp1);

                string[] temp2 = DES.L_Xor_F_RK(DES.listLn[ind], F_RK);
                DES.listRn.Insert(ind + 1, temp2);
                ind++;
            }
        }

        private bool isComparisonVisible = false;
        private void btnSoSanh_Click(object sender, EventArgs e)
        {
            isComparisonVisible = !isComparisonVisible;
            txtKetQua.Visible = isComparisonVisible;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private string TextToHex(string text)
        {
            StringBuilder hexBuilder = new StringBuilder();
            foreach (char c in text)
            {
                int decimalValue = (int)c;
                string hex = decimalValue.ToString("X2");
                hexBuilder.Append(hex);
            }
            return hexBuilder.ToString();
        }
        private string HexToText(string hex)
        {
            StringBuilder textBuilder = new StringBuilder();
            for (int i = 0; i < hex.Length; i += 2)
            {
                string hexByte = hex.Substring(i, 2);
                int decimalValue = Convert.ToInt32(hexByte, 16);
                char character = (char)decimalValue;
                textBuilder.Append(character);
            }
            return textBuilder.ToString();
        }
        public static string RemoveCharacter(string input, char character)
        {
            string result = input.Replace(character.ToString(), string.Empty);
            return result;
        }
        public string ketquatamthoi = "";
        private void btnMaHoa_Click(object sender, EventArgs e)
        {

            if (rdDES.Checked)
            {
                Stopwatch st = new Stopwatch();
                st.Start();
                txtKetQua.Clear();
                
                if (txtBanRo.Text == "")
                {
                    MessageBox.Show("Mời bạn nhập dữ liệu cần mã hóa!", "Thông báo", MessageBoxButtons.OK);
                    txtBanRo.Focus();
                    return;
                }
                if (txtKhoaK.Text.Length != 8)
                {
                    MessageBox.Show("  Độ dài K phải = 8!", "Thông báo");
                    return;
                }
                string cypherText = "";
                string x = txtBanRo.Text;
                string plainText = TextToHex(txtBanRo.Text);
                txtDESbanro.Text = txtBanRo.Text;
                if (plainText.Length % 16 != 0)
                {
                    while (plainText.Length % 16 != 0)
                    {
                        plainText += "F";
                    }
                }
                string mahoa1 = "";
                txtBanRo.Text = plainText;
                string[] plainTextArray = new string[plainText.Length / 16];
                int index = 0;
                for (int i = 0; i < plainTextArray.Length; i++)
                {
                    plainTextArray[i] = plainText.Substring(index, 16);
                    index += 16;
                }

                txtKetQua.AppendText("Bản rõ chia thành các đoạn: ");
                txtKetQua.AppendText(Environment.NewLine);
                for (int i = 0; i < plainTextArray.Length; i++)
                {
                    txtKetQua.AppendText("  Đoạn " + (i + 1) + ": ");
                    txtKetQua.AppendText(plainTextArray[i]);
                    txtKetQua.AppendText(Environment.NewLine);
                }
                string banMaSoSanh1 = "";
                for (int k = 0; k < plainTextArray.Length; k++)
                {

                    txtKetQua.AppendText(Environment.NewLine);
                    txtKetQua.AppendText("  Đoạn rõ " + (k + 1) + ": " + plainTextArray[k]); txtKetQua.AppendText(Environment.NewLine);
                    plainText = plainTextArray[k];
                    Key_Binary();

                    HoanViKey();

                    CnDnTable();


                    txtKetQua.AppendText(Environment.NewLine);

                    TimLnRn_MaHoa(plainText);
                    txtKetQua.AppendText(Environment.NewLine);
                    txtKetQua.AppendText("  L0:" + string.Join("", DES.listLn[0]));
                    txtKetQua.AppendText("  R0:" + string.Join("", DES.listRn[0]));
                    for (int i = 1; i <= 16; i++)
                    {
                        txtKetQua.AppendText(Environment.NewLine);
                        txtKetQua.AppendText(Environment.NewLine);
                        txtKetQua.AppendText("----------------------------------------------------------------------Vòng " + i + "---------------------------------------------------------------");


                        txtKetQua.AppendText(Environment.NewLine);
                        txtKetQua.AppendText("  L" + i + " :"); if (i <= 9) txtKetQua.AppendText("  ");
                        for (int j = 0; j < DES.listLn[i].Length; j++)
                            txtKetQua.AppendText(DES.listLn[i][j]);

                        txtKetQua.AppendText(Environment.NewLine);

                        txtKetQua.AppendText("  E(R" + (i - 1) + ") :"); if (i <= 9) txtKetQua.AppendText("  ");
                        txtKetQua.AppendText(string.Join(" ", DES.listE_R[i - 1]));
                        txtKetQua.AppendText(Environment.NewLine);

                        txtKetQua.AppendText("  K" + (i) + ":"); if (i <= 9) txtKetQua.AppendText("  ");
                        txtKetQua.AppendText(string.Join(" ", DES.key_List[i - 1]));
                        txtKetQua.AppendText(Environment.NewLine);

                        txtKetQua.AppendText("  ER" + (i - 1) + " XOR K" + (i) + ":"); if (i <= 9) txtKetQua.AppendText("  ");
                        txtKetQua.AppendText(string.Join(" ", DES.listERXorK[i - 1]));
                        txtKetQua.AppendText(Environment.NewLine);

                        txtKetQua.AppendText("  SBox_Out " + (i) + ":"); if (i <= 9) txtKetQua.AppendText("  ");
                        txtKetQua.AppendText(string.Join(" ", DES.listSboxOut[i - 1]));
                        txtKetQua.AppendText(Environment.NewLine);

                        txtKetQua.AppendText("  S" + (i) + "  B" + (i) + ":"); if (i <= 9) txtKetQua.AppendText("  ");
                        txtKetQua.AppendText(string.Join(" ", DES.listSnBnArray[i - 1]));
                        txtKetQua.AppendText(Environment.NewLine);

                        txtKetQua.AppendText("  F(R" + (i - 1) + "K" + (i) + "):"); if (i <= 9) txtKetQua.AppendText("  ");
                        txtKetQua.AppendText(string.Join(" ", DES.listFRK[i - 1]));

                        txtKetQua.AppendText(Environment.NewLine);
                        txtKetQua.AppendText("  L" + (i - 1) + " :"); if (i <= 9) txtKetQua.AppendText("  ");
                        for (int j = 0; j < DES.listLn[i].Length; j++)
                            txtKetQua.AppendText(DES.listLn[i - 1][j] + " ");
                        txtKetQua.AppendText(Environment.NewLine);
                        txtKetQua.AppendText("  R" + i + " :"); if (i <= 9) txtKetQua.AppendText("  ");
                        for (int j = 0; j < DES.listRn[i].Length; j++)
                            txtKetQua.AppendText(DES.listRn[i][j] + " ");

                    }
                    string[] R16L16 = DES.listRn[16].Concat(DES.listLn[16]).ToArray();
                    string[] hoanviIpNegative1 = DES.hoanVi(DES.MT_IP_negative1, R16L16, 64);

                    txtKetQua.AppendText(Environment.NewLine);
                    txtKetQua.AppendText(Environment.NewLine);
                    string hoanviIpNegative1Str = string.Join("", hoanviIpNegative1);
                    txtKetQua.AppendText("  IP-1:" + hoanviIpNegative1Str);
                    cypherText += DES.binary4bitToHexDecimal(hoanviIpNegative1Str); txtKetQua.AppendText(Environment.NewLine);
                    txtKetQua.AppendText("  Bản mã của đoạn: " + HexToText(cypherText)); txtKetQua.AppendText(Environment.NewLine);
                    txtKetQua.AppendText("_____________________________________________________________________________________"); txtKetQua.AppendText(Environment.NewLine);
                    banMaSoSanh1 = HexToText(DES.binary4bitToHexDecimal(hoanviIpNegative1Str));
                    mahoa1 = HexToText(DES.binary4bitToHexDecimal(hoanviIpNegative1Str));
                    DES.DisposeAll();
                }
                MaHoaHayGiaiMa = 1;
                MaHoa();
                txtMaHoa.Text = HexToText(cypherText);
                txtDESbanma.Text = banMaSoSanh1;
                txtBanRo.Text = x;
                st.Stop();
                txtDEStocdoMH.Text = st.ElapsedMilliseconds.ToString();
            }
            else if (rdAES.Checked)
            {
                Stopwatch st1 = new Stopwatch();
                st1.Start();
                txtKetQua.Text = "";
                // code 

                if (txtBanRo.Text != "")
                {
                    try
                    {
                        string plaintext = txtBanRo.Text;
                        string password = txtKhoaK.Text;
                        txtAESbanro.Text = plaintext;
                        StringBuilder encryptionProcess = new StringBuilder();
                        StringBuilder matrixDisplay = new StringBuilder();

                        // Encrypt the plaintext
                        string encryptedText = aes.Encrypt(plaintext, password, 128);

                        txtKetQua.Clear();

                        txtKetQua.AppendText("Bước 1: Đọc dữ liệu rõ\n");
                        txtKetQua.AppendText("   Dữ liệu rõ: " + plaintext + "\n\n");

                        txtKetQua.AppendText("Bước 2: Mã hóa với Rijndael\n");
                        txtKetQua.AppendText("   Khóa: " + password + "\n");
                        txtKetQua.AppendText("   Bits: " + 128 + "\n\n");

                        txtKetQua.AppendText("Bước 3: Hiển thị quá trình mã hóa và ma trận\n");

                        byte[] encryptedBytes = Encoding.UTF8.GetBytes(encryptedText);
                        int rows = 10; // Số hàng của ma trận (có thể thay đổi)
                        int columns = encryptedBytes.Length / rows; // Số cột của ma trận

                        for (int i = 0; i < rows; i++)
                        {
                            for (int j = 0; j < columns; j++)
                            {
                                int index = i * columns + j;
                                if (index < encryptedBytes.Length)
                                {
                                    encryptionProcess.Append(encryptedBytes[index].ToString() + " ");
                                    matrixDisplay.Append(encryptedBytes[index].ToString().PadLeft(3));
                                }
                            }
                            encryptionProcess.Append("\n");
                            matrixDisplay.Append("\n");
                        }

                        txtKetQua.AppendText("   Quá trình mã hóa:\n");
                        txtKetQua.AppendText(encryptionProcess.ToString());
                        txtKetQua.AppendText("\n   Ma trận mã hóa:\n");
                        txtKetQua.AppendText(matrixDisplay.ToString());

                        txtKetQua.AppendText("\nBước 4: Kết quả mã hóa\n");
                        txtKetQua.AppendText("   Kết quả mã hóa: " + encryptedText + "\n");
                        txtMaHoa.Text = encryptedText;
                        txtAESbanma.Text = encryptedText;
                    }
                    catch
                    {
                        MessageBox.Show("Không Mã Hóa được", "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Ô Nội Dung không được rỗng", "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                st1.Stop();
                txtAEStocdoMH.Text = st1.ElapsedMilliseconds.ToString();
            }
            else
            {
                MessageBox.Show("Thông báo!", "Vui lòng chọn DES hoặc AES để tiếp tục !!!", MessageBoxButtons.OK);
            }
        }
        //giai ma 
        int MaHoaHayGiaiMa = 1;
  
        DES64Bit MaHoaDES64;
        Khoa Khoa;
        public static string TenTienTrinh = "";
        public static int GiaiDoan = -1;
        private static int Dem = 0;
        public string chuoitamthoi = "";
        private void MaHoa()
        {
            MaHoaDES64 = new DES64Bit();
            GiaiDoan = 0;
            Dem = 0;
            Khoa = new Khoa(TextToHex(txtKhoaK.Text));
            char CharacterRemove = 'ÿ';
            if (MaHoaHayGiaiMa == 1)
            {

                MaHoaDES64 = new DES64Bit();
                GiaiDoan = 0;
                GiaiDoan = 1;
                string kq = MaHoaDES64.ThucHienDESText(Khoa,RemoveCharacter(HexToText(txtBanRo.Text),CharacterRemove), 1);
                chuoitamthoi = kq;      

                GiaiDoan = 2;
                GiaiDoan = 3;            
            }
            else
            {
                MaHoaDES64 = new DES64Bit();
                GiaiDoan = 0;
                GiaiDoan = 1;
                string kq = MaHoaDES64.ThucHienDESText(Khoa, chuoitamthoi, -1);
                txtBanRo.Text = kq;
                txtKetQua.AppendText(Environment.NewLine);
                txtKetQua.AppendText(kq);
                txtKetQua.AppendText(Environment.NewLine);
                if (kq == "")
                {
                    return;
                }
                GiaiDoan = 2;
                GiaiDoan = 3;
            }
        }

        private void btnGiaiMa_Click(object sender, EventArgs e)
        {
            Stopwatch st3 = new Stopwatch();
            st3.Start();
            if (rdDES.Checked)
            {
                txtKetQua.Clear();
                if (txtKhoaK.Text.Length != 8)
                {
                    MessageBox.Show("  Độ dài K phải = 8!", "Thông báo");
                    return;
                }
                if (txtMaHoa.Text == "")
                {
                    MessageBox.Show("Mời bạn nhập dữ liệu cần giải mã!", "Thông báo");
                    return;
                }
                string cypher = "";
                string cypherText1 = TextToHex(txtMaHoa.Text);
                if(cypherText1.Length % 16 != 0)
                {
                    while (cypherText1.Length % 16 != 0)
                    {
                        cypherText1 += "F";
                    }
                }              
                
                string[] cypherTextArray = new string[cypherText1.Length / 16];
                int index1 = 0;
                for (int i = 0; i < cypherTextArray.Length; i++)
                {
                    cypherTextArray[i] = cypherText1.Substring(index1, 16);
                    index1 += 16;
                }

                txtKetQua.AppendText("  Bản mã chia thành các đoạn: ");
                txtKetQua.AppendText(Environment.NewLine);
                for (int i = 0; i < cypherTextArray.Length; i++)
                {
                    txtKetQua.AppendText("  Đoạn " + (i + 1) + ": ");
                    txtKetQua.AppendText(cypherTextArray[i]);
                    txtKetQua.AppendText(Environment.NewLine);
                }
                string giaima2 = "";
                for (int k = 0; k < cypherTextArray.Length; k++)
                {

                    txtKetQua.AppendText(Environment.NewLine);
                    txtKetQua.AppendText("  Đoạn rõ " + (k + 1) + ": " + cypherTextArray[k]); txtKetQua.AppendText(Environment.NewLine);
                    cypher = cypherTextArray[k];
                                
                    TimLR_GiaiMa(cypher);
                    string[] R0L0 = DES.listRn[16].Concat(DES.listLn[16]).ToArray();
                    string[] cypherText = DES.hoanViNguoc(DES.MT_IP, R0L0);

                    string banRoCuaDoan = DES.binary4bitToHexDecimal(string.Join("", cypherText));
                    txtBanRo.Text += banRoCuaDoan;

                    txtKetQua.AppendText(Environment.NewLine);
                    txtKetQua.AppendText("  L0:" + string.Join("", DES.listLn[0]));
                    txtKetQua.AppendText("  R0:" + string.Join("", DES.listRn[0]));
                    int index = 16;
                    
                    for (int i = 1; i <= 16; i++)
                    {
                        txtKetQua.AppendText(Environment.NewLine);
                        txtKetQua.AppendText(Environment.NewLine);
                        txtKetQua.AppendText("----------------------------------------------------------------------Vòng " + i + "---------------------------------------------------------------");


                        txtKetQua.AppendText(Environment.NewLine);
                        txtKetQua.AppendText("  L" + i + " :"); if (i <= 9) txtKetQua.AppendText("  ");
                        for (int j = 0; j < DES.listLn[i].Length; j++)
                            txtKetQua.AppendText(DES.listLn[i][j]);

                        txtKetQua.AppendText(Environment.NewLine);

                        txtKetQua.AppendText("  E(R" + (i - 1) + ") :"); if (i <= 9) txtKetQua.AppendText("  ");
                        txtKetQua.AppendText(string.Join(" ", DES.listE_R[i - 1]));
                        txtKetQua.AppendText(Environment.NewLine);

                        txtKetQua.AppendText("  K" + (index) + ":"); if (i <= 9) txtKetQua.AppendText("  ");
                        txtKetQua.AppendText(string.Join(" ", DES.key_List[index - 1]));
                        txtKetQua.AppendText(Environment.NewLine);

                        txtKetQua.AppendText("  ER" + (i - 1) + " XOR K" + (index) + ":"); if (i <= 9) txtKetQua.AppendText("  ");
                        txtKetQua.AppendText(string.Join(" ", DES.listERXorK[i - 1]));
                        txtKetQua.AppendText(Environment.NewLine);

                        txtKetQua.AppendText("  SBox_Out " + (i) + ":"); if (i <= 9) txtKetQua.AppendText("  ");
                        txtKetQua.AppendText(string.Join(" ", DES.listSboxOut[i - 1]));
                        txtKetQua.AppendText(Environment.NewLine);

                        txtKetQua.AppendText("  S" + (i) + "  B" + (i) + ":"); if (i <= 9) txtKetQua.AppendText("  ");
                        txtKetQua.AppendText(string.Join(" ", DES.listSnBnArray[i - 1]));
                        txtKetQua.AppendText(Environment.NewLine);

                        txtKetQua.AppendText("  F(R" + (i - 1) + "K" + (index) + "):"); if (i <= 9) txtKetQua.AppendText("  ");
                        txtKetQua.AppendText(string.Join(" ", DES.listFRK[i - 1]));

                        txtKetQua.AppendText(Environment.NewLine);
                        txtKetQua.AppendText("  L" + (i - 1) + " :"); if (i <= 9) txtKetQua.AppendText("  ");
                        for (int j = 0; j < DES.listLn[i].Length; j++)
                            txtKetQua.AppendText(DES.listLn[i - 1][j] + " ");
                        txtKetQua.AppendText(Environment.NewLine);
                        txtKetQua.AppendText("  R" + i + " :"); if (i <= 9) txtKetQua.AppendText("  ");
                        for (int j = 0; j < DES.listRn[i].Length; j++)
                            txtKetQua.AppendText(DES.listRn[i][j] + " ");

                        index--;
                    }
                    char removeChar = 'ÿ';
                    txtKetQua.AppendText(Environment.NewLine);
                    txtKetQua.AppendText("  Bản rõ của đoạn: ");
                    giaima2 = RemoveCharacter(HexToText(banRoCuaDoan), removeChar);
                    txtKetQua.AppendText(Environment.NewLine);

                    DES.DisposeAll();
                }

                MaHoaHayGiaiMa = -1;
                MaHoa();
                txtKetQua.AppendText("_____________________________________________________________________________________"); txtKetQua.AppendText(Environment.NewLine);
                
                st3.Stop();
                txtDEStocdoGM.Text = st3.ElapsedMilliseconds.ToString();
            }
            else if (rdAES.Checked)
            {
                Stopwatch st4 = new Stopwatch();
                st4.Start();
                txtKetQua.Text = "";

                if (txtMaHoa.Text != "")
                {
                    try
                    {
                        string decryptedText = aes.Decrypt(txtMaHoa.Text, txtKhoaK.Text, 128);

                        txtKetQua.Clear();

                        txtKetQua.AppendText("Bước 1: Đọc dữ liệu đã mã hóa\n");
                        txtKetQua.AppendText("   Dữ liệu đã mã hóa: " + txtMaHoa.Text + "\n\n");

                        txtKetQua.AppendText("Bước 2: Giải mã với Rijndael\n");
                        txtKetQua.AppendText("   Khóa: " + txtKhoaK.Text + "\n");
                        txtKetQua.AppendText("   Bits: " + 128 + "\n\n");

                        txtKetQua.AppendText("Bước 3: Hiển thị quá trình giải mã và ma trận\n");

                        byte[] decryptedBytes = Encoding.UTF8.GetBytes(decryptedText);
                        int rows = 5; // Số hàng của ma trận (có thể thay đổi)
                        int columns = decryptedBytes.Length / rows; // Số cột của ma trận

                        StringBuilder decryptionProcess = new StringBuilder();
                        StringBuilder matrixDisplay = new StringBuilder();

                        for (int i = 0; i < rows; i++)
                        {
                            for (int j = 0; j < columns; j++)
                            {
                                int index = i * columns + j;
                                if (index < decryptedBytes.Length)
                                {
                                    decryptionProcess.Append(decryptedBytes[index].ToString() + " ");
                                    matrixDisplay.Append(decryptedBytes[index].ToString() +" ");
                                }
                            }
                            decryptionProcess.Append("\n");
                            matrixDisplay.Append("\n");
                        }

                        txtKetQua.AppendText("   Quá trình giải mã:\n");
                        txtKetQua.AppendText(decryptionProcess.ToString());
                        txtKetQua.AppendText("\n   Ma trận giải mã:\n");
                        txtKetQua.AppendText(matrixDisplay.ToString());

                        txtKetQua.AppendText("\nBước 4: Kết quả giải mã\n");
                        txtKetQua.AppendText("   Kết quả giải mã: " + decryptedText + "\n");
                        txtBanRo.Text = decryptedText; // Hiển thị kết quả giải mã trong ô văn bản txtrsdecr
                        txtAEStocdoGM.Text = decryptedText;
                    }
                    catch
                    {
                        MessageBox.Show("Không Giải Mã được", "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Ô Nội Dung không được rỗng", "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            
            st4.Stop();
                txtAEStocdoGM.Text = st4.ElapsedMilliseconds.ToString();
            }
            else
            {
                MessageBox.Show("Thông báo!", "Vui lòng chọn DES hoặc AES để tiếp tục !!!", MessageBoxButtons.OK);
            }
        }

        private void txtKhoaK_TextChanged(object sender, EventArgs e)
        {

        }

        private void rdAES_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void gb2_Enter(object sender, EventArgs e)
        {

        }

        private void gb1_Enter(object sender, EventArgs e)
        {

        }

        private void gb2_Enter_1(object sender, EventArgs e)
        {

        }

        private void txtKetQua_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMaHoa_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "van ban (txt)|*.txt";
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                string filePath = ofd.FileName;
                string content = File.ReadAllText(filePath);
                txtBanRo.Text = content;
            }
        }

        private void btnOPK_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "van ban (txt)|*.txt";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string filePath = ofd.FileName;
                string content = File.ReadAllText(filePath);
                txtKhoaK.Text = content;
            }
        }

        private void btnOPBma_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "van ban (txt)|*.txt";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string filePath = ofd.FileName;
                string content = File.ReadAllText(filePath);
                txtMaHoa.Text = content;
            }
        }
    }
}
