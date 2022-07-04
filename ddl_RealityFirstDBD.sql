
USE [RealityFirst]
GO

/****** Objeto: Table [dbo].[ticket] Fecha del script: 28-06-2022 11:35:19 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

DROP TABLE [dbo].[ticket];


GO
CREATE TABLE [dbo].[ticket] (
    [Idticket]  INT          NOT NULL,
    [tipo]      VARCHAR (50) NOT NULL,
    [Espacio]   VARCHAR (50) NOT NULL,
    [precio]    INT          NOT NULL,
    [idArtista] INT          NOT NULL
);

UUSE [RealityFirst]
GO

/****** Objeto: Table [dbo].[noticia] Fecha del script: 28-06-2022 11:33:32 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

DROP TABLE [dbo].[noticia];


GO
CREATE TABLE [dbo].[noticia] (
    [IdNoticia]         INT           NOT NULL,
    [titulo]            VARCHAR (100) NOT NULL,
    [Subtitulo]         VARCHAR (200) NOT NULL,
    [Autor]             VARCHAR (50)  NOT NULL,
    [fecha_publicacion] VARCHAR (50)  NOT NULL,
    [noticia]           VARCHAR (500) NOT NULL,
    [idArtista]         INT           NOT NULL
);


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

 
USE [RealityFirst]
GO

/****** Objeto: Table [dbo].[Evento] Fecha del script: 28-06-2022 11:38:27 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

DROP TABLE [dbo].[Evento];


GO
CREATE TABLE [dbo].[Evento] (
    [IdEvento]    INT          NOT NULL,
    [evento]      VARCHAR (50) NOT NULL,
    [lugar]       VARCHAR (50) NOT NULL,
    [fechaEvento] VARCHAR (50) NOT NULL,
    [idArtista]   INT          NOT NULL,
    [tipoEvento]  VARCHAR (50) NOT NULL
);


Insert into artista (IdArtista, Artista, lugar_nacimiento, fechaNac, edad, genero) values (1,'DEAD MAUS5','Niagara falls Canada','05/01/1981',41,'Electro');
Insert into artista (IdArtista, Artista, lugar_nacimiento, fechaNac, edad, genero) values (2,'COREY TAYLOR','Des moines','08/12/1973',49,'Metal');
Insert into artista (IdArtista, Artista, lugar_nacimiento, fechaNac, edad, genero) values (3,'MONCHITO','La vencidad, Mexico','05/01/1971',30,'Ranchera');
Insert into artista (IdArtista, Artista, lugar_nacimiento, fechaNac, edad, genero) values (4,'MYKE TOWERS','Valparaiso, Chile','15/01/1994',28,'Rap');
Insert into artista (IdArtista, Artista, lugar_nacimiento, fechaNac, edad, genero) values (5,'Steven Wilson','Londres, Inglaterra','03/11/1967',54,'Metal progresivo');
Insert into artista (IdArtista, Artista, lugar_nacimiento, fechaNac, edad, genero) values (6,'Ludwig van Beethoven','Viena','16/12/1770',57,'Opera clasica');


Insert into Evento (IdEvento,evento,lugar,fechaEvento,idArtista,tipoEvento) values (1,'MOVISTAR ARENA','Santiago','05/01/2022',1,'estadio'); 
Insert into Evento (IdEvento,evento,lugar,fechaEvento,idArtista,tipoEvento) values (2,'MOVISTAR ARENA','Santiago','15/01/2022',2,'estadio');
Insert into Evento (IdEvento,evento,lugar,fechaEvento,idArtista,tipoEvento) values (3,'MOVISTAR ARENA','Santiago','16/04/2022',3,'estadio');
Insert into Evento (IdEvento,evento,lugar,fechaEvento,idArtista,tipoEvento) values (4,'MOVISTAR ARENA','Santiago','08/12/2022',4,'estadio');
Insert into Evento (IdEvento,evento,lugar,fechaEvento,idArtista,tipoEvento) values (5,'MOVISTAR ARENA','Santiago','05/01/2022',5,'estadio');
Insert into Evento (IdEvento,evento,lugar,fechaEvento,idArtista,tipoEvento) values (6,'MOVISTAR ARENA','Santiago','16/12/2022',6,'estadio');





Insert into noticia(IdNoticia,titulo,Subtitulo,Autor,fecha_publicacion,noticia,idArtista)values(1,'LLEGA DEAD MAUS A CHILE EN SU GIRA MUNDIAL A MOVISTAR ARENA','El artista tocara las canciones mas reconocida que hara la noche inolvidable para la fanaticada','Nicolas Zamorano','24/06/2022','Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla vitae orci vel ligula convallis ullamcorper. Nam pharetra tortor risus, quis scelerisque enim congue eu. Phasellus at quam elit. Mauris consectetur elit quis tellus mollis sagittis. Mauris iaculis magna a justo venenatis tristique. Sed vitae est cursus, sagittis dolor id, vestibulum.',1);
Insert into noticia(IdNoticia,titulo,Subtitulo,Autor,fecha_publicacion,noticia,idArtista)values(2,'EL FAMOSO CANTANTE DE SLIPKNOT LANZA SINGLE CON MUCHOS CAMEOS','desde marilyn manson hasta las integrantes de BabyMetal el video alcanza mas de 1 millon de reproducciones en 3 horas','Nicolas','24/06/2022','Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla vitae orci vel ligula convallis ullamcorper. Nam pharetra tortor risus, quis scelerisque enim congue eu. Phasellus at quam elit. Mauris consectetur elit quis tellus mollis sagittis. Mauris iaculis magna a justo venenatis tristique. Sed vitae est cursus, sagittis dolor id, vestibulum.',2);
Insert into noticia(IdNoticia,titulo,Subtitulo,Autor,fecha_publicacion,noticia,idArtista)values(3,'SE ESTRENA EL ULTIMO CONCIERTO DE MONCHITO','El video fue tomado el año 2001 antes del fin de la carrera del artista','Nicolas','24/06/2022','Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla vitae orci vel ligula convallis ullamcorper. Nam pharetra tortor risus, quis scelerisque enim congue eu. Phasellus at quam elit. Mauris consectetur elit quis tellus mollis sagittis. Mauris iaculis magna a justo venenatis tristique. Sed vitae est cursus, sagittis dolor id, vestibulum.',3);
Insert into noticia(IdNoticia,titulo,Subtitulo,Autor,fecha_publicacion,noticia,idArtista)values(4,'LLEGA MYKE TOWERS A CLUB HIPICO A LANZAR SU NUEVO SINGLE','El nuevo single que cuenta las dificultades del artista promete conmover a su fanaticada','Nicolas','24/06/2022','Nominado en la categoría Artista del Año de los Latin American Music Awards 2022.
              No te pierdas al imperdible Myke Towers en concierto.',4);
Insert into noticia(IdNoticia,titulo,Subtitulo,Autor,fecha_publicacion,noticia,idArtista)values(5,'PORCUPINE TREE',' regresa la banda para presentar su nuevo disco','Nicolas','24/06/2022','PORCUPINE TREE, una de las bandas más reconocidas y destacadas del rock progresivo y uno de los 
              proyectos más exitosos de Steven Wilson  confirmó el lanzamiento, luego de 12 años, las fechas de su gira que los trae a Chile. ',5);
Insert into noticia(IdNoticia,titulo,Subtitulo,Autor,fecha_publicacion,noticia,idArtista)values(6,'VUELVE BETHOVEEN EN 3D','el legendario compositor bethoveen ','Nicolas','24/06/2022','Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla vitae orci vel ligula convallis ullamcorper. Nam pharetra tortor risus, quis scelerisque enim congue eu. Phasellus at quam elit. Mauris consectetur elit quis tellus mollis sagittis. Mauris iaculis magna a justo venenatis tristique. Sed vitae est cursus, sagittis dolor id, vestibulum.',6);


Insert into ticket (Idticket,tipo,espacio,precio,idArtista)values(1,'platea  alta','teatro',50000,1);
Insert into ticket (IdTicket,tipo,espacio,precio,idArtista)values(2,'platea  baja','teatro',50000,1);
Insert into ticket (IdTicket,tipo,espacio,precio,idArtista)values(3,'cancha general','teatro',50000,1);
Insert into ticket (IdTicket,tipo,espacio,precio,idArtista)values(4,'vip','teatro',50000,1);
Insert into ticket (IdTicket,tipo,espacio,precio,idArtista)values(5,'platea  alta','estadio',50000,3);
Insert into ticket (IdTicket,tipo,espacio,precio,idArtista)values(6,'platea  baja','estadio',50000,3);
Insert into ticket (IdTicket,tipo,espacio,precio,idArtista)values(7,'cancha general','estadio',50000,3);
Insert into ticket (IdTicket,tipo,espacio,precio,idArtista)values(8,'vip','estadio',50000,3);

Insert into ticket (Idticket,tipo,espacio,precio,idArtista)values(9,'platea  alta','teatro',50000,2);
Insert into ticket (IdTicket,tipo,espacio,precio,idArtista)values(10,'platea  baja','teatro',50000,2);
Insert into ticket (IdTicket,tipo,espacio,precio,idArtista)values(11,'cancha general','teatro',50000,2);
Insert into ticket (IdTicket,tipo,espacio,precio,idArtista)values(12,'vip','teatro',80000,2);
Insert into ticket (IdTicket,tipo,espacio,precio,idArtista)values(13,'platea  alta','estadio',50000,4);
Insert into ticket (IdTicket,tipo,espacio,precio,idArtista)values(14,'platea  baja','estadio',50000,4);
Insert into ticket (IdTicket,tipo,espacio,precio,idArtista)values(15,'cancha general','estadio',50000,4);
Insert into ticket (IdTicket,tipo,espacio,precio,idArtista)values(16,'vip','estadio',50000,4);

Insert into ticket (Idticket,tipo,espacio,precio,idArtista)values(17,'platea  alta','teatro',50000,5);
Insert into ticket (IdTicket,tipo,espacio,precio,idArtista)values(18,'platea  baja','teatro',50000,5);
Insert into ticket (IdTicket,tipo,espacio,precio,idArtista)values(19,'cancha general','teatro',50000,5);
Insert into ticket (IdTicket,tipo,espacio,precio,idArtista)values(20,'vip','teatro',50000,5);
Insert into ticket (IdTicket,tipo,espacio,precio,idArtista)values(21,'platea  alta','estadio',50000,6);
Insert into ticket (IdTicket,tipo,espacio,precio,idArtista)values(22,'platea  baja','estadio',50000,6);
Insert into ticket (IdTicket,tipo,espacio,precio,idArtista)values(23,'cancha general','estadio',50000,6);
Insert into ticket (IdTicket,tipo,espacio,precio,idArtista)values(24,'vip','estadio',50000,6);


