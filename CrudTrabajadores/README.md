# CRUD de Trabajadores - ASP.NET Core MVC

Este proyecto es una aplicación web desarrollada en Visual Studio 2022 utilizando ASP.NET Core MVC, Entity Framework Core y SQL Server. Permite gestionar trabajadores mediante operaciones CRUD (Crear, Leer, Editar, Eliminar), con interfaz moderna basada en Bootstrap 5 y uso de modales.

## 🛠 Tecnologías utilizadas

- ASP.NET Core MVC (.NET 8.0)
- Entity Framework Core (Code First)
- SQL Server 2022
- Bootstrap 5
- JavaScript (modales dinámicos vía Fetch API)

## ⚙️ Funcionalidades

- Crear trabajador (en modal)
- Listar trabajadores en grilla
- Editar trabajador (en modal)
- Eliminar trabajador (confirmación en modal)
- Validaciones en cliente y servidor

## 📦 Instalación y ejecución

1. Clona el repositorio:
   ```bash
   git clone https://github.com/tuusuario/CrudTrabajadores.git
   cd CrudTrabajadores
   ```

2. Abre el proyecto en Visual Studio 2022

3. Configura la conexión en `appsettings.json`:
   ```json
   "ConnectionStrings": {
     "DefaultConnection": "Server=localhost\\SQLEXPRESS;Database=CrudTrabajadores;Trusted_Connection=True;"
   }
   ```

4. Ejecuta migraciones desde el **Administrador de paquetes**:
   ```
   Add-Migration InitialCreate
   Update-Database
   ```

5. Ejecuta la aplicación (`Ctrl + F5` o botón ▶️)

## 🗃 Script SQL

El script para crear la base de datos se encuentra en la carpeta `/Database` del repositorio (ver archivo `Script_CrudTrabajadores.sql`).

## 🖼 Diagramas

Se incluyen diagramas de secuencia básicos para cada operación CRUD dentro de la carpeta `/Diagramas`.

## 👤 Autor

Desarrollado por Pablo Álvarez como parte de un proyecto profesional.
