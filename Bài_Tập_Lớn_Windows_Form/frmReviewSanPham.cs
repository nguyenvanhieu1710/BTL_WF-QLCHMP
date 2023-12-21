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
    public partial class frmReviewSanPham : Form
    {
        public frmReviewSanPham()
        {
            InitializeComponent();
        }

        private void frmReviewSanPham_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void frmReviewSanPham_Load(object sender, EventArgs e)
        {

        }
    }
}
