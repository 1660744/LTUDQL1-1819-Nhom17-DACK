using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;

namespace DAO
{
    public class DAO_Tram
    {
        public List<Tram> GetTram()
        {
            List<Tram> list = new List<Tram>();

            string query = "SELECT * FROM Tram";
            DataProvider provider = new DataProvider();
            DataTable data = provider.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Tram Tram = new Tram(item);
                list.Add(Tram);
            }

            return list;
        }
        public Tram GetTramByID(int id)
        {
            Tram tram = null;

            string query = "select * from Tram where ID_Tram = " + id;
            DataProvider provider = new DataProvider();
            DataTable data = provider.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                tram = new Tram(item);
                return tram;
            }

            return tram;
        }
    }
}
