using System;
using System.Collections.Generic;
using System.Text;
using DTO;

namespace GUI
{
    public class ChuongGUI
    {
        public static void MenuChuong()
        {
            Console.Clear();
            Console.WriteLine("-------------------Menu Quan li chuong---------------");
            Console.WriteLine("1.Them thu");
            Console.WriteLine("2. Xoa thu");
            Console.WriteLine("3. Sua");
            Console.WriteLine("4. Tim kiem");
            Console.WriteLine("5. Sap xep");
            Console.WriteLine("6. Tro ve menu chinh");
            Console.WriteLine("7. Thoat");
            Console.WriteLine("Moi ban nhap lua chon: ");
            int n = int.Parse(Console.ReadLine());
            switch (n)
            {
                //case 1: MenuThu(); break;
                //case 2: MenuChuong(); break;
                //case 3: MenuKhu(); break;
                //default:
                //    ThongBaoKoXuLi(); MenuChuong();
                //    break;
            }
        }
    }
}
