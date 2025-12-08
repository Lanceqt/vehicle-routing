# Vehicle Routing - Agent Guidelines

## Learning Context
This project is for learning software development fundamentals, specifically:
- **.NET 10** and **C# 14** features and best practices
- **React** with **TanStack** (React Query, Router, etc.) for frontend
- **Full-stack development** patterns and architecture
- **Instructional approach**: Explain decisions, introduce concepts, provide learning resources when implementing features

## Build & Development Commands
- `dotnet run` - Start development server (HTTPS: localhost:7109, HTTP: localhost:5147)
- `dotnet build` - Build the project
- `dotnet build --configuration Release` - Build for production
- No test framework configured yet

## Code Style Guidelines
- **Naming**: PascalCase for public members/types, camelCase for private/local
- **Types**: Use record types for DTOs and immutable data structures
- **Nullability**: Nullable reference types enabled - use ? for optional types
- **Imports**: Implicit usings enabled - avoid unnecessary using statements
- **Async**: Use async/await patterns for all I/O operations (database, API calls)
- **Entity Framework**: Follow EF Core conventions, use DbContext pattern
- **API Design**: RESTful endpoints with proper HTTP methods and status codes using **FastEndpoints** package
- **FastEndpoints**: Use FastEndpoints framework for API development - use context7 MCP server to look up documentation: `/fastendpoints/documentation`
- **Error Handling**: Use try-catch for external API calls (Google Maps), return appropriate HTTP responses

## Documentation Lookup
- **First and foremost**: Use context7 MCP server to look up documentation for any libraries/packages before implementing
- Use `context7_resolve-library-id` to find the correct library ID
- Use `context7_get-library-docs` to get API references and code examples
- This applies to FastEndpoints, Entity Framework, React, TanStack, and any other dependencies

## Project Structure
- Root namespace: `vehicle_routing`
- Use dependency injection for services
- OpenAPI/Swagger available in development mode
- SQLite database with EF Core migrations

## GitHub Copilot Instructions
See `.github/copilot-instructions.md` for detailed GitHub Copilot guidelines that mirror these agent instructions.