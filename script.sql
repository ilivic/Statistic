USE [StatisticDataBase]
GO
/****** Object:  Table [dbo].[Meters]    Script Date: 24.11.2024 12:22:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Meters](
	[Id_Meters] [int] IDENTITY(1,1) NOT NULL,
	[Title] [varchar](max) NOT NULL,
	[Type_id] [int] NULL,
	[OBJ_id] [int] NOT NULL,
	[Price] [money] NULL,
 CONSTRAINT [PK_Meters] PRIMARY KEY CLUSTERED 
(
	[Id_Meters] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OBJ]    Script Date: 24.11.2024 12:22:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OBJ](
	[Id_OBJ] [int] IDENTITY(1,1) NOT NULL,
	[Title] [varchar](max) NOT NULL,
	[Adress] [varchar](max) NOT NULL,
	[User_id] [int] NOT NULL,
	[DataAdd] [date] NOT NULL,
	[Period_id] [int] NOT NULL,
 CONSTRAINT [PK_OBJ] PRIMARY KEY CLUSTERED 
(
	[Id_OBJ] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Periods]    Script Date: 24.11.2024 12:22:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Periods](
	[Id_period] [int] NOT NULL,
	[Title] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Periods] PRIMARY KEY CLUSTERED 
(
	[Id_period] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PeriodsRead]    Script Date: 24.11.2024 12:22:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PeriodsRead](
	[Id_PR] [int] IDENTITY(1,1) NOT NULL,
	[id_periods] [int] NOT NULL,
	[DateP] [date] NOT NULL,
	[id_obj] [int] NOT NULL,
 CONSTRAINT [PK_PeriodsRead] PRIMARY KEY CLUSTERED 
(
	[Id_PR] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ReadMeters]    Script Date: 24.11.2024 12:22:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ReadMeters](
	[Id_RM] [int] IDENTITY(1,1) NOT NULL,
	[Count] [nchar](10) NOT NULL,
	[PR_id] [int] NOT NULL,
	[Meters_id] [int] NOT NULL,
 CONSTRAINT [PK_ReadMeters] PRIMARY KEY CLUSTERED 
(
	[Id_RM] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Recommendations]    Script Date: 24.11.2024 12:22:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Recommendations](
	[Id_recomendations] [int] IDENTITY(1,1) NOT NULL,
	[PR_id] [int] NOT NULL,
	[typeRecom_id] [int] NULL,
	[Date] [date] NOT NULL,
	[TypeSpecialRecom_id] [int] NULL,
 CONSTRAINT [PK_Recommendations] PRIMARY KEY CLUSTERED 
(
	[Id_recomendations] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TypeMeters]    Script Date: 24.11.2024 12:22:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TypeMeters](
	[Id_TM] [int] IDENTITY(1,1) NOT NULL,
	[Title] [varchar](50) NOT NULL,
	[Info] [text] NULL,
	[Unit] [varchar](50) NOT NULL,
 CONSTRAINT [PK_TypeMeters] PRIMARY KEY CLUSTERED 
(
	[Id_TM] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TypeRecome]    Script Date: 24.11.2024 12:22:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TypeRecome](
	[Id_TypeRecom] [int] IDENTITY(1,1) NOT NULL,
	[Title] [varchar](50) NOT NULL,
	[Info] [text] NOT NULL,
 CONSTRAINT [PK_TypeRecome] PRIMARY KEY CLUSTERED 
(
	[Id_TypeRecom] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TypeSpecialRecom]    Script Date: 24.11.2024 12:22:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TypeSpecialRecom](
	[Id_TypeSpecialRecom] [int] IDENTITY(1,1) NOT NULL,
	[Title] [varchar](50) NOT NULL,
	[diskription] [text] NOT NULL,
	[Price] [money] NOT NULL,
 CONSTRAINT [PK_TypeSpecialRecom] PRIMARY KEY CLUSTERED 
(
	[Id_TypeSpecialRecom] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 24.11.2024 12:22:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[Id_User] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](max) NOT NULL,
	[Photo] [image] NULL,
	[Email] [varchar](max) NULL,
	[Login] [varchar](max) NOT NULL,
	[password] [varchar](max) NOT NULL,
	[Balance] [money] NOT NULL,
	[DateRegist] [date] NOT NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[Id_User] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE [dbo].[Meters]  WITH CHECK ADD  CONSTRAINT [FK_Meters_OBJ] FOREIGN KEY([OBJ_id])
REFERENCES [dbo].[OBJ] ([Id_OBJ])
GO
ALTER TABLE [dbo].[Meters] CHECK CONSTRAINT [FK_Meters_OBJ]
GO
ALTER TABLE [dbo].[Meters]  WITH CHECK ADD  CONSTRAINT [FK_Meters_TypeMeters] FOREIGN KEY([Type_id])
REFERENCES [dbo].[TypeMeters] ([Id_TM])
GO
ALTER TABLE [dbo].[Meters] CHECK CONSTRAINT [FK_Meters_TypeMeters]
GO
ALTER TABLE [dbo].[OBJ]  WITH CHECK ADD  CONSTRAINT [FK_OBJ_Periods] FOREIGN KEY([Period_id])
REFERENCES [dbo].[Periods] ([Id_period])
GO
ALTER TABLE [dbo].[OBJ] CHECK CONSTRAINT [FK_OBJ_Periods]
GO
ALTER TABLE [dbo].[OBJ]  WITH CHECK ADD  CONSTRAINT [FK_OBJ_Users] FOREIGN KEY([User_id])
REFERENCES [dbo].[Users] ([Id_User])
GO
ALTER TABLE [dbo].[OBJ] CHECK CONSTRAINT [FK_OBJ_Users]
GO
ALTER TABLE [dbo].[PeriodsRead]  WITH CHECK ADD  CONSTRAINT [FK_PeriodsRead_OBJ] FOREIGN KEY([id_obj])
REFERENCES [dbo].[OBJ] ([Id_OBJ])
GO
ALTER TABLE [dbo].[PeriodsRead] CHECK CONSTRAINT [FK_PeriodsRead_OBJ]
GO
ALTER TABLE [dbo].[PeriodsRead]  WITH CHECK ADD  CONSTRAINT [FK_PeriodsRead_Periods] FOREIGN KEY([id_periods])
REFERENCES [dbo].[Periods] ([Id_period])
GO
ALTER TABLE [dbo].[PeriodsRead] CHECK CONSTRAINT [FK_PeriodsRead_Periods]
GO
ALTER TABLE [dbo].[ReadMeters]  WITH CHECK ADD  CONSTRAINT [FK_ReadMeters_Meters] FOREIGN KEY([Meters_id])
REFERENCES [dbo].[Meters] ([Id_Meters])
GO
ALTER TABLE [dbo].[ReadMeters] CHECK CONSTRAINT [FK_ReadMeters_Meters]
GO
ALTER TABLE [dbo].[ReadMeters]  WITH CHECK ADD  CONSTRAINT [FK_ReadMeters_PeriodsRead] FOREIGN KEY([PR_id])
REFERENCES [dbo].[PeriodsRead] ([Id_PR])
GO
ALTER TABLE [dbo].[ReadMeters] CHECK CONSTRAINT [FK_ReadMeters_PeriodsRead]
GO
ALTER TABLE [dbo].[Recommendations]  WITH CHECK ADD  CONSTRAINT [FK_Recommendations_PeriodsRead] FOREIGN KEY([PR_id])
REFERENCES [dbo].[PeriodsRead] ([Id_PR])
GO
ALTER TABLE [dbo].[Recommendations] CHECK CONSTRAINT [FK_Recommendations_PeriodsRead]
GO
ALTER TABLE [dbo].[Recommendations]  WITH CHECK ADD  CONSTRAINT [FK_Recommendations_TypeRecome] FOREIGN KEY([typeRecom_id])
REFERENCES [dbo].[TypeRecome] ([Id_TypeRecom])
GO
ALTER TABLE [dbo].[Recommendations] CHECK CONSTRAINT [FK_Recommendations_TypeRecome]
GO
ALTER TABLE [dbo].[Recommendations]  WITH CHECK ADD  CONSTRAINT [FK_Recommendations_TypeSpecialRecom] FOREIGN KEY([TypeSpecialRecom_id])
REFERENCES [dbo].[TypeSpecialRecom] ([Id_TypeSpecialRecom])
GO
ALTER TABLE [dbo].[Recommendations] CHECK CONSTRAINT [FK_Recommendations_TypeSpecialRecom]
GO
