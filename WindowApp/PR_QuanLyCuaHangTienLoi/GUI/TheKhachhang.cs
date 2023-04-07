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
using BLL;
namespace GUI
{
    public partial class TheKhachhang : Form
    {
        KhachHangBLL khBLL = new KhachHangBLL();
        LoaiTheKhachHangDTO loaithekhachhang = new LoaiTheKhachHangDTO();
        KhachHangDTO khachhang = new KhachHangDTO();
        TheKhachHangDTO thekhachhang = new TheKhachHangDTO();

        public TheKhachhang()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        // Form load
        private void TheKhachhang_Load(object sender, EventArgs e)
        {
            // datagridview LoaiTheKhachHang
            dataGridView_ltkh.DataSource = KhachHangBLL.GetAllLoaiTheKhachHang();
            dataGridView_ltkh.Columns[0].HeaderText = "Mã loại";
            dataGridView_ltkh.Columns[0].MinimumWidth = 100;
            dataGridView_ltkh.Columns[1].HeaderText = "Tên loại";
            dataGridView_ltkh.Columns[1].MinimumWidth = 250;
            // datagridview TheKhachHang
            dataGridView_tkh.DataSource = KhachHangBLL.GetAllTheKhachHang();
            dataGridView_tkh.Columns[0].HeaderText = "Mã KH";
            dataGridView_tkh.Columns[0].MinimumWidth= 250;
            dataGridView_tkh.Columns[1].HeaderText = "Họ tên";
            dataGridView_tkh.Columns[1].MinimumWidth = 350;
            dataGridView_tkh.Columns[2].HeaderText = "Mã thẻ KH";
            dataGridView_tkh.Columns[2].MinimumWidth = 150;
            dataGridView_tkh.Columns[3].HeaderText = "Ngày lập";
            dataGridView_tkh.Columns[3].MinimumWidth = 250;
            dataGridView_tkh.Columns[4].HeaderText = "Tích điểm";
            dataGridView_tkh.Columns[4].MinimumWidth = 150;
            dataGridView_tkh.Columns[5].HeaderText = "Mã loại thẻ KH";
            dataGridView_tkh.Columns[5].MinimumWidth = 150;
            dataGridView_tkh.Columns[6].HeaderText = "Tên loại thẻ KH";
            dataGridView_tkh.Columns[6].MinimumWidth = 350;

        }

        private void dateTimePicker_ns_ValueChanged(object sender, EventArgs e)
        {

        }

        // Datagridview loai the khach hang click
        private void dataGridView_ltkh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int option_click = e.RowIndex;
            textBox_ltkh_ten.Text = dataGridView_ltkh[1,option_click].Value.ToString();
            textBox_ltkh_maloai.Text = dataGridView_ltkh[0, option_click].Value.ToString();
            if (dataGridView_ltkh[0, option_click].Value.ToString() == "1")
            {
                pictureBox_huyhieu.LoadAsync("https://lolg-cdn.porofessor.gg/img/s/league-icons-v3/160/2.png?v=8");
                label_huyhieu.Text = "Hạng " + dataGridView_ltkh[1, option_click].Value.ToString();
            }
            if (dataGridView_ltkh[0, option_click].Value.ToString() == "2")
            {
                pictureBox_huyhieu.LoadAsync("https://lolg-cdn.porofessor.gg/img/s/league-icons-v3/160/3.png?v=8");
                label_huyhieu.Text = "Hạng " + dataGridView_ltkh[1, option_click].Value.ToString();
            }
            if (dataGridView_ltkh[0, option_click].Value.ToString() == "3")
            {
                pictureBox_huyhieu.LoadAsync("https://lolg-cdn.porofessor.gg/img/s/league-icons-v3/160/4.png?v=8");
                label_huyhieu.Text = "Hạng " + dataGridView_ltkh[1, option_click].Value.ToString();
            }
        }

        // Refresh datagridview loai the khach hang
        private void button_ltkh_lammoi_Click(object sender, EventArgs e)
        {
            dataGridView_ltkh.DataSource = KhachHangBLL.GetAllLoaiTheKhachHang();
        }

        // Button add LoaiTheKhachHang
        private void button_ltkh_them_Click(object sender, EventArgs e)
        {
            // Add Info LoaiTheKhachHang
            loaithekhachhang.TenLoaiTheKhachHang = textBox_ltkh_ten.Text;
            loaithekhachhang.MaLoaiTheKhachHang = Convert.ToInt32(textBox_ltkh_maloai.Text);
            string addltkh = khBLL.AddLoaiTheKhachHang(loaithekhachhang);
            // phan hoi nguoi dung neu nghiep vu khong dung
            switch (addltkh)
            {
                case "require_MaLoaiTheKhachHang":
                    MessageBox.Show("Mã loại thẻ khách hàng không được để trống");
                    return;
                case "require_TenLoaiTheKhachHang":
                    MessageBox.Show("Tên loại thẻ khách hàng không được để trống");
                    return;
                case "failure":
                    MessageBox.Show("Thêm loại thẻ khách hàng thất bại, bạn hãy thử lại !");
                    return;

            }
            MessageBox.Show("Thêm loại thẻ khách hàng thành công");

            // Refresh datagridview
            dataGridView_ltkh.DataSource = KhachHangBLL.GetAllLoaiTheKhachHang();

        }

        // Button Update or Save LoaiTheKhachHang
        private void button_ltkh_luu_Click(object sender, EventArgs e)
        {
            // Add Info LoaiTheKhachHang
            loaithekhachhang.TenLoaiTheKhachHang = textBox_ltkh_ten.Text;
            loaithekhachhang.MaLoaiTheKhachHang = Convert.ToInt32(textBox_ltkh_maloai.Text);
            string addltkh = khBLL.UpdateLoaiTheKhachHang(loaithekhachhang);
            // phan hoi nguoi dung neu nghiep vu khong dung
            switch (addltkh)
            {
                case "require_MaLoaiTheKhachHang":
                    MessageBox.Show("Mã loại thẻ khách hàng không được để trống");
                    return;
                case "failure":
                    MessageBox.Show("Cập nhật loại thẻ khách hàng thất bại, bạn hãy thử lại !");
                    return;

            }
            MessageBox.Show("Cập nhật loại thẻ khách hàng thành công");

            // Refresh datagridview
            dataGridView_ltkh.DataSource = KhachHangBLL.GetAllLoaiTheKhachHang();
        }

        // Button delete LoaiTheKhachHang
        private void button_ltkh_xoa_Click(object sender, EventArgs e)
        {
            // Add Info LoaiTheKhachHang
            loaithekhachhang.MaLoaiTheKhachHang = Convert.ToInt32(textBox_ltkh_maloai.Text);
            string addltkh = khBLL.DeleteLoaiTheKhachHang(loaithekhachhang);
            // phan hoi nguoi dung neu nghiep vu khong dung
            switch (addltkh)
            {
                case "require_MaLoaiTheKhachHang":
                    MessageBox.Show("Mã loại thẻ khách hàng không được để trống");
                    return;
                case "failure":
                    MessageBox.Show("Xóa loại thẻ khách hàng thất bại, bạn hãy thử lại !");
                    return;

            }
            MessageBox.Show("Xóa loại thẻ khách hàng thành công");

            // Refresh datagridview
            dataGridView_ltkh.DataSource = KhachHangBLL.GetAllLoaiTheKhachHang();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        // Button Cancel 
        private void button_nv_huybo_Click(object sender, EventArgs e)
        {
            textBox_tkh_makh.Text = string.Empty;
            textBox_tkh_maloai.Text = string.Empty;
            textBox_tkh_mathe.Text = string.Empty;
            textBox_ltkh_ten.Text = string.Empty;
            textBox_ltkh_maloai.Text = string.Empty ;
            textBox_tkh_tichdiem.Text = string.Empty;
            dateTimePicker_ns.Value = DateTime.Now;
            pictureBox_huyhieu.LoadAsync("https://i.imgur.com/NakYZgq.png");
            label_huyhieu.Text = "Huy hiệu";
        }

        // Datagridview TheKhachHang click
        private void dataGridView_tkh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int option_click = e.RowIndex;
            textBox_tkh_makh.Text = dataGridView_tkh[0, option_click].Value.ToString();
            textBox_tkh_mathe.Text = dataGridView_tkh[2, option_click].Value.ToString();
            dateTimePicker_ns.Text = dataGridView_tkh[3, option_click].Value.ToString();
            textBox_tkh_tichdiem.Text = dataGridView_tkh[4, option_click].Value.ToString();
            textBox_tkh_maloai.Text = dataGridView_tkh[5, option_click].Value.ToString();
            textBox_ltkh_maloai.Text = dataGridView_tkh[5, option_click].Value.ToString();
            textBox_ltkh_ten.Text = dataGridView_tkh[6, option_click].Value.ToString();
            if (dataGridView_tkh[5, option_click].Value.ToString() == "1")
            {
                pictureBox_huyhieu.LoadAsync("https://lolg-cdn.porofessor.gg/img/s/league-icons-v3/160/2.png?v=8");
                label_huyhieu.Text = "Hạng " + dataGridView_tkh[6, option_click].Value.ToString();
            }
            if (dataGridView_tkh[5, option_click].Value.ToString() == "2")
            {
                pictureBox_huyhieu.LoadAsync("https://lolg-cdn.porofessor.gg/img/s/league-icons-v3/160/3.png?v=8");
                label_huyhieu.Text = "Hạng " + dataGridView_tkh[6, option_click].Value.ToString();
            }
            if (dataGridView_tkh[5, option_click].Value.ToString() == "3")
            {
                pictureBox_huyhieu.LoadAsync("https://lolg-cdn.porofessor.gg/img/s/league-icons-v3/160/4.png?v=8");
                label_huyhieu.Text = "Hạng " + dataGridView_tkh[6, option_click].Value.ToString();
            }
        }

        // Buttton Add TheKhachHang
        private void button_nv_them_Click(object sender, EventArgs e)
        {
            // Add Info TheKhachHang
            thekhachhang.MaKhachhang = textBox_tkh_makh.Text;
            thekhachhang.MaTheKhachHang = textBox_tkh_mathe.Text;
            thekhachhang.NgayLap = dateTimePicker_ns.Value;
            if(textBox_tkh_tichdiem.Text == "")
            {
                thekhachhang.TichDiem = 0;
            }
            else
            {
                thekhachhang.TichDiem = Convert.ToInt32(textBox_tkh_tichdiem.Text);
            }
            thekhachhang.MaLoaiTheKhachHang = Convert.ToInt32(textBox_tkh_maloai.Text);
            string addtkh = khBLL.AddTheKhachHang(thekhachhang);
            // phan hoi nguoi dung neu nghiep vu khong dung
            switch (addtkh)
            {
                case "require_MaTheKhachHang":
                    MessageBox.Show("Mã thẻ khách hàng không được để trống");
                    return;
                case "require_MaKhachHang":
                    MessageBox.Show("Mã khách hàng không được để trống");
                    return;
                case "require_MaLoaiTheKhachHang":
                    MessageBox.Show("Mã loại thẻ khách hàng không được để trống");
                    return;
                case "failure":
                    MessageBox.Show("Thêm thẻ khách hàng thất bại, bạn hãy thử lại !");
                    return;

            }
            MessageBox.Show("Thêm thẻ khách hàng thành công");

            // Refresh datagridview
            dataGridView_tkh.DataSource = KhachHangBLL.GetAllTheKhachHang();
        }

        // Button Refresh datagidview TheKhachHang
        private void button_nv_tc_Click(object sender, EventArgs e)
        {
            dataGridView_tkh.DataSource = KhachHangBLL.GetAllTheKhachHang();
        }

        // Button Search TheKhachHang
        private void button_tkh_timkiem_Click(object sender, EventArgs e)
        {
            // Add Info KhachHang
            khachhang.HoTen = textBox_kh_timkiem.Text;
            // Refresh datagridview TheKhachHang
            dataGridView_tkh.DataSource = KhachHangBLL.searchTheKhachHang(khachhang);
        }

        // Button Update TheKhachHang
        private void button_nv_luu_Click(object sender, EventArgs e)
        {
            // Add Info TheKhachHang
            thekhachhang.MaKhachhang = textBox_tkh_makh.Text;
            thekhachhang.MaTheKhachHang = textBox_tkh_mathe.Text;
            thekhachhang.NgayLap = dateTimePicker_ns.Value;
            if (textBox_tkh_tichdiem.Text == "")
            {
                thekhachhang.TichDiem = 0;
            }
            else
            {
                thekhachhang.TichDiem = Convert.ToInt32(textBox_tkh_tichdiem.Text);
            }
            
            thekhachhang.MaLoaiTheKhachHang = Convert.ToInt32(textBox_tkh_maloai.Text);
            string addtkh = khBLL.UpdateTheKhachHang(thekhachhang);
            // phan hoi nguoi dung neu nghiep vu khong dung
            switch (addtkh)
            {
                case "require_MaTheKhachHang":
                    MessageBox.Show("Mã thẻ khách hàng không được để trống");
                    return;
                case "require_MaKhachHang":
                    MessageBox.Show("Mã khách hàng không được để trống");
                    return;
                case "require_MaLoaiTheKhachHang":
                    MessageBox.Show("Mã loại thẻ khách hàng không được để trống");
                    return;
                case "failure":
                    MessageBox.Show("Cập nhật thẻ khách hàng thất bại, bạn hãy thử lại !");
                    return;

            }
            MessageBox.Show("Cập nhật thẻ khách hàng thành công");

            // Refresh datagridview
            dataGridView_tkh.DataSource = KhachHangBLL.GetAllTheKhachHang();
        }

        // Button Delete TheKhachHang
        private void button_nv_xoa_Click(object sender, EventArgs e)
        {
            // Add Info TheKhachHang
            thekhachhang.MaTheKhachHang = textBox_tkh_mathe.Text;
            
            string addtkh = khBLL.DeleteTheKhachHang(thekhachhang);
            // phan hoi nguoi dung neu nghiep vu khong dung
            switch (addtkh)
            {
                case "require_MaTheKhachHang":
                    MessageBox.Show("Mã thẻ khách hàng không được để trống");
                    return;
                case "failure":
                    MessageBox.Show("Xóa thẻ khách hàng thất bại, bạn hãy thử lại !");
                    return;

            }
            MessageBox.Show("Xóa thẻ khách hàng thành công");

            // Refresh datagridview
            dataGridView_tkh.DataSource = KhachHangBLL.GetAllTheKhachHang();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form fm = new DangNhap();
            fm.Show();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void khuyếnMãiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form fm = new KhuyenMai();
            fm.Show();
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
