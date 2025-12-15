CREATE TABLE [dbo].[MountainsTable]
(
  [Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY DEFAULT NEWID(),
  [Name] NVARCHAR(100) NOT NULL,
  [Height] INT NOT NULL,
  [Location_Id] UNIQUEIDENTIFIER NOT NULL,
  CONSTRAINT FK_Mountains_Locations FOREIGN KEY (Location_Id)
    REFERENCES [dbo].[LocationsTable] ([Id])
);
