-- Script Date: 4/5/2017 4:42 PM  - ErikEJ.SqlCeScripting version 3.5.2.64
CREATE TABLE [restaurants] (
  [Id] INTEGER NOT NULL
, [Name] TEXT NOT NULL
, [Category] TEXT NOT NULL
, [LastVisit] TEXT NULL
, CONSTRAINT [PK_restaurants] PRIMARY KEY ([Id])
);
