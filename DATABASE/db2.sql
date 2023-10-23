USE dbcoffeeshop
GO
-- Food
-- Table
-- FoodCategory
-- Account
-- Bill
-- BillInfo
CREATE TABLE TableCustomer
(
	IDTable INT IDENTITY PRIMARY KEY,
	NameTable NVARCHAR(100) NOT NULL DEFAULT N'Unnamed',
	StatusTable NVARCHAR(100) NOT NULL DEFAULT N'Was not occuiped' -- was occuiped || was not occuiped || was booked
)
GO

CREATE TABLE Account
(
	UserName NVARCHAR(100) PRIMARY KEY,
	DisplayName NVARCHAR(100) NOT NULL DEFAULT N'Noname',
	UserPassWord NVARCHAR(1000) NOT NULL DEFAULT 0,
	TypeOffUser INT NOT NULL DEFAULT 0 -- 1: admin && 0: staff
)

GO
CREATE TABLE DrinkCategory
(
	IDDrinkCategory nvarchar(100) primary key,
	NameDrinkCategory NVARCHAR(100) NOT NULL DEFAULT N'Unnamed',
	PriceDrink float not null default 0
)
GO

CREATE TABLE FoodCategory
(
	IDFoodCategory nvarchar(100) primary key,
	NameFoodCategory NVARCHAR(100) NOT NULL DEFAULT N'Unnamed',
	PriceFoodCategory float not null default 0
)
GO

CREATE TABLE Product
(
	IDProduct nvarchar(100) PRIMARY KEY,
	NameProduct NVARCHAR(100) NOT NULL DEFAULT N'Unnamed',
	TypeOfProduct NVARCHAR(100) NOT NULL DEFAULT N'---',
	IDFoodCategory NVARCHAR(100) NOT NULL DEFAULT N'---',
	IDDrinkCategory NVARCHAR(100) NOT NULL DEFAULT N'---'

	foreign key (IDFoodCategory) references dbo.FoodCategory(IDFoodCategory),
	foreign key (IDDrinkCategory) references dbo.DrinkCategory(IDDrinkCategory)
)
GO


CREATE TABLE Bill
(
	IDBill INT IDENTITY PRIMARY KEY,
	DateCheckIn DATE NOT NULL DEFAULT GETDATE(),
	DateCheckOut DATE,
	IDTable INT NOT NULL,
	StatusBill INT NOT NULL DEFAULT 0 -- 1: paid && 0: unpaid
	FOREIGN KEY (IdTable) REFERENCES dbo.TableCustomer(IDTable)
)
GO

CREATE TABLE BillInfo
(
	id INT IDENTITY PRIMARY KEY,
	IDBill INT NOT NULL,
	IDProduct nvarchar(100) NOT NULL,
	Quantity INT NOT NULL DEFAULT 0

	FOREIGN KEY (IDBill) REFERENCES dbo.Bill(IDBill),
	FOREIGN KEY (IDProduct) REFERENCES dbo.Product(IDProduct)
)
GO

CREATE TABLE Salary
(
	Position nvarchar(100) primary key,
	BaseSalary float not null
)
go

CREATE TABLE Employee
(
	IDEmoloyee nvarchar(100) primary key,
	NameEmployee nvarchar(100) not null,
	PhoneEmployee nvarchar(100),
	GenderEmployee nvarchar(100),
	Position nvarchar(100)

	FOREIGN KEY (Position) REFERENCES dbo.Salary(Position)
)
go

--tạo tên bàn theo biến @numberTable
Declare @numberTable int = 1

while @numberTable <= 10
begin
	insert dbo.TableCustomer (NameTable) values (N'Bàn ' + cast(@numberTable as nvarchar(100)))
	set @numberTable = @numberTable + 1
end
go

create proc GetTableList
as select * from dbo.TableCustomer
go

update dbo.TableCustomer set StatusTable = N'Có người' where IDTable = 25
exec dbo.GetTableList 
