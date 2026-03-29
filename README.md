
# HST Audit Backend System

## 📌 Overview
This project is a backend system developed as part of a technical assessment. It demonstrates the implementation of a scalable and maintainable backend using **ASP.NET Core**, **Clean Architecture**, and **PostgreSQL** with a **Code First approach**.

The system focuses on proper structure, secure data handling, and real-world backend development practices.

---

## 🎯 Objectives
- Design a clean and maintainable backend architecture
- Implement RESTful API using ASP.NET Core
- Apply Clean Architecture principles
- Use PostgreSQL with Entity Framework Core (Code First)
- Ensure secure handling of user data

---

## 🏗️ Architecture (Clean Architecture)

The project is structured into the following layers:

### 1. Domain Layer
- Core business entities (User, Role)
- Contains no external dependencies

### 2. Application Layer
- DTOs (Data Transfer Objects)
- Handles communication between layers

### 3. Infrastructure Layer
- Database access using Entity Framework Core
- Contains DbContext and configurations

### 4. API Layer
- Entry point of the application
- Handles HTTP requests and responses

---

## 🗄️ Database Design

### Entities

#### User
- Id (GUID)
- FullName
- Email
- PasswordHash
- CreatedAt
- RoleId (Foreign Key)

#### Role
- Id (GUID)
- Name

### Relationship
- One Role → Many Users
- Enforced using foreign key constraints

---

## ⚙️ Technologies Used

- ASP.NET Core Web API
- C#
- PostgreSQL
- Entity Framework Core (Code First)
- BCrypt (for password hashing)

---

## 🔐 Security Features

- Passwords are hashed using BCrypt
- Plain text passwords are never stored
- Sensitive data is not returned in API responses

---

## 🚀 API Endpoint

### Register User

**POST** `/api/users/register`

#### Request Body:
```json
{
  "fullName": "Yabets",
  "email": "yabets@example.com",
  "password": "123456"
}
````

#### Response:

```json
{
  "id": "GUID",
  "fullName": "Yabets",
  "email": "yabets@example.com",
  "role": "Admin"
}
```

---

## ✅ Features Implemented

* User registration API
* Role-based relationship
* Password hashing
* Duplicate email validation
* Clean API response design

---

## 🔧 Setup Instructions

### 1. Clone Repository

```bash
git clone https://github.com/YOUR_USERNAME/hst-audit-backend.git
cd hst-audit-backend
```

### 2. Configure Database

Update connection string in `Program.cs`:

```csharp
Host=localhost;Port=5432;Database=hst_audit_db;Username=postgres;Password=YOUR_PASSWORD
```

### 3. Run Migrations

```bash
dotnet ef database update --project HST_Audit.Infrastructure --startup-project HST_Audit.API
```

### 4. Run Application

```bash
dotnet run --project HST_Audit.API
```

---

## 📈 Improvements Beyond Requirements

* Implemented secure password hashing
* Prevented duplicate user registration
* Removed hardcoded values (dynamic role assignment)
* Applied Clean Architecture structure
* Ensured database integrity with foreign keys

---

## 📌 Future Enhancements

* JWT Authentication
* Role-based authorization
* Logging and monitoring
* Unit and integration testing

---

## 👨‍💻 Author

**Yabets Desalegn**

---

## 📬 Feedback

I welcome feedback and suggestions for improvement.

````
