Use [DbParcial1-WalderReyes]
Go
CREATE DATABASE [DbParcial-WalderReyes];
go 
USE [DbParcial1-WalderReyes]
GO
CREATE TABLE Inventarios(
	IdInventario int PRIMARY KEY IDENTITY(1,1),
	Total real NOT NULL
 )
CREATE TABLE [dbo].[Productos](
	[ProductoId] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [nvarchar](max) NULL,
	[Existencia] [int] NOT NULL,
	[Costo] [real] NOT NULL,
	[ValorInventario] [real] NOT NULL,
 CONSTRAINT [PK_dbo.Productos] PRIMARY KEY CLUSTERED 
)

 
 insert into Inventarios values(0);
 Select * from Inventarios;
 Select * from Productos;


