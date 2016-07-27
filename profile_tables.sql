USE [epicodex]
GO
/****** Object:  Table [dbo].[comfortlvls]    Script Date: 7/27/2016 2:22:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[comfortlvls](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[lvl] [varchar](255) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[comments]    Script Date: 7/27/2016 2:22:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[comments](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[comment_body] [text] NULL,
	[message_Id] [int] NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[hobbies]    Script Date: 7/27/2016 2:22:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[hobbies](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](255) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[languages]    Script Date: 7/27/2016 2:22:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[languages](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](255) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[messages_posts]    Script Date: 7/27/2016 2:22:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[messages_posts](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[title] [varchar](255) NULL,
	[body] [text] NULL,
	[type_id] [int] NULL,
	[timestamp] [datetime] NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[messages_subhobbies]    Script Date: 7/27/2016 2:22:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[messages_subhobbies](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[message_id] [int] NULL,
	[subhobby_id] [int] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[messages_types]    Script Date: 7/27/2016 2:22:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[messages_types](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](255) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[profile_subhobby]    Script Date: 7/27/2016 2:22:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[profile_subhobby](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[profile_id] [int] NULL,
	[subhobby_id] [int] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[profiles]    Script Date: 7/27/2016 2:22:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[profiles](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[experience] [int] NULL,
	[style] [int] NULL,
	[enrollment] [int] NULL,
	[portland] [int] NULL,
	[home] [varchar](255) NULL,
	[github] [varchar](255) NULL,
	[linkedin] [varchar](255) NULL,
	[email] [varchar](255) NULL,
	[ei] [bit] NULL,
	[ns] [bit] NULL,
	[tf] [bit] NULL,
	[pj] [bit] NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[styles]    Script Date: 7/27/2016 2:22:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[styles](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](255) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[subhobbies]    Script Date: 7/27/2016 2:22:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[subhobbies](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](255) NULL,
	[hobby_id] [int] NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[comfortlvls] ON 

INSERT [dbo].[comfortlvls] ([id], [lvl]) VALUES (1, N'beginner')
INSERT [dbo].[comfortlvls] ([id], [lvl]) VALUES (2, N'intermediate')
INSERT [dbo].[comfortlvls] ([id], [lvl]) VALUES (3, N'advanced')
SET IDENTITY_INSERT [dbo].[comfortlvls] OFF
SET IDENTITY_INSERT [dbo].[hobbies] ON 

INSERT [dbo].[hobbies] ([id], [name]) VALUES (1, N'games')
INSERT [dbo].[hobbies] ([id], [name]) VALUES (2, N'movies')
INSERT [dbo].[hobbies] ([id], [name]) VALUES (3, N'pets')
SET IDENTITY_INSERT [dbo].[hobbies] OFF
SET IDENTITY_INSERT [dbo].[languages] ON 

INSERT [dbo].[languages] ([id], [name]) VALUES (1, N'intro')
INSERT [dbo].[languages] ([id], [name]) VALUES (2, N'ruby')
INSERT [dbo].[languages] ([id], [name]) VALUES (3, N'php')
INSERT [dbo].[languages] ([id], [name]) VALUES (4, N'java')
INSERT [dbo].[languages] ([id], [name]) VALUES (5, N'csharp')
INSERT [dbo].[languages] ([id], [name]) VALUES (6, N'javascript')
INSERT [dbo].[languages] ([id], [name]) VALUES (7, N'css')
INSERT [dbo].[languages] ([id], [name]) VALUES (8, N'design')
INSERT [dbo].[languages] ([id], [name]) VALUES (9, N'rails')
INSERT [dbo].[languages] ([id], [name]) VALUES (10, N'drupal')
INSERT [dbo].[languages] ([id], [name]) VALUES (11, N'android')
INSERT [dbo].[languages] ([id], [name]) VALUES (12, N'net')
SET IDENTITY_INSERT [dbo].[languages] OFF
SET IDENTITY_INSERT [dbo].[profiles] ON 

INSERT [dbo].[profiles] ([id], [experience], [style], [enrollment], [portland], [home], [github], [linkedin], [email], [ei], [ns], [tf], [pj]) VALUES (1, 2, 2, 5, 1, N'Cleveland', N'paul', N'paul', N'paulblart@gmail.com', 1, 0, 0, 1)
INSERT [dbo].[profiles] ([id], [experience], [style], [enrollment], [portland], [home], [github], [linkedin], [email], [ei], [ns], [tf], [pj]) VALUES (2, 2, 2, 5, 2, N'Boston', N'missy', N'missy', N'missy@gmail.com', 1, 0, 0, 0)
INSERT [dbo].[profiles] ([id], [experience], [style], [enrollment], [portland], [home], [github], [linkedin], [email], [ei], [ns], [tf], [pj]) VALUES (3, 1, 3, 5, 2, N'Seattle', N'nancy', N'nancy', N'nancy@gmail.com', 0, 1, 0, 1)
INSERT [dbo].[profiles] ([id], [experience], [style], [enrollment], [portland], [home], [github], [linkedin], [email], [ei], [ns], [tf], [pj]) VALUES (4, 3, 1, 5, 3, N'Eugene', N'elliot', N'elliot', N'elliot@gmail.com', 1, 0, 0, 1)
INSERT [dbo].[profiles] ([id], [experience], [style], [enrollment], [portland], [home], [github], [linkedin], [email], [ei], [ns], [tf], [pj]) VALUES (5, 3, 1, 5, 1, N'Orlando', N'kit', N'kit', N'kit@gmail.com', 1, 0, 0, 0)
INSERT [dbo].[profiles] ([id], [experience], [style], [enrollment], [portland], [home], [github], [linkedin], [email], [ei], [ns], [tf], [pj]) VALUES (6, 1, 1, 5, 1, N'New York City', N'pete', N'pete', N'pete@gmail.com', 0, 1, 0, 1)
INSERT [dbo].[profiles] ([id], [experience], [style], [enrollment], [portland], [home], [github], [linkedin], [email], [ei], [ns], [tf], [pj]) VALUES (7, 1, 2, 5, 4, N'Portland', N'sam', N'sam', N'sam@gmail.com', 1, 0, 0, 0)
INSERT [dbo].[profiles] ([id], [experience], [style], [enrollment], [portland], [home], [github], [linkedin], [email], [ei], [ns], [tf], [pj]) VALUES (8, 2, 1, 5, 4, N'Portland', N'mae', N'mae', N'mae@gmail.com', 0, 1, 1, 1)
INSERT [dbo].[profiles] ([id], [experience], [style], [enrollment], [portland], [home], [github], [linkedin], [email], [ei], [ns], [tf], [pj]) VALUES (9, 3, 1, 6, 2, N'Helena', N'kate', N'kate', N'kate@gmail.com', 0, 0, 0, 0)
INSERT [dbo].[profiles] ([id], [experience], [style], [enrollment], [portland], [home], [github], [linkedin], [email], [ei], [ns], [tf], [pj]) VALUES (10, 2, 2, 6, 2, N'Tampa', N'pat', N'pat', N'pat@gmail.com', 1, 1, 1, 1)
INSERT [dbo].[profiles] ([id], [experience], [style], [enrollment], [portland], [home], [github], [linkedin], [email], [ei], [ns], [tf], [pj]) VALUES (11, 2, 2, 5, 1, N'Columbus', N'phil', N'phil', N'phil@gmail.com', 1, 0, 0, 1)
INSERT [dbo].[profiles] ([id], [experience], [style], [enrollment], [portland], [home], [github], [linkedin], [email], [ei], [ns], [tf], [pj]) VALUES (12, 2, 2, 5, 1, N'Houston', N'tim', N'tim', N'tim@gmail.com', 1, 0, 0, 1)
INSERT [dbo].[profiles] ([id], [experience], [style], [enrollment], [portland], [home], [github], [linkedin], [email], [ei], [ns], [tf], [pj]) VALUES (13, 2, 2, 5, 1, N'Calgary', N'bethany', N'bethany', N'bethany@gmail.com', 1, 1, 1, 1)
INSERT [dbo].[profiles] ([id], [experience], [style], [enrollment], [portland], [home], [github], [linkedin], [email], [ei], [ns], [tf], [pj]) VALUES (14, 3, 1, 6, 2, N'Garden View', N'allen', N'allen', N'allen@gmail.com', 0, 0, 0, 0)
INSERT [dbo].[profiles] ([id], [experience], [style], [enrollment], [portland], [home], [github], [linkedin], [email], [ei], [ns], [tf], [pj]) VALUES (15, 2, 2, 6, 2, N'Chicago', N'yeardly', N'yeardly', N'pat@gmail.com', 1, 0, 0, 1)
SET IDENTITY_INSERT [dbo].[profiles] OFF
SET IDENTITY_INSERT [dbo].[styles] ON 

INSERT [dbo].[styles] ([id], [name]) VALUES (1, N'audio')
INSERT [dbo].[styles] ([id], [name]) VALUES (2, N'visual')
SET IDENTITY_INSERT [dbo].[styles] OFF
SET IDENTITY_INSERT [dbo].[subhobbies] ON 

INSERT [dbo].[subhobbies] ([id], [name], [hobby_id]) VALUES (1, N'tabletop', 1)
INSERT [dbo].[subhobbies] ([id], [name], [hobby_id]) VALUES (2, N'video', 1)
INSERT [dbo].[subhobbies] ([id], [name], [hobby_id]) VALUES (3, N'playingcard', 1)
INSERT [dbo].[subhobbies] ([id], [name], [hobby_id]) VALUES (4, N'mobile', 1)
INSERT [dbo].[subhobbies] ([id], [name], [hobby_id]) VALUES (7, N'action', 2)
INSERT [dbo].[subhobbies] ([id], [name], [hobby_id]) VALUES (8, N'drama', 2)
INSERT [dbo].[subhobbies] ([id], [name], [hobby_id]) VALUES (9, N'comedy', 2)
INSERT [dbo].[subhobbies] ([id], [name], [hobby_id]) VALUES (10, N'documentary', 2)
INSERT [dbo].[subhobbies] ([id], [name], [hobby_id]) VALUES (11, N'dog', 3)
INSERT [dbo].[subhobbies] ([id], [name], [hobby_id]) VALUES (12, N'cat', 3)
INSERT [dbo].[subhobbies] ([id], [name], [hobby_id]) VALUES (13, N'reptile', 3)
INSERT [dbo].[subhobbies] ([id], [name], [hobby_id]) VALUES (14, N'rodent', 3)
INSERT [dbo].[subhobbies] ([id], [name], [hobby_id]) VALUES (15, N'bird', 3)
INSERT [dbo].[subhobbies] ([id], [name], [hobby_id]) VALUES (16, N'other', 3)
SET IDENTITY_INSERT [dbo].[subhobbies] OFF
