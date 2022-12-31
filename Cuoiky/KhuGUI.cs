using BUS;
using Cuoiky;
using DTO;
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
            Console.WriteLine("-------------------Menu Quan li thu---------------");
            Console.WriteLine(ShowAllDulieu());
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("1. Them khu");
            Console.WriteLine("2. Xoa khu");
            Console.WriteLine("3. Sua khu");
            Console.WriteLine("4. Tim kiem khu");
            Console.WriteLine("5. Sap xep khu");
            Console.WriteLine("6. Tro ve menu chinh");
            Console.WriteLine("7. Thoat");
            Console.WriteLine("Moi ban nhap lua chon: ");
            int n = int.Parse(Console.ReadLine());
            switch (n)
            {
                case 1: ThemKhu(); MenuKhu(); break;
                case 2: XoaKhu(); MenuKhu(); break;
                case 3: SuaKhu(); MenuKhu(); break;
                case 4: TimKiemKhu(); MenuKhu(); break;
                case 5: SapXepKhu(); MenuKhu(); break;
                case 6: MainGUI.MenuChinh(); break;
                case 7: Thoat(); break;
                default:
                    ThongBaoKoXuLi(); MenuKhu();
                    break;
            }
        }
        static void SapXepKhu()
        {
            List<KhuDTO> ListKhu = GetAllDuLieu();
            for (int i = 0; i < ListKhu.Count; i++)
            {
                for (int j = 0; j < ListKhu.Count - 1; j++)
                {
                    if (ListKhu[j].Idkhu > ListKhu[j + 1].Idkhu)
                    {
                        KhuDTO tam = ListKhu[j];
                        ListKhu[j] = ListKhu[j + 1];
                        ListKhu[j + 1] = tam;
                    }
                }
            }
            KhuBUS.SapXep(ListKhu);
        }
        static void ThemKhu()
        {
            Console.WriteLine("Nhap id cua khu");
            int Idkhu = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap ten khu");
            string Tenkhu = Console.ReadLine();
            List<KhuDTO> ListKhu = GetAllDuLieu();
            KhuDTO khu = new KhuDTO(Idkhu, Tenkhu);
            ListKhu.Add(khu);
            KhuBUS.Them(ListKhu);
        }
        static void XoaKhu()
        {
        Nhap:
            bool hople = false;
            int id = 0;

            List<KhuDTO> ListKhu = GetAllDuLieu();
            bool kt = false;
            while (kt == false)
            {

                while (hople == false)
                {
                    try
                    {
                        Console.WriteLine("Nhap id can xoa: ");
                        id = int.Parse(Console.ReadLine());
                        hople = true;
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("id la so nguyen!!!");
                        hople = false;
                    }
                }
                for (int i = 0; i < ListKhu.Count; i++)
                {
                    if (ListKhu[i].Idkhu == id)
                    {
                        ListKhu.RemoveAt(i);
                        kt = true;
                        KhuBUS.Xoa(ListKhu);
                        Console.WriteLine("Xoa thanh cong!!!");
                    }
                }
                if (kt == false)
                {
                    Console.WriteLine("Khong tim thay!!!");
                    goto Nhap;
                }
                Console.ReadLine();
            }
        }
        static List<KhuDTO> GetAllDuLieu()
        {
            List<KhuDTO> listKhu = new List<KhuDTO>();
            string[] hang = ChuongBUS.GetAllDuLieu().Split("\r\n");
            for (int i = 1; i < hang.Length; i++)
            {
                string[] cot = hang[i].Split("\t");
                KhuDTO khu = new KhuDTO(int.Parse(cot[0]), cot[1]);
                listKhu.Add(khu);
            }
            return listKhu;
        }
        static string ShowAllDulieu()
        {
            List<KhuDTO> listKhu = new List<KhuDTO>();
            return ChuongBUS.GetAllDuLieu();
        }
        static void SuaKhu()
        {
            List<KhuDTO> ListKhu = GetAllDuLieu();
            Console.WriteLine("Nhap id can sua: ");
            int idCanSua = int.Parse(Console.ReadLine());

            bool kt = false;
            for (int i = 0; i < ListKhu.Count; i++)
            {
                if (ListKhu[i].Idkhu == idCanSua)
                {
                    Console.WriteLine("Nhap id cua khu");
                    int Idkhu = int.Parse(Console.ReadLine());
                    Console.WriteLine("Nhap loai khu");
                    string Tenkhu = Console.ReadLine();
                    ListKhu[i].Idkhu = Idkhu;
                    ListKhu[i].Tenkhu = Tenkhu;

                    kt = true;
                    KhuBUS.Sua(ListKhu);
                    Console.WriteLine("Sua thanh cong!!!");
                }
            }
            if (kt == false)
            {
                Console.WriteLine("Khong tim thay!!!");
            }
            Console.ReadLine();
        }
        static void TimKiemKhu()
        {
            Console.WriteLine("Nhap id can tim: ");
            int idCanTim = int.Parse(Console.ReadLine());
            List<KhuDTO> ListKhu = GetAllDuLieu();
            for (int i = 0; i < ListKhu.Count; i++)
            {
                bool kt = false;
                if (ListKhu[i].Idkhu == idCanTim)
                {
                    Console.WriteLine("IDchuong\tTenchuong");
                    Console.WriteLine("{0}\t{1}", ListKhu[i].Idkhu, ListKhu[i].Tenkhu);
                    kt = true;
                }
                if (kt == false)
                {
                    Console.WriteLine("Khong tim thay!!!");
                }
            }
            Console.ReadLine();
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
