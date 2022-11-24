# **SIGAME**
#### _Proyecto final de PP2 - IFTS 2022 2Q Comisión 2B_

---

## **Importante**

- Esto es un MVP
- Todavía no sabemos cuantos integrantes reales somos porque pasaron cosas
- Tenga piedad

## **Integrantes**

- Gonzalo Olarte
- Gabriela Asken
- Facundo Tomas

## **Acerca de**

SIGAME es una aplicación de gestión de ventas, productos y stock para un buffet/kiosco

v0.1:
- Permite la carga, edición y eliminación de productos
- Permite generar facturas de venta con sus productos asociados
- Permite consultar productos y ventas generadas


## **Tech**

- [Visual Studio C#](https://visualstudio.microsoft.com/es/vs/features/net-development/)
- [SQL Server](https://www.microsoft.com/es-es/sql-server/sql-server-downloads)
- [Git](https://git-scm.com/)
- [Trello](https://trello.com/b/Uep3os9K/grupo-42)

## **Instalación**

1) Instalar [SQL Server](https://www.microsoft.com/es-es/sql-server/sql-server-downloads)
2) Instalar [Visual Studio Community](https://visualstudio.microsoft.com/es/vs/features/net-development/)
3) Instalar [Git](https://git-scm.com/)
4) Clonar repo PP2
```
git clone https://github.com/Nokuaru/PP2
```
5) Ejecutar Queries en SQL Server
```
Query Completo.sql
Vistas.sql
Stored Procedures.sql
Triggers.sql
```
6) Abrir la Solución **PP2.sln** en Visual Studio
7) Modificar el servidor en **Conexión.cs**
```
public Conexion()
{
	con = new SqlConnection(@"Data Source = %NOMBREDESERVER%; Initial Catalog = Grupo42; Integrated Security = True");
}
```
8) Ejecutar utilizando el siguiente usuario
```
Usuario: nokuaru 
Contraseña: 123456
```
## **Documentación Complementaria**

[Google Drive](https://drive.google.com/drive/folders/1stJxENv8zSXfTaXmVVeULtq8sT1-aM-f?usp=share_link)

