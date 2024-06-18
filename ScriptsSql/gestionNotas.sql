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
SET IDENTITY_INSERT Estudiante OFF


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
SET IDENTITY_INSERT Docente OFF

SELECT * FROM Docente



CREATE TABLE Grado(
Idg INT IDENTITY PRIMARY KEY not null,
NombreG nvarchar(20))


SET IDENTITY_INSERT Grado ON
INSERT INTO Grado([NombreG]) VALUES ('SEXTO-B')
SET IDENTITY_INSERT Grado OFF

SELECT * FROM Grado


CREATE TABLE Materia(
Idm INT IDENTITY PRIMARY KEY not null,
NombreM nvarchar(20))

ALTER TABLE Materia
ADD DocenteNid NVARCHAR(150);

ALTER TABLE Materia
ADD CONSTRAINT FK_Materia_Docente
FOREIGN KEY (DocenteNid) REFERENCES Docente(DocenteNid);

SELECT * FROM Materia


ALTER TABLE Materia
ADD Idg INT;

ALTER TABLE Materia
ADD CONSTRAINT FK_Materia_Grado
FOREIGN KEY (Idg) REFERENCES Grado(Idg);


SELECT d.NombresDocente, m.NombreM FROM Materia m INNER JOIN Docente d ON m.DocenteNid = d.DocenteNid 
