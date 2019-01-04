using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class LoaiXe
    {
        private int _maLoai;
        private string _tenLoai;
        public LoaiXe(DataRow row)
        {
            this.MaLoai = (int)row["ID_LoaiXe"];
            this.TenLoai = row["TenLoai"].ToString();
        }

        public string TenLoai
        {
            get { return _tenLoai; }
            set { _tenLoai = value; }
        }
        public int MaLoai
        {
            get { return _maLoai; }
            set { _maLoai = value; }
        }
    }
}
