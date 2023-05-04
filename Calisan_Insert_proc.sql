Alter Proc Calisan_Insert_proc(
@Adi nvarchar(50),
@Soyadi nvarchar(50),
@Cinsiyet char(1),
@TcNo char(11))
as
begin
  Insert into Calisan(Adi,Soyadi,Cinsiyet,TcNo)
  Values(@Adi,@Soyadi,@Cinsiyet,@TcNo);
end