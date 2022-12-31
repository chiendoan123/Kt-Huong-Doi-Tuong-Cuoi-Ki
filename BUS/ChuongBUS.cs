using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Text;


namespace BUS
{
    public class ChuongBUS
    {
        public static void SapXep(List<ChuongDTO> ListChuong)
        {
            string dulieu = "Idthu\tLoai";
            for (int i = 0; i < ListChuong.Count; i++)
            {
                dulieu += string.Format("\r\n{0}\t{1}", ListChuong[i].IDchuong, ListChuong[i].Tenchuong);
            }
            ChuongDAL.SapXep(dulieu);
        }
        public static void Them(List<ChuongDTO> ListChuong)
        {
            string dulieu = "IDchuong\tTenchuong\t";
            for (int i = 0; i < ListChuong.Count; i++)
            {
                dulieu += string.Format("\r\n{0}\t{1}", ListChuong[i].IDchuong, ListChuong[i].Tenchuong);
            }
            ChuongDAL.ThemChuong(dulieu);
        }
        public static void Xoa(List<ChuongDTO> ListChuong)
        {
            string dulieu = "IDchuong\tTenchuong\t";
            for (int i = 0; i < ListChuong.Count; i++)
            {
                dulieu += string.Format("\r\n{0}\t{1}", ListChuong[i].IDchuong, ListChuong[i].Tenchuong);
            }
            ChuongDAL.XoaChuong(dulieu);
        }
        public static void Sua(int idCanSua, ChuongDTO chuong)
        {
            string dulieu = chuong.IDchuong + "\t" + chuong.Tenchuong + "\t" ;
            ChuongDAL.SuaChuong(idCanSua, dulieu);
        }
        public static string timkiem(int idCanTim)
        {
            return ChuongDAL.TimKiem(idCanTim);
        }
        public static string GetAllDuLieu()
        {
            return ChuongDAL.GetAllDuLieu();
        }

        public static void Sua(List<ChuongDTO> listThus)
        {
            throw new NotImplementedException();
        }
    }
}
