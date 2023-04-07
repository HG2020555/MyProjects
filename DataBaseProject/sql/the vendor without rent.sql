SELECT distinct v.VID,v.Vname
FROM vendor as v,Game AS G,rent as O
WHERE v.VID = G.VID or v.VID != G.VID AND not EXISTS(SELECT *
 FROM [rent] AS o	 
 WHERE o.GID = G.GID and (o.rent_date   between '2022-4-1' and '2022-4-30'))
 except
 SELECT distinct v.VID,v.Vname
FROM vendor as v,Game AS G,rent as O
WHERE v.VID = G.VID AND  EXISTS(SELECT *
 FROM [rent] AS o	 
 WHERE o.GID = G.GID and (o.rent_date   between '2022-4-1' and '2022-4-30'))