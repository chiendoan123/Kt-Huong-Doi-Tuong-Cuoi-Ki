using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    class KhuDTO
    {
        public int Idkhu { get; set; }
        public string Tenkhu { get; set; }       
        public KhuDTO(int _idKhu, string _tenKhu)
        {
            this.Idkhu = _idKhu;
            this.Tenkhu = _tenKhu;
        }
    }
}
