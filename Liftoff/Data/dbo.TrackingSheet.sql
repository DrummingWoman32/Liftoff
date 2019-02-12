CREATE TABLE [dbo].[TrackingSheet] (
    [date]      NVARCHAR (MAX) NOT NULL,
    [ID]        INT            IDENTITY (1, 1) NOT NULL,
    [AccountID] INT            NOT NULL,
    CONSTRAINT [PK_TrackingSheet] PRIMARY KEY CLUSTERED ([ID] ASC),
    CONSTRAINT [FK_TrackingSheet_Accounts_AccountID] FOREIGN KEY ([AccountID]) REFERENCES [dbo].[Accounts] ([ID])
);


GO
CREATE NONCLUSTERED INDEX [IX_TrackingSheet_AccountID]
    ON [dbo].[TrackingSheet]([AccountID] ASC);

