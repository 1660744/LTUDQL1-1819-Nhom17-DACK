using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
namespace DAO
{
    public class DAO_LoaiXe
    {
        public List<LoaiXe> GetLoaiXe()
        {
            List<LoaiXe> list = new List<LoaiXe>();

            string query = "SELECT * FROM LoaiXe";
            DataProvider provider = new DataProvider();
            DataTable data = provider.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                LoaiXe LoaiXe = new LoaiXe(item);
                list.Add(LoaiXe);
            }

            return list;
        }
        public LoaiXe GetLoaiXeByID(int id)
        {
            LoaiXe LoaiXe = null;

            string query = "select * from LoaiXe where ID_LoaiXe = " + id;
            DataProvider provider = new DataProvider();
            DataTable data = provider.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                LoaiXe = new LoaiXe(item);
                return LoaiXe;
            }

            return LoaiXe;
        }
    }
}
