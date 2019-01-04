using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAO
{
    public class DAO_Xe
    {
        public DataTable GetXe()
        {
            string query = "SELECT Xe.*,LoaiXe.TenLoai FROM Xe,LoaiXe WHERE Xe.LoaiXe_ID_LoaiXe=LoaiXe.ID_LoaiXe";
            DataProvider provider = new DataProvider();
            DataTable dataTable = provider.ExecuteQuery(query);
            return dataTable;
        }
        public List<Xe> GetXeToCbb()
        {
            List<Xe> list = new List<Xe>();

            string query = "SELECT * FROM Xe";
            DataProvider provider = new DataProvider();
            DataTable data = provider.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Xe Xe = new Xe(item);
                list.Add(Xe);
            }

            return list;
        }
        public Xe GetXeByID(int id)
        {
            Xe Xe = null;

            string query = "select * from Xe where XeID = " + id;
            DataProvider provider = new DataProvider();
            DataTable data = provider.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Xe = new Xe(item);
                return Xe;
            }

            return Xe;
        }
        public bool InsertXe(Xe tx)
        {
            string query = string.Format("EXEC sp_Xe @ten , @sodk , @Xe");
            int result = DataProvider.ExecuteNonQuery(query, new object[] { tx.TenXe, tx.SoDangKi, tx.MaLoaiXe});
            return result > 0;
        }
        public bool UpdateXe(Xe tx)
        {
            string query = string.Format("UPDATE Xe SET TenXe = '{0}', So_dang_ky = '{1}', LoaiXe_ID_LoaiXe= {2} WHERE XeID = {3}", tx.TenXe, tx.SoDangKi, tx.MaLoaiXe, tx.ID);
            int result = DataProvider.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool DeleteXe(int id)
        {
            string query = string.Format("DELETE Xe WHERE XeID = " + id);
            int result = DataProvider.ExecuteNonQuery(query);
            return result > 0;
        }
    }
}
