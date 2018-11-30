using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
