using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Lab05_Bo_Sung
{
    public partial class frmBoSung : Form
    {
        // Tạo một bản sao của DataTable để lưu trữ dữ liệu ban đầu
        DataTable originalTable;
        DataTable table = new DataTable();

        public frmBoSung()
        {
            InitializeComponent();
        }

        private void cboHangsx_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedManufacturer = cboHangsx.SelectedItem.ToString();
            List<string> productCodes = new List<string>();

            // Nếu người dùng chọn "Tất cả", hiển thị tất cả sản phẩm
            if (selectedManufacturer == "Tất cả")
            {
                table.Rows.Clear(); // Xóa các dòng hiện tại
                table.Merge(originalTable); // Sử dụng bản sao để tái tạo dữ liệu ban đầu
            }
            else
            {
                table.Rows.Clear(); // Xóa các dòng hiện tại

                // Lọc các sản phẩm theo hãng sản xuất được chọn
                foreach (DataRow row in originalTable.Rows)
                {
                    if (row["Sản Phẩm"].ToString().StartsWith(selectedManufacturer))
                    {
                        table.ImportRow(row); // Thêm dòng vào DataTable
                        productCodes.Add(row["Mã Định danh"].ToString()); // Thêm mã định danh vào danh sách
                    }
                }
            }
            cboDongsp.DataSource = productCodes;
            txtSoLuong.Text = dataGridView1.Rows.Count.ToString();
        }

        private void cboDongsp_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedProductCode = cboDongsp.SelectedItem.ToString();
            table.Rows.Clear(); // Xóa các dòng hiện tại

            // Lọc dữ liệu từ DataTable dựa trên mã định danh được chọn
            foreach (DataRow row in originalTable.Rows)
            {
                if (row["Mã Định danh"].ToString() == selectedProductCode)
                {
                    table.ImportRow(row); // Thêm dòng vào DataTable
                }
            }
        }

        private void frmBoSung_Load(object sender, EventArgs e)
        {
            table.Columns.Add("Sản Phẩm", typeof(string));
            table.Columns.Add("Mã Định danh", typeof(string));
            table.Columns.Add("Thông số Kỹ thuật", typeof(string));
            table.Columns.Add("Giá bán", typeof(double));

            dataGridView1.DataSource = table;

            // Tạo bản sao của DataTable
            originalTable = table.Clone();

            string[] lines = File.ReadAllLines(@"R:\App_Details\Visual_Studio\WorkSpace_C_Sharp\ThucHanh_WindowForm\Lab04\List.txt");

            foreach (string line in lines)
            {
                string[] values = line.Split('|');

                if (values.Length == table.Columns.Count)
                {
                    table.Rows.Add(values);
                    originalTable.Rows.Add(values); // Thêm dòng vào bản sao
                }
                else
                {
                    MessageBox.Show("Lỗi: Dòng không đúng định dạng. Dữ liệu không được thêm vào.");
                }
            }
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

        }
    }
}
