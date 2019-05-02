--SELECT clauses
	-- SELECT
	-- FROM
	-- WHERE
-- SELECT (some set of columns)
-- FROM (a table)
-- WHERE (the column value meet some condition)

SELECT FirstName, LastName
FROM SalesLT.Customer
WHERE FirstName = 'John'

-- "the select list" can have many expressions
SELECT	1, CURRENT_TIMESTAMP, SUBSTRING(FirstName, 1, 1), FirstName+' '+LastName AS [Full Name]
From SalesLT.Customer
WHERE FirstName = 'John'

-- The number of times each first name occurs
SELECT COUNT(*) AS Number, FirstName
FROM SalesLT.Customer
GROUP BY FirstName
-- Count anything when groupby is around
-- means the number of rowss that were combined into the given result row

-- when we 

-- GRROUP BY runs after WHERE
-- Having instead of WHERE


-- number of duplicates of first name beside john, if at least 3. 
-- sorted by number and by first name alphabetically
SELECT COUNT(*) AS Number, FirstName
FROM SalesLT.Customer
WHERE FirstName <> 'John'
GROUP BY FirstName
HAVING COUNT(*) >= 3
ORDER BY Number DESC, FirstName 


-- DISTINCT filters 100% dupplicate rows from the result
-- TOP(n)
-- e.g. to get the max result for some value, order by that value DESC, then use TOP(1)

-- logical order of execution of a SELECT statement

-- 1. FROM
-- 2. WHERE
-- 3. GROUP BY
-- 4. HAVING
-- 5. SELECT
-- 6. ORDER BY