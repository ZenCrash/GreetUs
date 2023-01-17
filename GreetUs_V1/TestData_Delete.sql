/* CREATE WEXO_GREETME DATABASE */

IF NOT EXISTS (SELECT * FROM sys.databases WHERE name = 'GreetUs')
	BEGIN
		CREATE DATABASE [GreetUs];
	END;
GO

/* CREATE TABELS */

USE [GreetUs]
GO

CREATE TABLE [dbo].[views](
	[id] [uniqueidentifier] PRIMARY KEY IDENTITY(1,1) NOT NULL,
	[view_name] [nvarchar](50) NOT NULL,
	[has_birthday] [bit] NOT NULL,
	[has_anniversary] [bit] NOT NULL
	)
GO