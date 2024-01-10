CREATE TABLE [dbo].[Patients]
(
	[PatientId] INT NOT NULL PRIMARY KEY, 
    [fName] NVARCHAR(50) NULL, 
    [lName] NVARCHAR(50) NULL, 
    [Gender] NCHAR(10) NULL, 
    [Age] INT NULL, 
    [BloodGroup] NCHAR(10) NULL, 
    [CNIC] DECIMAL NULL
)
