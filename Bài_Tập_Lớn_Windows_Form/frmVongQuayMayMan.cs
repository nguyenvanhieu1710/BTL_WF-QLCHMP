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
    public partial class frmVongQuayMayMan : Form
    {
        private Timer spinTimer;
        private Timer stopTimer;
        private float rotationAngle = 0;
        private float rotationSpeed = 2f; // Tốc độ xoay của hình ảnh
        private float spinDuration = 5f; // Thời gian quay (số giây)
        private float elapsedTime = 0f; // Thời gian đã trôi qua
        public frmVongQuayMayMan()
        {
            InitializeComponent();
            InitializeSpinTimer();
            InitializeStopTimer();
        }
        private void InitializeSpinTimer()
        {
            spinTimer = new Timer();
            spinTimer.Interval = 50; // Thời gian giữa mỗi tick (50 milliseconds)
            spinTimer.Tick += spinTimer_Tick;
        }

        private void InitializeStopTimer()
        {
            stopTimer = new Timer();
            stopTimer.Interval = 12000; // 12 giây
            stopTimer.Tick += stopTimer_Tick;
        }
        private void spinTimer_Tick(object sender, EventArgs e)
        {
            elapsedTime += spinTimer.Interval / 1000f; // Cập nhật thời gian đã trôi qua

            rotationAngle += rotationSpeed; // Tính góc xoay mới dựa trên tốc độ xoay
            if (rotationAngle >= 360)
            {
                rotationAngle -= 360; // Đảm bảo góc xoay nằm trong khoảng từ 0 đến 359 độ
            }

            pictureBox1.Invalidate(); // Yêu cầu PictureBox vẽ lại

            if (elapsedTime >= spinDuration)
            {
                spinTimer.Stop(); // Dừng timer quay
                elapsedTime = 0f; // Đặt lại thời gian đã trôi qua về 0
                stopTimer.Start(); // Bắt đầu đếm ngược 10 giây
            }
        }
        private void stopTimer_Tick(object sender, EventArgs e)
        {
            stopTimer.Stop(); // Dừng timer đếm ngược
            // Sau khi dừng quay
            MessageBox.Show("Đã quay xong");

            // Đặt lại góc xoay về 0
            rotationAngle = 0;
            pictureBox1.Invalidate(); // Yêu cầu PictureBox vẽ lại
        }

        private void frmHieuXu_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            rotationAngle += rotationSpeed; // Tính góc xoay mới dựa trên tốc độ xoay
            if (rotationAngle >= 360)
            {
                rotationAngle -= 360; // Đảm bảo góc xoay nằm trong khoảng từ 0 đến 359 độ
            }

            pictureBox1.Invalidate(); // Yêu cầu PictureBox vẽ lại
        }

        private void btnSprin_Click(object sender, EventArgs e)
        {
            rotationAngle = 0; // Đặt góc xoay về 0
            elapsedTime = 0f; // Đặt lại thời gian đã trôi qua về 0
            spinTimer.Start(); // Bắt đầu timer để quay hình ảnh
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.TranslateTransform(pictureBox1.Width / 2, pictureBox1.Height / 2); // Di chuyển gốc tọa độ đến trung tâm của PictureBox
            g.RotateTransform(rotationAngle); // Xoay hình ảnh theo góc xoay hiện tại

            string imagePath = "C:\\Users\\NGUYEN VAN HIEU\\Pictures\\muiten.png"; // đường dẫn tới hình ảnh 
            Image wheelImage = Image.FromFile(imagePath);
            g.DrawImage(wheelImage, -wheelImage.Width / 2, -wheelImage.Height / 2); // Vẽ hình ảnh tại vị trí trung tâm      }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
