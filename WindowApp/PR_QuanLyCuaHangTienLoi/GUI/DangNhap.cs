using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using DTO;
using BLL;

namespace GUI
{
    public partial class DangNhap : Form
    {
        TaiKhoan taikhoan = new TaiKhoan();
        TaiKhoanBLL tkBLL = new TaiKhoanBLL();

        public DangNhap()
        {
            InitializeComponent();
            this.txtTenDangNhap.Clear();
            this.txtMatKhau.Clear();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult q = MessageBox.Show("Bạn Có Muốn Thoát Không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (q.Equals(DialogResult.Yes))
            {
                this.Close();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            this.txtTenDangNhap.Clear();
            this.txtMatKhau.Clear();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            taikhoan.TenTaiKhoan = txtTenDangNhap.Text;
            taikhoan.MatKhau = txtMatKhau.Text;

            string getuser = tkBLL.CheckLogin(taikhoan);

            // phan hoi nguoi dung neu nghiep vu khong dung
            switch (getuser)
            {
                case "require_taikhoan":
                    MessageBox.Show("Tài khoản không được để trống");
                    return;
                case "require_matkhau":
                    MessageBox.Show("Mật khẩu không được để trống");
                    return;
                case "Tài khoản hoặc mật khẩu không chính xác":
                    MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác");
                    return;

            }
            MessageBox.Show("Đăng nhập thành công");
               
            Form fm = new TrangChu();
            fm.Show();
            this.Hide();
        }
    }
}
