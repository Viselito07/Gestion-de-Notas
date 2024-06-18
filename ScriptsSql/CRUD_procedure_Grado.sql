USE [Elvis_NotasDB]
GO
/****** Object:  StoredProcedure [dbo].[SP_CRUD_GRADO]    Script Date: 07/06/2024 16:25:50 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- ==============================================================================================================================
-- Author:						ELVIS OÑATE VERA
-- Create date:					07-06-2024
-- Description:					CRUD DE GRADO
-- ==============================================================================================================================


ALTER PROCEDURE [dbo].[SP_CRUD_GRADO]
(
	@intProceso				    INT,
	@Idg						INT = NULL,
	@NombreG					NVARCHAR(20)
)
AS
BEGIN
    SET NOCOUNT ON;
    DECLARE @intRegistros INT

	--1 - SELECT    
	IF @intProceso = 1
		BEGIN
			SELECT
				[Idg],
				[NombreG]
			FROM [Elvis_NotasDB].[dbo].[Grado] WITH(NOLOCK)			
    END
	--2 - INSERT 
    IF @intProceso = 2
    BEGIN 
        SELECT TOP 1 @intRegistros = 1
        FROM [Elvis_NotasDB].[dbo].[Grado] WITH(NOLOCK)
        WHERE ([Idg] = @Idg);

        IF @@ROWCOUNT = 1
        BEGIN
            SELECT 300 AS error
            RETURN
        END

       BEGIN TRANSACTION
			INSERT INTO [Elvis_NotasDB].[dbo].[Grado]
			(
				[NombreG]
			)
			VALUES
			(
				@NombreG
			)
       COMMIT TRANSACTION 
    END
	--3 - UPDATE
    IF @intProceso = 3
    BEGIN
		  BEGIN TRANSACTION 
				UPDATE [Elvis_NotasDB].[dbo].[Grado]
				SET
					[NombreG] = @NombreG
                WHERE ([Idg] = @Idg);
		  COMMIT TRANSACTION
    END
	--4 - DELETE
	IF @intProceso = 4
    BEGIN
		DELETE FROM [Elvis_NotasDB].[dbo].[Grado]
        WHERE ([Idg] = @Idg);
    END

	--5 CONSULTAR POR ID
	IF @intProceso = 5
		BEGIN
			SELECT
				[Idg],
				[NombreG]
			FROM [Elvis_NotasDB].[dbo].[Grado] WITH(NOLOCK)
			WHERE Idg = @Idg
    END

	--5 CONSULTAR POR NOMBRE
	IF @intProceso = 6
		BEGIN
			SELECT
				[NombreG]
			FROM [Elvis_NotasDB].[dbo].[Grado] WITH(NOLOCK)
			WHERE NombreG = @NombreG
    END
END