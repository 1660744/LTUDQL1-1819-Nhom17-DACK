using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Xe
    {
        private int _iD;
        private string _tenXe;
        private string _soDangKi;
        private int _maLoaiXe;
        public Xe()
        {
            this.ID = 0;
            this.TenXe = "";
            this.SoDangKi = "";
            this.MaLoaiXe = 0;
        }
        public Xe(DataRow row)
        {
            this.ID = (int)row["XeID"];
            this.TenXe = row["TenXe"].ToString();
            this.SoDangKi = row["So_dang_ky"].ToString();
            this.MaLoaiXe = (int)row["LoaiXe_ID_LoaiXe"];
        }

        public int MaLoaiXe
        {
            get { return _maLoaiXe; }
            set { _maLoaiXe = value; }
        }

        public string SoDangKi
        {
            get { return _soDangKi; }
            set { _soDangKi = value; }
        }

        public string TenXe
        {
            get { return _tenXe; }
            set { _tenXe = value; }
        }
        public int ID
        {
            get { return _iD; }
            set { _iD = value; }
        }
    }
}
