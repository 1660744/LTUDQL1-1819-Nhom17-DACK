using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
namespace BUS
{
    public class BUS_ChuyenXe
    {
        public DataTable getChuyenXe()
        {
            DAO_ChuyenXe daoChuyenXe = new DAO_ChuyenXe();
            return daoChuyenXe.GetChuyenXe();
        }
        public ChuyenXe getChuyenXeByID(int id)
        {
            DAO_ChuyenXe daoChuyenXe = new DAO_ChuyenXe();
            return daoChuyenXe.GetChuyenXeByID(id);
        }
        public bool InsertChuyenXe(ChuyenXe tx)
        {
            DAO_ChuyenXe daoChuyenXe = new DAO_ChuyenXe();
            return daoChuyenXe.InsertChuyenXe(tx);
        }
        public bool UpdateChuyenXe(ChuyenXe tx)
        {
            DAO_ChuyenXe daoChuyenXe = new DAO_ChuyenXe();
            return daoChuyenXe.UpdateChuyenXe(tx);
        }
        public bool DeleteChuyenXe(int id)
        {
            DAO_ChuyenXe daoChuyenXe = new DAO_ChuyenXe();
            return daoChuyenXe.DeleteChuyenXe(id);
        }
    }
}
