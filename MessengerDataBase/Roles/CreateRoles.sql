USE [MessengerDb]
GO
CREATE LOGIN [Moderator] WITH PASSWORD = '12345';
GO
CREATE USER [Moderator] FOR LOGIN [Moderator]
GO
CREATE ROLE moderators AUTHORIZATION [Moderator];
GO
ALTER ROLE moderators ADD MEMBER [Moderator];
GO
DENY CREATE TABLE, CREATE PROCEDURE
    TO [Moderator];
GO