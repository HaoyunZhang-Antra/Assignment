use AdventureWorks2019;
SELECT * FROM Production.Product;

--1
SELECT COUNT(Distinct ProductID) AS [Number of Products] FROM Production.Product;
GO

--2
SELECT COUNT(Distinct p.ProductID), p.ProductSubcategoryID 
FROM Production.Product as p
WHERE p.ProductSubcategoryID is not NULL
GROUP BY p.ProductSubcategoryID;
GO

--3
SELECT p.ProductSubcategoryID, COUNT(p.ProductID) AS [CountedProducts] 
FROM Production.Product AS p
WHERE p.ProductSubcategoryID IS NOT NULL
GROUP BY p.ProductSubcategoryID;
GO

--4
SELECT COUNT(p.ProductID) AS [Number of Products Not in A Category]
FROM Production.Product AS p
WHERE p.ProductSubcategoryID IS NULL;
GO

--5
SELECT SUM(Quantity) AS 'Summary of Products' 
FROM Production.ProductInventory
GROUP BY ProductID;
GO

--6
SELECT p.ProductID, SUM(p.Quantity) AS TheSum
FROM Production.ProductInventory as p
WHERE p.LocationID = 40
GROUP BY p.ProductID
HAVING SUM(p.Quantity) < 100;
GO

--7
SELECT p.Shelf, p.ProductID, SUM(p.Quantity)AS TheSum
FROM Production.ProductInventory as p
WHERE p.LocationID = 40
GROUP BY p.Shelf, p.ProductID
HAVING SUM(Quantity) <= 100;
GO
--8
SELECT avg(p.Quantity)
FROM Production.ProductInventory as p
WHERE p.LocationID = 10
GO

--9
SELECT p.ProductID, p.Shelf, avg(p.Quantity) [TheAvg]
FROM Production.ProductInventory as p
GROUP BY p.ProductID, p.Shelf;
GO

--10
SELECT p.ProductID, p.Shelf, AVG(p.Quantity) AS [TheAvg]
FROM Production.ProductInventory as p
WHERE p.Shelf <> 'N/A'
GROUP BY p.ProductID, p.Shelf;

--11	
SELECT p.Color, p.Class, Count(p.ProductID) AS TheCount, AVG(p.ListPrice) AS AvgPrice
FROM Production.Product as p
WHERE p.Color IS NOT NULL AND p.Class IS NOT NULL
GROUP BY p.Color, p.Class;
Go

--12	  
Select pc.Name Country, ps.Name Province
From Person.CountryRegion as pc Join Person.StateProvince as ps On pc.CountryRegionCode = ps.CountryRegionCode;
Go

--13
Select pc.Name Country, ps.Name Province
From Person.CountryRegion as pc Join Person.StateProvince as ps On pc.CountryRegionCode = ps.CountryRegionCode
Where pc.Name not in ('Germany', 'Canada');
Go

--14
Use Northwind;

Select Distinct p.ProductID
From dbo.Products as p Join dbo.[Order Details] as od On p.ProductID = od.ProductID
Join dbo.Orders as o ON od.OrderID = o.OrderID
Where o.OrderDate between DATEADD(year, -25, GETDATE()) and GETDATE()
GO

--15
Select Top 5 o.ShipPostalCode, Sum(od.Quantity) [SumQuantity]
From dbo.[Order Details] as od Join dbo.Orders as o On od.OrderID = o.OrderID
Where o.ShipPostalCode is not NULL
Group By o.ShipPostalCode
Order By 2 Desc
Go

--16
Select Top 5 o.ShipPostalCode, Sum(od.Quantity) [SumQuantity]
From dbo.[Order Details] as od Join dbo.Orders as o On od.OrderID = o.OrderID
Where o.ShipPostalCode is not NULL and o.OrderDate between DATEADD(year, -25, GETDATE()) and GETDATE()
Group By o.ShipPostalCode
Order By 2 Desc
Go


--17
Select c.City, Count(c.CustomerID) [Number of Customers]
From dbo.Customers as c
Group By c.City
Order By 1;
Go

--18
Select c.City, Count(c.CustomerID) [Number of Customers]
From dbo.Customers as c
Group By c.City
Having Count(c.CustomerID) >= 2
Order By 1;
Go



--19
Select c.ContactName, o.OrderDate
From dbo.Orders as o Join dbo.Customers as c On o.CustomerID = c.CustomerID 
Where o.OrderDate > '1998-01-01 00:00:00.000';
Go

--20
Select c.ContactName, Max(o.OrderDate) [Most recent order date]
From dbo.Orders as o Join dbo.Customers as c On o.CustomerID = c.CustomerID 
Group By c.ContactName;
Go

--21
Select o.CustomerID, Count(od.Quantity) [Count of products they bought]
From dbo.[Order Details] as od Join dbo.Orders as o On od.OrderID = o.OrderID
Group By o.CustomerID;
Go

--22
Select o.CustomerID, Count(od.Quantity) [Count of products they bought]
From dbo.[Order Details] as od Join dbo.Orders as o On od.OrderID = o.OrderID
Group By o.CustomerID
Having Count(od.Quantity) > 100;
Go

--23
Select Distinct sup.ContactName [Supplier Company Name],  s.CompanyName [Shipping Company Name]
From dbo.Suppliers as sup Join dbo.Products as p On sup.SupplierID = p.SupplierID
Join dbo.[Order Details] as od On p.ProductID = od.ProductID
Join dbo.Orders as o On od.OrderID = o.OrderID
Join dbo.Shippers as s On o.ShipVia = s.ShipperID;
Go

--24	
SELECT o.OrderDate, p.ProductName 
FROM dbo.Orders as o LEFT JOIN dbo.[Order Details] as od ON o.OrderID = od.OrderID
INNER JOIN Products as p ON od.ProductID = p.ProductID
GROUP BY o.OrderDate, p.ProductName
ORDER BY o.OrderDate;

--25 
Select e.EmployeeID, e.FirstName + e.LastName [FullName], e.Title, Count(e.EmployeeID) OVER(PARTITION BY e.Title) [Title Count],
RANK() OVER(PARTITION BY e.Title ORDER BY e.EmployeeID) [Rank]
From dbo.Employees as e

--26
SELECT e1.EmployeeId, e1.LastName, e1.FirstName, e2.ReportsTo, COUNT(e2.ReportsTo) AS Subordinate  
FROM dbo.Employees as e1 JOIN dbo.Employees as e2 ON e1.EmployeeId = e2.ReportsTo
WHERE e2.ReportsTo IS NOT NULL
GROUP BY e1.EmployeeId, e1.LastName, e1.FirstName, e2.ReportsTo
HAVING COUNT(e2.ReportsTo) > 2

--27
Select c.City, c.CompanyName, c.ContactName, 'Customer' [Type]
From dbo.Customers as c
Union
Select s.City, s.CompanyName, s.ContactName, 'Supplier' [Type]
From dbo.Suppliers as s