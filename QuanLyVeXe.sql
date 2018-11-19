use master
go
if db_id('qlvx') is not null
	drop database qlvx
go 
create database qlvx
go
use qlvx
go


create table LoaiXe
(
ID_LoaiXe int,
TenLoai varchar(4000),
primary key(ID_LoaiXe)
)
create table Xe
(
XeID int,
TenXe varchar(4000),
So_dang_ky varchar(4000),
LoaiXe_ID_LoaiXe int,
primary key(XeID),
foreign key(LoaiXe_ID_LoaiXe) references LoaiXe
)


create table KhachHang
(
ID_KhachHang int,
HoTen varchar(4000),
DienThoai varchar(4000),
Email varchar(4000),
Loai int,
primary key(ID_KhachHang)
)
create table Tai_xe
(
ID_TaiXe int,
TenTaiXe varchar(4000),
BangLai varchar(4000),
primary key (ID_TaiXe)
)

create table Tram
(
ID_Tram int,
TenTram varchar(4000),
Dia_diem varchar(4000),
primary key(ID_Tram)
)
create table Tuyen
(
ID_Tuyen int,
KhoangCach int,
ThoiGianChay int,
Tram_ID_Tram1 int,
Tram_ID_Tram int,
primary key(ID_Tuyen),
foreign key(Tram_ID_Tram) references Tram,
foreign key(Tram_ID_Tram1) references Tram
)
create table Tram_trung_gian
(
Tuyen_ID_Tuyen int,
Tram_ID_Tram int,
Thu_tu int,
primary key(Tuyen_ID_Tuyen,Tram_ID_Tram),
foreign key(Tram_ID_Tram) references Tram,
foreign key(Tuyen_ID_Tuyen) references Tuyen
)


create table Ghe
( 
ID_Ghe int,
Dong int,
Cot int,
Tang int,
So_ghe int,
Xe_XeID int,

primary key(ID_Ghe),
foreign key(Xe_XeID) references Xe
)
create table Chuyen
(
ID_Chuyen int,
Tuyen_ID_Tuyen int,
Gio_khoi_hanh date,
Ghi_chu varchar(4000),
Xe_XeID int,
Tai_xe_ID_Taixe int,
primary key(ID_Chuyen),
foreign key(Tai_xe_ID_Taixe) references Tai_xe,
foreign key(Tuyen_ID_Tuyen) references Tuyen,
foreign key(Xe_XeID) references Xe
)

create table Ve
(
ID_Ve int,
Ghe_ID_Ghe int,
Chuyen_ID_Chuyen int,
TinhTrang int,
GiaTien int,
KhachHang_ID_KhachHang int,
NgayXuatVe date,
GhiChu varchar(4000)
primary key(ID_Ve),
foreign key(Chuyen_ID_Chuyen) references Chuyen,
foreign key(KhachHang_ID_KhachHang) references KhachHang
)








