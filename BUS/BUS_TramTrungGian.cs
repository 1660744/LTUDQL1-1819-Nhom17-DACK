using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
namespace BUS
{
    public class BUS_TramTrungGian
    {
        public List<TramTrungGian> GetTramTrungGian(int id)
        {
            DAO_TramTrungGian daoTramTG = new DAO_TramTrungGian();
            return daoTramTG.GetTramTrungGian(id);
        }
        public DataTable GetTramTrungGianByID(int id)
        {
            DAO_TramTrungGian daoTramTG = new DAO_TramTrungGian();
            return daoTramTG.GetTramTrungGianByID(id);
        }
        public bool InsertTramTrungGian(int idTuyen, int idtram)
        {
            DAO_TramTrungGian daoTramTG = new DAO_TramTrungGian();
            return daoTramTG.InsertTramTrungGian(idTuyen, idtram);
        }
        public bool UpdateTramTrungGian(int stt,int idTuyen, int idTram)
        {
            DAO_TramTrungGian daoTramTG = new DAO_TramTrungGian();
            return daoTramTG.UpdateTramTrungGian(stt,idTuyen, idTram);
        }
        public bool DeleteTramTrungGian(int idTuyen, int idTram)
        {
            DAO_TramTrungGian daoTramTG = new DAO_TramTrungGian();
            return daoTramTG.DeleteTramTrungGian(idTram, idTuyen);
        }
    }
}
