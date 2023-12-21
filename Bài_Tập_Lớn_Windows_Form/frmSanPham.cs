using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Hosting;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bài_Tập_Lớn_Windows_Form
{
    public partial class frmSanpham : Form
    {
        //frmTrangchu trangchu;
        Database db = new Database();
        public frmSanpham()
        {
            InitializeComponent();
            //trangchu = new frmTrangchu();
        }
        private void LoadDataToDataGridView()
        {
            string load = "select * from SanPham";
            dataGridView1.DataSource = db.GetDataTable(load);
        }
        
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void frmSanpham_Load(object sender, EventArgs e)
        {
            LoadDataToDataGridView();
            // Đặt kích thước cố định cho Form
            this.MinimumSize = new Size(816, 529);
            this.MaximumSize = new Size(816, 529);
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();            
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string timten = "select * from SanPham where TenSanPham LIKE N'%" + txtSanPham.Text.Trim() + "%' ";
            DataTable dtcheck1 = db.GetDataTable(timten);//kiểm tra đã tồn tại trong csdl chưa
            if (dtcheck1.Rows.Count > 0)
            {
                DataTable dt = db.GetDataTable(timten);
                dataGridView1.DataSource = dt;//load ra datagridview
            }
            else { MessageBox.Show("Sản Phẩm:" + txtSanPham.Text.Trim() + " không tồn tại.", "Sản Phẩm", MessageBoxButtons.OK, MessageBoxIcon.Information); }

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void button5_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có dòng nào được chọn không
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Không có sản phẩm nào được chọn");
                return;
            }

            // Duyệt qua các hàng đã chọn trong DataGridView
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                // Lấy các giá trị trong hàng
                string maSanPham = row.Cells["MaSanPham"].Value.ToString().Trim();
                string TenSanPham = row.Cells["TenSanPham"].Value.ToString().Trim();
                string XuatXu = row.Cells["XuatXu"].Value.ToString().Trim();
                string LoaiSanPham = row.Cells["LoaiSanPham"].Value.ToString().Trim();
                string SoLuong = "1";
                string GiaTien = row.Cells["GiaTien"].Value.ToString().Trim();

                string them = "Insert into DonHang values('" + maSanPham + "', N'" + TenSanPham + "', N'" + XuatXu + "', N'" + LoaiSanPham + "', '" + SoLuong + "', '" + GiaTien + "')";

                DataTable dtcheck = db.GetDataTable("select * from DonHang where MaSanPham = '" + maSanPham + "'");
                if (dtcheck.Rows.Count > 0)
                {
                    MessageBox.Show("Sản phẩm: " + maSanPham.Trim() + " đã có trong giỏ hàng.");
                }
                else
                {
                    db.ThucThiPKN(them);
                    MessageBox.Show("Đã thêm vào giỏ hàng thành công");
                }
            }                
        }

        private void txtTimkiem_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                // Lấy giá trị của ô được ấn
                DataGridViewCell clickedCell = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];
                object cellValue = clickedCell.Value;

                if (cellValue.ToString()=="Nước hoa 1")
                {
                    string imagePath = "C:\\Users\\NGUYEN VAN HIEU\\Pictures\\Sản phẩm mỹ phẩm\\Nước hoa 1.1.jpg";
                    pictureBox1.Image = Image.FromFile(imagePath);
                }
                else if (cellValue.ToString()=="Nước hoa 2")
                {
                    string imagePath = "C:\\Users\\NGUYEN VAN HIEU\\Pictures\\Sản phẩm mỹ phẩm\\Nước hoa 2.2.jpg";
                    pictureBox1.Image = Image.FromFile(imagePath);
                }
                else if(cellValue.ToString()=="Kem chống nắng 1")
                {
                    string imagePath = "C:\\Users\\NGUYEN VAN HIEU\\Pictures\\Sản phẩm mỹ phẩm\\Kem chống nắng 1.jpg";
                    pictureBox1.Image = Image.FromFile(imagePath);
                }
                else if(cellValue.ToString() =="Kem chống nắng 2")
                {
                    string imagePath = "C:\\Users\\NGUYEN VAN HIEU\\Pictures\\Sản phẩm mỹ phẩm\\Kem chống nắng 2.jpg";
                    pictureBox1.Image = Image.FromFile(imagePath);
                }
                else if(cellValue.ToString() =="Nước tẩy trang 1")
                {
                    string imagePath = "C:\\Users\\NGUYEN VAN HIEU\\Pictures\\Sản phẩm mỹ phẩm\\Nước tẩy trang 1.png";
                    pictureBox1.Image = Image.FromFile(imagePath);
                }
                else if (cellValue.ToString() =="Nước tẩy trang 2")
                {
                    string imagePath = "C:\\Users\\NGUYEN VAN HIEU\\Pictures\\Sản phẩm mỹ phẩm\\Nước tẩy trang 2.jpg";
                    pictureBox1.Image = Image.FromFile(imagePath);
                }
                else if(cellValue.ToString()=="Son 1")
                {
                    string imagePath = "C:\\Users\\NGUYEN VAN HIEU\\Pictures\\Sản phẩm mỹ phẩm\\Son1.jpeg";
                    pictureBox1.Image = Image.FromFile(imagePath);
                }
                else if(cellValue.ToString() =="Son 2")
                {
                    string imagePath = "C:\\Users\\NGUYEN VAN HIEU\\Pictures\\Sản phẩm mỹ phẩm\\Son2.jpg";
                    pictureBox1.Image = Image.FromFile(imagePath);
                }
                else if(cellValue.ToString() =="Sữa rửa mặt 1")
                {
                    string imagePath = "C:\\Users\\NGUYEN VAN HIEU\\Pictures\\Sản phẩm mỹ phẩm\\Suaruamat1.jpg";
                    pictureBox1.Image = Image.FromFile(imagePath);
                }
                else if(cellValue.ToString() =="Sữa rửa mặt 2")
                {
                    string imagePath = "C:\\Users\\NGUYEN VAN HIEU\\Pictures\\Sản phẩm mỹ phẩm\\Suaruamat2.jpg";
                    pictureBox1.Image = Image.FromFile(imagePath);
                }
                else { }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnXemHinhAnhMinhHoa_Click(object sender, EventArgs e)
        {

        }

        private void btnReviewSanPham_Click(object sender, EventArgs e)
        {
            frmReviewSanPham reviewSanPham = new frmReviewSanPham();
            reviewSanPham.ShowDialog();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
            txtSanPham.Text = "";
            LoadDataToDataGridView();
        }

        private void frmSanpham_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
