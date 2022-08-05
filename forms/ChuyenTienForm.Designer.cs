namespace NGANHANG.forms
{
    partial class ChuyenTienForm
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
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode2 = new DevExpress.XtraGrid.GridLevelNode();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.nGANHANGDataSet = new NGANHANG.NGANHANGDataSet();
            this.tableAdapterManager = new NGANHANG.NGANHANGDataSetTableAdapters.TableAdapterManager();
            this.groupThongTin = new System.Windows.Forms.GroupBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.sP_DS_TAIKHOANBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupChuyenTien = new System.Windows.Forms.GroupBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnChuyen = new System.Windows.Forms.Button();
            this.txtMANV = new System.Windows.Forms.TextBox();
            this.txtNgayChuyen = new System.Windows.Forms.TextBox();
            this.txtTienChuyen = new System.Windows.Forms.TextBox();
            this.txtTKNhan = new System.Windows.Forms.TextBox();
            this.txtTKChuyen = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCMND = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDIACHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSODT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOTK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSODU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMACN_KH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMACN_TK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.taiKhoanGridControl = new DevExpress.XtraGrid.GridControl();
            this.sP_DS_TAIKHOANTableAdapter = new NGANHANG.NGANHANGDataSetTableAdapters.SP_DS_TAIKHOANTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nGANHANGDataSet)).BeginInit();
            this.groupThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sP_DS_TAIKHOANBindingSource)).BeginInit();
            this.groupChuyenTien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taiKhoanGridControl)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.barDockControlTop.Size = new System.Drawing.Size(1836, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 858);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.barDockControlBottom.Size = new System.Drawing.Size(1836, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 858);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1836, 0);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 858);
            // 
            // nGANHANGDataSet
            // 
            this.nGANHANGDataSet.DataSetName = "NGANHANGDataSet";
            this.nGANHANGDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChiNhanhTableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.GD_CHUYENTIENTableAdapter = null;
            this.tableAdapterManager.GD_GOIRUTTableAdapter = null;
            this.tableAdapterManager.KhachHangTableAdapter = null;
            this.tableAdapterManager.NhanVienTableAdapter = null;
            this.tableAdapterManager.TaiKhoanTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = NGANHANG.NGANHANGDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // groupThongTin
            // 
            this.groupThongTin.Controls.Add(this.textBox9);
            this.groupThongTin.Controls.Add(this.textBox8);
            this.groupThongTin.Controls.Add(this.textBox7);
            this.groupThongTin.Controls.Add(this.textBox6);
            this.groupThongTin.Controls.Add(this.textBox5);
            this.groupThongTin.Controls.Add(this.textBox4);
            this.groupThongTin.Controls.Add(this.textBox3);
            this.groupThongTin.Controls.Add(this.textBox2);
            this.groupThongTin.Controls.Add(this.textBox1);
            this.groupThongTin.Controls.Add(this.label10);
            this.groupThongTin.Controls.Add(this.label9);
            this.groupThongTin.Controls.Add(this.label8);
            this.groupThongTin.Controls.Add(this.label7);
            this.groupThongTin.Controls.Add(this.label6);
            this.groupThongTin.Controls.Add(this.label5);
            this.groupThongTin.Controls.Add(this.label4);
            this.groupThongTin.Controls.Add(this.label3);
            this.groupThongTin.Controls.Add(this.label2);
            this.groupThongTin.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupThongTin.Location = new System.Drawing.Point(0, 513);
            this.groupThongTin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupThongTin.Name = "groupThongTin";
            this.groupThongTin.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupThongTin.Size = new System.Drawing.Size(1068, 345);
            this.groupThongTin.TabIndex = 10;
            this.groupThongTin.TabStop = false;
            this.groupThongTin.Text = "Thông Tin";
            // 
            // textBox9
            // 
            this.textBox9.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sP_DS_TAIKHOANBindingSource, "MACN_KH", true));
            this.textBox9.Enabled = false;
            this.textBox9.Location = new System.Drawing.Point(908, 149);
            this.textBox9.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(118, 27);
            this.textBox9.TabIndex = 9;
            // 
            // sP_DS_TAIKHOANBindingSource
            // 
            this.sP_DS_TAIKHOANBindingSource.DataMember = "SP_DS_TAIKHOAN";
            this.sP_DS_TAIKHOANBindingSource.DataSource = this.nGANHANGDataSet;
            // 
            // textBox8
            // 
            this.textBox8.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sP_DS_TAIKHOANBindingSource, "MACN_TK", true));
            this.textBox8.Enabled = false;
            this.textBox8.Location = new System.Drawing.Point(908, 80);
            this.textBox8.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(118, 27);
            this.textBox8.TabIndex = 9;
            // 
            // textBox7
            // 
            this.textBox7.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sP_DS_TAIKHOANBindingSource, "TEN", true));
            this.textBox7.Enabled = false;
            this.textBox7.Location = new System.Drawing.Point(633, 85);
            this.textBox7.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(148, 27);
            this.textBox7.TabIndex = 9;
            // 
            // textBox6
            // 
            this.textBox6.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sP_DS_TAIKHOANBindingSource, "SODT", true));
            this.textBox6.Enabled = false;
            this.textBox6.Location = new System.Drawing.Point(424, 224);
            this.textBox6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(148, 27);
            this.textBox6.TabIndex = 9;
            // 
            // textBox5
            // 
            this.textBox5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sP_DS_TAIKHOANBindingSource, "SODU", true));
            this.textBox5.Enabled = false;
            this.textBox5.Location = new System.Drawing.Point(424, 149);
            this.textBox5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(148, 27);
            this.textBox5.TabIndex = 9;
            // 
            // textBox4
            // 
            this.textBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sP_DS_TAIKHOANBindingSource, "HO", true));
            this.textBox4.Enabled = false;
            this.textBox4.Location = new System.Drawing.Point(428, 85);
            this.textBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(148, 27);
            this.textBox4.TabIndex = 9;
            // 
            // textBox3
            // 
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sP_DS_TAIKHOANBindingSource, "DIACHI", true));
            this.textBox3.Enabled = false;
            this.textBox3.Location = new System.Drawing.Point(178, 224);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(148, 27);
            this.textBox3.TabIndex = 9;
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sP_DS_TAIKHOANBindingSource, "CMND", true));
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(178, 149);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(148, 27);
            this.textBox2.TabIndex = 9;
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sP_DS_TAIKHOANBindingSource, "SOTK", true));
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(178, 80);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(148, 27);
            this.textBox1.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(66, 228);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 19);
            this.label10.TabIndex = 8;
            this.label10.Text = "Địa Chỉ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(586, 85);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 19);
            this.label9.TabIndex = 7;
            this.label9.Text = "Tên";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(362, 85);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 19);
            this.label8.TabIndex = 6;
            this.label8.Text = "Họ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(790, 153);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 19);
            this.label7.TabIndex = 5;
            this.label7.Text = "Chi Nhánh KH";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(792, 85);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 19);
            this.label6.TabIndex = 4;
            this.label6.Text = "Chi Nhánh TK";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(362, 228);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 19);
            this.label5.TabIndex = 3;
            this.label5.Text = "Số ĐT";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(362, 153);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 19);
            this.label4.TabIndex = 2;
            this.label4.Text = "Số Dư";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 153);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "CMND";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 85);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Số Tài Khoản";
            // 
            // groupChuyenTien
            // 
            this.groupChuyenTien.Controls.Add(this.btnThoat);
            this.groupChuyenTien.Controls.Add(this.btnChuyen);
            this.groupChuyenTien.Controls.Add(this.txtMANV);
            this.groupChuyenTien.Controls.Add(this.txtNgayChuyen);
            this.groupChuyenTien.Controls.Add(this.txtTienChuyen);
            this.groupChuyenTien.Controls.Add(this.txtTKNhan);
            this.groupChuyenTien.Controls.Add(this.txtTKChuyen);
            this.groupChuyenTien.Controls.Add(this.label14);
            this.groupChuyenTien.Controls.Add(this.label15);
            this.groupChuyenTien.Controls.Add(this.label12);
            this.groupChuyenTien.Controls.Add(this.label13);
            this.groupChuyenTien.Controls.Add(this.label11);
            this.groupChuyenTien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupChuyenTien.Location = new System.Drawing.Point(1068, 513);
            this.groupChuyenTien.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupChuyenTien.Name = "groupChuyenTien";
            this.groupChuyenTien.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupChuyenTien.Size = new System.Drawing.Size(768, 345);
            this.groupChuyenTien.TabIndex = 11;
            this.groupChuyenTien.TabStop = false;
            this.groupChuyenTien.Text = "Chuyển Tiền";
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(471, 285);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(150, 34);
            this.btnThoat.TabIndex = 4;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnChuyen
            // 
            this.btnChuyen.Location = new System.Drawing.Point(471, 219);
            this.btnChuyen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnChuyen.Name = "btnChuyen";
            this.btnChuyen.Size = new System.Drawing.Size(150, 35);
            this.btnChuyen.TabIndex = 3;
            this.btnChuyen.Text = "Chuyển Tiền";
            this.btnChuyen.UseVisualStyleBackColor = true;
            this.btnChuyen.Click += new System.EventHandler(this.btnChuyen_Click);
            // 
            // txtMANV
            // 
            this.txtMANV.Enabled = false;
            this.txtMANV.Location = new System.Drawing.Point(471, 80);
            this.txtMANV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMANV.Name = "txtMANV";
            this.txtMANV.Size = new System.Drawing.Size(148, 27);
            this.txtMANV.TabIndex = 2;
            // 
            // txtNgayChuyen
            // 
            this.txtNgayChuyen.Enabled = false;
            this.txtNgayChuyen.Location = new System.Drawing.Point(471, 149);
            this.txtNgayChuyen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNgayChuyen.Name = "txtNgayChuyen";
            this.txtNgayChuyen.Size = new System.Drawing.Size(148, 27);
            this.txtNgayChuyen.TabIndex = 2;
            // 
            // txtTienChuyen
            // 
            this.txtTienChuyen.Location = new System.Drawing.Point(189, 224);
            this.txtTienChuyen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTienChuyen.Name = "txtTienChuyen";
            this.txtTienChuyen.Size = new System.Drawing.Size(148, 27);
            this.txtTienChuyen.TabIndex = 2;
            this.txtTienChuyen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTienChuyen_KeyPress);
            // 
            // txtTKNhan
            // 
            this.txtTKNhan.Location = new System.Drawing.Point(189, 149);
            this.txtTKNhan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTKNhan.Name = "txtTKNhan";
            this.txtTKNhan.Size = new System.Drawing.Size(148, 27);
            this.txtTKNhan.TabIndex = 2;
            this.txtTKNhan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTKNhan_KeyPress);
            // 
            // txtTKChuyen
            // 
            this.txtTKChuyen.Location = new System.Drawing.Point(189, 80);
            this.txtTKChuyen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTKChuyen.Name = "txtTKChuyen";
            this.txtTKChuyen.Size = new System.Drawing.Size(148, 27);
            this.txtTKChuyen.TabIndex = 2;
            this.txtTKChuyen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTKChuyen_KeyPress);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(354, 153);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(103, 19);
            this.label14.TabIndex = 1;
            this.label14.Text = "Ngày Chuyển";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(57, 228);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(121, 19);
            this.label15.TabIndex = 1;
            this.label15.Text = "Số Tiền Chuyển";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(87, 153);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(93, 19);
            this.label12.TabIndex = 1;
            this.label12.Text = "Số TK Nhận";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(354, 85);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(107, 19);
            this.label13.TabIndex = 0;
            this.label13.Text = "Mã Nhân Viên";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(69, 89);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(109, 19);
            this.label11.TabIndex = 0;
            this.label11.Text = "Số TK Chuyển";
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCMND,
            this.colHO,
            this.colTEN,
            this.colDIACHI,
            this.colSODT,
            this.colSOTK,
            this.colSODU,
            this.colMACN_KH,
            this.colMACN_TK});
            this.gridView1.DetailHeight = 512;
            this.gridView1.FixedLineWidth = 3;
            this.gridView1.GridControl = this.taiKhoanGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colSOTK, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colCMND
            // 
            this.colCMND.FieldName = "CMND";
            this.colCMND.MinWidth = 30;
            this.colCMND.Name = "colCMND";
            this.colCMND.Visible = true;
            this.colCMND.VisibleIndex = 1;
            this.colCMND.Width = 204;
            // 
            // colHO
            // 
            this.colHO.FieldName = "HO";
            this.colHO.MinWidth = 30;
            this.colHO.Name = "colHO";
            this.colHO.Visible = true;
            this.colHO.VisibleIndex = 2;
            this.colHO.Width = 172;
            // 
            // colTEN
            // 
            this.colTEN.FieldName = "TEN";
            this.colTEN.MinWidth = 30;
            this.colTEN.Name = "colTEN";
            this.colTEN.Visible = true;
            this.colTEN.VisibleIndex = 3;
            this.colTEN.Width = 172;
            // 
            // colDIACHI
            // 
            this.colDIACHI.FieldName = "DIACHI";
            this.colDIACHI.MinWidth = 30;
            this.colDIACHI.Name = "colDIACHI";
            this.colDIACHI.Visible = true;
            this.colDIACHI.VisibleIndex = 5;
            this.colDIACHI.Width = 205;
            // 
            // colSODT
            // 
            this.colSODT.FieldName = "SODT";
            this.colSODT.MinWidth = 30;
            this.colSODT.Name = "colSODT";
            this.colSODT.Visible = true;
            this.colSODT.VisibleIndex = 6;
            this.colSODT.Width = 160;
            // 
            // colSOTK
            // 
            this.colSOTK.DisplayFormat.FormatString = "{0:#,### VND}";
            this.colSOTK.FieldName = "SOTK";
            this.colSOTK.MinWidth = 30;
            this.colSOTK.Name = "colSOTK";
            this.colSOTK.Visible = true;
            this.colSOTK.VisibleIndex = 0;
            this.colSOTK.Width = 121;
            // 
            // colSODU
            // 
            this.colSODU.FieldName = "SODU";
            this.colSODU.MinWidth = 30;
            this.colSODU.Name = "colSODU";
            this.colSODU.Visible = true;
            this.colSODU.VisibleIndex = 4;
            this.colSODU.Width = 249;
            // 
            // colMACN_KH
            // 
            this.colMACN_KH.FieldName = "MACN_KH";
            this.colMACN_KH.MinWidth = 30;
            this.colMACN_KH.Name = "colMACN_KH";
            this.colMACN_KH.Visible = true;
            this.colMACN_KH.VisibleIndex = 7;
            this.colMACN_KH.Width = 150;
            // 
            // colMACN_TK
            // 
            this.colMACN_TK.FieldName = "MACN_TK";
            this.colMACN_TK.MinWidth = 30;
            this.colMACN_TK.Name = "colMACN_TK";
            this.colMACN_TK.Visible = true;
            this.colMACN_TK.VisibleIndex = 8;
            this.colMACN_TK.Width = 166;
            // 
            // taiKhoanGridControl
            // 
            this.taiKhoanGridControl.DataSource = this.sP_DS_TAIKHOANBindingSource;
            this.taiKhoanGridControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.taiKhoanGridControl.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            gridLevelNode1.RelationName = "Level1";
            gridLevelNode2.RelationName = "Level2";
            this.taiKhoanGridControl.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1,
            gridLevelNode2});
            this.taiKhoanGridControl.Location = new System.Drawing.Point(0, 0);
            this.taiKhoanGridControl.MainView = this.gridView1;
            this.taiKhoanGridControl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.taiKhoanGridControl.MenuManager = this.barManager1;
            this.taiKhoanGridControl.Name = "taiKhoanGridControl";
            this.taiKhoanGridControl.Size = new System.Drawing.Size(1836, 513);
            this.taiKhoanGridControl.TabIndex = 5;
            this.taiKhoanGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // sP_DS_TAIKHOANTableAdapter
            // 
            this.sP_DS_TAIKHOANTableAdapter.ClearBeforeFill = true;
            // 
            // ChuyenTienForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1836, 858);
            this.Controls.Add(this.groupChuyenTien);
            this.Controls.Add(this.groupThongTin);
            this.Controls.Add(this.taiKhoanGridControl);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ChuyenTienForm";
            this.Text = "ChuyenTienForm";
            this.Load += new System.EventHandler(this.ChuyenTienForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nGANHANGDataSet)).EndInit();
            this.groupThongTin.ResumeLayout(false);
            this.groupThongTin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sP_DS_TAIKHOANBindingSource)).EndInit();
            this.groupChuyenTien.ResumeLayout(false);
            this.groupChuyenTien.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taiKhoanGridControl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private NGANHANGDataSet nGANHANGDataSet;
        private NGANHANGDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.GroupBox groupChuyenTien;
        private System.Windows.Forms.GroupBox groupThongTin;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private DevExpress.XtraGrid.GridControl taiKhoanGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource sP_DS_TAIKHOANBindingSource;
        private NGANHANGDataSetTableAdapters.SP_DS_TAIKHOANTableAdapter sP_DS_TAIKHOANTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colCMND;
        private DevExpress.XtraGrid.Columns.GridColumn colHO;
        private DevExpress.XtraGrid.Columns.GridColumn colTEN;
        private DevExpress.XtraGrid.Columns.GridColumn colDIACHI;
        private DevExpress.XtraGrid.Columns.GridColumn colSODT;
        private DevExpress.XtraGrid.Columns.GridColumn colSOTK;
        private DevExpress.XtraGrid.Columns.GridColumn colSODU;
        private DevExpress.XtraGrid.Columns.GridColumn colMACN_KH;
        private DevExpress.XtraGrid.Columns.GridColumn colMACN_TK;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnChuyen;
        private System.Windows.Forms.TextBox txtMANV;
        private System.Windows.Forms.TextBox txtNgayChuyen;
        private System.Windows.Forms.TextBox txtTienChuyen;
        private System.Windows.Forms.TextBox txtTKNhan;
        private System.Windows.Forms.TextBox txtTKChuyen;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnThoat;
    }
}