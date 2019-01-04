using DAO;
<<<<<<< HEAD
using DTO;
=======
>>>>>>> 24fb77a71b216a80673efc55a134eb710e46a298
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
<<<<<<< HEAD
         public DataTable getKhachHang()
        {
            DAO_KhachHang daoKhachHang = new DAO_KhachHang();
            DataTable dtKhachHang = daoKhachHang.getKhachHang();

            return dtKhachHang;

        }
        public bool InsertKH(KhachHang kh)
         {
             DAO_KhachHang daoKhachHang = new DAO_KhachHang();
             return daoKhachHang.InsertKH(kh);
         }
        public bool UpdateKH(KhachHang kh)
        {
            DAO_KhachHang daoKhachHang = new DAO_KhachHang();
            return daoKhachHang.UpdateKH(kh);
        }
        public bool DeleteKH(int id)
        {
            DAO_KhachHang daoKhachHang = new DAO_KhachHang();
            return daoKhachHang.DeleteKH(id);
        }
=======
>>>>>>> 24fb77a71b216a80673efc55a134eb710e46a298
    }
}
