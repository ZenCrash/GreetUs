/* CREATE WEXO_GREETME DATABASE */

IF NOT EXISTS (SELECT * FROM sys.databases WHERE name = 'WEXO_GreetMe')
	BEGIN
		CREATE DATABASE [WEXO_GreetMe];
	END;
GO

/* CREATE TABELS */

USE [WEXO_GreetMe]
GO

CREATE TABLE [dbo].[views](
	[id] [int] PRIMARY KEY IDENTITY(1,1) NOT NULL,
	[view_name] [nvarchar](50) NOT NULL,
	[has_birthday] [bit] NOT NULL,
	[has_anniversary] [bit] NOT NULL
	)