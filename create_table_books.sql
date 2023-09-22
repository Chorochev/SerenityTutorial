CREATE SCHEMA [test]
go

CREATE TABLE [test].[Books](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](128) NOT NULL,
	[Info] [nvarchar](256) NULL,
 CONSTRAINT [PK_test_Books_Id] PRIMARY KEY ([Id]))

GO

INSERT INTO [test].[Books] ([Title], [Info])
VALUES 
(N'Остров сокровищ', N'Приключения про поиск пиратских сокровищ.'),
(N'Мастер и Маргарита', N'Про любовь.'),
(N'Война и Мир', N'Про войну.')

GO
  