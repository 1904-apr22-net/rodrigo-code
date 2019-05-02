--- EXERCISES

-- solve these with a mixture of joins, subqueries, CTE, and set operators.
-- solve at least one of them in two different ways, and see if the execution
-- plan for them is the same, or different.

-- 1. which artists did not make any albums at all?


SELECT  Name
FROM Artist 
WHERE ArtistId NOT IN(
	SELECT ArtistId
	FROM Album
)

-- 2. which artists did not record any tracks of the Latin genre?

SELECT ar.Name
FROM Artist AS ar
	LEFT JOIN Album as al ON al.ArtistId = ar.ArtistId
	LEFT JOIN Track as t ON t.AlbumID = al.AlbumId
	LEFT JOIN Genre as g ON g.GenreId = al.AlbumId
WHERE g.Name = 'Latin'

-- 3. which video track has the longest length? (use media type table)
SELECT MAX(Milliseconds)
FROM Track as t
	LEFT JOIN MediaType as mt ON mt.MediaTypeId = mt.MediaTypeId
--GROUP BY t.Name
--ORDER BY Milliseconds DESC

-- 4. find the names of the customers who live in the same city as the
--    boss employee (the one who reports to nobody)

-- 5. how many audio tracks were bought by German customers, and what was
--    the total price paid for them?

-- 6. list the names and countries of the customers supported by an employee
--    who was hired younger than 35.