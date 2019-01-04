using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
namespace BUS
{
    public class BUS_LoaiXe
    {
        public List<LoaiXe> GetLoaiXe()
        {
            DAO_LoaiXe daoLoaiXe = new DAO_LoaiXe();
            return daoLoaiXe.GetLoaiXe();
        }
        public LoaiXe GetLoaiXeByID(int id)
        {
            DAO_LoaiXe daoLoaiXe = new DAO_LoaiXe();
            return daoLoaiXe.GetLoaiXeByID(id);
        }
    }
}
