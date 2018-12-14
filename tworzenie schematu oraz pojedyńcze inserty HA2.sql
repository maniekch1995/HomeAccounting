create schema HA2 

create table HA2.Payments
(
	IdPayment int identity(1,1) primary key (IdPayment),
	ValuePayment decimal(10,2),
	DatePayment datetime,
	ShopName varchar(200),
	PlaceName varchar(200),
	TypeName varchar(200),
	Tmstmp datetime default getdate()
)

insert into HA2.Payments values (100.00,getdate(),NULL,NULL,'Wydatki na auto',getdate())


create table HA2.Incomes
(
	IdIncomes int identity(1,1),
	Primary key (IdIncomes),
	ValueOfIncome decimal(10,2),
	NameIncome varchar(200),
	TypeIncome varchar(200)
)

insert into HA2.Incomes values (4000,'Wyp³ata','Przychody miesiêczne')