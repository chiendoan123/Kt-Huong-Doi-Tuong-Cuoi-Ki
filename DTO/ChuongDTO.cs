using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class ChuongDTO
    {
        public int IDchuong { get; set; }
        public string Tenchuong { get; set; }

        public ChuongDTO(int _idChuong, string _tenChuong)
        {
            this.IDchuong = _idChuong;
            this.Tenchuong = _tenChuong;
        }
    }
}
