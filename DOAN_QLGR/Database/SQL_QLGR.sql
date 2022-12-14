CREATE DATABASE DAQLGR
USE DAQLGR
ON 
	(NAME = 'DAQLGR_DATA',FILENAME ='E:\SQL\DAQLGR.MDF')
LOG ON
	(NAME ='DAQLGR_LOG',FILENAME = 'E:\SQL\DAQLGR.LDF')
	GO
USE DAQLGR
GO

--DROP TABLE FOODS

CREATE TABLE OTABLE 
(
	ID INT IDENTITY(1,1) PRIMARY KEY,
	TABLENUMBER VARCHAR(5)  NOT NULL DEFAULT 'A0',
	TSTATUS NVARCHAR(10) NOT NULL DEFAULT N'Trống'--0 IS AVAILABLE , 1 IS HAVE PERSONS

)
GO

CREATE TABLE ACCOUNTTYPE 
(
	POSITION int IDENTITY(1,1) NOT NULL PRIMARY KEY,
	ACCOUNTTYPE NVARCHAR (20)NOT NULL DEFAULT 'Nhân Viên'
	)
	GO

CREATE TABLE ACCOUNT 
(
	USERNAME VARCHAR(30) NOT NULL PRIMARY KEY DEFAULT '********',
	DISPLAYNAME NVARCHAR(30)NOT NULL,
	UPASSWORD VARCHAR(20) NOT NULL DEFAULT '********',
	POSITION INT NOT NULL 
	FOREIGN KEY (POSITION) REFERENCES DBO.ACCOUNTTYPE(POSITION)
	
	

)
GO 

CREATE TABLE FOODSTYPE
(
	ID INT IDENTITY(1,1) PRIMARY KEY,
	TYPENAME NVARCHAR(50)

)
GO

CREATE TABLE FOODS
(
	ID INT IDENTITY(1,1)PRIMARY KEY,
	FOODSNAME NVARCHAR(50)NOT NULL DEFAULT N'UNKNOWN FOOD NAME',
	IDTYPE INT NOT NULL,
	FOODSPRICE MONEY NOT NULL DEFAULT 0,
	FOODIMAGE IMAGE
	
	FOREIGN KEY (IDTYPE) REFERENCES DBO.FOODSTYPE(ID)
)
GO

CREATE TABLE BILL
(
	ID INT IDENTITY (1,1)PRIMARY KEY ,
	CHECKIN DATE NOT NULL DEFAULT GETDATE(),
	CHECKOUT DATE ,
	IDTABLE INT NOT NULL,
	DISCOUNT FLOAT DEFAULT 0,
	TAKEREAL FLOAT DEFAULT 0,
	TOTAL FLOAT DEFAULT 0,
	BSTATUS BIT NOT NULL DEFAULT 0--1 IS PAID , 2 UNPAID 

	FOREIGN KEY (IDTABLE) REFERENCES DBO.OTABLE(ID)
)

GO

CREATE TABLE BILLINFO
(
	ID INT IDENTITY (1,1)PRIMARY KEY,
	IDBILL INT NOT NULL,
	CHECKDAY DATE NOT NULL DEFAULT GETDATE(),
	IDFOODS INT NOT NULL,
	AMOUNT INT NOT NULL DEFAULT 0
	FOREIGN KEY (IDBILL) REFERENCES DBO.BILL(ID),
	FOREIGN KEY (IDFOODS) REFERENCES DBO.FOODS(ID)
)
GO
CREATE TABLE SUPLIERS
(
	SUPLIERSID VARCHAR(10) NOT NULL PRIMARY KEY,
	SUPLIERSNAME NVARCHAR(50) NOT NULL DEFAULT 'UNKNOWN SUPLIER NAME' ,
	PHONENUMBER VARCHAR(15) NOT NULL,
	SUPLIERSADDRESS NVARCHAR (50) NOT NULL DEFAULT 'INPUT SUPLIERS ADDRESS'

)
CREATE TABLE RESOURCESTYPE
(
	ID INT IDENTITY (1,1)PRIMARY KEY,
	RESOURCESTYPENAME NVARCHAR(30) NOT NULL DEFAULT 'UNKNOWN TYPE NAME',
	SUPLIERSID VARCHAR(10) NOT NULL
	FOREIGN KEY (SUPLIERSID) REFERENCES DBO.SUPLIERS(SUPLIERSID),
	)
CREATE TABLE RESOURCES 
(
	ID INT IDENTITY(1,1) PRIMARY KEY,
	RESOURCESNAME NVARCHAR(50)NOT NULL DEFAULT 'UNKNOWN RESOURCE NAME',
	RESOURCESTYPEID INT NOT NULL,
	RESOURCESAMOUNT INT NOT NULL DEFAULT 0
	FOREIGN KEY (RESOURCESTYPEID) REFERENCES DBO.RESOURCESTYPE(ID)

	
)
CREATE TABLE INCOME
(
	ID INT IDENTITY(1,1) PRIMARY KEY,
	DATEINCOM DATE NOT NULL DEFAULT GETDATE(),
	COLLECT FLOAT NOT NULL DEFAULT 0.0,
	SPEND FLOAT NOT NULL DEFAULT 0.0,
	PROFIT FLOAT NOT NULL DEFAULT 0.0
	)
	GO

	--DROP TABLE foods

CREATE PROC USER_GETACCOUNT
	 @USERNAME VARCHAR(30)
	AS
	BEGIN
	SELECT DISPLAYNAME AS[Tên hiển thị] ,USERNAME AS [Tên đăng nhập],UPASSWORD AS[Mật khẩu],ACCOUNTTYPE AS [Chức Vụ]
	FROM ACCOUNT,ACCOUNTTYPE
	WHERE 
	DBO.ACCOUNT.POSITION=DBO.ACCOUNTTYPE.POSITION AND  USERNAME=@USERNAME
	END
	GO

	--EXEC DBO.USER_GETACCOUNT @USERNAME = 'STAFF'
--	GO

	--drop table FOODS

CREATE PROC LOGIN
	 @USERNAME VARCHAR(50),@UPASSWORD NVARCHAR(50)
	AS
	BEGIN
	SELECT*
	FROM ACCOUNT
	WHERE 
	DBO.ACCOUNT.USERNAME=@USERNAME  COLLATE SQL_Latin1_General_CP1_CS_AS AND DBO.ACCOUNT.UPASSWORD=@UPASSWORD  COLLATE SQL_Latin1_General_CP1_CS_AS
	END
	GO
	
create  PROC SETTABLE

@COUNT INT
AS
	DECLARE @I INT =1;
	WHILE @I<= @COUNT
	BEGIN

		INSERT DBO.OTABLE(TABLENUMBER) VALUES('A' +CAST(@I AS VARCHAR(5)))
		SET @I=@I+1;
	END
	
GO	

CREATE PROC [dbo].[GETTABLE]
AS
BEGIN
	SELECT*FROM OTABLE
END
GO
GO
--drop table foods
DROP PROC GETTABLE
CREATE PROC GETTABLE1
@TSTATUS NVARCHAR(10)
AS
BEGIN
	SELECT*FROM OTABLE where TSTATUS=@TSTATUS
END
GO --EXEC DBO.GETTABLE1 @TSTATUS = N'Trống'
--insert loai tai khoan-------------------------------------------
INSERT INTO DBO.ACCOUNTTYPE
(
	
	ACCOUNTTYPE
	

	)
	VALUES(
	N'Quản Lý'
	
	)
	GO

INSERT INTO DBO.ACCOUNTTYPE
(
	
	ACCOUNTTYPE
	

	)
	VAlUES 
	(
	
		N'Nhân Viên'
		
	)
GO
--insert tai khoan-------------------------------------------

INSERT INTO DBO.ACCOUNT
(
	
	
	DISPLAYNAME,
	USERNAME,
	UPASSWORD,
	POSITION

	)
	VALUES(
	'QUOCVIET',
	N'TR?NH QU?C VI?T',
	'1234',
	1
	
	)
GO

INSERT INTO DBO.ACCOUNT
(
	
	USERNAME,
	DISPLAYNAME,
	UPASSWORD,
	POSITION

	)
	VALUES(
	'STAFF',
	N'STAFF',
	'1234',
	2
	)
GO

INSERT INTO DBO.ACCOUNT
(
	
	USERNAME,
	DISPLAYNAME,
	UPASSWORD,
	POSITION

	)
	VALUES(
	N'STAFF12',
	'STAF1',
	'1234',
	1
	)
GO
INSERT INTO DBO.ACCOUNT
(
	
	USERNAME,
	DISPLAYNAME,
	UPASSWORD,
	POSITION

	)
	VALUES(
	'QL123',
	N'Trịnh Quốc Việt',
	'1234',
	0
	)
go



CREATE PROC GETPRICE
@IDTABLE INT
AS
BEGIN
SELECT FOODSNAME , AMOUNT,FOODSPRICE,TOTAL = FOODSPRICE*AMOUNT,IDFOODS  FROM BILL,FOODS,BILLINFO WHERE BILL.BSTATUS=0 AND IDFOODS=FOODS.ID AND BILLINFO.IDBILL=BILL.ID AND BILL.IDTABLE=@IDTABLE
END
GO
--EXEC GETPRICE @IDTABLE = 1
--GO 
--SELECT*FROM BILL
--drop proc INSERTBILLINFO

create PROC INSERTBILL
@IDTABLE INT 
AS 
BEGIN 
INSERT INTO DBO.BILL VALUES(GETDATE(),NULL,@IDTABLE,0,0,0,0)
END
GO

create PROC INSERTBILLINFO
@IDBILL INT ,@IDFOODS INT ,@AMOUNT INT 
AS
--EXEC INSERTBILL @IDTABLE = 


BEGIN 
	DECLARE @EXIST INT ;
	DECLARE @FOODSCOUNT INT =1;
	SELECT @EXIST = B.ID, @FOODSCOUNT=b.AMOUNT FROM BILLINFO as B ,BILL WHERE IDBILL=@IDBILL AND IDFOODS = @IDFOODS AND BILL.ID= IDBILL
	IF(@EXIST>0)
		BEGIN
			DECLARE @NEWCOUNT INT = @FOODSCOUNT +@AMOUNT
			IF(@NEWCOUNT>0)
				UPDATE BILLINFO SET AMOUNT= @AMOUNT+@FOODSCOUNT WHERE  IDFOODS = @IDFOODS AND IDBILL=@IDBILL
			ELSE
			DELETE BILLINFO WHERE IDBILL=@IDBILL AND IDFOODS = @IDFOODS
		END
	ELSE
		BEGIN
			INSERT INTO BILLINFO VALUES(@IDBILL,GETDATE(),@IDFOODS,@AMOUNT)
		END
END
GO

--create TRIGGER UPDATEBILLIF
--ON BILLINFO  FOR INSERT , UPDATE 
--AS
--BEGIN 
--DECLARE @IDBILL INT 
--SELECT @IDBILL = IDBILL FROM inserted
--DECLARE @IDTABLE INT 
--SELECT @IDTABLE = IDTABLE  FROM BILL WHERE ID=@IDBILL AND BILL.BSTATUS =0 
--UPDATE OTABLE SET TSTATUS = N'Có người' WHERE ID = @IDTABLE	
--END 
--GO

--select*from OTABLE
--drop trigger updatebillif
--create TRIGGER UPDATEBILL
--ON BILL FOR UPDATE
--AS
--BEGIN 
--	DECLARE @IDBILL INT 
--	SELECT @IDBILL=ID FROM inserted
--	DECLARE @COUNT INT =0
--	DECLARE @IDTABLE INT 
--SELECT @IDTABLE = IDTABLE  FROM BILL WHERE ID=@IDBILL  
--	SELECT @COUNT = COUNT(*) FROM BILL WHERE IDTABLE=@IDTABLE AND BSTATUS=0 --
--	IF(@COUNT =0)
--	UPDATE OTABLE SET TSTATUS = N'Trống'WHERE ID = @IDTABLE
--END 
--GO







--EXEC INSERTBILLINFO @IDBILL @IDFOODS,@AMOUNT

--select max(id)from bill

--INSERT INTO DBO.BILL VALUES(GETDATE(),NULL,9,0)




CREATE PROC TEST
@IDBILL INT 
AS
BEGIN 
select B.ID as [Mã bill] ,o.TABLENUMBER as [Số bàn],b.CHECKIN as [Ngày vào],b.CHECKOUT as [Ngày ra],f.FOODSNAME as [Tên món],i.AMOUNT as[Số lượng] , [Tổng tiền]=convert(float,(f.FOODSPRICE*i.AMOUNT))
from bill as b, billinfo as i , otable as o , foods as f 
where O.ID=B.IDTABLE AND  I.IDFOODS=F.ID   AND  B.ID=I.IDBILL AND B.BSTATUS=1 AND B.ID=@IDBILL
END 
GO



CREATE PROC VIEWINCOME
@CHECKIN DATE , @CHECKOUT DATE
AS
BEGIN
	select bill.id ,TABLENUMBER ,CHECKIN ,CHECKOUT ,TOTAL , DISCOUNT ,TAKEREAL 
	from bill,OTABLE
	where IDTABLE= OTABLE.ID and CHECKIN>=@CHECKIN and CHECKOUT<=@CHECKOUT and BSTATUS=1
END 
GO


CREATE PROC GETALLBILLNOCHECK
AS
BEGIN
select bill.id,o.tablenumber,checkin,checkout,total,discount,takereal from bill,OTABLE as  o where bill.idtable=o.id and bstatus=1
END
GO



CREATE PROC GETBILLCHECKID
@IDBILL INT
AS
BEGIN
select bill.id,o.tablenumber,checkin,checkout,total,discount,takereal from bill,OTABLE as  o where bill.id = @IDBILL and bill.idtable=o.id and bstatus=1
END
GO
	select * from ACCOUNT
	CREATE PROC UPDATEACCOUNT
	@USERNAME VARCHAR(30),@DISPLAYNAME NVARCHAR(30),@UPASSWORD VARCHAR(20),@NEWPASS VARCHAR(20)
	AS

	BEGIN 
	DECLARE @CHECKEXIST INT =0
	SELECT @CHECKEXIST = COUNT(*) FROM ACCOUNT WHERE @USERNAME=USERNAME AND @UPASSWORD = UPASSWORD
	IF(@CHECKEXIST=1)
		BEGIN 
			IF(@NEWPASS=NULL OR @NEWPASS='')
				BEGIN
					UPDATE ACCOUNT SET DISPLAYNAME = @DISPLAYNAME WHERE USERNAME =@USERNAME
				END
			ELSE 
				UPDATE ACCOUNT SET DISPLAYNAME = @DISPLAYNAME , UPASSWORD =@NEWPASS WHERE USERNAME =@USERNAME
		END
	END
	GO



CREATE PROC GETFOODS
AS
BEGIN 
SELECT FOODS.ID,FOODSNAME,FOODIMAGE,FOODSTYPE.TYPENAME ,FOODSPRICE FROM DBO.FOODS,DBO.FOODSTYPE WHERE  DBO.FOODS.IDTYPE=DBO.FOODSTYPE.ID 
END
GO 

CREATE PROC BILLVIEW 
@idbill int 
AS
BEGIN 
	select bill.ID , OTABLE.TABLENUMBER,bill.CHECKIN,bill.CHECKOUT,foods.FOODSNAME,BILLINFO.AMOUNT,PRICE=(BILLINFO.AMOUNT*FOODS.FOODSPRICE),FOODSPRICE ,bill.TOTAL,bill.DISCOUNT,bill.TAKEREAL
	from bill, billinfo, FOODS, otable 
	where bill.IDTABLE=OTABLE.ID and BILLINFO.IDBILL=bill.ID and BILLINFO.IDFOODS=FOODS.ID and bill.ID=@idbill 
END 
GO

create proc getaccount
as
begin
select USERNAME, DISPLAYNAME,UPASSWORD,ACCOUNTTYPE from ACCOUNT, ACCOUNTTYPE where ACCOUNT.POSITION=ACCOUNTTYPE.POSITION
end

getaccount
go 
 create proc deletebillif
 @idbill int
 as
 begin
delete billinfo where BILLINFO.IDBILL= @IDBILL
end
go

create proc deletebill
as
begin 
delete bill where MONTH(bill.CHECKIN) !=MONTH(getdate())
end



update bill set CHECKIN='09/09/2020',CHECKOUT = '09/09/2020' where id= 207
select * from bill where id=207



