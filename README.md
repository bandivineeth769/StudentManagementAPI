# Student Management API

## Features
- CRUD operations for students
- JWT Authentication
- Layered Architecture
- Global Exception Handling
- Swagger Documentation

## Technologies Used
- ASP.NET Core Web API
- Entity Framework Core
- SQL Server

## Setup Steps
1. Clone repository
2. Update connection string
3. Run migrations:
   Add-Migration InitialCreate
   Update-Database
4. Run project

## API Endpoints
- GET /api/student
- POST /api/student
- PUT /api/student
- DELETE /api/student/{id}
- POST /api/auth/login
