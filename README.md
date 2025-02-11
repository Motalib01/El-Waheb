# El-Waheb

##  Overview
**El-Waheb** is a modern web application built using **ASP.NET Core** and **Entity Framework Core** with a well-structured database context and best practices for managing entity configurations. The project follows the **repository pattern** and **clean architecture principles** to ensure scalability and maintainability.

##  Tech Stack
- **Backend:** ASP.NET Core Web API
- **ORM:** Entity Framework Core
- **Database:** SQL Server / PostgreSQL (Configurable)
- **Dependency Injection:** Built-in .NET Core DI container

##  Project Structure
```
/ElWaheb
   ├── Data
   │      ├── ApplicationDbContext.cs
   │      ├── Configurations
   │      │      ├── UserConfiguration.cs
   │      │      ├── NotificationConfiguration.cs
   │      │      ├── LocationConfiguration.cs
   │      │      ├── DonationRequestConfiguration.cs
   │
   ├── Models
   │      ├── User.cs
   │      ├── Notification.cs
   │      ├── Location.cs
   │      ├── DonationRequest.cs
   │
   ├── Repositories
   │      ├── IRepository.cs
   │      ├── Repository.cs
   │
   ├── Controllers
   │      ├── UsersController.cs
   │      ├── NotificationsController.cs
   │      ├── LocationsController.cs
```

##  Database Configuration
1. **Configure the connection string** in `appsettings.json`:
   ```json
   "ConnectionStrings": {
       "DefaultConnection": "Server=YOUR_SERVER;Database=ElWahebDB;User Id=YOUR_USER;Password=YOUR_PASSWORD;"
   }
   ```
2. **Apply Migrations**:
   ```sh
   dotnet ef migrations add InitialCreate
   dotnet ef database update
   ```

##  Running the Project
1. Clone the repository:
   ```sh
   git clone https://github.com/YOUR_USERNAME/El-Waheb.git
   cd El-Waheb
   ```
2. Install dependencies:
   ```sh
   dotnet restore
   ```
3. Run the application:
   ```sh
   dotnet run
   ```

##  Features
 **Entity Configuration with `IEntityTypeConfiguration<T>`**
 **Repository Pattern for Data Access**
 **API Endpoints for CRUD Operations**
 **Modular and Scalable Architecture**

##  Contributing
Feel free to fork this repository and contribute by creating a pull request. 

##  License
This project is licensed under the **MIT License**.

---
 **El-Waheb – Simplifying Entity Management with Best Practices!** 

