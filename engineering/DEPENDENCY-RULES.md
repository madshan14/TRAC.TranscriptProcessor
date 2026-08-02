# Dependency Rules

Every project in the solution must respect the dependency graph.

Rules:

- Domain depends on nothing.
- Application depends on Domain.
- Infrastructure depends on Application.
- Presentation depends on Application.
- Modules must not reference another module's Infrastructure.
- Modules communicate through Contracts.

Architecture tests will enforce these rules.