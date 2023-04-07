SELECT distinct c.GID,c.Gname,c.state,c.category
FROM Game AS c,rent as o
WHERE o.GID != c.GID and not EXISTS(SELECT *
 FROM [rent] AS o
 WHERE o.GID = c.GID and (o.rent_date  between '2022-4-1' and '2022-4-30'))