
namespace NGANHANG
{
    partial class Frpt_KhachHangTheoHoTen
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
            this.cmbChinhNhanh = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPreview = new System.Windows.Forms.Button();
            this.Thoát = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbChinhNhanh
            // 
            this.cmbChinhNhanh.FormattingEnabled = true;
            this.cmbChinhNhanh.Location = new System.Drawing.Point(96, 27);
            this.cmbChinhNhanh.Name = "cmbChinhNhanh";
            this.cmbChinhNhanh.Size = new System.Drawing.Size(270, 23);
            this.cmbChinhNhanh.TabIndex = 3;
            this.cmbChinhNhanh.SelectedIndexChanged += new System.EventHandler(this.cmbChinhNhanh_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Chi nhánh";
            // 
            // btnPreview
            // 
            this.btnPreview.Location = new System.Drawing.Point(417, 26);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(75, 23);
            this.btnPreview.TabIndex = 4;
            this.btnPreview.Text = "Preview";
            this.btnPreview.UseVisualStyleBackColor = true;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // Thoát
            // 
            this.Thoát.Location = new System.Drawing.Point(513, 26);
            this.Thoát.Name = "Thoát";
            this.Thoát.Size = new System.Drawing.Size(75, 23);
            this.Thoát.TabIndex = 5;
            this.Thoát.Text = "Thoát";
            this.Thoát.UseVisualStyleBackColor = true;
            this.Thoát.Click += new System.EventHandler(this.Thoát_Click);
            // 
            // Frpt_KhachHangTheoHoTen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 79);
            this.Controls.Add(this.Thoát);
            this.Controls.Add(this.btnPreview);
            this.Controls.Add(this.cmbChinhNhanh);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Frpt_KhachHangTheoHoTen";
            this.Text = "Frpt_KhachHangTheoHoTen";
            this.Load += new System.EventHandler(this.Frpt_KhachHangTheoHoTen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbChinhNhanh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.Button Thoát;
    }
}