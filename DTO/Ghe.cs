using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Ghe
    {
        private int _iD_Ghe;
        private int _dong;
        private int _cot;
        private int _tang;
        private int _soGhe;
        private int _iDXe;

        public int IDXe
        {
            get { return _iDXe; }
            set { _iDXe = value; }
        }
        public int SoGhe
        {
            get { return _soGhe; }
            set { _soGhe = value; }
        }
       

        public int Tang
        {
            get { return _tang; }
            set { _tang = value; }
        }

        public int Cot
        {
            get { return _cot; }
            set { _cot = value; }
        }

        public int Dong
        {
            get { return _dong; }
            set { _dong = value; }
        }

        public int ID
        {
            get { return _iD_Ghe; }
            set { _iD_Ghe = value; }
        }
    }
}
