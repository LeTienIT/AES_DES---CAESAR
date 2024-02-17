using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace AES_DES
{
    class Khoa
    {
        
        ChuoiNhiPhan KhoaChinhNhiPhan; 
        public ChuoiNhiPhan[] DayKhoaPhu { get; private set; } 
        
        public Khoa(string khoa)
        {
            KhoaChinhNhiPhan = new ChuoiNhiPhan(0);
            foreach (var ch in khoa)
            {
                KhoaChinhNhiPhan = KhoaChinhNhiPhan.Cong(ChuoiNhiPhan.ChuyenSoSangNhiPhan(ChuoiHexa.ChuyenHexaSangHe10(ch), 4));
            }
            
        }
        
        public bool KiemTraKhoa()
        {
            return (KhoaChinhNhiPhan.DoDai % 64 == 0);
        }
       
        public void SinhKhoaCon()
        {
            DayKhoaPhu = new ChuoiNhiPhan[16];
            ChuoiNhiPhan C0, D0, MotKhoaPhu;
            
            ChuoiNhiPhan[] ChuoiSauPC1 = CacThongSo.TinhPC1(KhoaChinhNhiPhan);
            
            C0 = ChuoiSauPC1[0];
            D0 = ChuoiSauPC1[1];
           
            for (int i = 0; i < 16; i++)
            {
                
                C0 = C0.DichTraiBit(CacThongSo.soBitDichTaiCacVong[i]);
                D0 = D0.DichTraiBit(CacThongSo.soBitDichTaiCacVong[i]);
                
                MotKhoaPhu = CacThongSo.TinhPC2(C0, D0);

                DayKhoaPhu[i] = MotKhoaPhu;
            }

        }
    }
}
