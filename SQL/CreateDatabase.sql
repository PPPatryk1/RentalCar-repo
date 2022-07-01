USE master   
GO  

create database RentalCar
go


DROP TABLE IF EXISTS [Cars]

CREATE TABLE [Cars] ( 
IDCar INT constraint prm_key_car PRIMARY KEY  IDENTITY(1,1) NOT NULL,
Brand nvarchar(30) NOT NULL,
Model nvarchar(50) NOT NULL,
EngineType VARCHAR(10) NOT NULL CHECK (EngineType IN ('petrol','diesel','electric','hybrid')) DEFAULT 'petrol',
Transmission VARCHAR(10) NOT NULL CHECK (Transmission IN ('manual','automatic')) DEFAULT 'manual',
DoorNumber int NOT NULL,
BootCapacity int NOT NULL,
Price int NOT NULL,
Status int NOT NULL CHECK (status IN (0,1)) DEFAULT 1)

INSERT INTO Cars (Brand, Model, EngineType, Transmission, DoorNumber,BootCapacity,Price,Status) 
VALUES	('Toyota', 'Corolla', 'diesel', 'manual',5,400,240,1), 
		('Volkswagen', 'Golf VI', 'petrol','automatic',3,300,180,0), 
		('Nissan', 'Qashqai', 'petrol','manual',5,550,275,1),
		('Audi', 'A4 b8 combi', 'diesel', 'manual',5,450,220,1), 
		('BMW', 'M4', 'petrol','automatic',3,230,1200,1), 
		('Toyota', 'Marki', 'hybrid','automatic',5,320,400,1),
		('Hyundai', 'Kona', 'electric', 'automatic',5,450,560,0),
		('Fiat', '500e La Prima', 'electric', 'automatic',3,200,350,1), 
		('Nissan', '390z', 'petrol','manual',3,260,890,0), 
		('Subaru', 'brz', 'petrol','manual',3,250,750,0);
go


DROP TABLE IF EXISTS [Customers]

CREATE TABLE [Customers] ( 
IDCustomer INT constraint prm_key_cust PRIMARY KEY  IDENTITY(1,1) NOT NULL,
Firstname nvarchar(30) NOT NULL,
Surrname nvarchar(30) NOT NULL,
Adress nvarchar(200) NOT NULL,
PhoneNumber int NOT NULL UNIQUE CHECK (PhoneNumber Not Like '%[^0-9]%'),
Email nvarchar(50) NOT NULL,
Password nvarchar(20) NOT NULL)

INSERT INTO Customers(Firstname, Surrname, Adress, PhoneNumber, Email,Password) 
VALUES	('Maciej', 'Róg', 'ul. Kwiatowa 34 98-300 Wieluñ', 874154895,'Maciej4322@gmail.com','wdedf432w'),
		('Jan', 'Madej', 'ul. Polna 22\4a 00-001 Warszawa', 587412367,'Jannek1221@o2.pl','KijfruJ33'),
		('Karolina', 'Lina', 'al. Kart 11b 76-555 £ódŸ', 259874565,'Karolcia21@onet.pl','MNDJjfurfh3223j'),
		('Milena', 'Kowalska', 'ul. Paska 4 63-093 Katowice', 987444514,'Mil0923ena@gmail.com','SDsdfds33'),
		('Henryk', 'Nowak', 'ul. Kolorowa 2 87-232 Bydgoszcz', 365985475,'HenNow@gmail.com','poiuhbn2'),
		('Patryk', 'Dos', 'ul. Polna 25\4b 00-001 Warszawa', 125478548,'PatrykDos00001@o2.pl','MKijij884rr4re');

go