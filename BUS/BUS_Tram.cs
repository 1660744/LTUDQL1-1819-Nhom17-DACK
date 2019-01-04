using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_Tram
    {
        public List<Tram> getTram()
        {
            DAO_Tram daoTram = new DAO_Tram();
            return daoTram.GetTram();
        }
        public Tram getTramByID(int id)
        {
            DAO_Tram daoTram = new DAO_Tram();
            return daoTram.GetTramByID(id);
        }
    }
}
