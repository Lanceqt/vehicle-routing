# GitHub Copilot Instructions for Vehicle Routing Project

## Project Context
This is a learning project focused on .NET 10, C# 14, and React with TanStack. The goal is to learn modern full-stack development patterns while building a vehicle routing management system.

## Code Generation Guidelines

### .NET Backend
- Use .NET 10 and C# 14 modern features (primary constructors, file-scoped namespaces)
- Follow Entity Framework Core best practices with async operations
- Generate proper RESTful API endpoints with OpenAPI documentation using **FastEndpoints** package
- Use FastEndpoints framework for API development - use context7 MCP server to look up documentation: `/fastendpoints/documentation`
- Include XML documentation comments for public APIs
- Use record types for DTOs and immutable data structures
- Follow async/await patterns for all I/O operations

### Frontend (when implemented)
- Use React with TanStack (React Query, Router, etc.)
- Follow modern React patterns and hooks
- Implement proper state management and data fetching

### General Guidelines
- Follow the established naming conventions and project structure
- Consider the learning context - provide educational comments when helpful
- Use modern C# features appropriately for the learning objectives
- Handle errors gracefully, especially for external API calls (Google Maps)
- Use dependency injection patterns throughout the application

### Documentation Lookup
- **First and foremost**: Use context7 MCP server to look up documentation for any libraries/packages before implementing
- Use `context7_resolve-library-id` to find the correct library ID
- Use `context7_get-library-docs` to get API references and code examples
- This applies to FastEndpoints, Entity Framework, React, TanStack, and any other dependencies

### Learning Focus
- Explain decisions and introduce concepts when implementing features
- Provide learning resources and best practices
- Demonstrate full-stack development patterns
- Show proper integration between frontend and backend components