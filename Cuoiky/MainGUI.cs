using GUI;
using System;

namespace Cuoiky
{
    public class MainGUI
    {
        static void Main(string[] args)
        {
            MenuChinh();
        }
        public static void MenuChinh()
        {
            Console.Clear();
            Console.WriteLine("-------------------Menu Quan li so thu---------------");
            Console.WriteLine("1.Quan li thu");
            Console.WriteLine("2. Quan li chuong");
            Console.WriteLine("3. Quan li khu");
            Console.WriteLine("4. Thoat");
            Console.WriteLine("Moi ban nhap lua chon: ");
            int n = int.Parse(Console.ReadLine());
            switch (n)
            {
                case 1: ThuGUI.MenuThu();break;
                case 2: ChuongGUI.MenuChuong();break;
                case 3: KhuGUI.MenuKhu();break;
                case 4: Thoat();break;
                default: ThongBaoKoXuLi();MenuChinh();
                    break;
            }
        }
        
        
        
        static void Thoat()
        {
            Console.Clear();
            Console.WriteLine("Cam on da su dung!!!!!!!");
        }
        public static void ThongBaoKoXuLi()
        {
            Console.WriteLine("Khong the nhan dang ban nhap gi? Vui long nhap lai!!!!!");
            Console.ReadLine();
        }

        
    }
}
