namespace Bài_Tập_Lớn_Windows_Form
{
    partial class frmTrangchu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTrangchu));
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.đăngNhậpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhânViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kháchHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ThongKetoolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.quanLySanPhamtoolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.profileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnListMenu = new System.Windows.Forms.Button();
            this.btnDonHang = new System.Windows.Forms.Button();
            this.btnCoin = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnSanpham = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.btnMaGiamGia = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cooper Black", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 32);
            this.label2.TabIndex = 0;
            this.label2.Text = "Hiếu Shop";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đăngNhậpToolStripMenuItem,
            this.nhânViênToolStripMenuItem,
            this.kháchHàngToolStripMenuItem,
            this.ThongKetoolStripMenuItem1,
            this.quanLySanPhamtoolStripMenuItem1,
            this.profileToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(820, 32);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.Visible = false;
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // đăngNhậpToolStripMenuItem
            // 
            this.đăngNhậpToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("đăngNhậpToolStripMenuItem.Image")));
            this.đăngNhậpToolStripMenuItem.Name = "đăngNhậpToolStripMenuItem";
            this.đăngNhậpToolStripMenuItem.Size = new System.Drawing.Size(141, 28);
            this.đăngNhậpToolStripMenuItem.Text = "Đăng nhập";
            this.đăngNhậpToolStripMenuItem.Click += new System.EventHandler(this.đăngNhậpToolStripMenuItem_Click);
            // 
            // nhânViênToolStripMenuItem
            // 
            this.nhânViênToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("nhânViênToolStripMenuItem.Image")));
            this.nhânViênToolStripMenuItem.Name = "nhânViênToolStripMenuItem";
            this.nhânViênToolStripMenuItem.Size = new System.Drawing.Size(133, 28);
            this.nhânViênToolStripMenuItem.Text = "Nhân viên";
            this.nhânViênToolStripMenuItem.Click += new System.EventHandler(this.nhânViênToolStripMenuItem_Click);
            // 
            // kháchHàngToolStripMenuItem
            // 
            this.kháchHàngToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("kháchHàngToolStripMenuItem.Image")));
            this.kháchHàngToolStripMenuItem.Name = "kháchHàngToolStripMenuItem";
            this.kháchHàngToolStripMenuItem.Size = new System.Drawing.Size(148, 28);
            this.kháchHàngToolStripMenuItem.Text = "Khách hàng";
            this.kháchHàngToolStripMenuItem.Click += new System.EventHandler(this.kháchHàngToolStripMenuItem_Click);
            // 
            // ThongKetoolStripMenuItem1
            // 
            this.ThongKetoolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("ThongKetoolStripMenuItem1.Image")));
            this.ThongKetoolStripMenuItem1.Name = "ThongKetoolStripMenuItem1";
            this.ThongKetoolStripMenuItem1.Size = new System.Drawing.Size(127, 28);
            this.ThongKetoolStripMenuItem1.Text = "Thống kê";
            this.ThongKetoolStripMenuItem1.Click += new System.EventHandler(this.ThongKetoolStripMenuItem1_Click);
            // 
            // quanLySanPhamtoolStripMenuItem1
            // 
            this.quanLySanPhamtoolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("quanLySanPhamtoolStripMenuItem1.Image")));
            this.quanLySanPhamtoolStripMenuItem1.Name = "quanLySanPhamtoolStripMenuItem1";
            this.quanLySanPhamtoolStripMenuItem1.Size = new System.Drawing.Size(163, 28);
            this.quanLySanPhamtoolStripMenuItem1.Text = "QL Sản phẩm";
            this.quanLySanPhamtoolStripMenuItem1.Click += new System.EventHandler(this.quanLySanPhamtoolStripMenuItem1_Click);
            // 
            // profileToolStripMenuItem
            // 
            this.profileToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("profileToolStripMenuItem.Image")));
            this.profileToolStripMenuItem.Name = "profileToolStripMenuItem";
            this.profileToolStripMenuItem.Size = new System.Drawing.Size(100, 28);
            this.profileToolStripMenuItem.Text = "Profile";
            this.profileToolStripMenuItem.Click += new System.EventHandler(this.profileToolStripMenuItem_Click);
            // 
            // btnListMenu
            // 
            this.btnListMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnListMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnListMenu.Image")));
            this.btnListMenu.Location = new System.Drawing.Point(838, 0);
            this.btnListMenu.Name = "btnListMenu";
            this.btnListMenu.Size = new System.Drawing.Size(57, 42);
            this.btnListMenu.TabIndex = 4;
            this.btnListMenu.UseVisualStyleBackColor = true;
            this.btnListMenu.Click += new System.EventHandler(this.btnListMenu_Click);
            // 
            // btnDonHang
            // 
            this.btnDonHang.FlatAppearance.BorderColor = System.Drawing.Color.BlueViolet;
            this.btnDonHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDonHang.Image = ((System.Drawing.Image)(resources.GetObject("btnDonHang.Image")));
            this.btnDonHang.Location = new System.Drawing.Point(18, 182);
            this.btnDonHang.Name = "btnDonHang";
            this.btnDonHang.Size = new System.Drawing.Size(132, 92);
            this.btnDonHang.TabIndex = 1;
            this.btnDonHang.UseVisualStyleBackColor = true;
            this.btnDonHang.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnCoin
            // 
            this.btnCoin.BackColor = System.Drawing.Color.White;
            this.btnCoin.FlatAppearance.BorderColor = System.Drawing.Color.BlueViolet;
            this.btnCoin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCoin.Image = ((System.Drawing.Image)(resources.GetObject("btnCoin.Image")));
            this.btnCoin.Location = new System.Drawing.Point(18, 280);
            this.btnCoin.Name = "btnCoin";
            this.btnCoin.Size = new System.Drawing.Size(132, 93);
            this.btnCoin.TabIndex = 2;
            this.btnCoin.UseVisualStyleBackColor = false;
            this.btnCoin.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.FlatAppearance.BorderColor = System.Drawing.Color.BlueViolet;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.Image")));
            this.btnThoat.Location = new System.Drawing.Point(18, 477);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(132, 86);
            this.btnThoat.TabIndex = 5;
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.button2_Click_2);
            // 
            // btnSanpham
            // 
            this.btnSanpham.FlatAppearance.BorderColor = System.Drawing.Color.BlueViolet;
            this.btnSanpham.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSanpham.Image = ((System.Drawing.Image)(resources.GetObject("btnSanpham.Image")));
            this.btnSanpham.Location = new System.Drawing.Point(18, 89);
            this.btnSanpham.Name = "btnSanpham";
            this.btnSanpham.Size = new System.Drawing.Size(132, 82);
            this.btnSanpham.TabIndex = 0;
            this.btnSanpham.UseVisualStyleBackColor = true;
            this.btnSanpham.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(179, 43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(716, 522);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 15;
            this.guna2Elipse1.TargetControl = this;
            // 
            // btnMaGiamGia
            // 
            this.btnMaGiamGia.FlatAppearance.BorderColor = System.Drawing.Color.BlueViolet;
            this.btnMaGiamGia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaGiamGia.Image = ((System.Drawing.Image)(resources.GetObject("btnMaGiamGia.Image")));
            this.btnMaGiamGia.Location = new System.Drawing.Point(18, 379);
            this.btnMaGiamGia.Name = "btnMaGiamGia";
            this.btnMaGiamGia.Size = new System.Drawing.Size(132, 81);
            this.btnMaGiamGia.TabIndex = 3;
            this.btnMaGiamGia.UseVisualStyleBackColor = true;
            this.btnMaGiamGia.Click += new System.EventHandler(this.btnMaGiamGia_Click);
            // 
            // frmTrangchu
            // 
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(895, 565);
            this.Controls.Add(this.btnMaGiamGia);
            this.Controls.Add(this.btnListMenu);
            this.Controls.Add(this.btnDonHang);
            this.Controls.Add(this.btnCoin);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnSanpham);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmTrangchu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trang chủ";
            this.Load += new System.EventHandler(this.frmTrangchu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSanpham;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnCoin;
        private System.Windows.Forms.Button btnDonHang;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button btnListMenu;
        private System.Windows.Forms.ToolStripMenuItem nhânViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kháchHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngNhậpToolStripMenuItem;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.ToolStripMenuItem profileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ThongKetoolStripMenuItem1;
        private System.Windows.Forms.Button btnMaGiamGia;
        private System.Windows.Forms.ToolStripMenuItem quanLySanPhamtoolStripMenuItem1;
    }
}