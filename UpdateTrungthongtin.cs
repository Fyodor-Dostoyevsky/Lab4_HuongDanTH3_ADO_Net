using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4_HuongDanTH3_ADO_Net
{
    public partial class UpdateTrungthongtin : Form
    {
        private SqlConnection conn;
        private string maHS;
        public UpdateTrungthongtin(string maHS)
        {
            InitializeComponent();
            this.maHS = maHS;
            conn = new SqlConnection(@"Data Source=LAPTOP-78LVMDCQ;Initial Catalog=QLHOCSINH;Integrated Security=True;");
            LoadData();
        }

        private void LoadData()
        {
            string sql = "SELECT * FROM HOCSINH WHERE maHS = @maHS";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@maHS", maHS);
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                txtTenhsU.Text = dt.Rows[0]["TenHS"].ToString();
                dtpNgaysinhU.Value = Convert.ToDateTime(dt.Rows[0]["NgaySinh"]);
                txtDiaChiU.Text = dt.Rows[0]["DiaChi"].ToString();
                txtDiemTBU.Text = dt.Rows[0]["DTB"].ToString();
                cmbLopU.SelectedValue = dt.Rows[0]["MaLop"].ToString();
            }
        }

        private void txtTenhsU_TextChanged(object sender, EventArgs e)
        {
            if (conn.State != ConnectionState.Open)
                conn.Open();

            string sql = "UPDATE HOCSINH SET TenHS = @tenHS WHERE MaHS = @maHS";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@tenHS", txtTenhsU.Text);
            cmd.Parameters.AddWithValue("@maHS", txtMahsU.Text);
            cmd.ExecuteNonQuery();

            conn.Close();
        }

        private void txtDiaChiU_TextChanged(object sender, EventArgs e)
        {
            if (conn.State != ConnectionState.Open)
                conn.Open();

            string sql = "UPDATE HOCSINH SET DiaChi = @diaChi WHERE MaHS = @maHS";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@diaChi", txtDiaChiU.Text);
            cmd.Parameters.AddWithValue("@maHS", txtMahsU.Text);
            cmd.ExecuteNonQuery();

            conn.Close();
        }

        private void cmbLopU_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (conn.State != ConnectionState.Open)
                conn.Open();

            string sql = "UPDATE HOCSINH SET MaLop = @maLop WHERE MaHS = @maHS";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@maLop", cmbLopU.SelectedValue);
            cmd.Parameters.AddWithValue("@maHS", txtMahsU.Text);
            cmd.ExecuteNonQuery();

            conn.Close();
        }

        private void txtDiemTBU_TextChanged(object sender, EventArgs e)
        {
            if (conn.State != ConnectionState.Open)
                conn.Open();

            string sql = "UPDATE HOCSINH SET DTB = @dtb WHERE MaHS = @maHS";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@dtb", txtDiemTBU.Text);
            cmd.Parameters.AddWithValue("@maHS", txtMahsU.Text);
            cmd.ExecuteNonQuery();

            conn.Close();
        }

        private void txtMahs_TextChanged(object sender, EventArgs e)
        {

        }

        private void UpdateTrungthongtin_Load(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dtpNgaysinhU_ValueChanged(object sender, EventArgs e)
        {

        }

       
    }
}
