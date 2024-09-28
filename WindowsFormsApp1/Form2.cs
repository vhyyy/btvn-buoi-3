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
    public partial class Form2 : Form
    {
        // Thuộc tính để truyền thông tin giữa các form
        public string MSNV { get; set; }
        public string TenNV { get; set; }
        public string LuongCB { get; set; }
        public Form2()
        {
            InitializeComponent();
        }
        public Form2(string msnv, string tenNV, string luongCB) : this()
        {
            txtMSNV.Text = msnv;
            txtTenNV.Text = tenNV;
            txtLuongCB.Text = luongCB;
        }

        private void btnDongY_Click(object sender, EventArgs e)
        {
            // Lấy thông tin từ các TextBox
            MSNV = txtMSNV.Text;
            TenNV = txtTenNV.Text;
            LuongCB = txtLuongCB.Text;

            // Đặt DialogResult thành OK để thông báo với Form1 rằng dữ liệu đã sẵn sàng
            this.DialogResult = DialogResult.OK;

            // Đóng form
            this.Close();
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            // Đóng form mà không làm gì cả
            this.Close();
        }

        private void txtMSNV_KeyDown(object sender, KeyEventArgs e)
        {
             if (e.KeyCode == Keys.Enter)
                if (e.KeyCode == Keys.Enter)
                {
                    // Di chuyển đến TextBox tiếp theo
                    this.SelectNextControl((Control)sender, true, true, true, true);
                    e.SuppressKeyPress = true; // Ngăn âm thanh "beep"
                }
        }

        private void txtTenNV_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
                e.SuppressKeyPress = true;
            }
        }

        private void txtLuongCB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Nếu nhấn Enter trên TextBox lương, gọi hàm thêm
                btnDongY_Click(sender, e); // Gọi hàm lưu dữ liệu
                e.SuppressKeyPress = true; // Ngăn chặn âm thanh "beep"
            }
        }
    }
}
