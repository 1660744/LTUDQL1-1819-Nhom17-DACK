namespace GUI
{
    partial class frmTramTrungGian
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
            this.txtSTT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbDiaDiem = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbbTenTram = new System.Windows.Forms.ComboBox();
            this.txtIDTuyen = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvTramTG = new System.Windows.Forms.DataGridView();
            this.btnThemTrTG = new System.Windows.Forms.Button();
            this.btnXoaTrTG = new System.Windows.Forms.Button();
            this.btnSuaTrTG = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTramTG)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSTT
            // 
            this.txtSTT.Location = new System.Drawing.Point(97, 67);
            this.txtSTT.Name = "txtSTT";
            this.txtSTT.Size = new System.Drawing.Size(96, 22);
            this.txtSTT.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "STT";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbDiaDiem);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cbbTenTram);
            this.groupBox1.Controls.Add(this.txtIDTuyen);
            this.groupBox1.Controls.Add(this.txtSTT);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(33, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(542, 176);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin trạm trung gian";
            // 
            // lbDiaDiem
            // 
            this.lbDiaDiem.AutoSize = true;
            this.lbDiaDiem.Location = new System.Drawing.Point(104, 135);
            this.lbDiaDiem.Name = "lbDiaDiem";
            this.lbDiaDiem.Size = new System.Drawing.Size(53, 17);
            this.lbDiaDiem.TabIndex = 5;
            this.lbDiaDiem.Text = "Trạm 1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Tên trạm";
            // 
            // cbbTenTram
            // 
            this.cbbTenTram.FormattingEnabled = true;
            this.cbbTenTram.Location = new System.Drawing.Point(97, 95);
            this.cbbTenTram.Name = "cbbTenTram";
            this.cbbTenTram.Size = new System.Drawing.Size(241, 24);
            this.cbbTenTram.TabIndex = 3;
            // 
            // txtIDTuyen
            // 
            this.txtIDTuyen.Location = new System.Drawing.Point(97, 37);
            this.txtIDTuyen.Name = "txtIDTuyen";
            this.txtIDTuyen.ReadOnly = true;
            this.txtIDTuyen.Size = new System.Drawing.Size(131, 22);
            this.txtIDTuyen.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Địa điểm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID_Tuyen";
            // 
            // dgvTramTG
            // 
            this.dgvTramTG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTramTG.Location = new System.Drawing.Point(12, 206);
            this.dgvTramTG.Name = "dgvTramTG";
            this.dgvTramTG.ReadOnly = true;
            this.dgvTramTG.RowTemplate.Height = 24;
            this.dgvTramTG.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTramTG.Size = new System.Drawing.Size(579, 150);
            this.dgvTramTG.TabIndex = 3;
            this.dgvTramTG.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTramTG_CellClick);
            this.dgvTramTG.Click += new System.EventHandler(this.dgvTramTG_Click);
            // 
            // btnThemTrTG
            // 
            this.btnThemTrTG.Location = new System.Drawing.Point(140, 382);
            this.btnThemTrTG.Name = "btnThemTrTG";
            this.btnThemTrTG.Size = new System.Drawing.Size(109, 51);
            this.btnThemTrTG.TabIndex = 4;
            this.btnThemTrTG.Text = "Thêm";
            this.btnThemTrTG.UseVisualStyleBackColor = true;
            this.btnThemTrTG.Click += new System.EventHandler(this.btnThemTrTG_Click);
            // 
            // btnXoaTrTG
            // 
            this.btnXoaTrTG.Location = new System.Drawing.Point(370, 382);
            this.btnXoaTrTG.Name = "btnXoaTrTG";
            this.btnXoaTrTG.Size = new System.Drawing.Size(109, 51);
            this.btnXoaTrTG.TabIndex = 4;
            this.btnXoaTrTG.Text = "Xóa";
            this.btnXoaTrTG.UseVisualStyleBackColor = true;
            this.btnXoaTrTG.Click += new System.EventHandler(this.btnXoaTrTG_Click);
            // 
            // btnSuaTrTG
            // 
            this.btnSuaTrTG.Location = new System.Drawing.Point(255, 382);
            this.btnSuaTrTG.Name = "btnSuaTrTG";
            this.btnSuaTrTG.Size = new System.Drawing.Size(109, 51);
            this.btnSuaTrTG.TabIndex = 4;
            this.btnSuaTrTG.Text = "Sửa";
            this.btnSuaTrTG.UseVisualStyleBackColor = true;
            this.btnSuaTrTG.Click += new System.EventHandler(this.btnSuaTrTG_Click);
            // 
            // frmTramTrungGian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 445);
            this.Controls.Add(this.btnSuaTrTG);
            this.Controls.Add(this.btnXoaTrTG);
            this.Controls.Add(this.btnThemTrTG);
            this.Controls.Add(this.dgvTramTG);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmTramTrungGian";
            this.Text = "frmTramTrungGian";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTramTG)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtSTT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbbTenTram;
        private System.Windows.Forms.TextBox txtIDTuyen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbDiaDiem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvTramTG;
        private System.Windows.Forms.Button btnThemTrTG;
        private System.Windows.Forms.Button btnXoaTrTG;
        private System.Windows.Forms.Button btnSuaTrTG;
    }
}