CREATE TABLE Product
(
	Id int IDENTITY(1, 1) PRIMARY KEY,
	Name VARCHAR(30)
)

INSERT INTO Product (Name)
VALUES ('tire'), ('table'), ('wheel')

CREATE TABLE Category
(
	Id int IDENTITY(1, 1) PRIMARY KEY,
	Name VARCHAR(30)
)

INSERT INTO Category (Name)
VALUES ('wood'), ('rubber'), ('square')

CREATE TABLE Link
(
	ProductId int FOREIGN KEY REFERENCES Product(Id),
	CategoryId int FOREIGN KEY REFERENCES Category(Id)
)

INSERT INTO Link (ProductId, CategoryId)
VALUES (1, 2), (2, 1), (2, 3)


select prod.name, cat.name
from Product prod
left join Link link
on prod.Id = link.ProductId
left join Category cat
on link.CategoryId = cat.Id
