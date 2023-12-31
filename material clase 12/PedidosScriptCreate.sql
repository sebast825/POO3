CREATE TABLE [dbo].[Clientes](
	[IdCliente] [int] NOT NULL,
	[Compañia] [varchar](50) NULL,
	[Apellidos] [varchar](50) not NULL,
	[Nombre] [varchar](50) not NULL,
	[Email] [varchar](50) NULL,
	[Cargo] [varchar](50) NULL,
	[TelefonoTrabajo] [varchar](25) NULL,
	[TelefonoParticular] [varchar](25) NULL,
	[TelefonoMovil] [varchar](25) NULL,
	[Fax] [varchar](25) NULL,
	[Direccion] [varchar](100) NULL,
	[Ciudad] [varchar](50) NULL,
	[Provincia] [varchar](50) NULL,
	[CPostal] [varchar](15) NULL,
	[Pais] [varchar](50) NULL,
	[Notas] [varchar](10) NULL,
 Primary key([IdCliente]) 
 )
/****** Object:  Table [dbo].[Empleados]    Script Date: 04/12/2022 11:14:34 ******/
go
CREATE TABLE [dbo].[Empleados](
	[IdEmpleado] [int] NOT NULL,
	[Compania] [varchar](50) NULL,
	[Apellidos] [varchar](50) not NULL,
	[Nombre] [varchar](50) not NULL,
	[Email] [varchar](50) NULL,
	[Cargo] [varchar](50) NULL,
	[TelefonoTrabajo] [varchar](25) NULL,
	[TelefonoParticular] [varchar](25) NULL,
	[TelefonoMovil] [varchar](25) NULL,
	[Fax] [varchar](25) NULL,
	[Dirección] [varchar](100) NULL,
	[Ciudad] [varchar](50) NULL,
	[Provincia] [varchar](50) NULL,
	[CPostal] [varchar](15) NULL,
	[Pais] [varchar](50) NULL,
	[Notas] [varchar](max) NULL,
	[Superior] [int] NULL,
 Primary key ([IdEmpleado])
 )

GO
CREATE TABLE [dbo].[EstadosPedidos](
	[IdEstadoPedidos] [smallint] NOT NULL,
	[Descripcion] [varchar](50) NOT NULL,
 Primary key( [IdEstadoPedidos] )
 )
GO

/****** Object:  Table [dbo].[Productos]    Script Date: 04/12/2022 11:14:34 ******/
CREATE TABLE [dbo].[Productos](
	[IdProducto] [int] NOT NULL,
	[Codigo] [varchar](25) NULL,
	[Nombre] [varchar](50) NULL,
	[Descripción] [varchar](100) NULL,
	[Costo] [money] NULL,
	[PrecioListado] [money] NOT NULL,
	[PuntoPedido] [smallint] NULL,
	[NivelObjetivo] [int] NULL,
	[CantidadPorUnidad] [varchar](50) NULL,
	[Suspendido] [bit] NOT NULL,
	[CantMinimaReposicion] [smallint] NULL,
	[Categoría] [varchar](50) NULL,
	[IdProveedor] [int] NULL,
	Primary key ([IdProducto])
)

GO
CREATE TABLE [dbo].[Proveedores](
	[IdProveedor] [int] NOT NULL,
	[Compania] [varchar](50) not NULL,
	[Apellidos] [varchar](50) not NULL,
	[Nombre] [varchar](50) not NULL,
	[Email] [varchar](50) NULL,
	[Cargo] [varchar](50) NULL,
	[TelefonoTrabajo] [varchar](25) NULL,
	[TelefonoParticular] [varchar](25) NULL,
	[TelefonoMovil] [varchar](25) NULL,
	[Fax] [varchar](25) NULL,
	[Dirección] [varchar](100) NULL,
	[Ciudad] [varchar](50) NULL,
	[Provincia] [varchar](50) NULL,
	[CPostal] [varchar](15) NULL,
	[Pais] [varchar](50) NULL,
 Primary Key ([IdProveedor])
 )
 go
/****** Object:  Table [dbo].[Transportistas]    Script Date: 04/12/2022 11:14:34 ******/
CREATE TABLE [dbo].[Transportistas](
	[IdTransportista] [int] NOT NULL,
	[Compania] [varchar](50) not NULL,
	[Apellidos] [varchar](50) NULL,
	[Nombre] [varchar](50) NULL,
	[Email] [varchar](50) NULL,
	[Cargo] [varchar](50) NULL,
	[TelefonoTrabajo] [varchar](25) NULL,
	[TelefonoParticular] [varchar](25) NULL,
	[TelefonoMovil] [varchar](25) NULL,
	[Fax] [varchar](25) NULL,
	[Direccion] [varchar](100) NULL,
	[Ciudad] [varchar](50) NULL,
	[Provincia] [varchar](50) NULL,
	[CPostal] [varchar](15) NULL,
	[Pais] [varchar](50) NULL
  Primary Key ([IdTransportista])
  )

  GO

CREATE TABLE [dbo].[Pedidos](
	[IdPedido] [int] NOT NULL,
	[IdEmpleado] [int] NULL,
	[IdCliente] [int] NULL,
	[FechaDePedido] [datetime] NULL,
	[FechaDeEnvío] [datetime] NULL,
	[IdTransportista] [int] NULL,
	[NombreEnvio] [varchar](50) NULL,
	[DireccionEnvio] [ntext] NULL,
	[CiudadDestino] [varchar](50) NULL,
	[ProvinciaDestino] [varchar](50) NULL,
	[CodigoPostalEnvio] [varchar](50) NULL,
	[PaisEnvio] [varchar](50) NULL,
	[GastosEnvio] [money] NULL,
	[Impuestos] [money] NULL,
	[TipoDePago] [varchar](50) NULL,
	[FechaDePago] [datetime] NULL,
	[Notas] [ntext] NULL,
	[ImporteTotal] [float] NULL,
 Primary key( [IdPedido] ),
 Foreign key ([IdEmpleado]) references Empleados([IdEmpleado]),
 Foreign key ([IdCliente]) references Clientes([IdCliente]),
  Foreign key ([IdTransportista]) references Transportistas([IdTransportista])
 )
GO

CREATE TABLE [dbo].[Privilegios](
	[idPrivilegio] [int] NOT NULL,
	[Descripcion] [varchar](50) Not NULL,
 Primary key ([idPrivilegio]) 
 )


GO
CREATE TABLE [dbo].[PrivilegiosPorEmpleado](
	[IdEmpleado] [int] NOT NULL,
	[IdPrivilegio] [int] NOT NULL,
  Primary key ([IdEmpleado], [IdPrivilegio])
  )
GO


CREATE TABLE [dbo].[Facturas](
	[IdFactura] [int] NOT NULL,
	[IdPedido] [int] not NULL,
	[Fecha] [datetime] NULL,
	[FechaVencimiento] [datetime] NULL,
	[Impuestos] [money] NULL,
	[Envio] [money] NULL,
	[ImporteDebido] [money] NULL,
 Primary key([IdFactura]) ,
 Foreign key (idPedido) references Pedidos(idPedido)
)
GO

CREATE TABLE [dbo].[PedidosDetalles](
	[IdPedido] [int] not NULL,
	[Renglon] [int] not NULL,
	[IdProducto] [int] not NULL,
	[Cantidad] [decimal](18, 4) NOT NULL,
	[Precio] [money] not NULL,
	[Descuento] [float] NOT NULL,
	
 Primary key ([IdPedido], [IdProducto], [Renglon] ),
 Foreign key ([IdPedido]) references Pedidos([IdPedido]),
 Foreign key ([IdProducto]) references Productos([IdProducto])
)
go