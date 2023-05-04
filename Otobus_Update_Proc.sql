alter Proc Otobus_Update_Proc(
@OtobusId int,
@Plaka nchar(10),
@Marka nvarchar(50),
@Firma nvarchar(50),
@Koltuk tinyint)
as
begin
  update Otobus
  set Plaka=@Plaka,
  Marka=@Marka,
  Firma=@Firma,
  Koltuk=@Koltuk
  where OtobusId=@OtobusId

end