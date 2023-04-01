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
using System.Data.SqlClient;

namespace GUI
{
    public partial class NhanVien : Form
    {
        NhanVienDTO nhanvien = new NhanVienDTO();
        NhanVienBLL nvBLL = new NhanVienBLL();

        public NhanVien()
        {
            InitializeComponent();
        }

        // Datagridview Click
        private void dataGridView_nv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int option_click = e.RowIndex;
            textBox_nv_manv.Text = dataGridView_nv[0, option_click].Value.ToString();
            textBox_nv_tennv.Text = dataGridView_nv[1, option_click].Value.ToString();
            if (dataGridView_nv[2, option_click].Value.ToString() == "Nam")
            {
                radioButton2.Checked = false;
                radioButton1.Checked = true;
            }
            if (dataGridView_nv[2, option_click].Value.ToString() == "Nữ")
            {
                radioButton2.Checked = true;
                radioButton1.Checked = false;
            }
            if (dataGridView_nv[2, option_click].Value.ToString() == "")
            {
                radioButton2.Checked = false;
                radioButton1.Checked = false;
            }
            textBox_nv_dc.Text = dataGridView_nv[4, option_click].Value.ToString();
            textBox_nv_quequan.Text = dataGridView_nv[5, option_click].Value.ToString();
            textBox_nv_sdt.Text = dataGridView_nv[6, option_click].Value.ToString();
            textBox_nv_email.Text = dataGridView_nv[7, option_click].Value.ToString();
            textBox_nv_link.Text = dataGridView_nv[8, option_click].Value.ToString();
            if(textBox_nv_link.Text == "")
            {
                pictureBox_bh.LoadAsync("https://png.pngtree.com/png-vector/20190411/ourlarge/pngtree-vector-businessman-icon-png-image_924876.jpg");
            }
            else
            {
                pictureBox_bh.LoadAsync(textBox_nv_link.Text);
            }
            dateTimePicker_ns.Text = dataGridView_nv[3,option_click].Value.ToString();

        }

        private void label_nv_macv_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        // Exit
        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // Form Load
        private void NhanVien_Load(object sender, EventArgs e)
        {
            dataGridView_nv.DataSource = NhanVienBLL.GetAllNhanVien();
            dataGridView_nv.Columns[0].HeaderText = "Mã NV";
            dataGridView_nv.Columns[0].MinimumWidth = 150;
            dataGridView_nv.Columns[1].HeaderText = "Họ tên";
            dataGridView_nv.Columns[1].MinimumWidth = 200;
            dataGridView_nv.Columns[2].HeaderText = "Giới tính";
            dataGridView_nv.Columns[2].MinimumWidth = 100;
            dataGridView_nv.Columns[3].HeaderText = "Ngày sinh";
            dataGridView_nv.Columns[3].MinimumWidth = 150;
            dataGridView_nv.Columns[4].HeaderText = "Địa chỉ";
            dataGridView_nv.Columns[4].MinimumWidth = 300;
            dataGridView_nv.Columns[5].HeaderText = "Quê quán";
            dataGridView_nv.Columns[5].MinimumWidth = 150;
            dataGridView_nv.Columns[6].HeaderText = "Số điện thoại";
            dataGridView_nv.Columns[6].MinimumWidth = 150;
            dataGridView_nv.Columns[7].HeaderText = "Email";
            dataGridView_nv.Columns[7].MinimumWidth = 250;
            dataGridView_nv.Columns[8].HeaderText = "Hình ảnh";
            dataGridView_nv.Columns[8].MinimumWidth = 300;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        // Button Add 
        private void button_nv_them_Click(object sender, EventArgs e)
        {
            // Add Info NhanVien
            nhanvien.MaNhanVien = textBox_nv_manv.Text;
            nhanvien.HoTen = textBox_nv_tennv.Text;
            if(radioButton1.Checked == true)
            {
                nhanvien.GioiTinh = "Nam";
            }
            if (radioButton2.Checked == true)
            {
                nhanvien.GioiTinh = "Nữ";
            }
            nhanvien.GioiTinh = "";
            nhanvien.NgaySinh = dateTimePicker_ns.Value;
            nhanvien.DiaChi = textBox_nv_dc.Text;
            nhanvien.QueQuan = textBox_nv_quequan.Text;
            nhanvien.SoDienThoai = textBox_nv_sdt.Text; 
            nhanvien.Email = textBox_nv_email.Text;
            nhanvien.HinhAnh = textBox_nv_link.Text;
            string addnv = nvBLL.AddNhanVien(nhanvien);
            // phan hoi nguoi dung neu nghiep vu khong dung
            switch (addnv)
            {
                case "require_MaNhanVien":
                    MessageBox.Show("Mã nhân viên không được để trống");
                    return;
                case "require_HoTen":
                    MessageBox.Show("Tên nhân viên không được để trống");
                    return;
                case "failure":
                    MessageBox.Show("Thêm nhân viên thất bại, bạn hãy thử lại !");
                    return;

            }
            MessageBox.Show("Thêm nhân viên thành công");
            // Refresh datagridview
            dataGridView_nv.DataSource = NhanVienBLL.GetAllNhanVien();

        }

        // Button Cancel 
        private void button_nv_huybo_Click(object sender, EventArgs e)
        {
            textBox_nv_manv.Text = "";
            textBox_nv_tennv.Text = "";
            textBox_nv_sdt.Text = "";
            textBox_nv_email.Text = "";
            textBox_nv_link.Text = "";
            textBox_nv_quequan.Text = "";
            textBox_nv_dc.Text = "";
            dateTimePicker_ns.Text = DateTime.Now.ToString();
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            pictureBox_bh.LoadAsync("https://png.pngtree.com/png-vector/20190411/ourlarge/pngtree-vector-businessman-icon-png-image_924876.jpg");
            
        }

        // Button ReFresh
        private void button_nv_lammoi_Click(object sender, EventArgs e)
        {
            dataGridView_nv.DataSource = NhanVienBLL.GetAllNhanVien();
        }

        // Button Update or Save
        private void button_nv_luu_Click(object sender, EventArgs e)
        {
            // Update Info NhanVien
            nhanvien.MaNhanVien = textBox_nv_manv.Text;
            nhanvien.HoTen = textBox_nv_tennv.Text;
            if (radioButton1.Checked == true)
            {
                nhanvien.GioiTinh = "Nam";
            }
            else if (radioButton2.Checked == true)
            {
                nhanvien.GioiTinh = "Nữ";
            }
            else
            {
                nhanvien.GioiTinh = "";
            }
            
            nhanvien.NgaySinh = dateTimePicker_ns.Value;
            nhanvien.DiaChi = textBox_nv_dc.Text;
            nhanvien.QueQuan = textBox_nv_quequan.Text;
            nhanvien.SoDienThoai = textBox_nv_sdt.Text;
            nhanvien.Email = textBox_nv_email.Text;
            nhanvien.HinhAnh = textBox_nv_link.Text;
            string updatenv = nvBLL.UpdateNhanVien(nhanvien);
            // phan hoi nguoi dung neu nghiep vu khong dung
            switch (updatenv)
            {
                case "require_MaNhanVien":
                    MessageBox.Show("Mã nhân viên không được để trống");
                    return;
                case "failure":
                    MessageBox.Show("Cập nhật nhân viên thất bại, bạn hãy thử lại !");
                    return;

            }
            MessageBox.Show("Cập nhật nhân viên thành công");
            // Refresh datagridview
            dataGridView_nv.DataSource = NhanVienBLL.GetAllNhanVien();
        }

        // Button Delete
        private void button_nv_xoa_Click(object sender, EventArgs e)
        {
            // Add Info NhanVien
            nhanvien.MaNhanVien = textBox_nv_manv.Text;
            // Delete NhanVien
            string deletenv = nvBLL.DeleteNhanVien(nhanvien);
            // phan hoi nguoi dung neu nghiep vu khong dung
            switch (deletenv)
            {
                case "require_MaNhanVien":
                    MessageBox.Show("Mã nhân viên không được để trống");
                    return;
                case "failure":
                    MessageBox.Show("Xóa nhân viên thất bại, mời bạn thử lại !");
                    return;
            }
            
            MessageBox.Show("Xóa nhân viên thành công");
            // Refresh datagridview
            dataGridView_nv.DataSource = NhanVienBLL.GetAllNhanVien();
        }

        
        private void textBox_nv_timkiem_TextChanged(object sender, EventArgs e)
        {

        }
        // Button tim kiem
        private void button_nv_timkiem_Click(object sender, EventArgs e)
        {
            // Add Info NhanVien
            nhanvien.HoTen = textBox_nv_timkiem.Text;
            // Search NhanVien
            dataGridView_nv.DataSource = NhanVienBLL.searchNhanVien(nhanvien);
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form fm = new DangNhap();
            fm.Show();
        }

        private void hàngHóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form fm = new SanPham();
            fm.Show();
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form fm = new KhachHang();
            fm.Show();
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form fm = new TheKhachhang();
            fm.Show();
        }

        private void nhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form fm = new NhaCungCap();
            fm.Show();
        }

        private void khuyễnMãiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form fm = new KhuyenMai();
            fm.Show();
        }
    }
}
