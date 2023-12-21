using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bài_Tập_Lớn_Windows_Form
{
    internal class Database
    {
        ///Lớp chuyên xử lý dữ liệu
        //Khai báo các đối tượng
        string strCon = @"Data Source=MSI;Initial Catalog=QLCHMP;Integrated Security=True";
        SqlConnection sqlCon;
        SqlCommand sqlCom;
        SqlDataAdapter sqlAdap;
        DataSet ds;

        /// <summary>
        /// Phương thức kết nối đến CSDL
        /// </summary>
        void KetNoi()
        {
            sqlCon = new SqlConnection(strCon);
            if (sqlCon.State == ConnectionState.Closed)
            {
                sqlCon.Open();
                //MessageBox.Show("Kết nối đến CSDL thành công!");
            }
        }
        /// <summary>
        /// Phương thức ngắt kết nối CSDL
        /// </summary>
        void NgatKetNoi()
        {
            if (sqlCon.State == ConnectionState.Open)
            {
                sqlCon.Close();
            }          
        }

        /// <summary>
        /// Phương thức thực thi câu lệnh SQL: Insert, Update, Delete...
        /// </summary>
        /// <param name="strSQL">Chuỗi mô tả câu lệnh SQL: Insert, Update, Delete...</param>
        public void ThucThi(string strSQL)
        {
            //Step 1
            KetNoi();
            //Step 2
            sqlCom = new SqlCommand(strSQL, sqlCon);
            sqlCom.ExecuteNonQuery();
            //Step 3
            NgatKetNoi();
        }

        //Để load CSDL lên, cần sử dụng đối tượng DataReader để đọc CSDL => Hiển thị lên DataGridView
        //Mất thời gian và không tiện bằng sử dụng Phương thức Phi kết nối
        //Sử dụng DataReader sinh viên tự đọc và thực hiện
        /// <summary>
        /// Phương thức thực thi câu lệnh SQL theo mô hình PKN!
        /// </summary>
        /// <param name="strSQL">Chuỗi mô tả câu lệnh SQL Insert, Update, Delete...</param>
        public void ThucThiPKN(string strSQL)
        {
            //B1
            sqlAdap = new SqlDataAdapter(strSQL, strCon);
            //B2
            ds = new DataSet();
            sqlAdap.Fill(ds);//fill là lấy dữ liệu của sql điền vào ds
        }
        public DataSet GetDataSet()
        {
            return ds;
        }

        //Dùng để thực hiện các câu truy vấn sql xong trả kết quả về DataTable
        public DataTable GetDataTable(string strSelect)
        {
            //B1
            sqlAdap = new SqlDataAdapter(strSelect, strCon);
            //B2
            ds = new DataSet();
            sqlAdap.Fill(ds);//fill là lấy dữ liệu của sql điền vào ds
            //B3
            return ds.Tables[0];
        }
    }
}
