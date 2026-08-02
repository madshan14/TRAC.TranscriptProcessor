# AI Context

## Purpose

This repository contains the source code for TRAC.TranscriptProcessor.

This document defines the architectural rules that every contributor and AI assistant must follow.

## Architecture

- Modular Monolith
- Clean Architecture
- CQRS
- Vertical Slice Architecture
- Domain-Driven Design (where appropriate)

## Principles

- Modules are independent.
- Modules communicate through contracts.
- Business logic belongs in Application handlers.
- Domain contains business rules only.
- Infrastructure contains implementation details.
- Presentation exposes Minimal API endpoints.

## Project Goals

- Maintainable
- Testable
- Loosely coupled
- Highly cohesive
- Production ready

This document will evolve as the project grows.