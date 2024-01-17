using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bài_Tập_Lớn_Windows_Form
{
    public partial class frmDonhang : Form
    {
        Database db = new Database();
        public frmDonhang()
        {
            InitializeComponent();
        }
        public void LoadDataToDataGridView()
        {
            string load = "select * from DonHang";
            dgDonHang.DataSource = db.GetDataTable(load);
        }

        private void frmDonhang_Load(object sender, EventArgs e)
        {
            LoadDataToDataGridView();
            // Đặt kích thước cố định cho Form
            this.MinimumSize = new Size(847, 422);
            this.MaximumSize = new Size(847, 422);
            labelNgayBan.Text = DateTime.Now.ToString("dd-MM-yyyy");
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        public int tong_tien;
        public int phi_van_chuyen;
        public int tien_duoc_khi_giam_gia;
        public int tong_tien_ban_dau_khi_chua_giam_gia;
        public void TinhTongTien()//Tổng tiền ban đầu khi chưa thêm mã giảm giá
        {
            if (dgDonHang.SelectedRows.Count > 0)// Kiểm tra xem có dòng nào được chọn không
            {
                int columnIndex = 5; // Chỉ số cột giá tiền 
                int sum = 0;
                foreach (DataGridViewRow selectedRow in dgDonHang.SelectedRows)
                {
                    // Lấy giá trị từ cột được chỉ định của dòng được chọn
                    int value = Convert.ToInt32(selectedRow.Cells[columnIndex].Value);
                    sum += value;
                }
                tong_tien = sum;//tổng cột giá tiền
                phi_van_chuyen = Convert.ToInt32(txtPhiVanChuyen.Text.Trim());
                tong_tien = tong_tien + phi_van_chuyen;
                tong_tien_ban_dau_khi_chua_giam_gia = tong_tien;//tiền khi chưa áp mã giảm giá
                txtTongTien.Text = tong_tien.ToString();
            }
            else txtTongTien.Clear();                      
        }
        public string data;//Mã khách hàng được truyền từ form trang chủ vào
        public void SetData(string data1)
        {
            data = data1;
        }
        public void HoaDon()
        {
            // Kiểm tra xem có dòng nào được chọn không
            if (dgDonHang.SelectedRows.Count == 0)
            {
                MessageBox.Show("Không có sản phẩm nào được chọn");
                return;
            }
            // Duyệt qua các hàng đã chọn trong DataGridView
            foreach (DataGridViewRow row in dgDonHang.SelectedRows)
            {
                // Lấy các giá trị trong hàng
                string maSanPham = row.Cells["MaSanPham"].Value.ToString().Trim();
                string TenSanPham = row.Cells["TenSanPham"].Value.ToString().Trim();
                string XuatXu = row.Cells["XuatXu"].Value.ToString().Trim();
                string LoaiSanPham = row.Cells["LoaiSanPham"].Value.ToString().Trim();
                string SoLuong = row.Cells["SoLuong"].Value.ToString().Trim();
                string GiaTien = row.Cells["GiaTien"].Value.ToString().Trim();
                labelNgayBan.Text = DateTime.Now.ToString("yyyy-MM-dd");
                string NgayBan = labelNgayBan.Text.Trim();
                string DiaChi = txtDiaChi.Text.Trim();
                string MaKhachhang = data;

                string them = "Insert into HoaDon values('" + maSanPham + "', N'" + TenSanPham + "', N'" + XuatXu + "', N'" + LoaiSanPham + "', '" + SoLuong + "', '" + GiaTien + "', '" + NgayBan + "', N'"+DiaChi+"', '"+MaKhachhang+"')";

                DataTable dtcheck = db.GetDataTable("select * from HoaDon where MaSanPham = '" + maSanPham + "'");
                if (dtcheck.Rows.Count > 0)
                {
                    MessageBox.Show("Sản phẩm: " + maSanPham.Trim() + " đã có trong hóa đơn.");
                }
                else
                {
                    db.ThucThiPKN(them);
                    //MessageBox.Show("Đã thêm vào hóa đơn thành công");
                }
            }
        }
        public void ThemThongKe()
        {
            // Kiểm tra xem có dòng nào được chọn không
            if (dgDonHang.SelectedRows.Count == 0)
            {
                MessageBox.Show("Không có sản phẩm nào được chọn");
                return;
            }

            // Duyệt qua các hàng đã chọn trong DataGridView
            foreach (DataGridViewRow row in dgDonHang.SelectedRows)
            {
                // Lấy các giá trị trong hàng
                string maSanPham = row.Cells["MaSanPham"].Value.ToString().Trim();
                string TenSanPham = row.Cells["TenSanPham"].Value.ToString().Trim();
                string XuatXu = row.Cells["XuatXu"].Value.ToString().Trim();
                string LoaiSanPham = row.Cells["LoaiSanPham"].Value.ToString().Trim();
                string SoLuong = row.Cells["SoLuong"].Value.ToString().Trim();
                string GiaTien = row.Cells["GiaTien"].Value.ToString().Trim();
                labelNgayBan.Text = DateTime.Now.ToString("yyyy-MM-dd");
                string NgayBan = labelNgayBan.Text.Trim();

                string them = "Insert into ThongKe values('" + maSanPham + "', N'" + TenSanPham + "', N'" + XuatXu + "', N'" + LoaiSanPham + "', '" + SoLuong + "', '" + GiaTien + "', '"+NgayBan+"')";

                DataTable dtcheck = db.GetDataTable("select * from ThongKe where MaSanPham = '" + maSanPham + "'");
                if (dtcheck.Rows.Count > 0)
                {
                    MessageBox.Show("Sản phẩm: " + maSanPham + " đã có trong Thống kê.");
                }
                else
                {
                    db.ThucThiPKN(them);
                    //MessageBox.Show("Đã thêm vào thống kê thành công");
                }
            }
        }
        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (txtDiaChi.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin");
                return;
            }            
            // Kiểm tra xem có dòng nào được chọn không
            if (dgDonHang.SelectedRows.Count == 0)
            {
                MessageBox.Show("Không có sản phẩm nào được chọn");
                return;
            }
            if (tong_tien > 0)
            {
                MessageBox.Show("Cảm ơn bạn đã mua hàng. Sản phẩm sẽ được giao tới sớm.");
                HoaDon();
                ThemThongKe();
                XoaSPdaban();
                LoadDataToDataGridView();
            }
            else
            {
                MessageBox.Show("Tiền = 0");
            }
        }

        public void XoaSPdaban()
        {
            // Kiểm tra xem có dòng nào được chọn không
            if (dgDonHang.SelectedRows.Count == 0)
            {
                MessageBox.Show("Không có sản phẩm nào được chọn");
                return;
            }

            // Duyệt qua các hàng đã chọn trong DataGridView
            foreach (DataGridViewRow row in dgDonHang.SelectedRows)
            {
                // Lấy giá trị cột "MaSanPham" trong hàng
                string maSanPham = row.Cells["MaSanPham"].Value.ToString().Trim();

                // Lấy giá trị ô "SoLuong" trong hàng
                int soLuongUserChon = Convert.ToInt32(row.Cells["SoLuong"].Value);

                // Kiểm tra số lượng trong cơ sở dữ liệu bảng Sản phẩm 
                string xemSoLuong = "SELECT SoLuong FROM SanPham WHERE MaSanPham = '" + maSanPham + "'";
                db.ThucThiPKN(xemSoLuong);
                DataSet ds = db.GetDataSet();

                if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)//có dữ liệu(số lượng) hay không
                {
                    int soLuongTrongDatabase = Convert.ToInt32(ds.Tables[0].Rows[0]["SoLuong"]);

                    if (soLuongTrongDatabase >= soLuongUserChon)
                    {
                        int soLuongKhiDaTru = soLuongTrongDatabase - soLuongUserChon;

                        // Cập nhật số lượng trong cơ sở dữ liệu
                        string updateSanPhamSoLuong = "UPDATE SanPham SET SoLuong = '" + soLuongKhiDaTru + "' WHERE MaSanPham = '" + maSanPham + "'";
                        db.ThucThiPKN(updateSanPhamSoLuong);
                        //xóa trong đơn hàng
                        string deleteSanPham = "DELETE FROM DonHang WHERE MaSanPham = '" + maSanPham + "'";
                        db.ThucThiPKN(deleteSanPham);
                        LoadDataToDataGridView();

                        if (soLuongKhiDaTru == 0)
                        {
                            // Xóa sản phẩm từ cơ sở dữ liệu nếu số lượng bằng 0
                            string deleteSanPhamQuery = "DELETE FROM SanPham WHERE MaSanPham = '" + maSanPham + "'";
                            db.ThucThiPKN(deleteSanPhamQuery);
                        }
                    }
                }
            }
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn muốn xóa chứ?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                DataTable dtcheck = db.GetDataTable("select * from DonHang where MaSanPham = '" + txtMaSanPham.Text.Trim() + "'");
                if (dtcheck.Rows.Count > 0)
                {
                    string lenh = "delete from DonHang where MaSanPham = '" + txtMaSanPham.Text.Trim() + "'";
                    db.ThucThiPKN(lenh);
                    LoadDataToDataGridView();
                    MessageBox.Show("Đã xóa thành công");
                    txtMaSanPham.Clear();
                    txtMaSanPham.Focus();
                }
                else
                {
                    MessageBox.Show("Sản Phẩm " + txtMaSanPham.Text.Trim() + " không có trong đơn hàng.Vui lòng nhập lại.");
                }
            }
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Thiết lập cột 5(số lượng) được chỉnh sửa
            dgDonHang.Columns[4].ReadOnly = false;

            // Thiết lập các cột khác là chỉ đọc
            for (int i = 0; i < dgDonHang.Columns.Count; i++)
            {
                if (i != 4) // Loại bỏ cột 5
                {
                    dgDonHang.Columns[i].ReadOnly = true;
                }
            }
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TinhTongTien();
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4) // Kiểm tra xem người dùng đã thay đổi ô thứ 5(số lượng) hay chưa
            {
                DataGridViewCell cell5 = dgDonHang.Rows[e.RowIndex].Cells[4]; // Ô thứ 5(số lượng)
                DataGridViewCell cell6 = dgDonHang.Rows[e.RowIndex].Cells[5]; // Ô thứ 6(giá tiền)
                DataGridViewCell cell0 = dgDonHang.Rows[e.RowIndex].Cells[0]; // Ô thứ 1(mã sản phẩm)

                //kiểm tra trong csdl cell0 là MaSanPham
                DataTable dtcheck = db.GetDataTable("select SoLuong, GiaTien from SanPham where MaSanPham = '" + cell0.Value.ToString() + "' ");
                if(dtcheck.Rows.Count > 0)
                {
                    int soLuongSanPham = Convert.ToInt32(dtcheck.Rows[0]["SoLuong"]);//số lượng trong csdl
                    int giaTienSanPham = Convert.ToInt32(dtcheck.Rows[0]["GiaTien"]);//giá tiền trong csdl đồng thời cũng là giá tiền ban đầu
                    int soLuongThayDoi = Convert.ToInt32(cell5.Value);//số lượng đã thay đổi

                    if (soLuongSanPham >= soLuongThayDoi && soLuongThayDoi>0)
                    {
                        // Tính giá trị mới của ô thứ 6(giá tiền) dựa trên số lượng đã thay đổi
                        int tinhtoan = soLuongThayDoi * giaTienSanPham;
                        // Cập nhật giá trị của ô thứ 6(giá tiền)
                        cell6.Value = tinhtoan;
                    }
                    else
                    {
                        MessageBox.Show("Số lượng vượt quá số lượng trong csdl hoặc số lượng nhỏ hơn <= 0.Vui lòng thông cảm bởi vì chúng tôi đã không đủ số lượng hàng mà bạn cần.");
                        cell5.Value = 1;
                        cell6.Value = giaTienSanPham;
                    }
                }               
            }
            else
            {
                MessageBox.Show("Chưa sửa");
            }
        }

        private void chkGiamGia_CheckedChanged(object sender, EventArgs e)
        {
            if (chkGiamGia.Checked == true && txtTongTien.Text.Trim() != "")//nếu nhấn vào giảm giá
            {
                tong_tien = Convert.ToInt32(txtTongTien.Text.Trim());
                tien_duoc_khi_giam_gia = (tong_tien * 20) / 100;//tiền được giảm giá 
                tong_tien = tong_tien - tien_duoc_khi_giam_gia;//tổng tiền sau khi trừ đi tiền được giảm giá
                txtTongTien.Text = tong_tien.ToString();
            }
            else//nếu không nhấn giảm giá thì lại trở lại tổng tiền ban đầu
            {
                txtTongTien.Text = tong_tien_ban_dau_khi_chua_giam_gia.ToString();
            }
        }

        private void txtTongTien_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmDonhang_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {           
            
        }
    }
}
