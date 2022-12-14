USE [Grupo42]
GO
--DROP VIEW V_Compra_UltimasCompras, V_Producto_Productos,V_Venta_Deudores,V_Venta_ListadoVentas

/*********************************** CREACIÓN DE VISTAS ***********************************/


/************************************************/
/****** CREA V_Compra_UltimasCompras ************/
/************************************************/
/****** V_Compra_UltimasCompras    Script Date: 27/10/2022 17:58:12 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[V_Compra_UltimasCompras]
AS
SELECT        TOP (100) PERCENT dbo.Compra.idCompra, dbo.Compra.Total, CONVERT(varchar, dbo.Compra.FechaCompra, 103) AS [Fecha], dbo.Compra.TipoComprobante, dbo.Proveedor.RazonSocial, dbo.Producto.Cantidad, 
                         dbo.Producto.Nombre
FROM            dbo.Compra INNER JOIN
                         dbo.DetalleCompra ON dbo.Compra.idCompra = dbo.DetalleCompra.idCompra INNER JOIN
                         dbo.Producto ON dbo.DetalleCompra.idProducto = dbo.Producto.idProducto INNER JOIN
                         dbo.Proveedor ON dbo.Producto.idProveedor = dbo.Proveedor.idProveedor
ORDER BY dbo.Compra.FechaCompra DESC
GO

USE [Grupo42]
GO
/***************************************/
/****** CREA V_PRODUCTO_PRODUCTOS ******/
/***************************************/
/****** Object:  View [dbo].[V_Producto_Productos]    Script Date: 27/10/2022 18:29:28 ******/

CREATE VIEW [dbo].[V_Producto_Productos]
AS
SELECT        dbo.Producto.idProducto as [ID], dbo.CategoriaProducto.DescripcionCatProd AS [Tipo de Producto], dbo.Producto.Nombre, dbo.Proveedor.RazonSocial AS Proveedor, dbo.Producto.Cantidad, 
                         dbo.Producto.PrecioUnitarioCompra AS [Precio Unitario Compra], dbo.Producto.PrecioUnitarioVenta AS [Precio Unitario Venta]
FROM            dbo.Producto INNER JOIN
                         dbo.CategoriaProducto ON dbo.Producto.idCategoria = dbo.CategoriaProducto.idCategoria INNER JOIN
                         dbo.Proveedor ON dbo.Producto.idProveedor = dbo.Proveedor.idProveedor
GO
/***********************************/
/****** CREA V_VENTA_DEUDORES ******/
/***********************************/
/****** Object:  View [dbo].[V_Venta_Deudores]    Script Date: 28/10/2022 11:40:23 ******/

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[V_Venta_Deudores]
AS
SELECT        dbo.Cliente.idCliente, dbo.Cliente.Nombre, dbo.Cliente.Apellido, dbo.Cliente.Telefono, SUM(dbo.Venta.Total) AS [Total Ventas], SUM(DISTINCT dbo.Venta.idVenta) AS [Cant ventas adeudadas], 
                         dbo.Cliente.FechaEstadoCliente AS [Deudor Desde]
FROM            dbo.Cliente INNER JOIN
                         dbo.Venta ON dbo.Cliente.idCliente = dbo.Venta.idCliente INNER JOIN
                         dbo.EstadoCliente ON dbo.Cliente.idEstadoCliente = dbo.EstadoCliente.idEstadoCliente
WHERE        (dbo.EstadoCliente.idEstadoCliente = 2)
GROUP BY dbo.Cliente.idCliente, dbo.Cliente.Nombre, dbo.Cliente.Apellido, dbo.Cliente.Telefono, dbo.Cliente.FechaEstadoCliente
GO


/***********************************/
/**** CREA V_VENTA_LISTADOVENTAS ***/
/***********************************/
/****** Object:  View [dbo].[V_Venta_ListadoVentas]    Script Date: 28/10/2022 14:16:47 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[V_Venta_ListadoVentas]
AS
SELECT        dbo.Venta.idVenta, CONVERT(varchar, dbo.Venta.FechaVenta, 103) AS Fecha, dbo.Cliente.Nombre, dbo.Cliente.Apellido, dbo.EstadoVenta.DescripcionEstadoVenta AS Estado, 
                         dbo.TipoComprobante.DescripcionTipoComprobante AS [Tipo de comprobante], ROUND(SUM(CAST(dbo.DetalleVenta.Cantidad AS int) * CAST(dbo.Producto.PrecioUnitarioVenta AS decimal(10, 2))), 1, 2) 
                         AS Monto
FROM            dbo.Venta INNER JOIN
                         dbo.Cliente ON dbo.Venta.idCliente = dbo.Cliente.idCliente INNER JOIN
                         dbo.EstadoVenta ON dbo.Venta.idEstadoVenta = dbo.EstadoVenta.idEstadoVenta INNER JOIN
                         dbo.TipoComprobante ON dbo.Venta.idTipoComprobante = dbo.TipoComprobante.idTipoComprobante INNER JOIN
                         dbo.DetalleVenta ON dbo.Venta.idVenta = dbo.DetalleVenta.idVenta INNER JOIN
                         dbo.Producto ON dbo.DetalleVenta.idProducto = dbo.Producto.idProducto
WHERE        (dbo.Venta.idEstadoVenta = 1)
GROUP BY dbo.Venta.idVenta, dbo.Venta.FechaVenta, dbo.Cliente.Nombre, dbo.Cliente.Apellido, dbo.EstadoVenta.DescripcionEstadoVenta, dbo.TipoComprobante.DescripcionTipoComprobante

GO

CREATE VIEW [dbo].[V_Venta_VentaConDetalles]
AS
SELECT        dbo.Venta.idVenta, CONVERT(varchar, dbo.Venta.FechaVenta, 103) AS Fecha, dbo.Cliente.Nombre, dbo.Cliente.Apellido, dbo.EstadoVenta.DescripcionEstadoVenta AS Estado, 
                         dbo.TipoComprobante.DescripcionTipoComprobante AS [Tipo de comprobante], dbo.Venta.NumeroComprobante as [N de Comprobante], dbo.Producto.Nombre AS Producto,
						 dbo.DetalleVenta.Cantidad AS [Cantidad Vendida], dbo.Producto.PrecioUnitarioVenta AS [Precio Unitario],
						 ROUND(SUM(CAST(dbo.DetalleVenta.Cantidad AS int) * CAST(dbo.Producto.PrecioUnitarioVenta AS decimal(10, 2))), 1, 2) 
                         AS [Total por Producto]
						 
FROM            dbo.Venta INNER JOIN
                         dbo.Cliente ON dbo.Venta.idCliente = dbo.Cliente.idCliente INNER JOIN
                         dbo.EstadoVenta ON dbo.Venta.idEstadoVenta = dbo.EstadoVenta.idEstadoVenta INNER JOIN
                         dbo.TipoComprobante ON dbo.Venta.idTipoComprobante = dbo.TipoComprobante.idTipoComprobante INNER JOIN
                         dbo.DetalleVenta ON dbo.Venta.idVenta = dbo.DetalleVenta.idVenta INNER JOIN
                         dbo.Producto ON dbo.DetalleVenta.idProducto = dbo.Producto.idProducto
						 
WHERE        (dbo.Venta.idEstadoVenta = 1)
GROUP BY dbo.Venta.idVenta, dbo.Venta.FechaVenta, dbo.Cliente.Nombre, dbo.Cliente.Apellido, dbo.EstadoVenta.DescripcionEstadoVenta, dbo.TipoComprobante.DescripcionTipoComprobante, dbo.Producto.Nombre, dbo.Venta.NumeroComprobante, dbo.DetalleVenta.Cantidad,dbo.Producto.PrecioUnitarioVenta

GO