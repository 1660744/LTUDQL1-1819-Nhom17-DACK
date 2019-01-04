using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
<<<<<<< HEAD
using DTO;
=======

>>>>>>> 24fb77a71b216a80673efc55a134eb710e46a298
namespace DAO
{
    public class DAO_KhachHang
    {
       public DataTable Search_KhachHang(string hoten)
        {
            string query = "EXEC sp_KiemTraKH @hoten";//Viết câu truy vấn Procedure nếu có nhiều Parameter viết theo cú pháp "EXEC <procedure_name> @<parameter_name1> , @<parameter_name2>"
            DataProvider provider = new DataProvider();
            DataTable dataTable = provider.ExecuteQuery(query, new object[]{hoten});
            return dataTable;

        }
<<<<<<< HEAD
       public DataTable getKhachHang()
       {
           string query = "SELECT * FROM KhachHang";//Viết câu truy vấn Procedure nếu có nhiều Parameter viết theo cú pháp "EXEC <procedure_name> @<parameter_name1> , @<parameter_name2>"
           DataProvider provider = new DataProvider();
           DataTable dataTable = provider.ExecuteQuery(query);
           return dataTable;

       }
       public bool InsertKH(KhachHang kh)
       {
           string query = string.Format("EXEC sp_ThemKH @hoten , @sdt , @email , @loai");
           int result = DataProvider.ExecuteNonQuery(query, new object[] { kh.Name,kh.Sdt,kh.Email,kh.LoaiKH });
           return result > 0;
       }
       public bool UpdateKH(KhachHang kh)
       {
           string query = string.Format("EXEC sp_SuaKH @id , @hoten , @sdt , @email , @loai");
           int result = DataProvider.ExecuteNonQuery(query, new object[] {kh.ID ,kh.Name, kh.Sdt, kh.Email, kh.LoaiKH });
           return result > 0;
       }
       public bool DeleteKH(int id)
       {
           string query = string.Format("DELETE KhachHang WHERE ID_KhachHang = {0}",id);
           int result = DataProvider.ExecuteNonQuery(query);
           return result > 0;
       }
=======
>>>>>>> 24fb77a71b216a80673efc55a134eb710e46a298
    }
}
