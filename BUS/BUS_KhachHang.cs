using DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_KhachHang
    {
        public DataTable Search_KhachHang(string hoten)
        {
            DAO_KhachHang daoKhachHang = new DAO_KhachHang();
            DataTable dtKhachHang = daoKhachHang.Search_KhachHang(hoten);

            return dtKhachHang;

        }
    }
}
