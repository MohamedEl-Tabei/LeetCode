SELECT name AS results
FROM
    (
    SELECT TOP(1) U.name, COUNT(U.name) AS NUM
    FROM Users U
    JOIN MovieRating MR
    ON U.user_id = MR.user_id      
    GROUP BY U.name
    ORDER BY   NUM DESC, U.name ASC
    ) AS T1
UNION ALL
SELECT title AS results
FROM
    (
    SELECT TOP(1) M.title, AVG(1.00 * MR.rating)  AS NUM
    FROM Movies M
    JOIN MovieRating MR
    ON M.movie_id = MR.movie_id AND DATEDIFF(day, '2020-02-01', MR.created_at) >= 0 AND DATEDIFF(day, MR.created_at, '2020-03-01') > 0         
    GROUP BY M.title
    ORDER BY NUM DESC, M.title ASC
    ) AS T2
