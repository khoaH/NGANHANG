namespace NGANHANG.forms
{
    partial class TaiKhoanForm
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
            this.groupTK = new System.Windows.Forms.GroupBox();
            this.lookupKH = new DevExpress.XtraEditors.LookUpEdit();
            this.txtCMND = new System.Windows.Forms.TextBox();
            this.taiKhoanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nGANHANGDataSet1 = new NGANHANG.NGANHANGDataSet1();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnThemTK = new System.Windows.Forms.Button();
            this.btnLuuTK = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.txtNgayTao = new System.Windows.Forms.TextBox();
            this.txtSoDu = new System.Windows.Forms.TextBox();
            this.txtChiNhanhTK = new System.Windows.Forms.TextBox();
            this.txtSoTK = new System.Windows.Forms.TextBox();
            this.taiKhoanTableAdapter = new NGANHANG.NGANHANGDataSet1TableAdapters.TaiKhoanTableAdapter();
            this.tableAdapterManager = new NGANHANG.NGANHANGDataSet1TableAdapters.TableAdapterManager();
            this.taiKhoanGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSOTK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCMND = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSODU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMACN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAYMOTK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.sPDSKHACHHANGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sP_DS_KHACHHANGTableAdapter = new NGANHANG.NGANHANGDataSet1TableAdapters.SP_DS_KHACHHANGTableAdapter();
            this.groupTK.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookupKH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taiKhoanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nGANHANGDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taiKhoanGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPDSKHACHHANGBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupTK
            // 
            this.groupTK.Controls.Add(this.lookupKH);
            this.groupTK.Controls.Add(this.txtCMND);
            this.groupTK.Controls.Add(this.label1);
            this.groupTK.Controls.Add(this.label8);
            this.groupTK.Controls.Add(this.btnHuy);
            this.groupTK.Controls.Add(this.btnThemTK);
            this.groupTK.Controls.Add(this.btnLuuTK);
            this.groupTK.Controls.Add(this.label7);
            this.groupTK.Controls.Add(this.label6);
            this.groupTK.Controls.Add(this.label5);
            this.groupTK.Controls.Add(this.label4);
            this.groupTK.Controls.Add(this.btnThoat);
            this.groupTK.Controls.Add(this.txtNgayTao);
            this.groupTK.Controls.Add(this.txtSoDu);
            this.groupTK.Controls.Add(this.txtChiNhanhTK);
            this.groupTK.Controls.Add(this.txtSoTK);
            this.groupTK.Location = new System.Drawing.Point(12, 391);
            this.groupTK.Name = "groupTK";
            this.groupTK.Size = new System.Drawing.Size(1008, 198);
            this.groupTK.TabIndex = 1;
            this.groupTK.TabStop = false;
            this.groupTK.Text = "Tài Khoản";
            // 
            // lookupKH
            // 
            this.lookupKH.Enabled = false;
            this.lookupKH.Location = new System.Drawing.Point(280, 44);
            this.lookupKH.Name = "lookupKH";
            this.lookupKH.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookupKH.Properties.DataSource = this.sPDSKHACHHANGBindingSource;
            this.lookupKH.Properties.DisplayMember = "THONGTIN";
            this.lookupKH.Properties.ValueMember = "CMND";
            this.lookupKH.Size = new System.Drawing.Size(464, 20);
            this.lookupKH.TabIndex = 21;
            this.lookupKH.EditValueChanged += new System.EventHandler(this.lookupKH_EditValueChanged);
            // 
            // txtCMND
            // 
            this.txtCMND.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.taiKhoanBindingSource, "CMND", true));
            this.txtCMND.Enabled = false;
            this.txtCMND.Location = new System.Drawing.Point(566, 136);
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Size = new System.Drawing.Size(178, 21);
            this.txtCMND.TabIndex = 20;
            // 
            // taiKhoanBindingSource
            // 
            this.taiKhoanBindingSource.DataMember = "TaiKhoan";
            this.taiKhoanBindingSource.DataSource = this.nGANHANGDataSet1;
            // 
            // nGANHANGDataSet1
            // 
            this.nGANHANGDataSet1.DataSetName = "NGANHANGDataSet1";
            this.nGANHANGDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(524, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "CMND";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(209, 47);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Khách Hàng";
            // 
            // btnHuy
            // 
            this.btnHuy.Enabled = false;
            this.btnHuy.Location = new System.Drawing.Point(538, 163);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(100, 29);
            this.btnHuy.TabIndex = 17;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnThemTK
            // 
            this.btnThemTK.Location = new System.Drawing.Point(326, 163);
            this.btnThemTK.Name = "btnThemTK";
            this.btnThemTK.Size = new System.Drawing.Size(100, 29);
            this.btnThemTK.TabIndex = 16;
            this.btnThemTK.Text = "Thêm";
            this.btnThemTK.UseVisualStyleBackColor = true;
            this.btnThemTK.Click += new System.EventHandler(this.btnThemTK_Click);
            // 
            // btnLuuTK
            // 
            this.btnLuuTK.Enabled = false;
            this.btnLuuTK.Location = new System.Drawing.Point(432, 163);
            this.btnLuuTK.Name = "btnLuuTK";
            this.btnLuuTK.Size = new System.Drawing.Size(100, 29);
            this.btnLuuTK.TabIndex = 15;
            this.btnLuuTK.Text = "Lưu";
            this.btnLuuTK.UseVisualStyleBackColor = true;
            this.btnLuuTK.Click += new System.EventHandler(this.btnLuuTK_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(218, 112);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Chi Nhánh";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(524, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Số Dư";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(507, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Ngày Tạo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(239, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Số TK";
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(644, 163);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(100, 29);
            this.btnThoat.TabIndex = 8;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // txtNgayTao
            // 
            this.txtNgayTao.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.taiKhoanBindingSource, "NGAYMOTK", true));
            this.txtNgayTao.Enabled = false;
            this.txtNgayTao.Location = new System.Drawing.Point(566, 109);
            this.txtNgayTao.Name = "txtNgayTao";
            this.txtNgayTao.Size = new System.Drawing.Size(178, 21);
            this.txtNgayTao.TabIndex = 11;
            // 
            // txtSoDu
            // 
            this.txtSoDu.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.taiKhoanBindingSource, "SODU", true));
            this.txtSoDu.Enabled = false;
            this.txtSoDu.Location = new System.Drawing.Point(566, 82);
            this.txtSoDu.Name = "txtSoDu";
            this.txtSoDu.Size = new System.Drawing.Size(178, 21);
            this.txtSoDu.TabIndex = 10;
            // 
            // txtChiNhanhTK
            // 
            this.txtChiNhanhTK.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.taiKhoanBindingSource, "MACN", true));
            this.txtChiNhanhTK.Enabled = false;
            this.txtChiNhanhTK.Location = new System.Drawing.Point(280, 109);
            this.txtChiNhanhTK.Name = "txtChiNhanhTK";
            this.txtChiNhanhTK.Size = new System.Drawing.Size(183, 21);
            this.txtChiNhanhTK.TabIndex = 9;
            // 
            // txtSoTK
            // 
            this.txtSoTK.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.taiKhoanBindingSource, "SOTK", true));
            this.txtSoTK.Enabled = false;
            this.txtSoTK.Location = new System.Drawing.Point(280, 82);
            this.txtSoTK.Name = "txtSoTK";
            this.txtSoTK.Size = new System.Drawing.Size(183, 21);
            this.txtSoTK.TabIndex = 8;
            // 
            // taiKhoanTableAdapter
            // 
            this.taiKhoanTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChiNhanhTableAdapter = null;
            this.tableAdapterManager.GD_CHUYENTIENTableAdapter = null;
            this.tableAdapterManager.GD_GOIRUTTableAdapter = null;
            this.tableAdapterManager.KhachHangTableAdapter = null;
            this.tableAdapterManager.NhanVienTableAdapter = null;
            this.tableAdapterManager.TaiKhoanTableAdapter = this.taiKhoanTableAdapter;
            this.tableAdapterManager.UpdateOrder = NGANHANG.NGANHANGDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // taiKhoanGridControl
            // 
            this.taiKhoanGridControl.DataSource = this.taiKhoanBindingSource;
            this.taiKhoanGridControl.Location = new System.Drawing.Point(12, 12);
            this.taiKhoanGridControl.MainView = this.gridView1;
            this.taiKhoanGridControl.Name = "taiKhoanGridControl";
            this.taiKhoanGridControl.Size = new System.Drawing.Size(1008, 373);
            this.taiKhoanGridControl.TabIndex = 3;
            this.taiKhoanGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSOTK,
            this.colCMND,
            this.colSODU,
            this.colMACN,
            this.colNGAYMOTK});
            this.gridView1.GridControl = this.taiKhoanGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // colSOTK
            // 
            this.colSOTK.FieldName = "SOTK";
            this.colSOTK.Name = "colSOTK";
            this.colSOTK.Visible = true;
            this.colSOTK.VisibleIndex = 0;
            this.colSOTK.Width = 196;
            // 
            // colCMND
            // 
            this.colCMND.FieldName = "CMND";
            this.colCMND.Name = "colCMND";
            this.colCMND.Visible = true;
            this.colCMND.VisibleIndex = 1;
            this.colCMND.Width = 196;
            // 
            // colSODU
            // 
            this.colSODU.FieldName = "SODU";
            this.colSODU.Name = "colSODU";
            this.colSODU.Visible = true;
            this.colSODU.VisibleIndex = 2;
            this.colSODU.Width = 287;
            // 
            // colMACN
            // 
            this.colMACN.FieldName = "MACN";
            this.colMACN.Name = "colMACN";
            this.colMACN.Visible = true;
            this.colMACN.VisibleIndex = 3;
            this.colMACN.Width = 124;
            // 
            // colNGAYMOTK
            // 
            this.colNGAYMOTK.FieldName = "NGAYMOTK";
            this.colNGAYMOTK.Name = "colNGAYMOTK";
            this.colNGAYMOTK.Visible = true;
            this.colNGAYMOTK.VisibleIndex = 4;
            this.colNGAYMOTK.Width = 180;
            // 
            // sPDSKHACHHANGBindingSource
            // 
            this.sPDSKHACHHANGBindingSource.DataMember = "SP_DS_KHACHHANG";
            this.sPDSKHACHHANGBindingSource.DataSource = this.nGANHANGDataSet1;
            // 
            // sP_DS_KHACHHANGTableAdapter
            // 
            this.sP_DS_KHACHHANGTableAdapter.ClearBeforeFill = true;
            // 
            // TaiKhoanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 601);
            this.Controls.Add(this.taiKhoanGridControl);
            this.Controls.Add(this.groupTK);
            this.Name = "TaiKhoanForm";
            this.Text = "Tài Khoản";
            this.Load += new System.EventHandler(this.TaiKhoanForm_Load);
            this.groupTK.ResumeLayout(false);
            this.groupTK.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookupKH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taiKhoanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nGANHANGDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taiKhoanGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPDSKHACHHANGBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupTK;
        private NGANHANGDataSet1 nGANHANGDataSet1;
        private System.Windows.Forms.BindingSource taiKhoanBindingSource;
        private NGANHANGDataSet1TableAdapters.TaiKhoanTableAdapter taiKhoanTableAdapter;
        private NGANHANGDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl taiKhoanGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colSOTK;
        private DevExpress.XtraGrid.Columns.GridColumn colCMND;
        private DevExpress.XtraGrid.Columns.GridColumn colSODU;
        private DevExpress.XtraGrid.Columns.GridColumn colMACN;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAYMOTK;
        private System.Windows.Forms.Button btnThemTK;
        private System.Windows.Forms.Button btnLuuTK;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.TextBox txtNgayTao;
        private System.Windows.Forms.TextBox txtSoDu;
        private System.Windows.Forms.TextBox txtChiNhanhTK;
        private System.Windows.Forms.TextBox txtSoTK;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Label label8;
        private DevExpress.XtraEditors.LookUpEdit lookupKH;
        private System.Windows.Forms.TextBox txtCMND;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource sPDSKHACHHANGBindingSource;
        private NGANHANGDataSet1TableAdapters.SP_DS_KHACHHANGTableAdapter sP_DS_KHACHHANGTableAdapter;
    }
}