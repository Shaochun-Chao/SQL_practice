use AdventureWorks2019
GO



--1. Write a query that retrieves the columns ProductID, Name, Color and ListPrice from the Production.Product table, with no filter. 

select p.ProductID, p.Name,p.Color, p.ListPrice
from Production.Product as p

--2. Write a query that retrieves the
--columns ProductID, Name, Color and ListPrice from the Production.Product table,

--excluding the rows that ListPrice is 0.
select p.ProductID, p.Name,p.Color, p.ListPrice
from Production.Product as p
where p.ListPrice !=0

--3. Write a query that retrieves the columns ProductID, Name,
--Color and ListPrice from the Production.Product table, the rows that are not NULL for the Color column.
select p.ProductID, p.Name,p.Color, p.ListPrice
from Production.Product as p
where p.Color is not null

--4. Write a query that retrieves the columns ProductID, Name,
--Color and ListPrice from the Production.Product table, the rows that are not NULL for the column Color, and the column ListPrice has a value greater than zero.
select p.ProductID, p.Name,p.Color, p.ListPrice
from Production.Product as p
where p.Color is not null and p.ListPrice >0

--5. Write a query that concatenates the columns Name and Color
--from the Production.Product table by excluding the rows that are null for color.

select p.Name + ', ' + p.Color [Name, Color]
from Production.Product as p
where p.Color is not null
--6. Write a query that generates the following result set from
--Production.Product:


--NAME: LL Crankarm  --  COLOR: Black


--NAME: ML Crankarm  --  COLOR: Black


--NAME: HL Crankarm  --  COLOR: Black


--NAME: Chainring Bolts  --  COLOR: Silver


--NAME: Chainring Nut  --  COLOR: Silver


--NAME: Chainring  --  COLOR: Black
select 'NAME: ' + p.Name + ' -- COLOR: ' + p.Color [Name, Color]
from Production.Product as p
where p.Color is not null
--7.
--Write a query to retrieve the to the columns ProductID and Name from the Production.Product table filtered by ProductID from 400 to 500 using between
select p.ProductID,p.name
from Production.Product as p
where  p.ProductID >=400 and  p.ProductID <=500
--8. Write a query to retrieve the to the columns  ProductID,
--Name and color from the Production.Product table restricted to the colors black and blue
select p.ProductID,p.name,p.Color
from Production.Product as p
where  p.Color in ('Black','Blue')

--9. Write a query to get a result set on products that begins
--with the letter S. 
select p.name
from Production.Product as p
where  p.Name like 'S%'

--10. Write a query that retrieves the columns Name and ListPrice
--from the Production.Product table. Your result set should look something like the following. Order the result set


--by the Name column. The products name should start with either 'A' or 'S'


--Name                                            ListPrice


--Adjustable Race                                   0,00


--All-Purpose Bike Stand                       159,00


--AWC Logo Cap                                      8,99


--Seat Lug                                          0,00


--Seat Post                                         0,00

select p.name, p.ListPrice
from Production.Product as p
where  p.Name like 'S%' or p.name like 'A%'
order by p.name

--11. Write a query so you retrieve rows
--that have a Name that begins with the letters SPO, but is then not followed by the letter K. After this zero or more letters can exists. Order the result set by the Name column.
select p.name
from Production.Product as p
where p.name like 'SPO[^k]%'
order by p.name

--12. Write a query that retrieves the unique combination of
--columns ProductSubcategoryID and Color from the Production.Product table. We do not want any rows that are NULL.in any of the two columns in the result. (Hint: Use IsNull)
select distinct p.color,p.ProductSubcategoryID
from Production.Product as p
where p.color is not null and p.ProductSubcategoryID is not null