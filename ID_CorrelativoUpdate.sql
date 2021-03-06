

----------------------------------------------------------------------------
--Autor: Daniel Romero
--Create Date: 23/10/14
--Descripcion: Actualiza el correlativo de las encomiendas
--exec ID_CorrelativoUpdate 18
--exec ID_CorrelativoGet 16
----------------------------------------------------------------------------

create PROC [dbo].[ID_CorrelativoUpdate]
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

