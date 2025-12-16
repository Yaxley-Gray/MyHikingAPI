CREATE TABLE [dbo].[TrailsTable]
(
  [Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY DEFAULT NEWID(),
  [Name] NVARCHAR(100) NOT NULL,
  [MountainId] UNIQUEIDENTIFIER NOT NULL,
  [Difficulty] NVARCHAR(100) NOT NULL,
  [Distance] DECIMAL(6,2) NOT NULL, -- this is in km 
  CONSTRAINT FK_Trails_MountainsId
      FOREIGN KEY ([MountainId])
    REFERENCES MountainsTable([Id])
);
