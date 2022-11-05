create database QL_APPFOODtest50
USE QL_APPFOODtest50

CREATE TABLE tbl_khach
(
	KhachID INT IDENTITY (1,1) primary key,
	TenKhach nvarchar(50) ,
	DiaChi nvarchar(50),
	Email nvarchar(50),
	taikhoan nvarchar(50) ,
	MATKHAU nvarchar(50) 
)

create table tbl_CuaHang
(
	taikhoan nvarchar(50) ,
	MATKHAU nvarchar(50) 
)

CREATE TABLE tbl_DonHang
(	
	
	DonHangID INT IDENTITY (1000,1)primary key,
	NgayBan datetime,
	KhachID INT,
	
	
	
)
create table tbl_hang
(	
	DonHangID INT ,
	HangID INT ,
	SoLuong nvarchar(50)
)
create table tbl_hangban
(	
	
	HangID INT IDENTITY (1,1) primary key,
	TenHang nvarchar(50),
	DonVi nvarchar(50),
	DonGia float,
	loai nvarchar(50),
	Anh varbinary(max),
)
ALTER TABLE   tbl_DonHang
add constraint fk_k_dh foreign key (KhachID) references tbl_khach  (KhachID)
alter table  tbl_Hang
add constraint fk_dh_h foreign key (DonHangID) references tbl_DonHang   (DonHangID)
alter table tbl_Hang
add constraint fk_h_hb foreign key (HangID) references tbl_HangBan (HangID)

insert tbl_CuaHang (MATKHAU) values ('123')