alter proc Otobus_Delete_Proc(
@OtobusId int)
as
begin
 delete from Otobus
 where  OtobusId=@OtobusId
end