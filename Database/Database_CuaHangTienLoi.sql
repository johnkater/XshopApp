-- TAO CO SO DU LIEU (DATABASE)---------------------------------------------------------------
CREATE DATABASE IF NOT EXISTS CuaHangTienLoi CHARACTER SET UTF8 COLLATE utf8_vietnamese_ci;
USE CuaHangTienLoi;

-- TAO BANG (TABLE) -------------------------------------------------------------------------------------------------------------------

-- 1. TAI KHOAN---------------------------------

CREATE TABLE TAIKHOAN (  
    TenTaiKhoan varchar(20) NOT NULL,  
    MatKhau varchar(20) NOT NULL,  
    MaNhanVien int(10) NOT NULL,
    Quyen nvarchar(20) NOT NULL,
    PRIMARY KEY (MaNhanVien)  
); 

-- 2. THE KHACH HANG----------------------------
CREATE TABLE THEKHACHHANG (  
    MaTheKhachHang int(10) NOT NULL,  
    MaKhachhang int(10) NOT NULL,  
    NgayLap datetime NULL,
    TichDiem bigint NULL , 
    MaLoaiTheKhachHang int(1) NOT NULL,
    PRIMARY KEY (MaTheKhachHang)  
);

-- 3. LOAI THE KHACH HANG----------------------------	
CREATE TABLE LOAITHEKHACHHANG (  
    MaLoaiTheKhachHang int(1) NOT NULL,  
    TenLoaiTheKhachHang nvarchar(30) NOT NULL,  
    PRIMARY KEY (MaLoaiTheKhachHang)  
);
	
-- 4. KHACH HANG----------------------------	
CREATE TABLE KHACHHANG (  
    MaKhachHang int(10) NOT NULL,  
    HoTen nvarchar(30) NULL, 
    GioiTinh nvarchar(6) NULL, 
    NgaySinh date NULL, 
    DiaChi nvarchar(100) NULL, 
    SoDienThoai varchar(13) NULL, 
    Email varchar(30) NULL,
    PRIMARY KEY (MaKhachHang)  
);

-- 5. NHANVIEN ----------------------------
CREATE TABLE NHANVIEN (  
    MaNV int(10) NOT NULL,  
    HoTen nvarchar(30) NULL, 
    GioiTinh nvarchar(6) NULL, 
    NgaySinh date NULL, 
    DiaChi nvarchar(100) NULL,
    QueQuan	nvarchar(100) NULL,
    SoDienThoai varchar(13) NULL, 
    Email varchar(30) NULL,
    PRIMARY KEY (MaNV)  
);

-- 6. PHIEUXUAT ----------------------------
CREATE TABLE PHIEUXUAT (  
    MaPhieuXuat int(10) NOT NULL,  
    MaNV int(10) NOT NULL, 
    MaKhachHang int(10) NOT NULL, 
    NgayXuat datetime NULL, 
    PRIMARY KEY (MaPhieuXuat)  
);
    
-- 7. PHIEUXUATCHITIET ----------------------------
CREATE TABLE PHIEUXUATCHITIET (  
    MaPhieuXuatChiTiet int(10) NOT NULL,  
    MaPhieuXuat int(10) NOT NULL, 
    MaSanPham int(10) NOT NULL, 
    SoLuong int(10) NULL, 
    PRIMARY KEY (MaPhieuXuatChiTiet,MaSanPham)  
); 
 
-- 8. PHIEUHUY ----------------------------
CREATE TABLE PHIEUHUY (  
    MaPhieuHuy int(10) NOT NULL,  
    MaNV int(10) NOT NULL, 
    SoLuong int(10) NULL, 
    PRIMARY KEY (MaPhieuHuy)  
); 

-- 9. PHIEUHUYCHITIET ----------------------------
CREATE TABLE PHIEUHUYCHITIET (  
    MaPhieuHuyChiTiet int(10) NOT NULL,  
    MaPhieuHuy int(10) NOT NULL, 
    MaSanPham int(10) NOT NULL,
    SoLuong int(10) NULL, 
    PRIMARY KEY (MaPhieuHuyChiTiet,MaSanPham)  
);
 
-- 10. SANPHAM ---------------------------- Mavach (EAN13)
CREATE TABLE SANPHAM (  
	MaSanPham int(10) NOT NULL,
    MaVach int(13) NOT NULL, 
    TenSanPham nvarchar(30) NULL, 
    DonGiaBan int(10) NULL,
    DonViTinh nvarchar(30) NULL, 
    NgaySanXuat date NULL, 
    HanSuDung date NULL, 
    MaLoaiSanPham int(10) NOT NULL, 
    MaKhuyenMai int(10) NOT NULL,
    PRIMARY KEY (MaSanPham)  
);

-- 11. LOAISANPHAM ----------------------------
CREATE TABLE LOAISANPHAM (  
    MaLoaiSanPham int(10) NOT NULL,  
    TenLoaiSanPham nvarchar(30) NOT NULL, 
    PRIMARY KEY (MaLoaiSanPham)  
);

-- 12. PHIEUNHAP ----------------------------
CREATE TABLE PHIEUNHAP (  
    MaPhieuNhap int(10) NOT NULL,  
    MaNV int(10) NOT NULL, 
    MaNhaCungCap int(10) NOT NULL,  
    NgayNhap datetime NULL,
    PRIMARY KEY (MaPhieuNhap)  
);

-- 13. PHIEUNHAPCHITIET ----------------------------
CREATE TABLE PHIEUNHAPCHITIET (  
    MaPhieuNhapChiTiet int(10) NOT NULL,  
    MaPhieuNhap int(10) NOT NULL, 
    MaSanPham int(10) NOT NULL,  
    SoLuong int(10) NULL,
    DonGiaNhap int(10) NULL,
    PRIMARY KEY (MaPhieuNhapChiTiet,MaSanPham)  
);

-- 14. NHACUNGCAP ----------------------------
CREATE TABLE NHACUNGCAP (  
    MaNhaCungCap int(10) NOT NULL,  
    TenNhaCungCap nvarchar(30) NULL, 
    DiaChi nvarchar(100) NULL,  
    SoDienThoai varchar(13) NULL,
    Email varchar(30) NULL,
    PRIMARY KEY (MaNhaCungCap)  
);

-- 15. KHUYENMAI ----------------------------
CREATE TABLE KHUYENMAI (  
    MaKhuyenMai int(10) NOT NULL,  
    MaLoaiKhuyenMai int(10) NOT NULL, 
    GiaGiam int(10) NULL,  
    NgayBatDau datetime NULL,
    NgayKetThuc datetime NULL,
    PRIMARY KEY (MaKhuyenMai)  
);

-- 16. LOAIKHUYENMAI ----------------------------
CREATE TABLE LOAIKHUYENMAI (  
    MaLoaiKhuyenMai int(10) NOT NULL,  
    TenLoaiKhuyenMai nvarchar(30) NOT NULL, 
    PRIMARY KEY (MaLoaiKhuyenMai )  
);


-- TAO KHOA NGOAI (FOREIGN KEY)---------------------------------------------------------------------------------------------------
-- 1. THEKHACHHANG (MaKhachhang) --> KHACHHANG (MaKhachhang)
alter table THEKHACHHANG
add constraint FK_THEKHACHHANG_KHACHHANG
foreign key (MaKhachhang)
references KHACHHANG(MaKhachhang);

-- 2. THEKHACHHANG --> LOAITHEKHACHHANG (MaLoaiTheKhachHang)
alter table THEKHACHHANG
add constraint FK_THEKHACHHANG_LOAITHEKHACHHANG
foreign key (MaLoaiTheKhachHang)
references LOAITHEKHACHHANG(MaLoaiTheKhachHang);

-- 3. PHIEUXUAT --> NHANVIEN (MaNV)
alter table PHIEUXUAT
add constraint FK_PHIEUXUAT_NHANVIEN
foreign key (MaNV)
references NHANVIEN(MaNV);

-- 4. PHIEUXUAT --> KHACHHANG (MaKhachhang)
alter table PHIEUXUAT
add constraint FK_PHIEUXUAT_KHACHHANG
foreign key (MaKhachhang)
references KHACHHANG(MaKhachhang);

-- 5. PHIEUXUATCHITIET --> PHIEUXUAT (MaPhieuXuat)
alter table PHIEUXUATCHITIET
add constraint FK_PHIEUXUATCHITIET_PHIEUXUAT
foreign key (MaPhieuXuat)
references PHIEUXUAT(MaPhieuXuat);

-- 6. PHIEUXUATCHITIET --> SANPHAM (MaSanPham)
alter table PHIEUXUATCHITIET
add constraint FK_PHIEUXUATCHITIET_SANPHAM
foreign key (MaSanPham)
references SANPHAM(MaSanPham);

-- 7. PHIEUHUY --> NHANVIEN (MaNV)
alter table PHIEUHUY
add constraint FK_PHIEUHUY_NHANVIEN
foreign key (MaNV)
references NHANVIEN(MaNV);

-- 8. PHIEUHUYCHITIET --> PHIEUHUY (MaPhieuHuy)
alter table PHIEUHUYCHITIET
add constraint FK_PHIEUHUYCHITIET_PHIEUHUY
foreign key (MaPhieuHuy)
references PHIEUHUY(MaPhieuHuy);

-- 9. PHIEUHUYCHITIET --> SANPHAM (MaSanPham)
alter table PHIEUHUYCHITIET
add constraint FK_PHIEUHUYCHITIET_SANPHAM
foreign key (MaSanPham)
references SANPHAM(MaSanPham);

-- 10. SANPHAM --> LOAISANPHAM (MaLoaiSanPham)
alter table SANPHAM
add constraint FK_SANPHAM_LOAISANPHAM
foreign key (MaLoaiSanPham)
references LOAISANPHAM(MaLoaiSanPham);

-- 11. SANPHAM --> KHUYENMAI (MaKhuyenMai)
alter table SANPHAM
add constraint FK_SANPHAM_KHUYENMAI
foreign key (MaKhuyenMai)
references KHUYENMAI(MaKhuyenMai);

-- 12. PHIEUNHAP --> NHANVIEN (MaNV)
alter table PHIEUNHAP
add constraint FK_PHIEUNHAP_NHANVIEN
foreign key (MaNV)
references NHANVIEN(MaNV);

-- 13. PHIEUNHAP --> NHACUNGCAP (MaNhaCungCap)
alter table PHIEUNHAP
add constraint FK_PHIEUNHAP_NHACUNGCAP
foreign key (MaNhaCungCap)
references NHACUNGCAP(MaNhaCungCap);

-- 14. PHIEUNHAPCHITIET --> PHIEUNHAP (MaPhieuNhap)
alter table PHIEUNHAPCHITIET
add constraint FK_PHIEUNHAPCHITIET_PHIEUNHAP
foreign key (MaPhieuNhap)
references PHIEUNHAP(MaPhieuNhap);

-- 15. PHIEUNHAPCHITIET --> SANPHAM (MaSanPham)
alter table PHIEUNHAPCHITIET
add constraint FK_PHIEUNHAPCHITIET_SANPHAM
foreign key (MaSanPham)
references SANPHAM(MaSanPham);

-- 15. KHUYENMAI --> LOAIKHUYENMAI	(MaLoaiKhuyenMai)
alter table KHUYENMAI
add constraint FK_KHUYENMAI_LOAIKHUYENMAI
foreign key (MaLoaiKhuyenMai)
references LOAIKHUYENMAI(MaLoaiKhuyenMai);

-- TAO RANG BUOC (CHECK) --------------------------------------------------------------------------------------------------

-- TAO TRIGGER ------------------------------------------------------------------------------------------------------------

-- 1. TAI KHOAN
INSERT INTO TaiKhoan (TenTaiKhoan, MatKhau, MaNhanVien, Quyen) VALUES ('admin','123456',0,'admin');
INSERT INTO TaiKhoan (TenTaiKhoan, MatKhau, MaNhanVien, Quyen) VALUES ('hung','654321',1,'user');



    
    
    
    
    