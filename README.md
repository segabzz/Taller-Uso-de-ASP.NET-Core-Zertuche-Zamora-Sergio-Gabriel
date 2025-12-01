# ToDoApp – Lista de Tareas Personalizada con ASP.NET Core

Este repositorio contiene el proyecto desarrollado durante el taller de ASP.NET Core, implementando una aplicación web completa que utiliza el patrón **Modelo-Vista-Controlador (MVC)**, **Entity Framework Core** y **Identity** para la seguridad.

## 🚀 Características principales

- **Arquitectura MVC:** Aplicación construida siguiendo el patrón de diseño Modelo-Vista-Controlador con ASP.NET Core.
- **Seguridad:** Sistema de autenticación y registro de usuarios (cada usuario gestiona únicamente su propia lista).
- **Gestión de Tareas:** Listas personalizadas vinculadas a la cuenta del usuario.
- **CRUD Completo:**
  - Crear nuevas tareas.
  - Leer y visualizar el listado de tareas.
  - Actualizar tareas existentes.
  - Eliminar tareas definitivamente.
- **Filtrado:** Funcionalidad para filtrar tareas por prioridad (Alta, Media, Baja).
- **Base de Datos Portátil:** Uso de **SQLite** para facilitar el despliegue y pruebas sin configuraciones complejas.

---

## 🛠 Instrucciones para ejecutar el proyecto

### 1. Clonar el repositorio
```bash
git clone [https://github.com/TU-USUARIO/ToDoApp.git](https://github.com/TU-USUARIO/ToDoApp.git)
cd ToDoApp
````

### 2\. Abrir el proyecto

  * Abre la carpeta del proyecto en **Visual Studio Code** o Visual Studio 2022.

### 3\. Configurar la base de datos

El proyecto utiliza **SQLite**, por lo que la configuración es automática. Solo necesitas generar el archivo de base de datos (`app.db`) aplicando las migraciones:

```bash
dotnet ef database update
```

### 4\. Ejecutar la aplicación

Ejecuta el siguiente comando en la terminal:

```bash
dotnet run
```

Una vez iniciada, accede a la aplicación desde tu navegador en:
👉 **http://localhost:5053** (o el puerto que indique tu terminal).

-----

## 💻 Tecnologías utilizadas

  * **ASP.NET Core 7.0 / 8.0**
  * **Entity Framework Core** (ORM)
  * **SQLite** (Base de datos)
  * **ASP.NET Core Identity** (Autenticación)
  * **Bootstrap 5** (Diseño responsivo)
  * **jQuery Validation** (Validación del lado del cliente)

## 📂 Estructura del proyecto

```text
ToDoApp/
│
├── Controllers/      # Lógica de control (TodoController.cs)
├── Models/           # Modelos de datos (TodoItem.cs)
├── Views/            # Interfaz de usuario (Razor Views)
│   ├── Todo/         # Vistas CRUD (Create, Edit, Index, Delete)
│   └── Shared/       # Layouts y parciales
├── Data/             # Contexto de base de datos y migraciones
├── wwwroot/          # Archivos estáticos (CSS, JS, Librerías)
├── appsettings.json  # Configuración de conexión a SQLite
└── README.md         # Documentación del proyecto
```

## 🧪 Credenciales de prueba (Opcional)

Puedes registrar un usuario nuevo o usar estos datos si decides configurar un seed de datos:

  * **Usuario:** usuario@prueba.com
  * **Contraseña:** Demo123\!

## 📄 Licencia

Este proyecto se distribuye bajo la licencia **MIT**.
