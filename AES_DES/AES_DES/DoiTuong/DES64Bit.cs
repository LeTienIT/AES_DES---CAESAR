using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AES_DES
{
    class DES64Bit
    {
        /// <summary>
        /// Hàm mã hóa và giải mã bằng thuật toán DES 
        /// gồm 1 khóa đẻ mã hóa các chuỗi vào
        /// </summary>
        public Khoa KhoaDES { get; private set; }
        public ChuoiNhiPhan ThucHienDES(Khoa key, ChuoiNhiPhan ChuoiVaoDai, int MaHoaHayGiaiMa)
        {
            this.KhoaDES = key;
            if (MaHoaHayGiaiMa == 1) 
                ChuoiVaoDai = ChuoiVaoDai.ChinhDoDai64();

            KhoaDES.SinhKhoaCon(); 
            ChuoiNhiPhan[] DSChuoiVao = ChuoiVaoDai.Chia(ChuoiVaoDai.DoDai / 64);
            ChuoiNhiPhan ChuoiVao, ChuoiKQ;
            ChuoiKQ = new ChuoiNhiPhan(0);
            ChuoiNhiPhan[] ChuoiSauIP;
            ChuoiNhiPhan ChuoiSauIP_1;
            ChuoiNhiPhan L, R, F, TG;
            for (int k = 0; k < DSChuoiVao.Length; k++)  
            {
                
                ChuoiSauIP = CacThongSo.TinhIP(DSChuoiVao[k]);
                
                L = ChuoiSauIP[0];
                R = ChuoiSauIP[1];

                for (int i = 0; i < 16; i++)
                {
                    
                    F = HamF(R, KhoaDES.DayKhoaPhu[MaHoaHayGiaiMa == 1 ? i : 15 - i]);
                    L = L.XOR(F);
                    TG = L;
                    L = R;
                    R = TG;
                }
                
                ChuoiSauIP_1 = CacThongSo.TinhIP_1(R, L);

                
                ChuoiKQ = ChuoiKQ.Cong(ChuoiSauIP_1);
            }
            if (MaHoaHayGiaiMa == -1) 
                ChuoiKQ = ChuoiKQ.CatDuLieu64();
            return ChuoiKQ;
        }

        
        public string ThucHienDESText(Khoa key, string ChuoiVao, int MaHoaHayGiaiMa)
        {
            ChuoiNhiPhan chuoiNhiPhan;
            if (MaHoaHayGiaiMa == 1)
            {
                chuoiNhiPhan = ChuoiNhiPhan.ChuyenChuSangNhiPhan(ChuoiVao);
            }
            else
            {
                chuoiNhiPhan = ChuoiNhiPhan.ChuyenChuSangChuoiNhiPhan(ChuoiVao);
            }
            ChuoiNhiPhan KQ = ThucHienDES(key, chuoiNhiPhan, MaHoaHayGiaiMa);
            if (MaHoaHayGiaiMa == 1)
            {
                return KQ.Text;
            }
            if (KQ == null)
            {
                MessageBox.Show("Lỗi giải mã . kiểm tra khóa ");
                return "";
            }
            return ChuoiNhiPhan.ChuyenNhiPhanSangChu(KQ);
        }
        
        private ChuoiNhiPhan HamF(ChuoiNhiPhan chuoiVao, ChuoiNhiPhan KhoaCon)
        {
            ChuoiNhiPhan KQ = CacThongSo.TinhE(chuoiVao); 
            KQ = KQ.XOR(KhoaCon); 
            KQ = CacThongSo.TinhSBox(KQ); 
            KQ = CacThongSo.TinhP(KQ); 
            return KQ;
        }

    }
}
