
CREATE TABLE Ogrenci (
    OgrenciID INT PRIMARY KEY,
    AdSoyad NVARCHAR(100) NOT NULL,
    Bolum NVARCHAR(100),
    Sinif INT
);


CREATE TABLE OgretimUyesi (
    OgretimUyesiID INT PRIMARY KEY,
    AdSoyad NVARCHAR(100) NOT NULL,
    Unvan NVARCHAR(50)
);


CREATE TABLE Ders (
    DersID INT PRIMARY KEY,
    DersAdi NVARCHAR(100) NOT NULL,
    Kredi INT,
    OgretimUyesiID INT,
    FOREIGN KEY (OgretimUyesiID) REFERENCES OgretimUyesi(OgretimUyesiID)
);



CREATE TABLE NotGiris (
    OgrenciID INT,
    DersID INT,
    Vize FLOAT,
    Final FLOAT,
    Ortalama FLOAT,
    PRIMARY KEY (OgrenciID, DersID),
    FOREIGN KEY (OgrenciID) REFERENCES Ogrenci(OgrenciID),
    FOREIGN KEY (DersID) REFERENCES Ders(DersID)
);








