USE [BDEncomiendas]
GO
/****** Object:  Table [dbo].[Permisos]    Script Date: 10/21/2014 01:05:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Permisos](
	[ID_TipoUser] [int] NOT NULL,
	[Ventana] [varchar](50) NOT NULL,
	[Acceso] [bit] NOT NULL,
	[FechaAct] [datetime] NOT NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  UserDefinedFunction [dbo].[fnIsColumnPrimaryKey]    Script Date: 10/21/2014 01:05:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   FUNCTION [dbo].[fnIsColumnPrimaryKey](@sTableName varchar(128), @nColumnName varchar(128))
RETURNS bit
AS
BEGIN
	DECLARE @nTableID int,
		@nIndexID int,
		@i int
	
	SET 	@nTableID = OBJECT_ID(@sTableName)
	
	SELECT 	@nIndexID = indid
	FROM 	sysindexes
	WHERE 	id = @nTableID
	 AND 	indid BETWEEN 1 And 254 
	 AND 	(status & 2048) = 2048
	
	IF @nIndexID Is Null
		RETURN 0
	
	IF @nColumnName IN
		(SELECT sc.[name]
		FROM 	sysindexkeys sik
			INNER JOIN syscolumns sc ON sik.id = sc.id AND sik.colid = sc.colid
		WHERE 	sik.id = @nTableID
		 AND 	sik.indid = @nIndexID)
	 BEGIN
		RETURN 1
	 END


	RETURN 0
END
GO
/****** Object:  Table [dbo].[TipoUser]    Script Date: 10/21/2014 01:05:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TipoUser](
	[ID_Tipo] [int] NOT NULL,
	[Descripcion] [varchar](150) NOT NULL,
	[Activo] [bit] NOT NULL,
	[FechaAct] [datetime] NOT NULL,
 CONSTRAINT [PK_TipoUser] PRIMARY KEY CLUSTERED 
(
	[ID_Tipo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Punto]    Script Date: 10/21/2014 01:05:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Punto](
	[ID_Punto] [int] NOT NULL,
	[Descripcion] [varchar](50) NOT NULL,
	[Instancia] [char](50) NOT NULL,
	[BaseDatos] [char](50) NOT NULL,
	[Activo] [bit] NOT NULL,
	[FechaAct] [datetime] NOT NULL,
 CONSTRAINT [PK_Punto] PRIMARY KEY CLUSTERED 
(
	[ID_Punto] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 10/21/2014 01:05:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Usuario](
	[ID_Usuario] [int] NOT NULL,
	[Usuario] [varchar](50) NOT NULL,
	[Contraseña] [varchar](20) NOT NULL,
	[ID_TipoUsuario] [int] NULL,
 CONSTRAINT [PK_Usuario] PRIMARY KEY CLUSTERED 
(
	[ID_Usuario] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Parametro]    Script Date: 10/21/2014 01:05:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Parametro](
	[ParametroId] [int] NOT NULL,
	[PrecioMinimo] [decimal](10, 2) NOT NULL,
	[PrecioKilo] [decimal](10, 2) NOT NULL,
	[PrecioVolumen] [decimal](10, 2) NOT NULL,
	[Activo] [bit] NOT NULL,
	[Fecha] [datetime] NOT NULL,
 CONSTRAINT [PK_Parametro] PRIMARY KEY CLUSTERED 
(
	[ParametroId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HojaRuta]    Script Date: 10/21/2014 01:05:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HojaRuta](
	[ID_HojaRuta] [int] NOT NULL,
	[ID_PuntoOrigen] [int] NOT NULL,
	[ID_PuntoDestino] [int] NOT NULL,
	[ID_Flota] [int] NOT NULL,
	[NroDoc_Chofer] [int] NOT NULL,
	[FechaSalida] [datetime] NOT NULL,
	[FechaLlegada] [datetime] NOT NULL,
	[Activo] [bit] NOT NULL,
	[FechaAct] [datetime] NOT NULL,
 CONSTRAINT [PK_Calendario] PRIMARY KEY CLUSTERED 
(
	[ID_HojaRuta] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HistorialRuta]    Script Date: 10/21/2014 01:05:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[HistorialRuta](
	[ID_HistorialRuta] [int] NOT NULL,
	[ID_HojaRuta] [int] NOT NULL,
	[ID_Usuario] [int] NOT NULL,
	[Fecha] [datetime] NOT NULL,
	[Estado] [char](10) NOT NULL,
 CONSTRAINT [PK_HistorialRuta] PRIMARY KEY CLUSTERED 
(
	[ID_HistorialRuta] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[HistorialEncomienda]    Script Date: 10/21/2014 01:05:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[HistorialEncomienda](
	[ID_HistorialEncomienda] [int] NOT NULL,
	[ID_Encomienda] [int] NOT NULL,
	[ID_Usuario] [int] NOT NULL,
	[Estado] [char](1) NOT NULL,
	[Fecha] [datetime] NOT NULL,
 CONSTRAINT [PK_HistorialEstado] PRIMARY KEY CLUSTERED 
(
	[ID_HistorialEncomienda] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  UserDefinedFunction [dbo].[fnTableHasPrimaryKey]    Script Date: 10/21/2014 01:05:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[fnTableHasPrimaryKey](@sTableName varchar(128))
RETURNS bit
AS
BEGIN
	DECLARE @nTableID int,
		@nIndexID int
	
	SET 	@nTableID = OBJECT_ID(@sTableName)
	
	SELECT 	@nIndexID = indid
	FROM 	sysindexes
	WHERE 	id = @nTableID
	 AND 	indid BETWEEN 1 And 254 
	 AND 	(status & 2048) = 2048
	
	IF @nIndexID IS NOT Null
		RETURN 1
	
	RETURN 0
END
GO
/****** Object:  Table [dbo].[Chofer]    Script Date: 10/21/2014 01:05:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Chofer](
	[NroDoc] [varchar](15) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Direccion] [varchar](200) NOT NULL,
	[Telefono] [varchar](20) NOT NULL,
	[Activo] [bit] NOT NULL,
	[FechaAct] [datetime] NOT NULL,
 CONSTRAINT [PK_Chofer_1] PRIMARY KEY CLUSTERED 
(
	[NroDoc] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  UserDefinedFunction [dbo].[fnCleanDefaultValue]    Script Date: 10/21/2014 01:05:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[fnCleanDefaultValue](@sDefaultValue varchar(4000))
RETURNS varchar(4000)
AS
BEGIN
	RETURN SubString(@sDefaultValue, 2, DataLength(@sDefaultValue)-2)
END
GO
/****** Object:  Table [dbo].[Cliente]    Script Date: 10/21/2014 01:05:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Cliente](
	[NroDoc] [varchar](15) NOT NULL,
	[Nombre] [varchar](70) NOT NULL,
	[Telefono] [varchar](20) NOT NULL,
	[Direccion] [varchar](200) NOT NULL,
	[Activo] [bit] NOT NULL,
	[FechaAct] [datetime] NOT NULL,
 CONSTRAINT [PK_Cliente_1] PRIMARY KEY CLUSTERED 
(
	[NroDoc] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Flota]    Script Date: 10/21/2014 01:05:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Flota](
	[ID_flota] [int] NOT NULL,
	[Marca] [varchar](20) NOT NULL,
	[Modelo] [varchar](20) NOT NULL,
	[Año] [int] NOT NULL,
	[Placa] [varchar](10) NOT NULL,
	[VolumenCarga] [decimal](12, 2) NOT NULL,
	[PesoCarga] [decimal](12, 2) NOT NULL,
	[Activo] [bit] NOT NULL,
	[Fecha_Act] [datetime] NOT NULL,
 CONSTRAINT [PK_Flota] PRIMARY KEY CLUSTERED 
(
	[ID_flota] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Encomienda]    Script Date: 10/21/2014 01:05:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Encomienda](
	[ID_Encomienda] [varchar](8) NOT NULL,
	[Fecha] [datetime] NOT NULL,
	[NroDoc_Remitente] [int] NOT NULL,
	[NroDoc_Destinatario] [int] NOT NULL,
	[ID_HojaRuta] [int] NOT NULL,
	[Descripcion] [varchar](200) NOT NULL,
	[Fragil] [bit] NOT NULL,
	[Volumen] [decimal](12, 2) NOT NULL,
	[Peso] [decimal](12, 2) NOT NULL,
	[Monto] [decimal](12, 2) NOT NULL,
	[Pagado] [bit] NOT NULL,
	[Activo] [bit] NOT NULL,
	[FechaAct] [datetime] NOT NULL,
 CONSTRAINT [PK_Encomienda] PRIMARY KEY CLUSTERED 
(
	[ID_Encomienda] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  StoredProcedure [dbo].[Cliente_Update]    Script Date: 10/21/2014 01:05:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
----------------------------------------------------------------------------
-- Update a single record in Cliente
----------------------------------------------------------------------------
CREATE PROC [dbo].[Cliente_Update]
	@NroDoc_Anterior varchar(15),
	@NroDoc_Nuevo varchar(15),
	@Nombre varchar(70),
	@Telefono varchar(20),
	@Direccion varchar(200),
	@Activo bit,
	@FechaAct datetime
AS
begin	

	UPDATE	Cliente
	SET	NroDoc  = @NroDoc_Nuevo ,
		Nombre = @Nombre,
		Telefono = @Telefono,
		Direccion = @Direccion,
		Activo = @Activo,
		FechaAct = @FechaAct 
	WHERE NroDoc  = @NroDoc_Anterior 

end
GO
/****** Object:  StoredProcedure [dbo].[Cliente_SelectAll]    Script Date: 10/21/2014 01:05:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
----------------------------------------------------------------------------
-- Select a single record from Cliente
----------------------------------------------------------------------------
CREATE PROC [dbo].[Cliente_SelectAll]
	@Estado bit,
	@Nombre varchar(50)
AS
begin
	SELECT *
	FROM Cliente 
	WHERE Activo = @Estado 
	  AND Nombre LIKE '%' + @Nombre + '%'
end
GO
/****** Object:  StoredProcedure [dbo].[Cliente_Select]    Script Date: 10/21/2014 01:05:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
----------------------------------------------------------------------------
-- Select a single record from Cliente
----------------------------------------------------------------------------
CREATE PROC [dbo].[Cliente_Select]
	@NroDoc int
AS

SELECT	NroDoc,
	Nombre,
	NroDoc,
	Telefono,
	Direccion,
	Activo
FROM	Cliente
WHERE 	NroDoc = @NroDoc
GO
/****** Object:  StoredProcedure [dbo].[Cliente_Insert]    Script Date: 10/21/2014 01:05:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
----------------------------------------------------------------------------
-- Insert a single record into Cliente
----------------------------------------------------------------------------
CREATE PROC [dbo].[Cliente_Insert]
(
	@NroDoc varchar(15),
	@Nombre varchar(70),
	@Telefono varchar(20),
	@Direccion varchar(200),
	@Activo bit,
	@FechaAct datetime
)

AS
BEGIN
	INSERT INTO Cliente
	VALUES (@NroDoc,  
			@Nombre, 
			@Telefono, 
			@Direccion, 
			@Activo,
			@FechaAct)
END
GO
/****** Object:  StoredProcedure [dbo].[Cliente_Delete]    Script Date: 10/21/2014 01:05:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
----------------------------------------------------------------------------
-- AUTOR: "DANIEL ROMERO"
-- FECHA: 13/09/2014
-- MODIF: 13/09/2014
-- DESC : CAMBIA EL ESTADO A INACTIVO
----------------------------------------------------------------------------
CREATE PROC [dbo].[Cliente_Delete]
	@NroDoc int
AS

UPDATE	Cliente
SET Activo = 0
WHERE 	NroDoc = @NroDoc
GO
/****** Object:  StoredProcedure [dbo].[Chofer_Update]    Script Date: 10/21/2014 01:05:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
----------------------------------------------------------------------------
--Autor: Jhon Vargas
--Create Date: 25/09/14
--Descripcion: Modifica un Chofer por ID
--exec Chofer_Update
----------------------------------------------------------------------------

CREATE PROC [dbo].[Chofer_Update]
	@NroDoc varchar(15),
	@Nombre varchar(50),
	@Direccion varchar(200),
	@Telefono varchar(20)
AS

UPDATE	Chofer
SET	
	Nombre = @Nombre,
	Direccion = @Direccion,
	Telefono = @Telefono
WHERE 	NroDoc= @NroDoc
GO
/****** Object:  StoredProcedure [dbo].[Chofer_SelectByCI]    Script Date: 10/21/2014 01:05:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
----------------------------------------------------------------------------
--Autor: Jhon Vargas
--Create Date: 25/09/14
--Descripcion: Buscar un Chofer por Carnet
--exec Chofer_SelectByCI '62216220'
----------------------------------------------------------------------------

create PROC [dbo].[Chofer_SelectByCI]
	@NroDoc int
AS

SELECT	*
FROM	Chofer
WHERE 	NroDoc= @NroDoc
GO
/****** Object:  StoredProcedure [dbo].[Chofer_Select]    Script Date: 10/21/2014 01:05:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[Chofer_Select]
	@nombre varchar(50),
	@activo bit
AS
begin
SELECT	NroDoc,nombre,direccion,telefono
FROM	Chofer
WHERE 	Nombre LIKE '%' + @nombre + '%' and Activo = @activo
end
GO
/****** Object:  StoredProcedure [dbo].[Chofer_Insert]    Script Date: 10/21/2014 01:05:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
----------------------------------------------------------------------------
--Autor: Jhon Vargas
--Create Date: 25/09/14
--Descripcion: Insertar un Chofer
--exec Chofer_Insert
----------------------------------------------------------------------------


CREATE procedure [dbo].[Chofer_Insert]
(
	@NroDoc varchar(15),
	@Nombre varchar(50),
	@Direccion varchar(200),
	@Telefono varchar(20)
)
as
begin
	insert Chofer(NroDoc,Nombre,Direccion,Telefono,Activo,FechaAct)
	values(@NroDoc,@Nombre,@Direccion,@Telefono,1,GETDATE())
	end
GO
/****** Object:  StoredProcedure [dbo].[Chofer_Delete]    Script Date: 10/21/2014 01:05:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
----------------------------------------------------------------------------
--Autor: Jhon Vargas
--Create Date: 25/09/14
--Descripcion: Elimina un Chofer
--exec Chofer_Delete
----------------------------------------------------------------------------

create PROC [dbo].[Chofer_Delete]
	@NroDoc int
AS
begin
UPDATE Chofer
SET Activo = 0

WHERE 	NroDoc= @NroDoc
end
GO
/****** Object:  StoredProcedure [dbo].[Flota_Update]    Script Date: 10/21/2014 01:05:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[Flota_Update]
 @ID_flota int,
 @Marca varchar(20),
 @Modelo varchar(20),
 @Año int,
 @Placa varchar(10),
 @Volumen decimal(12,2),
 @Peso decimal(12,2),
 @Activo bit
as
begin 
   UPDATE Flota SET Marca=@Marca,Modelo=@Modelo,Año=@Año,Placa=@Placa,VolumenCarga=@Volumen,PesoCarga=@Peso,Activo=@Activo,fecha_act=GETDATE() WHERE ID_flota=@ID_flota
end
GO
/****** Object:  StoredProcedure [dbo].[Flota_SelectAll]    Script Date: 10/21/2014 01:05:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROC [dbo].[Flota_SelectAll]
	@Placa varchar(10),
	@activo bit
AS
begin
	SELECT *
	FROM Flota 
	WHERE Placa LIKE '%' + @Placa + '%' AND Activo = @activo
	
end
GO
/****** Object:  StoredProcedure [dbo].[Flota_Insert]    Script Date: 10/21/2014 01:05:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[Flota_Insert]
	@Marca varchar(20),
	@Modelo varchar(20),
	@año int,
	@Placa varchar(10),
	@VolumenCarga decimal(12,2),
	@PesoCarga decimal(12,2),
	@Activo bit
AS
begin
	declare @id_flota int
	select @id_flota=isnull(MAX(ID_flota)+1,1) From Flota
	INSERT Flota(ID_flota, Marca,Modelo,Año,Placa,VolumenCarga,PesoCarga, Activo,fecha_act)
	VALUES (@id_flota,@Marca,@Modelo,@año,@Placa,@VolumenCarga,@PesoCarga,@Activo,GETDATE())
end
GO
/****** Object:  StoredProcedure [dbo].[Parametro_GetAllForUser]    Script Date: 10/21/2014 01:05:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Autor:		<Gonzalo Salazar>
-- Create date: <24/09/2014>
-- Description:	<Obtener todos los Parametros>
-- exec Parametro_GetAllForUser
-- =============================================
CREATE proc [dbo].[Parametro_GetAllForUser]
AS
BEGIN
	SELECT	ParametroId,
			PrecioMinimo,
			PrecioKilo,
			PrecioVolumen,
			Activo,
			Fecha 
	FROM	Parametro
	ORDER BY ParametroId	DESC

END
GO
/****** Object:  StoredProcedure [dbo].[UpdateActivo]    Script Date: 10/21/2014 01:05:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[UpdateActivo]
as
begin
	declare @penultimoId int
	
	SELECT  @penultimoId = MAX(ParametroId) 
	FROM	Parametro
	
	UPDATE  Parametro
	SET		Activo = 0
	WHERE	ParametroId = @penultimoId
		
end
GO
/****** Object:  StoredProcedure [dbo].[Pun_Update]    Script Date: 10/21/2014 01:05:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
----------------------------------------------------------------------------
-- AUTOR: "DANIEL ROMERO"
-- FECHA: 20/09/2014
-- MODIF: 27/09/2014
-- DESC : ACTUALIZA LOS DATOS DE UN PUNTO
----------------------------------------------------------------------------
CREATE PROC [dbo].[Pun_Update]
(
	@ID_PuntoAnterior int,
	@ID_Punto int,
	@Descripcion varchar(50),
	@Instancia char(50),
	@BaseDatos char(50),
	@Activo bit,
	@FechaAct datetime

)
AS
BEGIN

	UPDATE Punto
	SET ID_Punto = @ID_Punto ,
		Descripcion = @Descripcion,
		Instancia =@Instancia,
		BaseDatos = @BaseDatos,
		Activo = @Activo,
		FechaAct = @FechaAct
	WHERE ID_Punto = @ID_PuntoAnterior 

END
GO
/****** Object:  StoredProcedure [dbo].[Pun_Insert]    Script Date: 10/21/2014 01:05:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
----------------------------------------------------------------------------
-- AUTOR: "DANIEL ROMERO"
-- FECHA: 20/09/2014
-- MODIF: 27/09/2014
-- DESC : GUARDA UN NUEVO PUNTO
----------------------------------------------------------------------------
CREATE PROC [dbo].[Pun_Insert]
(
	@ID_Punto int,
	@Descripcion varchar(50),
	@Instancia char(50),
	@BaseDatos char(50),
	@Activo bit,
	@FechaAct datetime

)
AS
BEGIN

	INSERT 
	INTO Punto 
	VALUES (@ID_Punto,
			@Descripcion ,
			@Instancia,
			@BaseDatos,
			@Activo,
			@FechaAct)

END
GO
/****** Object:  StoredProcedure [dbo].[Pun_GetByID]    Script Date: 10/21/2014 01:05:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
----------------------------------------------------------------------------
-- AUTOR: "DANIEL ROMERO"
-- FECHA: 20/09/2014
-- MODIF: 20/09/2014
-- DESC : OBTIENE EL PUNTO POR SU CODIGO
----------------------------------------------------------------------------
CREATE PROC [dbo].[Pun_GetByID]
(
	@ID_Punto int
)
AS
BEGIN

	SELECT *
	FROM Punto 
	WHERE ID_Punto = @ID_Punto 

END
GO
/****** Object:  StoredProcedure [dbo].[Pun_GetAll]    Script Date: 10/21/2014 01:05:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
----------------------------------------------------------------------------
-- AUTOR: "DANIEL ROMERO"
-- FECHA: 20/09/2014
-- MODIF: 20/09/2014
-- DESC : OBTIENE LOS PUNTOS X SU DESCRIPCION
-- EXEC Pun_GetAll 'TRUE',''
----------------------------------------------------------------------------
CREATE PROC [dbo].[Pun_GetAll]
(
	@Activo bit,
	@Descripcion varchar(50)
)
AS
BEGIN

	SELECT *
	FROM Punto 
	WHERE Activo  = @Activo  
	  and Descripcion LIKE '%' + @Descripcion + '%'

END
GO
/****** Object:  StoredProcedure [dbo].[Pun_Delete]    Script Date: 10/21/2014 01:05:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
----------------------------------------------------------------------------
-- AUTOR: "DANIEL ROMERO"
-- FECHA: 20/09/2014
-- MODIF: 20/09/2014
-- DESC : CAMBIA EL ESTADO DE UN PUNTO
----------------------------------------------------------------------------
CREATE PROC [dbo].[Pun_Delete]
(
	@ID_Punto int,
	@Estado bit
)
AS
BEGIN

	UPDATE Punto
	SET Activo = @Estado  
	WHERE ID_Punto = @ID_Punto 

END
GO
/****** Object:  UserDefinedFunction [dbo].[fnColumnDefault]    Script Date: 10/21/2014 01:05:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[fnColumnDefault](@sTableName varchar(128), @sColumnName varchar(128))
RETURNS varchar(4000)
AS
BEGIN
	DECLARE @sDefaultValue varchar(4000)

	SELECT	@sDefaultValue = dbo.fnCleanDefaultValue(COLUMN_DEFAULT)
	FROM	INFORMATION_SCHEMA.COLUMNS
	WHERE	TABLE_NAME = @sTableName
	 AND 	COLUMN_NAME = @sColumnName

	RETURN 	@sDefaultValue

END
GO
/****** Object:  StoredProcedure [dbo].[Parametro_UpdateForUser]    Script Date: 10/21/2014 01:05:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Autor:		<Gonzalo Salazar>
-- Create date: <24/09/2014>
-- Description:	<Insertar Precios a la tabla Parametro>
-- exec Parametro_SetForUser
-- =============================================
CREATE PROC [dbo].[Parametro_UpdateForUser]
@PrecioMinimo  DECIMAL(10,2),
@PrecioKilo    DECIMAL(10,2),
@PrecioVolumen DECIMAL(10,2),
@Activo		   bit

AS
Begin
	UPDATE	Parametro
	SET		PrecioMinimo  = @PrecioMinimo,
			PrecioKilo	  = @PrecioKilo,
			PrecioVolumen = @PrecioVolumen
	WHERE	Activo = @Activo
End
GO
/****** Object:  StoredProcedure [dbo].[Parametro_UpdateActivo]    Script Date: 10/21/2014 01:05:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Autor:		<Gonzalo Salazar>
-- Create date: <20/09/2014>
-- Description:	<Actualizar Col. Activo de Parametro>
-- exec Parametro_UpdateActivo
-- =============================================
CREATE proc [dbo].[Parametro_UpdateActivo]
as
begin
	DECLARE @UltimoId int
	
	SELECT  @UltimoId = MAX(ParametroId) 
	FROM	Parametro
	
	UPDATE  Parametro 
	SET		Activo = 0
	WHERE   @UltimoId is Null 
	OR		ParametroId = @UltimoId
end
GO
/****** Object:  StoredProcedure [dbo].[Parametro_SetForUser]    Script Date: 10/21/2014 01:05:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Autor:		<Gonzalo Salazar>
-- Create date: <24/09/2014>
-- Description:	<Insertar Precios a la tabla Parametro>
-- exec Parametro_SetForUser
-- =============================================


CREATE proc [dbo].[Parametro_SetForUser]
	@PrecioMinimo   decimal(10,2),
	@PrecioKilo     decimal(10,2), 
	@PrecioVolumen  decimal(10,2)
as
begin
	declare @maxId int, 
			@fecha datetime
	
	SELECT	@maxId = isnull(MAX(ParametroId + 1),1)
	FROM	Parametro
	
	SELECT	@fecha = GETDATE()
	
	EXEC	Parametro_UpdateActivo
	
	INSERT 
	INTO	Parametro(
			ParametroId,
			PrecioMinimo,
			PrecioKilo,
			PrecioVolumen,
			Activo,
			  Fecha)
	VALUES (@maxId,
		    @PrecioMinimo,
		    @PrecioKilo,
		    @PrecioVolumen,
		    1,
		    @fecha)
	
end
GO
/****** Object:  UserDefinedFunction [dbo].[fnTableColumnInfo]    Script Date: 10/21/2014 01:05:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE       FUNCTION [dbo].[fnTableColumnInfo](@sTableName varchar(128))
RETURNS TABLE
AS
	RETURN
	SELECT	c.name AS sColumnName,
		c.colid AS nColumnID,
		dbo.fnIsColumnPrimaryKey(@sTableName, c.name) AS bPrimaryKeyColumn,
		CASE 	WHEN t.name IN ('char', 'varchar', 'binary', 'varbinary', 'nchar', 'nvarchar') THEN 1
			WHEN t.name IN ('decimal', 'numeric') THEN 2
			ELSE 0
		END AS nAlternateType,
		c.length AS nColumnLength,
		c.prec AS nColumnPrecision,
		c.scale AS nColumnScale, 
		c.IsNullable, 
		SIGN(c.status & 128) AS IsIdentity,
		t.name as sTypeName,
		dbo.fnColumnDefault(@sTableName, c.name) AS sDefaultValue
	FROM	syscolumns c 
		INNER JOIN systypes t ON c.xtype = t.xtype and c.usertype = t.usertype
	WHERE	c.id = OBJECT_ID(@sTableName)
GO
