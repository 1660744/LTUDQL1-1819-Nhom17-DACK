using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;
namespace GUI
{
    public partial class frmTramTrungGian : Form
    {
        BindingSource DSTramTG = new BindingSource();
        public frmTramTrungGian()
        {
            InitializeComponent();
            LoadData();
        }
        void LoadData()
        {
            txtIDTuyen.Text = frmAdmin.SetValueForText1.ToString();
            dgvTramTG.DataSource = DSTramTG;

            LoadListTrTG();
            
            LoadTram(cbbTenTram);
            AddTramTGBingding();
        }
        void AddTramTGBingding()
        {
            txtSTT.DataBindings.Add(new Binding("Text", dgvTramTG.DataSource, "Thu_tu"));
            lbDiaDiem.DataBindings.Add(new Binding("Text", dgvTramTG.DataSource, "Dia_diem"));
        }
        void LoadTram(ComboBox cb)
        {
            BUS_Tram bus_tram = new BUS_Tram();
            cb.DataSource = bus_tram.getTram();
            cb.DisplayMember = "TenTram";
        }
        void LoadListTrTG()
        {
            BUS_TramTrungGian bus_TramTrungGian = new BUS_TramTrungGian();
            DataTable dt = bus_TramTrungGian.GetTramTrungGianByID(frmAdmin.SetValueForText1);

            DSTramTG.DataSource = dt;
        }

        private void dgvTramTG_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvTramTG.SelectedCells.Count > 0)
                {
                    int id_dau = (int)dgvTramTG.SelectedCells[0].OwningRow.Cells["Tram_ID_Tram"].Value;
                    //int id = (int)dgvTramTG.SelectedCells[0].OwningRow.Cells["ID_TramTG"].Value;

                    BUS_Tram bustram = new BUS_Tram();
                    BUS_Tram bustramcuoi = new BUS_Tram();

                    Tram tram = bustram.getTramByID(id_dau);

                    cbbTenTram.SelectedItem = tram;
                    lbDiaDiem.Text = tram.DiaDiem;

                    int index = -1;
                    int i = 0;
                    foreach (Tram item in cbbTenTram.Items)
                    {
                        if (item.IDTram == tram.IDTram)
                        {
                            index = i;
                            break;
                        }
                        i++;
                    }

                    cbbTenTram.SelectedIndex = index;
                }
            }
            catch { }
        }
        
        private void btnThemTrTG_Click(object sender, EventArgs e)
        {
            BUS_TramTrungGian BUS_TramTrungGian = new BUS_TramTrungGian();
            //int stt = int.Parse(txtSTT.Text);
            int id_tram = (cbbTenTram.SelectedItem as Tram).IDTram;
            int id_tuyen = frmAdmin.SetValueForText1;
            if (BUS_TramTrungGian.InsertTramTrungGian(id_tuyen,id_tram))
            {
                MessageBox.Show("Thêm Trạm thành công");
                LoadListTrTG();
                if (insertTramTrungGian != null)
                    insertTramTrungGian(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Có lỗi khi thêm Trạm");
            }
        }
        private void btnSuaTrTG_Click(object sender, EventArgs e)
        {
            BUS_TramTrungGian BUS_TramTrungGian = new BUS_TramTrungGian();
            int stt = int.Parse(txtSTT.Text);
            int id_tram = (int)dgvTramTG.SelectedCells[0].OwningRow.Cells["Tram_ID_Tram"].Value;
            int id_tuyen = frmAdmin.SetValueForText1;

            if (BUS_TramTrungGian.UpdateTramTrungGian(stt, id_tuyen, id_tram))
            {
                MessageBox.Show("Cập nhật Trạm thành công");
                LoadListTrTG();
                if (updateTramTrungGian != null)
                    updateTramTrungGian(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Có lỗi khi Cập nhật Trạm");
            }
        }

        private void btnXoaTrTG_Click(object sender, EventArgs e)
        {
            BUS_TramTrungGian BUS_TramTrungGian = new BUS_TramTrungGian();
            int id_tram = (int)dgvTramTG.SelectedCells[0].OwningRow.Cells["Tram_ID_Tram"].Value;
            int id_tuyen = frmAdmin.SetValueForText1;

            if (BUS_TramTrungGian.DeleteTramTrungGian(id_tuyen, id_tram))
            {
                MessageBox.Show("Xóa Trạm thành công");
                LoadListTrTG();
                if (deleteTramTrungGian != null)
                    deleteTramTrungGian(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Có lỗi khi xóa Trạm");
            }
        }
        private event EventHandler insertTramTrungGian;
        public event EventHandler InsertTramTrungGian
        {
            add { insertTramTrungGian += value; }
            remove { insertTramTrungGian -= value; }
        }

        private event EventHandler updateTramTrungGian;
        public event EventHandler UpdateTramTrungGian
        {
            add { updateTramTrungGian += value; }
            remove { updateTramTrungGian -= value; }
        }

        private event EventHandler deleteTramTrungGian;
        public event EventHandler DeleteTramTrungGian
        {
            add { deleteTramTrungGian += value; }
            remove { deleteTramTrungGian -= value; }
        }

        private void dgvTramTG_Click(object sender, EventArgs e)
        {
            dgvTramTG.DataSource = DSTramTG;
            LoadListTrTG();
        }
    }
}
