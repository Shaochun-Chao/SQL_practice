use AdventureWorks2019
GO

--SELECT statement: identify which columns we want to retrieve

--1. SELECT all columns and rows

--1. Write a query that lists the country and province names from person. CountryRegion and person. StateProvince tables. Join them and produce a result set similar to the
--following.

select 'Country '+ c.CountryRegionCode + '    Province ' + s.StateProvinceCode 
from Person.StateProvince as s join Person.CountryRegion as c
on s.CountryRegionCode = c.CountryRegionCode


 --   Country                        Province




--2. Write a query that lists the country and province names from person. CountryRegion and person. StateProvince tables and list the countries filter them by Germany and Canada.
--Join them and produce a result set similar to the following.




  --  Country                        Province
select 'Country '+ c.CountryRegionCode + '    Province ' + s.StateProvinceCode 
from Person.StateProvince as s join Person.CountryRegion as c
on s.CountryRegionCode = c.CountryRegionCode 
where c.name in ('Germany', 'Canada')

GO
 --Using Northwind Database: (Use aliases for all the Joins)
use Northwind
GO
--3. List all Products that has been sold at least once in last 25 years.

select DISTINCT p.ProductID, p.ProductName
from Products p JOIN [Order Details] od
ON p.ProductID = od.ProductID JOIN Orders o ON o.OrderID = od.OrderID 
where o.OrderDate > '1997-06-22'


--4. List top 5 locations (Zip Code) where the products sold most in last 25 years.
select top 5 o.ShipPostalCode, count(o.ShipPostalCode) num
from Products p JOIN [Order Details] od
ON p.ProductID = od.ProductID JOIN Orders o ON o.OrderID = od.OrderID 
where OrderDate > '1997-06-22' group by o.ShipPostalCode
order by num desc

--5. List all city names and number of customers in that city.     
select City, Count(City) NumOfCusts 
from Customers group by City




--6. List city names which have more than 2 customers, and number of customers in that city

select c.City, Count(c.City) num
from Customers c
group by c.City 
having count(c.City) >2


--7. Display the names of all customers  along with the  count of products they bought
select c.ContactName, sum(od.Quantity) num
from Customers c
join Orders o on o.CustomerID = c.CustomerID 
join [Order Details] od on o.OrderID = od.OrderID
group by c.ContactName



--8. Display the customer ids who bought more than 100 Products with count of products.
select c.CustomerID, sum(od.Quantity) num
from Customers c
join Orders o on o.CustomerID = c.CustomerID 
join [Order Details] od on o.OrderID = od.OrderID
group by c.CustomerID
having sum(od.Quantity) > 100



--9. List all of the possible ways that suppliers can ship their products. Display the results as below




   -- Supplier Company Name                Shipping Company Name




    ---------------------------------            ----------------------------------


select DISTINCT s.CompanyName [Supplier Company Name], sh.CompanyName [Shipping Company Name] from Suppliers s JOIN Products p ON s.SupplierID = p.SupplierID 
JOIN [Order Details] od on p.ProductID = od.ProductID JOIN Orders o ON o.OrderID = od.OrderID JOIN Shippers sh ON sh.ShipperID = o.ShipVia 
              



--10. Display the products order each day. Show Order date and Product Name.

select p.ProductName, o.OrderDate
from Products p  left join [Order Details] od on p.ProductID = od.ProductID left join Orders o on od.OrderID=o.OrderID


--11. Displays pairs of employees who have the same job title.

select e.FirstName+' '+ e.LastName [employee1],e2.FirstName+' '+ e2.LastName [employee2], e.Title
from Employees e, Employees e2
where e.Title=e2.Title and e.FirstName !=e2.FirstName and e.LastName!=e2.LastName



--12. Display all the Managers who have more than 2 employees reporting to them.

select count(e.ReportsTo) [num], e2.FirstName as manager
from Employees e inner join Employees e2 on e.ReportsTo = e2.EmployeeID 
group by e2.FirstName 
having count(e.ReportsTo) > 2


--13. Display the customers and suppliers by city. The results should have the following columns




--City


--Name


--Contact Name,


--Type (Customer or Supplier)


select c.ContactName, c.CompanyName, c.City, c.Relationship 
from [Customer and Suppliers by City] c order by c.City


--All scenarios are based on Database NORTHWIND.



--14. List all cities that have both Employees and Customers.
select distinct c.City
from Customers c where c.City in (select e.City from Employees e )

--15. List all cities that have Customers but no Employee.


--a. 
    
-- Use
--sub-query
select distinct c.City
from Customers c where c.City not in (select e.City from Employees e )


--b. 
    
-- Do
--not use sub-query
select distinct c.City
from Customers c where c.City not in (select e.City from Employees e )

--16. List all products and their total order quantities throughout all orders.
select p.ProductName, SUM(od.Quantity)
from [Order Details] od left join Orders o on od.OrderID=o.OrderID left join Products p on od.ProductID=p.ProductID
group by p.ProductName order by SUM(od.Quantity) DESC



--17. List all Customer Cities that have at least two customers.


--a. 
    
-- Use
--union

select c.city
from Customers c 
group by c.city
having count(c.city) >=2
UNION 
select c1.city
from Customers c1 
group by c1.city
having count(c1.city) >=2
--b. 
    
-- Use
--sub-query and no union
select distinct c.city
from Customers c 
where c.city in ( select c1.city from customers c1 where c.CustomerID != c1.CustomerID)

--18. List all Customer Cities that have ordered at least two different kinds of products.
select c.city
from Customers c left join Orders o on c.CustomerID=o.CustomerID left join [Order Details] od on od.OrderID=o.OrderID
group by c.city 
having count(od.ProductID) >=2
 


--19. List 5 most popular products, their average price, and the customer city that ordered most quantity of it.
select top 5 SUM(od.Quantity) [number of products], od.ProductID, avg(od.UnitPrice) [average price], c.City
from  [Order Details] od left join Products p on od.ProductID=p.ProductID left join orders o on o.OrderID=od.OrderID left join customers c on c.CustomerID=o.CustomerID
group by od.ProductID, c.city
order by SUM(od.Quantity) desc



--20. List one city, if exists, that is the city from where the employee sold most orders (not the product quantity) is, and also the city of most total quantity of products ordered
--from. (tip: join  sub-query)


select top 5 o.ShipCity, count(o.ShipCity) from Orders o group by o.ShipCity order by count(o.ShipCity)

select top 1 o.ShipCity 
from Orders o left join [Order Details] od on o.OrderID = od.OrderID
group by o.ShipCity
order by sum(od.quantity)  desc


select top 1 e.City
from Orders o  left join Employees e on o.EmployeeID=e.EmployeeID
group by e.City
order by count(e.City)  desc

--21. How do you remove the duplicates record of a table?

