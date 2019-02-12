CREATE TABLE [dbo].[Accounts] (
    [username]   NVARCHAR (MAX) NOT NULL,
    [password]   NVARCHAR (MAX) NOT NULL,
    [areaCode]   INT            NOT NULL,
    [ID]         INT            IDENTITY (1, 1) NOT NULL,
    [sourceCode] INT            NOT NULL,
    CONSTRAINT [PK_Accounts] PRIMARY KEY CLUSTERED ([ID] ASC)
);

