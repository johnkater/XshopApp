using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BLL;
namespace GUI
{
    public partial class BanHang : Form
    {
        SanPhamDTO sanpham = new SanPhamDTO();
        PhieuXuatDTO phieuxuat = new PhieuXuatDTO();
        PhieuXuatChiTietDTOcs phieuxuatchitiet = new PhieuXuatChiTietDTOcs();
        BanHangBLL BanHangBLL = new BanHangBLL();

        public BanHang()
        {
            InitializeComponent();
        }

        // Form load
        private void BanHang_Load(object sender, EventArgs e)
        {
            // Init Value 
            textBox_px_makh.Text = "KH000000";

            // Datagridview SanPham
            dataGridView_timsp.DataSource = SanPhamBLL.GetAllSanPham();
            dataGridView_timsp.Columns[0].HeaderText = "Mã SP";
            dataGridView_timsp.Columns[0].MinimumWidth = 150;
            dataGridView_timsp.Columns[1].HeaderText = "Mã vạch";
            dataGridView_timsp.Columns[1].MinimumWidth = 150;
            dataGridView_timsp.Columns[2].HeaderText = "Mã Loại SP";
            dataGridView_timsp.Columns[2].MinimumWidth = 150;
            dataGridView_timsp.Columns[3].HeaderText = "Tên loại SP";
            dataGridView_timsp.Columns[3].MinimumWidth = 150;
            dataGridView_timsp.Columns[4].HeaderText = "Tên SP";
            dataGridView_timsp.Columns[4].MinimumWidth = 300;
            dataGridView_timsp.Columns[5].HeaderText = "Giá bán";
            dataGridView_timsp.Columns[5].MinimumWidth = 150;
            dataGridView_timsp.Columns[6].HeaderText = "Đơn vị tính";
            dataGridView_timsp.Columns[6].MinimumWidth = 100;
            dataGridView_timsp.Columns[7].HeaderText = "NSX";
            dataGridView_timsp.Columns[7].MinimumWidth = 150;
            dataGridView_timsp.Columns[8].HeaderText = "HSD";
            dataGridView_timsp.Columns[8].MinimumWidth = 150;
            dataGridView_timsp.Columns[9].HeaderText = "Hình ảnh";
            dataGridView_timsp.Columns[9].MinimumWidth = 200;
            dataGridView_timsp.Columns[10].HeaderText = "Mã KM";
            dataGridView_timsp.Columns[10].MinimumWidth = 150;
            dataGridView_timsp.Columns[11].HeaderText = "Tên loại KM";
            dataGridView_timsp.Columns[11].MinimumWidth = 200;
            dataGridView_timsp.Columns[12].HeaderText = "Giá giảm";
            dataGridView_timsp.Columns[12].MinimumWidth = 150;
            dataGridView_timsp.Columns[13].HeaderText = "Ngày bắt đầu";
            dataGridView_timsp.Columns[13].MinimumWidth = 150;
            dataGridView_timsp.Columns[14].HeaderText = "Ngày kết thúc";
            dataGridView_timsp.Columns[14].MinimumWidth = 150;

            // Data BanHang
            dataGridView_banhang.DataSource = BanHangBLL.GetAllBanHang();
            dataGridView_banhang.Columns[0].HeaderText = "Mã Phiếu Xuất";
            dataGridView_banhang.Columns[0].MinimumWidth = 200;
            dataGridView_banhang.Columns[1].HeaderText = "Ngày Xuất";
            dataGridView_banhang.Columns[1].MinimumWidth = 100;
            dataGridView_banhang.Columns[2].HeaderText = "Mã Nhân Viên";
            dataGridView_banhang.Columns[2].MinimumWidth = 100;
            dataGridView_banhang.Columns[3].HeaderText = "Mã khách hàng";
            dataGridView_banhang.Columns[3].MinimumWidth = 100;
            dataGridView_banhang.Columns[4].HeaderText = "Mã sản phẩm";
            dataGridView_banhang.Columns[4].MinimumWidth = 100;
            dataGridView_banhang.Columns[5].HeaderText = "Tên sản phẩm";
            dataGridView_banhang.Columns[5].MinimumWidth = 250;
            dataGridView_banhang.Columns[6].HeaderText = "Đơn giá";
            dataGridView_banhang.Columns[6].MinimumWidth = 100;
            dataGridView_banhang.Columns[7].HeaderText = "Đơn vị tính";
            dataGridView_banhang.Columns[7].MinimumWidth = 100;
            dataGridView_banhang.Columns[8].HeaderText = "Giá giảm";
            dataGridView_banhang.Columns[8].MinimumWidth = 150;
            dataGridView_banhang.Columns[9].HeaderText = "Số lượng";
            dataGridView_banhang.Columns[9].MinimumWidth = 150;
            dataGridView_banhang.Columns[10].HeaderText = "Trạng thái";
            dataGridView_banhang.Columns[10].MinimumWidth = 150;
            dataGridView_banhang.Columns[11].HeaderText = "Ghi chú";
            dataGridView_banhang.Columns[11].MinimumWidth = 300;

            // Tinh tien
            int sc = dataGridView_banhang.Rows.Count;
            int thanhtien = 0;
            for (int i = 0; i < sc - 1; i++)
                thanhtien += int.Parse(dataGridView_banhang.Rows[i].Cells[12].Value.ToString());
            textBox_thanhtoan_tongtien.Text = thanhtien.ToString();
            
        }

        private void pictureBox_sp_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        // Button cancel
        private void button_sp_huybo_Click(object sender, EventArgs e)
        {
            textBox_px_mapx.Text = "";
            textBox_px_manv.Text = "";
            textBox_px_makh.Text = "KH00000000";
            dateTimePicker_px_ngay.Text = DateTime.Now.ToString();
            textBox_thanhtoan_tongtien.Text = "";
            textBox_thanhtoan_nhan.Text = "";
            textBox_thanhtoan_tralai.Text = "";
            textBox_px_ghichu.Text = "";
            textBox_bh_masp.Text = "";
            textBox_bh_tensp.Text = "";
            textBox_bh_mavach.Text = "";
            textBox_bh_soluong.Text = "";
        }

        // Button Search SanPham
        private void button_bh_tim_Click(object sender, EventArgs e)
        {
            // Add Info SanPham
            // Vo hieu hoa search bang ten neu TenSP bi bo trong
            if(textBox_bh_tensp.Text == "")
            {
                sanpham.TenSanPham = "ssssss";
            }else
            {
                sanpham.TenSanPham = textBox_bh_tensp.Text;
            }
            // Vo hieu hoa search bang Mavach neu Mavach bi bo trong
            if(textBox_bh_mavach.Text == "")
            {
                sanpham.MaVach = "0000000000";
            }
            else
            {
                sanpham.MaVach = textBox_bh_mavach.Text;
            }
            // Vo hieu hoa search bang MaSanPham neu MaSanPham bi bo trong
            if(textBox_bh_masp.Text == "")
            {
                sanpham.MaSanPham = "sssssssss";
            }else
            {
                sanpham.MaSanPham = textBox_bh_masp.Text;
            }
            
            // Refresh Datagridview SanPham
            dataGridView_timsp.DataSource = BanHangBLL.searchSanPham(sanpham);

        }

        private void dataGridView_timsp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int option_click = e.RowIndex;
            textBox_bh_masp.Text = dataGridView_timsp[0, option_click].Value.ToString();
            textBox_bh_mavach.Text = dataGridView_timsp[1, option_click].Value.ToString();
            textBox_bh_tensp.Text = dataGridView_timsp[4, option_click].Value.ToString();
            
            if (dataGridView_timsp[9, option_click].Value.ToString() != "")
            {
                pictureBox_sp.LoadAsync(dataGridView_timsp[9, option_click].Value.ToString());
            }
            else
            {
                pictureBox_sp.LoadAsync("https://i.imgur.com/emQg1dY.png");
            }
            
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

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

        private void dataGridView_banhang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int option_click = e.RowIndex;
            textBox_bh_masp.Text = dataGridView_banhang[4, option_click].Value.ToString();
            textBox_bh_tensp.Text = dataGridView_banhang[5, option_click].Value.ToString();
            textBox_bh_soluong.Text = dataGridView_banhang[9, option_click].Value.ToString();
            textBox_px_ghichu.Text = dataGridView_banhang[11, option_click].Value.ToString();
            textBox_px_mapx.Text = dataGridView_banhang[0, option_click].Value.ToString();
            textBox_px_manv.Text = dataGridView_banhang[2, option_click].Value.ToString();
            textBox_px_makh.Text = dataGridView_banhang[3, option_click].Value.ToString();
            dateTimePicker_px_ngay.Text = dataGridView_banhang[1, option_click].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Add Info PhieuXuat
            phieuxuat.MaPhieuXuat = textBox_bh_search.Text;
            phieuxuat.MaNhanVien = textBox_bh_search.Text;
            phieuxuat.MaKhachHang = textBox_bh_search.Text;

            // Refresh datagridview BanHang
            dataGridView_banhang.DataSource = BanHangBLL.searchPhieuXuat(phieuxuat);
            // Tinh tien
            int sc = dataGridView_banhang.Rows.Count;
            int thanhtien = 0;
            for (int i = 0; i < sc - 1; i++)
                thanhtien += int.Parse(dataGridView_banhang.Rows[i].Cells[12].Value.ToString());
            textBox_thanhtoan_tongtien.Text = thanhtien.ToString();
        }

        // Button add SanPham to PhieuXuatChiTiet
        private void button_pxct_them_Click(object sender, EventArgs e)
        {
            // Add Info PhieuXuatChiTiet
            phieuxuatchitiet.MaPhieuXuatChiTiet = textBox_px_mapx.Text;
            phieuxuatchitiet.MaSanPham = textBox_bh_masp.Text;
            if(textBox_bh_soluong.Text == "")
            {
                phieuxuatchitiet.SoLuong = 0;
            }
            else
            {
                phieuxuatchitiet.SoLuong = Convert.ToInt32(textBox_bh_soluong.Text);
            }

            string addPhieuXuatChiTiet = BanHangBLL.AddPhieuXuatChiTiet(phieuxuatchitiet);
            // phan hoi nguoi dung neu nghiep vu khong dung
            switch (addPhieuXuatChiTiet)
            {
                case "require_MaPhieuXuatChiTiet":
                    MessageBox.Show("Mã Phiếu xuất không được để trống");
                    return;
                case "require_MaSanPham":
                    MessageBox.Show("Mã sản phẩm không được để trống");
                    return;
                case "require_SoLuong":
                    MessageBox.Show("Số lượng không được để trống");
                    return;
                
                case "failure":
                    MessageBox.Show("Thêm sản phẩm vào phiếu xuất thất bại, bạn hãy thử lại !");
                    return;

            }
            MessageBox.Show("Thêm sản phẩm vào phiếu xuất thành công");
            // Refresh datagridview
            dataGridView_banhang.DataSource = BanHangBLL.searchPhieuXuatBanHang(phieuxuatchitiet);
            // Tinh tien
            
            int sc = dataGridView_banhang.Rows.Count;
            int thanhtien = 0;
            for (int i = 0; i < sc - 1; i++)
                thanhtien += int.Parse(dataGridView_banhang.Rows[i].Cells[12].Value.ToString());
            textBox_thanhtoan_tongtien.Text = thanhtien.ToString();

        }

        // Button Update SanPham to PhieuXuatChiTiet
        private void button_pxct_luu_Click(object sender, EventArgs e)
        {
            // Add Info PhieuXuatChiTiet
            phieuxuatchitiet.MaPhieuXuatChiTiet = textBox_px_mapx.Text;
            phieuxuatchitiet.MaSanPham = textBox_bh_masp.Text;
            if (textBox_bh_soluong.Text == "")
            {
                phieuxuatchitiet.SoLuong = 0;
            }
            else
            {
                phieuxuatchitiet.SoLuong = Convert.ToInt32(textBox_bh_soluong.Text);
            }

            string updatePhieuXuatChiTiet = BanHangBLL.UpdatePhieuXuatChiTiet(phieuxuatchitiet);
            // phan hoi nguoi dung neu nghiep vu khong dung
            switch (updatePhieuXuatChiTiet)
            {
                case "require_MaPhieuXuatChiTiet":
                    MessageBox.Show("Mã Phiếu xuất không được để trống");
                    return;
                case "require_MaSanPham":
                    MessageBox.Show("Mã sản phẩm không được để trống");
                    return;
                case "require_SoLuong":
                    MessageBox.Show("Số lượng không được để trống");
                    return;

                case "failure":
                    MessageBox.Show("Cập nhật sản phẩm vào phiếu xuất thất bại, bạn hãy thử lại !");
                    return;

            }
            MessageBox.Show("Cập sản phẩm vào phiếu xuất thành công");
            // Refresh datagridview
            dataGridView_banhang.DataSource = BanHangBLL.searchPhieuXuatBanHang(phieuxuatchitiet);

            // Tinh tien

            int sc = dataGridView_banhang.Rows.Count;
            int thanhtien = 0;
            for (int i = 0; i < sc - 1; i++)
                thanhtien += int.Parse(dataGridView_banhang.Rows[i].Cells[12].Value.ToString());
            textBox_thanhtoan_tongtien.Text = thanhtien.ToString();

        }

        private void button_pxct_xoa_Click(object sender, EventArgs e)
        {
            // Add Info PhieuXuatChiTiet
            phieuxuatchitiet.MaPhieuXuatChiTiet = textBox_px_mapx.Text;
            phieuxuatchitiet.MaSanPham = textBox_bh_masp.Text;
            

            string deletePhieuXuatChiTiet = BanHangBLL.DeletePhieuXuatChiTiet(phieuxuatchitiet);
            // phan hoi nguoi dung neu nghiep vu khong dung
            switch (deletePhieuXuatChiTiet)
            {
                case "require_MaPhieuXuatChiTiet":
                    MessageBox.Show("Mã Phiếu xuất không được để trống");
                    return;
                case "require_MaSanPham":
                    MessageBox.Show("Mã sản phẩm không được để trống");
                    return;

                case "failure":
                    MessageBox.Show("Xóa sản phẩm trong phiếu xuất thất bại, bạn hãy thử lại !");
                    return;

            }
            MessageBox.Show("Xóa sản phẩm trong phiếu xuất thành công");
            // Refresh datagridview
            dataGridView_banhang.DataSource = BanHangBLL.searchPhieuXuatBanHang(phieuxuatchitiet);

            // Tinh tien

            int sc = dataGridView_banhang.Rows.Count;
            int thanhtien = 0;
            for (int i = 0; i < sc - 1; i++)
                thanhtien += int.Parse(dataGridView_banhang.Rows[i].Cells[12].Value.ToString());
            textBox_thanhtoan_tongtien.Text = thanhtien.ToString();

        }

        // Button refresh datagridview BanHang
        private void button_sp_lammoi_Click(object sender, EventArgs e)
        {
            // 
            phieuxuatchitiet.MaPhieuXuatChiTiet = textBox_px_mapx.Text;
            dataGridView_banhang.DataSource = BanHangBLL.searchPhieuXuatBanHang(phieuxuatchitiet);
            // 
            int sc = dataGridView_banhang.Rows.Count;
            int thanhtien = 0;
            for (int i = 0; i < sc - 1; i++)
                thanhtien += int.Parse(dataGridView_banhang.Rows[i].Cells[12].Value.ToString());
            textBox_thanhtoan_tongtien.Text = thanhtien.ToString();
        }

        // Button Add PhieuXuat
        private void button_sp_them_Click(object sender, EventArgs e)
        {
            // Add Info PhieuXuat
            phieuxuat.MaPhieuXuat = textBox_px_mapx.Text;
            phieuxuat.MaNhanVien = textBox_px_manv.Text;
            phieuxuat.MaKhachHang = textBox_px_makh.Text;
            phieuxuat.NgayXuat = dateTimePicker_px_ngay.Value;
            phieuxuat.TrangThai = "Chưa thanh toán";
            phieuxuat.GhiChu = textBox_px_ghichu.Text;
            phieuxuatchitiet.MaPhieuXuatChiTiet = textBox_px_mapx.Text;
            //
            string addPhieuXuat = BanHangBLL.AddPhieuXuat(phieuxuat);
            // phan hoi nguoi dung neu nghiep vu khong dung
            switch (addPhieuXuat)
            {
                case "require_MaPhieuXuat":
                    MessageBox.Show("Mã Phiếu xuất không được để trống");
                    return;
                case "require_MaNhanVien":
                    MessageBox.Show("Mã nhân viên không được để trống");
                    return;
                case "require_MaKhachHang":
                    MessageBox.Show("MaKhachHang không được để trống");
                    return;

                case "failure":
                    MessageBox.Show("Thêm phiếu xuất thất bại, bạn hãy thử lại !");
                    return;

            }
            MessageBox.Show("Thêm phiếu xuất thành công");
            // Refresh datagridview
            dataGridView_banhang.DataSource = BanHangBLL.searchPhieuXuatBanHang(phieuxuatchitiet);
        }

        // Button Update PhieuXuat
        private void button_sp_luu_Click(object sender, EventArgs e)
        {
            // Add Info PhieuXuat
            phieuxuat.MaPhieuXuat = textBox_px_mapx.Text;
            phieuxuat.MaNhanVien = textBox_px_manv.Text;
            phieuxuat.MaKhachHang = textBox_px_makh.Text;
            phieuxuat.NgayXuat = dateTimePicker_px_ngay.Value;
            phieuxuat.GhiChu = textBox_px_ghichu.Text;
            phieuxuatchitiet.MaPhieuXuatChiTiet = textBox_px_mapx.Text;
            //
            string updatePhieuXuat = BanHangBLL.UpdatePhieuXuat(phieuxuat);
            // phan hoi nguoi dung neu nghiep vu khong dung
            switch (updatePhieuXuat)
            {
                case "require_MaPhieuXuat":
                    MessageBox.Show("Mã Phiếu xuất không được để trống");
                    return;
                case "require_MaNhanVien":
                    MessageBox.Show("Mã nhân viên không được để trống");
                    return;
                case "require_MaKhachHang":
                    MessageBox.Show("MaKhachHang không được để trống");
                    return;

                case "failure":
                    MessageBox.Show("Cập nhật phiếu xuất thất bại, bạn hãy thử lại !");
                    return;

            }
            MessageBox.Show("Cập nhật phiếu xuất thành công");
            // Refresh datagridview
            dataGridView_banhang.DataSource = BanHangBLL.searchPhieuXuatBanHang(phieuxuatchitiet);
        }

        // Button Delete PhieuXuat
        private void button_sp_xoa_Click(object sender, EventArgs e)
        {
            // Add Info PhieuXuat
            phieuxuat.MaPhieuXuat = textBox_px_mapx.Text;
            phieuxuatchitiet.MaPhieuXuatChiTiet = textBox_px_mapx.Text;
            string deleteAllPhieuXuatChiTiet = BanHangBLL.DeleteAllPhieuXuatChiTiet(phieuxuatchitiet);

            string deletePhieuXuat = BanHangBLL.DeletePhieuXuat(phieuxuat);
            // phan hoi nguoi dung neu nghiep vu khong dung
            switch (deletePhieuXuat)
            {
                case "require_MaPhieuXuat":
                    MessageBox.Show("Mã Phiếu xuất không được để trống");
                    return;                

                case "failure":
                    MessageBox.Show("Xóa phiếu xuất thất bại, bạn hãy thử lại !");
                    return;

            }
            MessageBox.Show("Xóa phiếu xuất thành công");
            // Refresh datagridview
            dataGridView_banhang.DataSource = BanHangBLL.searchPhieuXuatBanHang(phieuxuatchitiet);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Add Info PhieuXuat
            phieuxuat.MaPhieuXuat = textBox_px_mapx.Text;
            phieuxuat.TrangThai = "Đã thanh toán";

            // 
            string updateThanhToanPhieuXuat = BanHangBLL.UpdateThanhToanPhieuXuat(phieuxuat);
            // phan hoi nguoi dung neu nghiep vu khong dung
            switch (updateThanhToanPhieuXuat)
            {
                case "require_MaPhieuXuat":
                    MessageBox.Show("Mã Phiếu xuất không được để trống");
                    return;
                

                case "failure":
                    MessageBox.Show("Thanh toán phiếu xuất thất bại, bạn hãy thử lại !");
                    return;

            }
            MessageBox.Show("Thanh toán phiếu xuất thành công");
            // Refresh datagridview
            dataGridView_banhang.DataSource = BanHangBLL.searchPhieuXuatBanHang(phieuxuatchitiet);

            // Tinh tien 
            int tongTien = int.Parse(textBox_thanhtoan_tongtien.Text);
            int tienNhan = int.Parse(textBox_thanhtoan_nhan.Text);
            int tienThua = tienNhan - tongTien;
            textBox_thanhtoan_tralai.Text = tienThua.ToString();
        }

        // Button In Hoa Don
        private void button6_Click(object sender, EventArgs e)
        {

            // Process
            this.Hide();
            Form fm = new HoaDonBanHang();
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

        private void hàngHóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form fm = new KhuyenMai();
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

        private void sảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form fm = new SanPham();
            fm.Show();
        }
    }
}
