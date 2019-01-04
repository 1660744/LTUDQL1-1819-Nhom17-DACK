using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class KhachHang
    {
        private string _name;
        private int _iD;
        private string _sdt;
        private string _email;
        private int _loaiKH;

        public int LoaiKH
        {
            get { return _loaiKH; }
            set { _loaiKH = value; }
        }


        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public int ID
        {
            get { return _iD; }
            set { _iD = value; }
        }
        public string Sdt
        {
            get { return _sdt; }
            set { _sdt = value; }
        }
        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }
    }
}
