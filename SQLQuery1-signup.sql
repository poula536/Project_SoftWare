use NewAcount
Go
create table NewUser
(
	Id int primary key identity(1,1),
	FullName nvarchar(50) Not null,
	Email nvarchar(50),
	City nvarchar(50),
	Password nvarchar(50) not null,
	ConfirmPassword nvarchar(50) not null,
);
create table Products
(
	Product_id int primary key identity(1,1),
	Product_Name nvarchar(50) Not null,
	Product_price numeric(7,2) not null,
	quantity int not null
);
drop table Products

create table Order_Items
(
	order_id int primary key identity(1,1),
	item_id int,
	NewUser_id int,
	order_date Date,
	Product_id int,

	constraint order_fk_products foreign key (Product_id)
	references Products(Product_id),

	constraint order_fk_newuser foreign key (NewUser_id)
	references NewUser(Id)
);

insert into Products values
('Piqué Biker Jacket',67.24,1),
('Piqué Biker Jacket',43.48,5),
('Multi-pocket Chest Bag',60.9,5),
('Diagonal Textured Cap',31.37,1),
('Lether Backpack',98.49,1),
('Ankle Boots',49.66,1),
('T-shirt Contrast Pocket',26.28,6),
('Basic Flowing Scarf',26.28,1);

select * from Products

alter table 
add  int;