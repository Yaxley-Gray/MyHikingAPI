CREATE TABLE [dbo].[TrailsNormalised]
(
  [Id] UNIQUEIDENTIFIER NOT NULL,
  [Name] NVARCHAR(100) NOT NULL,
  [MountainId] UNIQUEIDENTIFIER NOT NULL,
  [Difficulty] NVARCHAR(100) NOT NULL,
  [Distance] DECIMAL(6,2) NOT NULL, -- this is in km 
  CONSTRAINT PK_TrailsNormalised PRIMARY KEY ([Id]),
  CONSTRAINT FK_Trails_MountainsId
      FOREIGN KEY ([MountainId])
    REFERENCES MountainsNormalised([Id])
);
