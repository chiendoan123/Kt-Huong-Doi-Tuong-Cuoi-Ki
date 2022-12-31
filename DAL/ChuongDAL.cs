using System;
using System.IO;

namespace DAL
{
    public class ChuongDAL
    {
        static string path = @"D:\dataChuong.txt";

        public static void SapXep(string duLieu)
        {
            File.WriteAllText(path, duLieu);
        }
        public static void ThemChuong(string duLieu)
        {
            File.WriteAllText(path, duLieu);
        }
        public static void XoaChuong(string duLieu)
        {
            File.WriteAllText(path, duLieu);
        }
        public static void SuaChuong(int idCanSua, string duLieuSua)
        {
            string dataTxt = "";
            dataTxt = File.ReadAllText(path);
            string[] chuoi1 = dataTxt.Split(idCanSua.ToString());
            string[] chuoi2 = chuoi1[1].Split("\r\n");
            dataTxt = "";
            for (int i = 0; i < chuoi1.Length; i++)
            {
                if (i == 0)
                {
                    dataTxt += chuoi1[i] + duLieuSua;
                    for (int j = 1; j < chuoi2.Length - 1; j++)
                    {
                        dataTxt += chuoi2[j] + "\r\n";
                    }
                }
                else if (i > 1)
                    dataTxt += chuoi1[i];
            }

            File.WriteAllText(path, dataTxt);
        }
        public static string TimKiem(int idCanTim)
        {
            string dataTxt = File.ReadAllText(path);
            string[] chuoi1 = dataTxt.Split(idCanTim.ToString());
            string[] chuoi2 = chuoi1[1].Split("\r\n");
            return idCanTim.ToString() + chuoi2[0];
        }
        public static string GetAllDuLieu()
        {
            string dataTxt = File.ReadAllText(path);
            return dataTxt;
        }

    }
}
