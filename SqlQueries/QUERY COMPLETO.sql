USE Grupo42
GO

--PARA ARRANCAR DE NUEVO, CORRAN EL DROP DE LAS TABLAS 
--DROP TABLE DetalleVenta, DetalleCompra, Venta, Compra, Producto, Proveedor, Usuario, Cliente, EstadoCliente, EstadoVenta, FormaPago, CategoriaProducto,EstadoCompra,EstadoUsuario

-- CREA TABLA ESTADOUSUARIO
CREATE TABLE EstadoUsuario (
	idEstadoUsuario TINYINT IDENTITY PRIMARY KEY NOT NULL,
	DescripcionEstadoUsuario varchar(20) NOT NULL
)
-----------------------------------------------------------------------------------------------------
-- CREA TABLA ESTADOVENTA
CREATE TABLE EstadoVenta (
	idEstadoVenta TINYINT IDENTITY PRIMARY KEY NOT NULL,
	DescripcionEstadoVenta varchar(20) NOT NULL
)
-----------------------------------------------------------------------------------------------------
-- CREA TABLA FORMAPAGO
CREATE TABLE FormaPago (
	idFormaPago TINYINT IDENTITY PRIMARY KEY NOT NULL,
	DescripcionFormaPago varchar(20) NOT NULL
)
-----------------------------------------------------------------------------------------------------
-- CREA TABLA CATEGORIAPRODUCTO
CREATE TABLE CategoriaProducto (
	idCategoria TINYINT IDENTITY PRIMARY KEY NOT NULL,
	DescripcionCatProd varchar(20) NOT NULL,
)
-----------------------------------------------------------------------------------------------------
-- CREA TABLA ESTADOCOMPRA
CREATE TABLE EstadoCompra (
	idEstadoCompra TINYINT IDENTITY NOT NULL PRIMARY KEY,
	DescripcionEstadoCompra varchar(50) NOT NULL
)
-----------------------------------------------------------------------------------------------------
-- CREA TABLA ESTADOCLIENTE
CREATE TABLE EstadoCliente (
	idEstadoCliente TINYINT IDENTITY(1,1) PRIMARY KEY,
	DescripcionEstadoCliente varchar(20)
)
-----------------------------------------------------------------------------------------------------
-- CREA TABLA USUARIO
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
CREATE TABLE Producto (
	idProducto INT IDENTITY (1000,1) NOT NULL PRIMARY KEY,
	idCategoria TINYINT NOT NULL,
		CONSTRAINT fk_ProductoCategoria FOREIGN KEY (idCategoria) REFERENCES CategoriaProducto (idCategoria),
	idProveedor SMALLINT NOT NULL,
		CONSTRAINT fk_ProductoProveedor FOREIGN KEY (idProveedor) REFERENCES Proveedor (idProveedor),
	Nombre VARCHAR (20) NOT NULL,
	Cantidad SMALLINT NOT NULL,
	PrecioUnitarioCompra DECIMAL (9,2) NOT NULL,
	PrecioUnitarioVenta DECIMAL (9,2) NOT NULL
) 
-----------------------------------------------------------------------------------------------------
-- CREA TABLA COMPRA
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
-----------------------------------------------------------------------------------------------------
-- CREA TABLA DETALLE VENTA
CREATE TABLE DetalleVenta (
	idDetalleVenta INT PRIMARY KEY IDENTITY (1000,1),
	idVenta INT NOT NULL,
		CONSTRAINT fk_DetalleVeVenta FOREIGN KEY (idVenta) REFERENCES Venta (idVenta),
	idProducto INT NOT NULL,
		CONSTRAINT fk_DetalleVeProducto FOREIGN KEY (idProducto) REFERENCES Producto (idProducto),
	Cantidad INT NOT NULL,
)


--AGREGAMOS UN POCO DE DATA ACÁ

INSERT INTO EstadoUsuario
			VALUES ('Admin'),('Buffet'),('Kiosco'),('Baja Temporal'),('Baja Definitiva')
INSERT INTO EstadoUsuario
			VALUES ('Paga'),('Impaga')
INSERT INTO FormaPago
			VALUES ('Efectivo'),('Débito'),('Crédito'),('MercadoPago')
INSERT INTO CategoriaProducto
			VALUES ('Gaseosas'),('Jugos'),('Buffet'),('Golosinas'),('Comida')
INSERT INTO EstadoCompra
			VALUES ('Paga'),('Impaga')
INSERT INTO EstadoVenta
			VALUES ('Pago'),('Impago')
INSERT INTO EstadoCliente
			VALUES ('Al día'),('Deudor'),('Requiere sicario')
INSERT INTO Usuario
			VALUES	('1','Facundo','Tomas','32478178','nokuaru@gmail.com','Nokuaru','123456','1121739785'),
					('1','Gonzalo','Olarte','12345678','olartegonzalo@gmail.com','Olarte','123456','987654321')
INSERT INTO Proveedor (Cuit,RazonSocial,Direccion,Mail,Telefono) 
			VALUES	('22222222222','McDonalds','General Paz 5445' ,'a@a.com','11111222'),
					('11111111111','BurgerKing','Amenabar 5445' ,'b@b.com','32323232'),
					('33333333333','PumperNic','Belgrano 5445' ,'c@c.com','42424242')
INSERT INTO Cliente
			VALUES	('1','Jorge','Capitanich','7894561', 'jorgito@gmail.com','1513254857',DEFAULT,DEFAULT),
					('2','Alberto','Fernández','25589289', 'tibio@gmail.com','1512324257',DEFAULT,DEFAULT)
INSERT INTO Producto (idCategoria,idProveedor,Nombre,Cantidad,PrecioUnitarioVenta,PrecioUnitarioCompra)
			VALUES	('1','1001','Coca Cola 500ml','50','90.25','135'),
					('5','1002','Empanada JyQ','23','73.55','155')

INSERT INTO Compra (idUsuario,idEstadoCompra,TipoComprobante,NumeroComprobante,Total,FormaPago)
			VALUES	('1000','1','A','000021','255','1'),
					('1001','2','B','000022','384','2')
INSERT INTO Venta (idCliente, idUsuario, TipoComprobante,NumeroComprobante,FechaVenta,Total,idEstadoVenta,idFormaPago)
			VALUES ('1000','1001','A','0000028',DEFAULT,'453','1','1')
INSERT INTO DetalleVenta (idVenta,idProducto,Cantidad)
			VALUES	('1000','1000','20'),
					('1000','1001','9')
INSERT INTO DetalleCompra (idCompra,idProducto,Cantidad)
			VALUES	('1000','1000','20'),
					('1000','1001','15'),
					('1001','1000','7'),
					('1001','1000','14')
		






