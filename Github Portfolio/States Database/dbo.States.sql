CREATE TABLE [dbo].[States] (
    [StateID]                    INT            IDENTITY (1, 1) NOT NULL,
    [State Name]                 NVARCHAR (50)  NOT NULL,
    [Population (millions)]      NVARCHAR(50)  NOT NULL,
    [State Flag]                 NVARCHAR (MAX) NOT NULL,
    [State Flower]               NVARCHAR (50)  NOT NULL,
    [State Bird]                 NVARCHAR (50)  NOT NULL,
    [State Colors]               NVARCHAR (50)  NOT NULL,
    [Largest Cities]             NVARCHAR (50)  NOT NULL,
    [State Capitol]              NVARCHAR (50)  NOT NULL,
    [Median Income]              NVARCHAR(50)          NOT NULL,
    [% of Computer-Related Jobs] NVARCHAR(50)  NOT NULL,
    PRIMARY KEY CLUSTERED ([StateID] ASC)
);

