
USE Institute;

CREATE LOGIN Vasya WITH PASSWORD = '12345!';
GO
USE [Institute]
GO
CREATE USER [Vasya] FOR LOGIN [Vasya]
GO

CREATE SCHEMA poco AUTHORIZATION Vasya

GO
CREATE TABLE Product (
    Number CHAR(10) NOT NULL UNIQUE,
    Name CHAR(20) NULL,
    Price MONEY NULL);

GO
CREATE VIEW view_Product
    AS SELECT Number, Name
    FROM Product;

GO

CREATE ROLE marketing AUTHORIZATION Vasya;

GO
ALTER ROLE marketing ADD MEMBER Vasya;
