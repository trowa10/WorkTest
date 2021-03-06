USE [master]
GO
/****** Object:  Database [CircleCoffee]    Script Date: 7/15/2018 4:58:03 PM ******/
CREATE DATABASE [CircleCoffee]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'CircleCoffee', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\CircleCoffee.mdf' , SIZE = 4096KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'CircleCoffee_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\CircleCoffee_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [CircleCoffee] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [CircleCoffee].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [CircleCoffee] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [CircleCoffee] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [CircleCoffee] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [CircleCoffee] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [CircleCoffee] SET ARITHABORT OFF 
GO
ALTER DATABASE [CircleCoffee] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [CircleCoffee] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [CircleCoffee] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [CircleCoffee] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [CircleCoffee] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [CircleCoffee] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [CircleCoffee] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [CircleCoffee] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [CircleCoffee] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [CircleCoffee] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [CircleCoffee] SET  DISABLE_BROKER 
GO
ALTER DATABASE [CircleCoffee] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [CircleCoffee] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [CircleCoffee] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [CircleCoffee] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [CircleCoffee] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [CircleCoffee] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [CircleCoffee] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [CircleCoffee] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [CircleCoffee] SET  MULTI_USER 
GO
ALTER DATABASE [CircleCoffee] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [CircleCoffee] SET DB_CHAINING OFF 
GO
ALTER DATABASE [CircleCoffee] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [CircleCoffee] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [CircleCoffee]
GO
/****** Object:  Table [dbo].[tblIngredientInventory]    Script Date: 7/15/2018 4:58:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblIngredientInventory](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IngredientName] [nvarchar](50) NOT NULL,
	[TotalUnit] [int] NOT NULL,
 CONSTRAINT [PK_tblIngredientInventory] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblProduct]    Script Date: 7/15/2018 4:58:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblProduct](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ProductName] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_tblProduct] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblProductIngredientUnit]    Script Date: 7/15/2018 4:58:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblProductIngredientUnit](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[ProductId] [int] NULL,
	[IngredientId] [int] NULL,
	[Unit] [int] NOT NULL,
 CONSTRAINT [PK_tblProductIngredientUnit] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[tblIngredientInventory] ON 

INSERT [dbo].[tblIngredientInventory] ([Id], [IngredientName], [TotalUnit]) VALUES (1, N'Coffee Beans', 45)
INSERT [dbo].[tblIngredientInventory] ([Id], [IngredientName], [TotalUnit]) VALUES (2, N'Sugar', 45)
INSERT [dbo].[tblIngredientInventory] ([Id], [IngredientName], [TotalUnit]) VALUES (4, N'Milk', 45)
SET IDENTITY_INSERT [dbo].[tblIngredientInventory] OFF
SET IDENTITY_INSERT [dbo].[tblProduct] ON 

INSERT [dbo].[tblProduct] ([Id], [ProductName]) VALUES (1, N'Double Americano')
INSERT [dbo].[tblProduct] ([Id], [ProductName]) VALUES (2, N'Sweet Latte')
INSERT [dbo].[tblProduct] ([Id], [ProductName]) VALUES (3, N'Flat White')
SET IDENTITY_INSERT [dbo].[tblProduct] OFF
SET IDENTITY_INSERT [dbo].[tblProductIngredientUnit] ON 

INSERT [dbo].[tblProductIngredientUnit] ([id], [ProductId], [IngredientId], [Unit]) VALUES (1, 1, 1, 3)
INSERT [dbo].[tblProductIngredientUnit] ([id], [ProductId], [IngredientId], [Unit]) VALUES (2, 1, 2, 0)
INSERT [dbo].[tblProductIngredientUnit] ([id], [ProductId], [IngredientId], [Unit]) VALUES (3, 1, 4, 0)
INSERT [dbo].[tblProductIngredientUnit] ([id], [ProductId], [IngredientId], [Unit]) VALUES (4, 2, 1, 2)
INSERT [dbo].[tblProductIngredientUnit] ([id], [ProductId], [IngredientId], [Unit]) VALUES (5, 2, 2, 5)
INSERT [dbo].[tblProductIngredientUnit] ([id], [ProductId], [IngredientId], [Unit]) VALUES (6, 2, 4, 0)
INSERT [dbo].[tblProductIngredientUnit] ([id], [ProductId], [IngredientId], [Unit]) VALUES (7, 3, 1, 2)
INSERT [dbo].[tblProductIngredientUnit] ([id], [ProductId], [IngredientId], [Unit]) VALUES (8, 3, 2, 1)
INSERT [dbo].[tblProductIngredientUnit] ([id], [ProductId], [IngredientId], [Unit]) VALUES (9, 3, 4, 4)
SET IDENTITY_INSERT [dbo].[tblProductIngredientUnit] OFF
ALTER TABLE [dbo].[tblProductIngredientUnit]  WITH CHECK ADD  CONSTRAINT [FK_tblProductIngredientUnit_tblIngredientInventory] FOREIGN KEY([IngredientId])
REFERENCES [dbo].[tblIngredientInventory] ([Id])
GO
ALTER TABLE [dbo].[tblProductIngredientUnit] CHECK CONSTRAINT [FK_tblProductIngredientUnit_tblIngredientInventory]
GO
ALTER TABLE [dbo].[tblProductIngredientUnit]  WITH CHECK ADD  CONSTRAINT [FK_tblProductIngredientUnit_tblProduct] FOREIGN KEY([ProductId])
REFERENCES [dbo].[tblProduct] ([Id])
GO
ALTER TABLE [dbo].[tblProductIngredientUnit] CHECK CONSTRAINT [FK_tblProductIngredientUnit_tblProduct]
GO
USE [master]
GO
ALTER DATABASE [CircleCoffee] SET  READ_WRITE 
GO
