create database cnpm;
go
use cnpm;
go
create table TaiKhoanNhanVien (
	TenDangNhap char(4) PRIMARY KEY,
	MatKhau char(10) NOT NULL,
	Quyen bit default 0,
);

create table GoiCuoc (
	MaGoi char(3) PRIMARY KEY,
	TenGoi nvarchar(30) NOT NULL,
	Phi int NOT NULL,
	ThoiHan int NOT NULL,
);

create table KhachHang(
	MSSV char(8) PRIMARY KEY, 
	Ho nvarchar(20) NOT NULL, 
	Ten nvarchar(10) NOT NULL, 
	KhuKTX char(2) NOT NULL, 
	SoDienThoai char(10) NOT NULL, 
	SoPhong char(3) NOT NULL, 
	MatKhau varchar(10) NOT NULL,
);

create table DangKy (
	MaDK char(10) PRIMARY KEY, 
	MSSV char(8) NOT NULL, 
	NgayDK date NOT NULL, 
	MaGoi char(3) NOT NULL,
	constraint fk_dk_goi FOREIGN KEY (MaGoi) REFERENCES GoiCuoc (MaGoi),
	constraint fk_dk_kh FOREIGN KEY (MSSV) REFERENCES KhachHang (MSSV),
);