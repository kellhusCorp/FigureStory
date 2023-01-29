IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA= 'DBO' AND TABLE_NAME='Categories')
BEGIN
	CREATE TABLE Categories (
		Id int PRIMARY KEY IDENTITY,
		Name nvarchar(max)
	)

	insert into Categories (Name) values
	('Категория №1'),
	('Категория №2'),
	('Категория №3'),
	('Категория №4'),
	('Категория №5'),
	('Категория №6'),
	('Категория №7'),
	('Категория №8'),
	('Категория №9'),
	('Категория №10')
END