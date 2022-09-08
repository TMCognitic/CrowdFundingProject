CREATE PROCEDURE [dbo].[CSP_AjoutUtilisateur]
	@Nom NVARCHAR(75),
	@Prenom NVARCHAR(75),
	@Email NVARCHAR(384),
	@Passwd NVARCHAR(20)
AS
BEGIN
	INSERT INTO [Utilisateur] (Nom, Prenom, Email, Passwd) VALUES (@Nom, @Prenom, @Email, HASHBYTES('SHA2_512', dbo.CSF_GetSalt() + @Passwd));
END
