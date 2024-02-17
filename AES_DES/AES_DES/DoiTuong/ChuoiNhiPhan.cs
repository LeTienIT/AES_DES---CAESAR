using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AES_DES
{
    class ChuoiNhiPhan
    {
        
        public int[] MangNhiPhan { get; set; } 
        private double _doDai;
        string _text = "";
        public int DoDai
        {
            get { return MangNhiPhan.Length; }
        }

        
        public ChuoiNhiPhan(int doDai)
        {
            MangNhiPhan = new int[doDai];
        }
        
        public ChuoiNhiPhan(int[] mangNhiPhan)
        {
            MangNhiPhan = mangNhiPhan;
        }
        
        public ChuoiNhiPhan(char kyTu)
        {
            MangNhiPhan = new int[16];
            int MaUnicode = (int)kyTu;
            int i = 15;
            while (MaUnicode > 0)
            {
                MangNhiPhan[i] = MaUnicode % 2;
                MaUnicode = MaUnicode / 2;
                i--;
            }
        }


        public string Text
        {
            get { return GetText(); }
        }
        
        public string GetText()
        {
            string str = "";
            foreach (var ch in MangNhiPhan)
            {
                str += ch.ToString();
            }
            return str;
        }
        
        public ChuoiNhiPhan Cat(long viTriBatDau, long SoLuong)  
        {
            int[] mangNhiPhanDuocCat = new int[SoLuong];
            for (long i = viTriBatDau; i < viTriBatDau + SoLuong; i++)
            {
                mangNhiPhanDuocCat[i - viTriBatDau] = MangNhiPhan[i];
            }
            return (new ChuoiNhiPhan(mangNhiPhanDuocCat));
        }
        
        public ChuoiNhiPhan ChinhDoDai64()
        {
            int Mod = DoDai % 64;
            int thieu = 64 - Mod;
            ChuoiNhiPhan chuoiBuThieu = new ChuoiNhiPhan(thieu);
            ChuoiNhiPhan KQ = new ChuoiNhiPhan(MangNhiPhan);
            KQ = KQ.Cong(chuoiBuThieu);

            ChuoiNhiPhan ChuoiChieuDai = ChuoiNhiPhan.ChuyenSoSangNhiPhan((int)DoDai, 64);
            KQ = KQ.Cong(ChuoiChieuDai); 
            return KQ;
        }
 
        public ChuoiNhiPhan CatDuLieu64()
        {
            ChuoiNhiPhan ChuoiChieuDai = this.Cat(DoDai - 64, 64);
            long d = ChuoiNhiPhan.ChuyenNhiPhanSangSo(ChuoiChieuDai); 

            ChuoiNhiPhan KQ = this.Cat(0, DoDai - 64); 
            if (d < 0 || d > KQ.DoDai)
                return null;
            KQ = KQ.Cat(0, d);
            return KQ;
        }

        
        public ChuoiNhiPhan XOR(ChuoiNhiPhan Chuoi2)
        {
            if (DoDai != Chuoi2.DoDai)
                return null;
            ChuoiNhiPhan ChuoiKQ = new ChuoiNhiPhan(DoDai);
            int x = 0, y = 0;
            for (int i = 0; i < ChuoiKQ.DoDai; i++)
            {
                x = MangNhiPhan[i];
                y = Chuoi2.MangNhiPhan[i];
                if (x != y) // XOR
                {
                    ChuoiKQ.MangNhiPhan[i] = 1;
                }
                else
                {
                    ChuoiKQ.MangNhiPhan[i] = 0;
                }
            }
            return ChuoiKQ;
        }
       
        public ChuoiNhiPhan DichTraiBit(int SoBitDich)
        {
            ChuoiNhiPhan KQ = new ChuoiNhiPhan(MangNhiPhan);
            int tam = 0;
            for (int i = 0; i < SoBitDich; i++) 
            {
                tam = MangNhiPhan[0];
                for (int j = 0; j < MangNhiPhan.Length - 1; j++)
                {
                    KQ.MangNhiPhan[j] = MangNhiPhan[j + 1]; 
                }
                KQ.MangNhiPhan[MangNhiPhan.Length - 1] = tam; 
            }
            return (KQ);
        }
       
        public ChuoiNhiPhan Cong(ChuoiNhiPhan chuoi2)
        {
            ChuoiNhiPhan ChuoiKQ = new ChuoiNhiPhan(chuoi2.DoDai + this.DoDai);
            for (int i = 0; i < DoDai; i++)
            {
                ChuoiKQ.MangNhiPhan[i] = MangNhiPhan[i];
            }
            for (int i = 0; i < chuoi2.DoDai; i++)
            {
                ChuoiKQ.MangNhiPhan[DoDai + i] = chuoi2.MangNhiPhan[i];
            }
            return ChuoiKQ; 
        }
        
        public ChuoiNhiPhan[] ChiaDoi()
        {
            ChuoiNhiPhan ChuoiTrai = new ChuoiNhiPhan(this.DoDai / 2);
            ChuoiNhiPhan ChuoiPhai = new ChuoiNhiPhan(DoDai - ChuoiTrai.DoDai);
            for (int i = 0; i < ChuoiTrai.DoDai; i++)
            {
                ChuoiTrai.MangNhiPhan[i] = MangNhiPhan[i];
            }
            for (int i = 0; i < ChuoiPhai.DoDai; i++)
            {
                ChuoiPhai.MangNhiPhan[i] = MangNhiPhan[i + ChuoiTrai.DoDai];
            }
            return (new ChuoiNhiPhan[] { ChuoiTrai, ChuoiPhai });
        }
        
        public ChuoiNhiPhan[] Chia(int SoLuong)
        {
            ChuoiNhiPhan[] KQ = new ChuoiNhiPhan[SoLuong];
            ChuoiNhiPhan chuoi;
            int SoBit = DoDai / SoLuong; 
            int[] NhiPhan = new int[SoBit];
            int leng = SoBit;
            for (int i = 0; i < SoLuong; i++)
            {
                if (i * SoBit + SoBit > DoDai)
                {
                    SoBit = DoDai - i * SoBit;
                }
                NhiPhan = new int[SoBit];
                for (int j = i * SoBit; j < i * SoBit + SoBit; j++)
                {
                    NhiPhan[j - i * SoBit] = MangNhiPhan[j];
                }
                chuoi = new ChuoiNhiPhan(NhiPhan);
                KQ[i] = chuoi;
            }
            return (KQ);
        }
        

        public static ChuoiNhiPhan ChuyenSoSangNhiPhan(int SoInput, int doDai)
        {
            ChuoiNhiPhan ChuoiKQ = new ChuoiNhiPhan(doDai);
            int i = doDai - 1;
            while (SoInput > 0)
            {
                ChuoiKQ.MangNhiPhan[i] = SoInput % 2;
                SoInput = SoInput / 2;
                i--;
            }
            return ChuoiKQ;
        }
        public static int[] ChuyenSoSangMangNhiPhan(int SoInput, int doDai)
        {
            int[] MangNhiPhan = new int[doDai];
            int i = doDai - 1;
            while (SoInput > 0)
            {
                MangNhiPhan[i] = SoInput % 2;
                SoInput = SoInput / 2;
                i--;
            }
            return MangNhiPhan;
        }

        
        public static string ChuyenSoSangStringNhiPhan(int SoInput, int doDai)
        {
            return ChuyenSoSangNhiPhan(SoInput, doDai).Text;
        }
        
        public static int ChuyenNhiPhanSangSo(ChuoiNhiPhan ChuoiVao)
        {
            int KQ = 0;
            for (int i = ChuoiVao.DoDai - 1; i >= 0; i--)
            {
                KQ += ChuoiVao.MangNhiPhan[i] * (int)Math.Pow(2, ChuoiVao.DoDai - i - 1);
            }
            return KQ;
        }

        
        public static ChuoiNhiPhan ChuyenChuSangChuoiNhiPhan(string ChuoiVao)
        {
            try
            {
                ChuoiVao = ChuoiVao.Trim();
                int[] mangNhiPhan = new int[ChuoiVao.Length];
                for (int i = ChuoiVao.Length - 1; i >= 0; i--)
                {
                    mangNhiPhan[i] = int.Parse(ChuoiVao[i].ToString());
                }
                return (new ChuoiNhiPhan(mangNhiPhan));
            }
            catch (Exception ex)
            {

                return null;
            }

        }

        public static int ChuyenMangSangByte(int[] mang, int batDau, int KetThuc)
        {

            int KQ = 0;
            for (int i = KetThuc - 1; i >= batDau; i--)
            {
                KQ += mang[i] * (int)Math.Pow(2, KetThuc - i - 1);
            }
            return KQ;


        }
        
        public static int ChuyenNhiPhanSangSo(string ChuoiVao)
        {
            int KQ = 0;
            for (int i = ChuoiVao.Length - 1; i >= 0; i--)
            {
                KQ += int.Parse(ChuoiVao[i].ToString()) * (int)Math.Pow(2, ChuoiVao.Length - i - 1);
            }
            return KQ;
        }
        
        public static string ChuyenNhiPhanSangChu(ChuoiNhiPhan ChuoiVao)
        {

            int soChu = ChuoiVao.DoDai / 16;
            ChuoiNhiPhan[] MangChuoi = ChuoiVao.Chia(soChu);
            string KQ = "";
            foreach (var ch in MangChuoi)
            {
                KQ += (char)ChuyenNhiPhanSangSo(ch);
            }
            return KQ;

        }
      
        public static ChuoiNhiPhan ChuyenChuSangNhiPhan(string text)
        {
            ChuoiNhiPhan KQ = new ChuoiNhiPhan(0);
            ChuoiNhiPhan chuoi;
            foreach (var ch in text)
            {
                chuoi = new ChuoiNhiPhan(ch);
                KQ = KQ.Cong(chuoi);
            }
            return KQ;

        }
        public static ChuoiNhiPhan ChuyenKhoaSangNhiPhan(string text)
        {
            ChuoiNhiPhan KQ = new ChuoiNhiPhan(0);
            ChuoiNhiPhan chuoi;
            foreach (var ch in text)
            {
                chuoi = ChuoiNhiPhan.ChuyenSoSangNhiPhan((int)ch, 16);
                KQ = KQ.Cong(chuoi);
            }
            return KQ;

        }
    }
}
