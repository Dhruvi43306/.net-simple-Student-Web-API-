# Student Management API

## Overview

Student Management API is a simple ASP.NET Core Web API project that allows users to manage student records. It is designed for learning CRUD (Create, Read, Update, Delete) operations using .NET.

## Features

* Add a new student
* Get all students
* Get student by ID
* Update student details
* Delete a student
* Swagger API documentation

## Technologies Used

* ASP.NET Core Web API
* C#
* Swagger/OpenAPI
* Visual Studio

## Project Structure

StudentApi
│
├── Controllers
│   └── StudentController.cs
│
├── Models
│   └── StudentModel.cs
│
├── Program.cs
│
└── README.md

## Student Model

```json
{
  "id": 1,
  "name": "Dhruvi",
  "age": 20,
  "email": "dhruvi@gmail.com"
}
```

## API Endpoints

### Get All Students

GET /

### Get Student By ID

GET /{id}

### Add Student

POST /

### Update Student

PUT /{id}

### Delete Student

DELETE /api/student/{id}

## How to Run

1. Clone the project
2. Open in Visual Studio
3. Build the project
4. Run the application
5. Open Swagger

```
https://localhost:xxxx/swagger
```

## Learning Objectives

This project helps beginners understand:

* ASP.NET Core Web API
* Controllers
* Routing
* Models
* CRUD Operations
* Swagger Testing

## Future Improvements

* SQL Server Integration
* Entity Framework Core
* JWT Authentication
* Role-Based Authorization
* Student Attendance Module
* Student Result Module

## Author

Developed as a learning project to understand ASP.NET Core Web API development.
