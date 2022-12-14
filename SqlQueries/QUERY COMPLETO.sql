USE Grupo42
GO

--PARA ARRANCAR DE NUEVO, CORRAN EL DROP DE LAS TABLAS 
--DROP TABLE DetalleVenta, DetalleCompra, Venta, Compra, Producto, Proveedor, Usuario, Cliente, EstadoCliente, EstadoVenta, FormaPago, CategoriaProducto,EstadoCompra,EstadoUsuario,TipoComprobante

-- CREA TABLA ESTADOUSUARIO
DROP TABLE IF EXISTS EstadoUsuario
CREATE TABLE EstadoUsuario (
	idEstadoUsuario TINYINT IDENTITY PRIMARY KEY NOT NULL,
	DescripcionEstadoUsuario varchar(20) NOT NULL
)
-----------------------------------------------------------------------------------------------------
-- CREA TABLA ESTADOVENTA
DROP TABLE IF EXISTS EstadoVenta
CREATE TABLE EstadoVenta (
	idEstadoVenta TINYINT IDENTITY PRIMARY KEY NOT NULL,
	DescripcionEstadoVenta varchar(20) NOT NULL
)
-----------------------------------------------------------------------------------------------------
-- CREA TABLA FORMAPAGO
DROP TABLE IF EXISTS FormaPago
CREATE TABLE FormaPago (
	idFormaPago TINYINT IDENTITY PRIMARY KEY NOT NULL,
	DescripcionFormaPago varchar(20) NOT NULL
)
-----------------------------------------------------------------------------------------------------
-- CREA TABLA CATEGORIAPRODUCTO
DROP TABLE IF EXISTS CategoriaProducto
CREATE TABLE CategoriaProducto (
	idCategoria TINYINT IDENTITY PRIMARY KEY NOT NULL,
	DescripcionCatProd varchar(20) NOT NULL,
)
-----------------------------------------------------------------------------------------------------
-- CREA TABLA ESTADOCOMPRA
DROP TABLE IF EXISTS EstadoCompra
CREATE TABLE EstadoCompra (
	idEstadoCompra TINYINT IDENTITY NOT NULL PRIMARY KEY,
	DescripcionEstadoCompra varchar(50) NOT NULL
)
-----------------------------------------------------------------------------------------------------
-- CREA TABLA ESTADOCLIENTE
DROP TABLE IF EXISTS EstadoCliente
CREATE TABLE EstadoCliente (
	idEstadoCliente TINYINT IDENTITY(1,1) PRIMARY KEY,
	DescripcionEstadoCliente varchar(20)
)

-----------------------------------------------------------------------------------------------------
-- CREA TABLA TipoComprobante
DROP TABLE IF EXISTS TipoComprobante
CREATE TABLE TipoComprobante (
	idTipoComprobante TINYINT IDENTITY PRIMARY KEY NOT NULL,
	DescripcionTipoComprobante varchar(20) NOT NULL
)
-----------------------------------------------------------------------------------------------------
-- CREA TABLA USUARIO
DROP TABLE IF EXISTS Usuario
CREATE TABLE Usuario (
	idUsuario SMALLINT IDENTITY(1000,1) PRIMARY KEY,
	idEstadoUsuario TINYINT, -- FK EstadoUsuario.idEstadoUsuario
		CONSTRAINT fk_estadoUsuario FOREIGN KEY (idEstadoUsuario) REFERENCES EstadoUsuario(idEstadoUsuario),
	Nombre varchar(30) NOT NULL,
	Apellido varchar(20) NULL,
	Dni varchar(8) NULL,
	Mail varchar(30) NULL,
	Usuario varchar(30) NOT NULL,-- ********* VER COMO HACER ESTO *********
	Pass varchar(40) NOT NULL, -- ********* VER COMO HACER ESTO *********
	Telefono varchar(20)
)
-----------------------------------------------------------------------------------------------------
-- CREA TABLA PROVEEDOR
DROP TABLE IF EXISTS Proveedor
CREATE TABLE Proveedor (
	idProveedor SMALLINT IDENTITY (1000,1) PRIMARY KEY NOT NULL,
	FechaAlta date NOT NULL CONSTRAINT FechaActual DEFAULT getdate(),
	Cuit char(11) NOT NULL,
	RazonSocial varchar(50) NOT NULL,
	Direccion varchar(100),
	Mail varchar(50),
	Telefono varchar(20)
)
-----------------------------------------------------------------------------------------------------
-- CREA TABLA CLIENTE
DROP TABLE IF EXISTS Cliente 
CREATE TABLE Cliente (
	idCliente SMALLINT IDENTITY (1000,1) PRIMARY KEY,
	idEstadoCliente TINYINT,
		CONSTRAINT fk_ClientesEstadoCliente FOREIGN KEY (idEstadoCliente) REFERENCES EstadoCliente (idEstadoCliente),
	Nombre varchar(20) NULL,
	Apellido varchar(20) NULL,
	Dni varchar(8) NULL,
	Mail varchar(30) NULL,
	Telefono varchar(20) null,
	FechaEstadoCliente date NOT NULL DEFAULT GETDATE(),
	FechaAlta date NOT NULL DEFAULT GETDATE(),
)
-----------------------------------------------------------------------------------------------------
-- CREA TABLA PRODUCTO
DROP TABLE IF EXISTS Producto
CREATE TABLE Producto (
	idProducto INT IDENTITY (1000,1) NOT NULL PRIMARY KEY,
	idCategoria TINYINT NOT NULL,
		CONSTRAINT fk_ProductoCategoria FOREIGN KEY (idCategoria) REFERENCES CategoriaProducto (idCategoria),
	idProveedor SMALLINT NOT NULL,
		CONSTRAINT fk_ProductoProveedor FOREIGN KEY (idProveedor) REFERENCES Proveedor (idProveedor),
	Nombre VARCHAR (75) NOT NULL,
	Cantidad SMALLINT NOT NULL,
	PrecioUnitarioCompra DECIMAL (9,2) NOT NULL,
	PrecioUnitarioVenta DECIMAL (9,2) NOT NULL
) 
-----------------------------------------------------------------------------------------------------
-- CREA TABLA COMPRA
DROP TABLE IF EXISTS Compra
CREATE TABLE Compra (
	idCompra INT IDENTITY (1000,1) NOT NULL PRIMARY KEY,
	idUsuario SMALLINT NOT NULL,
		CONSTRAINT fk_ComprasUsuario FOREIGN KEY (idUsuario) REFERENCES Usuario (idUsuario),
	idEstadoCompra tinyint,
		CONSTRAINT fk_compras FOREIGN KEY (idEstadoCompra) REFERENCES EstadoCompra (idEstadoCompra),
	TipoComprobante VARCHAR(50) NULL,
	NumeroComprobante SMALLINT NULL,
	FechaCompra datetime NOT NULL CONSTRAINT FechaHoraActual DEFAULT getdate(),
	Total DECIMAL(9,2),
	FormaPago varchar(50)
)

-----------------------------------------------------------------------------------------------------
-- CREA TABLA DETALLE COMPRA
DROP TABLE IF EXISTS DetalleCompra
CREATE TABLE DetalleCompra (
	idDetalleCompra INT PRIMARY KEY IDENTITY (1000,1),
	idCompra INT NOT NULL,
		CONSTRAINT fk_DetalleCoCompra FOREIGN KEY (idCompra) REFERENCES Compra (idCompra),
	idProducto INT NOT NULL,
		CONSTRAINT fk_DetalleCoProducto FOREIGN KEY (idProducto) REFERENCES Producto (idProducto),
	Cantidad INT NOT NULL
) 
-----------------------------------------------------------------------------------------------------
-- CREA TABLA VENTA
/*
DROP TABLE IF EXISTS Venta
CREATE TABLE Venta (
	idVenta INT PRIMARY KEY IDENTITY (1000,1) NOT NULL,
	idCliente SMALLINT NOT NULL,
		CONSTRAINT fk_VentasCliente FOREIGN KEY (idCliente) REFERENCES Cliente (idCliente),
	idUsuario SMALLINT NOT NULL DEFAULT 0,
		Constraint fk_VentasUsuario FOREIGN KEY (idUsuario) REFERENCES Usuario (idUsuario),
	TipoComprobante VARCHAR (5) NULL,
	NumeroComprobante INT NULL,
	FechaVenta DATE NOT NULL DEFAULT GETDATE(),
	Total DECIMAL(9,2),
	idEstadoVenta tinyint not null,
		CONSTRAINT fk_VentasEstadoVenta FOREIGN KEY (idEstadoVenta) REFERENCES EstadoVenta (idEstadoVenta),
	idFormaPago tinyint not null,
		CONSTRAINT fk_formaPago FOREIGN KEY (idFormaPago) REFERENCES FormaPago (idFormaPago)
)
*/
-- CREA TABLA VENTA
DROP TABLE IF EXISTS Venta
CREATE TABLE Venta (
	idVenta INT PRIMARY KEY IDENTITY (1000,1) NOT NULL,
	idCliente SMALLINT NOT NULL,
		CONSTRAINT fk_VentasCliente FOREIGN KEY (idCliente) REFERENCES Cliente (idCliente),
	idUsuario SMALLINT NOT NULL DEFAULT 0,
		Constraint fk_VentasUsuario FOREIGN KEY (idUsuario) REFERENCES Usuario (idUsuario),
	idTipoComprobante TINYINT NULL,
		Constraint fk_VentasTipoComprobante FOREIGN KEY (idTipoComprobante) REFERENCES TipoComprobante (idTipoComprobante),
	NumeroComprobante INT NULL,
	FechaVenta DATE NOT NULL DEFAULT GETDATE(),
	Total DECIMAL(9,2),
	idEstadoVenta tinyint not null,
		CONSTRAINT fk_VentasEstadoVenta FOREIGN KEY (idEstadoVenta) REFERENCES EstadoVenta (idEstadoVenta),
	idFormaPago tinyint not null,
		CONSTRAINT fk_formaPago FOREIGN KEY (idFormaPago) REFERENCES FormaPago (idFormaPago)
)

-----------------------------------------------------------------------------------------------------
-- CREA TABLA DETALLE VENTA
DROP TABLE IF EXISTS DetalleVenta
CREATE TABLE DetalleVenta (
	idDetalleVenta INT PRIMARY KEY IDENTITY (1000,1),
	idVenta INT NOT NULL,
		CONSTRAINT fk_DetalleVeVenta FOREIGN KEY (idVenta) REFERENCES Venta (idVenta),
	idProducto INT NOT NULL,
		CONSTRAINT fk_DetalleVeProducto FOREIGN KEY (idProducto) REFERENCES Producto (idProducto),
	Cantidad INT NOT NULL,
)


----------------------- MODIFICA USUARIO | AGRAGA COLUMNA ACTIVO -----------------------
  ALTER TABLE [dbo].[Usuario]
  ADD Activo bit not null DEFAULT 0

--AGREGAMOS UN POCO DE DATA AC??

INSERT INTO EstadoUsuario
			VALUES ('Admin'),('Buffet'),('Kiosco'),('Baja Temporal'),('Baja Definitiva')
INSERT INTO EstadoUsuario
			VALUES ('Paga'),('Impaga')
INSERT INTO FormaPago
			VALUES ('Efectivo'),('D??bito'),('Cr??dito'),('MercadoPago')
INSERT INTO CategoriaProducto
			VALUES ('Bebidas'),('Buffet'),('Golosinas'),('Comida'),('Helados')
INSERT INTO EstadoCompra
			VALUES ('Paga'),('Impaga')
INSERT INTO EstadoVenta
			VALUES ('Pago'),('Impago'),('En Proceso')
INSERT INTO EstadoCliente
			VALUES ('Al d??a'),('Deudor'),('Requiere sicario')
			
INSERT INTO TipoComprobante (DescripcionTipoComprobante)
VALUES ('FACTURA A'), ('FACTURA B'), ('NOTA DE DEBITO'), ('NOTA DE CREDITO')


			
INSERT INTO Usuario
			VALUES	('1','Facundo','Tomas','32478178','nokuaru@gmail.com','Nokuaru','123456','1121739785',DEFAULT),
				('1','Gonzalo','Olarte','12345678','olartegonzalo@gmail.com','Olarte','123456','987654321',DEFAULT)
INSERT INTO Proveedor (Cuit,RazonSocial,Direccion,Mail,Telefono) 
			VALUES	('20123456789','BUFFET','General Paz 5445' ,'a@a.com','11111222'),
				('20321654987','Kossal Materias Primas','Amenabar 5445' ,'b@b.com','32323232'),
				('20159753648','Distribucion Alcamar','Belgrano 5445' ,'c@c.com','42424242'),
				('20397133489','SODIMAC','Blabla 3232' ,'d@c.com','42424242'),
				('20697416541','Vital','Bleble 121' ,'c@c.com','42424242'),
				('20364978453','MaxiConsumo','Bleble 121' ,'c@c.com','42424242'),
				('20159753694','Diarco','Bleble 121' ,'c@c.com','42424242')
				
INSERT INTO Cliente
			VALUES	('1','Presencial','Presencial','', '','',DEFAULT,DEFAULT),
				('2','Jorge','Capitanich','25589289', 'chaco@gmail.com','1512324257',DEFAULT,DEFAULT),
				('2','Alberto','Fern??ndez','25589289', 'tibio@gmail.com','1512324257',DEFAULT,DEFAULT),
				('1','Arturo','Frondizi','25589289', 'tibio@gmail.com','1512324257',DEFAULT,DEFAULT),
				('1','Arturo','Puig','25589289', 'tibio@gmail.com','1512324257',DEFAULT,DEFAULT),
				('1','Emilio','Disi','25589289', 'tibio@gmail.com','1512324257',DEFAULT,DEFAULT),
				('1','Jorge','Samid','25589289', 'tibio@gmail.com','1512324257',DEFAULT,DEFAULT)
				
INSERT INTO Producto (idCategoria,idProveedor,Nombre,Cantidad,PrecioUnitarioVenta,PrecioUnitarioCompra)
			VALUES	('1','1003','Coca Cola 500ml','50','135','90.25'),
				('1','1003','Sprite 500ml','50','135','90.25'),
				('1','1004','Heineken 1L','30','235','180'),
				('2','1000','Empanada JyQ','23','155','73.55'),
				('2','1000','Empanada Carne','13','155','73.55'),
				('2','1000','Sugus x20','18','40','155')

INSERT INTO Compra (idUsuario,idEstadoCompra,TipoComprobante,NumeroComprobante,Total,FormaPago)
			VALUES	('1000','1','A','000021','255','1'),
				('1001','2','B','000022','384','2')
INSERT INTO Venta (idCliente, idUsuario, idTipoComprobante,NumeroComprobante,FechaVenta,Total,idEstadoVenta,idFormaPago)
			VALUES  ('1000','1001',1,'0000028',DEFAULT,'835','1','1'),
				('1001','1001',2,'0000231',DEFAULT,'422','1','1'),
				('1002','1001',2,'0000232',DEFAULT,'159','1','1'),
				('1003','1001',2,'0000233',DEFAULT,'233','1','1'),
				('1004','1001',1,'0000029',DEFAULT,'425','1','1'),
				('1005','1001',1,'0000030',DEFAULT,'177','1','1')
INSERT INTO DetalleVenta (idVenta,idProducto,Cantidad)
			VALUES	('1000','1000','2'),
				('1000','1001','3'),
				('1000','1004','2'),
				('1001','1000','2'),
				('1001','1003','2'),
				('1001','1005','1'),
				('1002','1000','1'),
				('1002','1001','1'),
				('1002','1003','2'),
				('1003','1000','1'),
				('1003','1004','3'),
				('1004','1000','1'),
				('1004','1001','1'),
				('1005','1000','2')
	
				
INSERT INTO DetalleCompra (idCompra,idProducto,Cantidad)
			VALUES	('1000','1000','20'),
					('1000','1001','15'),
					('1001','1000','7'),
					('1001','1000','14')
