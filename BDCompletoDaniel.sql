USE [BDEncomiendas]
GO
/****** Object:  UserDefinedFunction [dbo].[fnCleanDefaultValue]    Script Date: 24/10/2014 2:00:14 ******/
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
/****** Object:  UserDefinedFunction [dbo].[fnColumnDefault]    Script Date: 24/10/2014 2:00:14 ******/
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
/****** Object:  UserDefinedFunction [dbo].[fnIsColumnPrimaryKey]    Script Date: 24/10/2014 2:00:14 ******/
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
/****** Object:  UserDefinedFunction [dbo].[fnTableHasPrimaryKey]    Script Date: 24/10/2014 2:00:14 ******/
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
/****** Object:  Table [dbo].[Chofer]    Script Date: 24/10/2014 2:00:14 ******/
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
	[Ubicacion] [int] NOT NULL,
 CONSTRAINT [PK_Chofer_1] PRIMARY KEY CLUSTERED 
(
	[NroDoc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Cliente]    Script Date: 24/10/2014 2:00:14 ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[EncAño]    Script Date: 24/10/2014 2:00:14 ******/
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
/****** Object:  Table [dbo].[Encomienda]    Script Date: 24/10/2014 2:00:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Encomienda](
	[ID_Encomienda] [varchar](8) NOT NULL,
	[Fecha] [datetime] NOT NULL,
	[NroDoc_Remitente] [varchar](15) NOT NULL,
	[NroDoc_Destinatario] [varchar](15) NOT NULL,
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Flota]    Script Date: 24/10/2014 2:00:14 ******/
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
	[Ubicacion] [int] NOT NULL,
 CONSTRAINT [PK_Flota] PRIMARY KEY CLUSTERED 
(
	[ID_flota] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[HistorialEncomienda]    Script Date: 24/10/2014 2:00:14 ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[HistorialRuta]    Script Date: 24/10/2014 2:00:14 ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[HojaRuta]    Script Date: 24/10/2014 2:00:14 ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Parametro]    Script Date: 24/10/2014 2:00:14 ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Permisos]    Script Date: 24/10/2014 2:00:14 ******/
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
/****** Object:  Table [dbo].[Punto]    Script Date: 24/10/2014 2:00:14 ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TipoUser]    Script Date: 24/10/2014 2:00:14 ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 24/10/2014 2:00:14 ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  UserDefinedFunction [dbo].[fnTableColumnInfo]    Script Date: 24/10/2014 2:00:14 ******/
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
/****** Object:  StoredProcedure [dbo].[Chofer_Delete]    Script Date: 24/10/2014 2:00:14 ******/
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
/****** Object:  StoredProcedure [dbo].[Chofer_Insert]    Script Date: 24/10/2014 2:00:14 ******/
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
	@Telefono varchar(20),
	@UBicacion int
)
as
begin
	INSERT 
	INTO Chofer
	values(@NroDoc,
			@Nombre,
			@Direccion,
			@Telefono,1,
			GETDATE(),
			@UBicacion )
	end

GO
/****** Object:  StoredProcedure [dbo].[Chofer_Select]    Script Date: 24/10/2014 2:00:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[Chofer_Select]
	@nombre varchar(50),
	@activo bit
AS
begin
	SELECT	NroDoc,nombre,direccion,telefono,ubicacion 
	FROM	Chofer
	WHERE 	Nombre LIKE '%' + @nombre + '%' and Activo = @activo
end

GO
/****** Object:  StoredProcedure [dbo].[Chofer_SelectByCI]    Script Date: 24/10/2014 2:00:14 ******/
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
/****** Object:  StoredProcedure [dbo].[Chofer_Update]    Script Date: 24/10/2014 2:00:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
----------------------------------------------------------------------------
--Autor: Jhon Vargas
--Create Date: 24/10/14
--Descripcion: Modifica un Chofer por ID
--exec Chofer_Update
----------------------------------------------------------------------------

CREATE PROC [dbo].[Chofer_Update]
	@NroDoc varchar(15),
	@Nombre varchar(50),
	@Direccion varchar(200),
	@Telefono varchar(20),
	@Ubicacion int
AS

UPDATE	Chofer
SET	
	Nombre = @Nombre,
	Direccion = @Direccion,
	Telefono = @Telefono,
	Ubicacion = @Ubicacion 
WHERE 	NroDoc= @NroDoc

GO
/****** Object:  StoredProcedure [dbo].[Cliente_Delete]    Script Date: 24/10/2014 2:00:14 ******/
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
WHERE 	NroDoc  = @NroDoc 


GO
/****** Object:  StoredProcedure [dbo].[Cliente_Insert]    Script Date: 24/10/2014 2:00:14 ******/
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
/****** Object:  StoredProcedure [dbo].[Cliente_Select]    Script Date: 24/10/2014 2:00:14 ******/
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

SELECT	NroDoc ,
	Nombre,
	NroDoc,
	Telefono,
	Direccion,
	Activo
FROM	Cliente
WHERE 	NroDoc = @NroDoc


GO
/****** Object:  StoredProcedure [dbo].[Cliente_SelectAll]    Script Date: 24/10/2014 2:00:14 ******/
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
/****** Object:  StoredProcedure [dbo].[Cliente_Update]    Script Date: 24/10/2014 2:00:14 ******/
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
/****** Object:  StoredProcedure [dbo].[Flota_Insert]    Script Date: 24/10/2014 2:00:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

---------------------------------------------------------------------------
--Autor: Wilson Garcia
--Create Date: 24/10/14
--Descripcion: guarda los detalles de una flota
--exec Flota_Insert
----------------------------------------------------------------------------
CREATE PROCEDURE [dbo].[Flota_Insert]
	@Marca varchar(20),
	@Modelo varchar(20),
	@año int,
	@Placa varchar(10),
	@VolumenCarga decimal(12,2),
	@PesoCarga decimal(12,2),
	@Activo bit,
	@Ubicacion int
AS
begin
	DECLARE @id_flota int

	SELECT @id_flota=isnull(MAX(ID_flota)+1,1) 
	FROM Flota

	INSERT 
	INTO Flota
	VALUES (@id_flota,
			@Marca,
			@Modelo,
			@año,
			@Placa,
			@VolumenCarga,
			@PesoCarga,
			@Activo,
			GETDATE(),
			@Ubicacion )
end
GO
/****** Object:  StoredProcedure [dbo].[Flota_SelectAll]    Script Date: 24/10/2014 2:00:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--exec Flota_SelectAll '',1
CREATE PROC [dbo].[Flota_SelectAll]
	@Placa varchar(10),
	@activo bit
AS
begin
	SELECT ID_flota,
			Marca,
			Modelo,
			Año,
			Placa,
			VolumenCarga,
			PesoCarga,
			f.Activo,
			Fecha_Act,
			p.Descripcion as Ubicacion

	FROM Flota as f join Punto as p on (f.Ubicacion = P.ID_Punto)
	WHERE Placa LIKE '%' + @Placa + '%' AND f.Activo = @activo
	  
	
end

GO
/****** Object:  StoredProcedure [dbo].[Flota_Update]    Script Date: 24/10/2014 2:00:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[Flota_Update]
 @ID_flota int,
 @Marca varchar(20),
 @Modelo varchar(20),
 @Año int,
 @Placa varchar(10),
 @Volumen decimal(12,2),
 @Peso decimal(12,2),
 @Activo bit,
 @Ubicacion int
as
begin 
   UPDATE Flota 
   SET Marca=@Marca,Modelo=@Modelo,Año=@Año,Placa=@Placa,VolumenCarga=@Volumen,PesoCarga=@Peso,Activo=@Activo,fecha_act=GETDATE() , Ubicacion = @Ubicacion 
   WHERE ID_flota=@ID_flota
end

GO
/****** Object:  StoredProcedure [dbo].[flotaByOrigen]    Script Date: 24/10/2014 2:00:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


----------------------------------------------------------------------------
--Autor: Jhon Vargas
--Create Date: 23/10/14
--Descripcion: Obtiene las flotas segun Origen
--exec flotaByOrigen 1
----------------------------------------------------------------------------

CREATE PROC [dbo].[flotaByOrigen]
(
	@Origen int
)
AS
BEGIN
	SELECT PLACA 
	FROM Flota 
	WHERE Ubicacion = @Origen   
END


GO
/****** Object:  StoredProcedure [dbo].[HistorialRuta_Insert]    Script Date: 24/10/2014 2:00:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
----------------------------------------------------------------------------
--Autor: Jhon Vargas
--Create Date: 10/10/14
--Descripcion: Insertar un HistorilRuta
--exec HistorialRuta_Insert 1
----------------------------------------------------------------------------

CREATE PROC [dbo].[HistorialRuta_Insert]
	@ID_Usuario int
AS
BEGIN
	Declare @idHojaR int
	
	select @idHojaR = ISNULL(MAX(ID_HojaRuta),1)from HojaRuta
	Declare @id int
	
	select @id = ISNULL(MAX(ID_HistorialRuta+1),1)from HistorialRuta
	
	INSERT INTO HistorialRuta 
	VALUES (@id, @idHojaR, @ID_Usuario, 1, GETDATE())
END

GO
/****** Object:  StoredProcedure [dbo].[HojaRuta_Insert]    Script Date: 24/10/2014 2:00:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
----------------------------------------------------------------------------
--Autor: Jhon Vargas
--Create Date: 10/10/14
--Descripcion: Insertar una Hoja de Ruta
--exec HojaRuta_Insert
----------------------------------------------------------------------------

CREATE PROC [dbo].[HojaRuta_Insert]
	@ID_flota int,
	@NroDoc varchar(15),
	@ID_Origen int,
	@ID_Destino int,
	@FechaSalida datetime,
	@FechaLlegada datetime
AS
BEGIN
Declare @id int
select @id = ISNULL(MAX(ID_HojaRuta+1),1)from HojaRuta
INSERT into dbo.HojaRuta
VALUES (@id, @ID_flota, @NroDoc, @ID_Origen, @ID_Destino, @FechaSalida, @FechaLlegada, 1, GETDATE())

END
GO
/****** Object:  StoredProcedure [dbo].[HR_IDGet]    Script Date: 24/10/2014 2:00:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

----------------------------------------------------------------------------
-- AUTOR: "DANIEL ROMERO"
-- FECHA: 09/10/2014
-- MODIF: 09/10/2014
-- DESC : OBTIENE EL ID PARA HOJARUTA
-- exec HR_IDGet
----------------------------------------------------------------------------
CREATE PROC [dbo].[HR_IDGet]
	
AS
begin
	DECLARE @id INT

	SELECT @ID = ISNULL(MAX(ID_HojaRuta+1),1)
	FROM HojaRuta 

	SELECT @id AS IDHojaRuta
end


GO
/****** Object:  StoredProcedure [dbo].[ID_CorrelativoGet]    Script Date: 24/10/2014 2:00:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


----------------------------------------------------------------------------
--Autor: Daniel Romero
--Create Date: 23/10/14
--Descripcion: Obtener el ID Correlativo para Encomienda
--exec ID_CorrelativoGet 15
----------------------------------------------------------------------------

CREATE PROC [dbo].[ID_CorrelativoGet]
(
	@Año int
)
AS
BEGIN
	DECLARE @Correlativo int

	SELECT @Correlativo = isnull(MAX (Correlativo +1 ),1)
	FROM EncAño 
	WHERE año = @Año 

	SELECT @Correlativo AS Correlativo
END


GO
/****** Object:  StoredProcedure [dbo].[ID_CorrelativoUpdate]    Script Date: 24/10/2014 2:00:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


----------------------------------------------------------------------------
--Autor: Daniel Romero
--Create Date: 23/10/14
--Descripcion: Actualiza el correlativo de las encomiendas
--exec ID_CorrelativoUpdate 17
--exec ID_CorrelativoGet 16
----------------------------------------------------------------------------

CREATE PROC [dbo].[ID_CorrelativoUpdate]
(
	@Año int
)
AS
BEGIN
	DECLARE @Correla int,
			@ID_Corre int

	SELECT @Correla = ISNULL(MAX(Correlativo)  ,0)
	FROM EncAño 
	WHERE Año = @Año  

	
	if @Correla = 0 
		begin
			SELECT @ID_Corre = ISNULL(MAX(Correlativo +1),1)
			FROM EncAño 
		
			INSERT 
			INTO EncAño 
			VALUES (@ID_Corre,
					@Año ,
					1)
		end
	ELSE
		BEGIN
			UPDATE EncAño 
			SET Correlativo = Correlativo + 1
			WHERE Año = @Año
		END

END


GO
/****** Object:  StoredProcedure [dbo].[Parametro_GetAllForUser]    Script Date: 24/10/2014 2:00:14 ******/
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
/****** Object:  StoredProcedure [dbo].[Parametro_SetForUser]    Script Date: 24/10/2014 2:00:14 ******/
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
/****** Object:  StoredProcedure [dbo].[Parametro_UpdateActivo]    Script Date: 24/10/2014 2:00:14 ******/
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
/****** Object:  StoredProcedure [dbo].[Parametro_UpdateForUser]    Script Date: 24/10/2014 2:00:14 ******/
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
/****** Object:  StoredProcedure [dbo].[Pun_Delete]    Script Date: 24/10/2014 2:00:14 ******/
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
/****** Object:  StoredProcedure [dbo].[Pun_GetAll]    Script Date: 24/10/2014 2:00:14 ******/
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
/****** Object:  StoredProcedure [dbo].[Pun_GetByID]    Script Date: 24/10/2014 2:00:14 ******/
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
/****** Object:  StoredProcedure [dbo].[Pun_Insert]    Script Date: 24/10/2014 2:00:14 ******/
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
/****** Object:  StoredProcedure [dbo].[Pun_Update]    Script Date: 24/10/2014 2:00:14 ******/
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
/****** Object:  StoredProcedure [dbo].[Punto_Select]    Script Date: 24/10/2014 2:00:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
----------------------------------------------------------------------------
--Autor: Jhon Vargas
--Create Date: 10/10/14
--Descripcion: Buscar todos los Puntos
--exec Punto_Select
----------------------------------------------------------------------------

CREATE PROCEDURE [dbo].[Punto_Select]
as 
begin
select ID_Punto,Descripcion
from Punto
end
GO
/****** Object:  StoredProcedure [dbo].[UpdateActivo]    Script Date: 24/10/2014 2:00:14 ******/
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
