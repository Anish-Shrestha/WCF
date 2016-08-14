Create procedure spGetEmployee
@Id int
as 
Begin
	Select Id, Name, Gender, DateOfBirth	
	from tblEmployee
	where Id = @Id
End