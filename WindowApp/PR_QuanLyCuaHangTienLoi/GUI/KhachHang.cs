using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;

namespace GUI
{
    public partial class KhachHang : Form
    {
        KhachHangDTO khachhang = new KhachHangDTO();
        KhachHangBLL khBLL = new KhachHangBLL();

        public KhachHang()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void hệThốngToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void KhachHang_Load(object sender, EventArgs e)
        {
            dataGridView_kh.DataSource = KhachHangBLL.GetAllKhachHang();
            dataGridView_kh.Columns[0].HeaderText = "Mã KH";
            dataGridView_kh.Columns[0].MinimumWidth = 150;
            dataGridView_kh.Columns[1].HeaderText = "Họ tên";
            dataGridView_kh.Columns[1].MinimumWidth = 250;
            dataGridView_kh.Columns[2].HeaderText = "Giới tính";
            dataGridView_kh.Columns[2].MinimumWidth = 100;
            dataGridView_kh.Columns[3].HeaderText = "Ngày sinh";
            dataGridView_kh.Columns[3].MinimumWidth = 150;
            dataGridView_kh.Columns[4].HeaderText = "Địa chỉ";
            dataGridView_kh.Columns[4].MinimumWidth = 300;
            dataGridView_kh.Columns[5].HeaderText = "Số điện thoại";
            dataGridView_kh.Columns[5].MinimumWidth = 150;
            dataGridView_kh.Columns[6].HeaderText = "Email";
            dataGridView_kh.Columns[6].MinimumWidth = 250;
            dataGridView_kh.Columns[7].HeaderText = "Hình ảnh";
            dataGridView_kh.Columns[7].MinimumWidth = 400;
        }

        private void dataGridView_kh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int option_click = e.RowIndex;
            textBox_nv_makh.Text = dataGridView_kh[0, option_click].Value.ToString();
            textBox_nv_tenkh.Text = dataGridView_kh[1, option_click].Value.ToString();
            if (dataGridView_kh[2,option_click].Value.ToString() == "Nam")
            {
                radioButton1.Checked = true;
                radioButton2.Checked = false;
            }
            else if(dataGridView_kh[2, option_click].Value.ToString() == "Nữ")
            {
                radioButton1.Checked = false;
                radioButton2.Checked = true;
            }
            else
            {
                radioButton1.Checked = false;
                radioButton2.Checked = false;
            }
            dateTimePicker_ns.Text = dataGridView_kh[3, option_click].Value.ToString();
            textBox_kh_dc.Text = dataGridView_kh[4, option_click].Value.ToString();
            textBox_kh_sdt.Text = dataGridView_kh[5, option_click].Value.ToString();
            textBox_kh_email.Text = dataGridView_kh[6, option_click].Value.ToString();
            textBox_kh_link.Text = dataGridView_kh[7, option_click].Value.ToString();
            if (dataGridView_kh[7, option_click].Value.ToString() != "")
            {
                pictureBox_kh.LoadAsync(dataGridView_kh[7, option_click].Value.ToString());
            }
            else
            {
                pictureBox_kh.LoadAsync("https://png.pngtree.com/png-vector/20190411/ourlarge/pngtree-vector-businessman-icon-png-image_924876.jpg");
            }
            
        }

        // Button Add
        private void button_nv_them_Click(object sender, EventArgs e)
        {
            // Add Info KhachHang
            khachhang.MaKhachHang = textBox_nv_makh.Text;
            khachhang.HoTen = textBox_nv_tenkh.Text;
            if(radioButton1.Checked == true)
            {
                khachhang.GioiTinh = "Nam";
            }else if(radioButton2.Checked == true)
            {
                khachhang.GioiTinh = "Nữ";
            }
            else
            {
                khachhang.GioiTinh = "";
            }
            khachhang.NgaySinh = dateTimePicker_ns.Value;
            khachhang.DiaChi = textBox_kh_dc.Text;
            khachhang.SoDienThoai = textBox_kh_sdt.Text;
            khachhang.Email = textBox_kh_email.Text;
            khachhang.HinhAnh = textBox_kh_link.Text;
            string addkh = khBLL.AddKhachHang(khachhang);
            // phan hoi nguoi dung neu nghiep vu khong dung
            switch (addkh)
            {
                case "require_MaKhachHang":
                    MessageBox.Show("Mã khách hàng không được để trống");
                    return;
                case "require_HoTen":
                    MessageBox.Show("Tên khách hàng không được để trống");
                    return;
                case "failure":
                    MessageBox.Show("Thêm khách hàng thất bại, bạn hãy thử lại !");
                    return;

            }
            MessageBox.Show("Thêm khách hàng thành công");
            // Refresh datagridview
            dataGridView_kh.DataSource = KhachHangBLL.GetAllKhachHang();

        }
        // Refresh Datagridview
        private void button_nv_tc_Click(object sender, EventArgs e)
        {
            dataGridView_kh.DataSource = KhachHangBLL.GetAllKhachHang();
        }

        // Button cancel
        private void button_nv_huybo_Click(object sender, EventArgs e)
        {
            textBox_nv_makh.Text = "";
            textBox_nv_tenkh.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            dateTimePicker_ns.Text = DateTime.Now.ToString();
            textBox_kh_dc.Text = "";
            textBox_kh_sdt.Text = "";
            textBox_kh_email.Text = "";
            textBox_kh_link.Text = "";
            pictureBox_kh.LoadAsync("https://png.pngtree.com/png-vector/20190411/ourlarge/pngtree-vector-businessman-icon-png-image_924876.jpg");


        }

        // Button Update
        private void button_nv_luu_Click(object sender, EventArgs e)
        {
            // Add Info KhachHang
            khachhang.MaKhachHang = textBox_nv_makh.Text;
            khachhang.HoTen = textBox_nv_tenkh.Text;
            if (radioButton1.Checked == true)
            {
                khachhang.GioiTinh = "Nam";
            }
            else if (radioButton2.Checked == true)
            {
                khachhang.GioiTinh = "Nữ";
            }
            else
            {
                khachhang.GioiTinh = "";
            }
            khachhang.NgaySinh = dateTimePicker_ns.Value;
            khachhang.DiaChi = textBox_kh_dc.Text;
            khachhang.SoDienThoai = textBox_kh_sdt.Text;
            khachhang.Email = textBox_kh_email.Text;
            khachhang.HinhAnh = textBox_kh_link.Text;
            string updatekh = khBLL.UpdateKhachHang(khachhang);
            // phan hoi nguoi dung neu nghiep vu khong dung
            switch (updatekh)
            {
                case "require_MaKhachHang":
                    MessageBox.Show("Mã khách hàng không được để trống");
                    return;
                case "failure":
                    MessageBox.Show("Cập nhật khách hàng thất bại, bạn hãy thử lại !");
                    return;

            }
            MessageBox.Show("Cập nhật khách hàng thành công");
            // Refresh datagridview
            dataGridView_kh.DataSource = KhachHangBLL.GetAllKhachHang();
        }

        // Button Delete
        private void button_nv_xoa_Click(object sender, EventArgs e)
        {
            // Add Info KhachHang
            khachhang.MaKhachHang = textBox_nv_makh.Text;
            string deletekh = khBLL.DeleteKhachHang(khachhang);
            // phan hoi nguoi dung neu nghiep vu khong dung
            switch (deletekh)
            {
                case "require_MaKhachHang":
                    MessageBox.Show("Mã khách hàng không được để trống");
                    return;
                case "failure":
                    MessageBox.Show("Xóa khách hàng thất bại, bạn hãy thử lại !");
                    return;

            }
            MessageBox.Show("Xóa khách hàng thành công");
            // Refresh datagridview
            dataGridView_kh.DataSource = KhachHangBLL.GetAllKhachHang();
        }

        // Button Search
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_nv_timkiem_Click(object sender, EventArgs e)
        {
            // Add Info NhanVien
            khachhang.HoTen = textBox_kh_timkiem.Text;
            // Search NhanVien
            dataGridView_kh.DataSource = KhachHangBLL.searchKhachHang(khachhang);
        }
    }
}
