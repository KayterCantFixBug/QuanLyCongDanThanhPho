CREATE DATABASE QuanLyCongDanThanhPho
GO

USE QuanLyCongDanThanhPho
GO

CREATE TABLE dbo.CongDan(
	MaCD INT IDENTITY PRIMARY KEY,
	HoTen NVARCHAR(255) NOT NULL,
	NgaySinh DATE NOT NULL DEFAULT GETDATE(),
	NoiSinh NVARCHAR(255) NOT NULL,
	GioiTinh NVARCHAR(255) NOT NULL,
	NgheNghiep NVARCHAR(255) NOT NULL DEFAULT N'Chưa có',
	TinhTrangHonNhan NVARCHAR(255) NOT NULL DEFAULT N'Độc thân',
	DanToc NVARCHAR(255) NOT NULL DEFAULT N'Kinh',
	TonGiao NVARCHAR(255) NOT NULL DEFAULT N'Không',
)
GO

CREATE TABLE dbo.HoKhau(
	MaHo INT IDENTITY PRIMARY KEY,
	ChuHo INT FOREIGN KEY REFERENCES dbo.CongDan(MaCD) NOT NULL,
	TinhThanh NVARCHAR(255) NOT NULL,
	QuanHuyen NVARCHAR(255) NOT NULL,
	PhuongXa NVARCHAR(255) NOT NULL
)
GO

CREATE TABLE dbo.ChiTietHoKhau(
	MaHo INT FOREIGN KEY REFERENCES dbo.HoKhau(MaHo) NOT NULL,
	MaCD INT FOREIGN KEY REFERENCES dbo.CongDan(MaCD) NOT NULL,
	TinhTrangCuTru NVARCHAR(255) NOT NULL DEFAULT N'Thường trú',
	QuanHeVoiChuHo NVARCHAR(255) NOT NULL DEFAULT N'Là chủ hộ',
	PRIMARY KEY (MaHo, MaCD, TinhTrangCuTru)
)
GO

CREATE TABLE dbo.TaiKhoan(
	TenTK NVARCHAR(255) NOT NULL PRIMARY KEY,
	MatKhau NVARCHAR(255) NOT NULL,
	MaCD INT FOREIGN KEY REFERENCES dbo.CongDan(MaCD) NOT NULL
)
GO

CREATE TABLE dbo.PhanQuyen(
	MaCD INT FOREIGN KEY REFERENCES dbo.CongDan(MaCD) NOT NULL,
	TenQuyen NVARCHAR(255) NOT NULL DEFAULT N'Công dân',
	PRIMARY KEY (MaCD, TenQuyen)
)
GO

CREATE TABLE dbo.CanCuocCongDan(
	CCCD NVARCHAR(12) PRIMARY KEY,
	MaCD INT NOT NULL FOREIGN KEY REFERENCES dbo.CongDan(MaCD),
	MaHo INT FOREIGN KEY REFERENCES dbo.HoKhau(MaHo) NOT NULL,
	NgayCap DATE NOT NULL DEFAULT GETDATE(),
	NoiCap NVARCHAR(255) NOT NULL DEFAULT N'CỤC TRƯỞNG CỤC CẢNH SÁT QUẢN LÝ HÀNH CHÍNH VỀ TRẬT TỰ XÃ HỘI'
)
GO

CREATE TABLE dbo.Mail(
	MaMail INT IDENTITY PRIMARY KEY,
	TieuDe NVARCHAR(255) NOT NULL DEFAULT N'Chưa có tiêu đề',
	NguoiGui NVARCHAR(255) FOREIGN KEY REFERENCES dbo.TaiKhoan(TenTK) NOT NULL,
	NguoiNhan NVARCHAR(255) FOREIGN KEY REFERENCES dbo.TaiKhoan(TenTK) NOT NULL
)
GO

INSERT INTO dbo.CongDan (HoTen, NgaySinh, NoiSinh, GioiTinh, NgheNghiep, TinhTrangHonNhan, DanToc, TonGiao)
VALUES
(N'Nguyễn Văn A', '1990-01-01', N'Hà Nội', N'Nam', N'Lập trình viên', N'Độc thân', N'Kinh', N'Không'),
(N'Trần Thị B', '1995-05-05', N'Hải Phòng', N'Nữ', N'Giáo viên', N'Đã kết hôn', N'Tày', N'Phật giáo'),
(N'Phạm Văn C', '1985-12-31', N'Đà Nẵng', N'Nam', N'Kỹ sư', N'Đã kết hôn', N'Chăm', N'Hồi giáo'),
(N'Lê Thị D', '2000-07-15', N'Hồ Chí Minh', N'Nữ', N'Sinh viên', N'Độc thân', N'Mường', N'Công giáo');

INSERT INTO dbo.HoKhau
(
    ChuHo,
    TinhThanh,
    QuanHuyen,
    PhuongXa
)
VALUES
(   1,   -- ChuHo - int
    N'Hà nội', -- TinhThanh - nvarchar(255)
    N'2', -- QuanHuyen - nvarchar(255)
    N'4'  -- PhuongXa - nvarchar(255)
)
GO

INSERT INTO dbo.HoKhau
(
    ChuHo,
    TinhThanh,
    QuanHuyen,
    PhuongXa
)
VALUES
(   3,   -- ChuHo - int
    N'Hồ Chí Minh', -- TinhThanh - nvarchar(255)
    N'8', -- QuanHuyen - nvarchar(255)
    N'15'  -- PhuongXa - nvarchar(255)
)
GO

INSERT INTO dbo.ChiTietHoKhau
(
    MaHo,
    MaCD,
    TinhTrangCuTru,
    QuanHeVoiChuHo
)
VALUES
(   1,       -- MaHo - int
    1,       -- MaCD - int
    DEFAULT, -- TinhTrangCuTru - int
    DEFAULT  -- QuanHeVoiChuHo - nvarchar(255)
)
GO

INSERT INTO dbo.ChiTietHoKhau
(
    MaHo,
    MaCD,
    TinhTrangCuTru,
    QuanHeVoiChuHo
)
VALUES
(   1,       -- MaHo - int
    2,       -- MaCD - int
    DEFAULT, -- TinhTrangCuTru - int
    N'Cháu'  -- QuanHeVoiChuHo - nvarchar(255)
)
GO

INSERT INTO dbo.ChiTietHoKhau
(
    MaHo,
    MaCD,
    TinhTrangCuTru,
    QuanHeVoiChuHo
)
VALUES
(   2,       -- MaHo - int
    3,       -- MaCD - int
    DEFAULT, -- TinhTrangCuTru - int
    DEFAULT  -- QuanHeVoiChuHo - nvarchar(255)
)
GO

INSERT INTO dbo.ChiTietHoKhau
(
    MaHo,
    MaCD,
    TinhTrangCuTru,
    QuanHeVoiChuHo
)
VALUES
(   2,       -- MaHo - int
    4,       -- MaCD - int
    DEFAULT, -- TinhTrangCuTru - int
    N'Em'  -- QuanHeVoiChuHo - nvarchar(255)
)
GO

INSERT INTO dbo.TaiKhoan (TenTK, MatKhau, MaCD)
VALUES
('nguyenvana', 'password123', 1),
('tranthib', 'abc123', 2),
('phamvanc', 'xyz789', 3),
('lethid', 'qwe456', 4);
GO

SELECT * FROM dbo.CongDan WHERE MaCD = {0}