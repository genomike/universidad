# universidad

## Descripción del Proyecto

Este proyecto es una plataforma web para la gestión de una universidad, implementada con .NET C# para el backend y Blazor para el frontend. La arquitectura del sistema sigue el enfoque de Domain-Driven Design (DDD) y cada módulo se implementa como un microservicio independiente. Los módulos incluidos en el sistema son:

### 1. Módulo Académico
- Gestión de docentes
- Gestión de horarios de clases
- Gestión de alumnos (status de alumnos, matrículas)
- Gestión de cursos

### 2. Módulo Financiero
- Gestión de pagos
- Gestión de ventas de cursos a alumnos
- Gestión contable
- Gestión financiera (nóminas)

### 3. Módulo Recursos y Logística
- Gestión logística
- Gestión de almacén (requerimientos)
- Gestión de RRHH (asistencias)

### 4. Módulo Frontend/Core
- Frontend
- Autenticación/Autorización
- APIs Gateway
- Servicios compartidos

La arquitectura del sistema se organiza en las siguientes capas según el enfoque DDD:

- Api
- Application
- Domain
- Infrastructure
- Tests

## Configuración del Entorno de Desarrollo

Para configurar el entorno de desarrollo, siga los siguientes pasos:

1. Clone el repositorio:
   ```bash
   git clone https://github.com/genomike/universidad.git
   cd universidad
   ```

2. Instale .NET SDK:
   - Asegúrese de tener instalado .NET SDK 5.0 o superior. Puede descargarlo desde [aquí](https://dotnet.microsoft.com/download).

3. Instale las dependencias de cada módulo:
   ```bash
   cd gestion-docentes
   dotnet restore
   cd ../gestion-horarios
   dotnet restore
   cd ../gestion-alumnos
   dotnet restore
   cd ../gestion-cursos
   dotnet restore
   cd ../gestion-pagos
   dotnet restore
   cd ../gestion-ventas
   dotnet restore
   cd ../gestion-contable
   dotnet restore
   cd ../gestion-financiera
   dotnet restore
   cd ../gestion-logistica
   dotnet restore
   cd ../gestion-almacen
   dotnet restore
   cd ../gestion-rrhh
   dotnet restore
   cd ../frontend
   dotnet restore
   ```

## Ejecución del Proyecto

Para ejecutar el proyecto, siga los siguientes pasos:

1. Inicie los microservicios:
   ```bash
   cd gestion-docentes
   dotnet run
   cd ../gestion-horarios
   dotnet run
   cd ../gestion-alumnos
   dotnet run
   cd ../gestion-cursos
   dotnet run
   cd ../gestion-pagos
   dotnet run
   cd ../gestion-ventas
   dotnet run
   cd ../gestion-contable
   dotnet run
   cd ../gestion-financiera
   dotnet run
   cd ../gestion-logistica
   dotnet run
   cd ../gestion-almacen
   dotnet run
   cd ../gestion-rrhh
   dotnet run
   ```

2. Inicie la aplicación frontend:
   ```bash
   cd frontend
   dotnet run
   ```

3. Acceda a la aplicación web en su navegador en la dirección `http://localhost:5000`.

## Pruebas Unitarias

Para ejecutar las pruebas unitarias, siga los siguientes pasos:

1. Navegue al directorio de pruebas:
   ```bash
   cd tests
   ```

2. Ejecute las pruebas:
   ```bash
   dotnet test
   ```

## Sistema de Gestión de Login

El sistema de gestión de login utiliza las credenciales de acceso a Windows para autenticar a los usuarios. Asegúrese de que su entorno de desarrollo esté configurado correctamente para permitir la autenticación de Windows.
