IF ( OBJECT_ID('dbo.ClienteAdicionar') IS NOT NULL ) 
   DROP PROCEDURE [dbo].[ClienteAdicionar]
GO
CREATE PROCEDURE [dbo].[ClienteAdicionar]
	@cliNome varchar(50),
	@cliCpf varchar(50)
AS
BEGIN
	INSERT INTO [dbo].[Cliente] ([CliNome], [CliCpf]) 
		VALUES (@cliNome, @cliCpf)
END
GO

IF ( OBJECT_ID('dbo.ClienteAlterar') IS NOT NULL ) 
   DROP PROCEDURE [dbo].[ClienteAlterar]
GO
CREATE PROCEDURE [dbo].[ClienteAlterar]
	@cliCodigo int,
	@cliNome varchar(50),
	@cliCpf varchar(50)
AS
BEGIN
	UPDATE [dbo].[Cliente] 
		SET [CliNome] = @cliNome, 
			[CliCpf] = @cliCpf
		WHERE [CliCodigo] = @cliCodigo
END
GO

IF ( OBJECT_ID('dbo.ClienteBuscarPorCodigo') IS NOT NULL ) 
   DROP PROCEDURE [dbo].[ClienteBuscarPorCodigo]
GO
CREATE PROCEDURE [dbo].[ClienteBuscarPorCodigo]
	@cliCodigo int
AS
BEGIN
	SELECT [CliCodigo], 
		   [CliNome], 
		   [CliCpf] 
		FROM [dbo].[Cliente]
		WHERE [CliCodigo] = @cliCodigo
END
GO

IF ( OBJECT_ID('dbo.ClienteBuscarPorCpf') IS NOT NULL ) 
   DROP PROCEDURE [dbo].[ClienteBuscarPorCpf]
GO
CREATE PROCEDURE [dbo].[ClienteBuscarPorCpf]
	@cliCpf varchar(15)
AS
BEGIN
	SELECT [CliCodigo], 
		   [CliNome], 
		   [CliCpf] 
		FROM [dbo].[Cliente]
		WHERE [CliCpf] = @cliCpf
END
GO

IF ( OBJECT_ID('dbo.ClienteExcluir') IS NOT NULL ) 
   DROP PROCEDURE [dbo].[ClienteExcluir]
GO
CREATE PROCEDURE [dbo].[ClienteExcluir]
	@cliCodigo int
AS
BEGIN
	DELETE FROM [dbo].[Cliente] 
		WHERE [CliCodigo] = @cliCodigo
END
GO

IF ( OBJECT_ID('dbo.ClienteListar') IS NOT NULL ) 
   DROP PROCEDURE [dbo].[ClienteListar]
GO
CREATE PROCEDURE [dbo].[ClienteListar]
AS
BEGIN
	SELECT	[CliCodigo], 
			[CliNome], 
			[CliCpf] 
		FROM [dbo].[Cliente]
		ORDER BY [CliNome]
END
GO