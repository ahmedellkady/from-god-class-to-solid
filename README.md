# From God Class to SOLID Design

A small C# refactoring exercise that shows how a messy `OrderProcessor` class can be transformed into a cleaner, more maintainable SOLID-based design.

## The Story

The original code had one class called `OrderProcessor`.

It was responsible for:

- validating orders
- calculating discounts
- saving orders
- sending confirmation emails
- generating reports
- exporting CSV
- logging

This made the class hard to change, hard to test, and easy to break.

## What Was Wrong?

### SRP — Single Responsibility Principle

`OrderProcessor` had too many responsibilities.

### OCP — Open/Closed Principle

Discount logic was handled using `if / else`, so adding a new order type required editing existing code.

### LSP — Liskov Substitution Principle

`ArchiveOrderStorage` inherited from `SqlOrderStorage`, but it could not support `Save()`.

### ISP — Interface Segregation Principle

`IOrderService` had unrelated methods for processing, notification, reporting, and exporting.

### DIP — Dependency Inversion Principle

`OrderProcessor` directly created concrete dependencies using `new`.

## The Refactor

The code was refactored into focused classes:

- `OrderValidator`
- `OrderProcessor`
- `OrderEmailSender`
- `OrderReportService`
- `DiscountCalculator`
- `SqlOrderStorage`
- `ArchiveOrderStorage`
- `ConsoleOrderLogger`

## Architecture Note

This structure is inspired by Clean Architecture, but it is intentionally simplified for a small training task.

The goal was not to create a complex enterprise architecture.

The goal was to separate responsibilities clearly:

- `Domain` contains the core models.
- `Abstractions` contains interfaces.
- `Application` contains business logic and flow.
- `Infrastructure` contains external details like storage, email, and logging.

## Before vs After

Before:

- one large class doing everything
- hard-coded dependencies
- difficult testing
- fragile changes

After:

- small focused classes
- strategy pattern for discounts
- constructor injection
- clearer dependencies
- easier testing

## Main Patterns Used

- Strategy Pattern
- Dependency Injection
- Interface Segregation
- Reader/Writer Interface Split
- Clean Architecture-inspired folder organization

## Technologies

- C#
- .NET

## Why This Repo Exists

This repo is part of my learning journey after the ITI 9-Month Track.

It helped me understand that software engineering is not only about writing code that works.

It is also about writing code that can survive change.
