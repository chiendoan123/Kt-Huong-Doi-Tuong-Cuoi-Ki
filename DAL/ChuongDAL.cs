using System;
using System.IO;

namespace DAL
{
    public class ChuongDAL
    {
        static string path = @"D:\dataChuong.txt";
        
        public static void xuatDuLieuChuongDAL(string duLieu)
        {
            StreamWriter sw = new StreamWriter(path);
            
            sw.WriteLine(duLieu);

            sw.Close();
        }

    }
}
