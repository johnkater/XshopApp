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
    public partial class HuyHang : Form
    {
        SanPhamDTO sanpham = new SanPhamDTO();
        PhieuHuyChiTietDTO phieuhuychitiet = new PhieuHuyChiTietDTO();
        PhieuHuyDTO phieuhuy = new PhieuHuyDTO();
        HuyHangBLL huyhangBLL = new HuyHangBLL();

        public HuyHang()
        {
            InitializeComponent();
        }

        // Form load
        private void HuyHang_Load(object sender, EventArgs e)
        {
            dataGridView_timsp.DataSource = HuyHangBLL.GetAllSanPham();
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

            // 
            dataGridView_huyhang.DataSource = HuyHangBLL.GetAllHuyHang();
            dataGridView_huyhang.Columns[0].HeaderText = "Mã phiếu hủy";
            dataGridView_huyhang.Columns[0].MinimumWidth = 200;
            dataGridView_huyhang.Columns[1].HeaderText = "Ngày hủy";
            dataGridView_huyhang.Columns[1].MinimumWidth = 150;
            dataGridView_huyhang.Columns[2].HeaderText = "Mã NV";
            dataGridView_huyhang.Columns[2].MinimumWidth = 150;
            dataGridView_huyhang.Columns[3].HeaderText = "Mã SP";
            dataGridView_huyhang.Columns[3].MinimumWidth = 150;
            dataGridView_huyhang.Columns[4].HeaderText = "Tên SP";
            dataGridView_huyhang.Columns[4].MinimumWidth = 300;
            dataGridView_huyhang.Columns[5].HeaderText = "Giá";
            dataGridView_huyhang.Columns[5].MinimumWidth = 150;
            dataGridView_huyhang.Columns[6].HeaderText = "Đơn vị tính";
            dataGridView_huyhang.Columns[6].MinimumWidth = 150;
            dataGridView_huyhang.Columns[7].HeaderText = "Số lượng";
            dataGridView_huyhang.Columns[7].MinimumWidth = 100;
            dataGridView_huyhang.Columns[8].HeaderText = "Trạng thái";
            dataGridView_huyhang.Columns[8].MinimumWidth = 150;
            dataGridView_huyhang.Columns[9].HeaderText = "Ghi chú";
            dataGridView_huyhang.Columns[9].MinimumWidth = 200;
            dataGridView_huyhang.Columns[10].HeaderText = "Thành tiền";
            dataGridView_huyhang.Columns[10].MinimumWidth = 150;
            // Tinh tien

            int sc = dataGridView_huyhang.Rows.Count;
            int thanhtien = 0;
            for (int i = 0; i < sc - 1; i++)
                thanhtien += int.Parse(dataGridView_huyhang.Rows[i].Cells[10].Value.ToString());
            textBox_TongThietHai.Text = thanhtien.ToString();

        }

        private void hệThốngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form fm = new DangNhap();
            fm.Show();
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
            Form fm = new NhapHang();
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

        private void báoCáoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void doanhThuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form fm = new ThongKe();
            fm.Show();
        }

        private void hoạtĐộngBánHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form fm = new TonKho();
            fm.Show();
        }

        private void dataGridView_timsp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int option_click = e.RowIndex;
            textBox_hh_masp.Text = dataGridView_timsp[0,option_click].Value.ToString();
            textBox_hh_mavach.Text = dataGridView_timsp[1,option_click].Value.ToString();
            textBox_hh_tensp.Text = dataGridView_timsp[4,option_click].Value.ToString();
            if(dataGridView_timsp[9, option_click].Value.ToString() != "")
            {
                pictureBox_sp.LoadAsync(dataGridView_timsp[9, option_click].Value.ToString());
            }
            else
            {
                pictureBox_sp.LoadAsync("https://i.imgur.com/emQg1dY.png");
            }
            

        }

        private void button_hh_tim_Click(object sender, EventArgs e)
        {
            // Add Info SanPham
            // Vo hieu hoa search bang ten neu TenSP bi bo trong
            if (textBox_hh_tensp.Text == "")
            {
                sanpham.TenSanPham = "ssssss";
            }
            else
            {
                sanpham.TenSanPham = textBox_hh_tensp.Text;
            }
            // Vo hieu hoa search bang Mavach neu Mavach bi bo trong
            if (textBox_hh_mavach.Text == "")
            {
                sanpham.MaVach = "0000000000";
            }
            else
            {
                sanpham.MaVach = textBox_hh_mavach.Text;
            }
            // Vo hieu hoa search bang MaSanPham neu MaSanPham bi bo trong
            if (textBox_hh_masp.Text == "")
            {
                sanpham.MaSanPham = "sssssssss";
            }
            else
            {
                sanpham.MaSanPham = textBox_hh_masp.Text;
            }

            // Refresh Datagridview SanPham
            dataGridView_timsp.DataSource = HuyHangBLL.searchSanPham(sanpham);
        }

        // Button add PhieuHuyChiTiet
        private void button_phct_them_Click(object sender, EventArgs e)
        {
            // Add Info PhieuHuyChiTiet
            phieuhuychitiet.MaPhieuHuyChiTiet = textBox_ph_maph.Text;
            phieuhuychitiet.MaSanPham = textBox_hh_masp.Text;
            if (textBox_hh_soluong.Text != "")
            {
                phieuhuychitiet.SoLuong = int.Parse(textBox_hh_soluong.Text);
            }
            else
            {
                phieuhuychitiet.SoLuong = 0;
            }


            string addPhieuHuyChiTiet = huyhangBLL.AddPhieuHuyChiTiet(phieuhuychitiet);
            // phan hoi nguoi dung neu nghiep vu khong dung
            switch (addPhieuHuyChiTiet)
            {
                case "require_MaPhieuHuyChiTiet":
                    MessageBox.Show("Mã phiếu hủy không được để trống");
                    return;
                case "require_MaSanPham":
                    MessageBox.Show("Mã sản phẩm không được để trống");
                    return;
                case "require_SoLuong":
                    MessageBox.Show("Số lượng không được để trống");
                    return;              

                case "failure":
                    MessageBox.Show("Thêm sản phẩm vào phiếu hủy thất bại, bạn hãy thử lại !");
                    return;

            }
            MessageBox.Show("Thêm sản phẩm vào phiếu hủy thành công");
            // Refresh datagridview
            dataGridView_huyhang.DataSource = HuyHangBLL.searchPhieuHuyHang(phieuhuychitiet);
            // Tinh tien

            int sc = dataGridView_huyhang.Rows.Count;
            int thanhtien = 0;
            for (int i = 0; i < sc - 1; i++)
                thanhtien += int.Parse(dataGridView_huyhang.Rows[i].Cells[10].Value.ToString());
            textBox_TongThietHai.Text = thanhtien.ToString();



        }

        // Button update PhieuHuyChiTiet
        private void button_phct_luu_Click(object sender, EventArgs e)
        {
            // Add Info PhieuHuyChiTiet
            phieuhuychitiet.MaPhieuHuyChiTiet = textBox_ph_maph.Text;
            phieuhuychitiet.MaSanPham = textBox_hh_masp.Text;
            if (textBox_hh_soluong.Text != "")
            {
                phieuhuychitiet.SoLuong = int.Parse(textBox_hh_soluong.Text);
            }
            else
            {
                phieuhuychitiet.SoLuong = 0;
            }


            string updatePhieuHuyChiTiet = huyhangBLL.UpdatePhieuHuyChiTiet(phieuhuychitiet);
            // phan hoi nguoi dung neu nghiep vu khong dung
            switch (updatePhieuHuyChiTiet)
            {
                case "require_MaPhieuHuyChiTiet":
                    MessageBox.Show("Mã phiếu hủy không được để trống");
                    return;
                case "require_MaSanPham":
                    MessageBox.Show("Mã sản phẩm không được để trống");
                    return;
                case "require_SoLuong":
                    MessageBox.Show("Số lượng không được để trống");
                    return;

                case "failure":
                    MessageBox.Show("Cập nhật sản phẩm vào phiếu hủy thất bại, bạn hãy thử lại !");
                    return;

            }
            MessageBox.Show("Cập nhật sản phẩm vào phiếu hủy thành công");
            // Refresh datagridview
            dataGridView_huyhang.DataSource = HuyHangBLL.searchPhieuHuyHang(phieuhuychitiet);
            // Tinh tien

            int sc = dataGridView_huyhang.Rows.Count;
            int thanhtien = 0;
            for (int i = 0; i < sc - 1; i++)
                thanhtien += int.Parse(dataGridView_huyhang.Rows[i].Cells[10].Value.ToString());
            textBox_TongThietHai.Text = thanhtien.ToString();
        }

        // Button delete PhieuHuyChiTiet
        private void button_phct_xoa_Click(object sender, EventArgs e)
        {
            // Add Info PhieuHuyChiTiet
            phieuhuychitiet.MaPhieuHuyChiTiet = textBox_ph_maph.Text;
            phieuhuychitiet.MaSanPham = textBox_hh_masp.Text;
            
            string deletePhieuHuyChiTiet = huyhangBLL.DeletePhieuHuyChiTiet(phieuhuychitiet);
            // phan hoi nguoi dung neu nghiep vu khong dung
            switch (deletePhieuHuyChiTiet)
            {
                case "require_MaPhieuHuyChiTiet":
                    MessageBox.Show("Mã phiếu hủy không được để trống");
                    return;
                case "require_MaSanPham":
                    MessageBox.Show("Mã sản phẩm không được để trống");
                    return;               

                case "failure":
                    MessageBox.Show("Xóa sản phẩm khỏi phiếu hủy thất bại, bạn hãy thử lại !");
                    return;

            }
            MessageBox.Show("Xóa sản phẩm khỏi phiếu hủy thành công");
            // Refresh datagridview
            dataGridView_huyhang.DataSource = HuyHangBLL.searchPhieuHuyHang(phieuhuychitiet);
            // Tinh tien

            int sc = dataGridView_huyhang.Rows.Count;
            int thanhtien = 0;
            for (int i = 0; i < sc - 1; i++)
                thanhtien += int.Parse(dataGridView_huyhang.Rows[i].Cells[10].Value.ToString());
            textBox_TongThietHai.Text = thanhtien.ToString();
        }

        private void dataGridView_huyhang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int option_click = e.RowIndex;
            textBox_ph_maph.Text = dataGridView_huyhang[0, option_click].Value.ToString();
            textBox_ph_manv.Text = dataGridView_huyhang[2, option_click].Value.ToString();
            textBox_hh_masp.Text = dataGridView_huyhang[3, option_click].Value.ToString();
            textBox_hh_tensp.Text = dataGridView_huyhang[4, option_click].Value.ToString();
            textBox_hh_soluong.Text = dataGridView_huyhang[7, option_click].Value.ToString();
            dateTimePicker_ph_ngay.Text = dataGridView_huyhang[1, option_click].Value.ToString();
            textBox_ph_ghichu.Text = dataGridView_huyhang[9, option_click].Value.ToString();
            
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_ph_lammoi_Click(object sender, EventArgs e)
        {
            // Add InFo
            phieuhuychitiet.MaPhieuHuyChiTiet = textBox_ph_maph.Text;
            // Refresh
            dataGridView_huyhang.DataSource = HuyHangBLL.searchPhieuHuyHang(phieuhuychitiet);
            // Tinh tien

            int sc = dataGridView_huyhang.Rows.Count;
            int thanhtien = 0;
            for (int i = 0; i < sc - 1; i++)
                thanhtien += int.Parse(dataGridView_huyhang.Rows[i].Cells[10].Value.ToString());
            textBox_TongThietHai.Text = thanhtien.ToString();

        }

        // Button cancel
        private void button_ph_huybo_Click(object sender, EventArgs e)
        {
            textBox_hh_masp.Text = "";
            textBox_hh_tensp.Text = "";
            textBox_hh_mavach.Text = "";
            textBox_hh_soluong.Text = "";
            textBox_ph_maph.Text = "";
            textBox_ph_manv.Text = "";
            dateTimePicker_ph_ngay.Value = DateTime.Now;
            textBox_TongThietHai.Text = "";
            textBox_ph_ghichu.Text = "";
        }

        // Button InHoaDon
        private void button_ph_inhoadon_Click(object sender, EventArgs e)
        {
            Form fm = new HoaDonHuyHang();
            fm.ShowDialog();
        }

        private void button_ph_them_Click(object sender, EventArgs e)
        {
            // Add Info PhieuHuy
            phieuhuy.MaPhieuHuy = textBox_ph_maph.Text;
            phieuhuy.MaNhanVien = textBox_ph_manv.Text;
            phieuhuy.NgayHuy = dateTimePicker_ph_ngay.Value;
            phieuhuy.TrangThai = "Chưa duyệt";
            phieuhuy.GhiChu = textBox_ph_ghichu.Text;
            phieuhuychitiet.MaPhieuHuyChiTiet = textBox_ph_maph.Text;
            //
            string addPhieuHuy = huyhangBLL.AddPhieuHuy(phieuhuy);
            // phan hoi nguoi dung neu nghiep vu khong dung
            switch (addPhieuHuy)
            {
                case "require_MaPhieuHuy":
                    MessageBox.Show("Mã phiếu hủy không được để trống");
                    return;
                case "require_MaNhanVien":
                    MessageBox.Show("Mã nhân viên không được để trống");
                    return;
              

                case "failure":
                    MessageBox.Show("Thêm phiếu hủy thất bại, bạn hãy thử lại !");
                    return;

            }
            MessageBox.Show("Thêm phiếu hủy thành công");
            // Refresh datagridview
            dataGridView_huyhang.DataSource = HuyHangBLL.searchPhieuHuyHang(phieuhuychitiet);
        }

        private void button_ph_luu_Click(object sender, EventArgs e)
        {
            // Add Info PhieuHuy
            phieuhuy.MaPhieuHuy = textBox_ph_maph.Text;
            phieuhuy.MaNhanVien = textBox_ph_manv.Text;
            phieuhuy.NgayHuy = dateTimePicker_ph_ngay.Value;
            phieuhuy.GhiChu = textBox_ph_ghichu.Text;
            phieuhuychitiet.MaPhieuHuyChiTiet = textBox_ph_maph.Text;
            //
            string updatePhieuHuy = huyhangBLL.UpdatePhieuHuy(phieuhuy);
            // phan hoi nguoi dung neu nghiep vu khong dung
            switch (updatePhieuHuy)
            {
                case "require_MaPhieuHuy":
                    MessageBox.Show("Mã phiếu hủy không được để trống");
                    return;
                case "require_MaNhanVien":
                    MessageBox.Show("Mã nhân viên không được để trống");
                    return;


                case "failure":
                    MessageBox.Show("Cập nhật phiếu hủy thất bại, bạn hãy thử lại !");
                    return;

            }
            MessageBox.Show("Cập nhật phiếu hủy thành công");
            // Refresh datagridview
            dataGridView_huyhang.DataSource = HuyHangBLL.searchPhieuHuyHang(phieuhuychitiet);
        }

        private void button_ph_xoa_Click(object sender, EventArgs e)
        {
            // Add Info PhieuHuy
            phieuhuy.MaPhieuHuy = textBox_ph_maph.Text;
            phieuhuychitiet.MaPhieuHuyChiTiet = textBox_ph_maph.Text;

            //
            string deleteAllPhieuHuyChiTiet = huyhangBLL.DeleteAllPhieuHuyChiTiet(phieuhuychitiet);
            string deletePhieuHuy = huyhangBLL.DeletePhieuHuy(phieuhuy);
            // phan hoi nguoi dung neu nghiep vu khong dung
            switch (deletePhieuHuy)
            {
                case "require_MaPhieuHuy":
                    MessageBox.Show("Mã phiếu hủy không được để trống");
                    return;

                case "failure":
                    MessageBox.Show("Xóa phiếu hủy thất bại, bạn hãy thử lại !");
                    return;

            }
            MessageBox.Show("Xóa phiếu hủy thành công");
            // Refresh datagridview
            dataGridView_huyhang.DataSource = HuyHangBLL.searchPhieuHuyHang(phieuhuychitiet);
        }

        private void button_ph_timkiem_Click(object sender, EventArgs e)
        {
            // Add Info PhieuHuy
            if(textBox_ph_search.Text != "")
            {
                phieuhuy.MaPhieuHuy = textBox_ph_search.Text;
                phieuhuy.MaNhanVien = textBox_ph_search.Text;
            }
            else
            {
                phieuhuy.MaPhieuHuy = dateTimePicker_ph_ngay.Text;
                phieuhuy.MaNhanVien = dateTimePicker_ph_ngay.Text;
            }
            
            phieuhuy.NgayHuy = dateTimePicker_ph_ngay.Value;

            // refresh 
            dataGridView_huyhang.DataSource = HuyHangBLL.searchPhieuHuyHangNhieuThamSo(phieuhuy);
            // Tinh tien

            int sc = dataGridView_huyhang.Rows.Count;
            int thanhtien = 0;
            for (int i = 0; i < sc - 1; i++)
                thanhtien += int.Parse(dataGridView_huyhang.Rows[i].Cells[10].Value.ToString());
            textBox_TongThietHai.Text = thanhtien.ToString();


        }

        private void button_ph_huyhang_Click(object sender, EventArgs e)
        {
            // Add Info PhieuHuy
            phieuhuy.MaPhieuHuy = textBox_ph_maph.Text;
            phieuhuy.TrangThai = "Đã duyệt";
            string updateTrangThaiPhieuHuy = huyhangBLL.UpdateTrangThaiPhieuHuy(phieuhuy);
            // phan hoi nguoi dung neu nghiep vu khong dung
            switch (updateTrangThaiPhieuHuy)
            {
                case "require_MaPhieuHuy":
                    MessageBox.Show("Mã phiếu hủy không được để trống");
                    return;                

                case "failure":
                    MessageBox.Show("Cập nhật trạng thái phiếu hủy thất bại, bạn hãy thử lại !");
                    return;

            }
            MessageBox.Show("Cập nhật trạng thái phiếu hủy thành công");
            // Refresh datagridview
            dataGridView_huyhang.DataSource = HuyHangBLL.searchPhieuHuyHang(phieuhuychitiet);

        }
    }
}
