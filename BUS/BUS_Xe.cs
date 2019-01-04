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
    public class BUS_Xe
    {
        public DataTable getXe()
        {
            DAO_Xe daoXe = new DAO_Xe();
            DataTable dt = new DataTable();
            dt = daoXe.GetXe(); 
            return dt;
        }
        public List<Xe> GetXeToCbb()
        {
            DAO_Xe daoXe = new DAO_Xe();
            return daoXe.GetXeToCbb();
        }
        public Xe getXeByID(int id)
        {
            DAO_Xe daoXe = new DAO_Xe();
            return daoXe.GetXeByID(id);
        }
        public bool InsertXe(Xe tx)
        {
            DAO_Xe daoXe = new DAO_Xe();
            return daoXe.InsertXe(tx);
        }
        public bool UpdateXe(Xe tx)
        {
            DAO_Xe daoXe = new DAO_Xe();
            return daoXe.UpdateXe(tx);
        }
        public bool DeleteXe(int id)
        {
            DAO_Xe daoXe = new DAO_Xe();
            return daoXe.DeleteXe(id);
        }
    }
}
