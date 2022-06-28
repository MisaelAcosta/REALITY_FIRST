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

go

Insert into Evento (IdEvento,evento,lugar,fechaEvento,idArtista,tipoEvento) values (1,'MOVISTAR ARENA','Santiago','05/01/2022',1,'estadio'); 
Insert into Evento (IdEvento,evento,lugar,fechaEvento,idArtista,tipoEvento) values (2,'EstadioNacional','Santiago','15/01/2022',2,'estadio');
Insert into Evento (IdEvento,evento,lugar,fechaEvento,idArtista,tipoEvento) values (3,'MOVISTAR ARENA','Santiago','16/04/2022',3,'estadio');
Insert into Evento (IdEvento,evento,lugar,fechaEvento,idArtista,tipoEvento) values (4,'Teatro Caopolican','Santiago','08/12/2022',4,'teatro');
Insert into Evento (IdEvento,evento,lugar,fechaEvento,idArtista,tipoEvento) values (5,'MOVISTAR ARENA','Santiago','05/01/2022',5,'estadio');
Insert into Evento (IdEvento,evento,lugar,fechaEvento,idArtista,tipoEvento) values (6,'Teatro Cariola','Santiago','16/12/2022',6,'teatro');

