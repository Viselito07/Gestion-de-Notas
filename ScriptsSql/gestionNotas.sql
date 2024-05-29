use Elvis_NotasDB

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
Insert into Estudiante(IdEs,[EstudianteNid],[NombreEstudiante],[ApellidoEstudiante],[FechNacEstudiante],[DirEstudiante],[TelfEstudiante],[EmailEstudiante]) values (1,'1065633056', 'Elvis', 'Oñate','07/10/91','mz10cs10','3155733996','egonate@unicesar.edu.co');

SELECT * FROM Estudiante