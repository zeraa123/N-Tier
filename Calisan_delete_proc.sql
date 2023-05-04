Create proc Calisan_delete_proc(
@id int)
as
begin 
 if @id>0
 begin
  delete from Calisan
  where @id=Id
 end
end
