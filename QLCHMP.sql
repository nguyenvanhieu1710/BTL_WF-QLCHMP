create database QLCHMP;
go
use QLCHMP;
go
create table DangNhap(
	TenDangNhap nvarchar(50) primary key,
	MatKhau nvarchar(50) not null,
	Quyen nvarchar(50) not null
);
go
create table KhachHang(
	MaKhachHang nvarchar(50) primary key,
	TenKhachHang nvarchar(50) not null,
	NgaySinh nvarchar(15) not null,
	SoDienThoai nchar(10) not null,
	Email nvarchar(50) not null,
	GioiTinh nvarchar(3) not null,
	Anh nvarchar(100) not null
);
go
create table NhanVien(
	MaNhanVien nvarchar(50) primary key,
	TenNhanVien nvarchar(50) not null,
	QueQuan nvarchar(50) not null,
	SoDienThoai nchar(10) not null
);
go
create table ThongKe(
	MaSanPham nvarchar(10) primary key,
	TenSanPham nvarchar(50) not null,
	XuatXu nvarchar(50) not null,
	LoaiSanPham nvarchar(50) not null,
	SoLuong nchar(10) not null,
	GiaTien nchar(10) not null,
	NgayBan date not null
);
go
create table HoaDon(
	MaSanPham nvarchar(10) primary key,
	TenSanPham nvarchar(50) not null,
	XuatXu nvarchar(50) not null,
	LoaiSanPham nvarchar(50) not null,
	SoLuong nchar(10) not null,
	GiaTien nchar(10) not null,
	NgayBan date not null,
	DiaChi nvarchar(50) not null,
	MaKhachHang nvarchar(50) not null
);
go
create table SanPham(
	MaSanPham nvarchar(10) primary key,
	TenSanPham nvarchar(50) not null,
	XuatXu nvarchar(50) not null,
	LoaiSanPham nvarchar(50) not null,
	SoLuong nchar(10) not null,
	GiaTien nchar(10) not null
);
go
create table DonHang(
	MaSanPham nvarchar(10),
	TenSanPham nvarchar(50) not null,
	XuatXu nvarchar(50) not null,
	LoaiSanPham nvarchar(50) not null,
	SoLuong nchar(10) not null,
	GiaTien nchar(10) not null,
	constraint FK_MaSanPham foreign key (MaSanPham) references SanPham(MaSanPham)
);
go