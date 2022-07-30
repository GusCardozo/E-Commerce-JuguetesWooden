IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;

GO

CREATE TABLE [CarritoCompras] (
    [Id] int NOT NULL IDENTITY,
    [TotalCompra] decimal(18,2) NOT NULL,
    CONSTRAINT [PK_CarritoCompras] PRIMARY KEY ([Id])
);

GO

CREATE TABLE [CategoriaJuguetes] (
    [Id] int NOT NULL IDENTITY,
    [Nombre] nvarchar(max) NULL,
    CONSTRAINT [PK_CategoriaJuguetes] PRIMARY KEY ([Id])
);

GO

CREATE TABLE [Roles] (
    [Id] int NOT NULL IDENTITY,
    [Descripcion] nvarchar(max) NULL,
    CONSTRAINT [PK_Roles] PRIMARY KEY ([Id])
);

GO

CREATE TABLE [Juguetes] (
    [Id] int NOT NULL IDENTITY,
    [Nombre] nvarchar(max) NULL,
    [Foto] nvarchar(max) NULL,
    [Descripcion] nvarchar(max) NULL,
    [Precio] decimal(18,2) NOT NULL,
    [IdCategoria] int NOT NULL,
    [CategoriaId] int NULL,
    CONSTRAINT [PK_Juguetes] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Juguetes_CategoriaJuguetes_CategoriaId] FOREIGN KEY ([CategoriaId]) REFERENCES [CategoriaJuguetes] ([Id]) ON DELETE NO ACTION
);

GO

CREATE TABLE [Usuarios] (
    [Id] int NOT NULL IDENTITY,
    [Nombre] nvarchar(max) NULL,
    [Apellido] nvarchar(max) NULL,
    [Email] nvarchar(max) NULL,
    [Password] nvarchar(max) NULL,
    [Telefono] nvarchar(max) NULL,
    [IdRol] int NOT NULL,
    [RolId] int NULL,
    CONSTRAINT [PK_Usuarios] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Usuarios_Roles_RolId] FOREIGN KEY ([RolId]) REFERENCES [Roles] ([Id]) ON DELETE NO ACTION
);

GO

CREATE TABLE [DetalleCompras] (
    [Id] int NOT NULL IDENTITY,
    [Cantidad] int NOT NULL,
    [IdJuguete] int NOT NULL,
    [IdCarritoCompra] int NOT NULL,
    [Subtotal] decimal(18,2) NOT NULL,
    [JugueteId] int NULL,
    [CarritoCompraId] int NULL,
    CONSTRAINT [PK_DetalleCompras] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_DetalleCompras_CarritoCompras_CarritoCompraId] FOREIGN KEY ([CarritoCompraId]) REFERENCES [CarritoCompras] ([Id]) ON DELETE NO ACTION,
    CONSTRAINT [FK_DetalleCompras_Juguetes_JugueteId] FOREIGN KEY ([JugueteId]) REFERENCES [Juguetes] ([Id]) ON DELETE NO ACTION
);

GO

CREATE INDEX [IX_DetalleCompras_CarritoCompraId] ON [DetalleCompras] ([CarritoCompraId]);

GO

CREATE INDEX [IX_DetalleCompras_JugueteId] ON [DetalleCompras] ([JugueteId]);

GO

CREATE INDEX [IX_Juguetes_CategoriaId] ON [Juguetes] ([CategoriaId]);

GO

CREATE INDEX [IX_Usuarios_RolId] ON [Usuarios] ([RolId]);

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20220730194709_First', N'3.1.27');

GO

