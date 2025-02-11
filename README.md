# El-Waheb

##  Overview
**El-Waheb** is an application designed to facilitate and manage blood donation requests, donor information, and emergency blood availability. Built using ASP.NET Core and Entity Framework Core, the platform ensures a structured, scalable, and efficient system for connecting blood donors with recipients in need.

Key Features
 Blood Donation Requests: Users can create and manage blood donation requests based on urgency and location.
 Donor Management: A structured database for storing donor details, blood types, and availability.
 Location-Based Search: Helps recipients find the nearest donors or blood banks.
 Notifications System: Sends alerts to registered donors when a matching blood request is made.
 Secure & Scalable Architecture: Uses modern development practices to ensure high performance and data integrity.

El-Waheb aims to make blood donation easier, faster, and more accessible, ultimately saving lives through technology.

**El-Waheb** is an application built using **ASP.NET Core** and **Entity Framework Core**. The project follows the **repository pattern** and **unit of work pattern**  to ensure scalability and maintainability.

##  Tech Stack
- **Backend:** ASP.NET Core Web API
- **ORM:** Entity Framework Core
- **Database:** SQL Server
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
   ├── Entities
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

