using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace BUS
{
    public class ThuBUS
    {
        public static void Them(List<ThuDTO> ListThus)
        {
            string dulieu="Idthu\tLoai\tTen\tNguongoc\tSuckhoe";
            for (int i = 0; i < ListThus.Count; i++)
            {
                dulieu+= string.Format("\r\n{0}\t{1}\t{2}\t{3}\t{4}", ListThus[i].Idthu, ListThus[i].Loai, ListThus[i].Ten, ListThus[i].Nguongoc, ListThus[i].Suckhoe);
            }
            ThuDAL.ThemThu(dulieu);
        }
        public static void Xoa(List<ThuDTO> ListThus)
        {
            string dulieu = "Idthu\tLoai\tTen\tNguongoc\tSuckhoe";
            for (int i = 0; i < ListThus.Count; i++)
            {
                dulieu += string.Format("\r\n{0}\t{1}\t{2}\t{3}\t{4}", ListThus[i].Idthu, ListThus[i].Loai, ListThus[i].Ten, ListThus[i].Nguongoc, ListThus[i].Suckhoe);
            }
            ThuDAL.XoaThu(dulieu);
        }
        public static void Sua(int idCanSua,ThuDTO thu)
        {
            string dulieu = thu.Idthu + "\t" + thu.Loai + "\t" + thu.Ten + "\t" + thu.Nguongoc + "\t" + thu.Suckhoe + "\t";
            ThuDAL.SuaThu(idCanSua,dulieu);
        }
        public static string timkiem(int idCanTim)
        {
            return ThuDAL.TimKiem(idCanTim);
        }
        public static string GetAllDuLieu()
        {
            return ThuDAL.GetAllDuLieu();
        }

        public static void Sua(List<ThuDTO> listThus)
        {
            throw new NotImplementedException();
        }
    }
}
