USE Elvis_NotasDB

CREATE TABLE Estudiante (
IdEs int identity not null,
EstudianteNid nvarchar(250) primary key,
NombreEstudiante nvarchar(250),
ApellidoEstudiante nvarchar(250),
FechNacEstudiante nvarchar(250),
DirEstudiante nvarchar(250),
TelfEstudiante nvarchar(250),
EmailEstudiante nvarchar(250)
)

SET IDENTITY_INSERT Estudiante ON
INSERT INTO Estudiante(IdEs,[EstudianteNid],[NombreEstudiante],[ApellidoEstudiante],[FechNacEstudiante],[DirEstudiante],[TelfEstudiante],[EmailEstudiante]) values (1,'1065633056', 'Elvis', 'Oñate','07/10/91','mz10cs10','3155733996','egonate@unicesar.edu.co');

SELECT * FROM Estudiante


CREATE TABLE Docente (
IdDoc int identity not null,
DocenteNid nvarchar(150) primary key,
NombresDocente nvarchar(150),
ApellidosDocente nvarchar(150),
FechaNacDocente nvarchar(150),
DirDocente nvarchar(150),
Especialidad nvarchar(150),
TelfDocente nvarchar(150),
)

SET IDENTITY_INSERT Docente ON
INSERT INTO Docente(IdDoc,[DocenteNid],[NombresDocente],[ApellidosDocente],[FechaNacDocente],[DirDocente],[Especialidad],[TelfDocente]) values (1,'1065456789', 'juan', 'morales','10/02/1986','mz10cs10','Ciencias Sociales','3155733996');

SELECT * FROM Docente