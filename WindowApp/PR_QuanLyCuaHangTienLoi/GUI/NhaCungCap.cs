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
using BLL;
using DTO;

namespace GUI
{
    public partial class NhaCungCap : Form
    {
        // Khoi tao doi tuong
        NhaCungCapDTO nhacungcap = new NhaCungCapDTO();
        NhaCungCapBLL nccBLL = new NhaCungCapBLL();
        
        public NhaCungCap()
        {
            InitializeComponent();
            textBox_ncc_mancc.Text = string.Empty;
            textBox_ncc_tenncc.Text = string.Empty;
            textBox_ncc_dc.Text = string.Empty;
            textBox_ncc_sdt.Text = string.Empty;
            textBox_ncc_email.Text = string.Empty;
            textBox_ncc_hinh.Text = string.Empty;
        }

        private void textBox_nv_tennv_TextChanged(object sender, EventArgs e)
        {
            
        }

        // Click to column in DataGridview
        private void dataGridView_nv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int option_click = e.RowIndex;
            textBox_ncc_mancc.Text = dataGridView_ncc[0, option_click].Value.ToString();
            textBox_ncc_tenncc.Text = dataGridView_ncc[1, option_click].Value.ToString();
            textBox_ncc_dc.Text = dataGridView_ncc[2, option_click].Value.ToString();
            textBox_ncc_sdt.Text = dataGridView_ncc[3, option_click].Value.ToString();
            textBox_ncc_email.Text = dataGridView_ncc[4, option_click].Value.ToString();
            textBox_ncc_hinh.Text = dataGridView_ncc[5,option_click].Value.ToString();
            if(textBox_ncc_hinh.Text != "")
            {
                pictureBox_ncc_hinhanh.LoadAsync(textBox_ncc_hinh.Text);
            }
            else
            {
                pictureBox_ncc_hinhanh.CancelAsync();
            }
            

        }

        private void hệThốngToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        // Form load
        private void NhaCungCap_Load(object sender, EventArgs e)
        {
            dataGridView_ncc.DataSource = NhaCungCapBLL.GetAllNhaCungCap();
            dataGridView_ncc.Columns[0].HeaderText = "Mã NCC";
            dataGridView_ncc.Columns[0].MinimumWidth = 150;
            dataGridView_ncc.Columns[1].HeaderText = "Tên NCC";
            dataGridView_ncc.Columns[1].MinimumWidth = 250;
            dataGridView_ncc.Columns[2].HeaderText = "Địa chỉ";
            dataGridView_ncc.Columns[2].MinimumWidth = 400;
            dataGridView_ncc.Columns[3].HeaderText = "Số điện thoại";
            dataGridView_ncc.Columns[3].MinimumWidth = 150;
            dataGridView_ncc.Columns[4].HeaderText = "Email";
            dataGridView_ncc.Columns[4].MinimumWidth = 250;
            dataGridView_ncc.Columns[5].HeaderText = "Hình ảnh";
            dataGridView_ncc.Columns[5].MinimumWidth = 300;
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        // Exit app
        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Button cancel
        private void button_ncc_huybo_Click(object sender, EventArgs e)
        {
            textBox_ncc_mancc.Text = "";
            textBox_ncc_tenncc.Text = "";
            textBox_ncc_dc.Text = "";
            textBox_ncc_sdt.Text = "";
            textBox_ncc_email.Text = "";
            textBox_ncc_hinh.Text = "";
            pictureBox_ncc_hinhanh.LoadAsync();
            
        }

        // Button Refresh
        private void button_ncc_quaylai_Click(object sender, EventArgs e)
        {
            dataGridView_ncc.DataSource = NhaCungCapBLL.GetAllNhaCungCap();
        }
        
        // Button add
        private void button_ncc_them_Click(object sender, EventArgs e)
        {

            // Add NhaCungCap
            nhacungcap.MaNhaCungCap = textBox_ncc_mancc.Text;
            nhacungcap.TenNhaCungCap = textBox_ncc_tenncc.Text;
            nhacungcap.DiaChi = textBox_ncc_dc.Text;
            nhacungcap.SoDienThoai = textBox_ncc_sdt.Text;
            nhacungcap.Email = textBox_ncc_email.Text;
            nhacungcap.HinhAnh = textBox_ncc_hinh.Text;
            string addncc = nccBLL.AddNhaCungCap(nhacungcap);
            // phan hoi nguoi dung neu nghiep vu khong dung
            switch (addncc)
            {
                case "require_MaNhaCungCap":
                    MessageBox.Show("Mã nhà cung cấp không được để trống");
                    return;
                case "require_TenNhaCungCap":
                    MessageBox.Show("Tên nhà cung cấp không được để trống");
                    return;

            }
            MessageBox.Show("Thêm nhà cung cấp thành công");

            // Refresh datagridview
            dataGridView_ncc.DataSource = NhaCungCapBLL.GetAllNhaCungCap();
        }

        // Button delete
        private void button_ncc_xoa_Click(object sender, EventArgs e)
        {
            // Add NhaCungCap
            nhacungcap.MaNhaCungCap = textBox_ncc_mancc.Text;
            string deletencc = nccBLL.DeleteNhaCungCap(nhacungcap);
            // phan hoi nguoi dung neu nghiep vu khong dung
            switch (deletencc)
            {
                case "require_MaNhaCungCap":
                    MessageBox.Show("Mã nhà cung cấp không được để trống");
                    return;

            }
            MessageBox.Show("Xóa nhà cung cấp thành công");

            // Refresh datagridview
            dataGridView_ncc.DataSource = NhaCungCapBLL.GetAllNhaCungCap();
        }

        // Button update or save
        private void button_ncc_luu_Click(object sender, EventArgs e)
        {
            // Add NhaCungCap
            nhacungcap.MaNhaCungCap = textBox_ncc_mancc.Text;
            nhacungcap.TenNhaCungCap = textBox_ncc_tenncc.Text;
            nhacungcap.DiaChi = textBox_ncc_dc.Text;
            nhacungcap.SoDienThoai = textBox_ncc_sdt.Text;
            nhacungcap.Email = textBox_ncc_email.Text;
            nhacungcap.HinhAnh = textBox_ncc_hinh.Text;
            string updatencc = nccBLL.UpdateNhaCungCap(nhacungcap);
            // phan hoi nguoi dung neu nghiep vu khong dung
            switch (updatencc)
            {
                case "require_MaNhaCungCap":
                    MessageBox.Show("Mã nhà cung cấp không được để trống");
                    return;

            }
            MessageBox.Show("Cập nhật nhà cung cấp thành công");

            // Refresh datagridview
            dataGridView_ncc.DataSource = NhaCungCapBLL.GetAllNhaCungCap();

        }

        private void button_ncc_timkiem_Click(object sender, EventArgs e)
        {
            // Add NhaCungCap
            nhacungcap.TenNhaCungCap = textBox_timkiem.Text;
            // Refresh datagridview
            dataGridView_ncc.DataSource = NhaCungCapBLL.SearchNhaCungCap(nhacungcap);

        }

        private void textBox_timkiem_TextChanged(object sender, EventArgs e)
        {

        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form fm = new DangNhap();
            fm.Show();

        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form fm = new KhachHang();
            fm.Show();
        }

        private void nhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form fm = new TheKhachhang();
            fm.Show();
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form fm = new NhanVien();
            fm.Show();
        }

        private void hàngHóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form fm = new SanPham();
            fm.Show();
        }

        private void khuyếnMãiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form fm = new KhuyenMai();
            fm.Show();
        }
    }
}
