CREATE DATABASE QLDHS
GO
USE QLDHS;

CREATE TABLE chucvu(
	macv nvarchar(5) primary key,
	tencv nvarchar(50) not null,
) 
GO



CREATE TABLE monhoc (
    mamonhoc varchar(5) PRIMARY KEY,
    tenmon NVARCHAR(100) not null
);
GO

CREATE TABLE giaovien (
	magv char(5) Primary key ,
	holot nvarchar(50) not null,
	tengv nvarchar(50) not null,
	phai nvarchar(3),
	SDT char(10) check (SDT like '[0][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]'),
	namsinh date,
	macv nvarchar(5) not null foreign key(macv) references chucvu(macv),
	mamonhoc VARCHAR(5) not null foreign key(mamonhoc) references monhoc(mamonhoc)
 );
 GO


 Create table lop(
	malop char(5) primary key ,
	tenlop nvarchar(10),
	magv char(5) REFERENCES giaovien(magv)
);
GO


CREATE TABLE hocsinh (
	 mahs VARCHAR(5) PRIMARY KEY ,
	 holot nvarchar(50) not null,
	 tenhs nvarchar(50) not null,
	 phai nvarchar(3),
	 ngaysinh date,
	 SDT char(10) check (SDT like '[0][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]'),
	 hocphi int,
	 malop char(5) foreign key (malop) REFERENCES lop(maLop)
);
GO


CREATE TABLE diem (
    mahs  varchar(5) REFERENCES hocsinh(mahs),
	mamonhoc varchar(5) REFERENCES monhoc(mamonhoc),
	diemGKI float,
	diemHKI float,
	diemGKII float,
	diemHKII float,
	TBCN float
);
GO


CREATE TABLE nguoidung(
 ten nvarchar(30) not null primary key,
 matkhau varchar(50) not null,
 quyen tinyint
)
GO

Create table hocky(
	mahk nvarchar(3) primary key,
	tenhk nvarchar(50)
)
GO

INSERT INTO hocky VALUES('GK1','Giữa kỳ 1');
INSERT INTO hocky VALUES('HK1','Học kỳ 1');
INSERT INTO hocky VALUES('GK2','Giữa kỳ 2');
INSERT INTO hocky VALUES('HK2','Học kỳ 2');
GO

INSERT INTO chucvu VALUES(N'HT',N'Hiệu trưởng');
INSERT INTO chucvu VALUES(N'PHT',N'Phó hiệu trưởng');
INSERT INTO chucvu VALUES(N'TBM',N'Trưởng bộ môn');
INSERT INTO chucvu VALUES(N'PBM',N'Phó bộ môn');
INSERT INTO chucvu VALUES(N'QL',N'Quản lý');
INSERT INTO chucvu VALUES(N'GVBM',N'Giáo viên bộ môn');
GO



INSERT INTO nguoidung
VALUES(N'HieuTruong','e99a18c428cb38d5f260853678922e03',1); /*Mật khẩu abc123*/
INSERT INTO nguoidung
VALUES(N'GiaoVien','a906449d5769fa7361d7ecc6aa3f6d28',2); /*Mật khẩu 123abc*/


INSERT INTO monhoc VALUES('MH01',N'Toán');
INSERT INTO monhoc VALUES('MH02',N'Tiếng việt');
INSERT INTO monhoc VALUES('MH03',N'Tiếng anh');
INSERT INTO monhoc VALUES('MH04',N'Tự nhiên và xã hội');
INSERT INTO monhoc VALUES('MH05',N'Mỹ thuật');
INSERT INTO monhoc VALUES('MH06',N'Âm nhạc');
INSERT INTO monhoc VALUES('MH07',N'Thể dục');
INSERT INTO monhoc VALUES('MH08',N'Khoa học');
INSERT INTO monhoc VALUES('MH09',N'Đạo đức');
INSERT INTO monhoc VALUES('MH10',N'Tin học');
GO




--Tự động đăng mã Giáo Viên

CREATE TRIGGER AutoGenerate_GiaoVien
ON giaovien
INSTEAD OF INSERT
AS
BEGIN
    DECLARE @MaNV NVARCHAR(50)
    DECLARE @NextID INT

    SELECT @NextID = ISNULL(MAX(CAST(SUBSTRING(magv, 3, LEN(magv) - 2) AS INT)), 0) + 1
    FROM giaovien

    SELECT @MaNV = 'GV' + RIGHT('000' + CAST(@NextID AS NVARCHAR(10)), 2)

    INSERT INTO giaovien(magv,holot,tengv,phai,SDT,namsinh,macv,mamonhoc)
    SELECT @MaNV, holot,tengv,phai,SDT,namsinh,macv,mamonhoc
    FROM inserted
END;
INSERT INTO giaovien(holot,tengv,phai,SDT,namsinh,macv,mamonhoc) VALUES(N'Giáo viên thứ',N'Nhất',N'Nam','0000000001','1970-01-01',N'HT','MH01');

--Tự động đăng mã Lớp
CREATE TRIGGER AutoGenerate_Lop
ON lop
INSTEAD OF INSERT
AS
BEGIN
    DECLARE @MaNV NVARCHAR(50)
    DECLARE @NextID INT

    SELECT @NextID = ISNULL(MAX(CAST(SUBSTRING(malop, 3, LEN(malop) - 2) AS INT)), 0) + 1
    FROM lop

    SELECT @MaNV = 'ML' + RIGHT('000' + CAST(@NextID AS NVARCHAR(10)), 2)

    INSERT INTO lop(malop,tenlop,magv)
    SELECT @MaNV, tenlop, magv
    FROM inserted
END;
INSERT INTO lop(tenlop, magv) VALUES(N'Lop1A',N'GV01');
select * from lop

--Tự động đăng mã Học Sinh
CREATE TRIGGER AutoGenerate_HocSinh
ON hocsinh
INSTEAD OF INSERT
AS
BEGIN
    DECLARE @MaNV NVARCHAR(50)
    DECLARE @NextID INT

    SELECT @NextID = ISNULL(MAX(CAST(SUBSTRING(mahs, 3, LEN(mahs) - 2) AS INT)), 0) + 1
    FROM hocsinh

    SELECT @MaNV = 'HS' + RIGHT('000' + CAST(@NextID AS NVARCHAR(10)), 2)

    INSERT INTO hocsinh(mahs,holot,tenhs,phai,ngaysinh,SDT,hocphi,malop)
    SELECT @MaNV, holot,tenhs,phai,ngaysinh,SDT,hocphi,malop
    FROM inserted
END;

INSERT INTO hocsinh(holot,tenhs,phai,ngaysinh,SDT,hocphi,malop) VALUES(N'Học sinh thứ',N'Nhất',N'Nam','1975-04-19','0000000001','1000000',N'ML01');
select * from hocsinh



INSERT INTO diem VALUES(N'HS01',N'MH01',N'10.0',N'10.0',N'10.0',N'10.0','10.0');
GO