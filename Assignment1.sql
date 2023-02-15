Use AdventureWorks2019;

--1
Select p.ProductID, p.Name, p.Color, p.ListPrice
from Production.Product As p;


--2
Select p.ProductID, p.Name, p.Color, p.ListPrice
from Production.Product As p
where p.ListPrice != 0;


--3
Select p.ProductID, p.Name, p.Color, p.ListPrice
from Production.Product As p
where p.Color is null;

--4
Select p.ProductID, p.Name, p.Color, p.ListPrice
from Production.Product As p
where p.Color is not null;

--5
Select p.ProductID, p.Name, p.Color, p.ListPrice
from Production.Product As p
where p.Color is not null and p.ListPrice > 0;


--6.
Select p.Name + ' ' + p.Color AS [Answer of Q6]
from Production.Product As p
where p.Color is not null;


--7.
Select Top 6 'NAME: ' + p.Name + ' -- COLOR: ' + p.Color AS [Answer of Q7]
from Production.Product As p
where p.Color is not null;


--8.
Select p.ProductID, p.Name
from Production.Product As p
where p.ProductID between 400 and 500;


--9.
Select p.ProductID, p.Name, p.Color
from Production.Product As p
where p.Color in ('Black', 'Blue');
GO


--10.
Select p.Name, p.ListPrice
from Production.Product As p
where p.Name like '[S-Z]%'
Order By p.Name;
GO

--11
Select p.Name, p.ListPrice 
from Production.Product as p
where p.Name like 'S%'
order by p.name
Go

--12
Select p.Name, p.ListPrice
from Production.Product As p
where p.Name like '[AS]%'
Order By p.Name;
GO


--13
Select p.Name, p.ProductID
from Production.Product As p
where p.Name like 'SPO[^K]%'
Order By p.Name;
GO


--14
Select Distinct p.Color
from Production.Product As p
Order By p.Color Desc;


--15
Select Distinct p.ProductSubcategoryID, p.Color
from Production.Product As p
where p.ProductSubcategoryID is not NULL and p.Color is not NULL