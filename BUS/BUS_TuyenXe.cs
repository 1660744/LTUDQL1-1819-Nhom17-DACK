using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_TuyenXe
    {
        public DataTable getTuyenXe()
        {
            DAO_TuyenXe daoTuyenXe = new DAO_TuyenXe();
            DataTable dt = new DataTable();
            dt = daoTuyenXe.GetTuyenXe();
            return dt;
        }
        public List<TuyenXe> GetTuyenXeCbb()
        {
            DAO_TuyenXe daotuyen = new DAO_TuyenXe();
            return daotuyen.GetTuyenXeCbb();
        }
        public TuyenXe getTuyenXeByID(int id)
        {
            DAO_TuyenXe daoTuyenXe = new DAO_TuyenXe();
            return daoTuyenXe.GetTuyenXeByID(id);
        }
        public bool InsertTuyenXe(TuyenXe tx)
        {
            DAO_TuyenXe daotuyenxe = new DAO_TuyenXe();
            return daotuyenxe.InsertTuyenXe(tx);
        }
        public bool UpdateTuyenXe(TuyenXe tx)
        {
            DAO_TuyenXe daotuyenxe = new DAO_TuyenXe();
            return daotuyenxe.UpdateTuyenXe(tx);
        }
        public bool DeleteTuyenXe(int id)
        {
            DAO_TuyenXe daotuyenxe = new DAO_TuyenXe();
            return daotuyenxe.DeleteTuyenXe(id);
        }
      
    }
}
