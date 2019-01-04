using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Tram
    {
        private int _iDTram;
        private string _tenTram;
        private string _diaDiem;

          public Tram(DataRow row)
        {
            this.IDTram = (int)row["ID_Tram"];
            this.TenTram = row["TenTram"].ToString();
            this.DiaDiem = row["Dia_Diem"].ToString();
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
        public int IDTram
        {
            get { return _iDTram; }
            set { _iDTram = value; }
        }
    }
}
