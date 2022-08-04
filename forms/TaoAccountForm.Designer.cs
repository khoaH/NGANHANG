namespace NGANHANG.forms
{
    partial class TaoAccountForm
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
            this.cbChiNhanh = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtLoginName = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lookUpNhanVien = new DevExpress.XtraEditors.LookUpEdit();
            this.vDSNVBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nGANHANGDataSet = new NGANHANG.NGANHANGDataSet();
            this.txtConfirm = new System.Windows.Forms.TextBox();
            this.vDS_NVTableAdapter = new NGANHANG.NGANHANGDataSetTableAdapters.vDS_NVTableAdapter();
            this.txtNhomQuyen = new System.Windows.Forms.TextBox();
            this.btnTaoLogin = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpNhanVien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vDSNVBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nGANHANGDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // cbChiNhanh
            // 
            this.cbChiNhanh.FormattingEnabled = true;
            this.cbChiNhanh.Location = new System.Drawing.Point(253, 57);
            this.cbChiNhanh.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbChiNhanh.Name = "cbChiNhanh";
            this.cbChiNhanh.Size = new System.Drawing.Size(178, 21);
            this.cbChiNhanh.TabIndex = 0;
            this.cbChiNhanh.SelectedIndexChanged += new System.EventHandler(this.cbChiNhanh_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 20F);
            this.label1.Location = new System.Drawing.Point(268, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "TẠO LOGIN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(157, 59);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Chi Nhánh";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(157, 100);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Login Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(157, 141);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(157, 183);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Confirm Password";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(157, 223);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Nhân Viên";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(157, 263);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Nhóm Quyền";
            // 
            // txtLoginName
            // 
            this.txtLoginName.Location = new System.Drawing.Point(253, 98);
            this.txtLoginName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtLoginName.Name = "txtLoginName";
            this.txtLoginName.Size = new System.Drawing.Size(178, 21);
            this.txtLoginName.TabIndex = 2;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(253, 139);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(178, 21);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // lookUpNhanVien
            // 
            this.lookUpNhanVien.Location = new System.Drawing.Point(253, 220);
            this.lookUpNhanVien.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lookUpNhanVien.Name = "lookUpNhanVien";
            this.lookUpNhanVien.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpNhanVien.Properties.DataSource = this.vDSNVBindingSource;
            this.lookUpNhanVien.Properties.DisplayMember = "HOTEN";
            this.lookUpNhanVien.Properties.ValueMember = "MANV";
            this.lookUpNhanVien.Size = new System.Drawing.Size(177, 20);
            this.lookUpNhanVien.TabIndex = 3;
            // 
            // vDSNVBindingSource
            // 
            this.vDSNVBindingSource.DataMember = "vDS_NV";
            this.vDSNVBindingSource.DataSource = this.nGANHANGDataSet;
            // 
            // nGANHANGDataSet
            // 
            this.nGANHANGDataSet.DataSetName = "NGANHANGDataSet";
            this.nGANHANGDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtConfirm
            // 
            this.txtConfirm.Location = new System.Drawing.Point(253, 181);
            this.txtConfirm.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtConfirm.Name = "txtConfirm";
            this.txtConfirm.Size = new System.Drawing.Size(178, 21);
            this.txtConfirm.TabIndex = 2;
            this.txtConfirm.UseSystemPasswordChar = true;
            // 
            // vDS_NVTableAdapter
            // 
            this.vDS_NVTableAdapter.ClearBeforeFill = true;
            // 
            // txtNhomQuyen
            // 
            this.txtNhomQuyen.Enabled = false;
            this.txtNhomQuyen.Location = new System.Drawing.Point(253, 261);
            this.txtNhomQuyen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNhomQuyen.Name = "txtNhomQuyen";
            this.txtNhomQuyen.Size = new System.Drawing.Size(178, 21);
            this.txtNhomQuyen.TabIndex = 2;
            // 
            // btnTaoLogin
            // 
            this.btnTaoLogin.Location = new System.Drawing.Point(253, 309);
            this.btnTaoLogin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTaoLogin.Name = "btnTaoLogin";
            this.btnTaoLogin.Size = new System.Drawing.Size(71, 44);
            this.btnTaoLogin.TabIndex = 4;
            this.btnTaoLogin.Text = "Tạo Login";
            this.btnTaoLogin.UseVisualStyleBackColor = true;
            this.btnTaoLogin.Click += new System.EventHandler(this.btnTaoLogin_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(358, 309);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(71, 44);
            this.btnThoat.TabIndex = 4;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // TaoAccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 421);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnTaoLogin);
            this.Controls.Add(this.lookUpNhanVien);
            this.Controls.Add(this.txtConfirm);
            this.Controls.Add(this.txtNhomQuyen);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtLoginName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbChiNhanh);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "TaoAccountForm";
            this.Text = "TaoAccountForm";
            this.Load += new System.EventHandler(this.TaoAccountForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lookUpNhanVien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vDSNVBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nGANHANGDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbChiNhanh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtLoginName;
        private System.Windows.Forms.TextBox txtPassword;
        private DevExpress.XtraEditors.LookUpEdit lookUpNhanVien;
        private System.Windows.Forms.TextBox txtConfirm;
        private NGANHANGDataSet nGANHANGDataSet;
        private System.Windows.Forms.BindingSource vDSNVBindingSource;
        private NGANHANGDataSetTableAdapters.vDS_NVTableAdapter vDS_NVTableAdapter;
        private System.Windows.Forms.TextBox txtNhomQuyen;
        private System.Windows.Forms.Button btnTaoLogin;
        private System.Windows.Forms.Button btnThoat;
    }
}