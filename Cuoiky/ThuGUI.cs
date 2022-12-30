using BUS;
using Cuoiky;
using DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace GUI
{
    class ThuGUI
    {
        public static void MenuThu()
        {
            Console.Clear();
            Console.WriteLine("-------------------Menu Quan li thu---------------");
            Console.WriteLine(ShowAllDulieu());
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("1.Them");
            Console.WriteLine("2. Xoa");
            Console.WriteLine("3. Sua");
            Console.WriteLine("4. Tim kiem");
            Console.WriteLine("5. Sap xep");
            Console.WriteLine("6. Tro ve menu chinh");
            Console.WriteLine("7. Thoat");
            Console.WriteLine("Moi ban nhap lua chon: ");
            int n = int.Parse(Console.ReadLine());
            switch (n)
            {
                case 1: ThemThu();MenuThu() ; break;
                case 2: XoaThu(); MenuThu(); break;
                case 3: SuaThu(); MenuThu(); break;
                case 4: TimKiemThu(); MenuThu(); break;
                //case 5: SapXepThu(); break;
                case 6: MainGUI.MenuChinh(); break;
                case 7: Thoat(); break;
                default:
                    ThongBaoKoXuLi(); MenuThu();
                    break;

            }            
        }                    

        static void ThemThu()
        {

            Console.WriteLine("Nhap id cua thu");
            int Idthu = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap loai thu");
            string Loai = Console.ReadLine();
            Console.WriteLine("Nhap ten cua thu");
            string Ten = Console.ReadLine();
            Console.WriteLine("Nhap nguon goc cua thu");
            string Nguongoc = Console.ReadLine();
            Console.WriteLine("Nhap suc khoe cua thu");
            string Suckhoe = Console.ReadLine();
            List<ThuDTO> ListThus = GetAllDuLieu();
            ThuDTO thu = new ThuDTO(Idthu,Loai,Ten,Nguongoc,Suckhoe);
            ListThus.Add(thu);
            ThuBUS.Them(ListThus);
        }
        static void XoaThu()
        {
            Nhap:
            bool hople = false;
            int id = 0;
            
            List<ThuDTO> ListThus = GetAllDuLieu();
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
                for (int i = 0; i < ListThus.Count; i++)
                {
                    if (ListThus[i].Idthu == id)
                    {
                        ListThus.RemoveAt(i);
                        kt = true;
                        ThuBUS.Xoa(ListThus);
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
        static List<ThuDTO> GetAllDuLieu()
        {
            List<ThuDTO> listThu = new List<ThuDTO>();
            string[] hang = ThuBUS.GetAllDuLieu().Split("\r\n");
            for (int i = 1; i < hang.Length-1; i++)
            {
                string[] cot = hang[i].Split("\t");
                ThuDTO thu = new ThuDTO(int.Parse(cot[0]), cot[1], cot[2], cot[3], cot[4]);
                listThu.Add(thu);
            }
            return listThu;
        }
        static string ShowAllDulieu()
        {
            List<ThuDTO> listThu = new List<ThuDTO>();
           return ThuBUS.GetAllDuLieu();
        }
        static void SuaThu()
        {
            List<ThuDTO> ListThus = GetAllDuLieu();
            Console.WriteLine("Nhap id can sua: ");
            int idCanSua = int.Parse(Console.ReadLine());
            
            bool kt = false;
            for (int i = 0; i < ListThus.Count; i++)
            {                
                if (ListThus[i].Idthu == idCanSua)
                {
                    Console.WriteLine("Nhap id cua thu");
                    int Idthu = int.Parse(Console.ReadLine());
                    Console.WriteLine("Nhap loai thu");
                    string Loai = Console.ReadLine();
                    Console.WriteLine("Nhap ten cua thu");
                    string Ten = Console.ReadLine();
                    Console.WriteLine("Nhap nguon goc cua thu");
                    string Nguongoc = Console.ReadLine();
                    Console.WriteLine("Nhap suc khoe cua thu");
                    string Suckhoe = Console.ReadLine();
                    ListThus[i].Idthu=Idthu;
                    ListThus[i].Loai = Loai;
                    ListThus[i].Ten = Ten;
                    ListThus[i].Nguongoc = Nguongoc;
                    ListThus[i].Suckhoe = Suckhoe;
                    kt = true;
                    ThuBUS.Sua(ListThus);
                    Console.WriteLine("Sua thanh cong!!!");
                }
            }
            if (kt == false)
            {
                Console.WriteLine("Khong tim thay!!!");
            }
            Console.ReadLine();
        }
        static void TimKiemThu()
        {
            Console.WriteLine("Nhap id can tim: ");
            int idCanTim = int.Parse(Console.ReadLine());
            List<ThuDTO> ListThus = GetAllDuLieu();
            for (int i = 0; i < ListThus.Count; i++)
            {
                bool kt = false;
                if(ListThus[i].Idthu == idCanTim)
                {
                    Console.WriteLine("Idthu\tLoai\tTen\tNguongoc\tSuckhoe");
                    Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}",ListThus[i].Idthu, ListThus[i].Loai, ListThus[i].Ten, ListThus[i].Nguongoc, ListThus[i].Suckhoe);
                    kt = true;
                }
                if (kt==false)
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
