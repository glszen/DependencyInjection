# DependencyInjection Project

## Description
This project demonstrates Dependency Injection in C# with a `Teacher` class, a `ClassRoom` class, and a base interface `ITeacher`.

## Classes and Interface

### ITeacher (Interface) ✅
- **Properties**: `FirstName`, `LastName`
- **Methods**: `GetInfo()`

### Teacher (Class) ✅
- Implements `ITeacher`.
- **Properties**: `FirstName`, `LastName`
- **Methods**: `GetInfo()` - Returns full name.

### ClassRoom (Class) ✅
- **Properties**: `Teacher` (of type `ITeacher`)
- **Methods**: `GetTeacherInfo()` - Calls `Teacher.GetInfo()`.
- **Constructor**: Accepts `ITeacher` instance.

