using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace DAL
{
    class KhuDAL
    {
        static string path = @"D:\dataKhu.txt";

        public static void xuatDuLieuKhuDAL(string duLieu)
        {
            StreamWriter sw = new StreamWriter(path);

            sw.WriteLine(duLieu);

            sw.Close();
        }

    }
}
