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
using DTO;
namespace GUI
{
    public partial class KhuyenMai : Form
    {
        LoaiKhuyenMaiDTO loaikhuyenmai = new LoaiKhuyenMaiDTO();
        KhuyenMaiBLL kmBLL = new KhuyenMaiBLL();
        KhuyenMaiDTO khuyenmai = new KhuyenMaiDTO();

        public KhuyenMai()
        {
            InitializeComponent();
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
            Form fm = new SanPham();
            fm.Show();
        }

        private void dataGridView_ltkh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int option_click = e.RowIndex;
            textBox_lkm_tenloai.Text = dataGridView_lkm[1, option_click].Value.ToString();
            textBox_lkm_maloai.Text = dataGridView_lkm[0, option_click].Value.ToString();
        }

        // Form load
        private void KhuyenMai_Load(object sender, EventArgs e)
        {
            // datagridview LoaiKhuyenMai
            dataGridView_lkm.DataSource = KhuyenMaiBLL.GetAllLoaiKhuyenMai();
            dataGridView_lkm.Columns[0].HeaderText = "Mã loại KM";
            dataGridView_lkm.Columns[0].MinimumWidth = 100;
            dataGridView_lkm.Columns[1].HeaderText = "Tên loại loại KM";
            dataGridView_lkm.Columns[1].MinimumWidth = 300;

            // datagridview KhuyenMai
            dataGridView_km.DataSource = KhuyenMaiBLL.GetAllKhuyenMai();
            dataGridView_km.Columns[0].HeaderText = "Mã KM";
            dataGridView_km.Columns[0].MinimumWidth =250;
            dataGridView_km.Columns[1].HeaderText = "Mã loại KM";
            dataGridView_km.Columns[1].MinimumWidth = 250;
            dataGridView_km.Columns[2].HeaderText = "Giá giảm (%)";
            dataGridView_km.Columns[2].MinimumWidth = 200;
            dataGridView_km.Columns[3].HeaderText = "Ngày bắt đầu";
            dataGridView_km.Columns[3].MinimumWidth = 400;
            dataGridView_km.Columns[4].HeaderText = "Ngày kết thúc";
            dataGridView_km.Columns[4].MinimumWidth = 400;

        }

        // Refresh datagridview LoaiKhuyenMai
        private void button_lkm_lammoi_Click(object sender, EventArgs e)
        {
            dataGridView_lkm.DataSource = KhuyenMaiBLL.GetAllLoaiKhuyenMai();
        }

        // Button cancel
        private void button_nv_huybo_Click(object sender, EventArgs e)
        {
            textBox_km_makm.Text = "";
            textBox_km_maloai.Text = "";
            textBox_km_giagiam.Text = "";
            textBox_lkm_maloai.Text = "";
            textBox_lkm_tenloai.Text = "";
            dateTimePicker_nbd.Value = DateTime.Now;
            dateTimePicker_nkt.Value = DateTime.Now;
            
        }

        // Button Add LoaiKhuyenMai
        private void button_lkm_them_Click(object sender, EventArgs e)
        {
            // Add Info LoaiKhuyenMai
            if(textBox_lkm_maloai.Text != "")
            {
                loaikhuyenmai.MaLoaiKhuyenMai = Convert.ToInt32(textBox_lkm_maloai.Text);
            }
            else
            {
                loaikhuyenmai.MaLoaiKhuyenMai = 0;
            }
            loaikhuyenmai.TenLoaiKhuyenMai = textBox_lkm_tenloai.Text;
            
            string addlkm = kmBLL.AddLoaiKhuyenMai(loaikhuyenmai);
            // phan hoi nguoi dung neu nghiep vu khong dung
            switch (addlkm)
            {
                case "require_MaLoaiKhuyenMai":
                    MessageBox.Show("Mã loại khuyến mãi không được để trống");
                    return;
                case "require_TenLoaiKhuyenMai":
                    MessageBox.Show("Tên tên loại khuyến mãi không được để trống");
                    return;
                case "failure":
                    MessageBox.Show("Thêm loại khuyến mãi thất bại, bạn hãy thử lại !");
                    return;

            }
            MessageBox.Show("Thêm loại khuyến mãi thành công");
            // Refresh datagridview
            dataGridView_lkm.DataSource = KhuyenMaiBLL.GetAllLoaiKhuyenMai();
        }

        // Button update or save LoaiKhuyenMai
        private void button_lkm_luu_Click(object sender, EventArgs e)
        {
            // Add Info LoaiKhuyenMai
            if (textBox_lkm_maloai.Text != "")
            {
                loaikhuyenmai.MaLoaiKhuyenMai = Convert.ToInt32(textBox_lkm_maloai.Text);
            }
            else
            {
                loaikhuyenmai.MaLoaiKhuyenMai = 0;
            }
            loaikhuyenmai.TenLoaiKhuyenMai = textBox_lkm_tenloai.Text;

            string updatelkm = kmBLL.UpdateLoaiKhuyenMai(loaikhuyenmai);
            // phan hoi nguoi dung neu nghiep vu khong dung
            switch (updatelkm)
            {
                case "require_MaLoaiKhuyenMai":
                    MessageBox.Show("Mã loại khuyến mãi không được để trống");
                    return;
                case "require_TenLoaiKhuyenMai":
                    MessageBox.Show("Tên tên loại khuyến mãi không được để trống");
                    return;
                case "failure":
                    MessageBox.Show("Cập nhật loại khuyến mãi thất bại, bạn hãy thử lại !");
                    return;

            }
            MessageBox.Show("Cập nhật loại khuyến mãi thành công");
            // Refresh datagridview
            dataGridView_lkm.DataSource = KhuyenMaiBLL.GetAllLoaiKhuyenMai();
        }

        // Button delete LoaiKhuyenMai
        private void button_lkm_xoa_Click(object sender, EventArgs e)
        {
            // Add Info LoaiKhuyenMai
            if (textBox_lkm_maloai.Text != "")
            {
                loaikhuyenmai.MaLoaiKhuyenMai = Convert.ToInt32(textBox_lkm_maloai.Text);
            }
            else
            {
                loaikhuyenmai.MaLoaiKhuyenMai = 0;
            }
            string deletelkm = kmBLL.DeleteLoaiKhuyenMai(loaikhuyenmai);
            // phan hoi nguoi dung neu nghiep vu khong dung
            switch (deletelkm)
            {
                case "require_MaLoaiKhuyenMai":
                    MessageBox.Show("Mã loại khuyến mãi không được để trống");
                    return;
           
                case "failure":
                    MessageBox.Show("Xóa loại khuyến mãi thất bại, bạn hãy thử lại !");
                    return;

            }
            MessageBox.Show("Xóa loại khuyến mãi thành công");
            // Refresh datagridview
            dataGridView_lkm.DataSource = KhuyenMaiBLL.GetAllLoaiKhuyenMai();
        }

        // Datagridview KhuyenMai Click
        private void dataGridView_km_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int option_click = e.RowIndex;
            textBox_km_makm.Text = dataGridView_km[0,option_click].Value.ToString();
            textBox_km_maloai.Text = dataGridView_km[1,option_click].Value.ToString();
            textBox_km_giagiam.Text = dataGridView_km[2,option_click].Value.ToString();
            dateTimePicker_nbd.Text = dataGridView_km[3,option_click].Value.ToString();
            dateTimePicker_nkt.Text = dataGridView_km[4,option_click].Value.ToString();

        }
        
        // Refresh datagridview KhuyenMai
        private void button_nv_tc_Click(object sender, EventArgs e)
        {
            dataGridView_km.DataSource = KhuyenMaiBLL.GetAllKhuyenMai();
        }

        // Button tim kiem KhuyenMai
        private void button_tkh_timkiem_Click(object sender, EventArgs e)
        {
            // Add Info KhuyenMai
            khuyenmai.MaKhuyenMai = textBox_km_timkiem.Text;
            // Refresh datagridview KhuyenMai
            dataGridView_km.DataSource = KhuyenMaiBLL.searchKhuyenMai(khuyenmai);

        }

        // Button Add KhuyenMai 
        private void button_nv_them_Click(object sender, EventArgs e)
        {
            // Add Info KhuyenMai
            khuyenmai.MaKhuyenMai = textBox_km_makm.Text;

            // Validate MaLoaiKhuyenMai
            if(textBox_km_maloai.Text != "")
            {
                khuyenmai.MaLoaiKhuyenMai = Convert.ToInt32(textBox_km_maloai.Text);               
            }
            else
            {
                khuyenmai.MaLoaiKhuyenMai = 0;
            }
            // Validate GiaGiam
            
            if (textBox_km_giagiam.Text != "")
            {
                khuyenmai.GiaGiam = Convert.ToInt32(textBox_km_giagiam.Text);
            }
            else
            {
                khuyenmai.GiaGiam = 0;
            }
            if (khuyenmai.MaLoaiKhuyenMai == 3)
            {
                khuyenmai.GiaGiam = 100;
            }


            khuyenmai.NgayBatDau = dateTimePicker_nbd.Value;
            khuyenmai.NgayKetThuc = dateTimePicker_nkt.Value;

            string addkm = kmBLL.AddKhuyenMai(khuyenmai);
            // phan hoi nguoi dung neu nghiep vu khong dung
            switch (addkm)
            {
                case "require_MaKhuyenMai":
                    MessageBox.Show("Mã khuyến mãi không được để trống");
                    return;
                case "require_MaLoaiKhuyenMai":
                    MessageBox.Show("Mã loại khuyến mãi không được để trống");
                    return;
                case "failure":
                    MessageBox.Show("Thêm khuyến mãi thất bại, bạn hãy thử lại !");
                    return;

            }
            MessageBox.Show("Thêm khuyến mãi thành công");
            // Refresh datagridview
            dataGridView_km.DataSource = KhuyenMaiBLL.GetAllKhuyenMai();

        }

        // Button Update KhuyenMai
        private void button_nv_luu_Click(object sender, EventArgs e)
        {
            // Add Info KhuyenMai
            khuyenmai.MaKhuyenMai = textBox_km_makm.Text;
            if (textBox_km_maloai.Text != "")
            {
                khuyenmai.MaLoaiKhuyenMai = Convert.ToInt32(textBox_km_maloai.Text);
            }
            else
            {
                khuyenmai.MaLoaiKhuyenMai = 0;
            }
            khuyenmai.GiaGiam = Convert.ToInt32(textBox_km_giagiam.Text);
            khuyenmai.NgayBatDau = dateTimePicker_nbd.Value;
            khuyenmai.NgayKetThuc = dateTimePicker_nkt.Value;

            string updatekm = kmBLL.UpdateKhuyenMai(khuyenmai);
            // phan hoi nguoi dung neu nghiep vu khong dung
            switch (updatekm)
            {
                case "require_MaKhuyenMai":
                    MessageBox.Show("Mã khuyến mãi không được để trống");
                    return;
                case "require_MaLoaiKhuyenMai":
                    MessageBox.Show("Mã loại khuyến mãi không được để trống");
                    return;
                case "failure":
                    MessageBox.Show("Cập nhật khuyến mãi thất bại, bạn hãy thử lại !");
                    return;

            }
            MessageBox.Show("Cập nhật khuyến mãi thành công");
            // Refresh datagridview
            dataGridView_km.DataSource = KhuyenMaiBLL.GetAllKhuyenMai();
        }

        // Button delete KhuyenMai
        private void button_nv_xoa_Click(object sender, EventArgs e)
        {
            // Add Info KhuyenMai
            khuyenmai.MaKhuyenMai = textBox_km_makm.Text;
            
            string deletekm = kmBLL.DeleteKhuyenMai(khuyenmai);
            // phan hoi nguoi dung neu nghiep vu khong dung
            switch (deletekm)
            {
                case "require_MaKhuyenMai":
                    MessageBox.Show("Mã khuyến mãi không được để trống");
                    return;
                case "failure":
                    MessageBox.Show("Xoa khuyến mãi thất bại, bạn hãy thử lại !");
                    return;

            }
            MessageBox.Show("Xoa khuyến mãi thành công");
            // Refresh datagridview
            dataGridView_km.DataSource = KhuyenMaiBLL.GetAllKhuyenMai();
        }
    }
}
