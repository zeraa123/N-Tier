alter proc Calisan_Update_proc
(@Adi nvarchar(50),
@Soyadi nvarchar(50),
@Cinsiyet char(1),
@TcNo char(11),
@Id int)
as
begin
   Update Calisan 
   set Adi=@Adi, Soyadi=@Soyadi,
   Cinsiyet=@Cinsiyet,TcNo=@TcNo
   where Id=@Id
end;