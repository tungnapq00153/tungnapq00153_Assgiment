﻿namespace tungnapq00153_QLBH
{
    partial class frmMain
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
            this.btnLoaiSP = new System.Windows.Forms.Button();
            this.btnDonHang = new System.Windows.Forms.Button();
            this.btnKhachHang = new System.Windows.Forms.Button();
            this.btnSanPham = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLoaiSP
            // 
            this.btnLoaiSP.Location = new System.Drawing.Point(29, 31);
            this.btnLoaiSP.Name = "btnLoaiSP";
            this.btnLoaiSP.Size = new System.Drawing.Size(126, 23);
            this.btnLoaiSP.TabIndex = 0;
            this.btnLoaiSP.Text = "Loại Sản Phẩm";
            this.btnLoaiSP.UseVisualStyleBackColor = true;
            this.btnLoaiSP.Click += new System.EventHandler(this.btnLoaiSP_Click);
            // 
            // btnDonHang
            // 
            this.btnDonHang.Location = new System.Drawing.Point(315, 183);
            this.btnDonHang.Name = "btnDonHang";
            this.btnDonHang.Size = new System.Drawing.Size(126, 23);
            this.btnDonHang.TabIndex = 1;
            this.btnDonHang.Text = "Quản lý đơn hàng";
            this.btnDonHang.UseVisualStyleBackColor = true;
            // 
            // btnKhachHang
            // 
            this.btnKhachHang.Location = new System.Drawing.Point(29, 183);
            this.btnKhachHang.Name = "btnKhachHang";
            this.btnKhachHang.Size = new System.Drawing.Size(126, 23);
            this.btnKhachHang.TabIndex = 2;
            this.btnKhachHang.Text = "Khách Hàng";
            this.btnKhachHang.UseVisualStyleBackColor = true;
            this.btnKhachHang.Click += new System.EventHandler(this.btnKhachHang_Click);
            // 
            // btnSanPham
            // 
            this.btnSanPham.Location = new System.Drawing.Point(315, 31);
            this.btnSanPham.Name = "btnSanPham";
            this.btnSanPham.Size = new System.Drawing.Size(126, 23);
            this.btnSanPham.TabIndex = 3;
            this.btnSanPham.Text = "Sản Phẩm";
            this.btnSanPham.UseVisualStyleBackColor = true;
            this.btnSanPham.Click += new System.EventHandler(this.btnSanPham_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 496);
            this.Controls.Add(this.btnSanPham);
            this.Controls.Add(this.btnKhachHang);
            this.Controls.Add(this.btnDonHang);
            this.Controls.Add(this.btnLoaiSP);
            this.Name = "frmMain";
            this.Text = "Ưng dụng quản lý bán hàng";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLoaiSP;
        private System.Windows.Forms.Button btnDonHang;
        private System.Windows.Forms.Button btnKhachHang;
        private System.Windows.Forms.Button btnSanPham;
    }
}

