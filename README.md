<div align="center">

  <h1>💳 Payment Cards Management System</h1>
  <p><b>A Full-Stack Web Application built with Angular, .NET Core Web API, and Entity Framework Core.</b></p>

  <!-- Badges -->
  <p>
    <img src="https://img.shields.io/badge/Angular-DD0031?style=for-the-badge&logo=angular&logoColor=white" />
    <img src="https://img.shields.io/badge/TypeScript-3178C6?style=for-the-badge&logo=typescript&logoColor=white" />
    <img src="https://img.shields.io/badge/Bootstrap-7952B3?style=for-the-badge&logo=bootstrap&logoColor=white" />
    <img src="https://img.shields.io/badge/Sass/SCSS-CC6699?style=for-the-badge&logo=sass&logoColor=white" />
    <img src="https://img.shields.io/badge/.NET_Core-512BD4?style=for-the-badge&logo=dotnet&logoColor=white" />
    <img src="https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=csharp&logoColor=white" />
    <img src="https://img.shields.io/badge/EF_Core-512BD4?style=for-the-badge&logo=dotnet&logoColor=white" />
    <img src="https://img.shields.io/badge/SQL_Server-CC292B?style=for-the-badge&logo=microsoftsqlserver&logoColor=white" />
  </p>

</div>

---

## 📝 Overview

This project is a complete **Full-Stack Payment Cards Management Application**. It features a modern, dynamic user interface built with **Angular (Reactive Forms)** and a robust RESTful backend API powered by **.NET Core** and **Entity Framework Core**. 

The app allows users to seamlessly perform full **CRUD operations** (Create, Read, Update, Delete) on payment card records with real-time validation and responsive design.

---

## ✨ Features

### 🅰️ Client-Side (Frontend)
- **Reactive Forms Integration:** Robust form validation (card number format, expiration dates, security codes) with clean user feedback.
- **Dynamic Data Display:** Real-time updating list of payment cards using RxJS HTTP Client services.
- **Responsive UI/UX:** Styled using **Bootstrap** and custom **SCSS** for pixel-perfect layout on all screen sizes.
- **Form State Management:** Easily reset, populate, and submit card details.

### ⚙️ Server-Side (Backend API)
- **RESTful Endpoints:** Full CRUD API architecture for card details management.
- **EF Core Database Handler:** Code-First database migrations and management with SQL Server.
- **LINQ Queries:** Efficient data filtering and mapping on the server side.
- **Swagger Documentation:** Interactive API testing environment.

---

## 🛠️ Tech Stack & Architecture

| Layer | Technologies Used |
| :--- | :--- |
| **Frontend** | Angular, TypeScript, Reactive Forms, SCSS, HTML5, Bootstrap |
| **Backend** | C#, .NET Core Web API, LINQ |
| **Database & ORM** | Microsoft SQL Server, Entity Framework Core (Code-First) |
| **Tools & Testing** | Visual Studio / VS Code, Postman, Swagger UI, Git |

---

## 📡 API Endpoints Summary

| Method | Endpoint | Description |
| :--- | :--- | :--- |
| `GET` | `/api/PaymentDetail` | Retrieve all payment cards |
| `GET` | `/api/PaymentDetail/{id}` | Get specific card details by ID |
| `POST` | `/api/PaymentDetail` | Add a new payment card |
| `PUT` | `/api/PaymentDetail/{id}` | Update an existing payment card |
| `DELETE` | `/api/PaymentDetail/{id}` | Remove a payment card |

---

## ⚡ Getting Started

### Prerequisites
- [Node.js](https://nodejs.org/) & [Angular CLI](https://angular.io/cli)
- [.NET Core SDK](https://dotnet.microsoft.com/)
- [SQL Server](https://www.microsoft.com/en-us/sql-server)

### Running the Backend (.NET Core)
1. Navigate to the backend folder:
   ```bash
   cd PaymentAPI
