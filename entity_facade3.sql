alter proc entity_facade(
@Id int)
as
begin 
  if @Id>0
  begin
   delete from Musteri
   where Id=@Id
  end
end