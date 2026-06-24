# Lab Sample Tracker 🧬

API para administrar y trackear muestras de laboratorio utilizando .NET Core, C# y Entity Framework Core con SQL Server. Este es el proyecto inicial del roadmap de Bioinformática.

## 🚀 Tecnologías utilizadas
- .NET 8.0
- ASP.NET Core Web API
- Entity Framework Core (SQL Server)
- xUnit Testing

## 🏗️ Estructura del repositorio
- `src/LabSampleTracker.API`: Lógica del Backend y Endpoints.
- `tests/LabSampleTracker.Tests`: Pruebas unitarias.


lab-sample-tracker/             <-- Raíz del Repositorio Git 
│
├── LabSampleTracker.sln        <-- Archivo de Solución (Orquestador de proyectos)
├── .gitignore                  <-- Exclusiones oficiales de .NET 8
├── README.md                   <-- Esta documentación 
│
├── LabSampleTracker.API/       <-- Proyecto Principal (Web API) 
│   ├── LabSampleTracker.API.csproj
│   ├── Program.cs              <-- Punto de entrada y configuración de DI
│   ├── appsettings.json        <-- Cadenas de conexión (SQL Server)
│   │
│   ├── Controllers/            <-- Controladores (Rutas HTTP)
│   │   ├── PatientsController.cs
│   │   └── SamplesController.cs
│   │
│   ├── Data/                   <-- Contexto de Base de Datos
│   │   └── AppDbContext.cs
│   │
│   ├── DTOs/                   <-- Objetos de Transferencia de Datos
│   │   ├── PatientDto.cs
│   │   └── SampleDto.cs
│   │
│   └── Models/                 <-- Entidades del Dominio (Tablas)
│       ├── Patient.cs
│       └── Sample.cs
│
└── LabSampleTracker.Tests/     <-- Proyecto de Pruebas Unitarias 
    ├── LabSampleTracker.Tests.csproj
    └── SampleStatusTests.cs

## 📊 Organigrama y Estructura del Sistema

En el desarrollo de software empresarial, visualizamos el sistema en capas para entender cómo fluyen los datos, garantizando la separación de responsabilidades y la mantenibilidad del código.

### Arquitectura de Capas Lógicas

```text
[ Cliente: Navegador / Postman / Swagger ]
                  │
                  ▼ (Peticiones HTTP: GET, POST, PUT)
┌────────────────────────────────────────────────────────┐
│ 1. CAPA DE ENTRADA / CONTROLADORES (API)               │
│    - Recibe los Requests del cliente.                  │
│    - Expone los Endpoints públicos.                    │
│    - Mapea las Entidades a DTOs (Seguridad).           │
└─────────────────────────┬──────────────────────────────┘
                          │
                          ▼ (Inyección de Dependencias)
┌────────────────────────────────────────────────────────┐
│ 2. CAPA DE PERSISTENCIA Y DATOS (EF Core)              │
│    - Gestiona el Contexto de BD (AppDbContext).        │
│    - Traduce consultas LINQ a código SQL.              │
│    - Reglas de negocio básicas y Enums (Status).       │
└─────────────────────────┬──────────────────────────────┘
                          │
                          ▼ (Manejador ADO.NET / TCP)
┌────────────────────────────────────────────────────────┐
│ 3. CAPA DE ALMACENAMIENTO (SQL Server)                 │
│    - Almacena las tablas físicas.                      │
│    - Garantiza integridad referencial (1:N).           │
└────────────────────────────────────────────────────────┘ 