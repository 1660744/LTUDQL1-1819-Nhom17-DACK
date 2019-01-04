using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChuyenXe
    {
        private int _iDTuyen;
        private int _iDChuyen;
        private int _iDXe;
        private DateTime _gioKhoiHanh;
        private string _ghiChu;
        private int _iDTaiXe;
        public ChuyenXe()
        {
            this.IDChuyen = 0;
            this.IDTaiXe = 0;
            this.IDXe = 0;
            this.IDTuyen = 0;
            this.GioKhoiHanh = default(DateTime);
            this.GhiChu = "";
        }
        public ChuyenXe(DataRow row)
        {
            this.IDChuyen= (int)row["ID_Chuyen"];
            this.IDTaiXe = (int)row["Tai_xe_ID_Taixe"];
            this.IDXe = (int)row["Xe_XeID"];
            this.IDTuyen = (int)row["Tuyen_ID_Tuyen"];
            this.GioKhoiHanh = (DateTime)row["Gio_khoi_hanh"];
            this.GhiChu = row["Ghi_chu"].ToString();
        }

        public int IDTaiXe
        {
            get { return _iDTaiXe; }
            set { _iDTaiXe = value; }
        }

        public string GhiChu
        {
            get { return _ghiChu; }
            set { _ghiChu = value; }
        }

        public DateTime GioKhoiHanh
        {
            get { return _gioKhoiHanh; }
            set { _gioKhoiHanh = value; }
        }


        public int IDXe
        {
            get { return _iDXe; }
            set { _iDXe = value; }
        }


        public int IDChuyen
        {
            get { return _iDChuyen; }
            set { _iDChuyen = value; }
        }

        public int IDTuyen
        {
            get { return _iDTuyen; }
            set { _iDTuyen = value; }
        }
    }
}
