CREATE TABLE [dbo].[Employee]
(
	[EmployeeId] INT NOT NULL PRIMARY KEY IDENTITY, 
    [EmployeeName] VARCHAR(50) NULL, 
    [DepartmentId] INT NOT NULL, 
    CONSTRAINT [FK_Employee_Department] FOREIGN KEY ([DepartmentId]) REFERENCES [Department]([DepartmentId])
)
