# FoodMenuCSharp

A C# Windows Forms food menu application built with Visual Studio and Microsoft SQL Server LocalDB. The project demonstrates a desktop application with account management, food selection, and order-related screens.

## Overview

FoodMenuCSharp is a desktop application developed using C# and Windows Forms. It combines a graphical user interface with a local SQL Server database for account registration and login.

Users can register an account, sign in, view account-related information, browse food choices, select menu items, and navigate through the application's order-related screens.

## Features

- **User registration:** Creates an account using a username and password.
- **User login:** Checks account credentials against the database.
- **Account interface:** Provides screens for viewing account-related information.
- **Food menu:** Displays food and drink choices using selectable menu items.
- **Item selection:** Lets users select or deselect menu items and view the current selection.
- **Order-related screen:** Provides a screen for displaying selected items.
- **Navigation controls:** Supports navigation between application screens, returning to previous screens, logging out, and exiting.
- **Database connectivity:** Uses SQL Server LocalDB to store account information.

## Technologies Used

- C#
- Windows Forms (WinForms)
- Visual Studio
- Microsoft SQL Server LocalDB
- SQL Server Management Studio (SSMS)
- ADO.NET (`SqlConnection`, `SqlCommand`, and `SqlDataAdapter`)

## Requirements

- Windows
- Visual Studio with the .NET desktop development workload
- A compatible .NET Framework or .NET runtime matching the project configuration
- SQL Server LocalDB
- SQL Server Management Studio (optional, but useful for inspecting and managing the database)

## Database Setup

The application uses a local SQL Server database file named `Koshigaya.mdf`.

### Setup instructions

1. Install Visual Studio and the required desktop development components.
2. Install SQL Server LocalDB.
3. Open SQL Server Management Studio if you want to inspect or manage the database.
4. Create or attach the required database file.
5. Ensure the database contains the `admin` table with the columns expected by the application, including `username`, `password`, and `date_created`.
6. Update the database connection strings in the source code to match your local database location.
7. Build and run the application in Visual Studio.

**Important:** The current source code references a database file under a specific Windows user's Documents folder. You must update this path if the file is located elsewhere. The required database file and Visual Studio project configuration should also be checked before running the application on another computer.

## How to Run

1. Clone or download this repository.
2. Open the project or solution in Visual Studio, if included.
3. Verify the database setup and connection strings.
4. Build the project using **Build → Build Solution**.
5. Start the application using **Start** or **F5**.
6. Register an account or sign in using an existing account in the database.
7. Navigate through the available menu and account screens.

## Project Files

The repository includes the following C# source files:

| File | Purpose |
|---|---|
| `AccountCenter.cs` | Login and account-entry interface logic |
| `Register.cs` | Account registration logic |
| `MainMenu.cs` | Main menu navigation |
| `FoodMenu.cs` | Food selection and selected-item display |
| `OrderPlaced.cs` | Order-related screen and navigation |
| `ViewMyAccount.cs` | Account information screen |
| `FoodMenuBackup.cs` | Backup version of food menu code |

Windows Forms designer files and project configuration may also be needed to build the application. Check that the complete Visual Studio project files are present in your local copy.

## How It Works

1. The user opens the application.
2. The login screen checks the supplied credentials against the local database.
3. New users can access the registration screen to create an account.
4. After logging in, the user can navigate to the available application screens.
5. In the food menu, the user selects items using checkboxes.
6. The application displays the selected items in a list.
7. The user can navigate to the order-related screen or return to other parts of the application.

## Learning Objectives

This project demonstrates:

- C# programming fundamentals
- Windows Forms event handling
- GUI design and navigation
- SQL Server database connectivity
- CRUD-related database operations for account registration and lookup
- ADO.NET commands and data adapters
- Handling user input and displaying message boxes

## Known Limitations and Security Considerations

- The database connection string contains a machine-specific file path.
- Account passwords appear to be stored and compared as plain text. A production application should use a secure password-hashing approach.
- The registration code builds its username-check query by concatenating user input, which should be replaced with a parameterized query.
- The selected menu items are maintained in application memory; the repository's order-related screen should not be assumed to persist orders to the database.
- The application requires a compatible local database setup.
- The project does not document a complete deployment or installation process.

## Author

**Ichiro Yamazaki**

## License

No license has been specified for this repository.
