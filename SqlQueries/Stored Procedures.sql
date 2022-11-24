CREATE PROC ProcVentaTotal
AS
BEGIN
SELECT SUM(dbo.Venta.Total) as [Venta Total]
FROM dbo.Venta 
END
GO

----- crea  ACTUALIZA STOCK --------

CREATE PROCEDURE dbo.ActualizaStock
    @idProducto int,   
    @cantidadDescontar int   
AS   

    UPDATE Producto SET
	Cantidad = Cantidad - @cantidadDescontar where idProducto = @idProducto
GO
