using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TuyenXe
    {
        private int _iD;
        private int _khoangCach;
        private int _thoiGian;
        private int _tramDau;
        private int _tramCuoi;
        private string _tenTuyen;

        public string TenTuyen
        {
            get { return _tenTuyen; }
            set { _tenTuyen = value; }
        }
        public TuyenXe()
        {
            this.ID = 0;
            this.KhoangCach = 0;
            this.ThoiGian = 0;
            this.TramDau = 0;
            this.TramCuoi = 0;
            this.TenTuyen = "";
        }
        public TuyenXe(DataRow row)
        {
            this.ID = (int)row["ID_Tuyen"];
            this.KhoangCach = (int)row["KhoangCach"];
            this.ThoiGian = (int)row["ThoiGianChay"];
            this.TramDau = (int)row["Tram_ID_Tram"];
            this.TramCuoi = (int)row["Tram_ID_Tram1"];
            this.TenTuyen = row["TenTuyen"].ToString();
        }
        public int TramCuoi
        {
            get { return _tramCuoi; }
            set { _tramCuoi = value; }
        }

        public int TramDau
        {
            get { return _tramDau; }
            set { _tramDau = value; }
        }

        public int ThoiGian
        {
            get { return _thoiGian; }
            set { _thoiGian = value; }
        }
        

        public int KhoangCach
        {
            get { return _khoangCach; }
            set { _khoangCach = value; }
        }

        public int ID
        {
            get { return _iD; }
            set { _iD = value; }
        }

    }
}
