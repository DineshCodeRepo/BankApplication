use ProductBacklog

create table customerTable
(
 cusSSNid bigint unique,
 cusid bigint primary key identity(100000200,1),
 cusname varchar(20),
 age int,
 address varchar(20),
 state varchar(20),
 city varchar(20),
 status varchar(20),
 message varchar(50),
 lastupdated datetime
 )


 --insert into customerTable (cusid) values (100000268)

 select * from customerTable

 drop table customerTable
 ----------------------------------------------------------------------------------------------------------------------------------------------------

 create proc sp_addcustomer

 @cusSSNid bigint,
 @cusname varchar(20),
 @age int,
 @address varchar(20),
 @state varchar(20),
 @city varchar(20),
 @status varchar(20),
 @message varchar(50),
 @lastupdated datetime

 as
 begin

 insert into  customerTable (cusSSNid,cusname,age,address,state,city,status,message,lastupdated) values(@cusname,@age,@address,@state,@city,@status,@message,@lastupdated)
 end

 exec sp_addcustomer 1234,kamla,23,chehha,tamilnadu,chennai,0,0,0
 exec sp_addcustomer 1235,kamala,25,chepa,tamilnadu,chennai,'Active','Customer created Successfully',0

 drop proc sp_addcustomer
 -----------------------------------------------------------------------------------------------------------------------------------------------------------

 create proc sp_updatecustomer


 @cusSSNid bigint,
 @cusid bigint,
 @cusname varchar(20),
 @address varchar(20),
 @age int,
 @status varchar(20),
 @message varchar(50),
 @lastupdated datetime

as
begin

update customerTable set cusname=@cusname,address=@address,age=@age,status=@status,message=@message,lastupdated = @lastupdated
where cusid = @cusid or cusSSNid=@cusSSNid
end

exec sp_updatecustomer 1234,asdf,erqwew,12

drop proc sp_updatecustomer
----------------------------------------------------------------------------

create proc sp_deletecustomer

@cusSSNid bigint,
@cusid bigint,
@cusname varchar(20),
@address varchar(20),
@age int,
@status varchar(20),
 @message varchar(50),
 @lastupdated datetime

as
begin

update customerTable set cusSSNid=@cusSSNid,cusname=@cusname,address=@address,age=@age,status=@status,message=@message,lastupdated = @lastupdated
where cusid = @cusid or cusSSNid=@cusSSNid
end

drop proc sp_deletecustomer
-----------------------------------------------------------------------------------
create proc sp_retrivedata

@cusSSNid bigint,
@cusid bigint

as
begin
select * from customerTable
where cusid = @cusid or cusSSNid = @cusSSNid
end

drop proc sp_retrivedata
----------------------------------------------------------------------------
create proc sp_view
as begin
select * from CustomerTable
end
-------------------------






 ---------------------------------------------------------------------------------------------------------------------------------------
 create table accountTable
 (
  cusid bigint foreign key references customerTable(cusid)  not null,
  acctype varchar(15) not null,
  accid bigint  identity(111011000,1) primary key not null,
  amount bigint not null,
  status varchar(20),
 message varchar(50),
 lastupdated datetime
)


insert into  accountTable (cusid,acctype,amount) values (100000200,'Current',35000)
insert into  accountTable (cusid,acctype,amount) values (542133,'Savings',40000)
insert into  accountTable (cusid,acctype,amount) values (145926,'Current',50000)



select * from accountTable

drop table accountTable


---------------------------------------------------------------------------------------------------

create proc sp_Addaccount

@cusid bigint,
@acctype varchar(15),
@amount bigint,
@status varchar(20),
@message varchar(50),
@lastupdated datetime

as
begin

insert into accountTable(cusid,acctype,amount,status,message,lastupdated) values (@cusid,@acctype,@amount,@status,@message,@lastupdated)



end

exec sp_Addaccount 100000200,'Current',35000,'Active','Account created Successfully',0

drop proc sp_Addaccount

-----------------------------------------------------------------------------------------------------------------------------------------------------

create proc sp_deleteAccount

@accid bigint,
@acctype varchar(15),
@status varchar(20),
@message varchar(50),
@lastupdated datetime

as
begin

update accountTable set acctype=@acctype,status=@status,message=@message,lastupdated=@lastupdated
 where accid = @accid and amount=0

end

drop proc sp_deleteAccount
----------------------------------------------------------------------------------------------------------------------------------------

create proc sp_viewAccountdetails

@accid bigint

as
begin

select acctype from accountTable where accid = @accid
end

drop proc sp_viewAccountdetails
----------------------------------------------------------------------------------------------------------------------------------------

create proc sp_ViewAll
@accid bigint,
@cusid bigint
as
begin

select * from accountTable where accid=@accid or cusid=@cusid;

end
drop proc sp_ViewAll
select * from accountTable
-------------------------------------------------------------------------------------------------------------------------------------------

create table transactions
(
 accountid bigint foreign key references accountTable(accid),
 transactionid bigint primary key identity(30000,1),
 date date,
 description varchar(20),
 amount bigint,
 toaccountid bigint
) 
drop table transactions

create proc readaccountid
 @accid bigint
as
begin
select * from accountTable where accid= @accid and status!='Pending'
end

drop proc readaccountid

create proc readaccountcustid
 @cusid bigint
as
begin
select * from accountTable where cusid= @cusid and status!='Pending'
end

drop proc readaccountcustid

create proc viewaccount
as
begin
select * from accountTable
end

create proc inserttransac
 @accountid bigint,
 @transactionid bigint output,
 @date date,
 @description varchar(20),
 @amount bigint,
 @toaccountid bigint
as 
begin
insert into transactions values
(@accountid,@date,@description,@amount,@toaccountid) 
set @transactionid=@@IDENTITY
end 

create proc updatebalance
 @accountid bigint,
 @amount bigint,
 @description varchar(20),
 @toaccountid bigint
 as 
 begin
 update accountTable set amount=amount-@amount where @description='debit' and accid=@accountid and amount-@amount>=0;
update accountTable set amount=amount+@amount where @description='credit' and accid=@accountid;
update accountTable set amount=amount-@amount where @description='transfer' and accid=@accountid and amount-@amount>=0;
update accountTable set amount=amount+@amount where @description='transfer' and accid=@toaccountid and ((select amount from accountTable where accid=@accountid)-@amount>=0);
 end

 create proc readtransac
 @accountid bigint
as
begin
select * from transactions where accountid=@accountid
end

create proc accstatementbytrans
@accountid bigint,
@nooftrans int
as 
begin
select top(@nooftrans) * from transactions where accountid=@accountid
order by date desc
end

create proc accstatementbydate
@accountid bigint,
@startdate date,
@enddate date
as
begin
select *from transactions where date>=@startdate and date<=@enddate and accountid=@accountid
end



create table userstore 
(
 username varchar(15),
 password varchar(15),
 timestamp datetime,
 type int
)


create proc retriveuser
@username varchar(15)
as
begin
select * from userstore where username=@username
end

select * from transactions