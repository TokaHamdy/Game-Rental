/*A*/
select game_name , count_g from game 
where count_g = (select max(count_g) from game)


/*b*/
select   g.game_name from game g  
EXCEPT
select Game_name 
from RentDate
where DATEPART(m,c_time)>=DATEPART(m,DATEADD(m,-1,GETDATE())) and DATEPART(year,c_time)=DATEPART(year,GETDATE())

/* c  */
select w.Client_ID ,max(w.c) as MaxRent
from(SELECT Client_ID,COUNT(*) c
from RentDate where DATEPART(m,c_time)>=DATEPART(m,DATEADD(m,-1,GETDATE())) and DATEPART(year,c_time)=DATEPART(year,GETDATE()) GROUP BY Client_ID)w
GROUP BY Client_ID
having max(w.c)=(select max(w.c)
from(SELECT Client_ID,COUNT(*) as c
from RentDate where DATEPART(m,c_time)>=DATEPART(m,DATEADD(m,-1,GETDATE())) and DATEPART(year,c_time)=DATEPART(year,GETDATE()) GROUP BY Client_ID)w)


/*d  */
select w.Vendor_ID ,max(w.c) as MaxRent
from(SELECT Vendor_ID,COUNT(*) c
from RentDate where DATEPART(m,c_time)>=DATEPART(m,DATEADD(m,-1,GETDATE())) and DATEPART(year,c_time)=DATEPART(year,GETDATE()) GROUP BY Vendor_ID)w
GROUP BY Vendor_ID
having max(w.c)=(select max(w.c)
from(SELECT Vendor_ID,COUNT(*) as c
from RentDate where DATEPART(m,c_time)>=DATEPART(m,DATEADD(m,-1,GETDATE())) and DATEPART(year,c_time)=DATEPART(year,GETDATE()) GROUP BY Vendor_ID)w)



/*e*/
select   g.vendor_ID from game g  
EXCEPT
select vendor_ID 
from RentDate
where DATEPART(m,c_time)>=DATEPART(m,DATEADD(m,-1,GETDATE())) and DATEPART(year,c_time)=DATEPART(year,GETDATE())





/*f*/
select   g.vendor_ID from game g  
group by vendor_ID
EXCEPT
select   g.vendor_ID from game g
where  game_year>=DATEPART(year,DATEADD(year,-1,GETDATE()))



