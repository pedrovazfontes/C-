IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;

GO

CREATE TABLE [FormadePgto] (
    [Id] int NOT NULL IDENTITY,
    [Nome] VARCHAR(30) NULL,
    CONSTRAINT [PK_FormadePgto] PRIMARY KEY ([Id])
);

GO

CREATE TABLE [Pedidos] (
    [Id] int NOT NULL IDENTITY,
    [Data] datetime2 NOT NULL DEFAULT (GETDATE()),
    [NomeProduto] VARCHAR(80) NOT NULL,
    [formadeEntrega] nvarchar(max) NOT NULL,
    [Pago] BIT NOT NULL,
    [Valor] FLOAT NOT NULL,
    CONSTRAINT [PK_Pedidos] PRIMARY KEY ([Id])
);

GO

CREATE TABLE [Produtos] (
    [Id] int NOT NULL IDENTITY,
    [Data] datetime2 NOT NULL DEFAULT (GETDATE()),
    [Nome] VARCHAR(40) NULL,
    [Descricao] VARCHAR(80) NULL,
    [Quantidade] INTEGER NOT NULL,
    [ValorCompra] FLOAT NOT NULL,
    [ValorVenda] real NOT NULL DEFAULT CAST(0 AS real),
    [Lucro] real NOT NULL DEFAULT CAST(0 AS real),
    CONSTRAINT [PK_Produtos] PRIMARY KEY ([Id])
);

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20230325170928_PrimeiraMigracao', N'3.1.5');

GO

DECLARE @var0 sysname;
SELECT @var0 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Pedidos]') AND [c].[name] = N'Pago');
IF @var0 IS NOT NULL EXEC(N'ALTER TABLE [Pedidos] DROP CONSTRAINT [' + @var0 + '];');
ALTER TABLE [Pedidos] ALTER COLUMN [Pago] INTEGER NOT NULL;

GO

ALTER TABLE [Pedidos] ADD [FormadePgto] nvarchar(max) NULL;

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20230326043443_SegundaMigracao', N'3.1.5');

GO

