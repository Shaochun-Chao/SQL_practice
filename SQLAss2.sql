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
where OrderDate > '1997-06-22'


--4. List top 5 locations (Zip Code) where the products sold most in last 25 years.




--5. List all city names and number of customers in that city.     
select City, Count(City) NumOfCusts 
from Customers group by City




--6. List city names which have more than 2 customers, and number of customers in that city

select City, Count(City) NumOfCusts 
from Customers 
group by City 
having count(City) >2


--7. Display the names of all customers  along with the  count of products they bought




--8. Display the customer ids who bought more than 100 Products with count of products.




--9. List all of the possible ways that suppliers can ship their products. Display the results as below




   -- Supplier Company Name                Shipping Company Name




    ---------------------------------            ----------------------------------




--10. Display the products order each day. Show Order date and Product Name.




--11. Displays pairs of employees who have the same job title.




--12. Display all the Managers who have more than 2 employees reporting to them.




--13. Display the customers and suppliers by city. The results should have the following columns




--City


--Name


--Contact Name,


--Type (Customer or Supplier)





--All scenarios are based on Database NORTHWIND.


--14. List all cities that have both Employees and Customers.


--15. List all cities that have Customers but no Employee.


--a. 
    
-- Use
--sub-query


--b. 
    
-- Do
--not use sub-query


--16. List all products and their total order quantities throughout all orders.


--17. List all Customer Cities that have at least two customers.


--a. 
    
-- Use
--union


--b. 
    
-- Use
--sub-query and no union


--18. List all Customer Cities that have ordered at least two different kinds of products.

 


--19. List 5 most popular products, their average price, and the customer city that ordered most quantity of it.

 


--20. List one city, if exists, that is the city from where the employee sold most orders (not the product quantity) is, and also the city of most total quantity of products ordered
--from. (tip: join  sub-query)




--21. How do you remove the duplicates record of a table?