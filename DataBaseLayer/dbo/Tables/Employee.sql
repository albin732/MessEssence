CREATE TABLE [dbo].[Employee]
(
	[EmployeeId] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Name] VARCHAR(50) NULL, 
    [DepartmentId] INT NOT NULL, 
    [Address] NVARCHAR(50) NULL, 
    [IsDeleted] BIT NULL, 
    CONSTRAINT [FK_Employee_Department] FOREIGN KEY ([DepartmentId]) REFERENCES [Department]([DepartmentId])
)
