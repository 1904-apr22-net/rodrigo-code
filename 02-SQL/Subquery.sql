-- subqueries another way to combine data from multiple tables
-- (Joins and Set operators are the other way)

-- every JOIN query can be converted into a subquery-based query.

-- we just use queries inside other queries with the help of some operators 
-- IN, NOT IN, ANY, ALL , EXISTS

-- every track that has never been purchased
SELECT TrackId, Name
FROM Track
WHERE TrackId NOT IN(
	SELECT TrackId
	FROM InvoiceLine
)

-- the track that has been bought the most time
SELECT Name
FROM Track
WHERE TrackId = (
	SELECT	TOP(1) TrackId
	FROM InvoiceLine
	GROUP BY TrackId
	ORDER BY SUM(Quantity) DESC
)

--ANY/ALL

--the artist who made the album with the longest title

SELECT *
FROM Artist
WHERE ArtistId = (
	SELECT ArtistId
	FROM  Album	
	WHERE LEN(Title) >= ALL (
		SELECT LEN(Title) From Album
	)
)
SELECT * 
FROM Track

