namespace GUI
{
    partial class frmKhachHang
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtKiemTraKH = new System.Windows.Forms.TextBox();
            this.btnKiemTraKH = new System.Windows.Forms.Button();
            this.dgvKhachHang = new System.Windows.Forms.DataGridView();
            this.btnThemKH = new System.Windows.Forms.Button();
            this.btnXoaKH = new System.Windows.Forms.Button();
            this.btnSuaKH = new System.Windows.Forms.Button();
            this.gpbThongTinKH = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtID_KH = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtLoai = new System.Windows.Forms.TextBox();
            this.btnDatVe = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).BeginInit();
            this.gpbThongTinKH.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên khách hàng";
            // 
            // txtKiemTraKH
            // 
            this.txtKiemTraKH.Location = new System.Drawing.Point(197, 50);
            this.txtKiemTraKH.Name = "txtKiemTraKH";
            this.txtKiemTraKH.Size = new System.Drawing.Size(278, 22);
            this.txtKiemTraKH.TabIndex = 1;
            // 
            // btnKiemTraKH
            // 
            this.btnKiemTraKH.Location = new System.Drawing.Point(512, 47);
            this.btnKiemTraKH.Name = "btnKiemTraKH";
            this.btnKiemTraKH.Size = new System.Drawing.Size(106, 29);
            this.btnKiemTraKH.TabIndex = 2;
            this.btnKiemTraKH.Text = "Kiểm tra";
            this.btnKiemTraKH.UseVisualStyleBackColor = true;
            this.btnKiemTraKH.Click += new System.EventHandler(this.btnKiemTraKH_Click);
            // 
            // dgvKhachHang
            // 
            this.dgvKhachHang.AllowUserToOrderColumns = true;
            this.dgvKhachHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKhachHang.Location = new System.Drawing.Point(12, 102);
            this.dgvKhachHang.Name = "dgvKhachHang";
            this.dgvKhachHang.ReadOnly = true;
            this.dgvKhachHang.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvKhachHang.RowTemplate.Height = 24;
            this.dgvKhachHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKhachHang.Size = new System.Drawing.Size(814, 226);
            this.dgvKhachHang.TabIndex = 3;
            // 
            // btnThemKH
            // 
            this.btnThemKH.Location = new System.Drawing.Point(521, 343);
            this.btnThemKH.Name = "btnThemKH";
            this.btnThemKH.Size = new System.Drawing.Size(97, 31);
            this.btnThemKH.TabIndex = 4;
            this.btnThemKH.Text = "Thêm";
            this.btnThemKH.UseVisualStyleBackColor = true;
            this.btnThemKH.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnThemKH_MouseClick);
            // 
            // btnXoaKH
            // 
            this.btnXoaKH.Location = new System.Drawing.Point(729, 343);
            this.btnXoaKH.Name = "btnXoaKH";
            this.btnXoaKH.Size = new System.Drawing.Size(97, 31);
            this.btnXoaKH.TabIndex = 4;
            this.btnXoaKH.Text = "Xóa";
            this.btnXoaKH.UseVisualStyleBackColor = true;
            // 
            // btnSuaKH
            // 
            this.btnSuaKH.Location = new System.Drawing.Point(626, 343);
            this.btnSuaKH.Name = "btnSuaKH";
            this.btnSuaKH.Size = new System.Drawing.Size(97, 31);
            this.btnSuaKH.TabIndex = 4;
            this.btnSuaKH.Text = "Sửa";
            this.btnSuaKH.UseVisualStyleBackColor = true;
            // 
            // gpbThongTinKH
            // 
            this.gpbThongTinKH.Controls.Add(this.txtLoai);
            this.gpbThongTinKH.Controls.Add(this.label6);
            this.gpbThongTinKH.Controls.Add(this.txtEmail);
            this.gpbThongTinKH.Controls.Add(this.label5);
            this.gpbThongTinKH.Controls.Add(this.txtSDT);
            this.gpbThongTinKH.Controls.Add(this.label4);
            this.gpbThongTinKH.Controls.Add(this.txtHoTen);
            this.gpbThongTinKH.Controls.Add(this.label3);
            this.gpbThongTinKH.Controls.Add(this.txtID_KH);
            this.gpbThongTinKH.Controls.Add(this.label2);
            this.gpbThongTinKH.Location = new System.Drawing.Point(12, 334);
            this.gpbThongTinKH.Name = "gpbThongTinKH";
            this.gpbThongTinKH.Size = new System.Drawing.Size(489, 196);
            this.gpbThongTinKH.TabIndex = 5;
            this.gpbThongTinKH.TabStop = false;
            this.gpbThongTinKH.Text = "Thông tin khách hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "ID";
            // 
            // txtID_KH
            // 
            this.txtID_KH.Location = new System.Drawing.Point(98, 39);
            this.txtID_KH.Name = "txtID_KH";
            this.txtID_KH.Size = new System.Drawing.Size(100, 22);
            this.txtID_KH.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Họ tên";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(98, 67);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(222, 22);
            this.txtHoTen.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "SĐT";
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(98, 95);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(185, 22);
            this.txtSDT.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(98, 123);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(222, 22);
            this.txtEmail.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Loại";
            // 
            // txtLoai
            // 
            this.txtLoai.Location = new System.Drawing.Point(98, 151);
            this.txtLoai.Name = "txtLoai";
            this.txtLoai.Size = new System.Drawing.Size(239, 22);
            this.txtLoai.TabIndex = 1;
            // 
            // btnDatVe
            // 
            this.btnDatVe.Location = new System.Drawing.Point(521, 406);
            this.btnDatVe.Name = "btnDatVe";
            this.btnDatVe.Size = new System.Drawing.Size(305, 61);
            this.btnDatVe.TabIndex = 6;
            this.btnDatVe.Text = "Đặt Vé";
            this.btnDatVe.UseVisualStyleBackColor = true;
            // 
            // frmKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1033, 556);
            this.Controls.Add(this.btnDatVe);
            this.Controls.Add(this.gpbThongTinKH);
            this.Controls.Add(this.btnSuaKH);
            this.Controls.Add(this.btnXoaKH);
            this.Controls.Add(this.btnThemKH);
            this.Controls.Add(this.dgvKhachHang);
            this.Controls.Add(this.btnKiemTraKH);
            this.Controls.Add(this.txtKiemTraKH);
            this.Controls.Add(this.label1);
            this.Name = "frmKhachHang";
            this.Text = "Khách Hàng";
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).EndInit();
            this.gpbThongTinKH.ResumeLayout(false);
            this.gpbThongTinKH.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKiemTraKH;
        private System.Windows.Forms.Button btnKiemTraKH;
        private System.Windows.Forms.DataGridView dgvKhachHang;
        private System.Windows.Forms.Button btnThemKH;
        private System.Windows.Forms.Button btnXoaKH;
        private System.Windows.Forms.Button btnSuaKH;
        private System.Windows.Forms.GroupBox gpbThongTinKH;
        private System.Windows.Forms.TextBox txtLoai;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtID_KH;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDatVe;
    }
}

