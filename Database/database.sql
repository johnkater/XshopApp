-- TAO CO SO DU LIEU (DATABASE)---------------------------------------------------------------
CREATE DATABASE CuaHangTienLoi
GO
USE CuaHangTienLoi
GO

-- TAO BANG (TABLE) -------------------------------------------------------------------------------------------------------------------

-- 1. TAI KHOAN---------------------------------

CREATE TABLE TAIKHOAN (  
    Id int IDENTITY(1,1) PRIMARY KEY,
	TenTaiKhoan varchar(20) NOT NULL,  
    MatKhau varchar(20) NOT NULL,  
    MaNhanVien varchar(10) NOT NULL,
    MaQuyen int NOT NULL
); 
go
-- 2. THE KHACH HANG----------------------------
CREATE TABLE THEKHACHHANG (  
    MaTheKhachHang varchar(10) NOT NULL,  
    MaKhachhang varchar(10) NOT NULL,  
    NgayLap datetime NULL,
    TichDiem bigint NULL , 
    MaLoaiTheKhachHang int NOT NULL,
    PRIMARY KEY (MaTheKhachHang)  
);
go
-- 3. LOAI THE KHACH HANG----------------------------	
CREATE TABLE LOAITHEKHACHHANG (  
    MaLoaiTheKhachHang int NOT NULL,  
    TenLoaiTheKhachHang nvarchar(30) NULL,  
    PRIMARY KEY (MaLoaiTheKhachHang)  
);
go
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
go
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
go
-- 6. PHIEUXUAT ----------------------------
CREATE TABLE PHIEUXUAT (  
    MaPhieuXuat varchar(20) NOT NULL,  
    MaNhanVien varchar(10) NOT NULL, 
    MaKhachHang varchar(10) NOT NULL, 
    NgayXuat datetime NULL, 
    PRIMARY KEY (MaPhieuXuat)  
);
go  
-- 7. PHIEUXUATCHITIET ----------------------------
CREATE TABLE PHIEUXUATCHITIET (  
    MaPhieuXuatChiTiet varchar(20) NOT NULL,  
    MaPhieuXuat varchar(20) NOT NULL, 
    MaSanPham varchar(20) NOT NULL, 
    SoLuong int NULL, 
    PRIMARY KEY (MaPhieuXuatChiTiet,MaSanPham)  
); 
go 
-- 8. PHIEUHUY ----------------------------
CREATE TABLE PHIEUHUY (  
    MaPhieuHuy varchar(20) NOT NULL,  
    MaNhanVien varchar(10) NOT NULL, 
    NgayHuy datetime NULL, 
    PRIMARY KEY (MaPhieuHuy)  
); 
go
-- 9. PHIEUHUYCHITIET ----------------------------
CREATE TABLE PHIEUHUYCHITIET (  
    MaPhieuHuyChiTiet varchar(20) NOT NULL,  
    MaPhieuHuy varchar(20) NOT NULL, 
    MaSanPham varchar(20) NOT NULL,
    SoLuong int NULL, 
    PRIMARY KEY (MaPhieuHuyChiTiet,MaSanPham)  
);
go
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
go
-- 11. LOAISANPHAM ----------------------------
CREATE TABLE LOAISANPHAM (  
    MaLoaiSanPham int NOT NULL,  
    TenLoaiSanPham nvarchar(30) NOT NULL, 
    PRIMARY KEY (MaLoaiSanPham)  
);
go
-- 12. PHIEUNHAP ----------------------------
CREATE TABLE PHIEUNHAP (  
    MaPhieuNhap varchar(20) NOT NULL,  
    MaNhanVien varchar(10) NOT NULL, 
    MaNhaCungCap varchar(10) NOT NULL,  
    NgayNhap datetime NULL,
    PRIMARY KEY (MaPhieuNhap)  
);
go
-- 13. PHIEUNHAPCHITIET ----------------------------
CREATE TABLE PHIEUNHAPCHITIET (  
    MaPhieuNhapChiTiet varchar(20) NOT NULL,  
    MaPhieuNhap varchar(20) NOT NULL, 
    MaSanPham varchar(20) NOT NULL,  
    SoLuong int NULL,
    DonGiaNhap int NULL,
    PRIMARY KEY (MaPhieuNhapChiTiet,MaSanPham)  
);
go
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
go
-- 15. KHUYENMAI ----------------------------
CREATE TABLE KHUYENMAI (  
    MaKhuyenMai varchar(20) NOT NULL,  
    MaLoaiKhuyenMai int NOT NULL, 
    GiaGiam int NULL,  
    NgayBatDau datetime NULL,
    NgayKetThuc datetime NULL,
    PRIMARY KEY (MaKhuyenMai)  
);
go
-- 16. LOAIKHUYENMAI ----------------------------
CREATE TABLE LOAIKHUYENMAI (  
    MaLoaiKhuyenMai int NOT NULL,  
    TenLoaiKhuyenMai nvarchar(30) NOT NULL, 
    PRIMARY KEY (MaLoaiKhuyenMai )  
);
go
-- 17. LOAITAIKHOAN ----------------------------
CREATE TABLE LOAITAIKHOAN (  
    MaQuyen int NOT NULL,  
    TenQuyen nvarchar(30) NOT NULL, 
    PRIMARY KEY (MaQuyen)  
);
go

-- TAO KHOA NGOAI (FOREIGN KEY)---------------------------------------------------------------------------------------------------
-- 1. THEKHACHHANG (MaKhachhang) --> KHACHHANG (MaKhachhang)
alter table THEKHACHHANG
add constraint FK_THEKHACHHANG_KHACHHANG
foreign key (MaKhachhang)
references KHACHHANG(MaKhachhang);
go
-- 2. THEKHACHHANG --> LOAITHEKHACHHANG (MaLoaiTheKhachHang)
alter table THEKHACHHANG
add constraint FK_THEKHACHHANG_LOAITHEKHACHHANG
foreign key (MaLoaiTheKhachHang)
references LOAITHEKHACHHANG(MaLoaiTheKhachHang);
go
-- 3. PHIEUXUAT --> NHANVIEN (MaNhanVien)
alter table PHIEUXUAT
add constraint FK_PHIEUXUAT_NHANVIEN
foreign key (MaNhanVien)
references NHANVIEN(MaNhanVien);
go
-- 4. PHIEUXUAT --> KHACHHANG (MaKhachhang)
alter table PHIEUXUAT
add constraint FK_PHIEUXUAT_KHACHHANG
foreign key (MaKhachhang)
references KHACHHANG(MaKhachhang);
go
-- 5. PHIEUXUATCHITIET --> PHIEUXUAT (MaPhieuXuat)
alter table PHIEUXUATCHITIET
add constraint FK_PHIEUXUATCHITIET_PHIEUXUAT
foreign key (MaPhieuXuat)
references PHIEUXUAT(MaPhieuXuat);
go
-- 6. PHIEUXUATCHITIET --> SANPHAM (MaSanPham)
alter table PHIEUXUATCHITIET
add constraint FK_PHIEUXUATCHITIET_SANPHAM
foreign key (MaSanPham)
references SANPHAM(MaSanPham);
go
-- 7. PHIEUHUY --> NHANVIEN (MaNhanVien)
alter table PHIEUHUY
add constraint FK_PHIEUHUY_NHANVIEN
foreign key (MaNhanVien)
references NHANVIEN(MaNhanVien);
go
-- 8. PHIEUHUYCHITIET --> PHIEUHUY (MaPhieuHuy)
alter table PHIEUHUYCHITIET
add constraint FK_PHIEUHUYCHITIET_PHIEUHUY
foreign key (MaPhieuHuy)
references PHIEUHUY(MaPhieuHuy);
go
-- 9. PHIEUHUYCHITIET --> SANPHAM (MaSanPham)
alter table PHIEUHUYCHITIET
add constraint FK_PHIEUHUYCHITIET_SANPHAM
foreign key (MaSanPham)
references SANPHAM(MaSanPham);
go
-- 10. SANPHAM --> LOAISANPHAM (MaLoaiSanPham)
alter table SANPHAM
add constraint FK_SANPHAM_LOAISANPHAM
foreign key (MaLoaiSanPham)
references LOAISANPHAM(MaLoaiSanPham);
go
-- 11. SANPHAM --> KHUYENMAI (MaKhuyenMai)
alter table SANPHAM
add constraint FK_SANPHAM_KHUYENMAI
foreign key (MaKhuyenMai)
references KHUYENMAI(MaKhuyenMai);
go
-- 12. PHIEUNHAP --> NHANVIEN (MaNhanVien)
alter table PHIEUNHAP
add constraint FK_PHIEUNHAP_NHANVIEN
foreign key (MaNhanVien)
references NHANVIEN(MaNhanVien);
go
-- 13. PHIEUNHAP --> NHACUNGCAP (MaNhaCungCap)
alter table PHIEUNHAP
add constraint FK_PHIEUNHAP_NHACUNGCAP
foreign key (MaNhaCungCap)
references NHACUNGCAP(MaNhaCungCap);
go
-- 14. PHIEUNHAPCHITIET --> PHIEUNHAP (MaPhieuNhap)
alter table PHIEUNHAPCHITIET
add constraint FK_PHIEUNHAPCHITIET_PHIEUNHAP
foreign key (MaPhieuNhap)
references PHIEUNHAP(MaPhieuNhap);
go
-- 15. PHIEUNHAPCHITIET --> SANPHAM (MaSanPham)
alter table PHIEUNHAPCHITIET
add constraint FK_PHIEUNHAPCHITIET_SANPHAM
foreign key (MaSanPham)
references SANPHAM(MaSanPham);
go
-- 16. KHUYENMAI --> LOAIKHUYENMAI	(MaLoaiKhuyenMai)
alter table KHUYENMAI
add constraint FK_KHUYENMAI_LOAIKHUYENMAI
foreign key (MaLoaiKhuyenMai)
references LOAIKHUYENMAI(MaLoaiKhuyenMai);
go
-- 17. TAIKHOAN --> LOAITAIKHOAN	(MaQuyen)
alter table TAIKHOAN
add constraint FK_TAIKHOAN_LOAITAIKHOAN
foreign key (MaQuyen)
references LOAITAIKHOAN(MaQuyen);
go


-- TAO PROCEDURE
-- 1. TAI KHOAN  

-- Proc dang nhap
CREATE PROC proc_login
(@user varchar(20), @pass varchar(20))
AS
BEGIN
	select * from TAIKHOAN where TenTaiKhoan=@user AND MatKhau=@pass
END
go
-- 1.1. Them
create proc addTAIKHOAN 
(@TenTaiKhoan varchar(20), @MatKhau varchar(20), @MaNhanVien varchar(10), @MaQuyen int)
as
begin
	insert into TAIKHOAN(TenTaiKhoan, MatKhau, MaNhanVien, MaQuyen) values (@TenTaiKhoan, @MatKhau, @MaNhanVien, @MaQuyen)
end
--exec addTAIKHOAN 'nhat' , '123', 'NV12322154', 2
--exec addTAIKHOAN 'nhung' , '123', 'NV12322255', 2
go
-- 1.2. Sua
CREATE proc updateTAIKHOAN
(@Id int, @TenTaiKhoan varchar(20), @MatKhau varchar(20), @MaNhanVien varchar(10), @MaQuyen int)
as
begin
	update TAIKHOAN 
	set TenTaiKhoan=@TenTaiKhoan, MatKhau=@MatKhau, MaNhanVien=@MaNhanVien, MaQuyen=@MaQuyen
	where Id=@Id
end
--exec updateTAIKHOAN 1003,'hung','456','NV12322254',2

-- 1.3. Xoa
CREATE proc deleteTAIKHOAN(@Id int)
as
begin
	delete TAIKHOAN
	
	where Id=@Id
end
--exec deleteTAIKHOAN 1003
--select * from TAIKHOAN
go

-- 2. NHA CUNG CAP
-- 2.1. Them
CREATE proc addNhaCungCap
(@MaNhaCungCap varchar(10), @TenNhaCungCap nvarchar(30), @DiaChi nvarchar(100), @SoDienThoai varchar(13), @Email varchar(30), @HinhAnh text )
as
begin
	insert into NHACUNGCAP (MaNhaCungCap, TenNhaCungCap, DiaChi, SoDienThoai, Email, HinhAnh) values (@MaNhaCungCap, @TenNhaCungCap, @DiaChi, @SoDienThoai, @Email, @HinhAnh)
end
--exec addNhaCungCap 'NCC0215235', N'Vinamilk', N'Hồ chí Minh', '02854161226', 'vinamilk@vinamilk.com.vn', 'https://www.vinamilk.com.vn/static/tpl/dist/assets/images/pages/contact/headquarter.jpg'
go
-- 2.2. Sua
CREATE proc updateNhaCungCap
(@MaNhaCungCap varchar(10), @TenNhaCungCap nvarchar(30), @DiaChi nvarchar(100), @SoDienThoai varchar(13), @Email varchar(30), @HinhAnh text )
as
begin
	update NHACUNGCAP 
	set TenNhaCungCap=@TenNhaCungCap, DiaChi=@DiaChi, SoDienThoai=@SoDienThoai, Email=@Email, HinhAnh=@HinhAnh
	where MaNhaCungCap=@MaNhaCungCap
end
--exec updateNhaCungCap 'NCC0215235', N'Vinamilk', N'10 Tân Trào, Tân Phú, Quận 7, Thành phố Hồ Chí Minh, Vietnam', '02854161226', 'vinamilk@vinamilk.com.vn', 'https://www.vinamilk.com.vn/static/tpl/dist/assets/images/pages/contact/headquarter.jpg'
go
-- 2.3. Xoa
CREATE proc deleteNHACUNGCAP(@MaNhaCungCap varchar(10))
as
begin
	delete NHACUNGCAP
	
	where MaNhaCungCap=@MaNhaCungCap
end
--exec deleteNHACUNGCAP 'NCC0215235'
--select * from NHACUNGCAP
go
-- 2.4. Truy van
CREATE proc queryNHACUNGCAP
as
begin
	select * from View_NhaCungCap
end
--exec queryNHACUNGCAP
go
--2.5. Tim kiem
CREATE proc searchNHACUNGCAP(@TenNhaCungCap nvarchar(30))
as
begin
	select * from View_NhaCungCap where TenNhaCungCap LIKE '%' + @TenNhaCungCap + '%'
end
go
--exec searchNHACUNGCAP 'Vi'

-- 3. NHANVIEN
-- 3.1. Them
CREATE proc addNhanVien
(@MaNhanVien varchar(10), @HoTen nvarchar(30), @GioiTinh nvarchar(6), @NgaySinh date, @DiaChi nvarchar(100), @QueQuan nvarchar(100), @SoDienThoai varchar(13), @Email varchar(30), @HinhAnh text )
as
begin
	insert into NHANVIEN(MaNhanVien, HoTen, GioiTinh, NgaySinh, DiaChi, QueQuan, SoDienThoai, Email, HinhAnh) values (@MaNhanVien, @HoTen, @GioiTinh, @NgaySinh, @DiaChi, @QueQuan, @SoDienThoai, @Email, @HinhAnh)
end
--exec addNhanVien 'NV23215684', N'Nguyễn Văn Hùng ', N'Nam', '1995-05-06', N'Quận 2, TPHCM', N'Thanh Hóa', '0344646445', 'hungnguyen@gmail.com', 'https://toigingiuvedep.vn/wp-content/uploads/2021/07/mau-anh-the-dep-nam-450x600.jpeg'
--exec addNhanVien 'NV12322255', N'Bùi Thị Ngọc Nhung', N'Nữ', '1993-08-05', N'Quận 3, TPHCM', N'Hải Phòng', '0344546446', 'nhungbui@gmail.com', 'https://toigingiuvedep.vn/wp-content/uploads/2021/07/mau-anh-the-dep-nu-400x600.jpg'
go
-- 3.2. Sua
CREATE proc updateNhanVien
(@MaNhanVien varchar(10), @HoTen nvarchar(30), @GioiTinh nvarchar(6), @NgaySinh date, @DiaChi nvarchar(100), @QueQuan nvarchar(100), @SoDienThoai varchar(13), @Email varchar(30), @HinhAnh text )
as
begin
	update NHANVIEN
	set HoTen=@HoTen, GioiTinh=@GioiTinh, NgaySinh=@NgaySinh, DiaChi=@DiaChi, QueQuan=@QueQuan, SoDienThoai=@SoDienThoai, Email=@Email, HinhAnh=@HinhAnh
	where MaNhanVien=@MaNhanVien
end
--exec updateNhanVien 'NV12322255', N'Bùi Thị Ngọc Nhung', N'Nữ', '1993-06-05', N'Quận 3, TPHCM', N'Hải Phòng', '0344546446', 'nhungbui@gmail.com', 'https://toigingiuvedep.vn/wp-content/uploads/2021/07/mau-anh-the-dep-nu-400x600.jpg'
go
-- 3.3. Xoa
CREATE proc deleteNhanVien (@MaNhanVien varchar(10))
as
begin
	delete NHANVIEN
	where MaNhanVien=@MaNhanVien
end
--exec deleteNhanVien 'NV23215684'
--select * from NHANVIEN
go
-- 3.4. Truy van
CREATE proc showNhanVien
as
begin
	select * from View_NhanVien
end
--exec showNhanVien
go 
--3.5. Tim kiem

CREATE proc searchNHANVIEN(@HoTen nvarchar(30))
as
begin
	select * from View_NhanVien where HoTen LIKE '%' + @HoTen + '%'
end
go
--exec searchNHANVIEN N'i'

-- 4. KHACHHANG
-- 4.1. Them
CREATE proc addKhachHang
(@MaKhachHang varchar(10), @HoTen nvarchar(30), @GioiTinh nvarchar(6), @NgaySinh date, @DiaChi nvarchar(100), @SoDienThoai varchar(13), @Email varchar(30), @HinhAnh text )
as
begin
	insert into KHACHHANG (MaKhachHang, HoTen, GioiTinh, NgaySinh, DiaChi, SoDienThoai, Email, HinhAnh) values (@MaKhachHang, @HoTen, @GioiTinh, @NgaySinh, @DiaChi, @SoDienThoai, @Email, @HinhAnh)
end
--exec addKhachHang 'KH00000000', N'Khách Hàng Mặc Định','','','','','',''
--exec addKhachHang 'KH12563258', N'Nguyễn Văn An', N'Nam', '1995-02-03', N'Quận 5, TPHCM', '0325648987', 'annguyenvan@gmail.com', 'https://toigingiuvedep.vn/wp-content/uploads/2021/07/mau-anh-the-nam-sinh.jpeg'
go
-- 4.2. Sua
CREATE proc updateKhachHang
(@MaKhachHang varchar(10), @HoTen nvarchar(30), @GioiTinh nvarchar(6), @NgaySinh date, @DiaChi nvarchar(100), @SoDienThoai varchar(13), @Email varchar(30), @HinhAnh text )
as
begin
	update KHACHHANG
	set HoTen=@HoTen, GioiTinh=@GioiTinh, NgaySinh=@NgaySinh, DiaChi=@DiaChi, SoDienThoai=@SoDienThoai, Email=@Email, HinhAnh=@HinhAnh 
	where MaKhachHang = @MaKhachHang
end
--exec updateKhachHang 'KH12563258', N'Nguyễn Văn An', N'Nam', '1995-02-03', N'Quận 4, TPHCM', '0325648987', 'annguyenvan@gmail.com', 'https://toigingiuvedep.vn/wp-content/uploads/2021/07/mau-anh-the-nam-sinh.jpeg'
go
-- 4.3. Xoa
CREATE proc deleteKhachHang (@MaKhachHang varchar(10))
as
begin
	delete KHACHHANG
	where MaKhachHang = @MaKhachHang
end
--exec deleteKhachHang 'KH00000000'
--select * from KHACHHANG
go
-- 4.4. Truy van
CREATE proc showKhachHang
as
begin
	select * from View_KhachHang
end
--exec showKhachHang
go
--4.5. Tim kiem

CREATE proc searchKHACHHANG(@HoTen nvarchar(30))
as
begin
	select * from View_KhachHang where HoTen LIKE '%' + @HoTen + '%'
end
--exec searchKHACHHANG N'a'
go

-- 5. LOAITHEKHACHHANG
-- 5.1. Them
CREATE proc addLoaiTheKhachHang
(@MaLoaiTheKhachHang int, @TenLoaiTheKhachHang nvarchar(30))
as
begin
	insert into LOAITHEKHACHHANG (MaLoaiTheKhachHang,TenLoaiTheKhachHang) values (@MaLoaiTheKhachHang, @TenLoaiTheKhachHang)
end
--exec addLoaiTheKhachHang 1, N'Đồng'
--exec addLoaiTheKhachHang 2, N'Bạc'
--exec addLoaiTheKhachHang 3, N'Vàng'
--exec addLoaiTheKhachHang 4, N'Bạch Kim'
go
-- 5.2. sua
CREATE proc updateLoaiTheKhachHang
(@MaLoaiTheKhachHang int, @TenLoaiTheKhachHang nvarchar(30))
as
begin
	update LOAITHEKHACHHANG
	set TenLoaiTheKhachHang=@TenLoaiTheKhachHang
	where MaLoaiTheKhachHang=@MaLoaiTheKhachHang
end
--exec updateLoaiTheKhachHang 4, N'Kim Cương'
go
-- 5.3. Xoa
CREATE proc deleteLoaiTheKhachHang
(@MaLoaiTheKhachHang int)
as
begin
	delete LOAITHEKHACHHANG
	where MaLoaiTheKhachHang=@MaLoaiTheKhachHang
end
--exec deleteLoaiTheKhachHang 4
--select * from LOAITHEKHACHHANG
go
-- 5.4. Truy van
CREATE proc showLoaiTheKhachHang
as
begin
	select MaLoaiTheKhachHang, TenLoaiTheKhachHAng from View_LoaiTheKhachHang
	
end
--exec showLoaiTheKhachHang
go

-- 5.5. Tim kiem
CREATE proc searchTHEKHACHHANG(@HoTen nvarchar(30))
as
begin
	select * from View_TheKhachHang where HoTen LIKE '%' + @HoTen + '%'
end
--exec searchTHEKHACHHANG N'a'
go


-- 6. THEKHACHHANG
-- 6.1. Them
CREATE proc addTheKhachHang
(@MaTheKhachHang varchar(10), @MaKhachHang varchar(10), @NgayLap datetime, @TichDiem bigint, @MaLoaiTheKhachHang int)
as
begin
	insert into THEKHACHHANG (MaTheKhachHang,MaKhachhang,NgayLap,TichDiem,MaLoaiTheKhachHang) values (@MaTheKhachHang, @MaKhachhang, @NgayLap, @TichDiem, @MaLoaiTheKhachHang)
end
--exec addTheKhachHang 'TKH2365897', 'KH12563258', '', 0, 1
go
-- 6.2. Sua
CREATE proc updateTheKhachHang
(@MaTheKhachHang varchar(10), @MaKhachHang varchar(10), @NgayLap datetime, @TichDiem bigint, @MaLoaiTheKhachHang int)
as
begin
	update THEKHACHHANG
	set MaKhachhang=@MaKhachHang, NgayLap=@NgayLap, TichDiem=@TichDiem, MaLoaiTheKhachHang=@MaLoaiTheKhachHang
	where MaTheKhachHang=@MaTheKhachHang
end
--exec updateTheKhachHang 'TKH2365897', 'KH12563258', '', 100, 1
go
-- 6.3. Xoa
CREATE proc deleteTheKhachHang
(@MaTheKhachHang varchar(10))
as
begin
	delete THEKHACHHANG
	where MaTheKhachHang=@MaTheKhachHang
end
--exec deleteTheKhachHang 'TKH2365898'
--select * from THEKHACHHANG
go
-- 6.4. Truy van
CREATE proc showTheKhachHang
as
begin
	select * from View_TheKhachHang
	
end
--exec showTheKhachHang
go

-- 7. LOAIKHUYENMAI
-- 7.1. Them
CREATE proc addLoaiKhuyenMai
(@MaLoaiKhuyenMai int, @TenLoaiKhuyenMai nvarchar(30))
as
begin
	insert into LOAIKHUYENMAI (MaLoaiKhuyenMai, TenLoaiKhuyenMai) values (@MaLoaiKhuyenMai, @TenLoaiKhuyenMai)
end
--exec addLoaiKhuyenMai 1, N'Mặc định'
--exec addLoaiKhuyenMai 2, N'Giảm giá'
--exec addLoaiKhuyenMai 3, N'Quà tặng'
go
-- 7.2. Sua
CREATE proc updateLoaiKhuyenMai
(@MaLoaiKhuyenMai int, @TenLoaiKhuyenMai nvarchar(30))
as
begin
	update LOAIKHUYENMAI
	set TenLoaiKhuyenMai=@TenLoaiKhuyenMai
	where MaLoaiKhuyenMai=@MaLoaiKhuyenMai
end
--exec updateLoaiKhuyenMai 1, N'Mặc định không giảm giá'
--exec updateLoaiKhuyenMai 2, N'Giảm giá'
--exec updateLoaiKhuyenMai 3, N'Quà tặng'
go
-- 7.3. Xoa
CREATE proc deleteLoaiKhuyenMai
(@MaLoaiKhuyenMai int)
as
begin
	delete LOAIKHUYENMAI
	where MaLoaiKhuyenMai=@MaLoaiKhuyenMai
end
--exec deleteLoaiKhuyenMai 3
--select * from LOAIKHUYENMAI
go
-- 7.4. Truy van
CREATE proc showLoaiKhuyenMai
as
begin
	select * from View_LoaiKhuyenMai
end
go

-- 8. KHUYENMAI
-- 8.1. Them
CREATE proc addKhuyenMai
(@MaKhuyenMai varchar(20), @MaLoaiKhuyenMai int, @GiaGiam int, @NgayBatDau datetime, @NgayKetThuc datetime)
as
begin
	insert into KHUYENMAI (MaKhuyenMai,MaLoaiKhuyenMai,GiaGiam, NgayBatDau, NgayKetThuc) values (@MaKhuyenMai, @MaLoaiKhuyenMai, @GiaGiam, @NgayBatDau, @NgayKetThuc)
end
--exec addKhuyenMai 'KM000000', 1, 0, '','' 
--exec addKhuyenMai 'KM202303123458', 2, 20,'2023-03-24 10:34:09','2023-03-28 10:34:09'
go
-- 8.2. Sua
CREATE proc updateKhuyenMai
(@MaKhuyenMai varchar(20), @MaLoaiKhuyenMai int, @GiaGiam int, @NgayBatDau datetime, @NgayKetThuc datetime)
as
begin
	update KHUYENMAI
	set MaLoaiKhuyenMai=@MaLoaiKhuyenMai, GiaGiam=@GiaGiam, NgayBatDau=@NgayBatDau, NgayKetThuc=@NgayKetThuc
	where MaKhuyenMai=@MaKhuyenMai
end
--exec updateKhuyenMai 'KM202303123458',2,15,'2023-03-24 10:34:09','2023-03-28 10:34:09' 
go
-- 8.3. Xoa
CREATE proc deleteKhuyenMai
(@MaKhuyenMai varchar(20))
as
begin
	delete KHUYENMAI
	where MaKhuyenMai=@MaKhuyenMai
end
--exec deleteKhuyenMai 'KM000000'
--select * from KHUYENMAI
go

-- 8.4. Truy van
CREATE proc showKhuyenMai
as
begin
	select * from View_KhuyenMai
end
go

-- 8.5. Tim kiem
CREATE proc searchKHUYENMAI(@MaKhuyenMai varchar(20))
as
begin
	select * from View_KhuyenMai where MaKhuyenMai LIKE '%' + @MaKhuyenMai + '%'
end
--exec searchKHUYENMAI N'20230312'
go


-- 9. LOAISANPHAM
-- 9.1. Them
CREATE proc addLoaiSanPham
(@MaLoaiSanPham int, @TenLoaiSanPham nvarchar(30))
as
begin
	insert into LOAISANPHAM (MaLoaiSanPham, TenLoaiSanPham) values (@MaLoaiSanPham, @TenLoaiSanPham)
end
--exec addLoaiSanPham 1, N'Mì,miến,phở,cháo'
--exec addLoaiSanPham 2, N'Sữa các loại'
--exec addLoaiSanPham 3, N'Thịt,cá,trứng'
--exec addLoaiSanPham 4, N'Hải sản'
--exec addLoaiSanPham 5, N'Rau,củ,nấm,trái cây'
--exec addLoaiSanPham 6, N'Gạo,bột,đồ khô'
--exec addLoaiSanPham 7, N'Bánh kẹo các loại'
--exec addLoaiSanPham 8, N'Bia,nước ngọt'
--exec addLoaiSanPham 9, N'Thực phẩm đông lạnh'
--exec addLoaiSanPham 10, N'Đồ dùng gia đình'
go
-- 9.2. Sua
CREATE proc updateLoaiSanPham
(@MaLoaiSanPham int, @TenLoaiSanPham nvarchar(30))
as
begin
	update LOAISANPHAM
	set TenLoaiSanPham=@TenLoaiSanPham
	where MaLoaiSanPham=@MaLoaiSanPham
end
--exec updateLoaiSanPham 3, N'Thịt,trứng,cá'
go
-- 9.3. Xoa
CREATE proc deleteLoaiSanPham
(@MaLoaiSanPham int)
as
begin
	delete LOAISANPHAM
	where MaLoaiSanPham=@MaLoaiSanPham
end 
--exec deleteLoaiSanPham 10
--select * from LOAISANPHAM
go
-- 9.4. Truy van
CREATE proc showLoaiSanPham
as
begin
	select * from View_LoaiSanPham
end
go


-- 10. SANPHAM
-- 10.1. Them
CREATE proc addSanPham
(@MaSanPham varchar(20), @MaVach varchar(13), @TenSanPham nvarchar(30), @DonGiaBan int, @DonViTinh nvarchar(30), @NgaySanXuat date, @HanSuDung date, @MaLoaiSanPham int, @MaKhuyenMai varchar(20), @HinhAnh text)
as
begin
	insert into SANPHAM (MaSanPham, MaVach, TenSanPham, DonGiaBan, DonViTinh , NgaySanXuat, HanSuDung , MaLoaiSanPham, MaKhuyenMai, HinhAnh) values (@MaSanPham, @MaVach, @TenSanPham, @DonGiaBan, @DonViTinh , @NgaySanXuat, @HanSuDung , @MaLoaiSanPham, @MaKhuyenMai, @HinhAnh)
end
--exec addSanPham 'SP1235468811521','1235485698547',N'Mì tôm 3 miền',93000,N'Thùng','2023-03-20','2023-09-20',1,'KM000000','https://cdn.tgdd.vn/Products/Images/2565/80211/bhx/thung-30-goi-mi-3-mien-tom-chua-cay-65g-202205171132088241_300x300.jpg'
--exec addSanPham 'SP1235468811522','1235485698548',N'Sữa tươi Harvey Fresh hộp 1 lít từ Úc',39000,N'Hộp','2023-03-20','2023-06-20',2,'KM000000','https://cdn.tgdd.vn/Products/Images/2386/164547/bhx/sua-tuoi-tiet-trung-it-beo-harvey-fresh-hop-1-lit-202301071053049374.jpg'
--exec addSanPham 'SP1235468811523','1235485698549',N'Cam sành 1kg',29000,N'Kg','2023-03-20','2023-04-20',3,'KM000000','https://cdn.tgdd.vn/Products/Images/8788/235006/bhx/cam-sanh-tui-1kg-3-4-trai-202211011331467096_300x300.jpg'
--exec addSanPham 'SP1235468811524','1235485698550',N'Thùng 48 bịch sữa vinamilk 220ml',325000,N'Thùng','2023-03-20','2023-09-20',2,'KM000000','https://cdn.tgdd.vn/Products/Images/2386/85837/bhx/thung-48-bich-sua-dinh-duong-co-duong-vinamilk-a-d3-220ml-202302270845500732_300x300.jpg'
go
-- 10.2. Sua
CREATE proc updateSanPham
(@MaSanPham varchar(20), @MaVach varchar(13), @TenSanPham nvarchar(30), @DonGiaBan int, @DonViTinh nvarchar(30), @NgaySanXuat date, @HanSuDung date, @MaLoaiSanPham int, @MaKhuyenMai varchar(20), @HinhAnh text)
as
begin
	update SANPHAM
	set MaVach=@MaVach, TenSanPham=@TenSanPham, DonGiaBan=@DonGiaBan, DonViTinh=@DonViTinh , NgaySanXuat=@NgaySanXuat, HanSuDung=@HanSuDung , MaLoaiSanPham=@MaLoaiSanPham, MaKhuyenMai=@MaKhuyenMai, HinhAnh=@HinhAnh
	where MaSanPham=@MaSanPham
end
--exec updateSanPham 'SP1235468811523','1235485698549',N'Cam sành 1kg',30000,N'Kg','2023-03-20','2023-04-20',3,'KM000000','https://cdn.tgdd.vn/Products/Images/8788/235006/bhx/cam-sanh-tui-1kg-3-4-trai-202211011331467096_300x300.jpg'
go
-- 10.3. Xoa
CREATE proc deleteSanPham
(@MaSanPham varchar(20))
as
begin
	delete SANPHAM
	where MaSanPham=@MaSanPham
end
--exec deleteSanPham 'SP1235468811523'
--select * from SANPHAM
go
-- 10.4. Truy van
CREATE proc showSanPham
as
begin
	select MaSanPham, MaVach, MaLoaiSanPham, TenLoaiSanPham, TenSanPham, DonGiaBan, DonViTinh, NgaySanXuat, HanSuDung, HinhAnh, MaKhuyenMai, TenLoaiKhuyenMai, GiaGiam, NgayBatDau, NgayKetThuc  
	from View_SanPham
end
go
-- 10.5. Tim kiem
CREATE proc searchSANPHAM(@TenSanPham nvarchar(30))
as
begin
	
	select MaSanPham, MaVach, MaLoaiSanPham, TenLoaiSanPham, TenSanPham, DonGiaBan, DonViTinh, NgaySanXuat, HanSuDung, HinhAnh, MaKhuyenMai, TenLoaiKhuyenMai, GiaGiam, NgayBatDau, NgayKetThuc  
	from View_SanPham where TenSanPham LIKE '%' + @TenSanPham + '%'

end
--exec searchSANPHAM N'mì'
go

-- 11. PHIEUNHAP
-- 11.1. Them
CREATE proc addPhieuNhap
(@MaPhieuNhap varchar(20), @MaNhanVien varchar(10), @MaNhaCungCap varchar(10), @NgayNhap datetime)
as
begin
	insert into PHIEUNHAP (MaPhieuNhap,MaNhanVien,MaNhaCungCap,NgayNhap) values (@MaPhieuNhap, @MaNhanVien, @MaNhaCungCap, @NgayNhap)
end
--exec addPhieuNhap 'PN123456789212235', 'NV23215684', 'NCC0215235', '2023-03-20 10:34:09'
go
-- 11.2. Sua
CREATE proc updatePhieuNhap
(@MaPhieuNhap varchar(20), @MaNhanVien varchar(10), @MaNhaCungCap varchar(10), @NgayNhap datetime)
as
begin
	update PHIEUNHAP
	set MaNhanVien=@MaNhanVien, MaNhaCungCap=@MaNhaCungCap, NgayNhap=@NgayNhap
	where MaPhieuNhap=@MaPhieuNhap
	
end
--exec updatePhieuNhap 'PN123456789212235', 'NV23215684', 'NCC0215235', '2023-03-21 10:34:09'
go
-- 11.3. Xoa
CREATE proc deletePhieuNhap
(@MaPhieuNhap varchar(20))
as
begin
	delete PHIEUNHAP
	where MaPhieuNhap=@MaPhieuNhap	
end
--exec deletePhieuNhap 'PN123456789212235'
--select * from PHIEUNHAP
go




-- 12. PHIEUNHAPCHITIET
-- 12.1. Them
CREATE proc addPhieuNhapChiTiet
(@MaPhieuNhapChiTiet varchar(20), @MaPhieuNhap varchar(20), @MaSanPham varchar(20), @SoLuong int, @DonGiaNhap int)
as
begin
	insert into PHIEUNHAPCHITIET(MaPhieuNhapChiTiet, MaPhieuNhap, MaSanPham, SoLuong, DonGiaNhap) values (@MaPhieuNhapChiTiet, @MaPhieuNhap, @MaSanPham, @SoLuong, @DonGiaNhap)
end
--exec addPhieuNhapChiTiet 'PNCT12312354545', 'PN123456789212235', 'SP1235468811524', 10, 280000 
go
-- 12.2. Sua
CREATE proc updatePhieuNhapChiTiet
(@MaPhieuNhapChiTiet varchar(20), @MaPhieuNhap varchar(20), @MaSanPham varchar(20), @SoLuong int, @DonGiaNhap int)
as
begin
	update PHIEUNHAPCHITIET
	set MaPhieuNhap=@MaPhieuNhap, MaSanPham=@MaSanPham, SoLuong=@SoLuong, DonGiaNhap=@DonGiaNhap
	where MaPhieuNhapChiTiet=@MaPhieuNhapChiTiet
end
--exec updatePhieuNhapChiTiet 'PNCT12312354545', 'PN123456789212235', 'SP1235468811524', 20, 280000
go
-- 12.3. Xoa
CREATE proc deletePhieuNhapChiTiet
(@MaPhieuNhapChiTiet varchar(20))
as
begin
	delete PHIEUNHAPCHITIET
	where MaPhieuNhapChiTiet=@MaPhieuNhapChiTiet
end
--exec deletePhieuNhapChiTiet 'PNCT12312354545'
--select * from PHIEUNHAPCHITIET
go
-- 13. PHIEUXUAT
-- 13.1. Them
CREATE proc addPhieuXuat
(@MaPhieuXuat varchar(20), @MaNhanVien varchar(10), @MaKhachHang varchar(10), @NgayXuat datetime)
as
begin
	insert into PHIEUXUAT (MaPhieuXuat, MaNhanVien, MaKhachHang, NgayXuat) values (@MaPhieuXuat, @MaNhanVien, @MaKhachHang, @NgayXuat)
end
--exec addPhieuXuat 'PX1234564789781', 'NV12322255', 'KH12563258', '2023-03-25 10:34:09'
--exec addPhieuXuat 'PX1234564789782', 'NV12322255', 'KH00000000', '2023-03-25 10:37:09'
--select * from PHIEUXUAT
go
-- 13.2. Sua
CREATE proc updatePhieuXuat
(@MaPhieuXuat varchar(20), @MaNhanVien varchar(10), @MaKhachHang varchar(10), @NgayXuat datetime)
as
begin
	update PHIEUXUAT
	set MaNhanVien=@MaNhanVien, MaKhachHang=@MaKhachHang, NgayXuat=@NgayXuat
	where MaPhieuXuat=@MaPhieuXuat 
end
--exec updatePhieuXuat 'PX1234564789782', 'NV12322255', 'KH00000000', '2023-03-25 11:37:09'
go
-- 13.3. Xoa
CREATE proc deletePhieuXuat
(@MaPhieuXuat varchar(20))
as
begin
	delete PHIEUXUAT
	where MaPhieuXuat=@MaPhieuXuat 
end
--exec deletePhieuXuat 'PX1234564789782'
--select * from PHIEUXUAT
go


-- 14. PHIEUXUATCHITIET
-- 14.1. Them
CREATE proc addPhieuXuatChiTiet
(@MaPhieuXuatChiTiet varchar(20), @MaPhieuXuat varchar(20), @MaSanPham varchar(20), @SoLuong int)
as
begin
	insert into PHIEUXUATCHITIET (MaPhieuXuatChiTiet, MaPhieuXuat, MaSanPham, SoLuong) values (@MaPhieuXuatChiTiet, @MaPhieuXuat, @MaSanPham, @SoLuong)
end
--exec addPhieuXuatChiTiet 'PXCT123135464848','PX1234564789781','SP1235468811524',1
--exec addPhieuXuatChiTiet 'PXCT123135464849','PX1234564789782','SP1235468811524',1
go
-- 14.2. Sua
CREATE proc updatePhieuXuatChiTiet
(@MaPhieuXuatChiTiet varchar(20), @MaPhieuXuat varchar(20), @MaSanPham varchar(20), @SoLuong int)
as
begin
	update PHIEUXUATCHITIET
	set  MaPhieuXuat=@MaPhieuXuat, MaSanPham=@MaSanPham, SoLuong=@SoLuong
	where MaPhieuXuatChiTiet=@MaPhieuXuatChiTiet
end
--exec updatePhieuXuatChiTiet 'PXCT123135464849','PX1234564789782','SP1235468811524',2
go
-- 14.3. Xoa
CREATE proc deletePhieuXuatChiTiet
(@MaPhieuXuatChiTiet varchar(20))
as
begin
	delete PHIEUXUATCHITIET
	where MaPhieuXuatChiTiet=@MaPhieuXuatChiTiet
end
--exec deletePhieuXuatChiTiet 'PXCT123135464849'
--select * from PHIEUXUATCHITIET
go
-- 15. PHIEUHUY
-- 15.1. Them
CREATE proc addPhieuHuy
(@MaPhieuHuy varchar(20), @MaNhanVien varchar(10), @NgayHuy datetime)
as
begin
	insert into PHIEUHUY (MaPhieuHuy, MaNhanVien, NgayHuy) values (@MaPhieuHuy, @MaNhanVien, @NgayHuy)
end
--exec addPhieuHuy 'PH123115546548', 'NV23215684', '2023-03-25 11:37:09'
go
-- 15.2. Sua
CREATE proc updatePhieuHuy
(@MaPhieuHuy varchar(20), @MaNhanVien varchar(10), @NgayHuy datetime)
as
begin
	update PHIEUHUY
	set MaNhanVien=@MaNhanVien, NgayHuy=@NgayHuy
	where MaPhieuHuy=@MaPhieuHuy
end
--exec updatePhieuHuy 'PH123115546548', 'NV23215684', '2023-03-25 11:38:09'
go
-- 15.3. Xoa
CREATE proc deletePhieuHuy
(@MaPhieuHuy varchar(20))
as
begin
	delete PHIEUHUY
	where MaPhieuHuy=@MaPhieuHuy
end
--exec deletePhieuHuy 'PH123115546548'
--select * from PHIEUHUY
go
-- 16. PHIEUHUYCHITIET
-- 16.1. Them
CREATE proc addPhieuHuyChiTiet
(@MaPhieuHuyChiTiet varchar(20), @MaPhieuHuy varchar(20), @MaSanPham varchar(20), @SoLuong int)
as
begin
	insert into PHIEUHUYCHITIET (MaPhieuHuyChiTiet, MaPhieuHuy, MaSanPham, SoLuong) values (@MaPhieuHuyChiTiet, @MaPhieuHuy, @MaSanPham, @SoLuong)
end
--exec addPhieuHuyChiTiet 'PHCT1556456444','PH123115546548','SP1235468811524', 1 
go
-- 16.2. Sua
CREATE proc updatePhieuHuyChiTiet
(@MaPhieuHuyChiTiet varchar(20), @MaPhieuHuy varchar(20), @MaSanPham varchar(20), @SoLuong int)
as
begin
	update PHIEUHUYCHITIET
	set  MaPhieuHuy=@MaPhieuHuy, MaSanPham=@MaSanPham, SoLuong=@SoLuong
	where MaPhieuHuyChiTiet=@MaPhieuHuyChiTiet
end
--exec updatePhieuHuyChiTiet 'PHCT1556456444','PH123115546548','SP1235468811524', 2 
go
-- 16.3. Xoa
CREATE proc deletePhieuHuyChiTiet
(@MaPhieuHuyChiTiet varchar(20))
as
begin
	delete PHIEUHUYCHITIET
	where MaPhieuHuyChiTiet=@MaPhieuHuyChiTiet
end
--exec deletePhieuHuyChiTiet 'PHCT1556456444'
--select * from PHIEUHUYCHITIET
go
-- 17. LOAITAIKHOAN
-- 17.1. Them
CREATE proc addLoaiTaiKhoan
(@MaQuyen int, @TenQuyen nvarchar(30))
as
begin
	insert into LOAITAIKHOAN (MaQuyen, TenQuyen) values (@MaQuyen, @TenQuyen)
end
--exec addLoaiTaiKhoan 4, N'Quản trị tối cao'
go
-- 17.2. Sua
CREATE proc updateLoaiTaiKhoan
(@MaQuyen int, @TenQuyen nvarchar(30))
as
begin
	update LOAITAIKHOAN
	set TenQuyen=@TenQuyen
	where MaQuyen= @MaQuyen
end
--exec updateLoaiTaiKhoan 4, N'Quản trị cao nhất'
go
-- 17.3. Xoa
CREATE proc deleteLoaiTaiKhoan
(@MaQuyen int)
as
begin
	delete LOAITAIKHOAN
	where MaQuyen= @MaQuyen
end
--exec deleteLoaiTaiKhoan 4
--select * from LOAITAIKHOAN
go

-- TAO RANG BUOC (CHECK) --------------------------------------------------------------------------------------------------

-- TAO TRIGGER ------------------------------------------------------------------------------------------------------------

-- TAO VIEW ---------------------------------------------------------------------------------------------------------------
-- 1. View_NhaCungCap	(table : NHACUNGCAP)
create View View_NhaCungCap as select * from NHACUNGCAP;
go
-- 2. View_KhachHang	(table : LOAITHEKHACHHANG, THEKHACHHANG, KHACHHANG) 
create view View_KhachHang as
	select * 
	from KHACHHANG
go

-- 3. View_NhanVien		(table : NHANVIEN)
create view View_NhanVien as
	select * from NHANVIEN;
go

-- 4. View_SanPham		(table : LOAIKHUYENMAI, KHUYENMAI, LOAISANPHAM, SANPHAM)
create view View_SanPham as
	select SP.MaSanPham, SP.MaVach, SP.TenSanPham, SP.DonGiaBan, SP.DonViTinh, SP.NgaySanXuat, SP.HanSuDung, SP.HinhAnh, SP.MaLoaiSanPham, LSP.TenLoaiSanPham, SP.MaKhuyenMai, KM.GiaGiam, KM.NgayBatDau, KM.NgayKetThuc, KM.MaLoaiKhuyenMai, LKM.TenLoaiKhuyenMai
	from SANPHAM as SP
	inner join LOAISANPHAM as LSP on SP.MaLoaiSanPham=LSP.MaLoaiSanPham
	inner join KHUYENMAI as KM on SP.MaKhuyenMai=KM.MaKhuyenMai
	inner join LOAIKHUYENMAI as LKM on KM.MaLoaiKhuyenMai=LKM.MaLoaiKhuyenMai ;
go
-- 5. View_TheKhachHang
create view View_TheKhachHang as
	select KH.MaKhachHang, KH.HoTen, TKH.MaTheKhachHang, TKH.NgayLap, TKH.TichDiem, TKH.MaLoaiTheKhachHang, L.TenLoaiTheKhachHang 
	from KHACHHANG as KH
	inner join THEKHACHHANG as TKH on KH.MaKhachHang = TKH.MaKhachhang
	inner join LOAITHEKHACHHANG as L on TKH.MaLoaiTheKhachHang = L.MaLoaiTheKhachHang
go
-- 6. View_LoaiTheKhachHang
create view View_LoaiTheKhachHang as
	select *
	from LOAITHEKHACHHANG
	
go
-- 7. View_LoaiKhuyenMai
create view View_LoaiKhuyenMai as
	select *
	from LOAIKHUYENMAI	
go
-- 8. View_KhuyenMai
create view View_KhuyenMai as
	select *
	from KHUYENMAI	
go
-- 9. View_LoaiSanPham
create view View_LoaiSanPham as
	select *
	from LOAISANPHAM
go

-- 10. View_BanHang
create view View_BanHang as
	select PX.MaPhieuXuat,PXCT.MaPhieuXuatChiTiet, PX.NgayXuat, PX.MaNhanVien, NV.HoTen, PX.MaKhachHang, KH.HoTen,TKH.MaTheKhachHang,TKH.MaLoaiTheKhachHang,LTKH.TenLoaiTheKhachHang,TKH.TichDiem, PXCT.MaSanPham, SP.TenSanPham,SP.MaLoaiSanPham, LSP.TenLoaiSanPham, PXCT.SoLuong, SP.DonGiaBan, SP.DonViTinh, (SP.DonGiaBan*PXCT.SoLuong) as ThanhTien
	from PHIEUXUAT as PX
	inner join KHACHHANG as KH on PX.MaKhachHang = KH.MaKhachHang
	inner join THEKHACHHANG as TKH on TKH.MaKhachhang = KH.MaKhachHang
	inner join LOAITHEKHACHHANG as LTKH on LTKH.MaLoaiTheKhachHang = TKH.MaLoaiTheKhachHang
	inner join NHANVIEN as NV on PX.MaNhanVien = NV.MaNhanVien
	inner join PHIEUXUATCHITIET as PXCT on PX.MaPhieuXuat = PXCT.MaPhieuXuat
	inner join SANPHAM as SP on PXCT.MaSanPham = SP.MaSanPham
	inner join LOAISANPHAM as LSP on SP.MaLoaiSanPham = LSP.MaLoaiSanPham
go



-- TAO DU LIEU -----------------------------------------------------------------------------------------------------------
-- 1. LOAI TAI KHOAN
INSERT INTO LOAITAIKHOAN (MaQuyen,TenQuyen) VALUES (1,N'Quản Trị Viên');
INSERT INTO LOAITAIKHOAN (MaQuyen,TenQuyen) VALUES (2,N'Quản lý');
INSERT INTO LOAITAIKHOAN (MaQuyen,TenQuyen) VALUES (3,N'Nhân viên');
-- 2. TAI KHOAN
INSERT INTO TaiKhoan (TenTaiKhoan, MatKhau, MaNhanVien, MaQuyen) VALUES ('admin','123456','NV23705523',1);
INSERT INTO TaiKhoan (TenTaiKhoan, MatKhau, MaNhanVien, MaQuyen) VALUES ('hung','654321','NV23215684',2);







-- TRUY VAN
select TAIKHOAN.Id, TAIKHOAN.TenTaiKhoan, TAIKHOAN.MatKhau,TAIKHOAN.MaNhanVien, LOAITAIKHOAN.TenQuyen
from TAIKHOAN 
inner join LOAITAIKHOAN on LOAITAIKHOAN.MaQuyen = TAIKHOAN.MaQuyen

    
    
    
    
    