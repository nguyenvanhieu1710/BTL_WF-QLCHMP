using Guna.UI2.AnimatorNS;
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
    public partial class frmProfile : Form
    {
        Database db = new Database();
        public frmProfile()
        {
            InitializeComponent();
        }
        public string imagePath;
        public void DayAnhLen()
        {
            //mở một hộp thoại để người dùng có thể chọn đường dẫn của một tệp tin
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Tệp ảnh|*.jpg;*.png;*.gif|Tất cả các tệp|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)//đã chọn tệp
            {
                string filePath = openFileDialog.FileName;//đường dẫn tệp tin đã chọn
                pbImage.Image = Image.FromFile(filePath);//gán đường dẫn vào ảnh
                imagePath = filePath;
            }
        }
        private void btnPushPhoto_Click(object sender, EventArgs e)
        {
            
        }

        private void btnDayAnhLoad_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void txtNgaySinh_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtHoTen.Text.Trim() =="" || txtNgaySinh.Text.Trim() =="" || txtSoDienThoai.Text.Trim() ==""
                || txtEmail.Text.Trim() =="" || (radNam.Checked == false && radNu.Checked == false) || pbImage.Image==null)
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin");
            }
            else
            {
                MessageBox.Show("Đã điền đủ thông tin");
                string MaKhachHang = txtUser.Text;
                DataTable dtcheck = db.GetDataTable("select * from KhachHang where MaKhachHang = '" + MaKhachHang + "' ");
                if(dtcheck.Rows.Count > 0)
                {
                    MessageBox.Show("Mã khách hàng đã tồn tại");
                    if (radNam.Checked)
                    {
                        string update1 = "UPDATE KhachHang SET " +
                                         "TenKhachHang = N'" + txtHoTen.Text.Trim() + "', " +
                                         "NgaySinh = '" + txtNgaySinh.Text.Trim() + "', " +
                                         "SoDienThoai = '" + txtSoDienThoai.Text.Trim() + "', " +
                                         "Email = N'" + txtEmail.Text.Trim() + "', " +
                                         "GioiTinh = N'Nam', " +
                                         "Anh = N'"+imagePath+"' where MaKhachHang = '"+MaKhachHang+"' ";
                        db.ThucThiPKN(update1);
                    }
                    else if (radNu.Checked)
                    {
                        string update2 = "UPDATE KhachHang SET " +
                                         "TenKhachHang = N'" + txtHoTen.Text.Trim() + "', " +
                                         "NgaySinh = '" + txtNgaySinh.Text.Trim() + "', " +
                                         "SoDienThoai = '" + txtSoDienThoai.Text.Trim() + "', " +
                                         "Email = N'" + txtEmail.Text.Trim() + "', " +
                                         "GioiTinh = N'Nữ', " +
                                         "Anh = N'"+imagePath+"' where MaKhachHang = '"+MaKhachHang+ "' ";
                        db.ThucThiPKN(update2);
                    }
                }
                else
                {
                    MessageBox.Show("Mã không tồn tại");
                    if (radNam.Checked)
                    {
                        string them = "Insert into KhachHang values ('" + MaKhachHang + "',N'" + txtHoTen.Text.Trim() + "'," +
                        " N'" + txtNgaySinh.Text.Trim() + "','" + txtSoDienThoai.Text.Trim() + "',N'" + txtEmail.Text.Trim() + "',N'Nam', N'"+imagePath+"')";
                        db.ThucThiPKN(them);
                    }
                    else if (radNu.Checked)
                    {
                        string them = "Insert into KhachHang values ('" + MaKhachHang + "',N'" + txtHoTen.Text.Trim() + "'," +
                        " N'" + txtNgaySinh.Text.Trim() + "','" + txtSoDienThoai.Text.Trim() + "',N'" + txtEmail.Text.Trim() + "',N'Nữ', N'"+imagePath+"')";
                        db.ThucThiPKN(them);
                    }
                }                 
            }
        }
        public void SetData(string data)//chèn MaKhachHang từ bên trang chủ vào mà trang chủ lại được bên đăng nhập truyền vào
        {
            txtUser.Text = data;//chèn vào txtUser
        }
        private void frmProfile_Load(object sender, EventArgs e)
        {
            string MaKhachHang = txtUser.Text;
            DataTable dtcheck = db.GetDataTable("select * from KhachHang where MaKhachHang = '" + MaKhachHang + "' ");
            if (dtcheck.Rows.Count > 0)
            {
                //MessageBox.Show("Mã đã tồn tại");
                foreach (DataRow row in dtcheck.Rows)
                {
                    //txtUser.Text = row[0].ToString();
                    txtHoTen.Text = row[1].ToString();
                    txtNgaySinh.Text = row[2].ToString();
                    txtSoDienThoai.Text = row[3].ToString();
                    txtEmail.Text = row[4].ToString();
                    if (row[5].ToString().Trim().Equals("Nam"))
                    {
                        radNam.Checked = true;
                    }
                    else 
                    {
                        radNu.Checked = true;
                    }
                    string duongdan = row[6].ToString();
                    pbImage.Image = Image.FromFile(duongdan);//gán đường dẫn vào ảnh
                }
            }
        }

        private void frmProfile_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void pbImage_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn sửa ảnh không?", "Sửa", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                DayAnhLen();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
