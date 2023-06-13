create table Categories (
	id int primary key identity(1,1),
	name varchar(20) not null
)

create table Products (
	id int primary key identity(1,1),
	name varchar(20) not null
)

create table ProductCategories (
	category_id int not null,
	product_id int not null,
	primary key (product_id, category_id),
	foreign key (category_id)  references Categories (id) on delete cascade,
	foreign key (product_id)  references Products (id) on delete cascade
)

insert into Categories values ('Ужасы'), ('Комедия'), ('Боевик')
insert into Products values ('Друзья'), ('Звонок'), ('Проклятие'), ('Очень страшное кино'), ('Форсаж'), ('Титаник')
insert into ProductCategories values (2, 1), (1, 2), (1, 3), (1, 4), (2, 4), (3, 5)

select
	c.name as Category,
	p.name as Product
from ProductCategories pc
join Categories c on pc.category_id = c.id
right join Products p on pc.product_id = p.id