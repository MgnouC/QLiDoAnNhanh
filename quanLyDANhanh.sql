create database QuanLyBanDoAnNhanh
go

use QuanLyBanDoAnNhanh
go


--table
create table TableFood
(
	id int identity primary key,
	name nvarchar(100) not null default N'Bàn chưa có tên',
	status nvarchar(100) not null default N'Trống' --trống || có người

)
go


--category
create table FoodCategory
(
	id int identity primary key,
	name nvarchar(100) not null default N'Chưa đặt tên'
)
GO
--food
create table Food
(
	id int identity primary key,
	name nvarchar(100) NOT NULL default N'Chưa đặt tên',
	idCategory int NOT NULL,
	price float not null default 0,

	
	FOREIGN KEY (idCategory) references FoodCategory(id)
)
GO
--account
create table Account
(
	UserName nvarchar(100) primary key ,
	DisplayName nvarchar(100) NOT NULL default N'TramTram',
	PassWord nvarchar(1000) NOT NULL default 0,
	Type int NOT NULL default 0 --1:admin 0:nhanvien
)
GO
--bill
create table Bill
(
	id int identity primary key,
	DateCheckIn Date not null default getdate(),
	DateCheckOut date,
	idTable int not null,
	status int not null --1: đã thanh toán , 0: chưa thanh toán

	foreign key (idTable) references dbo.TableFood(id)

)
GO
--billInfo 
create table BillInfo
(
	id int identity primary key,
	idBill int not null,
	idFood int not null,
	count int not null default 0

	foreign key (idBill) references dbo.Bill(id),
	foreign key (idFood) references dbo.Food(id)


)
go

insert into Account values (N'TramTram', N'HTram', N'123', 1)
insert into Account values (N'TrTram', N'HTramm', N'123', 0)

select * from Account

create proc USP_GetAccountByUserName
@userName nvarchar(100)
AS
begin
	select * from Account where UserName = @userName
end
go 

exec dbo.USP_GetAccountByUserName @userName = N'TrTram'

create proc USP_Login
@userName nvarchar(100), @passWord nvarchar(100)
as
begin
	select * from dbo.Account WHERE UserName = @userName AND PassWord = @passWord
end
go

declare @i int = 0
while @i <= 10
begin
	insert dbo.TableFood (name) values (N'Bàn ' + Cast (@i as nvarchar(100)))
	set @i = @i + 1

	end

	select * from TableFood


create proc USP_GetTableList
as select * from dbo.TableFood
go
exec dbo.USP_GetTableList
insert into TableFood(name) values (N'Bàn 11')

insert into FoodCategory ( name) values ( N'Pizza')
insert into FoodCategory ( name) values ( N'Gà rán')
insert into FoodCategory ( name) values ( N'Kimbap')
insert into FoodCategory ( name) values ( N'Nước uống')
select * from FoodCategory

insert into Food (name, idCategory, price ) values (N'Pizza gà sợi',1, 50000)
insert into Food (name, idCategory, price ) values (N'Pizza bò phô mai',1,70000)
insert into Food (name, idCategory, price ) values (N'Gà rán vị truyền thống',2,30000)
insert into Food (name, idCategory, price ) values (N'Gà giòn chua cay Hàn Quốc',2,40000)
insert into Food (name, idCategory, price ) values (N'Kimbap chay',3,30000)
insert into Food (name, idCategory, price ) values (N'CocaCola',4,10000)

select * from Food

insert into Bill(DateCheckIn, DateCheckOut, idTable, status) values (getdate(),GETDATE(), 3, 0)
insert into Bill(DateCheckIn, DateCheckOut, idTable, status) values (getdate(),GETDATE(), 6, 1)
insert into Bill(DateCheckIn, DateCheckOut, idTable, status) values (getdate(),GETDATE(), 5, 0)
insert into Bill(DateCheckIn, DateCheckOut, idTable, status) values (getdate(),GETDATE(), 2, 1)
insert into Bill(DateCheckIn, DateCheckOut, idTable, status) values (getdate(),GETDATE(), 7, 0)
insert into Bill(DateCheckIn, DateCheckOut, idTable, status) values (getdate(),GETDATE(), 5, 0)
insert into Bill(DateCheckIn, DateCheckOut, idTable, status) values (getdate(),GETDATE(), 1, 1)
insert into Bill(DateCheckIn, DateCheckOut, idTable, status) values (getdate(),GETDATE(), 1, 1)


select * from Bill

insert into BillInfo (idBill, idFood, count) values (1,2,2)
insert into BillInfo (idBill, idFood, count) values (3,5,3)
insert into BillInfo (idBill, idFood, count) values (2,4,1)
insert into BillInfo (idBill, idFood, count) values (4,4,3)
insert into BillInfo (idBill, idFood, count) values (5,3,3)
insert into BillInfo (idBill, idFood, count) values (6,3,3)
insert into BillInfo (idBill, idFood, count) values (7,6,4)
insert into BillInfo (idBill, idFood, count) values (8,1,3)




select * from BillInfo

select f.name, bi.count, f.price, f.price*bi.count AS totalPrice from dbo.BillInfo as bi, dbo.Bill as b, dbo.Food as f
where bi.idBill = b.id and bi.idFood = f.id and b.idTable = 5

create proc USP_InsertBill
@idTable Int
as
begin
	insert dbo.Bill (DateCheckIn, DateCheckOut, idTable, status, discount)
	values (GETDATE(), Null, @idTable,0,0)
	end
	go

create proc USP_InsertBillInfo
@idBill Int, @idFood int, @count int
as
begin

	declare @isEXitsBillInfo int
	declare @foodCount int = 1

	select @isEXitsBillInfo = id, @foodCount = b.count
	from dbo.BillInfo as b
	where idBill = @idBill and idFood = @idFood

	if(@isEXitsBillInfo > 0)
	begin
		declare @newCount int = @foodCount + @count
		if(@newCount > 0)
		update dbo.BillInfo set count = @foodCount + @count 
		where idFood = @idFood
		else
		delete dbo.BillInfo where idBill = @idBill and idFood = @idFood
		end
		else
		begin
			insert dbo.BillInfo(idBill, idFood, count)
			values (@idBill, @idFood, @count)
		end
		end
		go


create trigger UTG_UpdateBillInfo
on dbo.BillInfo for insert, update
as
begin
	declare @idBill int
	select @idBill = idBill from inserted
	declare @idTable int
	select @idTable = idTable from dbo.Bill where id = @idBill and status = 0
	update dbo.TableFood set status = N'Có người' where id = @idTable
	end
	go

	delete BillInfo
	delete Bill


create trigger UTG_UpdateBill
on dbo.Bill for update
as
begin
	declare @idBill int
	select @idBill = id From inserted
	declare @idTable int
	select @idTable = idTable from dbo.Bill where id = @idBill
	declare @count int = 0
	select @count = count(*) from dbo.Bill where idTable = @idTable and status = 0
	if(@count = 0)
		update dbo.TableFood set status = N'Trống' where id = @idTable
	end
	go
--them giam gia
alter table dbo.Bill
add discount int

update Bill set discount = 0

alter table dbo.Bill add totalPrice float

create proc USP_GetListBillByDate
@checkIn date, @checkOut date
as
begin
	select t.name as [Tên bàn] , b.totalPrice as [Tổng tiền] , DateCheckIn as [Ngày vào], DateCheckOut as [Ngày ra], discount as [Giảm giá]
	from dbo.Bill as b, dbo.TableFood as t
	where DateCheckIn >= @checkIn and DateCheckOut <= @checkOut and b.status = 1
	and t.id = b.idTable
end
go

