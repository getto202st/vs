create database productos

use productos

create table producto(
codigoProd int primary key identity,
nombreProd varchar(50) not null,
precioProd money not null,
cantidad int not null)

insert into producto values('Leche',25.00,10)

select * from producto

create procedure sp_mostrar
as
select * from producto

exec sp_mostrar

create procedure sp_insertar(
@nombre varchar(50),
@precio money,
@cantidad int)
as
insert into producto values(@nombre,@precio,@cantidad)

exec sp_insertar 'Jugo Naranja',15.00,10

create procedure sp_eliminar(@codigo int)
as
delete from producto where codigoProd = @codigo

exec sp_eliminar 2

create procedure sp_editar(
@codigo int,
@nombre varchar(50),
@precio money,
@cantidad int)
as
update producto set nombreProd = @nombre, precioProd = @precio, cantidad = @cantidad
where
codigoProd = @codigo

exec sp_editar 3, 'Jugo Limon', 12.00, 15