create database dbMercadinhoCarju;

use dbMercadinhoCarju;

create table tbProduto(
Prodid int primary key auto_increment,
Prodnome varchar(100) not null,
Prodpreco decimal (7,2) not null,
Prodqtd int not null,
Proddescr varchar(250)
);

select * from tbProduto;