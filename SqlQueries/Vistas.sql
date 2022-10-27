USE [Grupo42]
GO

/************** CREACIÓN DE VISTAS **************/

-- CREA V_Compra_UltimasCompras
/****** V_Compra_UltimasCompras    Script Date: 27/10/2022 17:58:12 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[V_Compra_UltimasCompras]
AS
SELECT        TOP (100) PERCENT dbo.Compra.idCompra, dbo.Compra.Total, CONVERT(varchar, dbo.Compra.FechaCompra, 103) AS Expr1, dbo.Compra.TipoComprobante, dbo.Proveedor.RazonSocial, dbo.Producto.Cantidad, 
                         dbo.Producto.Nombre
FROM            dbo.Compra INNER JOIN
                         dbo.DetalleCompra ON dbo.Compra.idCompra = dbo.DetalleCompra.idCompra INNER JOIN
                         dbo.Producto ON dbo.DetalleCompra.idProducto = dbo.Producto.idProducto INNER JOIN
                         dbo.Proveedor ON dbo.Producto.idProveedor = dbo.Proveedor.idProveedor
ORDER BY dbo.Compra.FechaCompra DESC
GO

USE [Grupo42]
GO

/****** CREA V_PRODUCTO_PRODUCTOS ******/
/****** Object:  View [dbo].[V_Producto_Productos]    Script Date: 27/10/2022 18:29:28 ******/


CREATE VIEW [dbo].[V_Producto_Productos]
AS
SELECT        dbo.CategoriaProducto.DescripcionCatProd AS [Tipo de Producto], dbo.Producto.Nombre, dbo.Proveedor.RazonSocial AS Proveedor, dbo.Producto.Cantidad, 
                         dbo.Producto.PrecioUnitarioCompra AS [Precio Unitario Compra], dbo.Producto.PrecioUnitarioVenta AS [Precio Unitario Venta]
FROM            dbo.Producto INNER JOIN
                         dbo.CategoriaProducto ON dbo.Producto.idCategoria = dbo.CategoriaProducto.idCategoria INNER JOIN
                         dbo.Proveedor ON dbo.Producto.idProveedor = dbo.Proveedor.idProveedor
GO
