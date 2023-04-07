SELECT client.CID,client.Cname,
	  count(client.CID) as Total_Rentals
  FROM rent inner join client
  on rent.CID=client.CID and (rent.rent_date  between '2022-4-1' and '2022-4-30')
 group by rent.CID,client.CID,client.Cname
 ORDER BY Total_Rentals desc