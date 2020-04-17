
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 03/31/2020 15:51:21
-- Generated from EDMX file: E:\Visual Studio Projects\MyPhotos\MyPhotos\Model\MyPhotos.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [MyPhotos];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_MultimediaPerson]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[People] DROP CONSTRAINT [FK_MultimediaPerson];
GO
IF OBJECT_ID(N'[dbo].[FK_PersonPhoto]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Photos] DROP CONSTRAINT [FK_PersonPhoto];
GO
IF OBJECT_ID(N'[dbo].[FK_MultimediaLocation]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Locations] DROP CONSTRAINT [FK_MultimediaLocation];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Multimedia]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Multimedia];
GO
IF OBJECT_ID(N'[dbo].[People]', 'U') IS NOT NULL
    DROP TABLE [dbo].[People];
GO
IF OBJECT_ID(N'[dbo].[Locations]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Locations];
GO
IF OBJECT_ID(N'[dbo].[Photos]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Photos];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Multimedia'
CREATE TABLE [dbo].[Multimedia] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Path] nvarchar(250)  NOT NULL,
    [Description] nvarchar(400)  NOT NULL,
    [Event] nvarchar(100)  NOT NULL,
    [Weather] tinyint  NOT NULL,
    [DateCreated] datetime  NOT NULL,
    [DateAdded] datetime  NOT NULL,
    [DateModified] datetime  NOT NULL,
    [Deleted] bit  NOT NULL,
    [AdditionalLabels] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'People'
CREATE TABLE [dbo].[People] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [FirstName] nvarchar(40)  NOT NULL,
    [LastName] nvarchar(40)  NOT NULL,
    [Age] smallint  NULL,
    [MultimediaId] int  NOT NULL
);
GO

-- Creating table 'Locations'
CREATE TABLE [dbo].[Locations] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(100)  NOT NULL,
    [Scenery] nvarchar(100)  NOT NULL,
    [ZipCode] nvarchar(16)  NOT NULL,
    [Longitude] decimal(11,8)  NULL,
    [Latitude] decimal(10,8)  NULL,
    [MultimediaId] int  NOT NULL
);
GO

-- Creating table 'Photos'
CREATE TABLE [dbo].[Photos] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [X] int  NOT NULL,
    [Y] int  NOT NULL,
    [Width] int  NOT NULL,
    [Height] int  NOT NULL,
    [Person_Id] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Multimedia'
ALTER TABLE [dbo].[Multimedia]
ADD CONSTRAINT [PK_Multimedia]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'People'
ALTER TABLE [dbo].[People]
ADD CONSTRAINT [PK_People]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Locations'
ALTER TABLE [dbo].[Locations]
ADD CONSTRAINT [PK_Locations]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Photos'
ALTER TABLE [dbo].[Photos]
ADD CONSTRAINT [PK_Photos]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [MultimediaId] in table 'People'
ALTER TABLE [dbo].[People]
ADD CONSTRAINT [FK_MultimediaPerson]
    FOREIGN KEY ([MultimediaId])
    REFERENCES [dbo].[Multimedia]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_MultimediaPerson'
CREATE INDEX [IX_FK_MultimediaPerson]
ON [dbo].[People]
    ([MultimediaId]);
GO

-- Creating foreign key on [Person_Id] in table 'Photos'
ALTER TABLE [dbo].[Photos]
ADD CONSTRAINT [FK_PersonPhoto]
    FOREIGN KEY ([Person_Id])
    REFERENCES [dbo].[People]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PersonPhoto'
CREATE INDEX [IX_FK_PersonPhoto]
ON [dbo].[Photos]
    ([Person_Id]);
GO

-- Creating foreign key on [MultimediaId] in table 'Locations'
ALTER TABLE [dbo].[Locations]
ADD CONSTRAINT [FK_MultimediaLocation]
    FOREIGN KEY ([MultimediaId])
    REFERENCES [dbo].[Multimedia]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_MultimediaLocation'
CREATE INDEX [IX_FK_MultimediaLocation]
ON [dbo].[Locations]
    ([MultimediaId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------