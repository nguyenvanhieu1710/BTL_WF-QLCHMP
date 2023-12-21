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
    public partial class frmDangNhap1 : Form
    {
        Database db = new Database();
        DataSet ds = new DataSet();
        frmTrangchu trangchu = new frmTrangchu();
        public frmDangNhap1()
        {
            InitializeComponent();
        }

        private bool isButtonClicked = false; // Biến để theo dõi trạng thái button
        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            if (isButtonClicked) // Kiểm tra trạng thái của button
            {
                txtPassword.PasswordChar = '*'; // Ẩn mật khẩu bằng kí tự '*'
                isButtonClicked = false; // Đặt lại trạng thái button
            }
            else
            {
                txtPassword.PasswordChar = '\0'; // Hiển thị mật khẩu trên textbox
                isButtonClicked = true; // Đặt lại trạng thái button
            }
        }
        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void TruyVan()
        {
            string hien = "select TenDangNhap, MatKhau, Quyen from DangNhap";
            db.ThucThiPKN(hien);
            //lấy dữ liệu ở dataset bên class Database = ds(Dataset) bên class này
            ds = db.GetDataSet();
        }
        public string data;        
        private void btnSignUp_Click(object sender, EventArgs e)
        {
            if(radUser.Checked && txtUser.Text.Trim() !="" && txtPassword.Text.Trim() !="")
            {
                TruyVan();//để lấy dữ liệu từ cơ sở dữ liệu và điền vào ds.
                foreach (DataRow row in ds.Tables[0].Rows)//duyệt theo hàng trong dataset
                {//duyệt qua từng hàng (DataRow) trong bảng đầu tiên (Tables[0]) của DataSet (ds).
                    // Kiểm tra xem dữ liệu trong DataSet có trùng khớp với dữ liệu trong textbox hay không
                    if (txtUser.Text.Trim() == row[0].ToString()
                        && txtPassword.Text.Trim() == row[1].ToString()
                        && row[2].Equals("User"))
                    {
                        // Dữ liệu trùng khớp
                        MessageBox.Show("Đăng nhập User thành công!");
                        data = row[0].ToString();
                        trangchu.SetData(data);
                        this.Hide();
                        trangchu.DisEnabled();
                        trangchu.Show();                        
                        return;//kết thúc lặp
                    }
                }
                // Dữ liệu không trùng khớp
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu hoặc quyền không chính xác!");
            }
            else if(radAdmin.Checked && txtUser.Text.Trim() != "" && txtPassword.Text.Trim() != "")
            {
                TruyVan();//để lấy dữ liệu từ cơ sở dữ liệu và điền vào ds.                        
                foreach (DataRow row in ds.Tables[0].Rows)//duyệt theo hàng trong dataset
                {//duyệt qua từng hàng (DataRow) trong bảng đầu tiên (Tables[0]) của DataSet (ds).
                    // Kiểm tra xem dữ liệu trong DataSet có trùng khớp với dữ liệu trong textbox hay không
                    if (txtUser.Text.Trim() == row[0].ToString()
                        && txtPassword.Text.Trim() == row[1].ToString()
                        && row[2].ToString() == "Admin")
                    {
                        // Dữ liệu trùng khớp
                        MessageBox.Show("Đăng nhập Admin thành công!");
                        data = row[0].ToString();
                        trangchu.SetData(data);
                        this.Hide();
                        trangchu.Show();
                        return;//kết thúc lặp
                    }
                }
                // Dữ liệu không trùng khớp
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu hoặc quyền không chính xác!");
            }
            else
            {
                MessageBox.Show("Vui lòng nhập User, Password và chọn quyền đăng nhập");
            }
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            DataTable dtcheck = db.GetDataTable("select * from DangNhap where TenDangNhap = '" + txtUser.Text.Trim() + "'");
            if(dtcheck.Rows.Count > 0)
            {
                MessageBox.Show("User: "+txtUser.Text.Trim() +" đã tồn tại.Vui lòng nhập lại.","Trùng dữ liệu");
            }
            else
            {
                if (radUser.Checked && txtUser.Text.Trim() != "" && txtPassword.Text.Trim() != "")
                {
                    string user = "User";
                    string lenh1 = "insert into DangNhap values(N'" + txtUser.Text.Trim() + "',N'" + txtPassword.Text.Trim() + "',N'"+user.Trim()+"')";
                    db.ThucThiPKN(lenh1);
                    MessageBox.Show("Đã đăng ký User thành công. Vui lòng đăng nhập.");
                }
                else if (radAdmin.Checked && txtUser.Text.Trim() != "" && txtPassword.Text.Trim() != "")
                {
                    MessageBox.Show("Bạn không có quyền đăng kí Admin");
                    //string admin = "Admin";
                    //string lenh2 = "insert into DangNhap values(N'" + txtUser.Text.Trim() + "',N'" + txtPassword.Text.Trim() + "',N'" + admin.Trim() + "')";
                    //db.ThucThiPKN(lenh2);
                    //MessageBox.Show("Đã đăng ký Admin thành công. Vui lòng đăng nhập.");
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập User, Password và chọn quyền đăng nhập");
                }
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2GradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
