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
    public partial class frmMaGiamGia : Form
    {
        Database db = new Database();
        public frmMaGiamGia()
        {
            InitializeComponent();
        }
        public void SetData(string data)//chèn MaKhachHang từ bên trang chủ vào mà bên trang chủ lại được bên đăng nhập truyền vào
        {
            txtUser.Text = data;//chèn vào txtUser
        }
        void KiemTra()
        {
            string lenh = "select * from KhachHang where MaKhachHang = '"+txtUser.Text.Trim()+"'";
            DataTable dtcheck = db.GetDataTable(lenh);
            if(dtcheck.Rows.Count > 0 )
            {
                btnGGSPKHM.Enabled = false;
                btnMVCKHM.Enabled = false;
            }
        }
        private void frmMaGiamGia_Load(object sender, EventArgs e)
        {
            KiemTra();
        }

        private void frmMaGiamGia_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
