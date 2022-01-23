CREATE TABLE [dbo].[DespesasUnidades] (
    [Id]               INT          NOT NULL,
    [Descrição]        VARCHAR (50) NOT NULL,
    [TipoDespesa]      VARCHAR (50) NOT NULL,
    [Valor]            MONEY        NOT NULL,
    [VencimentoFatura] VARCHAR (50) NOT NULL,
    [StatusPagamento]  VARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

