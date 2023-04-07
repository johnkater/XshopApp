using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class SanPham : Form
    {
        LoaiSanPhamDTO loaisanpham = new LoaiSanPhamDTO();
        SanPhamBLL spBLL = new SanPhamBLL();
        SanPhamDTO sanpham = new SanPhamDTO();

        public SanPham()
        {
            InitializeComponent();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
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
            Form fm = new KhuyenMai();
            fm.Show();
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form fm = new KhachHang();
            fm.Show();
        }

        private void thẻKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void nhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form fm = new NhaCungCap();
            fm.Show();
        }

        private void textBox_nv_tennv_TextChanged(object sender, EventArgs e)
        {

        }

        private void label_nv_tennv_Click(object sender, EventArgs e)
        {

        }

        private void label_nv_dc_Click(object sender, EventArgs e)
        {

        }

        // Form load
        private void SanPham_Load(object sender, EventArgs e)
        {
            // Datagridview LoaiSanPham
            dataGridView_lsp.DataSource = SanPhamBLL.GetAllLoaiSanPham();
            dataGridView_lsp.Columns[0].HeaderText = "Mã loại SP";
            dataGridView_lsp.Columns[0].MinimumWidth = 100;
            dataGridView_lsp.Columns[1].HeaderText = "Tên loại SP";
            dataGridView_lsp.Columns[1].MinimumWidth = 300;
            // Datagridview SanPham
            dataGridView_sp.DataSource = SanPhamBLL.GetAllSanPham();
            dataGridView_sp.Columns[0].HeaderText = "Mã SP";
            dataGridView_sp.Columns[0].MinimumWidth = 100;
            dataGridView_sp.Columns[1].HeaderText = "Mã vạch";
            dataGridView_sp.Columns[1].MinimumWidth = 100;
            dataGridView_sp.Columns[2].HeaderText = "Mã Loại SP";
            dataGridView_sp.Columns[2].MinimumWidth = 100;
            dataGridView_sp.Columns[3].HeaderText = "Tên loại SP";
            dataGridView_sp.Columns[3].MinimumWidth = 150;
            dataGridView_sp.Columns[4].HeaderText = "Tên SP";
            dataGridView_sp.Columns[4].MinimumWidth = 300;
            dataGridView_sp.Columns[5].HeaderText = "Giá bán";
            dataGridView_sp.Columns[5].MinimumWidth = 150;
            dataGridView_sp.Columns[6].HeaderText = "Đơn vị tính";
            dataGridView_sp.Columns[6].MinimumWidth = 100;
            dataGridView_sp.Columns[7].HeaderText = "NSX";
            dataGridView_sp.Columns[7].MinimumWidth = 150;
            dataGridView_sp.Columns[8].HeaderText = "HSD";
            dataGridView_sp.Columns[8].MinimumWidth = 150;
            dataGridView_sp.Columns[9].HeaderText = "Hình ảnh";
            dataGridView_sp.Columns[9].MinimumWidth = 200;
            dataGridView_sp.Columns[10].HeaderText = "Mã KM";
            dataGridView_sp.Columns[10].MinimumWidth = 100;
            dataGridView_sp.Columns[11].HeaderText = "Tên loại KM";
            dataGridView_sp.Columns[11].MinimumWidth = 200;
            dataGridView_sp.Columns[12].HeaderText = "Giá giảm";
            dataGridView_sp.Columns[12].MinimumWidth = 150;
            dataGridView_sp.Columns[13].HeaderText = "Ngày bắt đầu";
            dataGridView_sp.Columns[13].MinimumWidth = 150;
            dataGridView_sp.Columns[14].HeaderText = "Ngày kết thúc";
            dataGridView_sp.Columns[14].MinimumWidth = 150;

        }

        // Datagridview LoaiSanPham Click
        private void dataGridView_lsp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int option_click = e.RowIndex;
            textBox_lsp_maloai.Text = dataGridView_lsp[0, option_click].Value.ToString();
            textBox_lsp_tenloai.Text = dataGridView_lsp[1, option_click].Value.ToString();
        }

        // Refresh datagridview LoaiSanPham
        private void button_lkm_lammoi_Click(object sender, EventArgs e)
        {
            dataGridView_lsp.DataSource = SanPhamBLL.GetAllLoaiSanPham();
        }

        // Button add LoaiSanPham
        private void button_lkm_them_Click(object sender, EventArgs e)
        {
            // Add Info LoaiSanPham
            if (textBox_lsp_maloai.Text != "")
            {
                loaisanpham.MaLoaiSanPham = Convert.ToInt32(textBox_lsp_maloai.Text);
            }
            else
            {
                loaisanpham.MaLoaiSanPham = 0;
            }
            loaisanpham.TenLoaiSanPham = textBox_lsp_tenloai.Text;

            string addlsp = spBLL.AddLoaiSanPham(loaisanpham);
            // phan hoi nguoi dung neu nghiep vu khong dung
            switch (addlsp)
            {
                case "require_MaLoaiSanPham":
                    MessageBox.Show("Mã loại sản phẩm không được để trống");
                    return;
                case "require_TenLoaiSanPham":
                    MessageBox.Show("Tên loại sản phẩm không được để trống");
                    return;
                case "failure":
                    MessageBox.Show("Thêm loại sản phẩm thất bại, bạn hãy thử lại !");
                    return;

            }
            MessageBox.Show("Thêm loại sản phẩm thành công");
            // Refresh datagridview
            dataGridView_lsp.DataSource = SanPhamBLL.GetAllLoaiSanPham();
        }

        // Button update LoaiSanPham
        private void button_lkm_luu_Click(object sender, EventArgs e)
        {
            // Add Info LoaiSanPham
            if (textBox_lsp_maloai.Text != "")
            {
                loaisanpham.MaLoaiSanPham = Convert.ToInt32(textBox_lsp_maloai.Text);
            }
            else
            {
                loaisanpham.MaLoaiSanPham = 0;
            }
            loaisanpham.TenLoaiSanPham = textBox_lsp_tenloai.Text;

            string updatelsp = spBLL.UpdateLoaiSanPham(loaisanpham);
            // phan hoi nguoi dung neu nghiep vu khong dung
            switch (updatelsp)
            {
                case "require_MaLoaiSanPham":
                    MessageBox.Show("Mã loại sản phẩm không được để trống");
                    return;
                case "require_TenLoaiSanPham":
                    MessageBox.Show("Tên loại sản phẩm không được để trống");
                    return;
                case "failure":
                    MessageBox.Show("Cập nhật loại sản phẩm thất bại, bạn hãy thử lại !");
                    return;
            }
            MessageBox.Show("Cập nhật loại sản phẩm thành công");
            // Refresh datagridview
            dataGridView_lsp.DataSource = SanPhamBLL.GetAllLoaiSanPham();
        }

        // Button delete LoaiSanPham
        private void button_lkm_xoa_Click(object sender, EventArgs e)
        {
            // Add Info LoaiSanPham
            if (textBox_lsp_maloai.Text != "")
            {
                loaisanpham.MaLoaiSanPham = Convert.ToInt32(textBox_lsp_maloai.Text);
            }
            else
            {
                loaisanpham.MaLoaiSanPham = 0;
            }

            string deletelsp = spBLL.DeleteLoaiSanPham(loaisanpham);
            // phan hoi nguoi dung neu nghiep vu khong dung
            switch (deletelsp)
            {
                case "require_MaLoaiSanPham":
                    MessageBox.Show("Mã loại sản phẩm không được để trống");
                    return;
                case "failure":
                    MessageBox.Show("Xóa loại sản phẩm thất bại, bạn hãy thử lại !");
                    return;
            }
            MessageBox.Show("Xóa loại sản phẩm thành công");
            // Refresh datagridview
            dataGridView_lsp.DataSource = SanPhamBLL.GetAllLoaiSanPham();
        }

        // datagridview SanPham click
        private void dataGridView_sp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // 
            int option_click = e.RowIndex;
            textBox_sp_masp.Text = dataGridView_sp[0, option_click].Value.ToString();
            textBox_sp_mavach.Text = dataGridView_sp[1, option_click].Value.ToString();
            textBox_sp_maloai.Text = dataGridView_sp[2, option_click].Value.ToString();
            textBox_lsp_maloai.Text = dataGridView_sp[2, option_click].Value.ToString();
            textBox_lsp_tenloai.Text = dataGridView_sp[3, option_click].Value.ToString();
            textBox_sp_tensp.Text = dataGridView_sp[4, option_click].Value.ToString();
            textBox_sp_giaban.Text = dataGridView_sp[5, option_click].Value.ToString();
            textBox_sp_donvitinh.Text = dataGridView_sp[6, option_click].Value.ToString();     
            dateTimePicker_nsx.Text = dataGridView_sp[7, option_click].Value.ToString();
            dateTimePicker_hsd.Text = dataGridView_sp[8, option_click].Value.ToString();
            textBox_sp_hinh.Text = dataGridView_sp[9, option_click].Value.ToString();
            if(textBox_sp_hinh.Text != "")
            {
                pictureBox_sp.LoadAsync(textBox_sp_hinh.Text);
            }
            else
            {
                pictureBox_sp.LoadAsync("https://i.imgur.com/emQg1dY.png");
            }
            
            textBox_sp_makm.Text = dataGridView_sp[10, option_click].Value.ToString();
            

        }

        // Refresh datagridview SanPham
        private void button_sp_lammoi_Click(object sender, EventArgs e)
        {
            dataGridView_sp.DataSource = SanPhamBLL.GetAllSanPham();
        }

        // Button cancel 
        private void button_sp_huybo_Click(object sender, EventArgs e)
        {
            textBox_lsp_maloai.Text = "";
            textBox_lsp_tenloai.Text = "";

            textBox_sp_masp.Text = "";
            textBox_sp_mavach.Text = "";
            textBox_sp_maloai.Text = "";
            textBox_sp_giaban.Text = "";
            textBox_sp_donvitinh.Text = "";
            textBox_sp_hinh.Text = "";
            textBox_sp_makm.Text = "";
            textBox_sp_tensp.Text = "";
            textBox_sp_timkiem.Text = "";
            dateTimePicker_nsx.Value = DateTime.Now;
            dateTimePicker_hsd.Value = DateTime.Now;
        }

        // Button Search
        private void button_sp_timkiem_Click(object sender, EventArgs e)
        {
            // Add Info SanPham
            sanpham.TenSanPham = textBox_sp_timkiem.Text;
            // Refresh datagridview SanPham
            dataGridView_sp.DataSource = SanPhamBLL.searchSanPham(sanpham);
            
        }

        private void button_sp_them_Click(object sender, EventArgs e)
        {
            // Add Info SanPham
            sanpham.MaSanPham = textBox_sp_masp.Text;
            sanpham.MaVach = textBox_sp_mavach.Text;
            sanpham.TenSanPham = textBox_sp_tensp.Text;
            if(textBox_sp_giaban.Text != "")
            {
                sanpham.DonGiaBan = Convert.ToInt32(textBox_sp_giaban.Text);
            }
            else
            {
                sanpham.DonGiaBan = 0;
            }
            
            sanpham.DonViTinh = textBox_sp_donvitinh.Text;
            sanpham.NgaySanXuat = dateTimePicker_nsx.Value;
            sanpham.HanSuDung = dateTimePicker_hsd.Value;
            if(textBox_sp_maloai.Text != "")
            {
                sanpham.MaLoaiSanPham = Convert.ToInt32(textBox_sp_maloai.Text);
            }
            else
            {
                sanpham.MaLoaiSanPham = 0;
            }
            
            sanpham.MaKhuyenMai = textBox_sp_makm.Text;
            sanpham.HinhAnh = textBox_sp_hinh.Text;

            string addsp = spBLL.AddSanPham(sanpham);
            // phan hoi nguoi dung neu nghiep vu khong dung
            switch (addsp)
            {
                case "require_MaSanPham":
                    MessageBox.Show("Mã sản phẩm không được để trống");
                    return;
                case "require_MaVach":
                    MessageBox.Show("Mã vạch không được để trống");
                    return;
                case "require_TenSanPham":
                    MessageBox.Show("TenSanPham không được để trống");
                    return;
                case "require_MaLoaiSanPham":
                    MessageBox.Show("Mã loại sản phẩm không được để trống");
                    return;
                case "require_MaKhuyenMai":
                    MessageBox.Show("Mã khuyến mãi không được để trống");
                    return;
                case "failure":
                    MessageBox.Show("Thêm sản phẩm thất bại, bạn hãy thử lại !");
                    return;

            }
            MessageBox.Show("Thêm sản phẩm thành công");
            // Refresh datagridview
            dataGridView_sp.DataSource = SanPhamBLL.GetAllSanPham();

        }

        // Button update SanPham
        private void button_sp_luu_Click(object sender, EventArgs e)
        {
            // Add Info SanPham
            sanpham.MaSanPham = textBox_sp_masp.Text;
            sanpham.MaVach = textBox_sp_mavach.Text;
            sanpham.TenSanPham = textBox_sp_tensp.Text;
            if (textBox_sp_giaban.Text != "")
            {
                sanpham.DonGiaBan = Convert.ToInt32(textBox_sp_giaban.Text);
            }
            else
            {
                sanpham.DonGiaBan = 0;
            }

            sanpham.DonViTinh = textBox_sp_donvitinh.Text;
            sanpham.NgaySanXuat = dateTimePicker_nsx.Value;
            sanpham.HanSuDung = dateTimePicker_hsd.Value;
            if (textBox_sp_maloai.Text != "")
            {
                sanpham.MaLoaiSanPham = Convert.ToInt32(textBox_sp_maloai.Text);
            }
            else
            {
                sanpham.MaLoaiSanPham = 0;
            }

            sanpham.MaKhuyenMai = textBox_sp_makm.Text;
            sanpham.HinhAnh = textBox_sp_hinh.Text;

            string updatesp = spBLL.UpdateSanPham(sanpham);
            // phan hoi nguoi dung neu nghiep vu khong dung
            switch (updatesp)
            {
                case "require_MaSanPham":
                    MessageBox.Show("Mã sản phẩm không được để trống");
                    return;
                case "require_MaVach":
                    MessageBox.Show("Mã vạch không được để trống");
                    return;
                case "require_TenSanPham":
                    MessageBox.Show("TenSanPham không được để trống");
                    return;
                case "require_MaLoaiSanPham":
                    MessageBox.Show("Mã loại sản phẩm không được để trống");
                    return;
                case "require_MaKhuyenMai":
                    MessageBox.Show("Mã khuyến mãi không được để trống");
                    return;
                case "failure":
                    MessageBox.Show("Cập nhật sản phẩm thất bại, bạn hãy thử lại !");
                    return;

            }
            MessageBox.Show("Cập nhật sản phẩm thành công");
            // Refresh datagridview
            dataGridView_sp.DataSource = SanPhamBLL.GetAllSanPham();
        }

        // Button delete SanPham
        private void button_sp_xoa_Click(object sender, EventArgs e)
        {
            // Add Info SanPham
            sanpham.MaSanPham = textBox_sp_masp.Text;
            
            string deletesp = spBLL.DeleteSanPham(sanpham);
            // phan hoi nguoi dung neu nghiep vu khong dung
            switch (deletesp)
            {
                case "require_MaSanPham":
                    MessageBox.Show("Mã sản phẩm không được để trống");
                    return;
                
                case "failure":
                    MessageBox.Show("Xóa sản phẩm thất bại, bạn hãy thử lại !");
                    return;

            }
            MessageBox.Show("Xóa sản phẩm thành công");
            // Refresh datagridview
            dataGridView_sp.DataSource = SanPhamBLL.GetAllSanPham();
        }

        private void bánHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form fm = new BanHang();
            fm.Show();
        }

        private void nhậpHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form fm = new NhapHang();
            fm.Show();
        }

        private void hủyHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form fm = new HuyHang();
            fm.Show();
        }
    }
}
