using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bài_Tập_Lớn_Windows_Form
{
    public partial class frmTrangchu : Form
    {
        public frmTrangchu()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("Chào mừng các quý cô xinh đẹp đến với cửa hàng của Hiếu","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmSanpham sanpham = new frmSanpham();
            this.Hide();
            sanpham.ShowDialog();
            this.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
               
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Chức năng đang trong quá trình update.Bạn có muốn tiếp tục không.", "Update", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                frmVongQuayMayMan vongQuayMayMan = new frmVongQuayMayMan();
                this.Hide();
                vongQuayMayMan.ShowDialog();
                this.Show();
            }            
        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            Application.Exit();
            this.Dispose();
            Process proc = new Process();
            proc.StartInfo.FileName = Application.StartupPath + "\\Bài_Tập_Lớn_Windows_Form.exe";
            proc.StartInfo.WindowStyle = ProcessWindowStyle.Normal;
            proc.Start();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmDonhang donhang = new frmDonhang();
            this.Hide();
            donhang.SetData(data1);//truyền mã khách hàng vào form đơn hàng
            donhang.ShowDialog();
            this.Show();
        }

        private void btnListMenu_Click(object sender, EventArgs e)
        {
            if(menuStrip1.Visible==true)
            {
                menuStrip1.Hide();
            }
            else
            {
                menuStrip1.Show();
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            
        }

        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDangNhap1 dangNhap1 = new frmDangNhap1();
            this.Hide();
            dangNhap1.ShowDialog();
        }
        public void IsEnabled()
        {          
            nhânViênToolStripMenuItem.Enabled = true;
            kháchHàngToolStripMenuItem.Enabled = true;
            ThongKetoolStripMenuItem1.Enabled = true;
        }
        public void DisEnabled()
        {
            nhânViênToolStripMenuItem.Enabled = false;
            kháchHàngToolStripMenuItem.Enabled = false;
            ThongKetoolStripMenuItem1.Enabled=false;
            quanLySanPhamtoolStripMenuItem1.Enabled = false;
        }
        private void frmTrangchu_Load(object sender, EventArgs e)
        {
            
        }

        private void sảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNhanvien nhanvien = new frmNhanvien();
            this.Hide();
            nhanvien.ShowDialog();
            this.Show();
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKhachHang khachHang = new frmKhachHang();
            this.Hide();
            khachHang.ShowDialog();
            this.Show();
        }

        private void đơnHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void quanLytoolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void đăngNhậpUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDangnhap dangnhap = new frmDangnhap();
            this.Hide();
            dangnhap.Show();
        }

        private void đăngNhậpQLToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {

        }
        public string data1;//Mã khách hàng được truyền từ form đăng nhập
        public void SetData(string data2)
        {
            data1 = data2;
        }
        private void profileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProfile profile = new frmProfile();         
            this.Hide();
            profile.SetData(data1);//chèn MaKhachHang từ bên trang chủ vào mà trang chủ lại được bên đăng nhập truyền vào
            profile.ShowDialog();
            this.Show();
        }

        private void btnMaGiamGia_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Chức năng đang trong quá trình update.Bạn có muốn tiếp tục không.", "Update", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                frmMaGiamGia maGiamGia = new frmMaGiamGia();
                maGiamGia.SetData(data1);
                this.Hide();
                maGiamGia.ShowDialog();
                this.Show();
            }
        }

        private void ThongKetoolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmThongKe thongKe = new frmThongKe();
            this.Hide();
            thongKe.ShowDialog();
            this.Show();
        }

        private void quanLySanPhamtoolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmQuanLySanPham quanLySanPham = new frmQuanLySanPham();
            this.Hide();
            quanLySanPham.ShowDialog();
            this.Show();
        }
    }
}
