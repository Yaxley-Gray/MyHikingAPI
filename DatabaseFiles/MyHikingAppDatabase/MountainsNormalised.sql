CREATE TABLE [dbo].[MountainsNormalised]
(
  [Id] UNIQUEIDENTIFIER NOT NULL,
  [Name] NVARCHAR(100) NOT NULL,
  [Height] INT NOT NULL,
  [LocationId] UNIQUEIDENTIFIER NOT NULL,
  CONSTRAINT PK_MountainsNormalised PRIMARY KEY ([Id]),
  CONSTRAINT FK_MountainsNormalised_Locations 
      FOREIGN KEY ([LocationId])
    REFERENCES LocationsTable([Id])
);
