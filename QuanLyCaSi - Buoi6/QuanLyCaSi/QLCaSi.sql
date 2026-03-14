create database QLCaSi
go

use QLCaSi

create table TaiKhoan(
	MaTK varchar(6) primary key,
	TenDangNhap nvarchar(100) not null,
	MatKhau varchar(20),
	VaiTro varchar(20) not null,
	TrangThai varchar(1)
);
ALTER TABLE TaiKhoan
ADD CONSTRAINT CK_TrangThai
CHECK (
    (VaiTro = 'Staff' AND TrangThai IN (0,1))
    OR
    (VaiTro IN ('Admin','Guest'))
);

select * from TaiKhoan

ALTER TABLE TaiKhoan
DROP CONSTRAINT PK__TaiKhoan__27250070AC6DF056;

ALTER TABLE TaiKhoan
DROP COLUMN MaTK;

EXEC sp_help 'TaiKhoan';

INSERT INTO TaiKhoan VALUES
('TK001','admin','123','Admin','1'),
('TK002','staff01','123','Staff','1'),
('TK003','guest01',NULL,'Guest',NULL);


create table CaSi(
	MaCS varchar(6) primary key check(MaCS like 'CS[0-9][0-9][0-9][0-9]'),
	TenCS nvarchar(100) not null,
	GTinh nvarchar(3) check (GTinh in (N'nam', N'nữ')) not null,
	Ngsinh date,
	SDT varchar(10) not null UNIQUE
		constraint chk_sdt_CS check (sdt like '0[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]'),
	DChi nvarchar(200),
	Catxe int not null,
	TenTG nvarchar(100) not null
);

INSERT INTO CaSi (MaCS, TenCS, GTinh, Ngsinh, SDT, DChi, Catxe) VALUES
('CS0001', N'Sơn Tùng M-TP', N'nam', '1994-07-05', '0912345678', N'Thái Bình', 50000000),
('CS0002', N'Mỹ Tâm', N'nữ', '1981-01-16', '0901234567', N'Đà Nẵng', 60000000),
('CS0003', N'Đức Phúc', N'nam', '1996-10-15', '0934567890', N'Hà Nội', 30000000),
('CS0004', N'Hòa Minzy', N'nữ', '1995-05-31', '0987654321', N'Bắc Ninh', 35000000),
('CS0005', N'Noo Phước Thịnh', N'nam', '1988-12-18', '0971234567', N'TP Hồ Chí Minh', 45000000),
('CS0006', N'Bích Phương', N'nữ', '1989-09-30', '0962345678', N'Quảng Ninh', 40000000),
('CS0007', N'Erik', N'nam', '1997-10-13', '0945678901', N'Hà Nội', 32000000),
('CS0008', N'Chi Pu', N'nữ', '1993-06-14', '0923456789', N'Hà Nội', 38000000);

select * from casi

create table TacGia(
	MaTG varchar(6) primary key check(MaTG like 'TG[0-9][0-9][0-9][0-9]'),
	TenTG nvarchar(100) not null,
	SDT varchar(10) not null UNIQUE
		constraint chk_sdt_TG check (SDT like '0[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]'),
	GTinh nvarchar(3) check (GTinh in (N'nam', N'nữ')) not null,
	NgSinh date,
	DChi nvarchar(200)
);

drop table TacGia

INSERT INTO TacGia (MaTG, TenTG, SDT, GTinh, NgSinh, DChi) VALUES
('TG0001', N'Nguyễn Văn An', '0912345678', N'nam', '1985-03-12', N'Hà Nội'),
('TG0002', N'Trần Thị Mai', '0987654321', N'nữ', '1990-07-25', N'TP Hồ Chí Minh'),
('TG0003', N'Lê Quốc Bảo', '0901234567', N'nam', '1982-11-05', N'Đà Nẵng'),
('TG0004', N'Phạm Minh Tuấn', '0934567890', N'nam', '1978-09-18', N'Cần Thơ'),
('TG0005', N'Hoàng Thu Hà', '0976543210', N'nữ', '1995-01-30', N'Hải Phòng'),
('TG0006', N'Đỗ Thanh Bình', '0923456789', N'nam', '1988-06-14', N'Bình Dương'),
('TG0007', N'Vũ Ngọc Lan', '0945678901', N'nữ', '1992-04-22', N'Quảng Ninh'),
('TG0008', N'Bùi Đức Huy', '0967890123', N'nam', '1980-12-09', N'Nghệ An');

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
select * from taikhoan



