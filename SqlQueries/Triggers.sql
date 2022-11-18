CREATE TRIGGER [dbo].TR_Obtiene_Total ON [dbo].[Venta]
AFTER UPDATE AS
BEGIN
	
	DROP TABLE IF EXISTS #T_TotalFactura

	SELECT Venta.idVenta, ROUND(SUM(CAST(dbo.DetalleVenta.Cantidad AS int) * CAST(dbo.Producto.PrecioUnitarioVenta AS decimal(10, 2))), 1, 2) as Total
	INTO #T_TotalFactura
	FROM            dbo.Venta INNER JOIN
                         dbo.Cliente ON dbo.Venta.idCliente = dbo.Cliente.idCliente INNER JOIN
                         dbo.EstadoVenta ON dbo.Venta.idEstadoVenta = dbo.EstadoVenta.idEstadoVenta INNER JOIN
                         dbo.TipoComprobante ON dbo.Venta.idTipoComprobante = dbo.TipoComprobante.idTipoComprobante INNER JOIN
                         dbo.DetalleVenta ON dbo.Venta.idVenta = dbo.DetalleVenta.idVenta INNER JOIN
                         dbo.Producto ON dbo.DetalleVenta.idProducto = dbo.Producto.idProducto
	WHERE        (dbo.Venta.idEstadoVenta = 1 or dbo.Venta.idEstadoVenta = 2)
	GROUP BY Venta.idVenta

	UPDATE Venta SET Total=#T_TotalFactura.Total
	FROM Venta INNER JOIN #T_TotalFactura
	ON venta.idVenta = #T_TotalFactura.idVenta
	WHERE Venta.idEstadoVenta = 1 or Venta.idEstadoVenta = 2

	DROP TABLE IF EXISTS #T_TotalFactura
	
END
