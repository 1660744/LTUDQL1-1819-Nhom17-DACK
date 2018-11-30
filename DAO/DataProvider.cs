using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace DAO
{
    public class DataProvider
    {
        private static string connectionString = "";

        public static string ConnectionString
        {
            get
            {
                if (connectionString.CompareTo("") == 0)
                {
                    connectionString = ConfigurationManager.ConnectionStrings["QLVEXE"].ConnectionString;
                }
                return connectionString;
            }
        }

        public static SqlConnection ConnectDatabase()
        {
            SqlConnection sqlConnection = new SqlConnection(ConnectionString);
            sqlConnection.Open();
            return sqlConnection;
        }

        public static void CloseConnection(SqlConnection sqlConnection)
        {
            sqlConnection.Close();
        }

      public DataTable ExecuteQuery(string query, object[] parameter = null)//sử dụng để load danh sách
        {
            DataTable data = new DataTable();

            using (SqlConnection connection = ConnectDatabase())
            {
                SqlCommand command = new SqlCommand(query, connection);

                //Xử lí để add parameter
                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }

                SqlDataAdapter adapter = new SqlDataAdapter(command);

                adapter.Fill(data);

                connection.Close();
            }

            return data;
        }

        public int ExecuteNonQuery(string query, object[] parameter = null)//Sử dụng khi thêm xóa sửa
        {
            int data = 0;

            using (SqlConnection connection = ConnectDatabase())
            {
                SqlCommand command = new SqlCommand(query, connection);

                //Xử lí để add parameter
                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }

                data = command.ExecuteNonQuery();

                connection.Close();
            }

            return data;
        }

        public object ExecuteScalar(string query, object[] parameter = null)//Sử dụng để đếm số lượng dòng thỏa trong câu truy vấn
        {
            object data = 0;

            using (SqlConnection connection = ConnectDatabase())
            {

                SqlCommand command = new SqlCommand(query, connection);
                
                //Xử lí để add parameter
                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }

                data = command.ExecuteScalar();

                connection.Close();
            }

            return data;
        }
    }
}