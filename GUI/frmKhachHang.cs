using System;
using BUS;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace GUI
{
    public partial class frmKhachHang : Form
    {
        public frmKhachHang()
        {
            InitializeComponent();
        }

        private void btnKiemTraKH_Click(object sender, EventArgs e)
        {
            if(txtKiemTraKH.TextLength==0)
            {
                MessageBox.Show("Mời nhập Họ tên khách hàng");
            }
            else
            {
                BUS_KhachHang bUS_KhachHang = new BUS_KhachHang();
                DataTable dt = bUS_KhachHang.Search_KhachHang(txtKiemTraKH.Text);

                dgvKhachHang.DataSource = dt;
            }
        }

        private void btnThemKH_MouseClick(object sender, MouseEventArgs e)
        {

        }
    }
     
}
