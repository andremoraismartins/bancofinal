IF ( OBJECT_ID('dbo.ContaCorrenteAdicionar') IS NOT NULL ) 
   DROP PROCEDURE [dbo].[ContaCorrenteAdicionar]
GO
CREATE PROCEDURE [dbo].[ContaCorrenteAdicionar]
	@conSaldo decimal(15, 2),
	@cliCodigo int
AS
BEGIN
	INSERT INTO [dbo].[ContaCorrente] ([ConSaldo], [CliCodigo]) 
		VALUES (@conSaldo, @cliCodigo)
END
GO

IF ( OBJECT_ID('dbo.ContaCorrenteAlterar') IS NOT NULL ) 
   DROP PROCEDURE [dbo].[ContaCorrenteAlterar]
GO
CREATE PROCEDURE [dbo].[ContaCorrenteAlterar]
	@conCodigo int,
	@conSaldo decimal(15,2),
	@cliCodigo int
AS
BEGIN
	UPDATE [dbo].[ContaCorrente] 
		SET [ConSaldo] = @conSaldo, 
			[CliCodigo] = @cliCodigo
		WHERE [ConCodigo] = @conCodigo
END
GO

IF ( OBJECT_ID('dbo.ContaCorrenteBuscarPorCodigo') IS NOT NULL ) 
   DROP PROCEDURE [dbo].[ContaCorrenteBuscarPorCodigo]
GO
CREATE PROCEDURE [dbo].[ContaCorrenteBuscarPorCodigo]
	@conCodigo int
AS
BEGIN
	SELECT	[ConCodigo], 
			[ConSaldo], 
			[CliCodigo] 
		FROM [dbo].[ContaCorrente]
		WHERE [ConCodigo] = @conCodigo
END
GO

IF ( OBJECT_ID('dbo.ContaCorrenteBuscarPorCliente') IS NOT NULL ) 
   DROP PROCEDURE [dbo].[ContaCorrenteBuscarPorCliente]
GO
CREATE PROCEDURE [dbo].[ContaCorrenteBuscarPorCliente]
	@cliCodigo int
AS
BEGIN
	SELECT	[ConCodigo], 
			[ConSaldo], 
			[CliCodigo] 
		FROM [dbo].[ContaCorrente]
		WHERE [CliCodigo] = @cliCodigo
END
GO

IF ( OBJECT_ID('dbo.ContaCorrenteExcluir') IS NOT NULL ) 
   DROP PROCEDURE [dbo].[ContaCorrenteExcluir]
GO
CREATE PROCEDURE [dbo].[ContaCorrenteExcluir]
	@conCodigo int
AS
BEGIN
	DELETE FROM [dbo].[ContaCorrente] 
		WHERE [ConCodigo] = @conCodigo
END
GO

IF ( OBJECT_ID('dbo.ContaCorrenteListar') IS NOT NULL ) 
   DROP PROCEDURE [dbo].[ContaCorrenteListar]
GO
CREATE PROCEDURE [dbo].[ContaCorrenteListar]
AS
BEGIN
	SELECT	[ConCodigo],
			[ConSaldo],
			[CliCodigo]
		FROM [dbo].[ContaCorrente]
END
GO

IF ( OBJECT_ID('dbo.ContaCorrenteListarCompleto') IS NOT NULL ) 
   DROP PROCEDURE [dbo].[ContaCorrenteListarCompleto]
GO
CREATE PROCEDURE [dbo].[ContaCorrenteListarCompleto]
AS
BEGIN
	SELECT	[ContaCorrente].[ConCodigo],
			[ContaCorrente].[ConSaldo],
			[Cliente].[CliCodigo],
			[Cliente].[CliNome],
			[Cliente].[CliCpf]
		FROM [dbo].[ContaCorrente]
		INNER JOIN [dbo].[Cliente] ON ([Cliente].[CliCodigo] = [ContaCorrente].[CliCodigo])
		ORDER BY [Cliente].[CliNome]
END
GO