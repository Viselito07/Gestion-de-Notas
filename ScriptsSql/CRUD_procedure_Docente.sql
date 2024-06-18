USE [Elvis_NotasDB]
GO
/****** Object:  StoredProcedure [dbo].[SP_CRUD_DOCENTE]    Script Date: 31/05/2024 10:48:50 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- ==============================================================================================================================
-- Author:						ELVIS OÑATE VERA
-- Create date:					31-05-2024
-- Description:					CRUD DE DOCENTES
-- ==============================================================================================================================


CREATE PROCEDURE [dbo].[SP_CRUD_DOCENTE]
(
	@intProceso				    INT,
	@IdDoc						INT = NULL,
	@DocenteNid					NVARCHAR(150), 
	@NombresDocente	    		NVARCHAR(150),
    @ApellidosDocente		    NVARCHAR(150),
	@FechaNacDocente	        NVARCHAR(150),
    @DirDocente	    			NVARCHAR(150),
	@Especialidad				NVARCHAR(150),
	@TelfDocente				NVARCHAR(150) 
)
AS
BEGIN
    SET NOCOUNT ON;
    DECLARE @intRegistros INT

	--1 - SELECT    
	IF @intProceso = 1
		BEGIN
			SELECT
				[IdDoc],
				[DocenteNid],
				[NombresDocente],
				[ApellidosDocente],
				[FechaNacDocente],
				[DirDocente],
				[Especialidad],
				[TelfDocente]
			FROM [Elvis_NotasDB].[dbo].[Docente] WITH(NOLOCK)			
    END
	--2 - INSERT 
    IF @intProceso = 2
    BEGIN 
        SELECT TOP 1 @intRegistros = 1
        FROM [Elvis_NotasDB].[dbo].[Docente] WITH(NOLOCK)
        WHERE ([DocenteNid] = @DocenteNid);

        IF @@ROWCOUNT = 1
        BEGIN
            SELECT 300 AS error
            RETURN
        END

       BEGIN TRANSACTION
			INSERT INTO [Elvis_NotasDB].[dbo].[Docente]
			(
				DocenteNid,
				NombresDocente,
				ApellidosDocente,
				FechaNacDocente,
				DirDocente,
				Especialidad,
				TelfDocente
			)
			VALUES
			(
				@DocenteNid,
				@NombresDocente,
				@ApellidosDocente,
				@FechaNacDocente,
				@DirDocente,
				@Especialidad,
				@TelfDocente
			)
       COMMIT TRANSACTION 
    END
	--3 - UPDATE
    IF @intProceso = 3
    BEGIN
		  BEGIN TRANSACTION 
				UPDATE [Elvis_NotasDB].[dbo].[Docente]
				SET
					[NombresDocente] = @NombresDocente,
					[ApellidosDocente] = @ApellidosDocente,
					[FechaNacDocente] = @FechaNacDocente,
					[DirDocente] = @DirDocente,
					[Especialidad] = @Especialidad,
					[TelfDocente] = @TelfDocente
                WHERE ([DocenteNid] = @DocenteNid);
		  COMMIT TRANSACTION
    END
	--4 - DELETE
	IF @intProceso = 4
    BEGIN
		DELETE FROM [Elvis_NotasDB].[dbo].[Docente]
        WHERE ([DocenteNid] = @DocenteNid);
    END

	--5 CONSULTAR POR ID
	IF @intProceso = 5
		BEGIN
			SELECT
				[IdDoc],
				[DocenteNid],
				[NombresDocente],
				[ApellidosDocente],
				[FechaNacDocente],
				[DirDocente],
				[Especialidad],
				[TelfDocente]
			FROM [Elvis_NotasDB].[dbo].[Docente] WITH(NOLOCK)
			WHERE DocenteNid = @DocenteNid
    END

	--5 CONSULTAR 
	IF @intProceso = 6
		BEGIN
			SELECT d.NombresDocente, m.NombreM FROM [Elvis_NotasDB].[dbo].[Materia] m INNER JOIN Docente d ON m.DocenteNid = d.DocenteNid 
    END
END