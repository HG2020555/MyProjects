SELECT  vendor.VID,vendor.Vname,
	 count(*) as Total_Rented
  FROM rent inner join [Add]
  on rent.GID=[Add].GID 
  inner join vendor
 on vendor.VID=[Add].VID and rent.rent_date between '2022-4-1' and '2022-4-30'
 group by vendor.VID,vendor.Vname
 ORDER BY Total_Rented desc