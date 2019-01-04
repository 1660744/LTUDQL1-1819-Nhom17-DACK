using System;
using BUS;
using DTO;
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
    public partial class frmAdmin : Form
    {
        public static int SetValueForText1 = 0;
        BindingSource customerList = new BindingSource();
        BindingSource DSTuyenXe = new BindingSource();
        BindingSource DSXe = new BindingSource();
        BindingSource DSChuyen = new BindingSource();
        BindingSource DSTaiXe = new BindingSource();
        public frmAdmin()
        {
            InitializeComponent();
            LoadData();
        }
        /// <summary>
        /// Tab form Khach hang
        /// </summary>
        void LoadData()
        {
            dgvKhachHang.DataSource = customerList;
            dgvTuyenXe.DataSource = DSTuyenXe;
            dgvXe.DataSource = DSXe;
            //dgvChuyen.DataSource = DSChuyen;
            dgvTaiXe.DataSource = DSTaiXe;

            LoadListCustomer();
            LoadDSTuyenXe();
            LoadDSXe();
            LoadDSTaiXe();
            LoadTramDau(cbbTramDau);
            LoadTramCuoi(cbbTramCuoi);
            LoadLoaiXe(cbbLoaiXe);
            LoadTaiXe(cbbTaiXe);
            LoadXe(cbbxe);
            LoadTuyen(cbbTenTuyen);

            AddCustomerBingding();
            AddTuyenXeBingding();
            AddXeBingding();
            AddTaiXeBingding();
            //AddChuyenXeBingding();

        }
        #region LoadKH
        void AddCustomerBingding()
        {
            txtHoTen.DataBindings.Add(new Binding("Text", dgvKhachHang.DataSource, "HoTen"));
            txtID_KH.DataBindings.Add(new Binding("Text", dgvKhachHang.DataSource, "ID_KhachHang"));
            txtSDT.DataBindings.Add(new Binding("Text", dgvKhachHang.DataSource, "DienThoai"));
            txtEmail.DataBindings.Add(new Binding("Text", dgvKhachHang.DataSource, "Email"));
            cbbLoaiKH.DataBindings.Add(new Binding("Text", dgvKhachHang.DataSource, "Loai"));
        }

        void LoadListCustomer()
        {
            BUS_KhachHang bUS_KhachHang = new BUS_KhachHang();
            DataTable dt = bUS_KhachHang.getKhachHang();

            customerList.DataSource = dt;
        }
        #endregion
        #region events KH
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
                if(dt.Rows.Count == 0)
                {
                    MessageBox.Show("Chưa có khách hàng này");
                    dgvKhachHang.DataSource = customerList;
                    LoadListCustomer();
                }
                dgvKhachHang.ClearSelection();
            }
        }

        private void btnThemKH_Click(object sender, EventArgs e)
        {
            BUS_KhachHang bUS_KhachHang = new BUS_KhachHang();
            KhachHang kh = new KhachHang();
            kh.Name = txtHoTen.Text;
            kh.Sdt = txtSDT.Text;
            kh.Email = txtEmail.Text;
               

            if (bUS_KhachHang.InsertKH(kh))
            {
                MessageBox.Show("Thêm Khách hàng thành công");
                LoadListCustomer();
                if (insertKH != null)
                    insertKH(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Có lỗi khi thêm khách hàng");
            }
        }

        private void btnSuaKH_Click(object sender, EventArgs e)
        {
            BUS_KhachHang bUS_KhachHang = new BUS_KhachHang();
            KhachHang kh = new KhachHang();
            kh.ID = int.Parse(txtID_KH.Text);
            kh.Name = txtHoTen.Text;
            kh.Sdt = txtSDT.Text;
            kh.Email = txtEmail.Text;
            if (cbbLoaiKH.Text == "Khách hàng thường")
                kh.LoaiKH = 1;
            else
                kh.LoaiKH = 2;
            if (bUS_KhachHang.UpdateKH(kh))
            {
                MessageBox.Show("Cập nhật Khách hàng thành công");
                LoadListCustomer();
                if (updateKH != null)
                    updateKH(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Có lỗi khi cập nhật khách hàng");
            }
        }
       
        private void btnXoaKH_Click(object sender, EventArgs e)
        {
            BUS_KhachHang bUS_KhachHang = new BUS_KhachHang();
       
            int ID = int.Parse(txtID_KH.Text);
            if (bUS_KhachHang.DeleteKH(ID))
            {
                MessageBox.Show("Xóa Khách hàng thành công");
                LoadListCustomer();
                if (deleteKH != null)
                    deleteKH(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Có lỗi khi Xóa khách hàng");
            }
        }

        private event EventHandler insertKH;
        public event EventHandler InsertKH
        {
            add { insertKH += value; }
            remove { insertKH -= value; }
        }

        private event EventHandler updateKH;
        public event EventHandler UpdateKH
        {
            add { updateKH += value; }
            remove { updateKH -= value; }
        }

        private event EventHandler deleteKH;
        public event EventHandler DeleteKH
        {
            add { deleteKH += value; }
            remove { deleteKH -= value; }
        }

        private void tbpKhachHang_Click(object sender, EventArgs e)
        {
            dgvKhachHang.ClearSelection();
            txtID_KH.Text = "";
            txtHoTen.Text = "";
            txtSDT.Text = "";
            txtEmail.Text = "";
            cbbLoaiKH.Text = "";
        }


       /* private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in dgvKhachHang.SelectedRows)
            {
                txtID_KH.Text = row.Cells[0].Value.ToString();
                txtHoTen.Text = row.Cells[1].Value.ToString();
                txtSDT.Text = row.Cells[2].Value.ToString();
                txtEmail.Text = row.Cells[3].Value.ToString();
                cbbLoaiKH.Text = row.Cells[4].Value.ToString();
            }
        }*/

        private void btnTaiLai_Click(object sender, EventArgs e)
        {
            dgvKhachHang.DataSource = customerList;
            LoadListCustomer();
        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void dgvKhachHang_Click(object sender, EventArgs e)
        {
            dgvKhachHang.DataSource = customerList;
            LoadListCustomer();
        }
        #endregion
        #region LoadTuyen
        void LoadTramDau(ComboBox cb)
        {
            BUS_Tram bus_tram =new BUS_Tram();
            cb.DataSource = bus_tram.getTram();
            cb.DisplayMember = "TenTram";
        }
        void LoadTramCuoi(ComboBox cb)
        {
            BUS_Tram bus_tram = new BUS_Tram();
            cb.DataSource = bus_tram.getTram();
            cb.DisplayMember = "TenTram";
        }

        void AddTuyenXeBingding()
        {
            txtIDTuyenXe.DataBindings.Add(new Binding("Text",dgvTuyenXe.DataSource, "ID_Tuyen"));
            txtKhoangCach.DataBindings.Add(new Binding("Text", dgvTuyenXe.DataSource, "KhoangCach"));
            txtThoigian.DataBindings.Add(new Binding("Text", dgvTuyenXe.DataSource, "ThoiGianChay"));
        }

        void LoadDSTuyenXe()
        {
            BUS_TuyenXe bus_tuyenxe = new BUS_TuyenXe();
            DSTuyenXe.DataSource = bus_tuyenxe.getTuyenXe();
        }
        void ShowListTramTrungGian(int id)
        {
            lvTramTrungGian.Items.Clear();
            BUS_TramTrungGian tramtrunggian = new BUS_TramTrungGian();
            List<TramTrungGian> listBillInfo = tramtrunggian.GetTramTrungGian(id);

            foreach (TramTrungGian item in listBillInfo)
            {
                ListViewItem lsvItem = new ListViewItem(item.STT.ToString());
                lsvItem.SubItems.Add(item.TenTram.ToString());
                lsvItem.SubItems.Add(item.DiaDiem.ToString());

                lvTramTrungGian.Items.Add(lsvItem);
            }
        }
        #endregion
        #region event Tuyến xe
        private void btnThemTuyen_Click(object sender, EventArgs e)
        {
            BUS_TuyenXe bus_TuyenXe = new BUS_TuyenXe();
            TuyenXe tx = new TuyenXe();
            tx.KhoangCach = int.Parse(txtKhoangCach.Text);
            tx.ThoiGian = int.Parse(txtThoigian.Text);
            tx.TramDau = (cbbTramDau.SelectedItem as Tram).IDTram;
            tx.TramCuoi = (cbbTramCuoi.SelectedItem as Tram).IDTram;

            if (bus_TuyenXe.InsertTuyenXe(tx))
            {
                MessageBox.Show("Thêm Tuyến thành công");
                LoadDSTuyenXe();
                if (insertTuyenXe != null)
                    insertTuyenXe(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Có lỗi khi thêm Tuyến");
            }
        }

        private void btnCapNhatTuyen_Click(object sender, EventArgs e)
        {
            BUS_TuyenXe bus_TuyenXe = new BUS_TuyenXe();
            TuyenXe tx = new TuyenXe();
            tx.ID = int.Parse(txtIDTuyenXe.Text);
            tx.KhoangCach = int.Parse(txtKhoangCach.Text);
            tx.ThoiGian = int.Parse(txtThoigian.Text);
            tx.TramDau = (cbbTramDau.SelectedItem as Tram).IDTram;
            tx.TramCuoi = (cbbTramCuoi.SelectedItem as Tram).IDTram;

            if (bus_TuyenXe.UpdateTuyenXe(tx))
            {
                MessageBox.Show("Cập nhật Tuyến thành công");
                LoadDSTuyenXe();
                if (updateTuyenXe != null)
                    updateTuyenXe(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Có lỗi khi Cập nhật Tuyến");
            }
        }

        private void btnXoaTuyen_Click(object sender, EventArgs e)
        {
            BUS_TuyenXe bus_TuyenXe = new BUS_TuyenXe();
            int ID = int.Parse(txtIDTuyenXe.Text);

            if (bus_TuyenXe.DeleteTuyenXe(ID))
            {
                MessageBox.Show("Xóa Tuyến thành công");
                LoadDSTuyenXe();
                if (deleteTuyenXe != null)
                    deleteTuyenXe(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Có lỗi khi xóa Tuyến");
            }
        }
        private event EventHandler insertTuyenXe;
        public event EventHandler InsertTuyenXe
        {
            add { insertTuyenXe += value; }
            remove { insertTuyenXe -= value; }
        }

        private event EventHandler updateTuyenXe;
        public event EventHandler UpdateTuyenXe
        {
            add { updateTuyenXe += value; }
            remove { updateTuyenXe -= value; }
        }

        private event EventHandler deleteTuyenXe;
        public event EventHandler DeleteTuyenXe
        {
            add { deleteTuyenXe += value; }
            remove { deleteTuyenXe -= value; }
        }


        private void txtIDTuyenXe_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvTuyenXe.SelectedCells.Count > 0)
                {
                    int id_dau = (int)dgvTuyenXe.SelectedCells[0].OwningRow.Cells["ID_TramDau"].Value;
                    int id_cuoi = (int)dgvTuyenXe.SelectedCells[0].OwningRow.Cells["ID_TramCuoi"].Value;
                    int id = (int)dgvTuyenXe.SelectedCells[0].OwningRow.Cells["ID_Tuyen"].Value;
                    
                    BUS_Tram bustramdau = new BUS_Tram();
                    BUS_Tram bustramcuoi = new BUS_Tram();

                    Tram tramdau = bustramdau.getTramByID(id_dau);
                    Tram tramcuoi = bustramcuoi.getTramByID(id_cuoi);

                    cbbTramDau.SelectedItem = tramdau;
                    cbbTramCuoi.SelectedItem = tramcuoi;
                    lbDiaDiemDau.Text = tramdau.DiaDiem;
                    lbDiaDiemCuoi.Text = tramcuoi.DiaDiem;

                    int index1 = -1, index2 = -1;
                    int i = 0, j = 0;
                    foreach (Tram item in cbbTramDau.Items)
                    {
                        if (item.IDTram == tramdau.IDTram)
                        {
                            index1 = i;
                            break;
                        }
                        i++;
                    }
                    foreach (Tram item in cbbTramCuoi.Items)
                    {
                        if (item.IDTram == tramcuoi.IDTram)
                        {
                            index2 = j;
                            break;
                        }
                        j++;
                    }

                    cbbTramDau.SelectedIndex = index1;
                    cbbTramCuoi.SelectedIndex = index2;
                    ShowListTramTrungGian(id);
                }
            }
            catch { }
        }
        

        private void btnCapNhatTramTG_Click(object sender, EventArgs e)
        {
            SetValueForText1 = (int)dgvTuyenXe.SelectedCells[0].OwningRow.Cells["ID_Tuyen"].Value;
            frmTramTrungGian frmtg = new frmTramTrungGian();
            frmtg.Show();
        }

        private void dgvTuyenXe_Click(object sender, EventArgs e)
        {
            dgvTuyenXe.DataSource = DSTuyenXe;
            LoadDSTuyenXe();
        }
        #endregion
        #region LoadXe
        void LoadLoaiXe(ComboBox cb)
        {
            BUS_LoaiXe bus_loaixe = new BUS_LoaiXe();
            cb.DataSource = bus_loaixe.GetLoaiXe();
            cb.DisplayMember = "TenLoai";
        }

        void AddXeBingding()
        {
            txtSoXe.DataBindings.Add(new Binding("Text", dgvXe.DataSource, "So_dang_ky"));
            txtTenXe.DataBindings.Add(new Binding("Text", dgvXe.DataSource, "TenXe"));
            //txtChoNgoi.DataBindings.Add(new Binding("Text", dgvXe.DataSource, "So_ghe"));
        }

        void LoadDSXe()
        {
            BUS_Xe bus_xe = new BUS_Xe();
            DSXe.DataSource = bus_xe.getXe();
        }
        #endregion
        #region EventXe
        private void btnThemXe_Click(object sender, EventArgs e)
        {
            BUS_Xe bus_Xe = new BUS_Xe();
            Xe tx = new Xe();
            tx.TenXe = (txtTenXe.Text).ToString();
            tx.SoDangKi = (txtSoXe.Text).ToString();
            tx.MaLoaiXe = (cbbLoaiXe.SelectedItem as LoaiXe).MaLoai;

            if (bus_Xe.InsertXe(tx))
            {
                MessageBox.Show("Thêm Xe thành công");
                LoadDSXe();
                if (insertXe != null)
                    insertXe(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Có lỗi khi thêm Xe");
            }
        }

        private void btnSuaXe_Click(object sender, EventArgs e)
        {
            BUS_Xe bus_Xe = new BUS_Xe();
            Xe tx = new Xe();
            tx.TenXe = (txtTenXe.Text).ToString();
            tx.SoDangKi = (txtSoXe.Text).ToString();
            tx.MaLoaiXe = (cbbLoaiXe.SelectedItem as LoaiXe).MaLoai;
            tx.ID = (int)dgvXe.SelectedCells[0].OwningRow.Cells["XeID"].Value;
            if (bus_Xe.UpdateXe(tx))
            {
                MessageBox.Show("Cập nhật Xe thành công");
                LoadDSXe();
                if (updateXe != null)
                    updateXe(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Có lỗi khi Cập nhật Xe");
            }
        }

        private void btnXoaXe_Click(object sender, EventArgs e)
        {
            BUS_Xe bus_Xe = new BUS_Xe();
            int id = (int)dgvXe.SelectedCells[0].OwningRow.Cells["XeID"].Value;

            if (bus_Xe.DeleteXe(id))
            {
                MessageBox.Show("Xóa Xe thành công");
                LoadDSXe();
                if (deleteXe != null)
                    deleteXe(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Có lỗi khi xóa Xe");
            }
        }
        private event EventHandler insertXe;
        public event EventHandler InsertXe
        {
            add { insertXe += value; }
            remove { insertXe -= value; }
        }

        private event EventHandler updateXe;
        public event EventHandler UpdateXe
        {
            add { updateXe += value; }
            remove { updateXe -= value; }
        }

        private event EventHandler deleteXe;
        public event EventHandler DeleteXe
        {
            add { deleteXe += value; }
            remove { deleteXe -= value; }
        }

        private void dgvXe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvXe.SelectedCells.Count > 0)
                {
                    //int id_dau = (int)dgvXe.SelectedCells[0].OwningRow.Cells["ID_TramDau"].Value;
                    //int id_cuoi = (int)dgvXe.SelectedCells[0].OwningRow.Cells["ID_TramCuoi"].Value;
                    int id = (int)dgvXe.SelectedCells[0].OwningRow.Cells["LoaiXe_ID_LoaiXe"].Value;
                    
                    BUS_LoaiXe busloaixe = new BUS_LoaiXe();

                    LoaiXe loaixe = busloaixe.GetLoaiXeByID(id);

                    cbbLoaiXe.SelectedItem = loaixe;

                    int index = -1;
                    int i = 0;
                    foreach (LoaiXe item in cbbLoaiXe.Items)
                    {
                        if (item.MaLoai == loaixe.MaLoai)
                        {
                            index = i;
                            break;
                        }
                        i++;
                    }

                    cbbLoaiXe.SelectedIndex = index;
                    if (id == 1)
                        txtChoNgoi.Text = "30";
                    else if(id==2)
                        txtChoNgoi.Text = "45";
                    else
                        txtChoNgoi.Text = "50";
                }
            }
            catch { }
        }
        #endregion
        #region LoadChuyenXe
        void LoadTuyen(ComboBox cb)
        {
            BUS_TuyenXe BUS_Tuyen = new BUS_TuyenXe();
            cb.DataSource = BUS_Tuyen.GetTuyenXeCbb();
            cb.DisplayMember = "TenTuyen";
        }
        void LoadXe(ComboBox cb)
        {
            BUS_Xe bus_xe = new BUS_Xe();
            cb.DataSource = bus_xe.GetXeToCbb();
            cb.DisplayMember = "TenXe";
        }
        void LoadTaiXe(ComboBox cb)
        {
            BUS_TaiXe bus_TaiXe = new BUS_TaiXe();
            cb.DataSource = bus_TaiXe.getTaiXeCbb();
            cb.DisplayMember = "ID_TaiXe";
        }
        void AddChuyenXeBingding()
        {
            dtpGioKhoiHanh.DataBindings.Add(new Binding("Value", dgvChuyen.DataSource, "Gio_khoi_hanh"));
            txtGhiChu.DataBindings.Add(new Binding("Text", dgvChuyen.DataSource, "Ghi_chu"));
        }

        void LoadDSChuyenXe()
        {
            BUS_ChuyenXe bus_chuyenxe = new BUS_ChuyenXe();
            DSChuyen.DataSource = bus_chuyenxe.getChuyenXe();
        }
        #endregion
        #region Event ChuyenXe
        private void btnThemChuyen_Click(object sender, EventArgs e)
        {
            BUS_ChuyenXe bus_ChuyenXe = new BUS_ChuyenXe();
            ChuyenXe tx = new ChuyenXe();
            tx.GhiChu = txtGhiChu.Text.ToString();
            tx.IDTaiXe = (cbbTaiXe.SelectedItem as TaiXe).ID;
            tx.IDTuyen = (cbbTenTuyen.SelectedItem as TuyenXe).ID;
            tx.IDXe = (cbbxe.SelectedItem as Xe).ID;
            tx.GioKhoiHanh = DateTime.Parse(dtpGioKhoiHanh.Text);


            if (bus_ChuyenXe.InsertChuyenXe(tx))
            {
                MessageBox.Show("Thêm ChuyenXe thành công");
                LoadDSChuyenXe();
                if (insertChuyenXe != null)
                    insertChuyenXe(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Có lỗi khi thêm ChuyenXe");
            }
        }

        private void btnCapNhatChuyen_Click(object sender, EventArgs e)
        {
            BUS_ChuyenXe bus_ChuyenXe = new BUS_ChuyenXe();
            ChuyenXe tx = new ChuyenXe();
            tx.IDChuyen = (int)dgvChuyen.SelectedCells[0].OwningRow.Cells["ID_Chuyen"].Value;
            tx.GhiChu = txtGhiChu.Text.ToString();
            tx.IDTaiXe = (cbbTaiXe.SelectedItem as TaiXe).ID;
            tx.IDTuyen = (cbbTenTuyen.SelectedItem as TuyenXe).ID;
            tx.GioKhoiHanh = DateTime.Parse(dtpGioKhoiHanh.Text);
            if (bus_ChuyenXe.UpdateChuyenXe(tx))
            {
                MessageBox.Show("Cập nhật ChuyenXe thành công");
                LoadDSChuyenXe();
                if (updateChuyenXe != null)
                    updateChuyenXe(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Có lỗi khi Cập nhật ChuyenXe");
            }
        }

        private void btnXoaChuyen_Click(object sender, EventArgs e)
        {
            BUS_ChuyenXe bus_ChuyenXe = new BUS_ChuyenXe();
            int id = (int)dgvChuyen.SelectedCells[0].OwningRow.Cells["ID_Chuyen"].Value;

            if (bus_ChuyenXe.DeleteChuyenXe(id))
            {
                MessageBox.Show("Xóa ChuyenXe thành công");
                LoadDSChuyenXe();
                if (deleteChuyenXe != null)
                    deleteChuyenXe(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Có lỗi khi xóa ChuyenXe");
            }
        }
        private event EventHandler insertChuyenXe;
        public event EventHandler InsertChuyenXe
        {
            add { insertChuyenXe += value; }
            remove { insertChuyenXe -= value; }
        }

        private event EventHandler updateChuyenXe;
        public event EventHandler UpdateChuyenXe
        {
            add { updateChuyenXe += value; }
            remove { updateChuyenXe -= value; }
        }

        private event EventHandler deleteChuyenXe;
        public event EventHandler DeleteChuyenXe
        {
            add { deleteChuyenXe += value; }
            remove { deleteChuyenXe -= value; }
        }

        private void dgvChuyen_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvChuyen.SelectedCells.Count > 0)
                {
                    int id_TaiXe = (int)dgvChuyen.SelectedCells[0].OwningRow.Cells["Tai_xe_ID_Taixe"].Value;
                    int id_Xe = (int)dgvChuyen.SelectedCells[0].OwningRow.Cells["Xe_XeID"].Value;
                    int id_Tuyen = (int)dgvChuyen.SelectedCells[0].OwningRow.Cells["Tuyen_ID_Tuyen"].Value;

                    BUS_TuyenXe busTuyenXe = new BUS_TuyenXe();
                    BUS_Xe busxe = new BUS_Xe();
                    BUS_TaiXe bustaixe = new BUS_TaiXe();

                    TuyenXe tuyenXe = busTuyenXe.getTuyenXeByID(id_Tuyen);
                    Xe xe = busxe.getXeByID(id_Xe);
                    TaiXe taixe = bustaixe.getTaiXeByID(id_TaiXe);

                    cbbTenTuyen.SelectedItem = tuyenXe;
                    cbbxe.SelectedItem = xe;
                    cbbTaiXe.SelectedItem = taixe;

                    int index = -1, index1 = -1, index2 = -1;
                    int i = 0, j = 0, k = 0;
                    foreach (TuyenXe item in cbbTenTuyen.Items)
                    {
                        if (item.ID == tuyenXe.ID)
                        {
                            index = i;
                            break;
                        }
                        i++;
                    }
                    foreach (Xe item in cbbxe.Items)
                    {
                        if (item.ID == xe.ID)
                        {
                            index = j;
                            break;
                        }
                        j++;
                    }
                    foreach (TaiXe item in cbbTaiXe.Items)
                    {
                        if (item.ID == taixe.ID)
                        {
                            index = k;
                            break;
                        }
                        k++;
                    }
                    cbbTenTuyen.SelectedIndex = index;
                    cbbxe.SelectedIndex = index1;
                    cbbTaiXe.SelectedIndex = index2;
                }
            }
            catch { }
        }

        private void tbcKhachHang_Click(object sender, EventArgs e)
        {
            LoadTaiXe(cbbTaiXe);
            LoadXe(cbbxe);
            LoadTuyen(cbbTenTuyen);
        }
        #endregion
        #region LoadTaixe
        void AddTaiXeBingding()
        {
            txtIDTaiXe.DataBindings.Add(new Binding("Text", dgvTaiXe.DataSource, "ID_TaiXe"));
            txtTenTaiXe.DataBindings.Add(new Binding("Text", dgvTaiXe.DataSource, "TenTaiXe"));
            txtBangLai.DataBindings.Add(new Binding("Text", dgvTaiXe.DataSource, "BangLai"));
        }

        void LoadDSTaiXe()
        {
            BUS_TaiXe bus_TaiXe = new BUS_TaiXe();
            DSTaiXe.DataSource = bus_TaiXe.getTaiXe();
        }
        #endregion
        #region Event TaiXe
        private void btnThemTaiXe_Click(object sender, EventArgs e)
        {
            BUS_TaiXe bus_TaiXe = new BUS_TaiXe();
            TaiXe tx = new TaiXe();
            tx.Ten = txtTenTaiXe.Text.ToString();
            tx.BangLai = txtBangLai.Text.ToString();


            if (bus_TaiXe.InsertTaiXe(tx))
            {
                MessageBox.Show("Thêm Tài xế thành công");
                LoadDSTaiXe();
                if (insertTaiXe != null)
                    insertTaiXe(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Có lỗi khi thêm TaiXe");
            }
        }

        private void btnSuaTaiXe_Click(object sender, EventArgs e)
        {
            BUS_TaiXe bus_TaiXe = new BUS_TaiXe();
            TaiXe tx = new TaiXe();
            tx.ID = int.Parse(txtIDTaiXe.Text);
            tx.Ten = txtTenTaiXe.Text.ToString();
            tx.BangLai = txtBangLai.Text.ToString();
            if (bus_TaiXe.UpdateTaiXe(tx))
            {
                MessageBox.Show("Cập nhật TaiXe thành công");
                LoadDSTaiXe();
                if (updateTaiXe != null)
                    updateTaiXe(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Có lỗi khi Cập nhật TaiXe");
            }
        }

        private void btnXoaTaiXe_Click(object sender, EventArgs e)
        {
            BUS_TaiXe bus_TaiXe = new BUS_TaiXe();
            int id = (int)dgvTaiXe.SelectedCells[0].OwningRow.Cells["ID_TaiXe"].Value;

            if (bus_TaiXe.DeleteTaiXe(id))
            {
                MessageBox.Show("Xóa TaiXe thành công");
                LoadDSTaiXe();
                if (deleteTaiXe != null)
                    deleteTaiXe(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Có lỗi khi xóa TaiXe");
            }
        }
        private event EventHandler insertTaiXe;
        public event EventHandler InsertTaiXe
        {
            add { insertTaiXe += value; }
            remove { insertTaiXe -= value; }
        }

        private event EventHandler updateTaiXe;
        public event EventHandler UpdateTaiXe
        {
            add { updateTaiXe += value; }
            remove { updateTaiXe -= value; }
        }

        private event EventHandler deleteTaiXe;
        public event EventHandler DeleteTaiXe
        {
            add { deleteTaiXe += value; }
            remove { deleteTaiXe -= value; }
        }
        private void dgvTaiXe_Click(object sender, EventArgs e)
        {
            dgvTaiXe.DataSource = DSTaiXe;
            LoadDSTaiXe();
        }
        #endregion

    }
     
}
