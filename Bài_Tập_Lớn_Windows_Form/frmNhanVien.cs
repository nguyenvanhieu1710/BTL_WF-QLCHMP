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
    public partial class frmNhanvien : Form
    {
        Database db =new Database();
        public frmNhanvien()
        {
            InitializeComponent();
        }

        private void frmNhanvien_Load(object sender, EventArgs e)
        {
            LoadDataToDataGridView();
            // Đặt kích thước cố định cho Form
            this.MinimumSize = new Size(828, 538);
            this.MaximumSize = new Size(828, 538);
        }
        private void LoadDataToDataGridView()
        {
            dgDSNhanVien.DataSource = db.GetDataTable("select * from NhanVien");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if(txtMaNhanVien.Text.Trim()=="" || txtTenNhanVien.Text.Trim()=="" || txtQueQuan.Text.Trim()=="" || txtSoDienThoai.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin");
                return;
            }
            int number;
            bool isInteger = int.TryParse(txtSoDienThoai.Text, out number);
            if (isInteger == false)
            {
                MessageBox.Show("Vui lòng nhập lại số điện thoại");
                return;
            }
            string them = "INSERT INTO NhanVien " +
                          "VALUES ('" + txtMaNhanVien.Text.Trim() + "', " +
                          "N'" + txtTenNhanVien.Text.Trim() + "', " +
                          "'" + txtQueQuan.Text.Trim() + "', " +
                          "'" + txtSoDienThoai.Text.Trim() + "')";

            DataTable dtcheck = db.GetDataTable("select * from NhanVien where MaNhanVien='" + txtMaNhanVien.Text.Trim() + "'");
            if (dtcheck.Rows.Count == 1)
            {
                MessageBox.Show("Mã Nhân Viên:" + txtMaNhanVien.Text.Trim() + " đã tồn tại trong CSDL. Vui lòng chọn mã khác.", "Mã nhân viên trùng", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {               
                db.ThucThiPKN(them);
                // Load lại CSDL
                LoadDataToDataGridView();
            }
        }

        private void btnSuaNhanVien_Click(object sender, EventArgs e)
        {
            if (txtMaNhanVien.Text.Trim() == "" || txtTenNhanVien.Text.Trim() == "" || txtQueQuan.Text.Trim() == "" || txtSoDienThoai.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập mã bạn muốn sửa và điền đủ thông tin bạn muốn sửa");
                return;
            }
            string sua = "UPDATE NhanVien SET TenKhachHang = '" + txtTenNhanVien.Text.Trim() + "', " +
                    "QueQuan = '" + txtQueQuan.Text.Trim() + "', " +
                    "SoDienThoai = '" + txtSoDienThoai.Text.Trim() + "' " +
                    "Where MaNhanVien = '" + txtMaNhanVien.Text.Trim() + "'";

            DataTable dtcheck = db.GetDataTable("select * from NhanVien where MaNhanVien='" + txtMaNhanVien.Text.Trim() + "'");
            if (dtcheck.Rows.Count == 1)
            {
                if (MessageBox.Show("Bạn chắc chắn muốn sửa chứ?", "Sửa", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    db.ThucThiPKN(sua);

                    LoadDataToDataGridView();

                    // Đặt lại trạng thái ban đầu cho các textbox
                    txtTenNhanVien.Text = "";
                    txtQueQuan.Text = "";
                    txtSoDienThoai.Text = "";

                    txtMaNhanVien.Focus();
                }
            }
            else { MessageBox.Show("Mã Nhân viên:" + txtMaNhanVien.Text.Trim() + " không tồn tại trong CSDL.", "Mã nhân viên không trùng", MessageBoxButtons.OK, MessageBoxIcon.Information); }

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnXoaNhanVien_Click(object sender, EventArgs e)
        {
            if (txtMaNhanVien.Text.Trim() == "" )
            {
                MessageBox.Show("Vui lòng nhập mã bạn muốn xóa");
                return;
            }
            string xoa = "DELETE FROM NhanVien WHERE MaNhanVien = '" + txtMaNhanVien.Text.Trim() + "' ";
            if (MessageBox.Show("Bạn chắc chắn muốn xóa chứ?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                db.ThucThiPKN(xoa);
                LoadDataToDataGridView();

                // Đặt lại trạng thái ban đầu cho các textbox
                txtMaNhanVien.Text = "";
                txtTenNhanVien.Text = "";
                txtQueQuan.Text = "";
                txtSoDienThoai.Text = "";

                txtMaNhanVien.Focus();
            }
        }

        private void btnTimKiemNhanVien_Click(object sender, EventArgs e)
        {
            if (txtMaNhanVien.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập mã bạn muốn tìm");
                return;
            }
            string tim = "SELECT * FROM NhanVien WHERE MaNhanVien = '" + txtMaNhanVien.Text.Trim() + "'";
            DataTable dtcheck = db.GetDataTable(tim);
            if (dtcheck.Rows.Count == 1)
            {
                DataTable dt = db.GetDataTable(tim);
                dgDSNhanVien.DataSource = dt;//load ra datagridview
            }
            else { MessageBox.Show("Mã Nhân Viên:" + txtMaNhanVien.Text.Trim() + " không tồn tại trong CSDL.", "Mã nhân viên không trùng", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }

        private void frmNhanvien_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaNhanVien.Text = "";
            txtTenNhanVien.Text = "";
            txtQueQuan.Text = "";
            txtSoDienThoai.Text = "";
        }
    }
}
