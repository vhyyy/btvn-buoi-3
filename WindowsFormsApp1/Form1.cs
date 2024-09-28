using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            // Tạo instance của Form2 (form nhập nhân viên)
            Form2 form2 = new Form2();

            // Hiển thị Form2 dưới dạng modal (không cho phép tương tác với Form1 cho đến khi Form2 đóng)
            form2.ShowDialog();

            // Nếu Form2 trả về DialogResult.OK, nghĩa là đã thêm dữ liệu thành công
            if (form2.DialogResult == DialogResult.OK)
            {
                // Lấy thông tin từ Form2 và thêm vào DataGridView
                string msnv = form2.MSNV;
                string tenNV = form2.TenNV;
                string luongCB = form2.LuongCB;

                // Thêm thông tin vào DataGridView (giả sử cột 0 là MSNV, cột 1 là Tên NV, cột 2 là Lương CB)
                dataGridView1.Rows.Add(msnv, tenNV, luongCB);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Lấy thông tin của dòng được chọn
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                string msnv = selectedRow.Cells[0].Value.ToString();
                string tenNV = selectedRow.Cells[1].Value.ToString();
                string luongCB = selectedRow.Cells[2].Value.ToString();

                // Mở Form2 và truyền thông tin cần sửa vào
                Form2 form2 = new Form2(msnv, tenNV, luongCB);
                form2.ShowDialog();

                // Nếu sửa thành công
                if (form2.DialogResult == DialogResult.OK)
                {
                    // Cập nhật lại thông tin trong DataGridView
                    selectedRow.Cells[0].Value = form2.MSNV;
                    selectedRow.Cells[1].Value = form2.TenNV;
                    selectedRow.Cells[2].Value = form2.LuongCB;
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một nhân viên để sửa.");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có dòng nào được chọn hay không
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Xác nhận việc xóa
                var confirmResult = MessageBox.Show("Bạn có chắc chắn muốn xóa nhân viên này không?", "Xác nhận xóa", MessageBoxButtons.YesNo);

                if (confirmResult == DialogResult.Yes)
                {
                    // Xóa dòng đã chọn
                    foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                    {
                        dataGridView1.Rows.Remove(row);
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một nhân viên để xóa.");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Đóng form
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
