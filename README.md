# 📌 API de Gestión de Tareas

## 🚀 Descripción

Esta es una API RESTful desarrollada en **.NET 7** utilizando **Entity Framework Core** para gestionar tareas.

## 🛠️ Tecnologías Utilizadas

- **ASP.NET Core 7** - Framework principal.
- **Entity Framework Core** - ORM para manejar datos en memoria.
- **Swagger** - Documentación interactiva de la API.
- **CORS** - Para permitir solicitudes desde el frontend en Angular.

## 📂 Estructura del Proyecto

```
📁 TaskApi
 ┣ 📁 Controllers
 ┃ ┗ 📄 TasksController.cs
 ┣ 📁 Data
 ┃ ┗ 📄 AppDbContext.cs
 ┣ 📁 Models
 ┃ ┗ 📄 Tarea.cs
 ┣ 📄 Program.cs
 ┣ 📄 appsettings.json
```

## ⚙️ Instalación y Ejecución

### 1️⃣ Clonar el repositorio

```sh
git clone https://github.com/ingdanielleo/tareasapk
cd tareasapk
```

### 2️⃣ Instalar dependencias

```sh
dotnet restore
```

### 3️⃣ Ejecutar la API

```sh
dotnet run
```

La API estará disponible en **`https://localhost:5001`** (o puerto asignado).

## 🔗 Endpoints

### 📌 Obtener todas las tareas

**GET** `/api/tareas`

```json
[
  {
    "id": 1,
    "titulo": "Lavar el carro",
    "descripcion": "Lavar con agua y jabón",
    "estado": false
  }
]
```

### 📌 Crear una tarea

**POST** `/api/tareas`

```json
{
  "titulo": "Cambiar aceite",
  "descripcion": "Usar aceite sintético",
  "estado": false
}
```

### 📌 Actualizar una tarea

**PUT** `/api/tareas/{id}`

### 📌 Eliminar una tarea

**DELETE** `/api/tareas/{id}`

## 📝 Notas adicionales

- Para probar la API, puedes acceder a:
  👉 `https://tareasapk-f163150aa2f2.herokuapp.com/api/tasks`
- Se usa una base de datos en memoria con **Entity Framework Core**.
- Habilitado CORS para permitir solicitudes desde Angular.

## 🏆 Autor

Desarrollado por **Jorge Daniel Leon Prieto** | 🚀 2025
