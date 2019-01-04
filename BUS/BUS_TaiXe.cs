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
    public class BUS_TaiXe
    {
        public DataTable getTaiXe()
        {
            DAO_TaiXe daoTaiXe = new DAO_TaiXe();
            DataTable dt = new DataTable();
            dt = daoTaiXe.GetTaiXe();
            return dt;
        }
        public List<TaiXe> getTaiXeCbb()
        {
            DAO_TaiXe daoTaiXe = new DAO_TaiXe();
            return daoTaiXe.GetTaiXeCbb();
        }
        public TaiXe getTaiXeByID(int id)
        {
            DAO_TaiXe daoTaiXe = new DAO_TaiXe();
            return daoTaiXe.GetTaiXeByID(id);
        }
       public bool InsertTaiXe(TaiXe tx)
        {
            DAO_TaiXe daoTaiXe = new DAO_TaiXe();
            return daoTaiXe.InsertTaiXe(tx);
        }
        public bool UpdateTaiXe(TaiXe tx)
        {
            DAO_TaiXe daoTaiXe = new DAO_TaiXe();
            return daoTaiXe.UpdateTaiXe(tx);
        }
        public bool DeleteTaiXe(int id)
        {
            DAO_TaiXe daoTaiXe = new DAO_TaiXe();
            return daoTaiXe.DeleteTaiXe(id);
        }
    }
}
