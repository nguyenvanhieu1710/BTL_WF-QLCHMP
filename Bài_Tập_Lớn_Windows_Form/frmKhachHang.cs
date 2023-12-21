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
    public partial class frmKhachHang : Form
    {
        Database db = new Database();
        public frmKhachHang()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            LoadDataToDataGridView();
            // Đặt kích thước cố định cho Form
            this.MinimumSize = new Size(768, 530);
            this.MaximumSize = new Size(768, 530);
        }
        private void LoadDataToDataGridView()//Load dữ liệu lên DataGridView
        {
            dgDS_KH.DataSource = db.GetDataTable("select * from KhachHang");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (txtMaKhachHang.Text.Trim() == ""
                || txtTenKhachHang.Text.Trim() == ""
                || txtNgaySinh.Text.Trim() == ""
                || txtSoDienThoai.Text.Trim() == ""
                || txtEmail.Text.Trim() == ""
                || radNam.Checked == false && radNu.Checked == false
                || txtAnh.Text.Trim()=="")
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin");
                return;
            }
            int number;
            bool isInteger = int.TryParse(txtSoDienThoai.Text, out number);
            if (isInteger==false)
            {
                MessageBox.Show("Vui lòng nhập lại số điện thoại");
                return;
            }
            DataTable dtcheck = db.GetDataTable("select * from KhachHang where MaKhachHang='" + txtMaKhachHang.Text.Trim() + "'");
            if (dtcheck.Rows.Count > 0)
            {
                MessageBox.Show("Mã Khách Hàng:" + txtMaKhachHang.Text.Trim() + " đã tồn tại trong CSDL. Vui lòng chọn mã khác.", "Mã khách hàng trùng", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (radNam.Checked)
                {
                    string them1 = "Insert into KhachHang values ('" + txtMaKhachHang.Text.Trim() + "',N'" + txtTenKhachHang.Text.Trim() + "'," +
                    " N'" + txtNgaySinh.Text.Trim() + "','" + txtSoDienThoai.Text.Trim() + "',N'" + txtEmail.Text.Trim() + "', N'Nam', N'" + txtAnh.Text.Trim() + "')";
                    db.ThucThiPKN(them1);
                    MessageBox.Show("Bạn đã thêm thành công");
                }
                else if (radNu.Checked)
                {
                    string them2 = "Insert into KhachHang values ('" + txtMaKhachHang.Text.Trim() + "',N'" + txtTenKhachHang.Text.Trim() + "'," +
                    " N'" + txtNgaySinh.Text.Trim() + "','" + txtSoDienThoai.Text.Trim() + "',N'" + txtEmail.Text.Trim() + "', N'Nữ', N'" + txtAnh.Text.Trim() + "')";
                    db.ThucThiPKN(them2);
                    MessageBox.Show("Bạn đã thêm thành công");
                }
                LoadDataToDataGridView();
            }
            
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaKhachHang.Text.Trim() == ""
                || txtTenKhachHang.Text.Trim() == ""
                || txtNgaySinh.Text.Trim() == ""
                || txtSoDienThoai.Text.Trim() == ""
                || txtEmail.Text.Trim() == ""
                || radNam.Checked == false && radNu.Checked == false
                || txtAnh.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin");
                return;
            }
            DataTable dtcheck = db.GetDataTable("select * from KhachHang where MaKhachHang='" + txtMaKhachHang.Text.Trim() + "'");
            if(dtcheck.Rows.Count >0)
            {
                if (MessageBox.Show("Bạn chắc chắn muốn sửa chứ?", "Sửa", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    if (radNam.Checked)
                    {
                        string update1 = "UPDATE KhachHang SET " +
                                         "TenKhachHang = N'" + txtTenKhachHang.Text.Trim() + "', " +
                                         "NgaySinh = '" + txtNgaySinh.Text.Trim() + "', " +
                                         "SoDienThoai = '" + txtSoDienThoai.Text.Trim() + "', " +
                                         "Email = N'" + txtEmail.Text.Trim() + "', " +
                                         "GioiTinh = N'Nam' where MaKhachHang = '" + txtMaKhachHang.Text.Trim() + "' ";
                        db.ThucThiPKN(update1);
                    }
                    else if (radNu.Checked)
                    {
                        string update2 = "UPDATE KhachHang SET " +
                                         "TenKhachHang = N'" + txtTenKhachHang.Text.Trim() + "', " +
                                         "NgaySinh = '" + txtNgaySinh.Text.Trim() + "', " +
                                         "SoDienThoai = '" + txtSoDienThoai.Text.Trim() + "', " +
                                         "Email = N'" + txtEmail.Text.Trim() + "', " +
                                         "GioiTinh = N'Nữ' where MaKhachHang = '" + txtMaKhachHang.Text.Trim() + "' ";
                        db.ThucThiPKN(update2);
                    }
                    LoadDataToDataGridView();

                    // Đặt lại trạng thái ban đầu cho các textbox
                    txtMaKhachHang.Text = "";
                    txtTenKhachHang.Text = "";
                    txtNgaySinh.Text = "";
                    txtSoDienThoai.Text = "";
                    txtEmail.Text = "";
                    radNam.Checked = false;
                    radNu.Checked = false;
                    txtAnh.Text = "";
                    txtMaKhachHang.Focus();
                }               
            }
            else { MessageBox.Show("Mã Khách Hàng:" + txtMaKhachHang.Text.Trim() + " không tồn tại trong CSDL.", "Mã khách hàng không trùng", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaKhachHang.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập mã muốn xóa");
                return;
            }
            if (MessageBox.Show("Bạn chắc chắn muốn xóa chứ?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                string xoa = "DELETE FROM KhachHang WHERE MaKhachHang = '"+txtMaKhachHang.Text.Trim()+"' ";
                db.ThucThiPKN(xoa);
                LoadDataToDataGridView();

                // Đặt lại trạng thái ban đầu cho các textbox
                txtMaKhachHang.Text = "";
                txtTenKhachHang.Text = "";
                txtNgaySinh.Text = "";
                txtSoDienThoai.Text = "";
                txtEmail.Text = "";
                radNam.Checked = false;
                radNu.Checked = false;
                txtMaKhachHang.Focus();
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (txtMaKhachHang.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập mã muốn tìm");
                return;
            }
            string tim = "SELECT * FROM KhachHang WHERE MaKhachHang = '" + txtMaKhachHang.Text.Trim() + "'";
            DataTable dtcheck = db.GetDataTable(tim);
            if (dtcheck.Rows.Count > 0)
            {
                DataTable dt = db.GetDataTable(tim);
                dgDS_KH.DataSource = dt;//hiện ra datagridview
            }
            else { MessageBox.Show("Mã Khách Hàng:" + txtMaKhachHang.Text.Trim() + " không tồn tại trong CSDL.", "Mã khách hàng không trùng", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void frmKhachHang_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaKhachHang.Text = "";
            txtTenKhachHang.Text = "";
            txtEmail.Text = "";
            txtNgaySinh.Text = "";
            txtSoDienThoai.Text = "";
            radNam.Checked = false;
            radNu.Checked = false;
        }
    }
}
