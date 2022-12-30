using System;
using System.Collections.Generic;
using System.Text;

namespace GUI
{
    class KhuGUI
    {
        public static void MenuKhu()
        {
            Console.Clear();
            Console.WriteLine("-------------------Menu Quan li Khu---------------");
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
                case 1: ThuGUI.MenuThu(); break;
                case 2: ChuongGUI.MenuChuong(); break;
                case 3: KhuGUI.MenuKhu(); break;
                default:
                    break;
            }
        }
    }
}
