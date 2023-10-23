use dbcoffeeshop
go

select * from dbo.Account

create procedure GetAccountWithPara @Name1 nvarchar(100), @Name2 nvarchar(100)
as
begin
	select * from dbo.Account
	where (UserName = @Name1) or (UserName = @Name2) 
end
go

Exec dbo.GetAccountWithPara @Name1 = 'David123', @Name2 = 'PeterABC'

select * from dbo.Account
where UserName = N'David123' and UserPassWord = N'123456'

--thêm bill
INSERT dbo.Bill
(DateCheckIn, DateCheckOut, IDTable, StatusBill)
values (GETDATE(), null, 30, 0)
--thêm bill infor
INSERT dbo.BillInfo
(IDBill, IDProduct, Quantity)
values (2, 'CHESE01', 1)

INSERT dbo.BillInfo
(IDBill, IDProduct, Quantity)
values (3, 'CHESE02', 1)

INSERT dbo.BillInfo
(IDBill, IDProduct, Quantity)
values (2, 'TEA01', 1)


SELECT * FROM dbo.Product
SELECT * FROM dbo.FoodCategory
SELECT * FROM dbo.DrinkCategory
SELECT * FROM dbo.Bill
SELECT * FROM dbo.BillInfo
select * from dbo.TableCustomer

--hiển thị idbill có idtable là 5 và chưa thanh toán
select * from dbo.Bill


select * from dbo.BillInfo
where IDBill = 3

select a.NameProduct, a.TypeOfProduct, b.Quantity, c.PriceDrink, d.PriceFoodCategory 
from dbo.Product a, dbo.BillInfo b, dbo.DrinkCategory c, dbo.FoodCategory d, dbo.Bill e
where (a.IDProduct = b.IDProduct) and ((a.IDDrinkCategory = c.IDDrinkCategory)
		and (a.IDFoodCategory = D.IDFoodCategory)) and (b.IDBill = e.IDBill) and (e.StatusBill = 0) and (e.IDTable = 25)

select TypeOfProduct, IDDrinkCategory, IDFoodCategory from dbo.Product

create proc dbo.GetProductInfoByIDCategory @ID nvarchar(100)
as
begin
	select a.NameProduct ,c.IDFoodCategory, c.PriceFoodCategory, b.IDDrinkCategory, b.PriceDrink
	from dbo.Product a, dbo.DrinkCategory b, dbo.FoodCategory c
	where ((a.TypeOfProduct = 'FOOD') and (a.IDFoodCategory = c.IDFoodCategory) and (a.IDFoodCategory = @ID))
		or ((a.TypeOfProduct = 'DRINK') and (a.IDDrinkCategory = b.IDDrinkCategory) and (a.IDDrinkCategory = @ID))
end
go
exec dbo.GetProductInfoByIDCategory @ID = N'CHESE'

select a.NameProduct ,c.IDFoodCategory, c.PriceFoodCategory, b.IDDrinkCategory, b.PriceDrink
	from dbo.Product a, dbo.DrinkCategory b, dbo.FoodCategory c
	where ((a.TypeOfProduct = 'FOOD') and (a.IDFoodCategory = c.IDFoodCategory) and (a.IDFoodCategory = 'CHESE'))
		or ((a.TypeOfProduct = 'DRINK') and (a.IDDrinkCategory = b.IDDrinkCategory) and (a.IDDrinkCategory = 'CHESE'))

select  a.NameProduct, b.IDDrinkCategory, b.PriceDrink
from dbo.Product a, dbo.DrinkCategory b
where (a.IDDrinkCategory = b.IDDrinkCategory) and (a.IDDrinkCategory = 'CFE01')

select distinct b.PriceDrink, b.IDDrinkCategory, b.NameDrinkCategory from dbo.Product a, dbo.DrinkCategory b
where (b.IDDrinkCategory = a.IDDrinkCategory) 
	and (a.IDDrinkCategory != '---') --vì '---' là value cho record của food


--lấy all thông tin từ bảng drinkcate
select * from dbo.DrinkCategory
where (IDDrinkCategory != '---')

--LẤY THÔNG TIN ID, TÊN VÀ GIÁ THỨC UỐNG
select a.IDProduct, a.NameProduct, b. PriceDrink from Product a, DrinkCategory b
where (a.IDDrinkCategory = b.IDDrinkCategory) and (b.PriceDrink != 0) and (a.IDDrinkCategory != '---')
--NẾU GIÁ = 0 THÌ LÀ CỦA FOOD
--cái truyền vào là b.IDDrinkCategory lấy từ việc truy vấn IDDrinkCategory

select * from dbo.FoodCategory
where (IDFoodCategory != '---')

select distinct c.TypeOfProduct, a.IDDrinkCategory, b.IDFoodCategory from dbo.DrinkCategory a, dbo.FoodCategory b, dbo.Product c
where ((a.IDDrinkCategory = c.IDDrinkCategory) AND (b.IDFoodCategory = c.IDDrinkCategory))
		and (a.IDDrinkCategory != '---') and (b.IDFoodCategory != '---')

select a.NameProduct, a.TypeOfProduct, b.IDFoodCategory, c.IDDrinkCategory, b.PriceFoodCategory, c.PriceDrink 
from dbo.Product a, dbo.FoodCategory b, dbo.DrinkCategory c
where (a.IDFoodCategory = b.IDFoodCategory) and (a.IDDrinkCategory = C.IDDrinkCategory)


--truy vấn category (food/drink), phải phân biệt type để lưu id, price


	
--TẠM THỜI ĐẨY DRINK LÊN THỬ NGHIỆM TRƯỚC
select distinct * from dbo.DrinkCategory a, dbo.FoodCategory b
where (a.IDDrinkCategory != '---') and (b.IDFoodCategory != '---')
--đã đẩy lên id, name và price cate


--kết quả sẽ chứa ID, NAME, TYPE, Price của Product --chốt
select distinct c.IDProduct, C.NameProduct, c.TypeOfProduct, a.PriceDrink, b.PriceFoodCategory
from  dbo.Product c, dbo.DrinkCategory a, dbo.FoodCategory b
where (a.IDDrinkCategory = c.IDDrinkCategory) and (b.IDFoodCategory = C.IDFoodCategory)

--tạm thời chỉ đưa drink lên
select distinct c.IDProduct, c.NameProduct, c.TypeOfProduct, a.PriceDrink, a.IDDrinkCategory
from  dbo.Product c, dbo.DrinkCategory a
where (c.IDDrinkCategory = 'CFE01') and (C.IDDrinkCategory = a.IDDrinkCategory)

select distinct * from dbo.DrinkCategory a
where (a.IDDrinkCategory != '---')


--vừa đưa drink + food
select distinct c.IDProduct, c.NameProduct, c.TypeOfProduct, a.PriceDrink, 
			a.IDDrinkCategory, b.IDFoodCategory, b.PriceFoodCategory
from  dbo.Product c, dbo.DrinkCategory a, dbo.FoodCategory b
where (c.IDDrinkCategory = a.IDDrinkCategory)
and (c.IDFoodCategory = B.IDFoodCategory) AND ((B.IDFoodCategory = 'CHESE') or (A.IDDrinkCategory = 'CHESE'))

--vừa đưa drink + food
select distinct c.TypeOfProduct, a.PriceDrink, 
			a.IDDrinkCategory, b.IDFoodCategory, b.PriceFoodCategory
from  dbo.Product c, dbo.DrinkCategory a, dbo.FoodCategory b
where (c.IDDrinkCategory = a.IDDrinkCategory)
and (c.IDFoodCategory = B.IDFoodCategory) 

select Max(IDBill) from dbo.Bill

select * from Bill
select * from BillInfo


UPDATE dbo.Bill set StatusBill = 1 where IDBill = 1


create trigger UpdateBillInfo