USE [DemoDB]
GO
/****** Object:  Table [dbo].[RegistartionMaster]    Script Date: 2018-07-05 10:45:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[RegistartionMaster](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FullName] [varchar](50) NULL,
	[Address] [varchar](100) NULL,
	[Emailid] [varchar](40) NULL,
	[Gender] [varchar](10) NULL,
	[Mobno] [bigint] NULL,
	[IsActive] [bit] NULL,
 CONSTRAINT [PK_RegistartionMaster] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
