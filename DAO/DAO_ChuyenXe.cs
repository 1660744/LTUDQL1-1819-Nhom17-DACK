using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAO
{
    public class DAO_ChuyenXe
    {
        public DataTable GetChuyenXe()
        {
            string query = "select * from Chuyen";
            DataProvider provider = new DataProvider();
            DataTable dataTable = provider.ExecuteQuery(query);
            return dataTable;
        }
        public ChuyenXe GetChuyenXeByID(int id)
        {
            ChuyenXe ChuyenXe = null;

            string query = "select * from Chuyen where ID_Chuyen = " + id;
            DataProvider provider = new DataProvider();
            DataTable data = provider.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                ChuyenXe = new ChuyenXe(item);
                return ChuyenXe;
            }

            return ChuyenXe;
        }
        public bool InsertChuyenXe(ChuyenXe tx)
        {
            string query = string.Format("EXEC sp_ThemChuyenXe @idtuyen , @idchuyen , @giokh , @idtaixe , @idxe , @ghichu");
            int result = DataProvider.ExecuteNonQuery(query, new object[] { tx.IDTuyen, tx.IDChuyen, tx.GioKhoiHanh, tx.IDTaiXe,tx.IDXe,tx.GhiChu });
            return result > 0;
        }
        public bool UpdateChuyenXe(ChuyenXe tx)
        {
            string query = string.Format("UPDATE Chuyen SET Tuyen_ID_Tuyen = {0}, Gio_khoi_hanh = {1}, Ghi_chu = N'{2}' ,Tai_xe_ID_Taixe = {3} , Xe_XeID = {4} WHERE ID_Chuyen = {5}", tx.IDTuyen, tx.GioKhoiHanh, tx.GhiChu, tx.IDTaiXe, tx.IDXe, tx.IDChuyen);
            int result = DataProvider.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool DeleteChuyenXe(int id)
        {
            string query = string.Format("DELETE Chuyen WHERE ID_Chuyen= " + id);
            int result = DataProvider.ExecuteNonQuery(query);
            return result > 0;
        }
    }
}
