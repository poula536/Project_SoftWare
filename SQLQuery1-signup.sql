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


select * from NewUser
