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
    public partial class NhapHang : Form
    {
        SanPhamDTO sanpham = new SanPhamDTO();
        PhieuNhapChiTietDTO phieunhapchitiet = new PhieuNhapChiTietDTO();
        PhieuNhapDTO phieunhap = new PhieuNhapDTO();
        NhapHangBLL nhaphangBLL = new NhapHangBLL();

        public NhapHang()
        {
            InitializeComponent();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void nhậpHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form fm = new BanHang();
            fm.Show();
        }

        private void hủyHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form fm = new HuyHang();
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

        private void sảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form fm = new SanPham();
            fm.Show();
        }

        private void NhapHang_Load(object sender, EventArgs e)
        {
            // Load data all SanPham
            dataGridView_timsp.DataSource = NhapHangBLL.GetAllSanPham();
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

            // Load data Nhaphang
            dataGridView_nhaphang.DataSource = NhapHangBLL.GetAllNhapHang();
            dataGridView_nhaphang.Columns[0].HeaderText = "Mã phiếu nhập";
            dataGridView_nhaphang.Columns[0].MinimumWidth = 200;
            dataGridView_nhaphang.Columns[1].HeaderText = "Ngày nhập";
            dataGridView_nhaphang.Columns[1].MinimumWidth = 100;
            dataGridView_nhaphang.Columns[2].HeaderText = "Mã NV";
            dataGridView_nhaphang.Columns[2].MinimumWidth = 100;
            dataGridView_nhaphang.Columns[3].HeaderText = "Mã NCC";
            dataGridView_nhaphang.Columns[3].MinimumWidth = 100;
            dataGridView_nhaphang.Columns[4].HeaderText = "Mã SP";
            dataGridView_nhaphang.Columns[4].MinimumWidth = 100;
            dataGridView_nhaphang.Columns[5].HeaderText = "Tên SP";
            dataGridView_nhaphang.Columns[5].MinimumWidth = 350;
            dataGridView_nhaphang.Columns[6].HeaderText = "Giá nhập";
            dataGridView_nhaphang.Columns[6].MinimumWidth = 200;
            dataGridView_nhaphang.Columns[7].HeaderText = "Đơn vị tính";
            dataGridView_nhaphang.Columns[7].MinimumWidth = 200;
            dataGridView_nhaphang.Columns[8].HeaderText = "Số lượng";
            dataGridView_nhaphang.Columns[8].MinimumWidth = 200;
            dataGridView_nhaphang.Columns[9].HeaderText = "Trạng thái";
            dataGridView_nhaphang.Columns[9].MinimumWidth = 150;
            dataGridView_nhaphang.Columns[10].HeaderText = "Ghi chú";
            dataGridView_nhaphang.Columns[10].MinimumWidth = 250;
            dataGridView_nhaphang.Columns[11].HeaderText = "Thành tiền";
            dataGridView_nhaphang.Columns[11].MinimumWidth = 150;
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void baToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form fm = new DangNhap();
            fm.Show();
        }

        private void dataGridView_timsp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int option_click = e.RowIndex;
            textBox_nh_masp.Text = dataGridView_timsp[0, option_click].Value.ToString();
            textBox_nh_mavach.Text = dataGridView_timsp[1, option_click].Value.ToString();
            textBox_nh_tensp.Text = dataGridView_timsp[4, option_click].Value.ToString();

            if (dataGridView_timsp[9, option_click].Value.ToString() != "")
            {
                pictureBox_sp.LoadAsync(dataGridView_timsp[9, option_click].Value.ToString());
            }
            else
            {
                pictureBox_sp.LoadAsync("https://i.imgur.com/emQg1dY.png");
            }

        }

        private void button_nh_tim_Click(object sender, EventArgs e)
        {
            
            // Add Info SanPham
            // Vo hieu hoa search bang ten neu TenSP bi bo trong
            if (textBox_nh_tensp.Text == "")
            {
                sanpham.TenSanPham = "ssssss";
            }
            else
            {
                sanpham.TenSanPham = textBox_nh_tensp.Text;
            }
            // Vo hieu hoa search bang Mavach neu Mavach bi bo trong
            if (textBox_nh_mavach.Text == "")
            {
                sanpham.MaVach = "0000000000";
            }
            else
            {
                sanpham.MaVach = textBox_nh_mavach.Text;
            }
            // Vo hieu hoa search bang MaSanPham neu MaSanPham bi bo trong
            if (textBox_nh_masp.Text == "")
            {
                sanpham.MaSanPham = "sssssssss";
            }
            else
            {
                sanpham.MaSanPham = textBox_nh_masp.Text;
            }

            // Refresh Datagridview SanPham
            dataGridView_timsp.DataSource = NhapHangBLL.searchSanPham(sanpham);
        }

        // Button add PhieuNhapChiTiet
        private void button_pnct_them_Click(object sender, EventArgs e)
        {
            // Add Info PhieuNhapChiTiet
            phieunhapchitiet.MaPhieuNhapChiTiet = textBox_pn_mapn.Text;
            phieunhapchitiet.MaSanPham = textBox_nh_masp.Text;
            if(textBox_nh_soluong.Text == "")
            {
                phieunhapchitiet.SoLuong = 0;
            }
            else
            {
                phieunhapchitiet.SoLuong = Convert.ToInt32(textBox_nh_soluong.Text);
            }
            if(textBox_nh_gia.Text == "")
            {
                phieunhapchitiet.DonGiaNhap = 0;

            }
            else
            {
                phieunhapchitiet.DonGiaNhap = Convert.ToInt32(textBox_nh_gia.Text);
            }


            string addPhieuNhapChiTiet = nhaphangBLL.AddPhieuNhapChiTiet(phieunhapchitiet);
            // phan hoi nguoi dung neu nghiep vu khong dung
            switch (addPhieuNhapChiTiet)
            {
                case "require_MaPhieuNhapChiTiet":
                    MessageBox.Show("Mã Phiếu Nhập không được để trống");
                    return;
                case "require_MaSanPham":
                    MessageBox.Show("Mã sản phẩm không được để trống");
                    return;
                case "require_SoLuong":
                    MessageBox.Show("Số lượng không được để trống");
                    return;
                case "require_DonGiaNhap":
                    MessageBox.Show("Đơn giá nhập không được để trống");
                    return;

                case "failure":
                    MessageBox.Show("Thêm sản phẩm vào phiếu nhập thất bại, bạn hãy thử lại !");
                    return;

            }
            MessageBox.Show("Thêm sản phẩm vào phiếu nhập thành công");
            // Refresh datagridview
            dataGridView_nhaphang.DataSource = NhapHangBLL.searchPhieuNhapHang(phieunhapchitiet);
            // Tinh tien

            int sc = dataGridView_nhaphang.Rows.Count;
            int thanhtien = 0;
            for (int i = 0; i < sc - 1; i++)
                thanhtien += int.Parse(dataGridView_nhaphang.Rows[i].Cells[11].Value.ToString());
            textBox_thanhtoan_tongtien.Text = thanhtien.ToString();

        }

        private void dataGridView_nhaphang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int option_click = e.RowIndex;
            textBox_pn_mapn.Text = dataGridView_nhaphang[0,option_click].Value.ToString();
            textBox_pn_manv.Text = dataGridView_nhaphang[2,option_click].Value.ToString();
            textBox_pn_mancc.Text = dataGridView_nhaphang[3,option_click].Value.ToString();
            dateTimePicker_pn_ngay.Text = dataGridView_nhaphang[1,option_click].Value.ToString();
            textBox_nh_masp.Text = dataGridView_nhaphang[4,option_click].Value.ToString();
            textBox_nh_tensp.Text = dataGridView_nhaphang[5,option_click].Value.ToString(); 
            textBox_nh_soluong.Text = dataGridView_nhaphang[8,option_click].Value.ToString();
            textBox_nh_gia.Text = dataGridView_nhaphang[6,option_click].Value.ToString();
            textBox_pn_ghichu.Text = dataGridView_nhaphang[10, option_click].Value.ToString();
        }

        // Button update NhapHangChiTiet
        private void button_pnct_luu_Click(object sender, EventArgs e)
        {
            // Add Info PhieuNhapChiTiet
            phieunhapchitiet.MaPhieuNhapChiTiet = textBox_pn_mapn.Text;
            phieunhapchitiet.MaSanPham = textBox_nh_masp.Text;
            if (textBox_nh_soluong.Text == "")
            {
                phieunhapchitiet.SoLuong = 0;
            }
            else
            {
                phieunhapchitiet.SoLuong = Convert.ToInt32(textBox_nh_soluong.Text);
            }
            if (textBox_nh_gia.Text == "")
            {
                phieunhapchitiet.DonGiaNhap = 0;

            }
            else
            {
                phieunhapchitiet.DonGiaNhap = Convert.ToInt32(textBox_nh_gia.Text);
            }


            string updatePhieuNhapChiTiet = nhaphangBLL.UpdatePhieuNhapChiTiet(phieunhapchitiet);
            // phan hoi nguoi dung neu nghiep vu khong dung
            switch (updatePhieuNhapChiTiet)
            {
                case "require_MaPhieuNhapChiTiet":
                    MessageBox.Show("Mã Phiếu Nhập không được để trống");
                    return;
                case "require_MaSanPham":
                    MessageBox.Show("Mã sản phẩm không được để trống");
                    return;
                case "require_SoLuong":
                    MessageBox.Show("Số lượng không được để trống");
                    return;
                case "require_DonGiaNhap":
                    MessageBox.Show("Đơn giá nhập không được để trống");
                    return;

                case "failure":
                    MessageBox.Show("Cập nhật sản phẩm vào phiếu nhập thất bại, bạn hãy thử lại !");
                    return;

            }
            MessageBox.Show("Cập nhật sản phẩm vào phiếu nhập thành công");
            // Refresh datagridview
            dataGridView_nhaphang.DataSource = NhapHangBLL.searchPhieuNhapHang(phieunhapchitiet);
            // Tinh tien

            int sc = dataGridView_nhaphang.Rows.Count;
            int thanhtien = 0;
            for (int i = 0; i < sc - 1; i++)
                thanhtien += int.Parse(dataGridView_nhaphang.Rows[i].Cells[11].Value.ToString());
            textBox_thanhtoan_tongtien.Text = thanhtien.ToString();
        }

        private void button_pnct_xoa_Click(object sender, EventArgs e)
        {
            // Add Info PhieuNhapChiTiet
            phieunhapchitiet.MaPhieuNhapChiTiet = textBox_pn_mapn.Text;
            phieunhapchitiet.MaSanPham = textBox_nh_masp.Text;
            

            string deletePhieuNhapChiTiet = nhaphangBLL.DeletePhieuNhapChiTiet(phieunhapchitiet);
            // phan hoi nguoi dung neu nghiep vu khong dung
            switch (deletePhieuNhapChiTiet)
            {
                case "require_MaPhieuNhapChiTiet":
                    MessageBox.Show("Mã Phiếu Nhập không được để trống");
                    return;
                case "require_MaSanPham":
                    MessageBox.Show("Mã sản phẩm không được để trống");
                    return;
                

                case "failure":
                    MessageBox.Show("Xóa sản phẩm trong phiếu nhập thất bại, bạn hãy thử lại !");
                    return;

            }
            MessageBox.Show("Xóa sản phẩm trong phiếu nhập thành công");
            // Refresh datagridview
            dataGridView_nhaphang.DataSource = NhapHangBLL.searchPhieuNhapHang(phieunhapchitiet);
            // Tinh tien

            int sc = dataGridView_nhaphang.Rows.Count;
            int thanhtien = 0;
            for (int i = 0; i < sc - 1; i++)
                thanhtien += int.Parse(dataGridView_nhaphang.Rows[i].Cells[11].Value.ToString());
            textBox_thanhtoan_tongtien.Text = thanhtien.ToString();
        }

        private void button_pn_lammoi_Click(object sender, EventArgs e)
        {
            // Add Info PhieuNhapChiTiet
            phieunhapchitiet.MaPhieuNhapChiTiet = textBox_pn_mapn.Text;
            // Refresh
            dataGridView_nhaphang.DataSource = NhapHangBLL.searchPhieuNhapHang(phieunhapchitiet);
            // Tinh tien

            int sc = dataGridView_nhaphang.Rows.Count;
            int thanhtien = 0;
            for (int i = 0; i < sc - 1; i++)
                thanhtien += int.Parse(dataGridView_nhaphang.Rows[i].Cells[11].Value.ToString());
            textBox_thanhtoan_tongtien.Text = thanhtien.ToString();
        }

        // Button cancel
        private void button_pn_huybo_Click(object sender, EventArgs e)
        {
            textBox_nh_masp.Text = "";
            textBox_nh_tensp.Text = "";
            textBox_nh_mavach.Text = "";
            textBox_nh_gia.Text = "";
            textBox_nh_soluong.Text = "";
            pictureBox_sp.LoadAsync("https://i.imgur.com/emQg1dY.png");
            textBox_pn_mapn.Text = "";
            textBox_pn_manv.Text = "";
            textBox_pn_mancc.Text = "";
            dateTimePicker_pn_ngay.Value = DateTime.Now;
            textBox_thanhtoan_tongtien.Text = "";
            textBox_thanhtoan_tra.Text = "";
            textBox_thanhtoan_nhanlai.Text = "";
            textBox_pn_ghichu.Text = "";
            
        }

        private void button_pn_timkiem_Click(object sender, EventArgs e)
        {
            // Add Info PhieuNhap
            phieunhap.MaPhieuNhap = textBox_pn_search.Text;
            phieunhap.MaNhanVien = textBox_pn_search.Text;
            phieunhap.MaNhaCungCap = textBox_pn_search.Text;
            //
            dataGridView_nhaphang.DataSource = NhapHangBLL.searchPhieuNhapNhieuThamSo(phieunhap);
        }

        // Button add PhieuNhap
        private void button_pn_them_Click(object sender, EventArgs e)
        {
            // Add Info PhieuNhap
            phieunhap.MaPhieuNhap = textBox_pn_mapn.Text;
            phieunhap.MaNhanVien = textBox_pn_manv.Text;
            phieunhap.MaNhaCungCap = textBox_pn_mancc.Text;
            phieunhap.NgayNhap = dateTimePicker_pn_ngay.Value;
            phieunhap.TrangThai = "Chưa thanh toán";
            phieunhap.GhiChu = "Tạo mới";
            phieunhapchitiet.MaPhieuNhapChiTiet = textBox_pn_mapn.Text;
            //
            string addPhieuNhap = nhaphangBLL.AddPhieuNhap(phieunhap);
            // phan hoi nguoi dung neu nghiep vu khong dung
            switch (addPhieuNhap)
            {
                case "require_MaPhieuNhap":
                    MessageBox.Show("Mã Phiếu Nhập không được để trống");
                    return;
                case "require_MaNhanVien":
                    MessageBox.Show("Mã nhân viên không được để trống");
                    return;
                case "require_MaNhaCungCap":
                    MessageBox.Show("Mã nhà cung cấp không được để trống");
                    return;
                

                case "failure":
                    MessageBox.Show("Thêm phiếu nhập thất bại, bạn hãy thử lại !");
                    return;

            }
            MessageBox.Show("Thêm phiếu nhập thành công");
            // Refresh datagridview
            dataGridView_nhaphang.DataSource = NhapHangBLL.searchPhieuNhapHang(phieunhapchitiet);
        }

        private void button_pn_luu_Click(object sender, EventArgs e)
        {
            // Add Info PhieuNhap
            phieunhap.MaPhieuNhap = textBox_pn_mapn.Text;
            phieunhap.MaNhanVien = textBox_pn_manv.Text;
            phieunhap.MaNhaCungCap = textBox_pn_mancc.Text;
            phieunhap.NgayNhap = dateTimePicker_pn_ngay.Value;
            phieunhap.GhiChu = textBox_pn_ghichu.Text;
            phieunhapchitiet.MaPhieuNhapChiTiet = textBox_pn_mapn.Text;
            //
            string updatePhieuNhap = nhaphangBLL.UpdatePhieuNhap(phieunhap);
            // phan hoi nguoi dung neu nghiep vu khong dung
            switch (updatePhieuNhap)
            {
                case "require_MaPhieuNhap":
                    MessageBox.Show("Mã Phiếu Nhập không được để trống");
                    return;
                case "require_MaNhanVien":
                    MessageBox.Show("Mã nhân viên không được để trống");
                    return;
                case "require_MaNhaCungCap":
                    MessageBox.Show("Mã nhà cung cấp không được để trống");
                    return;


                case "failure":
                    MessageBox.Show("Cập nhật phiếu nhập thất bại, bạn hãy thử lại !");
                    return;

            }
            MessageBox.Show("Cập nhật phiếu nhập thành công");
            // Refresh datagridview
            dataGridView_nhaphang.DataSource = NhapHangBLL.searchPhieuNhapHang(phieunhapchitiet);
        }

        private void button_pn_xoa_Click(object sender, EventArgs e)
        {
            // Add Info PhieuNhap
            phieunhap.MaPhieuNhap = textBox_pn_mapn.Text;
            
            phieunhapchitiet.MaPhieuNhapChiTiet = textBox_pn_mapn.Text;
            //
            string deleteAllPhieuNhapChiTiet = nhaphangBLL.DeleteAllPhieuNhapChiTiet(phieunhapchitiet);

            string deletePhieuNhap = nhaphangBLL.DeletePhieuNhap(phieunhap);
            // phan hoi nguoi dung neu nghiep vu khong dung
            switch (deletePhieuNhap)
            {
                case "require_MaPhieuNhap":
                    MessageBox.Show("Mã Phiếu Nhập không được để trống");
                    return;
                

                case "failure":
                    MessageBox.Show("Xóa phiếu nhập thất bại, bạn hãy thử lại !");
                    return;

            }
            MessageBox.Show("Xóa phiếu nhập thành công");
            // Refresh datagridview
            dataGridView_nhaphang.DataSource = NhapHangBLL.searchPhieuNhapHang(phieunhapchitiet);
        }

        private void button_pn_inhoadon_Click(object sender, EventArgs e)
        {
            Form fm = new HoaDonNhapHang();
            fm.ShowDialog();
        }

        // Button Thanh toan PhieuNhap --> Update TrangThai PhieuNhap
        private void button_pn_thanhtoan_Click(object sender, EventArgs e)
        {
            // Add Info PhieuNhap
            phieunhap.MaPhieuNhap = textBox_pn_mapn.Text;
            phieunhap.TrangThai = "Đã thanh toán";
            string updateTrangThaiPhieuNhap = nhaphangBLL.UpdateTrangThaiPhieuNhap(phieunhap);
            // 
            // phan hoi nguoi dung neu nghiep vu khong dung
            switch (updateTrangThaiPhieuNhap)
            {
                case "require_MaPhieuNhap":
                    MessageBox.Show("Mã Phiếu Nhập không được để trống");
                    return;
                


                case "failure":
                    MessageBox.Show("Cập nhật trạng thái phiếu nhập thất bại, bạn hãy thử lại !");
                    return;

            }
            MessageBox.Show("Cập nhật trạng thái phiếu nhập thành công");
            // Refresh datagridview
            dataGridView_nhaphang.DataSource = NhapHangBLL.searchPhieuNhapHang(phieunhapchitiet);

            // Tinh tien
            if(textBox_thanhtoan_tra.Text != "")
            {
                int tienChiTra = int.Parse(textBox_thanhtoan_tra.Text);
                int tongTien = int.Parse(textBox_thanhtoan_tongtien.Text);
                int tienNhanLai = tienChiTra - tongTien;
                textBox_thanhtoan_nhanlai.Text = tienNhanLai.ToString();
            }
            
        }
    }
}
