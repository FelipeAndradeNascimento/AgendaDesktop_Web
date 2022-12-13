USE [db_agenda]
GO

/****** Object:  Table [dbo].[tClientes]    Script Date: 09/12/2022 22:57:38 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tbContatos](
	[IdContato] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [nvarchar](max) NULL,
	[Cpf] [nvarchar](max) NULL,
	[Email] [nvarchar](max) NULL,
	[Telefone] [nvarchar](max) NULL,
	[IdEndereco] [int] NULL,
 CONSTRAINT [PK_tbContatos] PRIMARY KEY CLUSTERED 
(
	[IdContato] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO

CREATE TABLE [tbEndereco] (
  [IdEndereco] [int] IDENTITY(1,1) NOT NULL,
  [Rua] [nvarchar](max) NULL,
  [Bairro] [nvarchar](max) NULL,
  [Cidade] [nvarchar](max) NULL,
  [Uf] [nvarchar](2) NULL,
  [Cep] [nvarchar](max) NULL,
 CONSTRAINT [PK_tbEndereco] PRIMARY KEY CLUSTERED 
(
	[IdEndereco] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO

CREATE TABLE [tbTipocompromisso] (
	[IdTipoCompromisso] [int] IDENTITY(1,1) NOT NULL,
	[DescricaoTipo] [nvarchar](max) NULL,
  
CONSTRAINT [PK_tbTipocompromisso] PRIMARY KEY CLUSTERED 
(
	[IdTipoCompromisso] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
go

CREATE TABLE [tbAgenda] (
  [IdAgenda] [int] IDENTITY(1,1) NOT NULL,
  [Titulo] [nvarchar](max) NULL,
  [Descricao] [nvarchar](max) NULL,
  [idContato] [int] NULL,
  [idTipo] [int] NULL,
  [dtCompromisso] [datetime] NULL,

CONSTRAINT [PK_tbAgenda] PRIMARY KEY CLUSTERED 
(
	[IdAgenda] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
