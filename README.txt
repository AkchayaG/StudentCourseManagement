Student Course Management System - PDF code in a ready VS Code project

1. Install .NET 10 SDK and SQL Server Express / SQL Server.
2. Open database.sql in SSMS and execute it.
3. In Program.cs, edit the connection string if your SQL Server instance is not .\SQLEXPRESS.
4. Open this folder in VS Code terminal.
5. Run:
   dotnet restore
   dotnet build
   dotnet run

Features:
- Add student, view all students, search student by ID
- Add course, view all courses, search course by ID
- ADO.NET using Microsoft.Data.SqlClient
- Service validation and repository database access

This project follows the core sample code in the uploaded PDF. The optional enrollment transaction exercise is not included in the initial runnable menu.
