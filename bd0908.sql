create database DB0908
use DB0908

create table tbUsuario(
    codUsuario int primary key,
    nomeUsuario varchar(50),
    endUsuario varchar(50),
    telUsuario varchar(50)
)

create table tbGenero(
    codGenero int primary key,
    genero varchar(50)
)

create table tbAutor(
    codAutor int primary key,
    autor varchar(50)
)

create table tbLivro(
    codLivro int primary key,
    nomeLivro varchar(50),
    codGenero int references tbGenero(codGenero),
    codAutor int references tbAutor(codAutor)
)

select * from tbUsuario
select * from tbAutor
select * from tbLivro