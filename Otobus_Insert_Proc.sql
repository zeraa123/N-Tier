Alter Proc Otobus_Insert_Proc(
@Plaka nchar(10),
@Marka nvarchar(50),
@Firma nvarchar(50),
@Koltuk tinyint)
as
begin
 Insert into Otobus(Plaka,Marka,Firma,Koltuk)
 Values(@Plaka,@Marka,@Firma,@Koltuk)
end