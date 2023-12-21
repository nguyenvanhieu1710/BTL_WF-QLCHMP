using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace Bài_Tập_Lớn_Windows_Form
{
    public partial class frmDangnhap : Form
    {
        Database db = new Database();
        DataSet ds = new DataSet();
        public frmDangnhap()
        {
            InitializeComponent();
        }
        private void txtMatkhau_TextChanged(object sender, EventArgs e)
        {//thuộc tính PasswordChar thay hết kí tự nhập vào textbox thành kí tự * hết
            txtMatkhau.PasswordChar = '*';
        }

        private void chkHienmatkhau_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void TruyVan()
        {
            string hien = "select TenDangNhap, MatKhau from DangNhap";
            db.ThucThiPKN(hien);
            //lấy dữ liệu ở dataset bên class Database = ds(Dataset) bên class này
            ds = db.GetDataSet();        
        }
        private void btDangnhap_Click(object sender, EventArgs e)
        {
            TruyVan();//để lấy dữ liệu từ cơ sở dữ liệu và điền vào ds.
            // Kiểm tra xem dữ liệu trong DataSet có trùng khớp với dữ liệu trong textbox hay không
            foreach (DataRow row in ds.Tables[0].Rows)//duyệt theo hàng trong dataset
            {//duyệt qua từng hàng (DataRow) trong bảng đầu tiên (Tables[0]) của DataSet (ds).
                if (txtDangnhap.Text.Trim() == row[0].ToString() 
                    && txtMatkhau.Text.Trim() == row[1].ToString())
                {
                    // Dữ liệu trùng khớp
                    MessageBox.Show("Đăng nhập thành công!");
                    this.Hide();
                    frmTrangchu trangchu = new frmTrangchu();
                    trangchu.DisEnabled();
                    trangchu.Show();
                    return;
                }
            }
            // Dữ liệu không trùng khớp
            MessageBox.Show("Tên đăng nhập hoặc mật khẩu không chính xác!");
        }
        private void timer1_Tick(object sender, EventArgs e)
        {

        }
        private void frmDangnhap_Load(object sender, EventArgs e)
        {
            // Đặt kích thước cố định cho Form
            this.MinimumSize = new Size(849, 690);
            this.MaximumSize = new Size(849, 690);
        }

        private bool isButtonClicked = false; // Biến để theo dõi trạng thái button
        private void btnHienMatKhau_Click(object sender, EventArgs e)
        {
            if (isButtonClicked) // Kiểm tra trạng thái của button
            {
                txtMatkhau.PasswordChar = '*'; // Ẩn mật khẩu bằng kí tự '*'
                isButtonClicked = false; // Đặt lại trạng thái button
            }
            else
            {
                txtMatkhau.PasswordChar = '\0'; // Hiển thị mật khẩu trên textbox
                isButtonClicked = true; // Đặt lại trạng thái button
            }
        }
    }
}
