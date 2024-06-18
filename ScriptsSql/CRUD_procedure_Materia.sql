USE [Elvis_NotasDB]
GO
/****** Object:  StoredProcedure [dbo].[SP_CRUD_MATERIA]    Script Date: 07/06/2024 16:30:50 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- ==============================================================================================================================
-- Author:						ELVIS OÑATE VERA
-- Create date:					07-06-2024
-- Description:					CRUD DE MATERIA
-- ==============================================================================================================================


CREATE PROCEDURE [dbo].[SP_CRUD_MATERIA]
(
	@intProceso				    INT,
	@Idm						INT = NULL,
	@NombreM					NVARCHAR(20)
)
AS
BEGIN
    SET NOCOUNT ON;
    DECLARE @intRegistros INT

	--1 - SELECT    
	IF @intProceso = 1
		BEGIN
			SELECT
				[Idm],
				[NombreM]
			FROM [Elvis_NotasDB].[dbo].[Materia] WITH(NOLOCK)			
    END
	--2 - INSERT 
    IF @intProceso = 2
    BEGIN 
        SELECT TOP 1 @intRegistros = 1
        FROM [Elvis_NotasDB].[dbo].[Materia] WITH(NOLOCK)
        WHERE ([Idm] = @Idm);

        IF @@ROWCOUNT = 1
        BEGIN
            SELECT 300 AS error
            RETURN
        END

       BEGIN TRANSACTION
			INSERT INTO [Elvis_NotasDB].[dbo].[Materia]
			(
				[NombreM]
			)
			VALUES
			(
				@NombreM
			)
       COMMIT TRANSACTION 
    END
	--3 - UPDATE
    IF @intProceso = 3
    BEGIN
		  BEGIN TRANSACTION 
				UPDATE [Elvis_NotasDB].[dbo].[Materia]
				SET
					[NombreM] = @NombreM
                WHERE ([Idm] = @Idm);
		  COMMIT TRANSACTION
    END
	--4 - DELETE
	IF @intProceso = 4
    BEGIN
		DELETE FROM [Elvis_NotasDB].[dbo].[Materia]
        WHERE ([Idm] = @Idm);
    END

	--5 CONSULTAR POR ID
	IF @intProceso = 5
		BEGIN
			SELECT
				[Idm],
				[NombreM]
			FROM [Elvis_NotasDB].[dbo].[Materia] WITH(NOLOCK)
			WHERE Idm = @Idm
    END
END