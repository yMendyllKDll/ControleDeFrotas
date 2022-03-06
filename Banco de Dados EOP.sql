--Criando Base de Dados

CREATE DATABASE EOP_Demo
GO

USE EOP_Demo
GO

--Criando Tabelas
CREATE TABLE tblMotorista(
	CodMoto int NOT NULL,
	Nome varchar(30) NULL,
	dataNasc date NULL,
	RG varchar(20) NULL,
	CPF varchar(15) NOT NULL,
	CNH varchar(11) NULL,
	ValCNH date NULL,
	StatusMoto varchar (10) null,

CONSTRAINT PK_CodMoto PRIMARY KEY (CodMoto),
CONSTRAINT PK_CPF UNIQUE (CPF),
CONSTRAINT UN_CNH UNIQUE (CNH))
GO

CREATE TABLE tblVeiculo(
	CodVeiculo int NOT NULL,
	Marca varchar(20) NOT NULL,
	Cor varchar(20) NOT NULL,
	KMAtual varchar (10) NOT NULL,
	Combustivel varchar (20) NOT NULL,
	Renavam varchar (20) NOT NULL,
	Chassi varchar (20) NOT NULL,
	Modelo varchar (20) NOT NULL,
	Ano date NOT NULL,
	SituacaoVei varchar (20) NOT NULL,
	Placa varchar (10) NOT NULL,
	Pneu varchar (20) NOT NULL,

CONSTRAINT PK_CodVeiculo PRIMARY KEY (CodVeiculo),
CONSTRAINT AK_Chassi UNIQUE(Chassi),
CONSTRAINT AK_Placa UNIQUE(Placa))
GO

CREATE TABLE tblClientes(
	CodCliente int NOT NULL,
	Nome varchar (20) NOT NULL,
	CPFouCNPJ varchar (15) NOT NULL,
	Endereco varchar (30) NOT NULL,
	Bairro varchar (20) NOT NULL,
	Estado varchar (5) NOT NULL,
	Categoria varchar (10) NOT NULL,
	ValCCNH varchar (10) NOT NULL,
	ValorPago varchar (20) NOT NULL,
	StatusCliente varchar (20) NOT NULL,
CONSTRAINT PK_CodCliente PRIMARY KEY (CodCliente),
CONSTRAINT AK_CPFouCNPJ UNIQUE(CPFouCNPJ))
GO

CREATE TABLE tblViagens(
	CodViagem int NOT NULL,
	CodVVeiculo int NOT NULL,
	CodVMoto int NOT NULL,
	DataViagem date NOT NULL,
	EntregArEm date NULL,
	EntregEEm date NULL,
	Motivo varchar (20) NULL,
	Situacao varchar (20) NULL,
CONSTRAINT PK_CodViagem PRIMARY KEY (CodVIagem),
CONSTRAINT FK_CodVMoto FOREIGN KEY (CodVMoto) REFERENCES tblMotorista (CodMoto),
CONSTRAINT FK_CodVVeiculo FOREIGN KEY (CodVVeiculo) REFERENCES tblVeiculo (CodVeiculo))
GO

CREATE TABLE tblLocacao(
	CodLocacao int NOT NULL,
	CodLCliente int NOT NULL,
	DataLocacao date NOT NULL,
	DataDevolucao date NOT NULL,
	LocalRetirada varchar (30) NULL,
	Quantidade varchar(5) NOT NULL,
	ValorLocacao varchar(20) NOT NULL,

CONSTRAINT PK_CodLocacao PRIMARY KEY (CodLocacao),
CONSTRAINT FK_CodLCliente FOREIGN KEY (CodLCliente) REFERENCES tblClientes (CodCliente))
GO

CREATE TABLE tblSeguroMoto(
	NumApolice varchar (20) NOT NULL,
	CPFMoto varchar(15) NOT NULL,
	Seguradora varchar (20) NULL,
	Corretor varchar (20) NULL,
	DataInicioSM date NULL,
	DataVencSM date NUll,
	ValorSM varchar (20) NULL,
	SituacaoSM varchar (10) NULL,

CONSTRAINT PK_NumApolice PRIMARY KEY (NumApolice),
CONSTRAINT FK_CPFMoto FOREIGN KEY (CPFMoto) REFERENCES tblMotorista (CPF))
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Compromissos](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Data] [date] NULL,
	[Hora] [time](7) NULL,
	[Descricao] [varchar](max) NULL,
	[Concluido] [char](1) NULL,
 CONSTRAINT [Pk_Compromissos] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[permissaousuario](
	[per_id] [int] IDENTITY(1,1) NOT NULL,
	[usu_id] [int] NULL,
	[per_nomefrm] [varchar](80) NULL,
	[per_descricao] [varchar](100) NULL,
	[per_bloqueado] [varchar](5) NULL,
	[per_inserir] [varchar](5) NULL,
	[per_alterar] [varchar](5) NULL,
	[per_excluir] [varchar](5) NULL,
	[per_imprimir] [varchar](5) NULL,
 CONSTRAINT [PK_permissaousuario] PRIMARY KEY CLUSTERED 
(
	[per_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuario](
	[usu_id] [int] IDENTITY(1,1) NOT NULL,
	[usu_nome] [varchar](150) NULL,
	[usu_login] [varchar](90) NULL,
	[usu_grupo] [varchar](90) NULL,
	[usu_senha] [varchar](50) NULL,
 CONSTRAINT [PK_Usuario] PRIMARY KEY CLUSTERED 
(
	[usu_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[permissaousuario]  WITH CHECK ADD  CONSTRAINT [FK_permissaousuario_Usuario] FOREIGN KEY([usu_id])
REFERENCES [dbo].[Usuario] ([usu_id])
GO
ALTER TABLE [dbo].[permissaousuario] CHECK CONSTRAINT [FK_permissaousuario_Usuario]
GO

-- Populando Tabelas
--(Em desenvolvimento)

INSERT INTO dbo.Usuario VALUES ('Administrador','Admin','Administrador','123');
GO

INSERT INTO dbo.permissaousuario
Values
('1','TelaMotoristaa','Cadastrar Motoristas','False','True','True','True','True'),
('1','TelaSeguroMotoristaa','Cadastrar Seguros Motoristas','False','True','True','True','True'),
('1','TelaVeiculoss','Cadastrar Veículos','False','True','True','True','True'),
('1','TelaCompraVendaa','Cadastrar Compra e Venda dos Veículos','False','True','True','True','True'),
('1','TelaSeguroVeiculoo','Cadastrar Seguros Veículos','False','True','True','True','True'),
('1','TelaSinistross','Cadastrar Sinistros','False','True','True','True','True'),
('1','TelaViagenss','Cadastrar Viagens','False','True','True','True','True'),
('1','TelaAbastecimentoo','Cadastrar Abastecimentos','False','True','True','True','True'),
('1','TelaClientee','Cadastro de Clientes','False','True','True','True','True'),
('1','TelaLocaçãoo','Cadastrar Locações','False','True','True','True','True'),
('1','TelaMultass','Cadastrar Multas','False','True','True','True','True'),
('1','TelaManutençãoo','Cadastrar Manutenções','False','True','True','True','True'),
('1','TelaFinanceiroo','Cadastrar Financeiro','False','True','True','True','True'),
('1','TelaVeiculosDisponiveiss','Visualizar Veículos Disponiveis','False','True','True','True','True'),
('1','TelaAvisoss','Visualizar Avisos','False','True','True','True','True'),
('1','TelaRelatorioss','Visualizar Relatórios','False','True','True','True','True'),
('1','frmCadastrarUsuario','Cadastrar Usuário','False','True','True','True','True'),
('1','frmPermissaoUsuario','Cadastrar as Permissões de Acesso dos Usuários','False','True','True','True','True'),
('1','frmConsultaUsuario','Consultar Usuário','False','True','True','True','True');
GO