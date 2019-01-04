using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAO
{
    public class DAO_TramTrungGian
    {
        public List<TramTrungGian> GetTramTrungGian(int id)
        {
            List<TramTrungGian> listtramtg = new List<TramTrungGian>();
            string query = "SELECT t.Tram_ID_Tram,t.Thu_tu,Tram.TenTram,Tram.Dia_diem FROM Tram_trung_gian t,Tram,Tuyen WHERE t.Tram_ID_Tram=Tram.ID_Tram and Tuyen.ID_Tuyen = t.Tuyen_ID_Tuyen and t.Tuyen_ID_Tuyen = " + id;
            DataProvider provider = new DataProvider();
            DataTable data = provider.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                TramTrungGian TramTG = new TramTrungGian(item);
                listtramtg.Add(TramTG);
            }
            return listtramtg;
        }
        public DataTable GetTramTrungGianByID(int id)
        {
            string query = "SELECT t.Tram_ID_Tram,t.Thu_tu,Tram.TenTram,Tram.Dia_diem FROM Tram_trung_gian t,Tram,Tuyen WHERE t.Tram_ID_Tram=Tram.ID_Tram and Tuyen.ID_Tuyen = t.Tuyen_ID_Tuyen and t.Tuyen_ID_Tuyen = " + id;
            DataProvider provider = new DataProvider();
            DataTable data = provider.ExecuteQuery(query);
            return data;
        }
        public bool InsertTramTrungGian(int ID_tuyen, int ID_Tram)
        {
            string query = string.Format("EXEC sp_ThemTramTG @idtuyen , @idtram");
            int result = DataProvider.ExecuteNonQuery(query, new object[] { ID_tuyen, ID_Tram });
            return result > 0;
        }
        public bool UpdateTramTrungGian(int stt,int ID_Tram, int ID_tuyen)
        {
            string query = string.Format("UPDATE Tram_trung_gian SET Thu_tu = {0} WHERE {1} = Tuyen_ID_Tuyen AND Tram_ID_Tram = {2}", stt, ID_tuyen,ID_Tram);
            int result = DataProvider.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool DeleteTramTrungGian(int ID_Tram, int ID_tuyen)
        {
            string query = string.Format("DELETE Tram_trung_gian WHERE Tuyen_ID_Tuyen= {0} and Tram_ID_Tram = {1}", ID_tuyen, ID_Tram);
            int result = DataProvider.ExecuteNonQuery(query);
            return result > 0;
        }
    }
}
