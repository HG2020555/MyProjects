SELECT Game.GID,Game.gname,
	  count(*) as Total_Rented
  FROM rent inner join Game
  on rent.GID=Game.GID and rent.rent_date between '2022-4-1' and '2022-4-30'
 group by rent.GID,Game.GID,Game.Gname
 ORDER BY Total_Rented desc