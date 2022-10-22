USE pp2_test

IF  NOT EXISTS (SELECT * FROM sys.objects 
WHERE object_id = OBJECT_ID(N'[dbo].[CategoriaProducto]') AND type in (N'U'))
BEGIN
	CREATE TABLE "CategoriaProducto"
		(idCategoriaProducto INT PRIMARY KEY IDENTITY(1,1),
		Descripcion VARCHAR(50) NOT NULL
)
END

IF  NOT EXISTS (SELECT * FROM sys.objects 
WHERE object_id = OBJECT_ID(N'[dbo].[Proveedores]') AND type in (N'U'))
BEGIN
	CREATE TABLE "Proveedores"
		(idProveedor INT NOT NULL PRIMARY KEY IDENTITY (1000,1),
		FechaAlta DATE DEFAULT (GETDATE()) NOT NULL,
		Cuit BIGINT UNIQUE NOT NULL,
		RazonSocial VARCHAR(20) NOT NULL,
		Direccion VARCHAR(20),
		Mail VARCHAR(50) NOT NULL,
		Telefono VARCHAR(20) NOT NULL
)
END

INSERT INTO CategoriaProducto VALUES ('Gaseosas'),('Jugos'),('Buffet'),('Golosinas')

SELECT * FROM CategoriaProducto

INSERT INTO Proveedores VALUES	(DEFAULT,'20324781782','Palmitos Voladores','Esquina 1234','palmitos@gmail.com','1134875887'),
								(DEFAULT,'20329171235','McDonalds','Callao 1452','mcdonaldsdemierda@gmail.com','114564667')

SELECT * FROM Proveedores

IF  NOT EXISTS (SELECT * FROM sys.objects 
WHERE object_id = OBJECT_ID(N'[dbo].[Productos]') AND type in (N'U'))
BEGIN
	CREATE TABLE "Productos"
		(idProducto	INT NOT NULL PRIMARY KEY IDENTITY (1000,1),
		idCategoriaProducto INT NOT NULL,
		idProveedor INT NOT NULL,
		Nombre VARCHAR(20) NOT NULL,
		Cantidad INT,
		PrecioUnitarioVenta DECIMAL(19,2) NOT NULL,
		PrecioUnitarioCompra DECIMAL(19,2) NOT NULL,
		CONSTRAINT fk_CategoriaProducto FOREIGN KEY (idCategoriaProducto)
		REFERENCES CategoriaProducto(idCategoriaProducto),
		CONSTRAINT fk_ProductoProveedor FOREIGN KEY (idProveedor)
		REFERENCES Proveedores(idProveedor)
		)

END

INSERT INTO Productos VALUES	('1','1000','Coca Cola 500ml','20', '120.80','145'),
								('3','1001','Empanadas','50', '80.40','180')


SELECT * FROM Productos

