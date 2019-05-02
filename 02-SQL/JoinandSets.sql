-- every track with his genre
SELECT COUNT(Track.Name), Track.Name, Genre.Name
FROM Track	
	LEFT OUTER JOIN Genre ON Track.GenreId = Genre.GenreId
GROUP BY Track.Name, Genre.Name
ORDER BY COUNT(Track.Name) AS 'Total'

SELECT COALESCE(ar.Name, 'Unkown Artist'), t.Name
FROM Track AS t
	LEFT JOIN Genre as g ON t.GenreId = g.GenreId
	LEFT JOIN Album as Al ON t.ALBUMID = al.AlbumId
	LEFT JOIN Artist as Ar ON al.ArtistId = ar.ArtistId
WHERE g.Name = 'Rock'

--set opertors --
-- these operators are going to suppress duplicates
-- and implement "Set union" "set intersection" and "set difference"

--UNION
--gives all result from two queries combined

--all first names of customers or employees
SELECT FirstName 
FROM Employee
UNION
SELECT FirstName From Customer

--we can switch off removing duplicates using all
SELECT FirstName
FROM Employee
UNION ALL
SELECT FirstName From Customer

-- that is "set untion"
-- every customer first name that is also an employee first name
SELECT FirstName
FROM Employee
INTERSECT
SELECT FirstName
FROM Customer

-- Set intrsection is like a big AND
-- set difference implemented by EXCEPT 

-- every employee first name that is not a customer name
SELECT FirstName
FROM Employee
EXCEPT 
SELECT FirstName
FROM Customer
