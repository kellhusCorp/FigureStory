IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA= 'DBO' AND TABLE_NAME='PRODUCTS')
BEGIN
	CREATE TABLE Products (
		Id int PRIMARY KEY IDENTITY,
		Name nvarchar(max)
	)

	insert into Products (Name) values
	('Продукт №1'),
	('Продукт №2'),
	('Продукт №3'),
	('Продукт №4'),
	('Продукт №5'),
	('Продукт №6'),
	('Продукт №7'),
	('Продукт №8'),
	('Продукт №9'),
	('Продукт №10')
END