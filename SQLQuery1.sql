CREATE TABLE Car(
  Id int PRIMARY KEY IDENTITY(1,1),
  BrandId int,
  ColorId int,
  ModelYear nvarchar(25),
  DailyPrice decimal,
  Descriptions nvarchar(25),
  FOREIGN KEY (BrandID) REFERENCES Brand(BrandID),
  FOREIGN KEY (ColorID) REFERENCES Color(ColorID)
)

CREATE TABLE Color(
   ColorId int PRIMARY KEY IDENTITY(1,1),
   ColorName nvarchar(25)
)

CREATE TABLE Brand(
     BrandId int PRIMARY KEY IDENTITY(1,1),
     BrandName nvarchar(25)
)

INSERT INTO Car(BrandId,ColorId,ModelYear,DailyPrice,Descriptions)
VALUES
     ('4','3','2016','200','manual'),
     ('3','4','2021','300','automatic'),
     ('2','1','2020','500','automatic'),
     ('1','2','2018','400','automatic');

INSERT INTO Color(ColorName)
VALUES
    ('Yeşil'),  
    ('Kırmızı'),  
    ('Beyaz'),  
    ('Mavi');
    
INSERT INTO Brand(BrandName)
VALUES
     ('PORSCHE'),
     ('NISSAN'),
     ('AUDI'),
     ('BMW');

SELECT * FROM Car
SELECT * FROM Brand
SELECT * FROM Color