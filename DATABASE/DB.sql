use dm5
go
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

CREATE TABLE FoodCategory
(
	IDFoodCategory nvarchar(100) PRIMARY KEY,
	NameFoodCategory NVARCHAR(100) NOT NULL DEFAULT N'Unnamed',
	PriceFood float not null
)
GO

CREATE TABLE Food
(
	IDFood nvarchar(100) PRIMARY KEY,
	NameFood NVARCHAR(100) NOT NULL DEFAULT N'Unnamed',
	IDFoodCategory nvarchar(100) NOT NULL

	FOREIGN KEY (IDFoodCategory) REFERENCES dbo.FoodCategory(IDFoodCategory)
)
GO

CREATE TABLE DrinkCategory
(
	IDDrinkCategory nvarchar(100) not null,
	NameDrinkCategory NVARCHAR(100) NOT NULL DEFAULT N'Unnamed',
	SizeOfDrink nvarchar(100) not null,
	Price float not null default 0

	primary key (IDDrinkCategory, SizeOfDrink)

)
GO

CREATE TABLE Drink
(
	IDDrink nvarchar(100) PRIMARY KEY,
	NameDrink NVARCHAR(100) NOT NULL DEFAULT N'Unnamed',
	IDDrinkCategory nvarchar(100) NOT NULL,
	SizeOfDrink nvarchar(100) not null,

	FOREIGN KEY (IDDrinkCategory, SizeOfDrink) REFERENCES dbo.DrinkCategory(IDDrinkCategory, SizeOfDrink)
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
	IDFood nvarchar(100) NOT NULL,
	IDDrink nvarchar(100) NOT NULL,
	Quantity INT NOT NULL DEFAULT 0

	FOREIGN KEY (IDBill) REFERENCES dbo.Bill(IDBill),
	FOREIGN KEY (IDFood) REFERENCES dbo.Food(IDFood),
	FOREIGN KEY (IDDrink) REFERENCES dbo.Drink(IDDrink)
)
GO

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

CREATE TABLE Salary
(
	Position nvarchar(100) primary key,
	BaseSalary float not null
)
go

--tạo procedure để insert bill
create proc dbo.InsertBill
@idTable int
as
begin
		insert into dbo.Bill
					(	DateCheckIn,
						DateCheckOut,
						IDTable,
						StatusBill
					)
			values	(	getdate(), --thời điểm thêm bill
						NULL,
						@idTable, --id lấy từ việc click vào button
						0 --mặc định
					)
end
go

--EXEC dbo.InsertBill @idTable = ...

create proc dbo.InsertBillDetailInfo
@idBill int, @idProduct nvarchar(100), @quantity int --quantily đc tạo ra lúc thêm món
as
begin
	insert into dbo.BillInfo
					(	IDBill,
						IDProduct,
						Quantity
					)
			values	(	@idBill,
						@idProduct,
						@quantity
					)
end
go
--exec dbo.InsertBillDetailInfo @idBill , @idProduct , @quantity

--trường hợp table đã tồn tại Bill
alter proc dbo.InsertBillDetailInfo
@idBill int, @idProduct nvarchar(100), @quantity int --quantily đc tạo ra lúc thêm món
as
begin
--check bill đã tồn tại chưa?? nếu có thì check xem product đã có trong billinfo chưa??
	declare @isExistBill int;
	declare @availableQuantity int;
	--check xem bill đã tồn tại chưa? tức là trong 1 ds bill có sẵn, có id nào trùng với @idbill đưa vào hay không?
	--sau đó sẽ kiểm tra đã tồn tại product sẽ đưa vào chưa?
	--trong trường hợp này, sẽ đếm số record với điều kiện là IDBill = @idBill và IDProduct = @idProduct
	--ở đây gộp 2 tiến kiểm tra bill và product thành 1
	select @isExistBill = IDBill, @availableQuantity = a.Quantity from dbo.BillInfo a where IDBill = @idBill and IDProduct = @idProduct

	if (@isExistBill > 0) --tức là đã có product tồn tại sẵn trong billinfo rồi!
	--sẽ tiến hành cập nhật số lượng cho product đó trong billinfo!
	begin
		declare @newQuantity int = @availableQuantity + @quantity --tiến hành kiểm tra số lượng trước khi cập nhật
		--nếu như số lượng cập nhật > 0, sẽ tiến hành cập nhật 'chính thức'
		if (@newQuantity > 0)
		begin
			update dbo.BillInfo set Quantity = Quantity + @quantity where IDProduct = @idProduct
		--ngược lại, nếu như số lượng cập nhật < 0, sẽ xóa luôn product đang có đó ra khỏi billinfo
		end
		else
		begin
			delete dbo.BillInfo where idBill = @idBill and IDProduct = @idProduct 
		end

	end
	else --ngược lại, sẽ tiến hành cập nhật BillInfo tương ứng với thông tin product mới đưa vào
	begin
		insert into dbo.BillInfo
						(	IDBill,
							IDProduct,
							Quantity
						)
				values	(	@idBill,
							@idProduct,
							@quantity
						)
	end
end
go


--MUỐN BILLINFO thay đổi thì bill phải thay đổi trươc
create trigger UpdateBillInfo --> đổi từ 'trống' -> 'có người'
on dbo.BillInfo for insert, update --thêm món mới
as
begin
	--mỗi khi insert sẽ thực hiện đoạn này 
	--###############
	declare @idBill int

	select @idBill = IDBill from Inserted --bảng ảo

	declare @idTable int

	select @idTable = IDTable from dbo.Bill where IDBill = @idBill and StatusBill = 0

	update dbo.TableCustomer set StatusTable = N'Có người' where IDTable = @idTable
	--###############
end
go

alter trigger dbo.UpdateBill --> có người -> trống
on dbo.Bill for update --không cần insert, vì mỗi lần insert đã kéo theo insert ở billinfo (đã tạo trigger rồi!)
as
begin
	declare @idBill int

	select @idBill = IDBill from inserted

	declare @idTable int

	select @idTable = IDTable from dbo.Bill where IDBill = @idBill

	declare @count int = 0

	--count sẽ đếm số bàn mà ở đó bill chưa được thanh toán
	--nếu count > 0 thì sẽ tồn tại bill chưa thanh toán -> bàn có người
	select @count = count(*) from dbo.Bill where IDTable = @idTable and StatusBill = 0

	if (@count = 0) -- nếu count = 0 thì sẽ không có người
		update dbo.TableCustomer set StatusTable = N'Trống' where IDTable = @idTable
end
go

delete dbo.BillInfo
delete dbo.Bill