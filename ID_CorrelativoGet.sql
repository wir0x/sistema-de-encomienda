USE [BDEncomiendas]
GO
/****** Object:  StoredProcedure [dbo].[ID_CorrelativoGet]    Script Date: 23/10/2014 22:06:07 ******/
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

create PROC [dbo].[ID_CorrelativoGet]
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

