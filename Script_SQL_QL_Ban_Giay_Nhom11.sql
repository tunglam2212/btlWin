-- có thể ctrl A
create database qlgiay
go
use qlgiay

go
Create table [KhachHang]
(
	[SDT_KH] Nvarchar(30) not null ,
	[TenKH] Nvarchar(30) NULL,
	[DiaChi_KH] Nvarchar(30) NULL,
	[Sotiendatcoc] int,
Primary Key ([SDT_KH])
) 
go

Create table [HoaDonBan]
(
	[SoHD] int identity(1,1)  NOT NULL,
	[SDT_KH] Nvarchar(30) not null,
	[MaNQL] Nvarchar(30) NOT NULL,
	[NgayBan] Datetime NULL,
	chietkhau int,
Primary Key ([SoHD])
) 
go

Create table [NguoiQuanLi]
(
	[MaNQL] Nvarchar(30) NOT NULL,
	[TenNQL] Nvarchar(30) NULL,
	[SDT_NQL] Nvarchar(30) NULL,
	[DiaChi_NQL] Nvarchar(30) NULL,
	Mat_Khau nvarchar(30),
	TinhTrang nvarchar(30),
Primary Key ([MaNQL])
) 
go

Create table [SanPham]
(
	[MaSP] int identity(1,1) NOT NULL,
	[TenSP] Nvarchar(30) NULL,
	[GiaBan] int NULL,
	tinhtrang nvarchar(30)
Primary Key ([MaSP])
) 
go
create table Slcon(
[MaSP] int  NOT NULL,
size nvarchar(30),
slcon int,
Primary Key ([MaSP],size)
)

go
Create table [ChiTietHoaDon]
(
	[SoHD] int  NOT NULL,
	[MaSP] int  NOT NULL,
	size  nvarchar(30),
	[SoLuongBan] Integer NULL,
	[GiaBan] int NULL,
	thanhtien int,
Primary Key ([SoHD],[MaSP],size)
) 
go
Create table [ChiTietHoaDonBanNhap]
(
	[MaSP] int  NOT NULL,
	[TenSp] nvarchar(30),
	size  nvarchar(30),
	[SoLuongBan] Integer NULL,
	[GiaBan] int NULL,
	thanhtien int,
Primary Key ([MaSP],size)
) 


go






Create table [HoaDonNhap]
(
	[SoHDN] int identity(1,1) NOT NULL,
	[MaNCC] int NOT NULL,
	[MaNQL] Nvarchar(30) NOT NULL,
	[NgayNhap] Datetime NULL,
Primary Key ([SoHDN])
) 
go

Create table [ChiTietHoaDonNhap]
(
	[MaSP] int NOT NULL,
	[SoHDN] int  NOT NULL,
	size nvarchar(30),
	[SoLuongNhap] Integer NULL,
	[DonGiaNhap] int NULL,
	thanhtien int null
Primary Key ([MaSP],[SoHDN],size)
) 
go
Create table [ChiTietHoaDonNhapBanNhap]
(
	[MaSP] int NOT NULL,
	[TenSp] nvarchar(30),
	size nvarchar(30),
	[SoLuongNhap] Integer NULL,
	[DonGiaNhap] int NULL,
	thanhtien int null
Primary Key ([MaSP],size)
) 

create table [NhaCungCap]
(
	[MaNCC] int identity(01,01) NOT NULL,
	[TenNCC] Nvarchar(30) NULL,
	[SDT_NCC] Nvarchar(30) NULL,
	[DiaChiNCC] nvarChar(30) NULL,
	tinhtrang nvarchar(30)
Primary Key ([MaNCC])
) 
go


Alter table [HoaDonBan] add  foreign key([SDT_KH]) references [KhachHang] ([SDT_KH])  on update no action on delete no action 
go
Alter table [ChiTietHoaDon] add  foreign key([SoHD]) references [HoaDonBan] ([SoHD])  on update no action on delete no action 
go
Alter table [HoaDonBan] add  foreign key([MaNQL]) references [NguoiQuanLi] ([MaNQL])  on update no action on delete no action 
go
Alter table [HoaDonNhap] add  foreign key([MaNQL]) references [NguoiQuanLi] ([MaNQL])  on update no action on delete no action 
go
Alter table [ChiTietHoaDon] add  foreign key([MaSP]) references [SanPham] ([MaSP])  on update no action on delete no action 
go
Alter table [ChiTietHoaDonNhap] add  foreign key([MaSP]) references [SanPham] ([MaSP])  on update no action on delete no action 
go

Alter table slcon add  foreign key([MaSP]) references sanpham ([MaSP])  on update no action on delete no action 
go
Alter table [ChiTietHoaDonNhap] add  foreign key([SoHDN]) references [HoaDonNhap] ([SoHDN])  on update no action on delete no action 
go
Alter table [HoaDonNhap] add  foreign key([MaNCC]) references [NhaCungCap] ([MaNCC])  on update no action on delete no action 
go


Set quoted_identifier on
go


Set quoted_identifier off
go


/* Roles permissions */


/* Users permissions */
GO
insert into NguoiQuanLi values('NQL01',N'Vũ Kim Anh','0123456789','Ha Noi','NQL01','ADMIN')
insert into NguoiQuanLi values('NQL02',N'Nguyễn văn Cường','0017482939','Hai Phong','NQL02','NV')
insert into NguoiQuanLi values('NQL03',N'Phạm Thùy Linh','0123456789','Hung Yen','NQL03','VHH')
insert into NguoiQuanLi values('NQL04',N'Phùng Văn Đại','0123456789','Hung Yen','NQL04','VHH')
insert into NguoiQuanLi values('1',N'Văn Cường','0123456789','Hưng Yên','1','ADMIN')
-------------------------------------------------
GO
insert into KhachHang values('0123456789',N'Văn Cường',N'Nam Định')
insert into KhachHang values('0988787889',N'Quang Đạt',N'Khánh hòa')
insert into KhachHang values('0302434204',N'Mạnh Cường',N'Bình Dương')
insert into KhachHang values('8429389080',N'Văn Cường',N'Quảng Nam')
-------------------------------------------------
GO
-------------------------------------------------

-------------------------------------------------
GO
insert into NhaCungCap values(N'Long sơn 2','0986062627',N'Khánh Hòa',N'N')
insert into NhaCungCap values(N'Thiên An','0123456789',N'Đồng Nai',N'N')
insert into NhaCungCap values(N'Công ty Tràng An','0987654321',N'Bình Phước',N'K')
insert into NhaCungCap values(N'Công ty Vàm Cổ','0123456788',N'An Giang',N'N')
-------------------------------------------------

GO
------------------------------------------------
insert into SanPham values(N'Giày Thể Thao',1000,N'N')
insert into SanPham values(N'Giày Balenciaga',2000,N'N')
insert into SanPham values(N'Giày Converse',3000,N'K')
insert into SanPham values(N'Giày Puma',4000,N'N')
insert into SanPham values(N'Giày Sneaker',5000,N'N')
------------------------------------------------
go
insert into Slcon values (1,'32',160)
insert into Slcon values (1,'43',110)


insert into Slcon values (2,'34',150)
insert into Slcon values (2,'36',120)
insert into Slcon values (2,'35',110)


insert into Slcon values (3,'34',130)
insert into Slcon values (3,'33',100)
insert into Slcon values (3,'36',110)
insert into Slcon values (3,'35',120)

insert into Slcon values (4,'36',100)
insert into Slcon values (4,'37',140)
insert into Slcon values (4,'39',130)
insert into Slcon values (4,'35',100)

insert into Slcon values (5,'33',150)
insert into Slcon values (5,'36',130)
insert into Slcon values (5,'37',160)
insert into Slcon values (5,'38',130)



----



SELECT * FROM NguoiQuanLi
Select *from ChiTietHoaDonNhap
select *from ChiTietHoaDon
select * from SanPham
select * from HoaDonBan
select * from HoaDonNhap
select * from KhachHang
select * from NhaCungCap
GO

--XEM DANH SÁCH SẢN PHẨM
create PROC xemdanhsachsanpham(@mahd nvarchar(20))
as
begin
	select sanpham.masp ,tensp,size,soluongban,chitiethoadon.giaban,thanhtien from ChiTietHoaDon inner join SanPham on SanPham.MaSP=ChiTietHoaDon.MaSP
	where SoHD = @mahd
end

go
--TỔNG TIỀN BÁN
create proc tongtienban(@sohd int)
as
begin
	select sum(thanhtien) as'thành tiền' from ChiTietHoaDon where @sohd=SoHD 
	group by SoHD
end

go
--XEM CHI TIẾT DANH SÁCH ĐƠN HÀNG
create proc xemchitietdanhsachdonhang(@sohd int)
as
begin
	select hoadonban.sohd,ngayban,tennql,tenkh,diachi_kh,hoadonban.sdt_kh,chietkhau,sum(thanhtien) as'thành tiền' from KhachHang inner join HoaDonBan on KhachHang.SDT_KH=HoaDonBan.SDT_KH inner join NguoiQuanLi on NguoiQuanLi.MaNQL=HoaDonBan.MaNQL inner join ChiTietHoaDon on ChiTietHoaDon.SoHD=HoaDonBan.SoHD
	where HoaDonBan.SoHD=@sohd
	group by hoadonban.sohd,ngayban,tennql,tenkh,diachi_kh,hoadonban.sdt_kh,chietkhau
end

go
--XEM SẢN PHẨM ĐÃ NHẬP
create proc xemsanphamdanhap(@sohdn int)
as
begin
	select SanPham.MaSP,tensp,size,dongianhap,soluongnhap,thanhtien from SanPham inner join ChiTietHoaDonNhap on SanPham.MaSP=ChiTietHoaDonNhap.MaSP
	where SoHDN=@sohdn
end

--TÍNH TỐNG TIỀN NHẬP
GO
create proc tongtiennhap(@sohd int)
as
begin
	select sum(thanhtien) as'thành tiền' from ChiTietHoaDonNhap where @sohd=SoHDN 
	group by SoHDN
end
--XEM CHI TIẾT MỘT HÓA ĐƠN
go
create proc xemchitietmothoadonnhap(@sohdn int)
as
begin
	select ChiTietHoaDonNhap.SoHDN,ngaynhap,tennql,tenncc,diachincc,sdt_ncc from NguoiQuanLi inner join HoaDonNhap on HoaDonNhap.MaNQL=NguoiQuanLi.MaNQL inner join NhaCungCap on NhaCungCap.MaNCC=HoaDonNhap.MaNCC 
	inner join ChiTietHoaDonNhap 
	on ChiTietHoaDonNhap.SoHDN=HoaDonNhap.SoHDN
	where HoaDonNhap.SoHDN=@sohdn
end
GO
--THỐNG KÊ HÓA ĐƠN BÁN THEO NGÀY
create proc thongkehoadonbantheongay(@x date,@y date)
as
begin
	
		select sohd,ngayban,chietkhau,TenNQL from HoaDonBan inner join NguoiQuanLi on NguoiQuanLi.MaNQL= HoaDonBan.MaNQL
		where NgayBan >= @x and NgayBan <=@y
		order by SoHD desc
end

go




create proc thongkehoadonnhaptheongay(@x date,@y date)
as
begin
	if(@x=@y)
	begin
		select sohdn,tennql,ngaynhap,TenNQL from HoaDonNhap inner join NguoiQuanLi on NguoiQuanLi.MaNQL=HoaDonNhap.MaNQL
		where NgayNhap = @x 
		order by SoHDn desc
	end
	else
	begin
		select sohdn,tennql,ngaynhap from HoaDonNhap inner join NguoiQuanLi on NguoiQuanLi.MaNQL=HoaDonNhap.MaNQL
		where  NgayNhap >= @x and NgayNhap <=@y
		order by SoHDn desc
	end
end

go

create proc thongkesanphambanchaynhat
as
begin
	select sanpham.masp,tensp,sum(soluongban) as"Số lượng đã bán" from ChiTietHoaDon inner join SanPham on SanPham.MaSP=ChiTietHoaDon.MaSP
	group by sanpham.masp,tensp
	order by  [Số lượng đã bán]  DESC
end

go

create proc sosanhgiagiua2nhacungcap(@masp int)
as
begin
	Select NhaCungCap.MaNCC,TenNCC,avg(dongianhap) as"Tiền nhập trung bình" from HoaDonNhap inner join NhaCungCap 
	on HoaDonNhap.MaNCC=NhaCungCap.MaNCC
	inner join ChiTietHoaDonNhap on ChiTietHoaDonNhap.SoHDN=HoaDonNhap.SoHDN
	where MaSP=@masp
	group by NhaCungCap.MaNCC,TenNCC
	order by [Tiền nhập trung bình] asc
end




go

create proc thongketiennhap(@x date,@y date)
as
begin
	Select ChiTietHoaDon.SoHD,tensp,ChiTietHoaDon.giaban,size,soluongban,thanhtien,chietkhau,(thanhtien-thanhtien*chietkhau/100) as "Tiền trả",NgayBan,Tennql as "Người xuất" from ChiTietHoaDon inner join HoaDonBan on HoaDonBan.SoHD=ChiTietHoaDon.SoHD inner join SanPham on SanPham.MaSP=ChiTietHoaDon.MaSP inner join NguoiQuanLi on NguoiQuanLi.MaNQL=HoaDonBan.MaNQL
	where NgayBan >=@x and NgayBan <=@y
	order by ChiTietHoaDon.SoHD desc
end


go

create proc thongketiennhap2(@x date,@y date)
as
begin
	select ChiTietHoaDonNhap.SoHDN,tensp,size,soluongnhap,dongianhap,thanhtien,NgayNhap,Tennql as "Người nhập" from ChiTietHoaDonNhap inner join SanPham on SanPham.MaSP=ChiTietHoaDonNhap.MaSP inner join HoaDonNhap on HoaDonNhap.SoHDN=ChiTietHoaDonNhap.SoHDN inner join NguoiQuanLi on NguoiQuanLi.MaNQL=HoaDonNhap.MaNQL
	where NgayNhap >=@x and NgayNhap <@y
	order by ChiTietHoaDonNhap.SoHDN desc
end

go

create proc layRaSoHDBanvuaNhap
as
begin
	select * from HoaDonBan
	order by SoHD DESC
end

go
create proc layRaSoHDNhapvuaNhap
as
begin
	select SoHDN from HoaDonNhap
	order by SoHDN DESC
end

go

create proc khachhangvip
as
begin
	Select KHACHHANG.SDT_KH,TENKH,SUM((thanhtien-thanhtien*chietkhau/100)) AS "Tổng tiền chi"
	FROM KhachHang INNER JOIN HoaDonBan ON KhachHang.SDT_KH=HoaDonBan.SDT_KH
	INNER JOIN ChiTietHoaDon ON ChiTietHoaDon.SoHD = HoaDonBan.SoHD
	GROUP BY KHACHHANG.SDT_KH,TENKH
	ORDER BY [Tổng tiền chi] DESC
end

go
create proc nhaCungCapTonTaiHayChua (@Tenncc nvarchar(20))
as
begin
	select count(MaNCC) from NhaCungCap
	where @tenncc = TenNCC
end
go


--lấy ra số lương sản đang còn



go 
--lấy ra số lượng sản phẩm đang bán
CREATE proc xemsoluongsanphamcondangban(@masp int)
as
begin
	select sum(soluongban) from ChiTietHoaDonBanNhap WHERE MaSP = @masp
	group by MaSP
end




go
CREATE proc layratinhtrangNQL(@manql nvarchar(20))
as
begin
	select tinhtrang from NguoiQuanLi
	where MaNQL=@manql
end

GO

go 
create proc CapNhatSoLuongHangThemVao(@masp int,@size nvarchar(20),@soluongban int)
as
begin
	update Slcon 
	set Slcon=slcon-@soluongban
	where @masp=MaSP and @size=size
end

go

create proc CapNhatSoLuongHangXoa(@masp int,@size nvarchar(20),@soluongban int)
as
begin
	update Slcon 
	set Slcon=slcon+@soluongban
	where @masp=MaSP and @size=size
end
go

create proc tongsltrongkho
as
begin
select slcon.masp,tensp,sum(slcon) as'Tổng số lượng còn' from SanPham inner join Slcon on slcon.MaSP=SanPham.MaSP
group by slcon.masp,tensp
order by [Tổng số lượng còn] desc
end

go

create proc ThongkeNguoiBanNhieuNhat(@x date,@y date)
as
begin
	select NguoiQuanLi.manql,tennql,TinhTrang,sum(SoLuongBan*GiaBan- SoLuongBan*GiaBan*chietkhau/100) as 'Tiền bán được'
	from NguoiQuanLi inner join hoadonban 
	on hoadonban.manql=nguoiquanli.manql
	inner join ChiTietHoaDon on ChiTietHoaDon.SoHD=HoaDonBan.SoHD
	where NgayBan between @x and @y
	group by NguoiQuanLi.manql,tennql,TinhTrang
	order by [Tiền bán được] desc
end

go 
create proc thongkehoadonnhapTheoNgayCuaNhaCc(@mancc int,@x date, @y date)
as
begin
	select sohdn,nhacungcap.mancc,tenncc,ngaynhap from hoadonnhap inner join nhacungcap on nhacungcap.mancc=hoadonnhap.mancc 
	where hoadonnhap.mancc=@mancc
	and NgayNhap between @x and @y
end

