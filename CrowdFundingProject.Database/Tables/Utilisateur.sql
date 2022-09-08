CREATE TABLE [dbo].[Utilisateur]
(
	[Id] INT NOT NULL, 
	[Nom] NVARCHAR(75) NOT NULL,
	[Prenom] NVARCHAR(75) NOT NULL,
	[Email] NVARCHAR(384) NOT NULL,
	[Passwd] BINARY(64) NOT NULL,
    CONSTRAINT [PK_Utilisateur] PRIMARY KEY ([Id])
);
