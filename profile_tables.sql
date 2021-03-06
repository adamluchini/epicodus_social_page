USE [epicodex]
GO
/****** Object:  Table [dbo].[comfortlvls]    Script Date: 7/29/2016 9:42:08 AM ******/
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
/****** Object:  Table [dbo].[comments]    Script Date: 7/29/2016 9:42:08 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[comments](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[comment_body] [text] NULL,
	[message_Id] [int] NULL,
	[profile_id] [int] NULL,
	[total_likes] [int] NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[hobbies]    Script Date: 7/29/2016 9:42:08 AM ******/
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
/****** Object:  Table [dbo].[languages]    Script Date: 7/29/2016 9:42:08 AM ******/
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
/****** Object:  Table [dbo].[messages_posts]    Script Date: 7/29/2016 9:42:08 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[messages_posts](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[body] [text] NULL,
	[profile_id] [int] NULL,
	[timestamp] [datetime] NULL,
	[title] [varchar](255) NULL,
	[type_id] [int] NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[messages_subhobbies]    Script Date: 7/29/2016 9:42:08 AM ******/
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
/****** Object:  Table [dbo].[messages_types]    Script Date: 7/29/2016 9:42:09 AM ******/
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
/****** Object:  Table [dbo].[profile_subhobby]    Script Date: 7/29/2016 9:42:09 AM ******/
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
/****** Object:  Table [dbo].[profiles]    Script Date: 7/29/2016 9:42:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[profiles](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[ei] [bit] NULL,
	[email] [varchar](255) NULL,
	[enrollment] [int] NULL,
	[experience] [int] NULL,
	[github] [varchar](255) NULL,
	[home] [varchar](255) NULL,
	[linkedin] [varchar](255) NULL,
	[name] [varchar](255) NULL,
	[ns] [bit] NULL,
	[pj] [bit] NULL,
	[portland] [int] NULL,
	[style] [int] NULL,
	[tf] [bit] NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[styles]    Script Date: 7/29/2016 9:42:09 AM ******/
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
/****** Object:  Table [dbo].[subhobbies]    Script Date: 7/29/2016 9:42:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[subhobbies](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[hobby_id] [int] NULL,
	[name] [varchar](255) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[comfortlvls] ON 

INSERT [dbo].[comfortlvls] ([id], [lvl]) VALUES (1, N'beginner')
INSERT [dbo].[comfortlvls] ([id], [lvl]) VALUES (2, N'intermediate')
INSERT [dbo].[comfortlvls] ([id], [lvl]) VALUES (3, N'advanced')
SET IDENTITY_INSERT [dbo].[comfortlvls] OFF
SET IDENTITY_INSERT [dbo].[comments] ON 

INSERT [dbo].[comments] ([id], [comment_body], [message_Id], [profile_id], [total_likes]) VALUES (1, N'This is an easy one to fix:  turn off your computer!', 2, 3, 6)
INSERT [dbo].[comments] ([id], [comment_body], [message_Id], [profile_id], [total_likes]) VALUES (2, N'I had the same problem.  I fixed it by reformatting my hard drive.', 2, 3, 1)
SET IDENTITY_INSERT [dbo].[comments] OFF
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
SET IDENTITY_INSERT [dbo].[messages_posts] ON 

INSERT [dbo].[messages_posts] ([id], [body], [profile_id], [timestamp], [title], [type_id]) VALUES (1, N'Today Tony Roma will speak on site design for his rib web site. Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.', 1, CAST(N'2016-07-28T00:00:00.000' AS DateTime), N'Speaker Today', 1)
INSERT [dbo].[messages_posts] ([id], [body], [profile_id], [timestamp], [title], [type_id]) VALUES (2, N'I get the following error:  Object not set to an instance of the object.  Please help!!!!!!! Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.', 2, CAST(N'2016-07-27T00:00:00.000' AS DateTime), N'CS 2088', 2)
INSERT [dbo].[messages_posts] ([id], [body], [profile_id], [timestamp], [title], [type_id]) VALUES (3, N'I''ll be out of town this weekend.  I need to find someone to feed my 27 cats. I sense judging, stop judging. Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.', 3, CAST(N'2016-07-26T00:00:00.000' AS DateTime), N'Cat sitter needed', 4)
INSERT [dbo].[messages_posts] ([id], [body], [profile_id], [timestamp], [title], [type_id]) VALUES (9, N'Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.', 14, CAST(N'2016-07-29T08:22:13.000' AS DateTime), N'Refridgerator Broken', 1)
INSERT [dbo].[messages_posts] ([id], [body], [profile_id], [timestamp], [title], [type_id]) VALUES (10, N'Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.', 24, CAST(N'2016-07-29T09:13:55.000' AS DateTime), N'GitHub servers down??', 2)
INSERT [dbo].[messages_posts] ([id], [body], [profile_id], [timestamp], [title], [type_id]) VALUES (11, N'Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.', 10, CAST(N'2016-07-29T01:45:21.000' AS DateTime), N'Extra keyboard batteries', 2)
INSERT [dbo].[messages_posts] ([id], [body], [profile_id], [timestamp], [title], [type_id]) VALUES (12, N'Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.', 18, CAST(N'2016-07-29T08:22:13.000' AS DateTime), N'Magic the Gathering at lunch today', 4)
INSERT [dbo].[messages_posts] ([id], [body], [profile_id], [timestamp], [title], [type_id]) VALUES (13, N'cool', 1, CAST(N'2016-07-29T09:21:46.593' AS DateTime), N'be cool', 1)
INSERT [dbo].[messages_posts] ([id], [body], [profile_id], [timestamp], [title], [type_id]) VALUES (14, N'cool', 1, CAST(N'2016-07-29T09:27:37.447' AS DateTime), N'be cool', 1)
INSERT [dbo].[messages_posts] ([id], [body], [profile_id], [timestamp], [title], [type_id]) VALUES (15, N'What is everyone doing tonight?', 1, CAST(N'2016-07-29T09:31:47.027' AS DateTime), N'Sup World?', 3)
SET IDENTITY_INSERT [dbo].[messages_posts] OFF
SET IDENTITY_INSERT [dbo].[messages_subhobbies] ON 

INSERT [dbo].[messages_subhobbies] ([id], [message_id], [subhobby_id]) VALUES (1, 3, 12)
SET IDENTITY_INSERT [dbo].[messages_subhobbies] OFF
SET IDENTITY_INSERT [dbo].[messages_types] ON 

INSERT [dbo].[messages_types] ([id], [name]) VALUES (1, N'Announcement')
INSERT [dbo].[messages_types] ([id], [name]) VALUES (2, N'Burning Question and Answer')
INSERT [dbo].[messages_types] ([id], [name]) VALUES (3, N'Off Topic')
INSERT [dbo].[messages_types] ([id], [name]) VALUES (4, N'Hobbies and Pets')
INSERT [dbo].[messages_types] ([id], [name]) VALUES (5, N'Class Resource')
INSERT [dbo].[messages_types] ([id], [name]) VALUES (6, N'Language Resource')
SET IDENTITY_INSERT [dbo].[messages_types] OFF
SET IDENTITY_INSERT [dbo].[profiles] ON 

INSERT [dbo].[profiles] ([id], [ei], [email], [enrollment], [experience], [github], [home], [linkedin], [name], [ns], [pj], [portland], [style], [tf]) VALUES (1, 1, N'paulblart@gmail.com', 2, 2, N'paul', N'Cleveland', N'paul', N'Paul', 0, 1, 1, 2, 0)
INSERT [dbo].[profiles] ([id], [ei], [email], [enrollment], [experience], [github], [home], [linkedin], [name], [ns], [pj], [portland], [style], [tf]) VALUES (2, 1, N'missy@gmail.com', 2, 2, N'missy', N'Boston', N'missy', N'Missy', 0, 0, 2, 2, 0)
INSERT [dbo].[profiles] ([id], [ei], [email], [enrollment], [experience], [github], [home], [linkedin], [name], [ns], [pj], [portland], [style], [tf]) VALUES (3, 0, N'nancy@gmail.com', 2, 1, N'nancy', N'Seattle', N'nancy', N'Nancy', 1, 1, 2, 3, 0)
INSERT [dbo].[profiles] ([id], [ei], [email], [enrollment], [experience], [github], [home], [linkedin], [name], [ns], [pj], [portland], [style], [tf]) VALUES (4, 1, N'elliot@gmail.com', 2, 3, N'elliot', N'Eugene', N'elliot', N'Elliot', 0, 1, 3, 1, 0)
INSERT [dbo].[profiles] ([id], [ei], [email], [enrollment], [experience], [github], [home], [linkedin], [name], [ns], [pj], [portland], [style], [tf]) VALUES (5, 1, N'kit@gmail.com', 2, 3, N'kit', N'Orlando', N'kit', N'Kit', 0, 0, 1, 1, 0)
INSERT [dbo].[profiles] ([id], [ei], [email], [enrollment], [experience], [github], [home], [linkedin], [name], [ns], [pj], [portland], [style], [tf]) VALUES (6, 0, N'pete@gmail.com', 2, 1, N'pete', N'New York City', N'pete', N'Pete', 1, 1, 1, 1, 0)
INSERT [dbo].[profiles] ([id], [ei], [email], [enrollment], [experience], [github], [home], [linkedin], [name], [ns], [pj], [portland], [style], [tf]) VALUES (7, 1, N'sam@gmail.com', 2, 1, N'sam', N'Portland', N'sam', N'Sam', 0, 0, 3, 2, 0)
INSERT [dbo].[profiles] ([id], [ei], [email], [enrollment], [experience], [github], [home], [linkedin], [name], [ns], [pj], [portland], [style], [tf]) VALUES (8, 0, N'mae@gmail.com', 2, 2, N'mae', N'Portland', N'mae', N'Mae', 1, 1, 3, 1, 1)
INSERT [dbo].[profiles] ([id], [ei], [email], [enrollment], [experience], [github], [home], [linkedin], [name], [ns], [pj], [portland], [style], [tf]) VALUES (9, 0, N'kate@gmail.com', 2, 3, N'kate', N'Helena', N'kate', N'Kate', 0, 0, 2, 1, 0)
INSERT [dbo].[profiles] ([id], [ei], [email], [enrollment], [experience], [github], [home], [linkedin], [name], [ns], [pj], [portland], [style], [tf]) VALUES (10, 1, N'pat@gmail.com', 2, 2, N'pat', N'Tampa', N'pat', N'Pat', 1, 1, 2, 2, 1)
INSERT [dbo].[profiles] ([id], [ei], [email], [enrollment], [experience], [github], [home], [linkedin], [name], [ns], [pj], [portland], [style], [tf]) VALUES (11, 1, N'phil@gmail.com', 2, 2, N'phil', N'Columbus', N'phil', N'Phil', 0, 1, 1, 2, 0)
INSERT [dbo].[profiles] ([id], [ei], [email], [enrollment], [experience], [github], [home], [linkedin], [name], [ns], [pj], [portland], [style], [tf]) VALUES (12, 1, N'tim@gmail.com', 2, 2, N'tim', N'Houston', N'tim', N'Tim', 0, 1, 1, 2, 0)
INSERT [dbo].[profiles] ([id], [ei], [email], [enrollment], [experience], [github], [home], [linkedin], [name], [ns], [pj], [portland], [style], [tf]) VALUES (13, 1, N'bethany@gmail.com', 2, 2, N'bethany', N'Calgary', N'bethany', N'Bethany', 1, 1, 1, 2, 1)
INSERT [dbo].[profiles] ([id], [ei], [email], [enrollment], [experience], [github], [home], [linkedin], [name], [ns], [pj], [portland], [style], [tf]) VALUES (14, 0, N'allen@gmail.com', 3, 3, N'allen', N'Garden View', N'allen', N'Allen', 0, 0, 2, 1, 0)
INSERT [dbo].[profiles] ([id], [ei], [email], [enrollment], [experience], [github], [home], [linkedin], [name], [ns], [pj], [portland], [style], [tf]) VALUES (15, 1, N'pat@gmail.com', 3, 2, N'yeardly', N'Chicago', N'yeardly', N'Yeardly', 0, 1, 2, 2, 0)
INSERT [dbo].[profiles] ([id], [ei], [email], [enrollment], [experience], [github], [home], [linkedin], [name], [ns], [pj], [portland], [style], [tf]) VALUES (16, 1, N'dooley@gmail.com', 3, 1, N'dooley', N'West Chester', N'dooley', N'Dooley', 1, 1, 1, 1, 1)
INSERT [dbo].[profiles] ([id], [ei], [email], [enrollment], [experience], [github], [home], [linkedin], [name], [ns], [pj], [portland], [style], [tf]) VALUES (17, 1, N'garron@gmail.com', 3, 1, N'garron', N'Los Angeles', N'garron', N'Garron', 1, 1, 1, 2, 0)
INSERT [dbo].[profiles] ([id], [ei], [email], [enrollment], [experience], [github], [home], [linkedin], [name], [ns], [pj], [portland], [style], [tf]) VALUES (18, 1, N'jimmy@gmail.com', 3, 1, N'jimmy', N'Los Angeles', N'jimmy', N'Jimmy', 1, 0, 1, 2, 1)
INSERT [dbo].[profiles] ([id], [ei], [email], [enrollment], [experience], [github], [home], [linkedin], [name], [ns], [pj], [portland], [style], [tf]) VALUES (23, 1, N'chris@gmail.com', 3, 2, N'yeardly', N'Chicago', N'yeardly', N'Chris', 0, 1, 2, 2, 0)
INSERT [dbo].[profiles] ([id], [ei], [email], [enrollment], [experience], [github], [home], [linkedin], [name], [ns], [pj], [portland], [style], [tf]) VALUES (24, 1, N'tracey@gmail.com', 3, 1, N'tracey', N'West Chester', N'tracey', N'Tracey', 1, 1, 1, 1, 1)
INSERT [dbo].[profiles] ([id], [ei], [email], [enrollment], [experience], [github], [home], [linkedin], [name], [ns], [pj], [portland], [style], [tf]) VALUES (25, 1, N'tina@gmail.com', 3, 1, N'tina', N'Los Angeles', N'tina', N'Tina', 1, 1, 1, 2, 0)
INSERT [dbo].[profiles] ([id], [ei], [email], [enrollment], [experience], [github], [home], [linkedin], [name], [ns], [pj], [portland], [style], [tf]) VALUES (26, 1, N'amy@gmail.com', 3, 1, N'amy', N'Los Angeles', N'amy', N'Amy', 1, 0, 1, 2, 1)
INSERT [dbo].[profiles] ([id], [ei], [email], [enrollment], [experience], [github], [home], [linkedin], [name], [ns], [pj], [portland], [style], [tf]) VALUES (27, 0, N'sarah@gmail.com', 3, 1, N'sarah', N'Albany', N'sarah', N'Sarah', 1, 0, 3, 1, 0)
INSERT [dbo].[profiles] ([id], [ei], [email], [enrollment], [experience], [github], [home], [linkedin], [name], [ns], [pj], [portland], [style], [tf]) VALUES (28, 0, N'sara@gmail.com', 3, 2, N'sara', N'Boise', N'sara', N'Sara', 0, 0, 1, 3, 1)
INSERT [dbo].[profiles] ([id], [ei], [email], [enrollment], [experience], [github], [home], [linkedin], [name], [ns], [pj], [portland], [style], [tf]) VALUES (29, 1, N'rose@gmail.com', 3, 1, N'rose', N'Tampa', N'rose', N'Rose', 1, 1, 1, 1, 1)
INSERT [dbo].[profiles] ([id], [ei], [email], [enrollment], [experience], [github], [home], [linkedin], [name], [ns], [pj], [portland], [style], [tf]) VALUES (30, 1, N'phillipa@gmail.clm', 3, 1, N'phillipa', N'Richmond', N'phillipa', N'Phillipa', 1, 1, 2, 3, 0)
INSERT [dbo].[profiles] ([id], [ei], [email], [enrollment], [experience], [github], [home], [linkedin], [name], [ns], [pj], [portland], [style], [tf]) VALUES (31, 1, N'daryl@gmail.com', 2, 2, N'paul', N'Cleveland', N'paul', N'Daryl', 0, 0, 1, 2, 0)
INSERT [dbo].[profiles] ([id], [ei], [email], [enrollment], [experience], [github], [home], [linkedin], [name], [ns], [pj], [portland], [style], [tf]) VALUES (32, 1, N'cheri@gmail.com', 2, 2, N'missy', N'Boston', N'missy', N'Cheri', 0, 0, 2, 2, 0)
INSERT [dbo].[profiles] ([id], [ei], [email], [enrollment], [experience], [github], [home], [linkedin], [name], [ns], [pj], [portland], [style], [tf]) VALUES (33, 0, N'stephanie@gmail.com', 2, 1, N'nancy', N'Seattle', N'nancy', N'Stephanie', 1, 1, 2, 3, 0)
INSERT [dbo].[profiles] ([id], [ei], [email], [enrollment], [experience], [github], [home], [linkedin], [name], [ns], [pj], [portland], [style], [tf]) VALUES (34, 1, N'stephan@gmail.com', 2, 3, N'elliot', N'Eugene', N'elliot', N'Stephan', 0, 0, 3, 1, 0)
INSERT [dbo].[profiles] ([id], [ei], [email], [enrollment], [experience], [github], [home], [linkedin], [name], [ns], [pj], [portland], [style], [tf]) VALUES (35, 1, N'damian@gmail.com', 2, 3, N'kit', N'Orlando', N'kit', N'Damian', 0, 0, 1, 1, 0)
INSERT [dbo].[profiles] ([id], [ei], [email], [enrollment], [experience], [github], [home], [linkedin], [name], [ns], [pj], [portland], [style], [tf]) VALUES (36, 0, N'rasheed@gmail.com', 2, 1, N'pete', N'New York City', N'pete', N'Rasheed', 1, 1, 1, 1, 0)
INSERT [dbo].[profiles] ([id], [ei], [email], [enrollment], [experience], [github], [home], [linkedin], [name], [ns], [pj], [portland], [style], [tf]) VALUES (37, 1, N'william@gmail.com', 2, 1, N'sam', N'Portland', N'sam', N'William', 0, 0, 3, 2, 0)
INSERT [dbo].[profiles] ([id], [ei], [email], [enrollment], [experience], [github], [home], [linkedin], [name], [ns], [pj], [portland], [style], [tf]) VALUES (38, 0, N'hilary@gmail.com', 2, 2, N'mae', N'Portland', N'mae', N'Hillary', 1, 1, 3, 1, 1)
INSERT [dbo].[profiles] ([id], [ei], [email], [enrollment], [experience], [github], [home], [linkedin], [name], [ns], [pj], [portland], [style], [tf]) VALUES (39, 0, N'bernie@gmail.com', 2, 3, N'kate', N'Helena', N'kate', N'Bernie', 0, 0, 2, 1, 0)
INSERT [dbo].[profiles] ([id], [ei], [email], [enrollment], [experience], [github], [home], [linkedin], [name], [ns], [pj], [portland], [style], [tf]) VALUES (40, 1, N'gabbi@gmail.com', 2, 2, N'pat', N'Tampa', N'pat', N'Gabbi', 1, 1, 2, 2, 1)
INSERT [dbo].[profiles] ([id], [ei], [email], [enrollment], [experience], [github], [home], [linkedin], [name], [ns], [pj], [portland], [style], [tf]) VALUES (41, 1, N'ceciley@gmail.com', 2, 2, N'phil', N'Columbus', N'phil', N'Ceciley', 0, 0, 1, 2, 0)
INSERT [dbo].[profiles] ([id], [ei], [email], [enrollment], [experience], [github], [home], [linkedin], [name], [ns], [pj], [portland], [style], [tf]) VALUES (42, 1, N'niles@gmail.com', 2, 2, N'tim', N'Houston', N'tim', N'Niles', 0, 0, 1, 2, 0)
INSERT [dbo].[profiles] ([id], [ei], [email], [enrollment], [experience], [github], [home], [linkedin], [name], [ns], [pj], [portland], [style], [tf]) VALUES (43, 1, N'rza@gmail.com', 2, 2, N'bethany', N'Calgary', N'bethany', N'Rza', 1, 1, 1, 2, 1)
INSERT [dbo].[profiles] ([id], [ei], [email], [enrollment], [experience], [github], [home], [linkedin], [name], [ns], [pj], [portland], [style], [tf]) VALUES (44, 0, N'lance@gmail.com', 3, 3, N'allen', N'Garden View', N'allen', N'Lance', 0, 0, 2, 1, 0)
INSERT [dbo].[profiles] ([id], [ei], [email], [enrollment], [experience], [github], [home], [linkedin], [name], [ns], [pj], [portland], [style], [tf]) VALUES (45, 1, N'kerry@gmail.com', 3, 2, N'yeardly', N'Chicago', N'yeardly', N'Kerry', 0, 1, 2, 2, 0)
INSERT [dbo].[profiles] ([id], [ei], [email], [enrollment], [experience], [github], [home], [linkedin], [name], [ns], [pj], [portland], [style], [tf]) VALUES (46, 1, N'fred@gmail.com', 3, 1, N'dooley', N'West Chester', N'dooley', N'Fred', 1, 1, 1, 1, 0)
INSERT [dbo].[profiles] ([id], [ei], [email], [enrollment], [experience], [github], [home], [linkedin], [name], [ns], [pj], [portland], [style], [tf]) VALUES (47, 1, N'teresa@gmail.com', 3, 1, N'garron', N'Los Angeles', N'garron', N'Teresa', 1, 1, 1, 2, 0)
INSERT [dbo].[profiles] ([id], [ei], [email], [enrollment], [experience], [github], [home], [linkedin], [name], [ns], [pj], [portland], [style], [tf]) VALUES (48, 1, N'michelle@gmail.com', 3, 1, N'jimmy', N'Los Angeles', N'jimmy', N'Michelle', 1, 0, 1, 2, 1)
INSERT [dbo].[profiles] ([id], [ei], [email], [enrollment], [experience], [github], [home], [linkedin], [name], [ns], [pj], [portland], [style], [tf]) VALUES (49, 1, N'barack@gmail.com', 3, 2, N'yeardly', N'Chicago', N'yeardly', N'Barack', 0, 1, 2, 2, 0)
INSERT [dbo].[profiles] ([id], [ei], [email], [enrollment], [experience], [github], [home], [linkedin], [name], [ns], [pj], [portland], [style], [tf]) VALUES (50, 1, N'george@gmail.com', 3, 1, N'tracey', N'West Chester', N'tracey', N'George', 1, 1, 1, 1, 1)
INSERT [dbo].[profiles] ([id], [ei], [email], [enrollment], [experience], [github], [home], [linkedin], [name], [ns], [pj], [portland], [style], [tf]) VALUES (51, 1, N'shelley@gmail.com', 3, 1, N'tina', N'Los Angeles', N'tina', N'Shelley', 1, 1, 1, 2, 0)
INSERT [dbo].[profiles] ([id], [ei], [email], [enrollment], [experience], [github], [home], [linkedin], [name], [ns], [pj], [portland], [style], [tf]) VALUES (52, 1, N'lauren@gmail.com', 3, 1, N'amy', N'Los Angeles', N'amy', N'Lauren', 0, 0, 1, 2, 0)
INSERT [dbo].[profiles] ([id], [ei], [email], [enrollment], [experience], [github], [home], [linkedin], [name], [ns], [pj], [portland], [style], [tf]) VALUES (53, 0, N'christopher@gmail.com', 3, 1, N'sarah', N'Albany', N'sarah', N'Christopher', 0, 0, 3, 1, 0)
SET IDENTITY_INSERT [dbo].[profiles] OFF
SET IDENTITY_INSERT [dbo].[styles] ON 

INSERT [dbo].[styles] ([id], [name]) VALUES (1, N'audio')
INSERT [dbo].[styles] ([id], [name]) VALUES (2, N'visual')
SET IDENTITY_INSERT [dbo].[styles] OFF
SET IDENTITY_INSERT [dbo].[subhobbies] ON 

INSERT [dbo].[subhobbies] ([id], [hobby_id], [name]) VALUES (1, 1, N'tabletop')
INSERT [dbo].[subhobbies] ([id], [hobby_id], [name]) VALUES (2, 1, N'video')
INSERT [dbo].[subhobbies] ([id], [hobby_id], [name]) VALUES (3, 1, N'playingcard')
INSERT [dbo].[subhobbies] ([id], [hobby_id], [name]) VALUES (4, 1, N'mobile')
INSERT [dbo].[subhobbies] ([id], [hobby_id], [name]) VALUES (7, 2, N'action')
INSERT [dbo].[subhobbies] ([id], [hobby_id], [name]) VALUES (8, 2, N'drama')
INSERT [dbo].[subhobbies] ([id], [hobby_id], [name]) VALUES (9, 2, N'comedy')
INSERT [dbo].[subhobbies] ([id], [hobby_id], [name]) VALUES (10, 2, N'documentary')
INSERT [dbo].[subhobbies] ([id], [hobby_id], [name]) VALUES (11, 3, N'dog')
INSERT [dbo].[subhobbies] ([id], [hobby_id], [name]) VALUES (12, 3, N'cat')
INSERT [dbo].[subhobbies] ([id], [hobby_id], [name]) VALUES (13, 3, N'reptile')
INSERT [dbo].[subhobbies] ([id], [hobby_id], [name]) VALUES (14, 3, N'rodent')
INSERT [dbo].[subhobbies] ([id], [hobby_id], [name]) VALUES (15, 3, N'bird')
INSERT [dbo].[subhobbies] ([id], [hobby_id], [name]) VALUES (16, 3, N'other')
SET IDENTITY_INSERT [dbo].[subhobbies] OFF
