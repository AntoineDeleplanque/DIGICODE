
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, and Azure
-- --------------------------------------------------
-- Date Created: 05/12/2014 12:27:20
-- Generated from EDMX file: C:\Users\AntoineD\Documents\DEV_BTS\PPE4\DigiCode\DigiCode\DigiCode\DbModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [DigiCode];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[SalleEntityJeu]', 'U') IS NOT NULL
    DROP TABLE [dbo].[SalleEntityJeu];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'SalleEntityJeu'
CREATE TABLE [dbo].[SalleEntityJeu] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [Libelle] nvarchar(max)  NOT NULL,
    [Code] nvarchar(max)  NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [ID] in table 'SalleEntityJeu'
ALTER TABLE [dbo].[SalleEntityJeu]
ADD CONSTRAINT [PK_SalleEntityJeu]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------