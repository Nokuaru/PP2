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
