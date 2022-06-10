CREATE PROCEDURE dbo.spTableOperations
	@NameOfOperations nvarchar(50),
	@ValueToChange money,
	@Notes nvarchar(150),
	@Id int = 0 output
AS
BEGIN
	SET NOCOUNT ON;
	insert into dbo.tableOperations(NameOfOperation, ValueToChange, Notes)
	values(@NameOfOperations, @ValueToChange, @Notes);

	select @Id = SCOPE_IDENTITY();
END
GO