--Select
Select ContactName Adi,CompanyName SirketAdi,City Sehir from Customers

Select * from Customers where City = 'London'

Select * from products where categoryId=1 or categoryId=3

Select * from products where categoryId=1 or UnitPrice>=10

Select * from products where CategoryID=1 order by UnitPrice desc --ascending artan anlamına gelir. --desc, descending azalan yani düşen anlamına gelir.

Select count(*) from Products where CategoryID = 2

Select CategoryID,count(*) from Products where UnitPrice>20 group by CategoryID having count(*)<10 --having sayesinde 10 taneden az olan ürün çeşitlerini listeledik.

select Products.ProductID, Products.ProductName, products.UnitPrice, Categories.CategoryName
from products inner join Categories
on Products.CategoryID = Categories.CategoryId
where Products.UnitPrice>10


--Dto Data Transformation Object

Select * from Products p left join [Order details] od
on p.ProductID = od.ProductID

inner join Orders o
on o.OrderID = od.OrderID

Select * from Customers c left join Orders o
on c.CustomerID = o.CustomerID
where o.CustomerID is null












