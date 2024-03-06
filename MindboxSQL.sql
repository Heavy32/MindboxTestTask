CREATE DATABASE MindboxDB;

USE MindboxDB

CREATE TABLE Products (
    Id int PRIMARY KEY,
    Name varchar(255) NOT NULL,
);

CREATE TABLE Categories (
    Id int PRIMARY KEY,
    Name varchar(255) NOT NULL,
);

CREATE TABLE ProductsCategories (
    ProductId int NOT NULL,
    CategoryId int NOT NULL,
	PRIMARY KEY (ProductId, CategoryId)
);

INSERT INTO Products (Id, Name)
VALUES (1, 'Socks'),
	   (2, 'Milk'),
	   (3, 'Lamp'),
	   (4, 'Coca-Cola'),
	   (5, 'Sausages')
           (6, 'Ball')

INSERT INTO Categories(Id, Name)
VALUES (1, 'Clothes'),
	   (2, 'Drink'),
	   (3, 'For home'),
	   (4, 'Best choice'),
	   (5, 'Sale'); 

INSERT INTO ProductsCategories (ProductId, CategoryId)
VALUES (1, 1),
       (1, 4),
       (1, 5),
       (2, 2),
       (3, 3),
       (3, 5),
       (4, 2),
       (4, 4),
       (5, 4);

Select Products.Name, Categories.Name from ProductsCategories
INNER JOIN Categories
ON ProductsCategories.CategoryId = Categories.Id
FULL OUTER JOIN Products
ON ProductsCategories.ProductId = Products.Id;
