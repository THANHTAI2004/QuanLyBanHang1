/*CREATE DATABASE PTPM_QLBanHang
USE PTPM_QLBanHang*/
set dateformat dmy
create table NhaSanXuat
(
	MaNSX int not null primary key identity,
	TenNSX nvarchar(255),
	DiaChi nvarchar(255),
	SDT varchar(12)
)
create table LoaiSanPham
(
	MaLoaiSP int primary key identity,
	TenLoaiSP nvarchar(MAX),
)
create table SanPham
(
	MaSP int not null primary key identity,
	TenSP nvarchar(255),
	HinhAnh nvarchar(MAX),
	DonGia decimal(18,0),
	SoLuongTon int,
	DaBan int,
	MaNSX int,
	MaLoaiSP int,
	foreign key (MaNSX) references NhaSanXuat(MaNSX) on delete cascade,
	foreign key (MaLoaiSP) references LoaiSanPham(MaLoaiSP),
)
create table NhanVien
(
	MaNV nvarchar(30) primary key not null,
	HoTen nvarchar(100),
	DiaChi nvarchar(255),
	NgaySinh datetime,
	ChucVu nvarchar(50),
	Luong int,
	SoDienThoai nvarchar(20),
)
create table TaiKhoan
(
	MaTK int identity primary key not null,
	TK nvarchar(50),
	MK varchar(50),
	MaNV nvarchar(30),
	Quyen nvarchar(10),
	TrangThai nvarchar(10),
	foreign key (MaNV) references NhanVien(MaNV) on delete cascade
)
create table KhachHang
(
	MaKH int identity primary key not null,
	Hoten nvarchar(255),
	DiaChi nvarchar(255),
	NgaySinh datetime,
	SoDienThoai nvarchar(20),
)
create table PhieuNhap
(
	MaPN int not null primary key identity,
	MaNSX int,
	NgayNhap datetime,
	foreign key (MaNSX) references NhaSanXuat(MaNSX) on delete cascade,
)
create table ChiTietPhieuNhap
(
	MaChiTietPN int not null primary key identity,
	MaPN int,
	MaSP int,
	DonGiaNhap decimal(18,0),
	SoLuongNhap int,
	foreign key (MaPN) references PhieuNhap(MaPN) on delete cascade,
	foreign key (MaSP) references SanPham(MaSP)
)
create table HoaDon
(
	MaHD nvarchar(10) primary key not null,
	NgayBan datetime,
	MaKH int,
	MaNV nvarchar(30),
	TongTien decimal(18,0),
	foreign key (MaKH) references KhachHang(MaKH) on delete cascade,
	foreign key (MaNV) references NhanVien(MaNV) on delete cascade,
)
create table ChiTietHoaDon
(
	MaCTHD int identity primary key not null,
	MaHD nvarchar(10),
	MaSP int,
	TenSP nvarchar(255),
	SoLuong int,
	DonGia decimal(18,0),
	foreign key (MaHD) references HoaDon(MaHD) on delete cascade,
	foreign key (MaSP) references SanPham(MaSP) on delete cascade,
)



insert into NhanVien values('N001666',N'Nguyễn Thành Tín',N'Quận 12','22/08/2000',N'Nhân viên bán hàng','7000000','0987656666')
insert into NhanVien values('L002673',N'Lê Huỳnh Phước Khôi',N'Quận 5','22/08/2000',N'Nhân viên bán hàng','7000000','0987656673')
insert into NhanVien values('N112138',N'Trịnh Hải Nguyên',N'Quận Gò Vấp','22/10/2000',N'Nhân viên bán hàng','7000000','0987653138')

insert into TaiKhoan values('haison','123','N001666','User','Offline')
insert into TaiKhoan values('thanhtai','123','L002673','User','Offline')
insert into TaiKhoan values('admin','123',null,'Admin','Offline')

insert into KhachHang values(N'Trịnh Tùng Chiến',N'TPHCM','22/10/2000','0954586929')
insert into KhachHang values(N'Nguyễn Thanh Minh Sơn',N'Cầu Giấy Hà Nội','21/09/2000','0876543211')
insert into KhachHang values(N'Trần Hồ Thiên Phú',N'Vĩnh Long','01/01/2000','0934567899')

insert into NhaSanXuat values(N'CÔNG TY HÀNG HOÁ SỈ LẺ',N'78-80-82 Hoàng Hoa Thám, Phường 12, Quận Tân Bình','0987654321')

insert into LoaiSanPham values(N'Bánh')
insert into LoaiSanPham values(N'Nước ngọt')
insert into LoaiSanPham values(N'Kẹo')
insert into LoaiSanPham values(N'Trà')
insert into LoaiSanPham values(N'Sách')
insert into LoaiSanPham values(N'Sữa')

insert into SanPham values(N'Sức mạnh của sự cô đơn',N'E:\QLBH\QLBH\Source\QuanLyBanHang\Resources\suc-manh-cua-su-co-don.jpg',68000,88,20,1,5)
insert into SanPham values(N'HOLMES Ở KYOTO',N'E:\QLBH\QLBH\Source\QuanLyBanHang\Resources\HOLMESOKYOTO.jpg',75000,100,11,1,5)
insert into SanPham values(N'Trường ca ACHILLES',N'E:\QLBH\QLBH\Source\QuanLyBanHang\Resources\truong-ca-achilles_bia-va-obi-1_1.jpg',156000,100,11,1,5)
insert into SanPham values(N'Thị trấn mèo',N'E:\QLBH\QLBH\Source\QuanLyBanHang\Resources\ThiTranMeo.jpg',68000,100,5,1,5)
insert into SanPham values(N'Chuyện ma ám ở trang viên BLY',N'E:\QLBH\QLBH\Source\QuanLyBanHang\Resources\chuyen-ma-am-o-trang-vien-bly.jpg',60000,100,4,1,5)
insert into SanPham values(N'Kẹo dẻo',N'E:\QLBH\QLBH\Source\QuanLyBanHang\Resources\keo-deo-haribo-goldbears-80g.jpg',7000,100,22,1,3)
insert into SanPham values(N'Kẹo mềm sữa bò',N'E:\QLBH\QLBH\Source\QuanLyBanHang\Resources\keomemsuabo.jpg',14000,100,22,1,3)
insert into SanPham values(N'Kẹo mềm sugar',N'E:\QLBH\QLBH\Source\QuanLyBanHang\Resources\keomemsugar.jpg',14000,100,6,1,3)
insert into SanPham values(N'Kẹo bốn mùa',N'E:\QLBH\QLBH\Source\QuanLyBanHang\Resources\keobonmua.jpg',12000,100,18,1,3)
insert into SanPham values(N'Bánh Choco-Pie',N'E:\QLBH\QLBH\Source\QuanLyBanHang\Resources\banhchocopie.jpg',24000,16,6,1,1)
insert into SanPham values(N'Bánh bông lan nho',N'E:\QLBH\QLBH\Source\QuanLyBanHang\Resources\banh-bong-lan-tuoi-bo-nho.jpg',5000,100,55,1,1)
insert into SanPham values(N'Bánh Toni vị cay',N'E:\QLBH\QLBH\Source\QuanLyBanHang\Resources\snack-vi-cay-toonies.jpg',6000,29,55,1,1)
insert into SanPham values(N'Bánh Quế vị dâu',N'E:\QLBH\QLBH\Source\QuanLyBanHang\Resources\banh-que-vi-kem-dau.jpg',7000,100,27,1,1)
insert into SanPham values(N'Bánh mì ngọt',N'E:\QLBH\QLBH\Source\QuanLyBanHang\Resources\banhmingot.jpg',6000,100,8,1,1)
insert into SanPham values(N'Bánh bao 2 trứng cút',N'E:\QLBH\QLBH\Source\QuanLyBanHang\Resources\bbao-2-trung.jpg',14000,31,31,1,1)
insert into SanPham values(N'Bánh tráng nướng',N'E:\QLBH\QLBH\Source\QuanLyBanHang\Resources\banh-trang-nướng.jpg',10000,57,16,1,1)
insert into SanPham values(N'Pepsi',N'E:\QLBH\QLBH\Source\QuanLyBanHang\Resources\nuoc-ngot-pepsi.jpg',10000,100,19,1,2)
insert into SanPham values(N'Cocacola',N'E:\QLBH\QLBH\Source\QuanLyBanHang\Resources\nuoc-ngot-coca-cola.jpg',10000,100,19,1,2)
insert into SanPham values(N'Monster Energy',N'E:\QLBH\QLBH\Source\QuanLyBanHang\Resources\nuoc-tang-luc-monster-energy.jpg',30000,100,27,1,2)
insert into SanPham values(N'C2 vị chanh',N'E:\QLBH\QLBH\Source\QuanLyBanHang\Resources\tra-xanh-c2-huong-chanh.jpg',10000,100,27,1,2)
insert into SanPham values(N'C2 vị đào',N'E:\QLBH\QLBH\Source\QuanLyBanHang\Resources\C2-vi-dao.jpg',10000,100,27,1,2)
insert into SanPham values(N'Sting dâu',N'E:\QLBH\QLBH\Source\QuanLyBanHang\Resources\sting-huong-dau.jpg',12000,10,33,1,2)
insert into SanPham values(N'Bò húc',N'E:\QLBH\QLBH\Source\QuanLyBanHang\Resources\bohuc.jpg',15000,100,31,1,2)
insert into SanPham values(N'Mirinda vị cam',N'E:\QLBH\QLBH\Source\QuanLyBanHang\Resources\mirinda-vi-cam.jpg',10000,100,17,1,2)
insert into SanPham values(N'Trà Lipton',N'E:\QLBH\QLBH\Source\QuanLyBanHang\Resources\Tralipton.jpg',10000,100,10,1,4)
insert into SanPham values(N'Sữa cô gái Hà Lan',N'E:\QLBH\QLBH\Source\QuanLyBanHang\Resources\cogaihalan.jpg',7500,25,66,1,6)
insert into SanPham values(N'Sữa milo',N'E:\QLBH\QLBH\Source\QuanLyBanHang\Resources\suamilo.jpg',6500,100,66,1,6)
insert into SanPham values(N'Sữa bột dành cho em bé',N'E:\QLBH\QLBH\Source\QuanLyBanHang\Resources\suabotdanhchoembe.jpg',271000,100,44,1,6)

insert into HoaDon values('T25489929','10/02/2025',1,'N001666',180000)
insert into HoaDon values('K33333333','11/02/2025',2,'L002673',35000)
insert into HoaDon values('T44124141','12/02/2025',1,'N001666',150000)
insert into HoaDon values('K53456711','13/02/2025',2,'L002673',12000)

insert into ChiTietHoaDon values('T25489929',5,N'Chuyện ma ám ở trang viên BLY',3,60000)
insert into ChiTietHoaDon values('K33333333',6,N'Kẹo dẻo',5,70000)
insert into ChiTietHoaDon values('T44124141',2,N'HOLMES Ở KYOTO',2,75000)
insert into ChiTietHoaDon values('K53456711',9,N'Kẹo bốn mùa',10,12000)