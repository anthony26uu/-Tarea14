create table Peliculas(
PeliculaId int identity(1,1) primary key,
Nombre varchar(80),
PeliculaEstreno DateTime,
Actor varchar(80),
ActorId int
);

create table Actores(
ActorId int identity(1,1) primary key,
Nombre varchar(80)
);

create table  [dbo].[PeliculasActores] (
    [PeliculaId] INT NOT NULL,
    [ActorId]    INT NOT NULL,
    CONSTRAINT [PK_dbo.PeliculasCategorias] PRIMARY KEY CLUSTERED ([PeliculaId] ASC, [ActorId] ASC),
    CONSTRAINT [FK_dbo.PeliculasCategorias_dbo.Categorias_PeliculaId] FOREIGN KEY ([PeliculaId]) REFERENCES [dbo].[Actores] ([ActorId]) ON DELETE CASCADE,
    CONSTRAINT [FK_dbo.PeliculasCategorias_dbo.Peliculas_CategoriaId] FOREIGN KEY ([ActorId]) REFERENCES [dbo].[Peliculas] ([PeliculaId]) ON DELETE CASCADE
);