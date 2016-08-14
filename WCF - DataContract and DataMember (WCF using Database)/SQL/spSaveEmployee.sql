Create procedure spSaveEmployee
@Id int,
@Name nvarchar(50),
@Gender nvarchar(50),
@DateOfBirth DateTime
as 
Begin
	Insert into tblEmployee
	values (@Id, @Name, @Gender, @DateOfBirth)
End