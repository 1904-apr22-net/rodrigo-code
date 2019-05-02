-- comments with --

-- many statements in one file like this...
-- the "execute" buttin (F5) will run all the statements

--when we don't want to run the whole file, we highlight what we want to run
-- and then hit F5.

--SQL has many commands/statements
-- the first category is called DML
	-- Data Manipulation Language
	
-- the most complicated/important DML statement is the SELECT statement. 
	-- What we use to read from database tables.
SELECT 'Hello World'; --prints hello world
--  all rows and all columns of a table
--Prints out all of the SalesLT table
SELECT *
FROM SalesLT.SalesOrderHeader;
-- Print out just certain columns (lastname, companyname)
SELECT LastName, CompanyName FROM SalesLT.Customer;
-- Print out only certain rows. Condition: Works at "A Bike Store"
SELECT FirstName, LastName, CompanyName FROM SalesLT.Customer WHERE CompanyName = 'A Bike Store'
-- Select customers where country is not US
SELECT FirstName, LastName, CustomerID, CountryRegion FROM SalesLT.Customer, SalesLT.Address 
WHERE CountryRegion != 'United States'
--Select customers from Brazil
SELECT FirstName, LastName, CustomerID, CountryRegion FROM SalesLT.Customer, SalesLT.Address 
WHERE CountryRegion = 'Brazil'
-- Print out all different countries in address
SELECT Distinct CountryRegion From SalesLT.Address
--How many invoices in 2009 and total sales
SELECT COUNT(ModifiedDate) FROM SalesLT.SalesOrderDetail
Where ModifiedDate LIKE '%2009%'
-- Sum of sales with no discount
SELECT SUM(LineTotal) FROM SalesLT.SalesOrderDetail
Where ModifiedDate LIKE '%2008%'
-- Total sales per countrySELECT COUNT(ModifiedDate) FROM SalesLT.SalesOrderDetail
SELECT COUNT(ModifiedDate) FROM SalesLT.SalesOrderDetail, 
Where ModifiedDate LIKE '%2009%'