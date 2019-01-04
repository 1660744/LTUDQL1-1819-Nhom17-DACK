using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
namespace DAO
{
    public class DAO_TaiXe
    {
        public DataTable GetTaiXe()
        {
            string query = "SELECT * FROM Tai_xe";
            DataProvider provider = new DataProvider();
            DataTable dataTable = provider.ExecuteQuery(query);
            return dataTable;
        }
        public List<TaiXe> GetTaiXeCbb()
        {
            List<TaiXe> list = new List<TaiXe>();

            string query = "SELECT * FROM Tai_xe";
            DataProvider provider = new DataProvider();
            DataTable data = provider.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                TaiXe taiXe = new TaiXe(item);
                list.Add(taiXe);
            }

            return list;
        }
        public TaiXe GetTaiXeByID(int id)
        {
            TaiXe TaiXe = new TaiXe();

            string query = "select * from Tai_xe where  = " + id;
            DataProvider provider = new DataProvider();
            DataTable data = provider.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                TaiXe = new TaiXe(item);
                return TaiXe;
            }

            return TaiXe;
        }
        public bool InsertTaiXe(TaiXe tx)
        {
            string query = string.Format("sp_ThemTaiXe @ten , @bang");
            int result = DataProvider.ExecuteNonQuery(query, new object[] { tx.Ten, tx.BangLai});
            return result > 0;
        }
        public bool UpdateTaiXe(TaiXe tx)
        {
            string query = string.Format("UPDATE Tai_xe SET TenTaiXe = N'{0}', BangLai = N'{1}' WHERE ID_TaiXe = {2}", tx.Ten,tx.BangLai , tx.ID);
            int result = DataProvider.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool DeleteTaiXe(int id)
        {
            string query = string.Format("DELETE Tai_xe WHERE ID_TaiXe = " + id);
            int result = DataProvider.ExecuteNonQuery(query);
            return result > 0;
        }
    }
}
