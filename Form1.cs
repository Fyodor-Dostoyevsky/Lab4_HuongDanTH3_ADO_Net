using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography.X509Certificates;
namespace Lab4_HuongDanTH3_ADO_Net
{
    public partial class FormDShs : Form
    {

       
        private SqlConnection conn;
        string maHS, tenHS, diachi, malop;
        double dtb;
        DateTime ngaysinh;

        public void connect()
        {
            String strconn = @"Data Source=LAPTOP-78LVMDCQ;Initial Catalog=QLHOCSINH;Integrated Security=True;";
            try
            {
                conn = new SqlConnection(strconn);
                conn.Open();
                string sql = "Select h.MaHS, h.TenHS, h.NgaySinh, h.DiaChi, h.DTB, l.TenLop From HOCSINH h, LOP l Where h.MaLop=l.MaLop";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.CommandType = CommandType.Text;
                SqlDataAdapter da  = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                
                dataGridView1.DataSource = dt;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

                foreach (DataGridViewColumn column in dataGridView1.Columns)
                {
                    column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }

                conn.Close();
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Không có dữ liệu được load lên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public DataTable getDslop()
        {
            string strSQL = "select * from lop";
            SqlDataAdapter adapter;
            adapter = new SqlDataAdapter(strSQL, conn);
            DataSet dataSet = new DataSet();
            try
            {
                adapter.Fill(dataSet);
                return dataSet.Tables[0];
            }
            catch
            {
                return null;
            }

        }
        public FormDShs()
        {
            InitializeComponent();
           
        }
       

        private void btnLuu_Click(object sender, EventArgs e)
        {
            maHS = txtMahs.Text;
            tenHS = txtTenhs.Text;
            ngaysinh = dtpNgaysinh.Value;
            diachi = txtDiaChi.Text;
            malop = cmbLop.SelectedValue.ToString();
            dtb = Convert.ToDouble(txtDiemTB.Text);
            

            if (string.IsNullOrEmpty(maHS))
            {
                MessageBox.Show("Mã học sinh không được để trống!");
                return;
            }
            if (string.IsNullOrEmpty(tenHS))
            {
                MessageBox.Show("Tên học sinh không được để trống!");
                return;
            }
            if (string.IsNullOrEmpty(dtb.ToString()))
            {
                MessageBox.Show("Điểm học sinh không được để trống!");
                return;
            }
            if (dtb < 0 || dtb > 10)
            {
                MessageBox.Show("Điểm trung bình phải là số thực từ 0 đến 10!");
                return; 
            }
            if (ngaysinh < DateTime.Today.AddYears(-20) || ngaysinh > DateTime.Today.AddYears(-15))
            {
                MessageBox.Show("Học sinh phải có độ tuổi từ 15 đến 20!");
                return;
            }

            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }

                string checkDuplicateSql = "SELECT COUNT(*) FROM HOCSINH WHERE maHS = @maHS";
                SqlCommand checkDuplicateCmd = new SqlCommand(checkDuplicateSql, conn);
                checkDuplicateCmd.Parameters.AddWithValue("@maHS", maHS);
                int duplicateCount = (int)checkDuplicateCmd.ExecuteScalar();

                if (duplicateCount > 0)
                {
                    MessageBox.Show("Mã học sinh đã tồn tại, vui lòng nhập lại thông tin và bấm nút cập nhật !");
                    
                }


                string str = "INSERT INTO HOCSINH VALUES (@maHS, @tenHS, @ngaysinh, @diachi, @dtb, @malop)";
                SqlCommand cmd = new SqlCommand(str, conn);
                cmd.Parameters.AddWithValue("@maHS", maHS);
                cmd.Parameters.AddWithValue("@tenHS", tenHS);
                cmd.Parameters.AddWithValue("@ngaysinh", ngaysinh);
                cmd.Parameters.AddWithValue("@diachi", diachi);
                cmd.Parameters.AddWithValue("@dtb", dtb);
                cmd.Parameters.AddWithValue("@malop", malop);

                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Thêm dữ liệu thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm dữ liệu bị lỗi \n" + ex.ToString());
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            maHS = txtMahs.Text;
            if (string.IsNullOrEmpty(maHS))
            {
                MessageBox.Show("Vui lòng chọn mã học sinh để xóa!");
                return;
            }
            try
            {
                if(conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                string strSQL = "delete from HocSinh where maHS  = @maHS";
                SqlCommand cmd = new SqlCommand(strSQL, conn);
                cmd.Parameters.AddWithValue("@maHS", maHS);

                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Xóa dữ liệu thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xóa bị lỗi: " + ex.ToString());
            }

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Bạn có chắc chắn muốn thoát","Thoát",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(res == DialogResult.Yes)
            {
                Close();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            maHS = txtMahs.Text;
            tenHS = txtTenhs.Text;
            ngaysinh = dtpNgaysinh.Value;

            diachi = txtDiaChi.Text;

            malop = cmbLop.SelectedValue.ToString();
            dtb = Convert.ToDouble(txtDiemTB.Text);
            string str = "UPDATE HOCSINH SET TenHS = @TenHS, NgaySinh = @NgaySinh, DiaChi = @DiaChi, DTB = @DTB, MaLop = @MaLop WHERE MaHS = @MaHS";
            SqlCommand cmd = new SqlCommand(str, conn);
            cmd.Parameters.AddWithValue("@TenHS", tenHS);
            cmd.Parameters.AddWithValue("@NgaySinh", ngaysinh);
            cmd.Parameters.AddWithValue("@DiaChi", diachi);
            cmd.Parameters.AddWithValue("@DTB", dtb);
            cmd.Parameters.AddWithValue("@MaLop", malop);
            cmd.Parameters.AddWithValue("@MaHS", maHS);
            cmd.ExecuteNonQuery();
            
            MessageBox.Show("Cập nhật dữ liệu thành công");
            conn.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
            connect();
            DataTable dt = getDslop();
            cmbLop.DataSource = dt;
            cmbLop.DisplayMember = "TenLop";
            cmbLop.ValueMember = "MaLop";
            
           



        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
         
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                txtMahs.Text = row.Cells["MaHS"].Value.ToString();
                txtTenhs.Text = row.Cells["TenHS"].Value.ToString();
                dtpNgaysinh.Value = Convert.ToDateTime(row.Cells["NgaySinh"].Value);
                txtDiaChi.Text = row.Cells["DiaChi"].Value.ToString();
                txtDiemTB.Text = row.Cells["DTB"].Value.ToString();
                cmbLop.Text= row.Cells["Tenlop"].Value.ToString();
            }
        }




    }
}
