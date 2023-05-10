-- Create Database---------------------------------------------------------------------------------------------------
CREATE DATABASE CuaHangTienLoi;
USE CuaHangTienLoi;

-- Create Table------------------------------------------------------------------------------------------------------


-- 1. TAI KHOAN---------------------------------

CREATE TABLE TAIKHOAN (  
    Id int AUTO_INCREMENT PRIMARY KEY,
	TenTaiKhoan varchar(20) NOT NULL,  
    MatKhau varchar(20) NOT NULL,  
    MaNhanVien varchar(10) NOT NULL,
    MaQuyen int NOT NULL
); 

-- 2. THE KHACH HANG----------------------------
CREATE TABLE THEKHACHHANG (  
    MaTheKhachHang varchar(10) NOT NULL,  
    MaKhachhang varchar(10) NOT NULL,  
    NgayLap datetime NULL,
    TichDiem bigint NULL , 
    MaLoaiTheKhachHang int NOT NULL,
    PRIMARY KEY (MaTheKhachHang)  
);

-- 3. LOAI THE KHACH HANG----------------------------	
CREATE TABLE LOAITHEKHACHHANG (  
    MaLoaiTheKhachHang int NOT NULL,  
    TenLoaiTheKhachHang nvarchar(30) NOT NULL,  
    PRIMARY KEY (MaLoaiTheKhachHang)  
);

-- 4. KHACH HANG----------------------------	
CREATE TABLE KHACHHANG (  
    MaKhachHang varchar(10) NOT NULL,  
    HoTen nvarchar(30) NULL, 
    GioiTinh nvarchar(6) NULL, 
    NgaySinh date NULL, 
    DiaChi nvarchar(100) NULL, 
    SoDienThoai varchar(13) NULL, 
    Email varchar(30) NULL,
	HinhAnh text NULL,
    PRIMARY KEY (MaKhachHang)  
);

-- 5. NHANVIEN ----------------------------
CREATE TABLE NHANVIEN (  
    MaNhanVien varchar(10) NOT NULL,  
    HoTen nvarchar(30) NULL, 
    GioiTinh nvarchar(6) NULL, 
    NgaySinh date NULL, 
    DiaChi nvarchar(100) NULL,
    QueQuan	nvarchar(100) NULL,
    SoDienThoai varchar(13) NULL, 
    Email varchar(30) NULL,
	HinhAnh text NULL,
    PRIMARY KEY (MaNhanVien)  
);

-- 6. PHIEUXUAT ----------------------------
CREATE TABLE PHIEUXUAT (  
    MaPhieuXuat varchar(20) NOT NULL,  
    MaNhanVien varchar(10) NOT NULL, 
    MaKhachHang varchar(10) NOT NULL, 
    NgayXuat datetime NULL,
	TrangThai nvarchar(30) NULL, 
	GhiChu nvarchar(30) NULL,
    PRIMARY KEY (MaPhieuXuat)  
);


-- 7. PHIEUXUATCHITIET ----------------------------
CREATE TABLE PHIEUXUATCHITIET (  
    MaPhieuXuatChiTiet varchar(20) NOT NULL, 
    MaSanPham varchar(20) NOT NULL, 
    SoLuong int NULL, 
    PRIMARY KEY (MaPhieuXuatChiTiet,MaSanPham)  
); 

-- 8. PHIEUHUY ----------------------------
CREATE TABLE PHIEUHUY (  
    MaPhieuHuy varchar(20) NOT NULL,  
    MaNhanVien varchar(10) NOT NULL, 
    NgayHuy datetime NULL,
	TrangThai nvarchar(20) NULL,
	GhiChu nvarchar(30) NULL,
    PRIMARY KEY (MaPhieuHuy)  
); 

-- 9. PHIEUHUYCHITIET ----------------------------
CREATE TABLE PHIEUHUYCHITIET (  
    MaPhieuHuyChiTiet varchar(20) NOT NULL,   
    MaSanPham varchar(20) NOT NULL,
    SoLuong int NULL, 
    PRIMARY KEY (MaPhieuHuyChiTiet,MaSanPham)  
);

-- 10. SANPHAM ---------------------------- Mavach (EAN13)
CREATE TABLE SANPHAM (  
	MaSanPham varchar(20) NOT NULL,
    MaVach varchar(13) NOT NULL, 
    TenSanPham nvarchar(30) NULL, 
    DonGiaBan int NULL,
    DonViTinh nvarchar(30) NULL, 
    NgaySanXuat date NULL, 
    HanSuDung date NULL, 
    MaLoaiSanPham int NOT NULL, 
    MaKhuyenMai varchar(20) NOT NULL,
	HinhAnh text NULL,
    PRIMARY KEY (MaSanPham)  
);

-- 11. LOAISANPHAM ----------------------------
CREATE TABLE LOAISANPHAM (  
    MaLoaiSanPham int NOT NULL,  
    TenLoaiSanPham nvarchar(30) NOT NULL, 
    PRIMARY KEY (MaLoaiSanPham)  
);

-- 12. PHIEUNHAP ----------------------------
CREATE TABLE PHIEUNHAP (  
    MaPhieuNhap varchar(20) NOT NULL,  
    MaNhanVien varchar(10) NOT NULL, 
    MaNhaCungCap varchar(10) NOT NULL,  
    NgayNhap datetime NOT NULL,
	TrangThai Nvarchar(20) NULL,
	GhiChu Nvarchar(30) NULL,
    PRIMARY KEY (MaPhieuNhap)  
);

-- 13. PHIEUNHAPCHITIET ----------------------------
CREATE TABLE PHIEUNHAPCHITIET (  
    MaPhieuNhapChiTiet varchar(20) NOT NULL,  
    MaSanPham varchar(20) NOT NULL,  
    SoLuong int NULL,
    DonGiaNhap int NULL,
    PRIMARY KEY (MaPhieuNhapChiTiet,MaSanPham)  
);

-- 14. NHACUNGCAP ----------------------------
CREATE TABLE NHACUNGCAP (  
    MaNhaCungCap varchar(10) NOT NULL,  
    TenNhaCungCap nvarchar(30) NULL, 
    DiaChi nvarchar(100) NULL,  
    SoDienThoai varchar(13) NULL,
    Email varchar(30) NULL,
	HinhAnh text NULL,
    PRIMARY KEY (MaNhaCungCap)  
);

-- 15. KHUYENMAI ----------------------------
CREATE TABLE KHUYENMAI (  
    MaKhuyenMai varchar(20) NOT NULL,  
    MaLoaiKhuyenMai int NOT NULL, 
    GiaGiam int NULL,  
    NgayBatDau datetime NULL,
    NgayKetThuc datetime NULL,
    PRIMARY KEY (MaKhuyenMai)  
);

-- 16. LOAIKHUYENMAI ----------------------------
CREATE TABLE LOAIKHUYENMAI (  
    MaLoaiKhuyenMai int NOT NULL,  
    TenLoaiKhuyenMai nvarchar(30) NOT NULL, 
    PRIMARY KEY (MaLoaiKhuyenMai )  
);

-- 17. LOAITAIKHOAN ----------------------------
CREATE TABLE LOAITAIKHOAN (  
    MaQuyen int NOT NULL,  
    TenQuyen nvarchar(30) NOT NULL, 
    PRIMARY KEY (MaQuyen)  
);


-- 18. PHIEUDATHANG ----------------------------
CREATE TABLE PHIEUDATHANG (  
    MaPhieuDatHang varchar(20) NOT NULL,  
    MaNhanVien varchar(10) NOT NULL, 
    MaKhachHang varchar(10) NOT NULL, 
    NgayXuat datetime NULL,
	TrangThai nvarchar(30) NULL, 
	GhiChu nvarchar(30) NULL,
    PRIMARY KEY (MaPhieuDatHang)  
);


-- 19. PHIEUDATHANGCHITIET ----------------------------
CREATE TABLE PHIEUDATHANGCHITIET (  
    MaPhieuDatHangChiTiet varchar(20) NOT NULL, 
    MaSanPham varchar(20) NOT NULL, 
    SoLuong int NULL, 
    PRIMARY KEY (MaPhieuDatHangChiTiet,MaSanPham)  
); 

-- Create Foreign Key------------------------------------------------------------------------------------------------
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

-- 3. PHIEUXUAT --> NHANVIEN (MaNhanVien)
alter table PHIEUXUAT
add constraint FK_PHIEUXUAT_NHANVIEN
foreign key (MaNhanVien)
references NHANVIEN(MaNhanVien);

-- 4. PHIEUXUAT --> KHACHHANG (MaKhachhang)
alter table PHIEUXUAT
add constraint FK_PHIEUXUAT_KHACHHANG
foreign key (MaKhachhang)
references KHACHHANG(MaKhachhang);

-- 5. PHIEUXUATCHITIET --> PHIEUXUAT (MaPhieuXuatChiTiet)
alter table PHIEUXUATCHITIET
add constraint FK_PHIEUXUATCHITIET_PHIEUXUAT
foreign key (MaPhieuXuatChiTiet)
references PHIEUXUAT(MaPhieuXuat);

-- 6. PHIEUXUATCHITIET --> SANPHAM (MaSanPham)
alter table PHIEUXUATCHITIET
add constraint FK_PHIEUXUATCHITIET_SANPHAM
foreign key (MaSanPham)
references SANPHAM(MaSanPham);

-- 7. PHIEUHUY --> NHANVIEN (MaNhanVien)
alter table PHIEUHUY
add constraint FK_PHIEUHUY_NHANVIEN
foreign key (MaNhanVien)
references NHANVIEN(MaNhanVien);

-- 8. PHIEUHUYCHITIET --> PHIEUHUY (MaPhieuHuy)
alter table PHIEUHUYCHITIET
add constraint FK_PHIEUHUYCHITIET_PHIEUHUY
foreign key (MaPhieuHuyChiTiet)
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

-- 12. PHIEUNHAP --> NHANVIEN (MaNhanVien)
alter table PHIEUNHAP
add constraint FK_PHIEUNHAP_NHANVIEN
foreign key (MaNhanVien)
references NHANVIEN(MaNhanVien);

-- 13. PHIEUNHAP --> NHACUNGCAP (MaNhaCungCap)
alter table PHIEUNHAP
add constraint FK_PHIEUNHAP_NHACUNGCAP
foreign key (MaNhaCungCap)
references NHACUNGCAP(MaNhaCungCap);

-- 14. PHIEUNHAPCHITIET --> PHIEUNHAP (MaPhieuNhap)
alter table PHIEUNHAPCHITIET
add constraint FK_PHIEUNHAPCHITIET_PHIEUNHAP
foreign key (MaPhieuNhapChiTiet)
references PHIEUNHAP(MaPhieuNhap);

-- 15. PHIEUNHAPCHITIET --> SANPHAM (MaSanPham)
alter table PHIEUNHAPCHITIET
add constraint FK_PHIEUNHAPCHITIET_SANPHAM
foreign key (MaSanPham)
references SANPHAM(MaSanPham);

-- 16. KHUYENMAI --> LOAIKHUYENMAI	(MaLoaiKhuyenMai)
alter table KHUYENMAI
add constraint FK_KHUYENMAI_LOAIKHUYENMAI
foreign key (MaLoaiKhuyenMai)
references LOAIKHUYENMAI(MaLoaiKhuyenMai);

-- 17. TAIKHOAN --> LOAITAIKHOAN	(MaQuyen)
alter table TAIKHOAN
add constraint FK_TAIKHOAN_LOAITAIKHOAN
foreign key (MaQuyen)
references LOAITAIKHOAN(MaQuyen);

-- 18. PHIEUDATHANG --> NHANVIEN (MaNhanVien)
alter table PHIEUDATHANG
add constraint FK_PHIEUDATHANG_NHANVIEN
foreign key (MaNhanVien)
references NHANVIEN(MaNhanVien);

-- 18. PHIEUDATHANG --> KHACHHANG (MaKhachHang)
alter table PHIEUDATHANG
add constraint FK_PHIEUDATHANG_KHACHHANG
foreign key (MaKhachHang)
references KHACHHANG(MaKhachHang);

-- 19. PHIEUDATHANGCHITIET --> PHIEUDATHANG (MaPhieuDatHang)
alter table PHIEUDATHANGCHITIET
add constraint FK_PHIEUDATHANGCHITIET_PHIEUDATHANG
foreign key (MaPhieuDatHangChiTiet)
references PHIEUDATHANG(MaPhieuDatHang);

-- 20. PHIEUDATHANGCHITIET --> SANPHAM (MaSanPham)
alter table PHIEUDATHANGCHITIET
add constraint FK_PHIEUDATHANGCHITIET_SANPHAM
foreign key (MaSanPham)
references SANPHAM(MaSanPham);

-- Create View-------------------------------------------------------------------------------------------------------
-- 1. View_NhaCungCap	(table : NHACUNGCAP)
create View View_NhaCungCap as select * from NHACUNGCAP;

-- 2. View_KhachHang	(table : KHACHHANG) 
create view View_KhachHang as select * from KHACHHANG;

-- 3. View_NhanVien		(table : NHANVIEN)
create view View_NhanVien as select * from NHANVIEN;

-- 4. View_SanPham		(table : LOAIKHUYENMAI, KHUYENMAI, LOAISANPHAM, SANPHAM)
create view View_SanPham as
	select SP.MaSanPham, SP.MaVach, SP.TenSanPham, SP.DonGiaBan, SP.DonViTinh, SP.NgaySanXuat, SP.HanSuDung, SP.HinhAnh, SP.MaLoaiSanPham, LSP.TenLoaiSanPham, SP.MaKhuyenMai, KM.GiaGiam, KM.NgayBatDau, KM.NgayKetThuc, KM.MaLoaiKhuyenMai, LKM.TenLoaiKhuyenMai
	from SANPHAM as SP
	inner join LOAISANPHAM as LSP on SP.MaLoaiSanPham=LSP.MaLoaiSanPham
	inner join KHUYENMAI as KM on SP.MaKhuyenMai=KM.MaKhuyenMai
	inner join LOAIKHUYENMAI as LKM on KM.MaLoaiKhuyenMai=LKM.MaLoaiKhuyenMai ;

-- 5. View_TheKhachHang
create view View_TheKhachHang as
	select KH.MaKhachHang, KH.HoTen, TKH.MaTheKhachHang, TKH.NgayLap, TKH.TichDiem, TKH.MaLoaiTheKhachHang, L.TenLoaiTheKhachHang 
	from KHACHHANG as KH
	inner join THEKHACHHANG as TKH on KH.MaKhachHang = TKH.MaKhachhang
	inner join LOAITHEKHACHHANG as L on TKH.MaLoaiTheKhachHang = L.MaLoaiTheKhachHang;

-- 6. View_LoaiTheKhachHang
create view View_LoaiTheKhachHang as select * from LOAITHEKHACHHANG;
	
-- 7. View_LoaiKhuyenMai
create view View_LoaiKhuyenMai as select * from LOAIKHUYENMAI;	

-- 8. View_KhuyenMai
create view View_KhuyenMai as select * from KHUYENMAI;	

-- 9. View_LoaiSanPham
create view View_LoaiSanPham as select * from LOAISANPHAM;

-- 10. View_BanHang
create view View_BanHang as
	select PX.MaPhieuXuat, PX.NgayXuat ,PX.MaNhanVien, PX.MaKhachHang, PXCT.MaSanPham, SP.TenSanPham , SP.DonGiaBan, SP.DonViTinh, KM.GiaGiam,PXCT.SoLuong, PX.TrangThai, PX.GhiChu, (SP.DonGiaBan - SP.DonGiaBan*KM.GiaGiam)*PXCT.SoLuong as ThanhTien 
	from PHIEUXUAT as PX
	CROSS JOIN PHIEUXUATCHITIET as PXCT on PX.MaPhieuXuat = PXCT.MaPhieuXuatChiTiet
	LEFT JOIN SANPHAM as SP on PXCT.MaSanPham = SP.MaSanPham
	LEFT JOIN KHUYENMAI as KM on SP.MaKhuyenMai = KM.MaKhuyenMai;
    
-- 11. View_NhapHang
create view View_NhapHang as
	select PN.MaPhieuNhap, PN.NgayNhap ,PN.MaNhanVien, PN.MaNhaCungCap, PNCT.MaSanPham, SP.TenSanPham , PNCT.DonGiaNhap, SP.DonViTinh, PNCT.SoLuong, PN.TrangThai, PN.GhiChu, PNCT.DonGiaNhap*PNCT.SoLuong as ThanhTien 
	from PHIEUNHAP as PN
	CROSS JOIN PHIEUNHAPCHITIET as PNCT on PN.MaPhieuNhap = PNCT.MaPhieuNhapChiTiet
	LEFT JOIN SANPHAM as SP on PNCT.MaSanPham = SP.MaSanPham;	

-- 12. View_HuyHang
create view View_HuyHang as
	select PH.MaPhieuHuy, PH.NgayHuy ,PH.MaNhanVien, PHCT.MaSanPham, SP.TenSanPham, SP.DonGiaBan ,SP.DonViTinh, PHCT.SoLuong, PH.TrangThai, PH.GhiChu, SP.DonGiaBan*PHCT.SoLuong as ThanhTien 
	from PHIEUHUY as PH
	CROSS JOIN PHIEUHUYCHITIET as PHCT on PH.MaPhieuHuy = PHCT.MaPhieuHuyChiTiet
	LEFT JOIN SANPHAM as SP on PHCT.MaSanPham = SP.MaSanPham;
-- 13. View_DatHang


-- Create Procedure--------------------------------------------------------------------------------------------------
-- 1. TAI KHOAN  

-- Proc dang nhap
DELIMITER $$  
CREATE PROCEDURE proc_login (IN _username varchar(20), IN _password varchar(20))
BEGIN
	select * from TAIKHOAN where TenTaiKhoan=_username AND MatKhau=_password ;
END $$
DELIMITER ;
-- CALL proc_login('admin','123456');

-- 1.1. Them
DELIMITER $$ 
CREATE PROCEDURE addTAIKHOAN (IN _TenTaiKhoan varchar(20), IN _MatKhau varchar(20), IN _MaNhanVien varchar(10), IN _MaQuyen int)
BEGIN
	insert into TAIKHOAN(TenTaiKhoan, MatKhau, MaNhanVien, MaQuyen) values (_TenTaiKhoan, _MatKhau, _MaNhanVien, _MaQuyen);
END $$
DELIMITER ;
-- CALL addTAIKHOAN ('hung','123456','NV1232212',2);

-- 1.2. Sua
DELIMITER $$
CREATE PROCEDURE updateTAIKHOAN (IN _Id int, IN _TenTaiKhoan varchar(20), IN _MatKhau varchar(20), IN _MaNhanVien varchar(10), IN _MaQuyen int)
BEGIN
	SET SQL_SAFE_UPDATES = 0;
	update TAIKHOAN 
	set TenTaiKhoan=_TenTaiKhoan, MatKhau=_MatKhau, MaNhanVien=_MaNhanVien, MaQuyen=_MaQuyen
	where Id= _Id;
    SET SQL_SAFE_UPDATES = 1;
END $$
DELIMITER ;
-- CALL updateTAIKHOAN (3,'nhat','456','NV12322254',2);

-- 1.3. Xoa
DELIMITER $$
CREATE PROCEDURE deleteTAIKHOAN(IN _Id int)
BEGIN
	delete from TAIKHOAN
	where Id=_Id ;
END $$
DELIMITER ;
-- CALL deleteTAIKHOAN (2);
-- select * from TAIKHOAN;

-- 2. NHA CUNG CAP
-- 2.1. Them
DELIMITER $$
CREATE PROCEDURE addNhaCungCap
(IN _MaNhaCungCap varchar(10), IN _TenNhaCungCap nvarchar(30), IN _DiaChi nvarchar(100), IN _SoDienThoai varchar(13), IN _Email varchar(30), IN _HinhAnh text )
BEGIN
	insert into NHACUNGCAP (MaNhaCungCap, TenNhaCungCap, DiaChi, SoDienThoai, Email, HinhAnh) values (_MaNhaCungCap, _TenNhaCungCap, _DiaChi, _SoDienThoai, _Email, _HinhAnh);
END $$
DELIMITER ;
-- CALL addNhaCungCap ('NCC0215235', N'Vinamilk', N'Hồ chí Minh', '02854161226', 'vinamilk@vinamilk.com.vn', 'https://www.vinamilk.com.vn/static/tpl/dist/assets/images/pages/contact/headquarter.jpg');
-- CALL addNhaCungCap ('NCC0215232', N'AceCook', N'Hồ chí Minh', '02854161226', 'vinamilk@vinamilk.com.vn', 'https://www.vinamilk.com.vn/static/tpl/dist/assets/images/pages/contact/headquarter.jpg');
-- 2.2. Sua
DELIMITER $$
CREATE PROCEDURE updateNhaCungCap
(IN _MaNhaCungCap varchar(10), IN _TenNhaCungCap nvarchar(30), IN _DiaChi nvarchar(100), IN _SoDienThoai varchar(13), IN _Email varchar(30), IN _HinhAnh text )
BEGIN
	SET SQL_SAFE_UPDATES = 0;
	update NHACUNGCAP 
	set TenNhaCungCap=_TenNhaCungCap, DiaChi=_DiaChi, SoDienThoai=_SoDienThoai, Email=_Email, HinhAnh=_HinhAnh
	where MaNhaCungCap=_MaNhaCungCap;
    SET SQL_SAFE_UPDATES = 1;
END $$
DELIMITER ;
-- CALL updateNhaCungCap ('NCC0215235', N'Vinamilk', N'10 Tân Trào, Tân Phú, Quận 7, Thành phố Hồ Chí Minh, Vietnam', '02854161226', 'vinamilk@vinamilk.com.vn', 'https://www.vinamilk.com.vn/static/tpl/dist/assets/images/pages/contact/headquarter.jpg');

-- 2.3. Xoa
DELIMITER $$
CREATE PROCEDURE deleteNHACUNGCAP(IN _MaNhaCungCap varchar(10))
BEGIN
	delete from NHACUNGCAP
	where MaNhaCungCap=_MaNhaCungCap;
END $$
DELIMITER ;
-- CALL deleteNHACUNGCAP ('NCC0215235');
-- select * from NHACUNGCAP

-- 2.4. Truy van
DELIMITER $$
CREATE PROCEDURE queryNHACUNGCAP()
BEGIN
	select * from View_NhaCungCap;
END $$
DELIMITER ;
-- CALL queryNHACUNGCAP;

--2.5. Tim kiem
DELIMITER $$
CREATE PROCEDURE searchNHACUNGCAP(IN _TenNhaCungCap nvarchar(30))
BEGIN
	select * from View_NhaCungCap where TenNhaCungCap LIKE CONCAT('%', _TenNhaCungCap,'%');
END $$
DELIMITER ;
-- CALL searchNHACUNGCAP ('ace');

-- 3. NHANVIEN
-- 3.1. Them
DELIMITER $$
CREATE PROCEDURE addNhanVien
(IN _MaNhanVien varchar(10), IN _HoTen nvarchar(30), IN _GioiTinh nvarchar(6), IN _NgaySinh date, IN _DiaChi nvarchar(100), IN _QueQuan nvarchar(100), IN _SoDienThoai varchar(13), IN _Email varchar(30), IN _HinhAnh text )
BEGIN
	insert into NHANVIEN(MaNhanVien, HoTen, GioiTinh, NgaySinh, DiaChi, QueQuan, SoDienThoai, Email, HinhAnh) values (_MaNhanVien, _HoTen, _GioiTinh, _NgaySinh, _DiaChi, _QueQuan, _SoDienThoai, _Email, _HinhAnh);
END $$
DELIMITER ;
-- CALL addNhanVien ('NV23215684', N'Nguyễn Văn Hùng ', N'Nam', '1995-05-06', N'Quận 2, TPHCM', N'Thanh Hóa', '0344646445', 'hungnguyen@gmail.com', 'https://toigingiuvedep.vn/wp-content/uploads/2021/07/mau-anh-the-dep-nam-450x600.jpeg');
-- CALL addNhanVien ('NV12322255', N'Bùi Thị Ngọc Nhung', N'Nữ', '1993-08-05', N'Quận 3, TPHCM', N'Hải Phòng', '0344546446', 'nhungbui@gmail.com', 'https://toigingiuvedep.vn/wp-content/uploads/2021/07/mau-anh-the-dep-nu-400x600.jpg');

-- 3.2. Sua
DELIMITER $$
CREATE PROCEDURE updateNhanVien
(IN _MaNhanVien varchar(10), IN _HoTen nvarchar(30), IN _GioiTinh nvarchar(6), IN _NgaySinh date, IN _DiaChi nvarchar(100), IN _QueQuan nvarchar(100), IN _SoDienThoai varchar(13), IN _Email varchar(30), IN _HinhAnh text )
BEGIN
	SET SQL_SAFE_UPDATES = 0;
	update NHANVIEN
	set HoTen=_HoTen, GioiTinh=_GioiTinh, NgaySinh=_NgaySinh, DiaChi=_DiaChi, QueQuan=_QueQuan, SoDienThoai=_SoDienThoai, Email=_Email, HinhAnh=_HinhAnh
	where MaNhanVien=_MaNhanVien;
    SET SQL_SAFE_UPDATES = 1;
END $$
DELIMITER ;
-- CALL updateNhanVien ('NV12322255', N'Bùi Thị Ngọc Nhung', N'Nữ', '1993-06-05', N'Quận 3, TPHCM', N'Hải Phòng', '0344546446', 'nhungbui@gmail.com', 'https://toigingiuvedep.vn/wp-content/uploads/2021/07/mau-anh-the-dep-nu-400x600.jpg');

-- 3.3. Xoa
DELIMITER $$
CREATE PROCEDURE deleteNhanVien (IN _MaNhanVien varchar(10))
BEGIN
	delete from NHANVIEN
	where MaNhanVien=_MaNhanVien;
END $$
DELIMITER ;
-- CALL deleteNhanVien ('NV23215684');
-- select * from NHANVIEN

-- 3.4. Truy van
DELIMITER $$
CREATE PROCEDURE showNhanVien()
BEGIN
	select * from View_NhanVien;
END $$
DELIMITER ;
-- CALL showNhanVien;

-- 3.5. Tim kiem

DELIMITER $$
CREATE PROCEDURE searchNHANVIEN(IN _HoTen nvarchar(30))
BEGIN
	select * from View_NhanVien where HoTen LIKE CONCAT('%',_HoTen,'%');
END $$
DELIMITER ;
-- CALL searchNHANVIEN (N'inn');

-- 4. KHACHHANG
-- 4.1. Them
DELIMITER $$
CREATE PROCEDURE addKhachHang
(IN _MaKhachHang varchar(10), IN _HoTen nvarchar(30), IN _GioiTinh nvarchar(6), IN _NgaySinh date, IN _DiaChi nvarchar(100), IN _SoDienThoai varchar(13), IN _Email varchar(30), IN _HinhAnh text )
BEGIN
	insert into KHACHHANG (MaKhachHang, HoTen, GioiTinh, NgaySinh, DiaChi, SoDienThoai, Email, HinhAnh) values (_MaKhachHang, _HoTen, _GioiTinh, _NgaySinh, _DiaChi, _SoDienThoai, _Email, _HinhAnh);
END $$
DELIMITER ;
-- CALL addKhachHang ('KH00000000', N'Khách Hàng Mặc Định','','0000-00-00','','','','');
-- CALL addKhachHang ('KH12563258', N'Nguyễn Văn An', N'Nam', '1995-02-03', N'Quận 5, TPHCM', '0325648987', 'annguyenvan@gmail.com', 'https://toigingiuvedep.vn/wp-content/uploads/2021/07/mau-anh-the-nam-sinh.jpeg');

-- 4.2. Sua
DELIMITER $$
CREATE PROCEDURE updateKhachHang
(IN _MaKhachHang varchar(10), IN _HoTen nvarchar(30), IN _GioiTinh nvarchar(6), IN _NgaySinh date, IN _DiaChi nvarchar(100), IN _SoDienThoai varchar(13), IN _Email varchar(30), IN _HinhAnh text )
BEGIN
	SET SQL_SAFE_UPDATES = 0;
	update KHACHHANG
	set HoTen=_HoTen, GioiTinh=_GioiTinh, NgaySinh=_NgaySinh, DiaChi=_DiaChi, SoDienThoai=_SoDienThoai, Email=_Email, HinhAnh=_HinhAnh 
	where MaKhachHang = _MaKhachHang;
    SET SQL_SAFE_UPDATES = 1;
END $$
DELIMITER ;
-- CALL updateKhachHang ('KH12563258', N'Nguyễn Văn An', N'Nam', '1995-02-03', N'Quận 4, TPHCM', '0325648987', 'annguyenvan@gmail.com', 'https://toigingiuvedep.vn/wp-content/uploads/2021/07/mau-anh-the-nam-sinh.jpeg');

-- 4.3. Xoa
DELIMITER $$
CREATE PROCEDURE deleteKhachHang (IN _MaKhachHang varchar(10))
BEGIN
	delete from KHACHHANG
	where MaKhachHang = _MaKhachHang;
END $$
DELIMITER ;
CALL deleteKhachHang ('KH00000000');
-- select * from KHACHHANG

-- 4.4. Truy van
DELIMITER $$
CREATE PROCEDURE showKhachHang()
BEGIN
	select * from View_KhachHang;
END $$
DELIMITER ;
-- CALL showKhachHang;

-- 4.5. Tim kiem

DELIMITER $$
CREATE PROCEDURE searchKHACHHANG(IN _HoTen nvarchar(30))
BEGIN
	select * from View_KhachHang where HoTen LIKE CONCAT('%', _HoTen , '%');
END $$
DELIMITER ;
-- CALL searchKHACHHANG (N'an');

-- 5. LOAITHEKHACHHANG
-- 5.1. Them
DELIMITER $$
CREATE PROCEDURE addLoaiTheKhachHang
(IN _MaLoaiTheKhachHang int, IN _TenLoaiTheKhachHang nvarchar(30))
BEGIN
	insert into LOAITHEKHACHHANG (MaLoaiTheKhachHang,TenLoaiTheKhachHang) values (_MaLoaiTheKhachHang, _TenLoaiTheKhachHang);
END $$
DELIMITER ;
-- CALL addLoaiTheKhachHang (1, N'Đồng');
-- CALL addLoaiTheKhachHang (2, N'Bạc');
-- CALL addLoaiTheKhachHang (3, N'Vàng');
-- CALL addLoaiTheKhachHang (4, N'Bạch Kim');

-- 5.2. sua
DELIMITER $$
CREATE PROCEDURE updateLoaiTheKhachHang
(IN _MaLoaiTheKhachHang int, IN _TenLoaiTheKhachHang nvarchar(30))
BEGIN
	SET SQL_SAFE_UPDATES = 0;
	update LOAITHEKHACHHANG
	set TenLoaiTheKhachHang=_TenLoaiTheKhachHang
	where MaLoaiTheKhachHang=_MaLoaiTheKhachHang;
    SET SQL_SAFE_UPDATES = 1;
END $$
DELIMITER ;
-- CALL updateLoaiTheKhachHang (4, N'Kim Cương');

-- 5.3. Xoa
DELIMITER $$
CREATE PROCEDURE deleteLoaiTheKhachHang
(IN _MaLoaiTheKhachHang int)
BEGIN
	delete from LOAITHEKHACHHANG
	where MaLoaiTheKhachHang=_MaLoaiTheKhachHang;
END $$
DELIMITER ;
-- CALL deleteLoaiTheKhachHang (4);
-- select * from LOAITHEKHACHHANG

-- 5.4. Truy van
DELIMITER $$
CREATE PROCEDURE showLoaiTheKhachHang()
BEGIN
	select MaLoaiTheKhachHang, TenLoaiTheKhachHAng from View_LoaiTheKhachHang;	
END $$
DELIMITER ;
-- CALL showLoaiTheKhachHang;

-- 5.5. Tim kiem
DELIMITER $$
CREATE PROCEDURE searchTHEKHACHHANG(IN _HoTen nvarchar(30))
BEGIN
	select * from View_TheKhachHang where HoTen LIKE CONCAT('%', _HoTen, '%');
END $$
DELIMITER ;
-- CALL searchTHEKHACHHANG (N'');



-- 6. THEKHACHHANG
-- 6.1. Them
DELIMITER $$
CREATE PROCEDURE addTheKhachHang
(IN _MaTheKhachHang varchar(10), IN _MaKhachHang varchar(10), IN _NgayLap datetime, IN _TichDiem bigint, IN _MaLoaiTheKhachHang int)
BEGIN
	insert into THEKHACHHANG (MaTheKhachHang,MaKhachhang,NgayLap,TichDiem,MaLoaiTheKhachHang) values (_MaTheKhachHang, _MaKhachhang, _NgayLap, _TichDiem, _MaLoaiTheKhachHang);
END $$
DELIMITER ;
-- CALL addTheKhachHang ('TKH2365897', 'KH12563258', '2023-03-24 10:34:09', 0, 1);

-- 6.2. Sua
DELIMITER $$
CREATE PROCEDURE updateTheKhachHang
(IN _MaTheKhachHang varchar(10), IN _MaKhachHang varchar(10), IN _NgayLap datetime, IN _TichDiem bigint, IN _MaLoaiTheKhachHang int)
BEGIN
	SET SQL_SAFE_UPDATES = 0;
	update THEKHACHHANG
	set MaKhachhang=_MaKhachHang, NgayLap=_NgayLap, TichDiem=_TichDiem, MaLoaiTheKhachHang=_MaLoaiTheKhachHang
	where MaTheKhachHang=_MaTheKhachHang;
    SET SQL_SAFE_UPDATES = 1;
END $$
DELIMITER ;
-- CALL updateTheKhachHang ('TKH2365897', 'KH12563258', '2023-03-24 10:34:09', 100, 1);

-- 6.3. Xoa
DELIMITER $$
CREATE PROCEDURE deleteTheKhachHang 
(IN _MaTheKhachHang varchar(10))
BEGIN
	delete from THEKHACHHANG
	where MaTheKhachHang=_MaTheKhachHang;
END $$
DELIMITER ;
-- CALL deleteTheKhachHang ('TKH2365898');
-- select * from THEKHACHHANG

-- 6.4. Truy van
DELIMITER $$
CREATE PROCEDURE showTheKhachHang()
BEGIN
	select * from View_TheKhachHang;
END $$
DELIMITER ;
-- CALL showTheKhachHang;


-- 7. LOAIKHUYENMAI
-- 7.1. Them
DELIMITER $$
CREATE PROCEDURE addLoaiKhuyenMai
(IN _MaLoaiKhuyenMai int, IN _TenLoaiKhuyenMai nvarchar(30))
BEGIN
	insert into LOAIKHUYENMAI (MaLoaiKhuyenMai, TenLoaiKhuyenMai) values (_MaLoaiKhuyenMai, _TenLoaiKhuyenMai);
END $$
DELIMITER ;
-- CALL addLoaiKhuyenMai (1, N'Mặc định');
-- CALL addLoaiKhuyenMai (2, N'Giảm giá');
-- CALL addLoaiKhuyenMai (3, N'Quà tặng');

-- 7.2. Sua
DELIMITER $$
CREATE PROCEDURE updateLoaiKhuyenMai
(IN _MaLoaiKhuyenMai int, IN _TenLoaiKhuyenMai nvarchar(30))
BEGIN
	SET SQL_SAFE_UPDATES = 0;
	update LOAIKHUYENMAI
	set TenLoaiKhuyenMai=_TenLoaiKhuyenMai
	where MaLoaiKhuyenMai=_MaLoaiKhuyenMai;
    SET SQL_SAFE_UPDATES = 1;
END $$
DELIMITER ;
-- CALL updateLoaiKhuyenMai (1, N'Mặc định không giảm giá');

-- 7.3. Xoa
DELIMITER $$
CREATE PROCEDURE deleteLoaiKhuyenMai
(IN _MaLoaiKhuyenMai int)
BEGIN
	delete from LOAIKHUYENMAI
	where MaLoaiKhuyenMai=_MaLoaiKhuyenMai;
END $$
DELIMITER ;
-- CALL deleteLoaiKhuyenMai (3);
-- select * from LOAIKHUYENMAI

-- 7.4. Truy van
DELIMITER $$
CREATE PROCEDURE  showLoaiKhuyenMai()
BEGIN
	select * from View_LoaiKhuyenMai;
END $$
DELIMITER ;
-- CALL showLoaiKhuyenMai;

-- 8. KHUYENMAI
-- 8.1. Them
DELIMITER $$
CREATE PROCEDURE addKhuyenMai
(IN _MaKhuyenMai varchar(20), IN _MaLoaiKhuyenMai int, IN _GiaGiam int, IN _NgayBatDau datetime, IN _NgayKetThuc datetime)
BEGIN
	insert into KHUYENMAI (MaKhuyenMai,MaLoaiKhuyenMai,GiaGiam, NgayBatDau, NgayKetThuc) values (_MaKhuyenMai, _MaLoaiKhuyenMai, _GiaGiam, _NgayBatDau, _NgayKetThuc);
END $$
DELIMITER ;
-- CALL addKhuyenMai ('KM000000', 1, 0,'2000-03-24 10:34:09','2050-03-28 10:34:09'); 
-- CALL addKhuyenMai ('KM202303123458', 2, 20,'2023-03-24 10:34:09','2023-03-28 10:34:09');

-- 8.2. Sua
DELIMITER $$
CREATE PROCEDURE updateKhuyenMai
(IN _MaKhuyenMai varchar(20), IN _MaLoaiKhuyenMai int, IN _GiaGiam int, IN _NgayBatDau datetime, IN _NgayKetThuc datetime)
BEGIN
	SET SQL_SAFE_UPDATES = 0;
	update KHUYENMAI
	set MaLoaiKhuyenMai=_MaLoaiKhuyenMai, GiaGiam=_GiaGiam, NgayBatDau=_NgayBatDau, NgayKetThuc=_NgayKetThuc
	where MaKhuyenMai=_MaKhuyenMai;
    SET SQL_SAFE_UPDATES = 1;
END $$
DELIMITER ;
-- CALL updateKhuyenMai ('KM202303123458',2,15,'2023-03-24 10:34:09','2023-03-28 10:34:09'); 

-- 8.3. Xoa
DELIMITER $$
CREATE PROCEDURE deleteKhuyenMai
(IN _MaKhuyenMai varchar(20))
BEGIN
	delete from KHUYENMAI
	where MaKhuyenMai=_MaKhuyenMai;
END $$
DELIMITER ;
-- CALL deleteKhuyenMai ('KM000000');
-- select * from KHUYENMAI

-- 8.4. Truy van
DELIMITER $$
CREATE PROCEDURE showKhuyenMai()
BEGIN
	select * from View_KhuyenMai;
END $$
DELIMITER ;
-- CALL showKhuyenMai;

-- 8.5. Tim kiem
DELIMITER $$
CREATE PROCEDURE searchKHUYENMAI(IN _MaKhuyenMai varchar(20))
BEGIN
	select * from View_KhuyenMai where MaKhuyenMai LIKE CONCAT('%', _MaKhuyenMai ,'%');
END $$
DELIMITER ;
-- CALL searchKHUYENMAI (N'20230312');


-- 9. LOAISANPHAM
-- 9.1. Them
DELIMITER $$
CREATE PROCEDURE addLoaiSanPham
(_MaLoaiSanPham int, _TenLoaiSanPham nvarchar(30))
BEGIN
	insert into LOAISANPHAM (MaLoaiSanPham, TenLoaiSanPham) values (_MaLoaiSanPham, _TenLoaiSanPham);
END $$
DELIMITER ;

-- CALL addLoaiSanPham (1, N'Mì,miến,phở,cháo');
-- CALL addLoaiSanPham (2, N'Sữa các loại');
-- CALL addLoaiSanPham (3, N'Thịt,cá,trứng');
-- CALL addLoaiSanPham (4, N'Hải sản');
-- CALL addLoaiSanPham (5, N'Rau,củ,nấm,trái cây');
-- CALL addLoaiSanPham (6, N'Gạo,bột,đồ khô');
-- CALL addLoaiSanPham (7, N'Bánh kẹo các loại');
-- CALL addLoaiSanPham (8, N'Bia,nước ngọt');
-- CALL addLoaiSanPham (9, N'Thực phẩm đông lạnh');
-- CALL addLoaiSanPham (10, N'Đồ dùng gia đình');

-- 9.2. Sua
DELIMITER $$
CREATE PROCEDURE updateLoaiSanPham
(_MaLoaiSanPham int, _TenLoaiSanPham nvarchar(30))
BEGIN
	SET SQL_SAFE_UPDATES = 0;
	update LOAISANPHAM
	set TenLoaiSanPham=_TenLoaiSanPham
	where MaLoaiSanPham=_MaLoaiSanPham;
    SET SQL_SAFE_UPDATES = 1;
END $$
DELIMITER ;
-- CALL updateLoaiSanPham(3,N'Thịt,trứng,cá');

-- 9.3. Xoa
DELIMITER $$
CREATE PROCEDURE deleteLoaiSanPham
(_MaLoaiSanPham int)
BEGIN
	delete from LOAISANPHAM
	where MaLoaiSanPham=_MaLoaiSanPham;
END $$
DELIMITER ;
-- CALL deleteLoaiSanPham(10)

-- 9.4. Truy van
DELIMITER $$
CREATE PROCEDURE showLoaiSanPham()
BEGIN
	select * from View_LoaiSanPham;
END $$
DELIMITER ;


-- 10. SANPHAM
-- 10.1. Them
DELIMITER $$
CREATE PROCEDURE addSanPham
(_MaSanPham varchar(20), _MaVach varchar(13), _TenSanPham nvarchar(30), _DonGiaBan int, _DonViTinh nvarchar(30), _NgaySanXuat date, _HanSuDung date, _MaLoaiSanPham int, _MaKhuyenMai varchar(20), _HinhAnh text)
BEGIN
	insert into SANPHAM (MaSanPham, MaVach, TenSanPham, DonGiaBan, DonViTinh , NgaySanXuat, HanSuDung , MaLoaiSanPham, MaKhuyenMai, HinhAnh) values (_MaSanPham, _MaVach, _TenSanPham, _DonGiaBan, _DonViTinh , _NgaySanXuat, _HanSuDung , _MaLoaiSanPham, _MaKhuyenMai, _HinhAnh);
END $$
DELIMITER ;
-- CALL addSanPham('SP1235468811521','1235485698547',N'Mì tôm 3 miền',93000,N'Thùng','2023-03-20','2023-09-20',1,'KM000000','https://cdn.tgdd.vn/Products/Images/2565/80211/bhx/thung-30-goi-mi-3-mien-tom-chua-cay-65g-202205171132088241_300x300.jpg');
-- CALL addSanPham('SP1235468811522','1235485698548',N'Sữa tươi Harvey Fresh',39000,N'Hộp','2023-03-20','2023-06-20',2,'KM000000','https://cdn.tgdd.vn/Products/Images/2386/164547/bhx/sua-tuoi-tiet-trung-it-beo-harvey-fresh-hop-1-lit-202301071053049374.jpg');
-- CALL addSanPham('SP1235468811523','1235485698549',N'Cam sành 1kg',29000,N'Kg','2023-03-20','2023-04-20',3,'KM000000','https://cdn.tgdd.vn/Products/Images/8788/235006/bhx/cam-sanh-tui-1kg-3-4-trai-202211011331467096_300x300.jpg');
-- CALL addSanPham('SP1235468811524','1235485698550',N'Thùng 48 bịch sữa',325000,N'Thùng','2023-03-20','2023-09-20',2,'KM000000','https://cdn.tgdd.vn/Products/Images/2386/85837/bhx/thung-48-bich-sua-dinh-duong-co-duong-vinamilk-a-d3-220ml-202302270845500732_300x300.jpg');

-- 10.2. Sua
DELIMITER $$
CREATE PROCEDURE updateSanPham
(_MaSanPham varchar(20), _MaVach varchar(13), _TenSanPham nvarchar(30), _DonGiaBan int, _DonViTinh nvarchar(30), _NgaySanXuat date, _HanSuDung date, _MaLoaiSanPham int, _MaKhuyenMai varchar(20), _HinhAnh text)
BEGIN
	SET SQL_SAFE_UPDATES = 0;
	update SANPHAM
	set MaVach=_MaVach, TenSanPham=_TenSanPham, DonGiaBan=_DonGiaBan, DonViTinh=_DonViTinh , NgaySanXuat=_NgaySanXuat, HanSuDung=_HanSuDung , MaLoaiSanPham=_MaLoaiSanPham, MaKhuyenMai=_MaKhuyenMai, HinhAnh=_HinhAnh
	where MaSanPham=_MaSanPham;
    SET SQL_SAFE_UPDATES = 1;
END $$
DELIMITER ;
-- CALL updateSanPham('SP1235468811523','1235485698549',N'Cam sành 1kg',32000,N'Kg','2023-03-20','2023-04-20',3,'KM000000','https://cdn.tgdd.vn/Products/Images/8788/235006/bhx/cam-sanh-tui-1kg-3-4-trai-202211011331467096_300x300.jpg');

-- 10.3. Xoa
DELIMITER $$
CREATE PROCEDURE deleteSanPham
(_MaSanPham varchar(20))
BEGIN
	delete from SANPHAM
	where MaSanPham=_MaSanPham;
END $$
DELIMITER ;
-- CALL deleteSanPham('SP1235468811524');

-- 10.4. Truy van
DELIMITER $$
CREATE PROCEDURE showSanPham()
BEGIN
	select MaSanPham, MaVach, MaLoaiSanPham, TenLoaiSanPham, TenSanPham, DonGiaBan, DonViTinh, NgaySanXuat, HanSuDung, HinhAnh, MaKhuyenMai, TenLoaiKhuyenMai, GiaGiam, NgayBatDau, NgayKetThuc  
	from View_SanPham;
END $$
DELIMITER ;
-- CALL showSanPham();

-- 10.5. Tim kiem
DELIMITER $$
CREATE PROCEDURE searchSANPHAM(_TenSanPham nvarchar(30))
BEGIN
	select MaSanPham, MaVach, MaLoaiSanPham, TenLoaiSanPham, TenSanPham, DonGiaBan, DonViTinh, NgaySanXuat, HanSuDung, HinhAnh, MaKhuyenMai, TenLoaiKhuyenMai, GiaGiam, NgayBatDau, NgayKetThuc  
	from View_SanPham where TenSanPham LIKE concat('%',_TenSanPham,'%');
END $$
DELIMITER ;
-- CALL searchSANPHAM(N'mì');

-- 10.6. Tim kiem nhieu tham so
DELIMITER $$
CREATE PROCEDURE searchSANPHAMBANHANG
(_TenSanPham nvarchar(30), _MaVach varchar(13), _MaSanPham varchar(20))
BEGIN
	select MaSanPham, MaVach, MaLoaiSanPham, TenLoaiSanPham, TenSanPham, DonGiaBan, DonViTinh, NgaySanXuat, HanSuDung, HinhAnh, MaKhuyenMai, TenLoaiKhuyenMai, GiaGiam, NgayBatDau, NgayKetThuc  
	from View_SanPham where TenSanPham LIKE concat('%',_TenSanPham,'%') or MaVach LIKE concat('%',_MaVach,'%') or MaSanPham LIKE concat('%',_MaSanPham,'%');
END $$
DELIMITER ;
-- CALL searchSANPHAMBANHANG(N'00','1235485698547','00');

-- 11. PHIEUNHAP
-- 11.1. Them
DELIMITER $$
CREATE PROCEDURE addPhieuNhap
(_MaPhieuNhap varchar(20), _MaNhanVien varchar(10), _MaNhaCungCap varchar(10), _NgayNhap datetime, _TrangThai nvarchar(20), _GhiChu nvarchar(30))
BEGIN
	insert into PHIEUNHAP (MaPhieuNhap,MaNhanVien,MaNhaCungCap,NgayNhap, TrangThai, GhiChu) values (_MaPhieuNhap, _MaNhanVien, _MaNhaCungCap, _NgayNhap, _TrangThai, _GhiChu);
END $$
DELIMITER ;
-- CALL addPhieuNhap('PN123456789212235', 'NV12322255', 'NCC0215235', '2023-03-20 10:34:09', N'Chưa thanh toán', N'Ghi chú'); 
-- CALL addPhieuNhap('PN123456789212251', 'NV12322255', 'NCC0215235', '2023-03-20 10:34:09', N'Chưa thanh toán', N'Ghi chú'); 

-- 11.2. Sua
DELIMITER $$
CREATE PROCEDURE updatePhieuNhap
(_MaPhieuNhap varchar(20), _MaNhanVien varchar(10), _MaNhaCungCap varchar(10), _NgayNhap datetime,_GhiChu nvarchar(30))
BEGIN
	SET SQL_SAFE_UPDATES = 0;
	update PHIEUNHAP
	set MaNhanVien=_MaNhanVien, MaNhaCungCap=_MaNhaCungCap, NgayNhap=_NgayNhap, GhiChu = _GhiChu
	where MaPhieuNhap=_MaPhieuNhap;
    SET SQL_SAFE_UPDATES = 1;
END $$
DELIMITER ; 
-- CALL updatePhieuNhap('PN123456789212235', 'NV12322255', 'NCC0215235', '2023-03-20 10:34:09', N'cập nhật'); 

-- 11.2.2. Sua --> Update TrangThai PhieuNhap
DELIMITER $$
CREATE PROCEDURE updateTrangThaiPhieuNhap
(_MaPhieuNhap varchar(20), _TrangThai varchar(30))
BEGIN
	SET SQL_SAFE_UPDATES = 0;
	update PHIEUNHAP
	set TrangThai = _TrangThai
	where MaPhieuNhap=_MaPhieuNhap;
    SET SQL_SAFE_UPDATES = 1;
END $$
DELIMITER ;
CALL updateTrangThaiPhieuNhap('PN123456789212235',  N'Đã thanh toán');

-- 11.3. Xoa
DELIMITER $$
CREATE PROCEDURE deletePhieuNhap
(_MaPhieuNhap varchar(20))
BEGIN
	delete from PHIEUNHAP
	where MaPhieuNhap=_MaPhieuNhap;	
END $$
DELIMITER ;
-- CALL deletePhieuNhap('PN123456789212235');

-- 12. PHIEUNHAPCHITIET
-- 12.1. Them
DELIMITER $$
CREATE PROCEDURE addPhieuNhapChiTiet
(_MaPhieuNhapChiTiet varchar(20), _MaSanPham varchar(20), _SoLuong int, _DonGiaNhap int)
BEGIN
	insert into PHIEUNHAPCHITIET(MaPhieuNhapChiTiet, MaSanPham, SoLuong, DonGiaNhap) values (_MaPhieuNhapChiTiet, _MaSanPham, _SoLuong, _DonGiaNhap);
END $$
DELIMITER ;
-- CALL addPhieuNhapChiTiet('PN123456789212235','SP1235468811523',10, 20000); 

-- 12.2. Sua
DELIMITER $$
CREATE PROCEDURE updatePhieuNhapChiTiet
(_MaPhieuNhapChiTiet varchar(20), _MaSanPham varchar(20), _SoLuong int, _DonGiaNhap int)
BEGIN
	SET SQL_SAFE_UPDATES = 0;
	update PHIEUNHAPCHITIET
	set SoLuong=_SoLuong, DonGiaNhap=_DonGiaNhap
	where MaPhieuNhapChiTiet=_MaPhieuNhapChiTiet and MaSanPham=_MaSanPham;
    SET SQL_SAFE_UPDATES = 1;
END $$
DELIMITER ;
-- CALL updatePhieuNhapChiTiet('PN123456789212235', 'SP1235468811523',20, 22000);

-- 12.3. Xoa
DELIMITER $$
CREATE PROCEDURE deletePhieuNhapChiTiet
(_MaPhieuNhapChiTiet varchar(20))
BEGIN
	delete from PHIEUNHAPCHITIET
	where MaPhieuNhapChiTiet=_MaPhieuNhapChiTiet;
END $$
DELIMITER ;
-- CALL deletePhieuNhapChiTiet('PN123456789212235');


-- 12.4. Xoa tung san pham trong PhieuNhap
DELIMITER $$
CREATE PROCEDURE deleteByOnePhieuNhapChiTiet
(_MaPhieuNhapChiTiet varchar(20), _MaSanPham varchar(20))
BEGIN
	delete from PHIEUNHAPCHITIET
	where MaPhieuNhapChiTiet=_MaPhieuNhapChiTiet and MaSanPham = _MaSanPham;
END $$
DELIMITER ;
-- CALL deleteByOnePhieuNhapChiTiet('MaPhieuNhapChiTiet', 'MaSanPham');

-- 12.5. Truy van
DELIMITER $$
CREATE PROCEDURE queryNhapHang()
BEGIN
	select * from View_NhapHang ;
END $$
DELIMITER ;

-- 12.6. Tim kiem phieu nhap hang mot tham so
DELIMITER $$
CREATE PROCEDURE searchPhieuNhap(_MaPhieuNhap varchar(20))
BEGIN
	select *
	from View_NhapHang where MaPhieuNhap LIKE concat('%',_MaPhieuNhap,'%'); 
END $$
DELIMITER ;

-- 12.7. Tim kiem phieu nhap hang nhieu tham so
DELIMITER $$
CREATE PROCEDURE searchPhieuNhapNhieuThamSo
(_MaPhieuNhap varchar(20), _MaNhanVien varchar(20), _MaNhaCungCap varchar(20))
BEGIN
	select *
	from View_NhapHang where MaPhieuNhap LIKE concat('%',_MaPhieuNhap,'%') or MaNhanVien LIKE concat('%',_MaNhanVien,'%') or MaNhaCungCap LIKE concat('%',_MaNhaCungCap,'%');
END $$
DELIMITER ;


-- 13. PHIEUXUAT
-- 13.1. Them
DELIMITER $$
CREATE PROCEDURE addPhieuXuat
(_MaPhieuXuat varchar(20), _MaNhanVien varchar(10), _MaKhachHang varchar(10), _NgayXuat datetime, _TrangThai nvarchar(30), _GhiChu nvarchar(30))
BEGIN
	insert into PHIEUXUAT (MaPhieuXuat, MaNhanVien, MaKhachHang, NgayXuat, TrangThai, GhiChu ) values (_MaPhieuXuat, _MaNhanVien, _MaKhachHang, _NgayXuat, _TrangThai, _GhiChu);
END $$
DELIMITER ; 
-- CALL addPhieuXuat('PX1234564789782', 'NV12322255', 'KH12563258', '2023-03-25 10:37:09', N'Chưa thanh toán', N'Chưa có sản phẩm mua');
-- CALL addPhieuXuat('PX1234564789714', 'NV12322255', 'KH00000000', '2023-03-25 10:37:09', N'Chưa thanh toán', N'Chưa có sản phẩm mua');
-- CALL addPhieuXuat('PX1234564789241', 'NV12322255', 'KH00000000', '2023-03-25 10:37:09', N'Chưa thanh toán', N'Chưa có sản phẩm mua');

-- 13.2. Sua
DELIMITER $$
CREATE PROCEDURE updatePhieuXuat
(_MaPhieuXuat varchar(20), _MaNhanVien varchar(10), _MaKhachHang varchar(10), _NgayXuat datetime, _GhiChu nvarchar(30))
BEGIN
	SET SQL_SAFE_UPDATES = 0;
	update PHIEUXUAT
	set MaNhanVien=_MaNhanVien, MaKhachHang=_MaKhachHang, NgayXuat=_NgayXuat,GhiChu = _GhiChu
	where MaPhieuXuat=_MaPhieuXuat; 
    SET SQL_SAFE_UPDATES = 1;
END $$
DELIMITER ; 
-- CALL updatePhieuXuat('PX1234564789241', 'NV12322255', 'KH00000000', '2023-03-25 11:37:09', N'update');

-- 13.2.2. Thanh toan PhieuXuat
DELIMITER $$
CREATE PROCEDURE updateThanhToanPhieuXuat
(_MaPhieuXuat varchar(20),  _TrangThai nvarchar(30))
BEGIN
	SET SQL_SAFE_UPDATES = 0;
	update PHIEUXUAT
	set TrangThai=_TrangThai
	where MaPhieuXuat=_MaPhieuXuat;
    SET SQL_SAFE_UPDATES = 1;
END $$
DELIMITER ; 
-- CALL updateThanhToanPhieuXuat('PX1234564789241', N'Đã thanh toán');

-- 13.3. Xoa
DELIMITER $$
CREATE PROCEDURE deletePhieuXuat
(_MaPhieuXuat varchar(20))
BEGIN
	delete from PHIEUXUAT
	where MaPhieuXuat=_MaPhieuXuat; 
END $$
DELIMITER ;
-- CALL deletePhieuXuat('PX1234564789241');

-- 14. PHIEUXUATCHITIET
-- 14.1. Them
DELIMITER $$
CREATE PROCEDURE addPhieuXuatChiTiet
(_MaPhieuXuatChiTiet varchar(20), _MaSanPham varchar(20), _SoLuong int)
BEGIN
	insert into PHIEUXUATCHITIET (MaPhieuXuatChiTiet, MaSanPham, SoLuong) values (_MaPhieuXuatChiTiet, _MaSanPham, _SoLuong);
END $$
DELIMITER ;
-- CALL addPhieuXuatChiTiet('PX1234564789241','SP1235468811522',2);

-- 14.2. Sua
DELIMITER $$
CREATE PROCEDURE updatePhieuXuatChiTiet
(_MaPhieuXuatChiTiet varchar(20), _MaSanPham varchar(20), _SoLuong int)
BEGIN
	SET SQL_SAFE_UPDATES = 0;
	update PHIEUXUATCHITIET
	set SoLuong=_SoLuong
	where MaPhieuXuatChiTiet=_MaPhieuXuatChiTiet and MaSanPham = _MaSanPham;
    SET SQL_SAFE_UPDATES = 1;
END $$
DELIMITER ;
CALL updatePhieuXuatChiTiet('PX1234564789241','SP1235468811522',3);

-- 14.3. Xoa tat ca san pham trong PhieuXuatChiTiet
DELIMITER $$
CREATE PROCEDURE deletePhieuXuatChiTiet
(_MaPhieuXuatChiTiet varchar(20))
BEGIN
	delete from PHIEUXUATCHITIET
	where MaPhieuXuatChiTiet=_MaPhieuXuatChiTiet;
END $$
DELIMITER ;
-- CALL deletePhieuXuatChiTiet('PX1234564789241');

-- 14.4. Xoa tung san pham trong PhieuXuatChiTiet
DELIMITER $$
CREATE PROCEDURE deleteSanPhamInPhieuXuat
(_MaPhieuXuatChiTiet varchar(20), _MaSanPham varchar(20))
BEGIN
	delete from PHIEUXUATCHITIET
	where MaPhieuXuatChiTiet=_MaPhieuXuatChiTiet and MaSanPham = _MaSanPham;
END $$
DELIMITER ;
-- CALL deleteSanPhamInPhieuXuat('PX1234564789241','SP1235468811522');

-- 14.5. Truy van
DELIMITER $$
CREATE PROCEDURE QueryBanHang()
BEGIN
	select * from View_BanHang;
END $$
DELIMITER ;

-- 14.5. Tim kiem hoa don Nhieu Tham so
DELIMITER $$
CREATE PROCEDURE searchHOADONBANHANG
(_MaPhieuXuat varchar(20), _MaNhanVien varchar(10), _MaKhachHang varchar(10))
BEGIN
	select *
	from View_BanHang where MaPhieuXuat LIKE concat('%',_MaPhieuXuat,'%') or MaNhanVien LIKE concat('%',_MaNhanVien,'%') or MaKhachHang LIKE concat('%',_MaKhachHang,'%');
END $$
DELIMITER ;
-- CALL searchHOADONBANHANG('PX1234564789782','0','');

-- 14.6. Tim kiem hoa don mot tham so
DELIMITER $$
CREATE PROCEDURE searchPHIEUXUAT(_MaPhieuXuat varchar(20))
BEGIN
	select *
	from View_BanHang where MaPhieuXuat LIKE concat('%',_MaPhieuXuat,'%'); 
END $$
DELIMITER ;
-- CALL searchPHIEUXUAT('');

-- 15. PHIEUHUY
-- 15.1. Them
DELIMITER $$
CREATE PROCEDURE addPhieuHuy
(_MaPhieuHuy varchar(20), _MaNhanVien varchar(10), _NgayHuy datetime, _TrangThai nvarchar(20), _Ghichu nvarchar(30))
BEGIN
	insert into PHIEUHUY (MaPhieuHuy, MaNhanVien, NgayHuy, TrangThai, GhiChu) values (_MaPhieuHuy, _MaNhanVien, _NgayHuy, _TrangThai, _Ghichu);
END $$
DELIMITER ;
-- CALL addPhieuHuy('PH1315161684181','NV12322255','2023-03-28 10:34:09.000',N'Chưa duyệt',N'Tạo mới');

-- 15.2. Sua
DELIMITER $$
CREATE PROCEDURE updatePhieuHuy
(_MaPhieuHuy varchar(20), _MaNhanVien varchar(10), _NgayHuy datetime, _GhiChu nvarchar(30))
BEGIN
	SET SQL_SAFE_UPDATES = 0;
	update PHIEUHUY
	set MaNhanVien=_MaNhanVien, NgayHuy=_NgayHuy,GhiChu=_GhiChu 
	where MaPhieuHuy=_MaPhieuHuy;
    SET SQL_SAFE_UPDATES = 1;
END $$
DELIMITER ;

-- 15.2.2. Sua --> Cap nhat trang thai PhieuHuy
DELIMITER $$
CREATE PROCEDURE updateTrangThaiPhieuHuy
(_MaPhieuHuy varchar(20), _TrangThai nvarchar(20))
BEGIN
	SET SQL_SAFE_UPDATES = 0;
	update PHIEUHUY
	set TrangThai=_TrangThai
	where MaPhieuHuy=_MaPhieuHuy;
    SET SQL_SAFE_UPDATES = 1;
END $$
DELIMITER ;

-- 15.3. Xoa
DELIMITER $$
CREATE PROCEDURE deletePhieuHuy
(_MaPhieuHuy varchar(20))
BEGIN
	delete from PHIEUHUY
	where MaPhieuHuy=_MaPhieuHuy;
END $$
DELIMITER ;

-- 16. PHIEUHUYCHITIET
-- 16.1. Them
DELIMITER $$
CREATE PROCEDURE addPhieuHuyChiTiet
(_MaPhieuHuyChiTiet varchar(20), _MaSanPham varchar(20), _SoLuong int)
BEGIN
	insert into PHIEUHUYCHITIET (MaPhieuHuyChiTiet, MaSanPham, SoLuong) values (_MaPhieuHuyChiTiet, _MaSanPham, _SoLuong);
END $$
DELIMITER ;

-- 16.2. Sua
DELIMITER $$
CREATE PROCEDURE updatePhieuHuyChiTiet
(_MaPhieuHuyChiTiet varchar(20), _MaSanPham varchar(20), _SoLuong int)
BEGIN
	SET SQL_SAFE_UPDATES = 0;
	update PHIEUHUYCHITIET
	set SoLuong=_SoLuong
	where MaPhieuHuyChiTiet=_MaPhieuHuyChiTiet and MaSanPham=_MaSanPham;
    SET SQL_SAFE_UPDATES = 0;
END $$
DELIMITER ;
 
-- 16.3. Xoa
DELIMITER $$
CREATE PROCEDURE deletePhieuHuyChiTiet
(_MaPhieuHuyChiTiet varchar(20))
BEGIN
	delete from PHIEUHUYCHITIET
	where MaPhieuHuyChiTiet=_MaPhieuHuyChiTiet;
END $$
DELIMITER ;

-- 16.4. Xoa tung PhieuHuychiTiet
DELIMITER $$
CREATE PROCEDURE deleteByOnePhieuHuyChiTiet
(_MaPhieuHuyChiTiet varchar(20), _MaSanPham varchar(20))
BEGIN
	delete from PHIEUHUYCHITIET
	where MaPhieuHuyChiTiet=_MaPhieuHuyChiTiet and MaSanPham = _MaSanPham;
END $$
DELIMITER ;

-- 16.4. Truy van HuyHang
DELIMITER $$
CREATE PROCEDURE QueryHuyHang()
BEGIN
	select * from View_HuyHang;
END $$
DELIMITER ;


-- 16.5. Tim kiem PhieuHuy mot tham so
DELIMITER $$
CREATE PROCEDURE searchPhieuHuy(_MaPhieuHuy varchar(20))
BEGIN
	select *
	from View_HuyHang where MaPhieuHuy LIKE concat('%',_MaPhieuHuy,'%'); 
END $$
DELIMITER ;

-- 16.6. Tim kiem PhieuHuy nhieu tham so
DELIMITER $$
CREATE PROCEDURE searchPhieuHuyNhieuThamSo
(_MaPhieuHuy varchar(20),_MaNhanVien varchar(20),_NgayHuy date)
BEGIN
	select *
	from View_HuyHang where MaPhieuHuy LIKE concat('%',_MaPhieuHuy,'%') or MaNhanVien LIKE concat('%',_MaNhanVien,'%') or DATE(NgayHuy) = _NgayHuy; 
END $$
DELIMITER ;
-- CALL searchPhieuHuyNhieuThamSo('ss','ss','2023-03-28');

-- 17. LOAITAIKHOAN
-- 17.1. Them
DELIMITER $$
CREATE PROCEDURE addLoaiTaiKhoan
(_MaQuyen int, _TenQuyen nvarchar(30))
BEGIN
	insert into LOAITAIKHOAN (MaQuyen, TenQuyen) values (_MaQuyen, _TenQuyen);
END $$
DELIMITER ;

-- 17.2. Sua
DELIMITER $$
CREATE PROCEDURE updateLoaiTaiKhoan
(_MaQuyen int, _TenQuyen nvarchar(30))
BEGIN
	SET SQL_SAFE_UPDATES = 0;
	update LOAITAIKHOAN
	set TenQuyen=_TenQuyen
	where MaQuyen= _MaQuyen;
    SET SQL_SAFE_UPDATES = 1;
END $$
DELIMITER ;

-- 17.3. Xoa
DELIMITER $$
CREATE PROCEDURE deleteLoaiTaiKhoan
(_MaQuyen int)
BEGIN
	delete from LOAITAIKHOAN
	where MaQuyen= _MaQuyen;
END $$
DELIMITER ;


-- Add Data----------------------------------------------------------------------------------------------------------
-- 1. LOAI TAI KHOAN
INSERT INTO LOAITAIKHOAN (MaQuyen,TenQuyen) VALUES (1,N'Quản Trị Viên');
INSERT INTO LOAITAIKHOAN (MaQuyen,TenQuyen) VALUES (2,N'Quản lý');
INSERT INTO LOAITAIKHOAN (MaQuyen,TenQuyen) VALUES (3,N'Nhân viên');
INSERT INTO LOAITAIKHOAN (MaQuyen,TenQuyen) VALUES (4,N'Khách hàng');
-- 2. TAI KHOAN
INSERT INTO TaiKhoan (TenTaiKhoan, MatKhau, MaNhanVien, MaQuyen) VALUES ('admin','123456','NV23705523',1);
INSERT INTO TaiKhoan (TenTaiKhoan, MatKhau, MaNhanVien, MaQuyen) VALUES ('hung','654321','NV23215684',2);

