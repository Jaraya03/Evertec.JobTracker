# 📋 Evertec Job Tracker

> Technical exercise for Senior Developer position - Job tracking and status management system

[![.NET](https://img.shields.io/badge/.NET-8.0-512BD4?logo=dotnet)](https://dotnet.microsoft.com/)
[![Blazor](https://img.shields.io/badge/Blazor-Server-512BD4?logo=blazor)](https://blazor.net/)
[![SQL Server](https://img.shields.io/badge/SQL%20Server-2019+-CC2927?logo=microsoftsqlserver)](https://www.microsoft.com/sql-server)
[![License](https://img.shields.io/badge/License-MIT-green.svg)](LICENSE)

### ✨ Key Features

- **Job Management**: Create, view, and track mail production jobs
- **Status Workflow**: Automated progression through predefined status stages
  - Received → Printing → Inserting → Mailed → Delivered
- **Exception Handling**: Report and track job exceptions with detailed notes
- **Status History**: Complete audit trail of all status changes
- **Real-time Updates**: Interactive UI with live data updates
- **Filtering & Search**: Filter jobs by status with instant results
- **Responsive Design**: Modern, gradient-based UI with smooth animations

## 🏗️ Architecture

### Technology Stack

- **Frontend**: Blazor Server
- **Backend**: ASP.NET Core 8.0
- **Database**: SQL Server with Entity Framework Core
- **UI Framework**: Bootstrap 5 with custom CSS
- **Pattern**: Repository Pattern with Dependency Injection

### Project Structure

```
Evertec.JobTracker/
├── Components/
│   ├── Pages/          # Razor pages (Index(Home), JobDetail, CreateJob)
│   ├── Layout/         # Layout components 
│   └── _Imports.razor
├── Data/
│   ├── Model/          # Entity models
│   ├── Services/       # Business logic layer
│   └── AppDbContext.cs # EF Core context
├── Migrations/         # Database migrations
├── wwwroot/           # Static assets
└── Program.cs         # Application entry point
```

## 🚀 Getting Started

### Prerequisites

- [.NET 8.0 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- [SQL Server 2019+](https://www.microsoft.com/sql-server) (or SQL Server Express)
- [Visual Studio 2022](https://visualstudio.microsoft.com/) or [VS Code](https://code.visualstudio.com/)

### Installation

1. **Clone the repository**
   ```bash
   git clone https://github.com/Jaraya03/Evertec.JobTracker.git
   cd Evertec.JobTracker
   ```
   

2. **Create tables in DB**

    Open the Script.ipynb file and run all the scripts in SQL Manager Studio. At the end of the file are some entries to feed 2 of the 3 tables.
   
4. **Configure the database connection**
   
   Update `appsettings.json` with your SQL Server connection string:
   ```json
   {
     "ConnectionStrings": {
       "DefaultConnection": "Server=localhost;Database=JobTrackerDB;Trusted_Connection=True;TrustServerCertificate=True;"
     }
   }
   ```

5. **Run the application**

    In Visual Studio 2022, click in play button

## 💻 Usage

### Creating a New Job

1. Click **"+ New Job"** button on the home page
2. Fill in the job details:
   - Client Name
   - Job Name
   - Quantity
   - SLA Mail By Date
   - Carrier (USPS, FedEx, UPS, DHL)
3. Click **"Create Job"**

### Managing Job Status

1. Click **"View Details"** on any job
2. Use **"Next Status →"** to advance the job through the workflow
3. Use **"Exception"** button to report issues

### Filtering Jobs

- Use the **Status** dropdown on the home page
- Options: All, Received, Printing, Inserting, Mailed, Delivered
- Real-time row count updates

### Viewing History

- All status changes are automatically logged
- View complete history on the job detail page
- Includes timestamps and notes for exceptions

## Known Limitations

Terminal states (cannot advance):
- **Delivered**: Successful completion
- **Exception**: Job encountered an issue

### Carriers

Supported carriers(Hardcoded):
- USPS
- FedEx
- UPS
- DHL

## 👤 Author

**Jose Araya**
- GitHub: [@Jaraya03](https://github.com/Jaraya03)
- Project: [Evertec.JobTracker](https://github.com/Jaraya03/Evertec.JobTracker)

**Note**: This project was created as a technical interview for a Senior Developer position at Evertec.
