CREATE TABLE [dbo].[noticia] (
    [IdNoticia]         INT          NOT NULL,
    [titulo]            VARCHAR (100) NOT NULL,
    [Subtitulo]        VARCHAR (200) NOT NULL,
    [Autor]             VARCHAR (50) NOT NULL,
    [fecha_publicacion] VARCHAR (50) NOT NULL,
    [noticia]           VARCHAR (500) NOT NULL,
    [idArtista]         INT          NOT NULL
);
