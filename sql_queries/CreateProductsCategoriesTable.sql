IF NOT EXISTS(SELECT * from INFORMATION_SCHEMA.TABLES where TABLE_SCHEMA='dbo' and TABLE_NAME='Product_Category')
begin
	CREATE TABLE Products_Categories (
		ProductId int,
		CategoryId int,
		CONSTRAINT Product_Category_Pk PRIMARY KEY (ProductId, CategoryId),
		CONSTRAINT FK_Product
			FOREIGN KEY (ProductId) REFERENCES Products (Id),
		CONSTRAINT FK_Category
			FOREIGN KEY (CategoryId) REFERENCES Categories (Id)
	)

	insert into Products_Categories (ProductId, CategoryId) values
	(1, 1),
	(1, 2),
	(1, 3),
	(1, 4),
	(1, 5),
	(1, 6),
	(1, 7),
	(1, 8),
	(3, 1),
	(3, 2),
	(3, 3),
	(3, 10),
	(4, 2),
	(4, 3),
	(4, 4),
	(5, 1),
	(5, 2),
	(5, 3),
	(5, 6),
	(5, 7),
	(5, 8),
	(5, 9)
end