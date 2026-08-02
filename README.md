# TRAC.TranscriptProcessor

TRAC.TranscriptProcessor is an enterprise-grade modernization of the legacy **ImageToTOR** application.

Rather than porting the original codebase, this project preserves the legacy application's business capabilities while redesigning the entire system using modern software architecture principles.

## Architecture

The solution is built using:

* Modular Monolith
* Clean Architecture
* Vertical Slice Architecture
* CQRS (Command Query Responsibility Segregation)
* Domain-Driven Design (DDD)
* ASP.NET Core
* Entity Framework Core
* JWT Authentication & Authorization (planned)

## Project Goals

The primary objectives of this project are to:

* Modernize the legacy ImageToTOR application.
* Improve maintainability, scalability, and testability.
* Establish clear module boundaries.
* Separate business logic from infrastructure concerns.
* Introduce enterprise-grade authentication and authorization.
* Create a foundation that can evolve into microservices if needed.

The legacy application serves as the source of business requirements—not the architectural blueprint.

---

# Current Architecture

```text
src
│
├── Api
│
├── Worker
│
├── BuildingBlocks
│   ├── TRAC.TranscriptProcessor.BuildingBlocks.Domain
│   ├── TRAC.TranscriptProcessor.BuildingBlocks.Application
│   └── TRAC.TranscriptProcessor.BuildingBlocks.Infrastructure
│
└── Modules
    ├── Identity
    │   ├── Domain
    │   ├── Application
    │   ├── Infrastructure
    │   └── Presentation
    │
    ├── Images
    ├── Transcript
    └── Processing
```

Every business module follows the same layered architecture.

---

# Dependency Direction

The solution enforces the following dependency flow:

```text
Presentation
      │
      ▼
Application
      │
      ▼
Domain

Infrastructure
      │
      ▼
Application
      │
      ▼
Domain
```

The Domain layer has no dependencies on higher layers, ensuring that business rules remain independent of frameworks and external technologies.

---

# Project Status

| Phase    | Description                       |  Status |
| -------- | --------------------------------- | :-----: |
| Phase 00 | Project Planning                  |    ✅    |
| Phase 01 | Repository Foundation             |    ✅    |
| Phase 02 | Solution Structure & Architecture |    ✅    |
| Phase 03 | Shared Building Blocks            |    ✅    |
| Phase 04 | Identity Module                   | 🚧 Next |

---

# Completed Work

## Phase 00 – Project Planning

* Defined project vision.
* Selected architectural patterns.
* Planned development roadmap.

## Phase 01 – Repository Foundation

* Created repository structure.
* Added engineering documentation.
* Established development standards.
* Organized solution layout.

## Phase 02 – Solution Structure & Architecture

* Created Modular Monolith solution.
* Established module boundaries.
* Implemented Clean Architecture layers.
* Added API and Worker hosts.
* Added architecture validation tests.
* Enforced dependency rules.

## Phase 03 – Shared Building Blocks

Established the shared architectural foundation used by every module.

### Domain

* Entity
* AggregateRoot
* ValueObject
* Domain Events
* Domain Exceptions

### Application

* CQRS contracts
* Result pattern
* Error abstraction
* Time abstraction

### Infrastructure

* Shared dependency injection
* SystemDateTimeProvider
* Common infrastructure conventions

### Engineering

* Centralized build configuration using `Directory.Build.props`
* Nullable reference types enabled
* Warnings treated as errors
* Shared global usings
* Architecture tests extended to BuildingBlocks

---

# What's Next

## Phase 04 – Identity Module

The next milestone introduces enterprise-grade authentication and authorization.

Planned features include:

* ASP.NET Core Identity
* JWT Access Tokens
* Refresh Tokens
* User Management
* Role Management
* Permission-based Authorization
* Login
* Registration
* Password Reset
* Authentication Endpoints

The Identity module will become the security foundation for the entire application.

---

# Development Principles

Throughout this project we follow these principles:

* Build from the inside out (Domain → Application → Infrastructure → Presentation)
* Keep modules independent
* Prefer composition over coupling
* Keep business logic framework-agnostic
* Write architecture tests to enforce design decisions
* Make small, incremental, production-quality changes
* Preserve business behavior while improving architecture

---

# Legacy Application

The original **ImageToTOR** application is used solely as the reference implementation for business behavior.

Business requirements will be extracted and redesigned to fit the new architecture rather than copied directly into the new solution.
