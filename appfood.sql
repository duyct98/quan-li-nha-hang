create database QL_APPFOODtest45
USE QL_APPFOODtest45

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

INSERT INTO tbl_khach VALUES ('K001', N'Nguyễn Văn An', N'Hà Nội', '','00001', '123')
INSERT INTO tbl_khach VALUES ('K002', N'Nguyễn Văn B', N'QUAN 2', '','00002', '123')
INSERT INTO tbl_taixe VALUES ('TX002', N'Nguyễn Văn A', N'QUAN 1', '','00001', '123')
INSERT INTO tbl_taixe VALUES ('TX001', N'Nguyễn Văn A', N'QUAN 1', '','00001', '123')



INSERT INTO tbl_CuaHang VALUES ('CH001', 'FOOD QUÁN 1', 'QUAN 1','', '00001', '123')
INSERT INTO tbl_CuaHang VALUES ('CH002', 'FOOD QUÁN 2', 'QUAN 2','', '00002', '123')
INSERT INTO tbl_CuaHang VALUES ('CH003', 'FOOD QUÁN 3', 'QUAN 3','', '00003', '123')

INSERT INTO tbl_hangban VALUES ('CH001', 'H001', 'BANH TRANG', '1', '10000')
INSERT INTO tbl_hangban VALUES ('CH002', 'H002', 'BANH NUONG', '1', '20000')
INSERT INTO tbl_hangban VALUES ('CH003', 'H003', 'TRA SUA', '1', '15000')

INSERT INTO tbl_DonHang VALUES ('DH002', '2021-03-12', 'CH002', 'K002', 'TX001')
INSERT INTO tbl_DonHang VALUES ('DH003', '2021-03-12', 'CH002', 'K002', 'TX001')
INSERT INTO tbl_DonHang VALUES ('DH004', '2021-03-12', 'CH002', 'K002', 'TX001')

INSERT INTO tbl_hang VALUES ('DH004', 'H002', '3')
INSERT INTO tbl_hang VALUES ('DH002', 'H002', '3')
INSERT INTO tbl_hang VALUES ('DH003', 'H001', '1')

select top 1 CuaHangID from tbl_CuaHang


select hangID from tbl_hangban ORDER BY hangID asc 


select CuaHangID from tbl_CuaHang where SDT='00001'

create view v_full as
select k.TenKhach,DH.DonHangID,TenCuaHang,tx.TenTaiXe,h.SoLuong,DonGia,hb.TenHang
from tbl_DonHang dh inner join tbl_khach  k on dh.KhachID = k.KhachID
inner join tbl_taixe tx on dh.TaiXeID = tx.TaiXeID
inner join tbl_hang h on dh.DonHangID = h.DonHangID
inner join tbl_hangban hb on h.HangID = hb.HangID

inner join tbl_CuaHang ch on dh.CuaHangID = ch.CuaHangID

group by TenKhach,dh.DonHangID,TenCuaHang,TenTaiXe,DonGia,SoLuong,hb.TenHang


create view v_dshk2 as
select k.KhachID,TenKhach,Sum(SoLuong) as 'TongSL'
from tbl_hangban hb inner join tbl_HoaDon hd on hb.HoaDonID = hd.HoaDonID
inner join tbl_khach k on hd.KhachID = k.KhachID
inner join tbl_hang h on hb.HangID = h.HangID
where hb.HangID = 'H001'
group by k.KhachID,TenKhach
having sum(SoLuong) > 4

select HangID,TenHang,DonVi,DonGia
from tbl_hangban


ALTER TABLE   tbl_DonHang
add constraint fk_k_dh foreign key (KhachID) references tbl_khach  (KhachID)


alter table  tbl_Hang
add constraint fk_dh_h foreign key (DonHangID) references tbl_DonHang   (DonHangID)
alter table tbl_Hang
add constraint fk_h_hb foreign key (HangID) references tbl_HangBan (HangID)




ALTER TABLE tbl_hoadon
add constraint fk_hd_k foreign key (KhachID) references tbl_khach (KhachID)
alter table tbl_hangban
add constraint fk_hb_hd foreign key (HoaDonID) references tbl_hoadon (HoaDonID)
alter table tbl_hangban
add constraint fk_hb_h foreign key (HangID) references tbl_hang (HangID)

/* Chèn dữ liệu */
ALTER TABLE tbl_hangban
ADD CONSTRAINT fc_sl CHECK (SoLuong >= 0)

INSERT INTO tbl_khach VALUES ('K001', N'Nguyễn Văn An', N'Hà Nội', 'an@gmail.com', N'Hình 1')
INSERT INTO tbl_khach VALUES ('K002', N'Trần Minh Chiến', N'Đà Nẵng', 'chien@gmail.com', N'Hình 2')
INSERT INTO tbl_khach VALUES ('K003', N'Nguyễn Thị Hồng', N'Long An', 'hong@gmail.com', N'Hình 3')
INSERT INTO tbl_khach VALUES ('K004', N'Nguyễn Thu Trang', N'Hồ Chí Minh', 'trang@gmail.com', N'Hình 4')
INSERT INTO tbl_khach VALUES ('K005', N'Phạm Tuấn Ngọc', N'Hà Nội', 'ngoc@gmail.com', N'Hình 5')
INSERT INTO tbl_khach VALUES ('K006', N'Phạm Thành Danh', N'Hồ Chí Minh', 'danh@gmail.com', N'Hình 6')

INSERT INTO tbl_hang VALUES ('H001', N'Bàn phím', N'Cái', '10')
INSERT INTO tbl_hang VALUES ('H002', N'Ram', N'Thanh', '200')
INSERT INTO tbl_hang VALUES ('H003', N'Màn hình', N'Màn', '300')
INSERT INTO tbl_hang VALUES ('H004', N'Máy in', N'Cái', '150')
INSERT INTO tbl_hang VALUES ('H005', N'Ổ cứng', N'Ổ', '100')

INSERT INTO tbl_hoadon VALUES ('HD01', '2021-03-12', 'K001')
INSERT INTO tbl_hoadon VALUES ('HD02', '2021-04-01', 'K002')
INSERT INTO tbl_hoadon VALUES ('HD03', '2021-08-19', 'K001')
INSERT INTO tbl_hoadon VALUES ('HD04', '2021-12-12', 'K003')
INSERT INTO tbl_hoadon VALUES ('HD05', '2021-01-12', 'K004')
INSERT INTO tbl_hoadon VALUES ('HD06', '2021-01-26', 'K005')
INSERT INTO tbl_hoadon VALUES ('HD07', '2021-02-02', 'K006')
INSERT INTO tbl_hoadon VALUES ('HD08', '2021-03-01', 'K002')
INSERT INTO tbl_hoadon VALUES ('HD09', '2021-03-11', 'K001')

INSERT INTO tbl_hangban VALUES ('H001', 'HD01', '4') 
INSERT INTO tbl_hangban VALUES ('H001', 'HD02', '5')
INSERT INTO tbl_hangban VALUES ('H001', 'HD04', '4')
INSERT INTO tbl_hangban VALUES ('H001', 'HD05', '4')
INSERT INTO tbl_hangban VALUES ('H002', 'HD01', '2')
INSERT INTO tbl_hangban VALUES ('H002', 'HD04', '8')
INSERT INTO tbl_hangban VALUES ('H002', 'HD06', '4')
INSERT INTO tbl_hangban VALUES ('H003', 'HD01', '12')
INSERT INTO tbl_hangban VALUES ('H003', 'HD02', '8')
INSERT INTO tbl_hangban VALUES ('H003', 'HD07', '4')
INSERT INTO tbl_hangban VALUES ('H004', 'HD03', '4')
INSERT INTO tbl_hangban VALUES ('H004', 'HD08', '4')
INSERT INTO tbl_hangban VALUES ('H005', 'HD03', '11')

create view v_dshk1 as
select hd.KhachID,TenKhach,HoaDonID,NgayBan from tbl_khach k 
inner join tbl_hoadon hd on k.KhachID = hd.KhachID

select * from v_dshk1

create view v_dshk2 as
select k.KhachID,TenKhach,Sum(SoLuong) as 'TongSL'
from tbl_hangban hb inner join tbl_HoaDon hd on hb.HoaDonID = hd.HoaDonID
inner join tbl_khach k on hd.KhachID = k.KhachID
inner join tbl_hang h on hb.HangID = h.HangID
where hb.HangID = 'H001'
group by k.KhachID,TenKhach
having sum(SoLuong) > 4

/* tạo view đưa ra danh sách các mặt hàng trong 3 tháng 3,6,9 
số lượng > 5 , hangID,Tenhang,NgayBan,SoLuong */

create view v_dskh4 as
select hb.HangID,TenHang,NgayBan,sum(SoLuong) as 'tongSl'
from tbl_hangban hb inner join tbl_HoaDon hd on hb.HoaDonID = hd.HoaDonID
inner join tbl_khach k on hd.KhachID = k.KhachID
inner join tbl_hang h on hb.HangID = h.HangID
where (MONTH(NgayBan) = 3 or MONTH(NgayBan) = 6 or MONTH(NgayBan) = 9 )

group by hb.HangID,TenHang,NgayBan

create view v_dskh3 as
select top 1 hd.KhachID as 'Ma Khach',TenKhach,Sum(SoLuong*DonGia) as 'Tong Tien'
from tbl_hangban hb inner join tbl_HoaDon hd on hb.HoaDonID = hd.HoaDonID
inner join tbl_khach k on hd.KhachID = k.KhachID
inner join tbl_hang h on hb.HangID = h.HangID
group by hd.KhachID,TenKhach


create view view1 as
select hd.HoaDonID as 'Ma Hoa Don',NgayBan,Sum(SoLuong*DonGia) as 'Tong Tien'
from tbl_hangban hb inner join tbl_HoaDon hd on hb.HoaDonID = hd.HoaDonID
inner join tbl_khach k on hd.KhachID = k.KhachID
inner join tbl_hang h on hb.HangID = h.HangID
where MONTH(NgayBan)<=3 and YEAR(NgayBan)=2021
group by hd.HoaDonID,NgayBan


create view TongTienTheoThang as
select MONTH(NgayBan) as 'Thang',Sum(SoLuong*DonGia) as 'Tong Tien'
from tbl_hangban hb inner join tbl_HoaDon hd on hb.HoaDonID = hd.HoaDonID
inner join tbl_khach k on hd.KhachID = k.KhachID
inner join tbl_hang h on hb.HangID = h.HangID
group by MONTH(NgayBan)

select * from TongTienTheoThang

INSERT INTO tbl_hangban (CuaHangID,TenHang,DonVi,DonGia) VALUES ('1', 'BANH TRANG', '1', '10000')
INSERT INTO tbl_hangban (CuaHangID,TenHang,DonVi,DonGia,Anh) VALUES ('1', 'BANH TRANG', '1', '10000',)
INSERT INTO tbl_hangban (loai,TenHang,DonVi,DonGia,Anh) select 'ruoubia',1, 'BANH TRANG', 'Banh', 10000, BulkColumn from OPENROWSET ('C:\Users\Admin\Downloads\duy.jpg' ,Single blob) as Picture

select * from tbl_hangban
INSERT INTO tbl_hangban (CuaHangID,TenHang,DonVi,DonGia,Anh) VALUES ('1', 'BANH TRANG', '1', '10000')
INSERT INTO tbl_hangban(CuaHangID,TenHang,DonVi,DonGia,Anh)
select 1, 'BANH TRANG', 'Banh', 10000, BulkColumn from openrowset (bulk N'C:\Users\Admin\Downloads\duy.jpg',SINGLE_BLOB) as Picture

select anh from tbl_hangban where hangid='2'
select * from tbl_hangban

select * from tbl_hangban

INSERT INTO tbl_hangban (CuaHangID,TenHang,DonVi,DonGia) VALUES ('1', N'Trà chanh', '', '15000')
INSERT INTO tbl_hangban (CuaHangID,TenHang,DonVi,DonGia) VALUES ('1', N'Trà Đào', '', '15000')
INSERT INTO tbl_hangban (CuaHangID,TenHang,DonVi,DonGia) VALUES ('1', N'Trà vải', '', '15000')
INSERT INTO tbl_hangban (CuaHangID,TenHang,DonVi,DonGia) VALUES ('1', N'Trà tắt', '', '15000')
INSERT INTO tbl_hangban (CuaHangID,TenHang,DonVi,DonGia) VALUES ('1', N'Bánh tráng trộn', '', '15000')
INSERT INTO tbl_hangban (CuaHangID,TenHang,DonVi,DonGia) VALUES ('1', N'Bánh trứng cút', '', '20000')
INSERT INTO tbl_hangban (CuaHangID,TenHang,DonVi,DonGia) VALUES ('1', N'Bánh tráng nướng', '', '20000')
INSERT INTO tbl_hangban (CuaHangID,TenHang,DonVi,DonGia) VALUES ('1', N'Bánh mì nướng', '', '20000')

select * from tbl_hangban
update tbl_hangban(loai,TenHang,DonVi,DonGia,Anh)
select 'ruoubia', N'Bánh tráng trộn', '', 30000 , BulkColumn from openrowset (bulk N'C:\Users\Admin\Downloads\APP KHACH CHUAN\ITEM FOOD\banhtrangtron.jpg',SINGLE_BLOB) as Picture

INSERT INTO tbl_hangban(loai,TenHang,DonVi,DonGia,Anh)
select 'monanchinh', N'Bánh trứng cút', '', 320000 , BulkColumn from openrowset (bulk N'C:\Users\Admin\Downloads\APP KHACH CHUAN\ITEM FOOD\banhtrungcut.jpg',SINGLE_BLOB) as Picture


INSERT INTO tbl_hangban(loai,TenHang,DonVi,DonGia,Anh)
select 'anvat', N'Bánh tráng nướng', '', 21000 , BulkColumn from openrowset (bulk N'C:\Users\Admin\Downloads\APP KHACH CHUAN\ITEM FOOD\banhtrangnuong.jpg',SINGLE_BLOB) as Picture


INSERT INTO tbl_hangban(loai,TenHang,DonVi,DonGia,Anh)
select 'nuocuong', N'Trà chanh', '', 125000 , BulkColumn from openrowset (bulk N'C:\Users\Admin\Downloads\APP KHACH CHUAN\ITEM FOOD\traChanh.jpg',SINGLE_BLOB) as Picture


INSERT INTO tbl_hangban(CuaHangID,TenHang,DonVi,DonGia,Anh)
select 2, N'Trà đào', '', 15000 , BulkColumn from openrowset (bulk N'C:\Users\Admin\Downloads\APP KHACH CHUAN\ITEM FOOD\tradao.jpg',SINGLE_BLOB) as Picture
SELECT @@IDENTITY asLastID

insert into tbl_CuaHang(TenCuaHang,DiaChi,SDT,MATKHAU) values (N'FOOD QUẬN 2 ',N'QUA',N'001',N'123')
INSERT INTO tbl_khach(TenKhach,DiaChi,Email,SDT,MATKHAU) VALUES (N'Nguyễn Văn A',N'Quận 1','','0123','123');

select MATKHAU from tbl_khach where MATKHAU='123'

UPDATE tbl_khach 
SET MATKHAU = '1234'
WHERE sdt='0001'

select * from tbl_khach

(delete tbl_khach where KhachID=;


select * from tbl_hang
select * from tbl_DonHang
select * from tbl_hangban
select * from tbl_CuaHang
select TenHang from tbl_hangban where hangid='2'

select khachid from tbl_Khach where SDT LIKE N'0123'


insert into tbl_DonHang(NgayBan,CuaHangID,KhachID) values (GETDATE (),1,1)
SELECT @@IDENTITY asLastID

insert into tbl_hang(DonHangID,HangID,SoLuong) values (1,1,3)

create view view_Hoadon2 as
select TenHang,SoLuong,dh.DonHangID,DonGia,hb.HangID,Anh
from tbl_hang h inner join tbl_hangban hb on hb.hangid = h.hangid
inner join tbl_DonHang dh on dh.DonHangID = h.DonHangID

group by TenHang,SoLuong,dh.DonHangID,DonGia,hb.HangID,Anh


select h.HangID,TenHang,SoLuong,DonGia
from tbl_hang h inner join tbl_hangban hb on hb.hangid = h.hangid

where h.DonHangID = 1022
group by  h.HangID,TenHang,SoLuong,DonGia


insert into tbl_DonHang(CuaHangID,KhachID) values (1,1)

select Count(HangID) from tbl_hang where DonHangID= 1

select sum(SoLuong*dongia) from tbl_hang


insert tbl_DonHang(NgayBan,KhachID) values (GETDATE(),1)
SELECT @@IDENTITY asLastID

insert tbl_hang(DonHangID,HangID,SoLuong) values (1,1,1)

delete tbl_DonHang where DonHangID = 7

select * from view_Hoadon2
select sum(DonGia*SoLuong) from view_Hoadon2 where DonHangID = 1

select COUNT(hangid)from view_Hoadon2 where DonHangID = 11


select tenhang from view_Hoadon1 where hangid=1 and donhangid =2

select HangID from view_Hoadon2 where DonHangID = 11 and HangID= 6


delete from tbl_hang
where DonHangID = '11'
delete from tbl_DonHang
where DonHangID = '11'

SELECT MONTH(GETDATE())

 

select * from tbl_DonHang
INSERT tbl_DonHang(NgayBan) values ('2022-9-22')

select dh.DonHangID,sum(DonGia*SoLuong)as 'tongbill',dh.NgayBan
from tbl_hang h inner join tbl_hangban hb on hb.hangid = h.hangid inner join tbl_DonHang dh on dh.DonHangID = h.DonHangID 
group by dh.DonHangID,dh.NgayBan 
order by 'tongbill' asc

view_Bill1