using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;

namespace DAO
{
    public class DAO_TuyenXe
    {
        public DataTable GetTuyenXe()
        {
            string query = "SELECT * FROM Tuyen";
            DataProvider provider = new DataProvider();
            DataTable dataTable = provider.ExecuteQuery(query);
            return dataTable;
        }
        public List<TuyenXe> GetTuyenXeCbb()
        {
            List<TuyenXe> list = new List<TuyenXe>();
            string query = "SELECT * FROM Tuyen";
            DataProvider provider = new DataProvider();
            DataTable data = provider.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                TuyenXe tuyen = new TuyenXe(item);
                list.Add(tuyen);
            }
            return list;
        }
        public TuyenXe GetTuyenXeByID(int id)
        {
            TuyenXe TuyenXe = null;

            string query = "select * from TuyenXe where ID_TuyenXe = " + id;
            DataProvider provider = new DataProvider();
            DataTable data = provider.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                TuyenXe = new TuyenXe(item);
                return TuyenXe;
            }

            return TuyenXe;
        }
        public bool InsertTuyenXe(TuyenXe tx)
        {
            string query = string.Format("EXEC sp_ThemTuyenXe @kc , @tg , @id_tramdau , @id_tramcuoi");
            int result = DataProvider.ExecuteNonQuery(query, new object[] { tx.KhoangCach, tx.ThoiGian, tx.TramDau, tx.TramCuoi });
            return result > 0;
        }
        public bool UpdateTuyenXe(TuyenXe tx)
        {
            string query = string.Format("EXEC sp_SuaTuyenXe @id , @kc , @tg , @id_tramdau , @id_tramcuoi");
            int result = DataProvider.ExecuteNonQuery(query, new object[] { tx.ID,tx.KhoangCach, tx.ThoiGian, tx.TramDau, tx.TramCuoi });
            return result > 0;
        }
        public bool DeleteTuyenXe(int id)
        {
            string query = string.Format("EXEC sp_XoaTuyenXe " + id);
            int result = DataProvider.ExecuteNonQuery(query);
            return result > 0;
        }
       
    }
}
