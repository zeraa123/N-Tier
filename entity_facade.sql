Alter Proc entity_facade
(@Adi nvarchar(50),
@Soyadi nvarchar(50),
@Cinsiyet char(1),
@TcNo char(11))
as
begin
  Insert into Musteri(Adi,Soyadi,Cinsiyet,TcNo)
  Values(@Adi,@Soyadi,@Cinsiyet,@TcNo);
end;
