CREATE PROC ProcVentaTotal
AS
BEGIN
SELECT SUM(dbo.Venta.Total) as [Venta Total]
FROM dbo.Venta 
END
GO

