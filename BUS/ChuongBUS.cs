using DAL;
using System;

namespace BUS
{
    public class ChuongBUS
    {
        public void xuatDuLieuChuongBUS(string duLieu)
        {
            ChuongDAL.xuatDuLieuChuongDAL(duLieu);
        }
    }
}
