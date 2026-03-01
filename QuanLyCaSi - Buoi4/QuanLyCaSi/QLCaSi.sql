create database QLCaSi
go

use QLCaSi

create table TaiKhoan(
	MaTK varchar(6) primary key,
	TenDangNhap nvarchar(100) not null,
	MatKhau varchar(20) not null,
	VaiTro varchar(20) not null,
	TrangThai varchar(1)
);

create table CaSi(
	MaCS varchar(6) primary key check(MaCS like 'CS[0-9][0-9][0-9][0-9]'),
	TenCS nvarchar(100) not null,
	GTinh nvarchar(3) check (GTinh in (N'nam', N'nữ')) not null,
	Ngsinh date,
	SDT varchar(10) not null UNIQUE
		constraint chk_sdt_CS check (sdt like '0[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]'),
	DChi nvarchar(200),
	Catxe int not null
);

create table TacGia(
	MaTG varchar(6) primary key check(MaTG like 'TG[0-9][0-9][0-9][0-9]'),
	TenTG nvarchar(100) not null,
	SDT varchar(10) not null UNIQUE
		constraint chk_sdt_CS check (sdt like '0[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]'),
	NgSinh date,
	DChi nvarchar(200)
);

create table Single(
	MaBH varchar(6) primary key check(MaBH like 'BH[0-9][0-9][0-9][0-9]'),
	TenBH nvarchar(100) not null,
	MaCS varchar(6) not null  foreign key (MaCS) references CaSi(MaCS),
	MaTG varchar(6) not null  foreign key (MaTG) references TacGia(MaTG),
	NgPhatHanh date,
	MaCSHT varchar(6) not null  foreign key (MaCSHT) references CaSi(MaCS)
);

create table Album(
	MaAlbum varchar(9) primary key check(MaAlbum like 'Album[0-9][0-9][0-9][0-9]'),
	TenAlbum nvarchar(200) not null,
	MaCS varchar(6) not null  foreign key (MaCS) references CaSi(MaCS),
	NgPhatHanh date,
	MaBH varchar(6) not null foreign key (MaBH) references Single(MaBH)
);

create table Show(
	MaShow varchar(8) primary key check(MaShow like 'Show[0-9][0-9][0-9][0-9]'),
	TenShow nvarchar(200) not null,
	MaBH varchar(6) not null foreign key (MaBH) references Single(MaBH),
	NgDien date,
	GiaVe int,
	DChi nvarchar(200)
);


------create table DoanhThu();


