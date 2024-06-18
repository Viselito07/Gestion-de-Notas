USE [Elvis_NotasDB]
GO
/****** Object:  StoredProcedure [dbo].[SP_CRUD_ESTUDIANTE]    Script Date: 28/05/2024 10:48:50 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- ==============================================================================================================================
-- Author:						ELVIS OÑATE VERA
-- Create date:					28-05-2024
-- Description:					CRUD DE ESTUDIANTES
-- ==============================================================================================================================


CREATE PROCEDURE [dbo].[SP_CRUD_ESTUDIANTE]
(
	@intProceso				        INT,
	@IdEs							INT = NULL,
	@EstudianteNid					NVARCHAR(250), 
	@NombreEstudiante	    		NVARCHAR(250),
    @ApellidoEstudiante		        NVARCHAR(250),
	@FechNacEstudiante	            NVARCHAR(250),
    @DirEstudiante	    			NVARCHAR(250),
	@TelfEstudiante					NVARCHAR(250),
	@EmailEstudiante				NVARCHAR(250) 
)
AS
BEGIN
    SET NOCOUNT ON;
    DECLARE @intRegistros INT

	--1 - SELECT    
	IF @intProceso = 1
		BEGIN
			SELECT
				[IdEs],
				[EstudianteNid],
				[NombreEstudiante],
				[ApellidoEstudiante],
				[FechNacEstudiante],
				[DirEstudiante],
				[TelfEstudiante],
				[EmailEstudiante]
			FROM [Elvis_NotasDB].[dbo].[Estudiante] WITH(NOLOCK)			
    END
	--2 - INSERT 
    IF @intProceso = 2
    BEGIN 
        SELECT TOP 1 @intRegistros = 1
        FROM [Elvis_NotasDB].[dbo].[Estudiante] WITH(NOLOCK)
        WHERE ([EstudianteNid] = @EstudianteNid);

        IF @@ROWCOUNT = 1
        BEGIN
            SELECT 300 AS error
            RETURN
        END

       BEGIN TRANSACTION
			INSERT INTO [Elvis_NotasDB].[dbo].[Estudiante]
			(
				EstudianteNid,
				NombreEstudiante,
				ApellidoEstudiante,
				FechNacEstudiante,
				DirEstudiante,
				TelfEstudiante,
				EmailEstudiante
			)
			VALUES
			(
                @EstudianteNid,
                @NombreEstudiante,
                @ApellidoEstudiante,
                @FechNacEstudiante,
				@DirEstudiante,
				@TelfEstudiante,
				@EmailEstudiante
			)
       COMMIT TRANSACTION 
    END
	--3 - UPDATE
    IF @intProceso = 3
    BEGIN
		  BEGIN TRANSACTION 
				UPDATE [Elvis_NotasDB].[dbo].[Estudiante]
				SET
					[NombreEstudiante] = @NombreEstudiante,
					[ApellidoEstudiante] = @ApellidoEstudiante,
					[FechNacEstudiante] = @FechNacEstudiante,
					[DirEstudiante] = @DirEstudiante,
					[TelfEstudiante] = @TelfEstudiante,
					[EmailEstudiante] = @EmailEstudiante
                WHERE ([EstudianteNid] = @EstudianteNid);
		  COMMIT TRANSACTION
    END
	--4 - DELETE
	IF @intProceso = 4
    BEGIN
		DELETE FROM [Elvis_NotasDB].[dbo].[Estudiante]
        WHERE ([EstudianteNid] = @EstudianteNid);
    END

	--5 CONSULTAR POR ID
	IF @intProceso = 5
		BEGIN
			SELECT
				[IdEs],
				[EstudianteNid],
				[NombreEstudiante],
				[ApellidoEstudiante],
				[FechNacEstudiante],
				[DirEstudiante],
				[TelfEstudiante],
				[EmailEstudiante]
			FROM [Elvis_NotasDB].[dbo].[Estudiante] WITH(NOLOCK)
			WHERE EstudianteNid = @EstudianteNid
    END
END