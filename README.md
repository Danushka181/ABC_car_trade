# ABC Car Trade

ABC Car Trade is a Windows Forms application for managing a car trading business. It appears to cover both admin and user workflows for handling cars, car parts, customers, orders, and reports.

## Overview

This project is built in C# on .NET Framework 4.7.2 and uses a dashboard-based desktop interface. The application launches from a welcome screen and routes users to login or registration. After authentication, the dashboard loads different child screens inside a main panel so the user can switch between modules without opening separate windows.

## Main Capabilities

### Authentication and session management
- Login screen for existing users
- Registration screen for new users
- Session tracking through `SessionManager`
- Logout functionality

### Admin management
- Add new cars
- Edit existing cars
- Add new car parts
- Edit car parts
- Manage customers
- Manage orders
- View reports

### User-facing features
- Browse available cars
- Browse available car parts
- Place car or part orders
- Check order status
- Use a dedicated user dashboard

### Dashboard navigation
- Dashboard loads child forms into a single main panel
- Menu buttons switch between Cars, Car Parts, Customers, Orders, and Reports
- Initial dashboard load opens the cars view by default

## Project Structure

Some important files and folders in the project include:

- `Program.cs` — application entry point
- `WelcomeScreen.cs` / `MainForm` — startup landing screen
- `LoginForm.cs` — sign-in screen
- `RegisterForm.cs` — user registration screen
- `DashBoard.cs` — main navigation shell
- `ChildCars.cs` — cars management view
- `ChildCarParts.cs` — car parts management view
- `ChildCustomers.cs` — customer management view
- `ChildOrders.cs` — order management view
- `ReportsChild.cs` — reporting view
- `User/` — user-side forms and reusable controls
- `DatabaseConnection.cs` — database connection helper
- `SessionManager.cs` — session state helper

## UI Components

The solution includes several forms and reusable controls such as:

- `AddNewCar`
- `EditCarForm`
- `AddNewPartAdmin`
- `EditCarPartAdmin`
- `CarsList`
- `CarListItem`
- `CarPartListItem`
- `OrderItem`
- `OrderCars`
- `OrderPart`
- `UserCars`
- `UserCarParts`
- `UserDashboard`
- `UserOrderStatus`

## Technology Stack

- C#
- Windows Forms
- .NET Framework 4.7.2
- MySQL Connector/NET (`MySql.Data`)

## Setup

To open and run the project:

1. Open `ABC_car_trade.sln` in Visual Studio.
2. Make sure the .NET Framework 4.7.2 developer pack is installed.
3. Install or configure MySQL Connector/NET 8.3.0 or a compatible version.
4. Update database connection settings if needed.
5. Build and run the solution.

## Notes

- The project includes multiple `.resx` resource files and image assets for the UI.
- The repository is licensed under the MIT License.

