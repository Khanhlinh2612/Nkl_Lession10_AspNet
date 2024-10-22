USE [ThpK22CNT3Lession10Db]
GO
/****** Object:  Table [dbo].[ThpAccount]    Script Date: 7/3/2024 9:14:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ThpAccount](
	[ThpID] [int] NOT NULL,
	[ThpUserName] [nvarchar](50) NULL,
	[ThpPassword] [nvarchar](50) NULL,
	[ThpFullName] [nvarchar](50) NULL,
	[ThpEmail] [nvarchar](50) NULL,
	[ThpPhone] [nvarchar](50) NULL,
	[ThpActive] [bit] NULL,
 CONSTRAINT [PK_ThpAccount] PRIMARY KEY CLUSTERED 
(
	[ThpID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[ThpAccount] ([ThpID], [ThpUserName], [ThpPassword], [ThpFullName], [ThpEmail], [ThpPhone], [ThpActive]) VALUES (1, N'Phuc', N'123456', N'Trinh Huu Phuc', N'toiduaroima@gmail.com', N'123456789', 1)
INSERT [dbo].[ThpAccount] ([ThpID], [ThpUserName], [ThpPassword], [ThpFullName], [ThpEmail], [ThpPhone], [ThpActive]) VALUES (2, N'Linh', N'654321', N'Nguyen Khanh Linh', N'a@gmail.com', N'987654321', 1)
GO
