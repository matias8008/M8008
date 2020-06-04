USE [master]
GO
/****** Object:  Database [ProyectV1]    Script Date: 01/06/2020 0:54:36 ******/
CREATE DATABASE [ProyectV1]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'ProyectV1', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.ROOT\MSSQL\DATA\ProyectV1.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'ProyectV1_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.ROOT\MSSQL\DATA\ProyectV1_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [ProyectV1] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ProyectV1].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [ProyectV1] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [ProyectV1] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [ProyectV1] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [ProyectV1] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [ProyectV1] SET ARITHABORT OFF 
GO
ALTER DATABASE [ProyectV1] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [ProyectV1] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [ProyectV1] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [ProyectV1] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [ProyectV1] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [ProyectV1] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [ProyectV1] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [ProyectV1] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [ProyectV1] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [ProyectV1] SET  ENABLE_BROKER 
GO
ALTER DATABASE [ProyectV1] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [ProyectV1] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [ProyectV1] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [ProyectV1] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [ProyectV1] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [ProyectV1] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [ProyectV1] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [ProyectV1] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [ProyectV1] SET  MULTI_USER 
GO
ALTER DATABASE [ProyectV1] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [ProyectV1] SET DB_CHAINING OFF 
GO
ALTER DATABASE [ProyectV1] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [ProyectV1] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [ProyectV1] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'ProyectV1', N'ON'
GO
ALTER DATABASE [ProyectV1] SET QUERY_STORE = OFF
GO
USE [ProyectV1]
GO
/****** Object:  Table [dbo].[Categories]    Script Date: 01/06/2020 0:54:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categories](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[CategoryName] [varchar](1) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Clients]    Script Date: 01/06/2020 0:54:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Clients](
	[ClientCode] [int] NOT NULL,
	[ClientName] [varchar](50) NOT NULL,
	[ClientContactLastName] [varchar](50) NULL,
	[ClientContactFirstName] [varchar](50) NULL,
	[Telephone] [varchar](50) NOT NULL,
	[ClientAddress1] [varchar](50) NOT NULL,
	[ClientEmail] [varchar](50) NOT NULL,
	[ClientCity] [varchar](50) NOT NULL,
	[ClientZone] [varchar](50) NULL,
	[ClientCountry] [varchar](50) NULL,
	[ClientPostCode] [varchar](10) NULL,
	[ClientEmployeeSalesRep] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ClientCode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Employee]    Script Date: 01/06/2020 0:54:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employee](
	[IdEmployee] [varchar](11) NOT NULL,
	[Id_Person] [int] NOT NULL,
	[SystemInDate] [date] NULL,
	[FirstDayEmployed] [date] NULL,
	[Category] [varchar](15) NULL,
	[Departament] [varchar](15) NULL,
 CONSTRAINT [PK_Employee] PRIMARY KEY CLUSTERED 
(
	[IdEmployee] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OrderDetails]    Script Date: 01/06/2020 0:54:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrderDetails](
	[OrderID] [int] NOT NULL,
	[ProductCode] [varchar](15) NOT NULL,
	[Quantity] [int] NOT NULL,
	[UnitPrice] [decimal](15, 2) NOT NULL,
	[LineNumber] [smallint] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[OrderID] ASC,
	[ProductCode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Orders]    Script Date: 01/06/2020 0:54:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Orders](
	[OrderID] [int] NOT NULL,
	[OrderDate] [date] NOT NULL,
	[OrderArranged] [date] NOT NULL,
	[OrderDelivered] [date] NOT NULL,
	[OrderStatus] [varchar](20) NOT NULL,
	[OrderComments] [text] NULL,
	[ClientCode] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[OrderID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Payments]    Script Date: 01/06/2020 0:54:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Payments](
	[ClientCode] [int] NOT NULL,
	[PayType] [varchar](40) NOT NULL,
	[IDTransaction] [varchar](50) NOT NULL,
	[PayDate] [date] NOT NULL,
	[PayQuantity] [decimal](15, 2) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ClientCode] ASC,
	[IDTransaction] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Person]    Script Date: 01/06/2020 0:54:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Person](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Id_Personal] [varchar](15) NOT NULL,
	[LastName] [varchar](60) NOT NULL,
	[FirstName] [varchar](60) NOT NULL,
	[Gender] [char](1) NOT NULL,
	[PAddress] [varchar](100) NULL,
	[DateOfBirth] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Products]    Script Date: 01/06/2020 0:54:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Products](
	[ProductCode] [varchar](15) NOT NULL,
	[ProductName] [varchar](70) NOT NULL,
	[Dimentions] [varchar](25) NULL,
	[ProductProvider] [varchar](50) NULL,
	[ProductDescription] [text] NULL,
	[Stock] [int] NULL,
	[SalePrice] [decimal](15, 2) NOT NULL,
	[BuyPrice] [decimal](15, 2) NOT NULL,
	[Categorie] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ProductCode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 01/06/2020 0:54:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[UserName] [varchar](20) NULL,
	[SecretKey] [varchar](15) NULL
) ON [PRIMARY]
GO
INSERT [dbo].[Employee] ([IdEmployee], [Id_Person], [SystemInDate], [FirstDayEmployed], [Category], [Departament]) VALUES (N'1', 1001, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[Employee] ([IdEmployee], [Id_Person], [SystemInDate], [FirstDayEmployed], [Category], [Departament]) VALUES (N'EstLai', 1017, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[Employee] ([IdEmployee], [Id_Person], [SystemInDate], [FirstDayEmployed], [Category], [Departament]) VALUES (N'JavPer', 1002, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[Employee] ([IdEmployee], [Id_Person], [SystemInDate], [FirstDayEmployed], [Category], [Departament]) VALUES (N'JavPer799', 1022, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[Employee] ([IdEmployee], [Id_Person], [SystemInDate], [FirstDayEmployed], [Category], [Departament]) VALUES (N'MarRod', 1018, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[Employee] ([IdEmployee], [Id_Person], [SystemInDate], [FirstDayEmployed], [Category], [Departament]) VALUES (N'MatJav669', 1023, CAST(N'2020-05-29' AS Date), NULL, NULL, NULL)
GO
SET IDENTITY_INSERT [dbo].[Person] ON 
GO
INSERT [dbo].[Person] ([ID], [Id_Personal], [LastName], [FirstName], [Gender], [PAddress], [DateOfBirth]) VALUES (1, N'12345', N'Javega', N'Matias', N'M', N'29 East Street', CAST(N'1990-07-08' AS Date))
GO
INSERT [dbo].[Person] ([ID], [Id_Personal], [LastName], [FirstName], [Gender], [PAddress], [DateOfBirth]) VALUES (1001, N'1111', N'Perez', N'Javier', N'M', N'30 Church Road', CAST(N'1990-03-01' AS Date))
GO
INSERT [dbo].[Person] ([ID], [Id_Personal], [LastName], [FirstName], [Gender], [PAddress], [DateOfBirth]) VALUES (1002, N'123456p', N'Peroni', N'Javier', N'M', N'456 street', CAST(N'2020-05-01' AS Date))
GO
INSERT [dbo].[Person] ([ID], [Id_Personal], [LastName], [FirstName], [Gender], [PAddress], [DateOfBirth]) VALUES (1003, N'1234565', N'Peroni', N'Javier', N'M', N'456 street', CAST(N'2020-05-01' AS Date))
GO
INSERT [dbo].[Person] ([ID], [Id_Personal], [LastName], [FirstName], [Gender], [PAddress], [DateOfBirth]) VALUES (1004, N'12345888', N'Peri', N'Javier', N'M', N'78 street', CAST(N'2020-05-01' AS Date))
GO
INSERT [dbo].[Person] ([ID], [Id_Personal], [LastName], [FirstName], [Gender], [PAddress], [DateOfBirth]) VALUES (1005, N'12345wer', N'peri', N'jav', N'M', N'12 street', CAST(N'2020-05-01' AS Date))
GO
INSERT [dbo].[Person] ([ID], [Id_Personal], [LastName], [FirstName], [Gender], [PAddress], [DateOfBirth]) VALUES (1006, N'789456', N'Per', N'Jav', N'M', N'34 street', CAST(N'2020-04-30' AS Date))
GO
INSERT [dbo].[Person] ([ID], [Id_Personal], [LastName], [FirstName], [Gender], [PAddress], [DateOfBirth]) VALUES (1007, N'987654', N'Per', N'Jav', N'M', N'', CAST(N'2020-04-30' AS Date))
GO
INSERT [dbo].[Person] ([ID], [Id_Personal], [LastName], [FirstName], [Gender], [PAddress], [DateOfBirth]) VALUES (1008, N'951984', N'Per', N'Jav', N'M', N'45 street', CAST(N'2020-05-06' AS Date))
GO
INSERT [dbo].[Person] ([ID], [Id_Personal], [LastName], [FirstName], [Gender], [PAddress], [DateOfBirth]) VALUES (1009, N'777888', N'Per', N'Jav', N'M', N'12 fereee', CAST(N'1990-01-31' AS Date))
GO
INSERT [dbo].[Person] ([ID], [Id_Personal], [LastName], [FirstName], [Gender], [PAddress], [DateOfBirth]) VALUES (1010, N'123sdfsd', N'Per', N'Jav', N'M', N'34 street', CAST(N'1998-12-29' AS Date))
GO
INSERT [dbo].[Person] ([ID], [Id_Personal], [LastName], [FirstName], [Gender], [PAddress], [DateOfBirth]) VALUES (1011, N'54689s', N'Per', N'Jav', N'M', N'65 street', CAST(N'1999-05-19' AS Date))
GO
INSERT [dbo].[Person] ([ID], [Id_Personal], [LastName], [FirstName], [Gender], [PAddress], [DateOfBirth]) VALUES (1012, N'12312r', N'Per', N'Jav', N'M', N'23 street', CAST(N'2020-05-15' AS Date))
GO
INSERT [dbo].[Person] ([ID], [Id_Personal], [LastName], [FirstName], [Gender], [PAddress], [DateOfBirth]) VALUES (1013, N'45678p', N'Per', N'Jav', N'M', N'56 street', CAST(N'2020-04-29' AS Date))
GO
INSERT [dbo].[Person] ([ID], [Id_Personal], [LastName], [FirstName], [Gender], [PAddress], [DateOfBirth]) VALUES (1014, N'456789u', N'Per', N'Jav', N'M', N'123 street', CAST(N'2020-05-05' AS Date))
GO
INSERT [dbo].[Person] ([ID], [Id_Personal], [LastName], [FirstName], [Gender], [PAddress], [DateOfBirth]) VALUES (1015, N'123A', N'Per', N'Jav', N'M', N'12 street', CAST(N'2020-05-19' AS Date))
GO
INSERT [dbo].[Person] ([ID], [Id_Personal], [LastName], [FirstName], [Gender], [PAddress], [DateOfBirth]) VALUES (1016, N'123q', N'Per', N'Jav', N'M', N'fsdf', CAST(N'2020-01-29' AS Date))
GO
INSERT [dbo].[Person] ([ID], [Id_Personal], [LastName], [FirstName], [Gender], [PAddress], [DateOfBirth]) VALUES (1017, N'345gf', N'Lainez', N'Esteban', N'M', N'12 street', CAST(N'2020-05-20' AS Date))
GO
INSERT [dbo].[Person] ([ID], [Id_Personal], [LastName], [FirstName], [Gender], [PAddress], [DateOfBirth]) VALUES (1018, N'456EE', N'Rodriguez', N'Marcela', N'F', N'56 North road', CAST(N'2000-02-16' AS Date))
GO
INSERT [dbo].[Person] ([ID], [Id_Personal], [LastName], [FirstName], [Gender], [PAddress], [DateOfBirth]) VALUES (1019, N'456EEP', N'Rodriguez', N'Marcela', N'F', N'56 North road', CAST(N'2000-02-16' AS Date))
GO
INSERT [dbo].[Person] ([ID], [Id_Personal], [LastName], [FirstName], [Gender], [PAddress], [DateOfBirth]) VALUES (1020, N'9090L', N'Per', N'Jav', N'M', N'123 road', CAST(N'2005-01-01' AS Date))
GO
INSERT [dbo].[Person] ([ID], [Id_Personal], [LastName], [FirstName], [Gender], [PAddress], [DateOfBirth]) VALUES (1021, N'123789R', N'Per', N'Jav', N'M', N'78 first road', CAST(N'1990-02-07' AS Date))
GO
INSERT [dbo].[Person] ([ID], [Id_Personal], [LastName], [FirstName], [Gender], [PAddress], [DateOfBirth]) VALUES (1022, N'679876876R', N'Per', N'Jav', N'M', N'45 road', CAST(N'1994-06-16' AS Date))
GO
INSERT [dbo].[Person] ([ID], [Id_Personal], [LastName], [FirstName], [Gender], [PAddress], [DateOfBirth]) VALUES (1023, N'365256T', N'Javega', N'Matilde', N'F', N'45 Street', CAST(N'1979-02-08' AS Date))
GO
SET IDENTITY_INSERT [dbo].[Person] OFF
GO
INSERT [dbo].[Products] ([ProductCode], [ProductName], [Dimentions], [ProductProvider], [ProductDescription], [Stock], [SalePrice], [BuyPrice], [Categorie]) VALUES (N'123', N'Cola drink', N'', N'Cola Company', N'R', 36, CAST(2.00 AS Decimal(15, 2)), CAST(1.00 AS Decimal(15, 2)), 1)
GO
INSERT [dbo].[Products] ([ProductCode], [ProductName], [Dimentions], [ProductProvider], [ProductDescription], [Stock], [SalePrice], [BuyPrice], [Categorie]) VALUES (N'12345', N'a', N'as', N'as', N'a', 1, CAST(1.00 AS Decimal(15, 2)), CAST(1.00 AS Decimal(15, 2)), 1)
GO
INSERT [dbo].[Products] ([ProductCode], [ProductName], [Dimentions], [ProductProvider], [ProductDescription], [Stock], [SalePrice], [BuyPrice], [Categorie]) VALUES (N'2', N'Orange Juice Acme', N'1 Litre', N'Acme', N'O', 90, CAST(3.00 AS Decimal(15, 2)), CAST(1.00 AS Decimal(15, 2)), 1)
GO
INSERT [dbo].[Users] ([UserName], [SecretKey]) VALUES (N'12345', N'12345')
GO
/****** Object:  Index [I_Clients_Employee_FK]    Script Date: 01/06/2020 0:54:37 ******/
CREATE NONCLUSTERED INDEX [I_Clients_Employee_FK] ON [dbo].[Clients]
(
	[ClientEmployeeSalesRep] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [I_OrderDetails_ProductCode]    Script Date: 01/06/2020 0:54:37 ******/
CREATE NONCLUSTERED INDEX [I_OrderDetails_ProductCode] ON [dbo].[OrderDetails]
(
	[ProductCode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [I_Client_Order]    Script Date: 01/06/2020 0:54:37 ******/
CREATE NONCLUSTERED INDEX [I_Client_Order] ON [dbo].[Orders]
(
	[ClientCode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Clients]  WITH CHECK ADD  CONSTRAINT [Clients_Employee_FK] FOREIGN KEY([ClientEmployeeSalesRep])
REFERENCES [dbo].[Person] ([ID])
GO
ALTER TABLE [dbo].[Clients] CHECK CONSTRAINT [Clients_Employee_FK]
GO
ALTER TABLE [dbo].[Employee]  WITH CHECK ADD  CONSTRAINT [FK_IdPersonal] FOREIGN KEY([Id_Person])
REFERENCES [dbo].[Person] ([ID])
GO
ALTER TABLE [dbo].[Employee] CHECK CONSTRAINT [FK_IdPersonal]
GO
ALTER TABLE [dbo].[OrderDetails]  WITH CHECK ADD  CONSTRAINT [OrderDetails_OrderID] FOREIGN KEY([OrderID])
REFERENCES [dbo].[Orders] ([OrderID])
GO
ALTER TABLE [dbo].[OrderDetails] CHECK CONSTRAINT [OrderDetails_OrderID]
GO
ALTER TABLE [dbo].[OrderDetails]  WITH CHECK ADD  CONSTRAINT [ProductCode_ProductCode] FOREIGN KEY([ProductCode])
REFERENCES [dbo].[Products] ([ProductCode])
GO
ALTER TABLE [dbo].[OrderDetails] CHECK CONSTRAINT [ProductCode_ProductCode]
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD  CONSTRAINT [Client_Order] FOREIGN KEY([ClientCode])
REFERENCES [dbo].[Clients] ([ClientCode])
GO
ALTER TABLE [dbo].[Orders] CHECK CONSTRAINT [Client_Order]
GO
ALTER TABLE [dbo].[Payments]  WITH CHECK ADD  CONSTRAINT [Payments_ClientsFK] FOREIGN KEY([ClientCode])
REFERENCES [dbo].[Clients] ([ClientCode])
GO
ALTER TABLE [dbo].[Payments] CHECK CONSTRAINT [Payments_ClientsFK]
GO
/****** Object:  StoredProcedure [dbo].[Register_Person]    Script Date: 01/06/2020 0:54:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[Register_Person](
	@Id_Personal VARCHAR(15),
	@LastName VARCHAR(60),
	@FirstName VARCHAR(60),
	@Gender CHAR(1),
	@PAddress VARCHAR(100),
	@DateOfBirth DATETIME,
	@Message VARCHAR(100) OUT
)
AS
	BEGIN
		IF(EXISTS(SELECT * FROM Person WHERE Id_Personal=@Id_Personal))
		SET @Message='This Personal ID already exists'
		ELSE
			BEGIN
			INSERT Person VALUES(@Id_Personal,@LastName,@FirstName,@Gender,@PAddress,@DateOfBirth)
			SET @Message='User stored'
			END
	END
GO
/****** Object:  StoredProcedure [dbo].[Register_Person_Employee]    Script Date: 01/06/2020 0:54:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[Register_Person_Employee](
	@Id_Personal VARCHAR(15),
	@LastName VARCHAR(60),
	@FirstName VARCHAR(60),
	@Gender CHAR(1),
	@PAddress VARCHAR(100),
	@DateOfBirth DATETIME,
	@Id_Employee VARCHAR(11),
	@SystemInDate DATETIME,
	@Message VARCHAR(100) OUT
	
)
AS
	BEGIN
		IF(EXISTS(SELECT * FROM Person WHERE Id_Personal=@Id_Personal))
		SET @Message='This Personal ID already exists'
		ELSE
		IF(EXISTS(SELECT * FROM Employee WHERE IdEmployee=@Id_Employee))
		SET @Id_Employee = @Id_Employee+'1'
		ELSE
			BEGIN
			INSERT Person VALUES(@Id_Personal,@LastName,@FirstName,@Gender,@PAddress,@DateOfBirth);

			INSERT Employee (IdEmployee, Id_Person, SystemInDate) VALUES(@Id_Employee,(SELECT MAX(ID) FROM Person), @SystemInDate);
			SET @Message='User stored'
			END
	END
GO
/****** Object:  StoredProcedure [dbo].[Register_Products]    Script Date: 01/06/2020 0:54:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[Register_Products](
	@ProductCode VARCHAR (15),
	@ProductName VARCHAR (70),
	@Dimentions VARCHAR (25),
	@ProductProvider VARCHAR (50),
	@ProductDescription VARCHAR,
	@Stock INT,
	@SalePrice DECIMAL(15,2),
	@BuyPrice DECIMAL(15,2),
	@categorie INT,
	@Message VARCHAR(100) OUT
)
AS
	BEGIN
		IF(EXISTS(SELECT * FROM Products WHERE ProductCode = @ProductCode))
		SET @Message='This Personal ID already exists'
		ELSE
			BEGIN
				INSERT Products VALUES (@ProductCode,@ProductName,@Dimentions,
				@ProductProvider,@ProductDescription,@Stock,@SalePrice,@BuyPrice,@categorie)
				SET @Message='Product stored'
			END
	END
GO
/****** Object:  StoredProcedure [dbo].[Search_Employee]    Script Date: 01/06/2020 0:54:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[Search_Employee](
	@newQuery VARCHAR (50)
)
AS
	SELECT * FROM Employee e INNER JOIN Person p
	ON e.Id_Person-1 = p.ID
	WHERE e.IdEmployee = @newQuery OR
	p.FirstName = @newQuery OR
	p.LastName = @newQuery
GO
/****** Object:  StoredProcedure [dbo].[Show_Employee]    Script Date: 01/06/2020 0:54:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[Show_Employee]
AS
	SELECT P.Id_Personal, P.FirstName, P.LastName, e.* FROM Person p RIGHT JOIN Employee e ON p.ID = E.Id_Person
GO
/****** Object:  StoredProcedure [dbo].[Show_Person]    Script Date: 01/06/2020 0:54:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[Show_Person]
AS
	SELECT * FROM Person
GO
/****** Object:  StoredProcedure [dbo].[Show_Products]    Script Date: 01/06/2020 0:54:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[Show_Products]
AS 
	SELECT * FROM Products
GO
USE [master]
GO
ALTER DATABASE [ProyectV1] SET  READ_WRITE 
GO
