USE pp2_test

IF  NOT EXISTS (SELECT * FROM sys.objects 
WHERE object_id = OBJECT_ID(N'[dbo].[EstadoCliente]') AND type in (N'U'))
BEGIN
	CREATE TABLE "EstadoCliente"
		(idEstadoCliente INT PRIMARY KEY IDENTITY(1,1),
		DescripcionEstadoClientes NVARCHAR(50) NOT NULL)
END


IF  NOT EXISTS (SELECT * FROM sys.objects 
WHERE object_id = OBJECT_ID(N'[dbo].[Clientes]') AND type in (N'U'))
BEGIN
	CREATE TABLE "Clientes"
		(idCliente	INT NOT NULL PRIMARY KEY IDENTITY (1000,1),
		idEstadoCliente INT NOT NULL,
		Nombre VARCHAR(20) NOT NULL,
		Apellido VARCHAR(20) NOT NULL,
		Dni INT UNIQUE NOT NULL,
		Mail VARCHAR(30) UNIQUE NOT NULL,
		Telefono VARCHAR(20) NOT NULL,
		fechaEstadoCliente DATE DEFAULT GETDATE(),
		fechaAlta DATE DEFAULT GETDATE(),
		CONSTRAINT fk_EstadoCliente FOREIGN KEY (idEstadoCliente)
		REFERENCES EstadoCliente(idEstadoCliente)

)
END

INSERT INTO EstadoCliente VALUES ('AL DÍA'),('DEUDOR')
SELECT * FROM EstadoCliente

INSERT INTO Clientes VALUES ('1','Jorge','Capitanich','7894561', 'jorgito@gmail.com','1513254857',DEFAULT,DEFAULT),
							('2','Alberto','Fernández','25589289', 'tibio@gmail.com','1512324257',DEFAULT,DEFAULT)


SELECT * FROM Clientes

