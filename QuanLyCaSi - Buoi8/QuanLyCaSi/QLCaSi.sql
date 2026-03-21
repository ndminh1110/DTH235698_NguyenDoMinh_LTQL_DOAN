use master

create database QLCaSi
go

use QLCaSi

CREATE TABLE TaiKhoan(
    MaTK        varchar(6)    PRIMARY KEY,
    TenDangNhap nvarchar(100) NOT NULL,
    MatKhau     varchar(20),
    VaiTro      varchar(20)   NOT NULL,
    TrangThai   varchar(1)
);
ALTER TABLE TaiKhoan
ADD CONSTRAINT CK_TrangThai
CHECK (
    (VaiTro = 'Staff' AND TrangThai IN ('0','1'))
    OR
    (VaiTro IN ('Admin','Guest'))
);

CREATE TABLE TacGia(
    MaTG    varchar(6)    PRIMARY KEY CHECK(MaTG LIKE 'TG[0-9][0-9][0-9][0-9]'),
    TenTG   nvarchar(100) NOT NULL,
    SDT     varchar(10)   NOT NULL UNIQUE
                          CONSTRAINT chk_sdt_TG CHECK(SDT LIKE '0[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]'),
    GTinh   nvarchar(3)   NOT NULL CHECK(GTinh IN (N'nam', N'nữ')),
    NgSinh  date,
    DChi    nvarchar(200)
);

CREATE TABLE CaSi(
    MaCS    varchar(6)    PRIMARY KEY CHECK(MaCS LIKE 'CS[0-9][0-9][0-9][0-9]'),
    TenCS   nvarchar(100) NOT NULL,
    GTinh   nvarchar(3)   NOT NULL CHECK(GTinh IN (N'nam', N'nữ')),
    Ngsinh  date,
    SDT     varchar(10)   NOT NULL UNIQUE
                          CONSTRAINT chk_sdt_CS CHECK(SDT LIKE '0[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]'),
    DChi    nvarchar(200),
    Catxe   int           NOT NULL
    -- Đã xóa cột TenTG
);

CREATE TABLE Single(
    MaBH        varchar(6)    PRIMARY KEY CHECK(MaBH LIKE 'BH[0-9][0-9][0-9][0-9]'),
    TenBH       nvarchar(100) NOT NULL,
    MaCS        varchar(6)    NOT NULL FOREIGN KEY REFERENCES CaSi(MaCS),
    MaTG        varchar(6)    NOT NULL FOREIGN KEY REFERENCES TacGia(MaTG),
    NgPhatHanh  date,
    MaCSHT      varchar(6)    NULL FOREIGN KEY REFERENCES CaSi(MaCS)
);

CREATE TABLE Album(
    MaAlbum    varchar(9)    PRIMARY KEY CHECK(MaAlbum LIKE 'Album[0-9][0-9][0-9][0-9]'),
    TenAlbum   nvarchar(200) NOT NULL,
    MaCS       varchar(6)    NOT NULL FOREIGN KEY REFERENCES CaSi(MaCS),
    NgPhatHanh date
);

CREATE TABLE AlbumSingle(
    MaAlbum varchar(9) NOT NULL FOREIGN KEY REFERENCES Album(MaAlbum),
    MaBH    varchar(6) NOT NULL FOREIGN KEY REFERENCES Single(MaBH),
    PRIMARY KEY (MaAlbum, MaBH)
);

CREATE TABLE Show(
    MaShow  varchar(8)    PRIMARY KEY CHECK(MaShow LIKE 'Show[0-9][0-9][0-9][0-9]'),
    TenShow nvarchar(200) NOT NULL,
    MaBH    varchar(6)    NOT NULL FOREIGN KEY REFERENCES Single(MaBH),
    NgDien  date,
    GiaVe   int,
    DChi    nvarchar(200)
);

CREATE TABLE ShowCaSi(
    MaShow varchar(8) NOT NULL FOREIGN KEY REFERENCES Show(MaShow),
    MaCS   varchar(6) NOT NULL FOREIGN KEY REFERENCES CaSi(MaCS),
    PRIMARY KEY (MaShow, MaCS)
);

INSERT INTO TaiKhoan VALUES
('TK001', 'admin',   '123',  'Admin', NULL),
('TK002', 'staff01', '123',  'Staff', '1'),
('TK003', 'staff02', '456',  'Staff', '0'),
('TK004', 'guest01',  NULL,  'Guest', NULL);

INSERT INTO TacGia (MaTG, TenTG, SDT, GTinh, NgSinh, DChi) VALUES
('TG0001', N'Nguyễn Văn An',   '0912345671', N'nam', '1985-03-12', N'Hà Nội'),
('TG0002', N'Trần Thị Mai',    '0987654322', N'nữ',  '1990-07-25', N'TP Hồ Chí Minh'),
('TG0003', N'Lê Quốc Bảo',    '0901234563', N'nam', '1982-11-05', N'Đà Nẵng'),
('TG0004', N'Phạm Minh Tuấn', '0934567894', N'nam', '1978-09-18', N'Cần Thơ'),
('TG0005', N'Hoàng Thu Hà',   '0976543215', N'nữ',  '1995-01-30', N'Hải Phòng'),
('TG0006', N'Đỗ Thanh Bình',  '0923456786', N'nam', '1988-06-14', N'Bình Dương'),
('TG0007', N'Vũ Ngọc Lan',    '0945678907', N'nữ',  '1992-04-22', N'Quảng Ninh'),
('TG0008', N'Bùi Đức Huy',    '0967890128', N'nam', '1980-12-09', N'Nghệ An');

INSERT INTO CaSi (MaCS, TenCS, GTinh, Ngsinh, SDT, DChi, Catxe) VALUES
('CS0001', N'Sơn Tùng M-TP',   N'nam', '1994-07-05', '0912000001', N'Thái Bình',       50000000),
('CS0002', N'Mỹ Tâm',          N'nữ',  '1981-01-16', '0912000002', N'Đà Nẵng',         60000000),
('CS0003', N'Đức Phúc',        N'nam', '1996-10-15', '0912000003', N'Hà Nội',           30000000),
('CS0004', N'Hòa Minzy',       N'nữ',  '1995-05-31', '0912000004', N'Bắc Ninh',         35000000),
('CS0005', N'Noo Phước Thịnh', N'nam', '1988-12-18', '0912000005', N'TP Hồ Chí Minh',  45000000),
('CS0006', N'Bích Phương',     N'nữ',  '1989-09-30', '0912000006', N'Quảng Ninh',       40000000),
('CS0007', N'Erik',            N'nam', '1997-10-13', '0912000007', N'Hà Nội',           32000000),
('CS0008', N'Chi Pu',          N'nữ',  '1993-06-14', '0912000008', N'Hà Nội',           38000000);

INSERT INTO Single (MaBH, TenBH, MaCS, MaTG, NgPhatHanh, MaCSHT) VALUES
('BH0001', N'Lạc Trôi',              'CS0001', 'TG0001', '2017-01-01', NULL),
('BH0002', N'Chạy Ngay Đi',          'CS0001', 'TG0001', '2018-05-12', NULL),
('BH0003', N'Nơi Này Có Anh',        'CS0001', 'TG0002', '2017-02-14', NULL),
('BH0004', N'Trống Cơm',             'CS0002', 'TG0003', '2019-03-20', NULL),
('BH0005', N'Bài Ca Đất Phương Nam', 'CS0002', 'TG0003', '2020-06-01', NULL),
('BH0006', N'Em Của Ngày Hôm Qua',   'CS0003', 'TG0002', '2014-02-14', NULL),
('BH0007', N'Hơn Cả Yêu',            'CS0007', 'TG0004', '2020-02-11', 'CS0008'),
('BH0008', N'Không Thể Say',         'CS0004', 'TG0005', '2021-03-15', 'CS0003'),
('BH0009', N'Bước Qua Mùa Cô Đơn',  'CS0005', 'TG0006', '2022-03-20', NULL),
('BH0010', N'Mơ',                    'CS0006', 'TG0007', '2021-08-10', NULL),
('BH0011', N'Túy Âm',                'CS0007', 'TG0008', '2022-11-01', NULL),
('BH0012', N'Đóa Hoa Hồng',          'CS0008', 'TG0005', '2023-02-14', NULL);

INSERT INTO Album (MaAlbum, TenAlbum, MaCS, NgPhatHanh) VALUES
('Album0001', N'Sky Tour',        'CS0001', '2019-07-05'),
('Album0002', N'Tâm 9',           'CS0002', '2020-01-16'),
('Album0003', N'Thế Giới Của Em', 'CS0003', '2021-10-15'),
('Album0004', N'Bội Bạc',         'CS0007', '2022-12-01');

INSERT INTO AlbumSingle (MaAlbum, MaBH) VALUES
('Album0001', 'BH0001'),
('Album0001', 'BH0002'),
('Album0001', 'BH0003'),
('Album0002', 'BH0004'),
('Album0002', 'BH0005'),
('Album0003', 'BH0006'),
('Album0003', 'BH0008'),
('Album0004', 'BH0007'),
('Album0004', 'BH0011');



INSERT INTO Show (MaShow, TenShow, MaBH, NgDien, GiaVe, DChi) VALUES
('Show0001', N'Sky Tour Concert 2019',     'BH0001', '2019-07-20', 800000,  N'Hà Nội'),
('Show0002', N'Mỹ Tâm Live Show 2020',    'BH0004', '2020-03-15', 600000,  N'TP Hồ Chí Minh'),
('Show0003', N'Vietnam Music Festival',    'BH0006', '2021-12-31', 500000,  N'Đà Nẵng'),
('Show0004', N'Gala Nhạc Việt 2022',       'BH0009', '2022-04-10', 400000,  N'Cần Thơ'),
('Show0005', N'Đêm Nhạc Trẻ 2023',        'BH0011', '2023-06-01', 350000,  N'Hà Nội');

INSERT INTO ShowCaSi (MaShow, MaCS) VALUES
('Show0001', 'CS0001'),
('Show0001', 'CS0003'),
('Show0002', 'CS0002'),
('Show0002', 'CS0004'),
('Show0003', 'CS0003'),
('Show0003', 'CS0006'),
('Show0003', 'CS0007'),
('Show0004', 'CS0005'),
('Show0004', 'CS0008'),
('Show0005', 'CS0007'),
('Show0005', 'CS0008');

select * from CaSi
select * from Single
select * from Album
select * from AlbumSingle
select * from ShowCaSi
select * from TaiKhoan
select * from TacGia
select * from Show

