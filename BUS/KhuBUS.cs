using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Text;


namespace BUS
{
    public class KhuBUS
    {
        public static void SapXep(List<KhuDTO> ListKhu)
        {
            string dulieu = "Idkhu\tTenkhu";
            for (int i = 0; i < ListKhu.Count; i++)
            {
                dulieu += string.Format("\r\n{0}\t{1}", ListKhu[i].Idkhu, ListKhu[i].Tenkhu);
            }
            KhuDAL.SapXep(dulieu);
        }
        public static void Them(List<KhuDTO> ListKhu)
        {
            string dulieu = "Idkhu\tTenkhu\t";
            for (int i = 0; i < ListKhu.Count; i++)
            {
                dulieu += string.Format("\r\n{0}\t{1}", ListKhu[i].Idkhu, ListKhu[i].Tenkhu);
            }
            KhuDAL.ThemKhu(dulieu);
        }
        public static void Xoa(List<KhuDTO> ListKhu)
        {
            string dulieu = "IDchuong\tTenchuong\t";
            for (int i = 0; i < ListKhu.Count; i++)
            {
                dulieu += string.Format("\r\n{0}\t{1}", ListKhu[i].Idkhu, ListKhu[i].Tenkhu);
            }
            KhuDAL.XoaKhu(dulieu);
        }
        public static void Sua(int idCanSua, List<KhuDTO> ListKhu)
        {
            string dulieu = "Idkhu\tTenkhu\t";
            for (int i = 0; i < ListKhu.Count; i++)
            {
                dulieu += string.Format("\r\n{0}\t{1}", ListKhu[i].Idkhu, ListKhu[i].Tenkhu);
            }
            KhuDAL.SuaKhu(idCanSua, dulieu);
        }
        public static string timkiem(int idCanTim)
        {
            return KhuDAL.TimKiem(idCanTim);
        }
        public static string GetAllDuLieu()
        {
            return KhuDAL.GetAllDuLieu();
        }       
    }
}
