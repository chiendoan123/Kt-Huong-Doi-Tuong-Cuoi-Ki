using System;
using System.Collections.Generic;
using System.Text;
using DTO;
using BUS;
using Cuoiky;

namespace GUI
{
    public class ChuongGUI
    {
        public static void MenuChuong()
        {
            Console.Clear();
            Console.WriteLine("-------------------Menu Quan li chuong---------------");
            Console.WriteLine(ShowAllDulieu());
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("1. Them chuong");
            Console.WriteLine("2. Xoa chuong");
            Console.WriteLine("3. Sua chuong");
            Console.WriteLine("4. Tim kiem chuong");
            Console.WriteLine("5. Sap xep chuong");
            Console.WriteLine("6. Tro ve menu chinh");
            Console.WriteLine("7. Thoat");
            Console.WriteLine("Moi ban nhap lua chon: ");
            int n = int.Parse(Console.ReadLine());
            switch (n)
            {
                case 1: ThemChuong(); MenuChuong(); break;
                case 2: XoaChuong(); MenuChuong(); break;
                case 3: SuaChuong(); MenuChuong(); break;
                case 4: TimKiemChuong(); MenuChuong(); break;
                case 5: SapXepChuong(); MenuChuong(); break;
                case 6: MainGUI.MenuChinh(); break;
                case 7: Thoat(); break;
                default:
                    ThongBaoKoXuLi(); MenuChuong();
                    break;
            }

        }
        
        static void SapXepChuong()
        {
            List<ChuongDTO> ListChuong = GetAllDuLieu();
            for (int i = 0; i < ListChuong.Count; i++)
            {
                for (int j = 0; j < ListChuong.Count - 1; j++)
                {
                    if (ListChuong[j].IDchuong > ListChuong[j + 1].IDchuong)
                    {
                        ChuongDTO tam = ListChuong[j];
                        ListChuong[j] = ListChuong[j + 1];
                        ListChuong[j + 1] = tam;
                    }
                }
            }
            ChuongBUS.SapXep(ListChuong);
        }
        static void ThemChuong()
        {
            Console.WriteLine("Nhap id cua chuong");
            int Idchuong = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap ten chuong");
            string Tenchuong = Console.ReadLine();            
            List<ChuongDTO> ListChuong = GetAllDuLieu();
            ChuongDTO chuong = new ChuongDTO(Idchuong, Tenchuong);
            ListChuong.Add(chuong);
            ChuongBUS.Them(ListChuong);
        }
        static void XoaChuong()
        {
        Nhap:
            bool hople = false;
            int id = 0;
            List<ChuongDTO> ListChuong = GetAllDuLieu();
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
                for (int i = 0; i < ListChuong.Count; i++)
                {
                    if (ListChuong[i].IDchuong == id)
                    {
                        ListChuong.RemoveAt(i);
                        kt = true;
                        ChuongBUS.Xoa(ListChuong);
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
        static List<ChuongDTO> GetAllDuLieu()
        {
            List<ChuongDTO> listChuong = new List<ChuongDTO>();
            string[] hang = ChuongBUS.GetAllDuLieu().Split("\r\n");
            for (int i = 1; i < hang.Length; i++)
            {
                string[] cot = hang[i].Split("\t");
                ChuongDTO chuong = new ChuongDTO(int.Parse(cot[0]), cot[1]);
                listChuong.Add(chuong);
            }
            return listChuong;
        }
        static string ShowAllDulieu()
        {
            List<ChuongDTO> listThu = new List<ChuongDTO>();
            return ChuongBUS.GetAllDuLieu();
        }
        static void SuaChuong()
        {            
            Console.WriteLine("Nhap id can sua: ");
            int idCanSua = int.Parse(Console.ReadLine());
            List<ChuongDTO> ListChuong = GetAllDuLieu();
            bool kt = false;
            for (int i = 0; i < ListChuong.Count; i++)
            {
                if (ListChuong[i].IDchuong == idCanSua)
                {
                    Console.WriteLine("Nhap id cua chuong");
                    int Idchuong = int.Parse(Console.ReadLine());
                    Console.WriteLine("Nhap loai chuong");
                    string Tenchuong = Console.ReadLine();                    
                    ListChuong[i].IDchuong = Idchuong;
                    ListChuong[i].Tenchuong = Tenchuong;                   
                    kt = true;
                    ChuongBUS.Sua(idCanSua, ListChuong);
                    Console.WriteLine("Sua thanh cong!!!");
                }
            }
            if (kt == false)
            {
                Console.WriteLine("Khong tim thay!!!");
            }
            Console.ReadLine();
        }
        static void TimKiemChuong()
        {
            Console.WriteLine("Nhap id can tim: ");
            int idCanTim = int.Parse(Console.ReadLine());
            List<ChuongDTO> ListChuong = GetAllDuLieu();
            bool kt = false;
            for (int i = 0; i < ListChuong.Count; i++)
            {               
                if (ListChuong[i].IDchuong == idCanTim)
                {
                    Console.WriteLine("IDchuong\tTenchuong");
                    Console.WriteLine("{0}\t{1}", ListChuong[i].IDchuong, ListChuong[i].Tenchuong);
                    kt = true;
                }               
            }
            if (kt == false)
            {
                Console.WriteLine("Khong tim thay!!!");
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
