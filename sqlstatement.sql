SELECT name,title,genre,year,duration
FROM songs
INNER JOIN artists
ON songs.id_artist = artists.id
WHERE year = 2021
ORDER BY name ASC
