using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bài_Tập_Lớn_Windows_Form
{
    public partial class frmThongKe : Form
    {
        Database db = new Database();
        public frmThongKe()
        {
            InitializeComponent();
        }
        void LoadDataGridViewView()
        {
            Ds_ThongKe.DataSource = db.GetDataTable("select * from ThongKe");
        }
        private void frmThongKe_Load(object sender, EventArgs e)
        {
            LoadDataGridViewView();
            
        }
        void TongSoLuongSanPhamDaBan()
        {
            string tongSoLuongSanPhamDaBan = "SELECT SUM(CAST(SoLuong AS int)) FROM ThongKe;";//cast để chuyển đổi kiểu dữ liệu từ nchar sang int            
            Ds_ThongKe.DataSource = db.GetDataTable(tongSoLuongSanPhamDaBan);
            // Thêm tên cho cột đầu tiên
            Ds_ThongKe.Columns[0].HeaderText = "Tổng Số Lượng Sản Phẩm Đã Bán";
        }
        void TongGiaTienSanPhamDaBan()
        {
            string tongGiaTienSanPhamDaBan = "SELECT SUM(CAST(GiaTien AS int)) FROM ThongKe;";//cast để chuyển đổi kiểu dữ liệu từ nchar sang int
            Ds_ThongKe.DataSource = db.GetDataTable(tongGiaTienSanPhamDaBan);
            // Thêm tên cho cột đầu tiên
            Ds_ThongKe.Columns[0].HeaderText = "Tổng Giá Tiền Sản Phẩm Đã Bán";
        }
        private void btnTong_Click(object sender, EventArgs e)
        {
            TongSoLuongSanPhamDaBan();
        }

        private void btnTongGT_Click(object sender, EventArgs e)
        {
            TongGiaTienSanPhamDaBan();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void frmThongKe_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnSapXepTang_Click(object sender, EventArgs e)
        {
            if(radMa.Checked)
            {
                string sapxep = "SELECT * FROM ThongKe ORDER BY MaSanPham ASC;";
                Ds_ThongKe.DataSource = db.GetDataTable(sapxep);
            }
            else if(radSoLuong.Checked)
            {
                string sapxep = "SELECT * FROM ThongKe ORDER BY SoLuong ASC;";
                Ds_ThongKe.DataSource = db.GetDataTable(sapxep);
            }
            else if (radGiaTien.Checked)
            {
                string sapxep = "SELECT * FROM ThongKe ORDER BY GiaTien ASC;";
                Ds_ThongKe.DataSource = db.GetDataTable(sapxep);
            }
        }

        private void btnSapXepGiam_Click(object sender, EventArgs e)
        {
            if (radMa.Checked)
            {
                string sapxep = "SELECT * FROM ThongKe ORDER BY MaSanPham DESC;";
                Ds_ThongKe.DataSource = db.GetDataTable(sapxep);
            }
            else if (radSoLuong.Checked)
            {
                string sapxep = "SELECT * FROM ThongKe ORDER BY SoLuong DESC;";
                Ds_ThongKe.DataSource = db.GetDataTable(sapxep);
            }
            else if (radGiaTien.Checked)
            {
                string sapxep = "SELECT * FROM ThongKe ORDER BY GiaTien DESC;";
                Ds_ThongKe.DataSource = db.GetDataTable(sapxep);
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            radMa.Checked = false;
            radSoLuong.Checked = false;
            radGiaTien.Checked = false;
            txtNgay.Text = "";
            txtThang.Text = "";
            txtNam.Text = "";
            LoadDataGridViewView();
        }

        private void txtNgay_TextChanged(object sender, EventArgs e)
        {
            if(txtNgay.Text.Length > 0)
            {
                txtThang.Enabled = false;
                txtNam.Enabled = false;
            }
            else
            {
                txtThang.Enabled = true;
                txtNam.Enabled=true;
            }
        }

        private void txtThang_TextChanged(object sender, EventArgs e)
        {
            if(txtThang.Text.Length > 0)
            {
                txtNgay.Enabled = false;
                txtNam.Enabled = false;
            }
            else
            {
                txtNgay.Enabled=true;
                txtNam.Enabled=true;
            }
        }

        private void txtNam_TextChanged(object sender, EventArgs e)
        {
            if(txtNam.Text.Length > 0)
            {
                txtThang.Enabled = false;
                txtNgay.Enabled=false;
            }
            else
            {
                txtNgay.Enabled=true;
                txtThang.Enabled=true;
            }
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            if(txtNgay.Text.Length>0)
            {
                string thongke = "SELECT SUM(CAST(GiaTien AS INT)) FROM ThongKe WHERE DAY(NgayBan) = " + txtNgay.Text.Trim() + " ";
                Ds_ThongKe.DataSource = db.GetDataTable(thongke);
                // Thêm tên cho cột đầu tiên
                Ds_ThongKe.Columns[0].HeaderText = "Tổng tiền trong ngày '"+txtNgay.Text.Trim()+"' ";
            }
            else if (txtThang.Text.Length > 0)
            {
                string thongke = "SELECT SUM(CAST(GiaTien AS INT)) FROM ThongKe WHERE Month(NgayBan) = '" + txtThang.Text.Trim() + "'";
                Ds_ThongKe.DataSource = db.GetDataTable(thongke);
                // Thêm tên cho cột đầu tiên
                Ds_ThongKe.Columns[0].HeaderText = "Tổng tiền trong tháng " + txtThang.Text.Trim() + " ";
            }
            else if (txtNam.Text.Length > 0)
            {
                string thongke = "SELECT SUM(CAST(GiaTien AS INT)) FROM ThongKe WHERE Year(NgayBan) = '" + txtNam.Text.Trim() + "'";
                Ds_ThongKe.DataSource = db.GetDataTable(thongke);
                // Thêm tên cho cột đầu tiên
                Ds_ThongKe.Columns[0].HeaderText = "Tổng tiền trong năm " + txtNam.Text.Trim() + " ";
            }
        }
    }
}
