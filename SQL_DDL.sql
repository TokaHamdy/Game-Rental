CREATE DATABASE GameRental

CREATE TABLE Admin
(
  Fname VARCHAR(30) NOT NULL,
  Lname VARCHAR(30) NOT NULL,
  password VARCHAR(30) NOT NULL,
  gender VARCHAR(7) NOT NULL,
  bdate DATE,
  Admin_ID  INT IDENTITY (1,1),
  PRIMARY KEY (Admin_ID)
);

CREATE TABLE Client
(
  Fname VARCHAR(30) NOT NULL,
  Lname VARCHAR(30) NOT NULL,
  password VARCHAR(30) NOT NULL,
  gender VARCHAR(7) NOT NULL,
  bdate DATE,
  client_ID INT IDENTITY (1,1),
  PRIMARY KEY (client_ID)
);

CREATE TABLE vendor
(
  Fname VARCHAR(30) NOT NULL,
  Lname VARCHAR(30) NOT NULL,
  gender VARCHAR(7) NOT NULL,
  vendor_ID INT IDENTITY (1,1),
  PRIMARY KEY (vendor_ID)
);

CREATE TABLE game
(
  game_ID INT IDENTITY (1,1),
  game_name VARCHAR(50) unique NOT NULL,
  category VARCHAR(30) NOT NULL,
  game_year INT NOT NULL,
  game_month INT NOT NULL,
  Admin_ID INT NOT NULL,
  vendor_ID INT NOT NULL,
  client_ID INT ,
  Rent_value INT Default 0,
  count_g INT Default 0,
  PRIMARY KEY (game_ID),
  FOREIGN KEY (Admin_ID) REFERENCES Admin(Admin_ID),
  FOREIGN KEY (client_ID) REFERENCES Client(client_ID),
  FOREIGN KEY (vendor_ID) REFERENCES vendor(vendor_ID)
);

CREATE TABLE RentDate
(
  Cient_ID INT NOT NULL ,
  Vendor_ID INT NOT NULL,
  c_time DATE NOT NULL,
  Game_name VARCHAR(30) NOT NULL,
);