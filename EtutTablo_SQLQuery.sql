CREATE PROCEDURE etutTablo
as
select ID,DERSAD,TBL_OGRETMEN.ADSOYAD as '��RETMEN',TAR�H,SAAT,DURUM from TBL_ETUT
inner join TBL_DERSLER
on TBL_DERSLER.DERSID=TBL_ETUT.DERSID
inner join TBL_OGRETMEN
on TBL_ETUT.OGRETMENID=TBL_OGRETMEN.OGRTID