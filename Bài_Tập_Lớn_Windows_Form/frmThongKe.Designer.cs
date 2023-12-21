namespace Bài_Tập_Lớn_Windows_Form
{
    partial class frmThongKe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThongKe));
            this.label2 = new System.Windows.Forms.Label();
            this.Ds_ThongKe = new System.Windows.Forms.DataGridView();
            this.btnTongsl = new System.Windows.Forms.Button();
            this.btnTongGT = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnSapXepTang = new System.Windows.Forms.Button();
            this.txtNgay = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.radMa = new System.Windows.Forms.RadioButton();
            this.radSoLuong = new System.Windows.Forms.RadioButton();
            this.radGiaTien = new System.Windows.Forms.RadioButton();
            this.btnSapXepGiam = new System.Windows.Forms.Button();
            this.txtThang = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtNam = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Ds_ThongKe)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(805, 43);
            this.label2.TabIndex = 0;
            this.label2.Text = "Danh sách sản phẩm đã bán";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Ds_ThongKe
            // 
            this.Ds_ThongKe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Ds_ThongKe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Ds_ThongKe.Location = new System.Drawing.Point(4, 46);
            this.Ds_ThongKe.Name = "Ds_ThongKe";
            this.Ds_ThongKe.RowHeadersWidth = 51;
            this.Ds_ThongKe.RowTemplate.Height = 24;
            this.Ds_ThongKe.Size = new System.Drawing.Size(801, 150);
            this.Ds_ThongKe.TabIndex = 2;
            // 
            // btnTongsl
            // 
            this.btnTongsl.Location = new System.Drawing.Point(604, 202);
            this.btnTongsl.Name = "btnTongsl";
            this.btnTongsl.Size = new System.Drawing.Size(189, 56);
            this.btnTongsl.TabIndex = 4;
            this.btnTongsl.Text = "Tổng số lượng đã bán";
            this.btnTongsl.UseVisualStyleBackColor = true;
            this.btnTongsl.Click += new System.EventHandler(this.btnTong_Click);
            // 
            // btnTongGT
            // 
            this.btnTongGT.Location = new System.Drawing.Point(604, 275);
            this.btnTongGT.Name = "btnTongGT";
            this.btnTongGT.Size = new System.Drawing.Size(189, 65);
            this.btnTongGT.TabIndex = 5;
            this.btnTongGT.Text = "Tổng giá tiền đã bán";
            this.btnTongGT.UseVisualStyleBackColor = true;
            this.btnTongGT.Click += new System.EventHandler(this.btnTongGT_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Image = ((System.Drawing.Image)(resources.GetObject("btnLoad.Image")));
            this.btnLoad.Location = new System.Drawing.Point(455, 281);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(64, 59);
            this.btnLoad.TabIndex = 11;
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnHome
            // 
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.Location = new System.Drawing.Point(534, 281);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(64, 59);
            this.btnHome.TabIndex = 12;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnSapXepTang
            // 
            this.btnSapXepTang.Location = new System.Drawing.Point(304, 210);
            this.btnSapXepTang.Name = "btnSapXepTang";
            this.btnSapXepTang.Size = new System.Drawing.Size(145, 48);
            this.btnSapXepTang.TabIndex = 9;
            this.btnSapXepTang.Text = "Sắp xếp tăng";
            this.btnSapXepTang.UseVisualStyleBackColor = true;
            this.btnSapXepTang.Click += new System.EventHandler(this.btnSapXepTang_Click);
            // 
            // txtNgay
            // 
            this.txtNgay.BorderRadius = 15;
            this.txtNgay.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNgay.DefaultText = "";
            this.txtNgay.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNgay.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNgay.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNgay.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNgay.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNgay.Font = new System.Drawing.Font("Cooper Black", 12F);
            this.txtNgay.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNgay.Location = new System.Drawing.Point(27, 285);
            this.txtNgay.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtNgay.Name = "txtNgay";
            this.txtNgay.PasswordChar = '\0';
            this.txtNgay.PlaceholderText = "Ngày";
            this.txtNgay.SelectedText = "";
            this.txtNgay.Size = new System.Drawing.Size(90, 55);
            this.txtNgay.TabIndex = 0;
            this.txtNgay.TextChanged += new System.EventHandler(this.txtNgay_TextChanged);
            // 
            // btnThongKe
            // 
            this.btnThongKe.Location = new System.Drawing.Point(325, 292);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(114, 48);
            this.btnThongKe.TabIndex = 3;
            this.btnThongKe.Text = "Thống Kê";
            this.btnThongKe.UseVisualStyleBackColor = true;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // radMa
            // 
            this.radMa.AutoSize = true;
            this.radMa.Location = new System.Drawing.Point(12, 221);
            this.radMa.Name = "radMa";
            this.radMa.Size = new System.Drawing.Size(60, 27);
            this.radMa.TabIndex = 6;
            this.radMa.TabStop = true;
            this.radMa.Text = "Mã";
            this.radMa.UseVisualStyleBackColor = true;
            // 
            // radSoLuong
            // 
            this.radSoLuong.AutoSize = true;
            this.radSoLuong.Location = new System.Drawing.Point(78, 221);
            this.radSoLuong.Name = "radSoLuong";
            this.radSoLuong.Size = new System.Drawing.Size(107, 27);
            this.radSoLuong.TabIndex = 7;
            this.radSoLuong.TabStop = true;
            this.radSoLuong.Text = "Số lượng";
            this.radSoLuong.UseVisualStyleBackColor = true;
            // 
            // radGiaTien
            // 
            this.radGiaTien.AutoSize = true;
            this.radGiaTien.Location = new System.Drawing.Point(191, 221);
            this.radGiaTien.Name = "radGiaTien";
            this.radGiaTien.Size = new System.Drawing.Size(107, 27);
            this.radGiaTien.TabIndex = 8;
            this.radGiaTien.TabStop = true;
            this.radGiaTien.Text = "Giá tiền";
            this.radGiaTien.UseVisualStyleBackColor = true;
            // 
            // btnSapXepGiam
            // 
            this.btnSapXepGiam.Location = new System.Drawing.Point(455, 210);
            this.btnSapXepGiam.Name = "btnSapXepGiam";
            this.btnSapXepGiam.Size = new System.Drawing.Size(143, 48);
            this.btnSapXepGiam.TabIndex = 10;
            this.btnSapXepGiam.Text = "Sắp xếp giảm";
            this.btnSapXepGiam.UseVisualStyleBackColor = true;
            this.btnSapXepGiam.Click += new System.EventHandler(this.btnSapXepGiam_Click);
            // 
            // txtThang
            // 
            this.txtThang.BorderRadius = 15;
            this.txtThang.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtThang.DefaultText = "";
            this.txtThang.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtThang.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtThang.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtThang.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtThang.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtThang.Font = new System.Drawing.Font("Cooper Black", 12F);
            this.txtThang.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtThang.Location = new System.Drawing.Point(127, 285);
            this.txtThang.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtThang.Name = "txtThang";
            this.txtThang.PasswordChar = '\0';
            this.txtThang.PlaceholderText = "Tháng";
            this.txtThang.SelectedText = "";
            this.txtThang.Size = new System.Drawing.Size(90, 55);
            this.txtThang.TabIndex = 1;
            this.txtThang.TextChanged += new System.EventHandler(this.txtThang_TextChanged);
            // 
            // txtNam
            // 
            this.txtNam.BorderRadius = 15;
            this.txtNam.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNam.DefaultText = "";
            this.txtNam.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNam.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNam.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNam.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNam.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNam.Font = new System.Drawing.Font("Cooper Black", 12F);
            this.txtNam.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNam.Location = new System.Drawing.Point(227, 285);
            this.txtNam.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtNam.Name = "txtNam";
            this.txtNam.PasswordChar = '\0';
            this.txtNam.PlaceholderText = "Năm";
            this.txtNam.SelectedText = "";
            this.txtNam.Size = new System.Drawing.Size(90, 55);
            this.txtNam.TabIndex = 2;
            this.txtNam.TextChanged += new System.EventHandler(this.txtNam_TextChanged);
            // 
            // frmThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 385);
            this.Controls.Add(this.radGiaTien);
            this.Controls.Add(this.radSoLuong);
            this.Controls.Add(this.radMa);
            this.Controls.Add(this.btnThongKe);
            this.Controls.Add(this.txtNam);
            this.Controls.Add(this.txtThang);
            this.Controls.Add(this.txtNgay);
            this.Controls.Add(this.btnSapXepGiam);
            this.Controls.Add(this.btnSapXepTang);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnTongGT);
            this.Controls.Add(this.btnTongsl);
            this.Controls.Add(this.Ds_ThongKe);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "frmThongKe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thống kê";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmThongKe_FormClosed);
            this.Load += new System.EventHandler(this.frmThongKe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Ds_ThongKe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView Ds_ThongKe;
        private System.Windows.Forms.Button btnTongsl;
        private System.Windows.Forms.Button btnTongGT;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnSapXepTang;
        private Guna.UI2.WinForms.Guna2TextBox txtNgay;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.RadioButton radMa;
        private System.Windows.Forms.RadioButton radSoLuong;
        private System.Windows.Forms.RadioButton radGiaTien;
        private System.Windows.Forms.Button btnSapXepGiam;
        private Guna.UI2.WinForms.Guna2TextBox txtThang;
        private Guna.UI2.WinForms.Guna2TextBox txtNam;
    }
}