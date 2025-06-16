# Top.MasonTech.NetCoreBaseAPI

A clean architecture-based .NET 8.0 Web API template for building modern, maintainable web services.

## Project Overview

This project implements Clean Architecture (also known as Onion Architecture) to provide a scalable and testable foundation for web APIs. It separates concerns into distinct layers with clear dependency directions.

## 🏗️ Architecture

The project follows Clean Architecture principles with the following layers:

### Core

#### Domain Layer

Contains enterprise business rules and entities that represent the core business logic independent of application specifics.

- Business entities and value objects
- Domain logic and validation rules
- Domain events and services
- Repository interfaces

#### Application Layer

Contains application logic that orchestrates the flow of data to and from domain entities.

- Use cases implementation
- DTOs (Data Transfer Objects)
- Interfaces for infrastructure
- Mappers between layers
- Service implementations

### Infrastructure

- **Persistence**: Database access, repository implementations
- **External**: Integration with external services and APIs

### Presentation

- **APIs**: RESTful API controllers with Swagger documentation
- **Views**: Razor views (if applicable)

## 🚀 Technology Stack

- **.NET 8.0**: Latest .NET framework
- **ASP.NET Core**: Web API framework
- **Swagger/OpenAPI**: API documentation
- **Docker**: Containerization support

## 🔧 Getting Started

### Prerequisites

- .NET 8.0 SDK
- Docker (optional)

### Running the Application

1. Clone the repository
2. Navigate to the project directory
3. Run the application:

```bash
dotnet run
```

4. Open your browser and navigate to `https://localhost:5001/swagger` to view the API documentation

### Using Docker

```bash
docker build -t masontech-api .
docker run -p 8080:8080 -p 8081:8081 masontech-api
```

## 📝 Project Structure

```
Top.MasonTech.NetCoreBaseAPI/
├── Core/                           
│   ├── Application/                # Application services, DTOs, interfaces
│   └── Domain/                     # Business entities, logic, and rules
├── Infrastructure/                 
│   ├── External/                   # External service integrations
│   └── Persistence/                # Data access and repositories
├── Presentation/                   
│   ├── APIs/                       # API controllers and endpoints
│   └── Views/                      # Razor views (if applicable)
├── Program.cs                      # Application entry point
├── Dockerfile                      # Docker configuration
└── appsettings.json               # Application configuration
```

## 🧪 Development Guidelines

### API Design Best Practices

- Use proper HTTP methods for operations
- Implement consistent naming conventions
- Design resource-oriented URLs
- Include comprehensive error handling
- Support pagination for large datasets

### Clean Architecture Principles

1. **Independence**: Business rules don't depend on UI, database, or external frameworks
2. **Testability**: Business logic can be tested without external elements
3. **Maintainability**: Changes in external systems have minimal impact on business logic

## 📄 License

[Specify your license information here]

## 🏢 About MasonTech

This project template is maintained by MasonTech and provides a standardized approach to building scalable .NET Core applications following industry best practices.
