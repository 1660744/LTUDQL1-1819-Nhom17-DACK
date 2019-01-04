using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TaiXe
    {
        private int _iD;
        private string _ten;
        private string _bangLai;
        public TaiXe()
        {
            this.ID = 0;
            this.Ten = "";
            this.BangLai = "";
        }
        public TaiXe(DataRow row)
        {
            this.ID = (int)row["ID_TaiXe"];
            this.Ten = row["TenTaiXe"].ToString();
            this.BangLai = row["BangLai"].ToString();
        }
        public string BangLai
        {
            get { return _bangLai; }
            set { _bangLai = value; }
        }

        public string Ten
        {
            get { return _ten; }
            set { _ten = value; }
        }
        
        public int ID
        {
            get { return _iD; }
            set { _iD = value; }
        }

    }
}
