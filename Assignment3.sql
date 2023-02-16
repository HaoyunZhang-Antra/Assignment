use Northwind;

--1
Select distinct city 
From Customers 
Where city in (select city from Employees)

--2
--a
Select distinct city  
From Customers 
Where City not in (select distinct city from employees where city is not null)

--b
Select distinct city From Customers  
Except 
Select distinct city From Employees

--3
Select od.ProductID, Sum(od.Quantity) [Total order quantities]
From dbo.[Order Details] od
Group By od.ProductID
Order By 1
Go


--4
Select c.City, Sum(od.Quantity) [Total Products Orders]
From dbo.Customers c Join dbo.Orders o On c.CustomerID = o.CustomerID
Join dbo.[Order Details] od On o.OrderID = od.OrderID
Group By c.City

--5
--a 
Select city From Customers
Except
Select city From customers
Group By city
Having COUNT(*)=1
Union 
Select city From customers
Group By city
Having COUNT(*)=0

--b
Select city 
From customers 
Group By city 
Having COUNT(*)>=2


--6
Select distinct city 
From orders o Join [order details] od On o.orderid = od.orderid 
Join customers c On c.customerid = o.CustomerID
Group By city
Having COUNT(*)>=2


--7
Select Distinct c.CustomerID 
From orders o Join [order details] od On o.orderid = od.orderid 
Join customers c On c.customerid = o.CustomerID
Where City <> ShipCity


--8
--Select Top 5 od.ProductID, Sum(od.Quantity)
--From dbo.[Order Details] od
--Group By od.ProductID
--Order By 2 Desc
--Go

Select Top 5 od.ProductID
From dbo.[Order Details] od
Group By od.ProductID
Order By Sum(od.Quantity) Desc
GO

--I create a new table Q8 to store the sum of quantity of each product in the same city.
--Then I can use a CTE to get the row which have the most value about the sum of quantity of each product in each city. 
--This most value give me the customer city that have the most ordered quantity.

--Select od.ProductID, c.City, Sum(od.Quantity) [MostOrder]
--INTO Q8
--From dbo.Customers c Join dbo.Orders o On c.CustomerID = o.CustomerID
--Join dbo.[Order Details] od On o.OrderID = od.OrderID
--Where od.ProductID in (Select Top 5 od.ProductID
--						From dbo.[Order Details] od
--						Group By od.ProductID
--						Order By Sum(od.Quantity) Desc)
--Group By od.ProductID, c.City
--Order By 1 Asc, 3 Desc;

--Select *
--From Q8
--Order By 1 Asc, 3 Desc;

WITH added_row_number AS (
  SELECT
    *,
    ROW_NUMBER() OVER(PARTITION BY ProductID ORDER BY MostOrder DESC) AS row_number
  FROM Q8
)
SELECT X.ProductId, X.City, Y.[Average price], X.MostOrder
FROM added_row_number X Join (
							Select od.ProductID, Sum(od.UnitPrice*(1-od.Discount))/Count(od.ProductID) [Average price]
							From dbo.[Order Details] od 
							Where od.ProductID in (Select Top 5 od.ProductID
													From dbo.[Order Details] od
													Group By od.ProductID
													Order By Sum(od.Quantity) Desc)
							Group By od.ProductID
) Y On X.ProductID = Y.ProductID
WHERE row_number = 1;
GO

--9
--a
Select DISTINCT e.City
From dbo.Employees e
Where e.EmployeeID in (Select e.EmployeeID 
						From dbo.Employees e Join dbo.Orders o On e.EmployeeID = o.EmployeeID
							Join dbo.Customers c On c.CustomerID = o.CustomerID
						Where e.City != c.City);
GO

--b
Select DISTINCT e.City
From dbo.Employees e Join dbo.Orders o On e.EmployeeID = o.EmployeeID
Join dbo.Customers c On c.CustomerID = o.CustomerID
Where e.City != c.City;
GO



--10
Select TOP 1 e.City [city of employees sold most orders], (Select top 1 o.ShipCity
						From dbo.Orders o Join dbo.[Order Details] od On o.OrderID = od.OrderID
						Group By o.ShipCity
						Order By Sum(od.Quantity) Desc) [city of most quantity ordered from]
From dbo.Employees e Join dbo.Orders o On e.EmployeeID = o.EmployeeID
Group By e.City
Order By Count(o.OrderID) Desc;


--11
--If the behavior for duplicate records is to keep one record and delete the rest of duplicate records,
--I can use this table union this table.
--I can also create a tempory new table to store Distinct records and delete all old table, then insert this new table to old table.
--Or I can use group by and count(*), if count(*)>1 then delete the rows using sub query.