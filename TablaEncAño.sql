USE [BDEncomiendas]
GO
/****** Object:  Table [dbo].[EncAño]    Script Date: 23/10/2014 22:13:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EncAño](
	[ID_Encomienda] [int] NOT NULL,
	[Año] [int] NOT NULL,
	[Correlativo] [nchar](10) NOT NULL
) ON [PRIMARY]

GO
