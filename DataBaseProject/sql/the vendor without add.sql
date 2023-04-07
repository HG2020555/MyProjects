SELECT VID,Vname
FROM vendor AS v
WHERE Not EXISTS(SELECT *
 FROM [Add] AS c
 WHERE c.VID = v.VID and (c.date  between '2021-1-1' and '2021-12-31'))