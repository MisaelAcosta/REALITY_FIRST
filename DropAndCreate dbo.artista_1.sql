USE [RealityFirst]
GO

/****** Objeto: Table [dbo].[artista] Fecha del script: 28-06-2022 11:37:56 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

DROP TABLE [dbo].[artista];


GO
CREATE TABLE [dbo].[artista] (
    [IdArtista]        INT          NOT NULL,
    [Artista]          VARCHAR (50) NOT NULL,
    [lugar_nacimiento] VARCHAR (50) NOT NULL,
    [fechaNac]         VARCHAR (50) NOT NULL,
    [edad]             INT          NOT NULL,
    [genero]           VARCHAR (50) NOT NULL
);

go 

Insert into artista (IdArtista, Artista, lugar_nacimiento, fechaNac, edad, genero) values (1,'DEAD MAUS5','Niagara falls Canada','05/01/1981',41,'Electro');
Insert into artista (IdArtista, Artista, lugar_nacimiento, fechaNac, edad, genero) values (2,'COREY TAYLOR','Des moines','08/12/1973',49,'Metal');
Insert into artista (IdArtista, Artista, lugar_nacimiento, fechaNac, edad, genero) values (3,'MONCHITO','La vencidad, Mexico','05/01/1971',30,'Ranchera');
Insert into artista (IdArtista, Artista, lugar_nacimiento, fechaNac, edad, genero) values (4,'MYKE TOWERS','Valparaiso, Chile','15/01/1994',28,'Rap');
Insert into artista (IdArtista, Artista, lugar_nacimiento, fechaNac, edad, genero) values (5,'Steven Wilson','Londres, Inglaterra','03/11/1967',54,'Metal progresivo');
Insert into artista (IdArtista, Artista, lugar_nacimiento, fechaNac, edad, genero) values (6,'Ludwig van Beethoven','Viena','16/12/1770',57,'Opera clasica');

