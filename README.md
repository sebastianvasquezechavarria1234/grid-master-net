# GridMaster .NET 🚀

**GridMaster .NET** is a modern, high-performance CRUD application built with **ASP.NET Core MVC 8**, designed to showcase seamless integration with **DataTables.net** for advanced data management.

## 🌟 Features

- **Full CRUD Operations**: Create, Read, Update, and Delete records with ease.
- **DataTables Integration**: High-speed data interaction with server-side feel using AJAX.
- **Responsive UI**: Built with **Bootstrap 5** and **FontAwesome 6** for a premium, mobile-friendly look.
- **Asynchronous Processing**: Uses AJAX for deletions and data fetching to provide a smooth user experience without page reloads.
- **Entity Framework Core**: Robust data access layer using SQL Server.
- **Client-Side Validation**: Real-time form validation using jQuery Validation.

## 🛠️ Tech Stack

- **Backend**: ASP.NET Core MVC 8.0
- **ORM**: Entity Framework Core
- **Database**: SQL Server (LocalDB)
- **Frontend**: Bootstrap 5, jQuery, FontAwesome
- **Data Grid**: DataTables.net (Bootstrap 5 theme)

## 🚀 Getting Started

### Prerequisites

- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- [Visual Studio 2022](https://visualstudio.microsoft.com/) (or VS Code)
- SQL Server LocalDB (installed with Visual Studio)

### Installation

1. **Clone the repository**:
   ```bash
   git clone https://github.com/sebastianvasquezechavarria1234/grid-master-net.git
   ```

2. **Navigate to the project folder**:
   ```bash
   cd GridMaster-NET
   ```

3. **Update Database**:
   Open the **Package Manager Console** in Visual Studio and run:
   ```powershell
   Add-Migration InitialCreate
   Update-Database
   ```

4. **Run the application**:
   Press `F5` in Visual Studio or run via terminal:
   ```bash
   dotnet run
   ```

## 📸 Preview

The application features a dark-themed professional navbar and a clean, striped data table with action buttons for managing users efficiently.

---
Developed by [Sebastian Vasquez](https://github.com/sebastianvasquezechavarria1234)
