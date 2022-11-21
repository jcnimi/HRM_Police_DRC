-- insert into [dbo].[village]
select [Villages] description, 
(select [id_secteur]
 from [dbo].[secteur] s
 join [dbo].[territoire] t on t.[id_territoire] = s.[id_territoire]
 where s.[nom] = lv.[Secteur] and lv.[Territoire] = t.[nom]
 ) [secteur],
 sysdatetime(),
 1 [cree_par],
 (select s.nom
 from [dbo].[secteur] s
 join [dbo].[territoire] t on t.[id_territoire] = s.[id_territoire]
 where s.[nom] = lv.[Secteur] and lv.[Territoire] = t.[nom]
 ) [secteur_name]
from [dbo].[Liste_Villages_RDC] lv
--where lv.Villages = 'kikanga'



delete from village where id_village > 1

Select 0 value, 'Select' display 
union
select a.secteur as value, b.nom as display
from village a
join secteur b on a.secteur = b.id_secteur
where a.[description] = 'ngulungu'


Select 0 value, 'Select' display 
union
select a.id_territoire as value, B.nom as display
from secteur a
join [territoire] b on b.id_territoire = a.id_territoire
where a.nom 

