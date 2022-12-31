using System;

namespace DTO
{
    public class ThuDTO
    {
        public int Idthu { get; set; }
        public string Loai { get; set; }
        public string Ten { get; set; }
        public string Nguongoc { get; set; }
        public string Suckhoe { get; set; }

        public ThuDTO(int _idThu, string _loai, string _ten, string _nguonGoc,string _sucKhoe)
        {
            this.Idthu = _idThu;
            this.Loai = _loai;
            this.Ten = _ten;
            this.Nguongoc = _nguonGoc;
            this.Suckhoe = _sucKhoe;
        }    
    }
}
