# Raíz y Hoja - Página Web Responsiva con ASP.NET Core

Este proyecto es una página web responsiva desarrollada con **ASP.NET Core 8.0.14** para una empresa ficticia llamada **Raíz y Hoja**. La página incluye un formulario de contacto en la esquina inferior derecha que recopila datos del usuario y los almacena en una base de datos utilizando **Entity Framework Core**.

## Requisitos

### Entorno de Desarrollo
- **Visual Studio 2022** o superior.
- **.NET Core SDK 8.0.14** o superior.
- **SQL Server** (LocalDB o SQL Server Express).

### Tecnologías Utilizadas
- **ASP.NET Core MVC**
- **Entity Framework Core**
- **HTML, CSS y Bootstrap**
- **SweetAlert2** para notificaciones.
- **Font Awesome** para íconos.

### Dependencias
-Microsoft.EntityFrameworkCore.SqlServer (8.0.14)
-Microsoft.EntityFrameworkCore.Tools (8.0.14)

## Funcionalidades

### Página Web Responsiva
- La página principal es adaptativa y se visualiza correctamente en dispositivos de escritorio y móviles.
- Diseño moderno y atractivo con un enfoque en la experiencia del usuario (UX).

### Formulario de Contacto
- Ubicado en la esquina inferior derecha de la pantalla. Con un botón modal que abre la pestaña del formulario presentándolo con la posición requerida de una manera creativa.
- Campos requeridos: **Nombre**, **Email**, **Mensaje**.
- Los datos se validan y almacenan en una base de datos al enviar el formulario.
- Uso de **SweetAlert2** para mostrar mensajes de éxito o error.

### Base de Datos
- Se utiliza **Entity Framework Core** para interactuar con la base de datos.
- Se ha creado un modelo de datos (`ContactFormIndex`) que incluye los campos del formulario de contacto.
- Migraciones de EF Core para la creación y actualización de la base de datos.

## Estructura del Proyecto

### Controladores
- **HomeController**: Maneja las vistas principales (Home, Privacy, Error).
- **ContactController**: Procesa el formulario de contacto y guarda los datos en la base de datos.

### Modelos
- **ContactFormIndex**: Modelo que representa los datos del formulario de contacto.
  - Campos: `Id`, `Name`, `Email`, `Message`, `CreatedAt`.

### Vistas
- **Index.cshtml**: Página principal con el diseño responsivo y el botón flotante para el formulario de contacto.
- **Privacy.cshtml**: Página de privacidad (opcional).
- **Error.cshtml**: Página de error personalizada.

### Base de Datos
- **ApplicationDbContext**: Contexto de la base de datos que incluye el `DbSet` para los formularios de contacto.
- **Conexión SQL**: Configurada en `appsettings.json` para usar **LocalDB**.


## Instrucciones para Ejecutar el Proyecto

## 1.Clonar el Repositorio:

   git clone 

## 2.Abrir el Proyecto en Visual Studio:

Abre el archivo RaizyHojaWebApp.sln en Visual Studio.

## 3.Configurar la Base de Datos:

Asegúrarse de que SQL Server LocalDB esté instalado.

Configurar la cadena de conexión en appsettings.json:

  "ConnectionStrings": {
    "ConexionSql": "Server=(localdb)\\mssqllocaldb;Database=RaizyHojaDb;Trusted_connection=True;MultipleActiveResultSets=True"
}  
`

## 4.Ejecutar las Migraciones:

Abrir la Consola del Administrador de Paquetes en Visual Studio.

Ejecutar el siguiente comando para aplicar las migraciones y crear la base de datos:
`  Update-Database  `

## 5. Presionar F5 en Visual Studio o ejecuta el siguiente comando en la terminal:

` dotnet run  `

## 6. Acceder a la Aplicación:

Abrir el navegador y visita https://localhost:5001 (o el puerto que se indique en la consola).

