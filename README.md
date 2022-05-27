<h1>O bd é esse</h1>

create table usuario(
	id serial primary key,
	nome varchar(60),
	login varchar(10),
	senha varchar(10),
	status char(1)
);

create table local(
	id serial primary key,
	nomelocal varchar(60),
	descricaolocal varchar(300)
);

create table departamento(
	id serial primary key,
	nomedepartamento varchar(60),
	descricaodepartamento varchar(300),
	idlocal int,
	foreign key (idlocal) references local(id)
);

create table categoria(
	id serial primary key,
	descricaocategoria varchar(60)
);

create table fornecedor(
	id serial primary key,
	nomefornecedor varchar(60),
	endereco varchar(100),
	fone varchar(14)
);

create table patrimonio(
	id serial primary key,
	numetiqueta varchar(30),
	nomepatrimonio varchar(60),
	descricaopatrimonio varchar(300),
	valorpatrimonio numeric(12,2),
	idcategoria int,
	idlocal int,
	iddepartamento int,
	marcamodelo varchar(100),
	dataaquisicao date,
	databaixa date,
	foreign key (idcategoria) references categoria(id),
	foreign key (idlocal) references local(id),
	foreign key (iddepartamento) references departamento(id)
);
