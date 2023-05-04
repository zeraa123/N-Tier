alter proc entity_facade2
(@Adi nvarchar(50),
@Soyadi nvarchar(50),
@Cinsiyet char(1),
@TcNo char(11),
@id int)
as
begin
   Update Musteri 
   set Adi=@Adi, Soyadi=@Soyadi,
   Cinsiyet=@Cinsiyet,TcNo=@TcNo
   where Id=@id
end;
