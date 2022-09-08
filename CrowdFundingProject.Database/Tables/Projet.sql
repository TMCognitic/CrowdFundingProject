CREATE TABLE [dbo].[Projet]
(
	[Id] INT NOT NULL IDENTITY,
	[Nom] NVARCHAR(256) NOT NULL,
	[Objectif] INT NOT NULL,
	[UtilisateurId] INT NOT NULL,
	CONSTRAINT PK_Projet PRIMARY KEY (Id),
	CONSTRAINT CK_Projet_Objectif CHECK (Objectif > 0),
	CONSTRAINT FK_Projet_Utilisateur FOREIGN KEY ([UtilisateurId]) REFERENCES [Utilisateur]([Id])
);
