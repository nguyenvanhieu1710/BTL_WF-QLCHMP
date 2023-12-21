using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bài_Tập_Lớn_Windows_Form
{
    public partial class frmQuanLySanPham : Form
    {
        Database db = new Database();
        public frmQuanLySanPham()
        {
            InitializeComponent();
        }
        private void LoadDataToDataGridView()
        {
            dgDS_SanPham.DataSource = db.GetDataTable("select * from SanPham");
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtThem_Click(object sender, EventArgs e)
        {
            if(txtMaSanPham.Text.Trim()=="" || txtTenSanPham.Text.Trim()=="" || txtXuatXu.Text.Trim()==""
                || txtLoaiSanPham.Text.Trim()=="" || txtSoLuong.Text.Trim()=="" || txtGiaTien.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin");
                return;
            }
            DataTable dtcheck = db.GetDataTable("select * from SanPham where MaSanPham='" + txtMaSanPham.Text.Trim() + "'");
            if (dtcheck.Rows.Count >0)
            {
                MessageBox.Show("Mã Sản Phẩm:" + txtMaSanPham.Text.Trim() + " đã tồn tại trong CSDL. Vui lòng chọn mã khác.", "Mã sản phẩm trùng", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string them = "insert into SanPham values ('" + txtMaSanPham.Text.Trim() + "'" +
                    ",N'" + txtTenSanPham.Text.Trim() + "',N'" + txtXuatXu.Text.Trim() + "'," +
                    "N'" + txtLoaiSanPham.Text.Trim() + "'" +", '"+txtSoLuong.Text.Trim()+"'" +
                    ",'"+txtGiaTien.Text.Trim()+"' )";

                db.ThucThiPKN(them);
                MessageBox.Show("Đã thêm thành công");
                LoadDataToDataGridView();
            }
        }

        private void frmQLSP_Load(object sender, EventArgs e)
        {
            LoadDataToDataGridView();
            // Đặt kích thước cố định cho Form
            this.MinimumSize = new Size(860, 559);
            this.MaximumSize = new Size(860, 559);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaSanPham.Text.Trim() == "" || txtTenSanPham.Text.Trim() == "" || txtXuatXu.Text.Trim() == ""
                || txtLoaiSanPham.Text.Trim() == "" || txtSoLuong.Text.Trim() == "" || txtGiaTien.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập mã bạn muốn sửa và điền đủ thông tin bạn muốn sửa");
                return;
            }
            string sua = "UPDATE SanPham SET TenSanPham = '" + txtTenSanPham.Text.Trim() + "', " +
             "XuatXu = '" + txtXuatXu.Text.Trim() + "', " +
             "LoaiSanPham = '" + txtLoaiSanPham.Text.Trim() + "', " +
             "SoLuong = '"+txtSoLuong.Text.Trim()+"',"+
             "GiaTien = '"+txtGiaTien.Text.Trim()+"' "+
             "Where MaSanPham = '" + txtMaSanPham.Text.Trim() + "'";
            db.ThucThiPKN(sua);

            LoadDataToDataGridView();

            // Đặt lại trạng thái ban đầu cho các textbox
            txtTenSanPham.Text = "";
            txtXuatXu.Text = "";
            txtLoaiSanPham.Text = "";
            txtSoLuong.Text = "";
            txtGiaTien.Text = "";

            txtMaSanPham.Focus();
           
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaSanPham.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập mã bạn muốn xóa.");
                return;
            }
            else
            {
                if (MessageBox.Show("Bạn chắc chắn muốn xóa chứ?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    string xoa = "DELETE FROM SanPham WHERE MaSanPham = '" + txtMaSanPham.Text.Trim() + "' ";
                    db.ThucThiPKN(xoa);
                    LoadDataToDataGridView();

                    // Đặt lại trạng thái ban đầu cho các textbox
                    txtTenSanPham.Text = "";
                    txtXuatXu.Text = "";
                    txtLoaiSanPham.Text = "";
                    txtSoLuong.Text = "";
                    txtGiaTien.Text = "";

                    txtMaSanPham.Focus();
                }
            }            
            
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (txtMaSanPham.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập mã bạn muốn tìm.");
                return;
            }
            string tim = "select * from SanPham where MaSanPham ='"+txtMaSanPham.Text.Trim()+"'";
            DataTable dtcheck = db.GetDataTable(tim);
            if(dtcheck.Rows.Count > 0)
            {
                DataTable dt = db.GetDataTable(tim);
                dgDS_SanPham.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Mã Sản Phẩm:" + txtMaSanPham.Text.Trim() + " không tồn tại trong CSDL.", "Mã sản phẩm không trùng", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            // Đặt lại trạng thái ban đầu cho các textbox
            txtMaSanPham.Text = "";
            txtTenSanPham.Text = "";
            txtXuatXu.Text = "";
            txtLoaiSanPham.Text = "";
            txtSoLuong.Text = "";
            txtGiaTien.Text = "";

            txtMaSanPham.Focus();
        }

        private void frmQLSP_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void txtSoLuong_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
