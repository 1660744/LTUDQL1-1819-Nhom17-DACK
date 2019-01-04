using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TramTrungGian
    {
        private int _sTT;
        private string _tenTram;
        private string _diaDiem;
        public TramTrungGian()
        {
            this.STT = 0;
            this.TenTram = "";
            this.DiaDiem = "";
        }
        public TramTrungGian(DataRow row)
        {
            this.STT = (int)row["Thu_tu"];
            this.TenTram = row["TenTram"].ToString();
            this.DiaDiem = row["Dia_diem"].ToString();
        }

        public string DiaDiem
        {
            get { return _diaDiem; }
            set { _diaDiem = value; }
        }

        public string TenTram
        {
            get { return _tenTram; }
            set { _tenTram = value; }
        }

        public int STT
        {
            get { return _sTT; }
            set { _sTT = value; }
        }
    }
}
