using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AES_DES
{
    class ChuoiHexa
    {
        
        public string Chuoi { get; private set; } 
        private int _doDai;
        public ChuoiNhiPhan chuoiNhiPhan { get; private set; }
        public static readonly string BoHexa = "0123456789ABCDEFabcdef";
        public int DoDai
        {
            get { return Chuoi.Length; }
        }
        
        public ChuoiHexa(string chuoi)
        {
            this.Chuoi = chuoi.ToUpper(); 
            ChuoiNhiPhan chNP;//   
            if (KiemTra())
            {
                chuoiNhiPhan = new ChuoiNhiPhan(0);
                foreach (var ch in Chuoi)
                {
                    chNP = ChuoiNhiPhan.ChuyenSoSangNhiPhan(ChuoiHexa.ChuyenHexaSangHe10(ch), 4); 
                    chuoiNhiPhan = chuoiNhiPhan.Cong(chNP);
                }
            }
        }
      
        public bool KiemTra()
        {
            bool Kt = true;
            foreach (char ch in Chuoi)
            {
                if (!ChuoiHexa.BoHexa.Contains(ch))
                {
                    Kt = false;
                    break;

                }
            }
            return Kt;
        }
        
        public static int ChuyenHexaSangHe10(char K)
        {

            int KQ = 0;
            switch (K)
            {
                case '0':
                    KQ = 0;
                    break;
                case '1':
                    KQ = 1;
                    break;
                case '2':
                    KQ = 2;
                    break;
                case '3':
                    KQ = 3;
                    break;
                case '4':
                    KQ = 4;
                    break;
                case '5':
                    KQ = 5;
                    break;
                case '6':
                    KQ = 6;
                    break;
                case '7':
                    KQ = 7;
                    break;
                case '8':
                    KQ = 8;
                    break;
                case '9':
                    KQ = 9;
                    break;
                case 'A':
                    KQ = 10;
                    break;
                case 'B':
                    KQ = 11;
                    break;
                case 'C':
                    KQ = 12;
                    break;
                case 'D':
                    KQ = 13;
                    break;
                case 'E':
                    KQ = 14;
                    break;
                case 'F':
                    KQ = 15;
                    break;
            }
            return KQ;
        }


    }
}
