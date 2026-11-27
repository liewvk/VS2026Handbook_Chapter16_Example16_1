# VS2026 Handbook — Chapter 16 Example 16.1

A C# console application for Visual Studio 2026 Chapter 16, demonstrating a basic SQL Server connection and parameterized query with `Microsoft.Data.SqlClient`.

## Requirements

- .NET 10 SDK
- SQL Server LocalDB
- Visual Studio 2026 or another compatible C# development environment

## Run the application

```bash
dotnet restore
dotnet run
```

The application connects to `(localdb)\MSSQLLocalDB`, opens the `master` database, and executes:

```sql
SELECT @value + 10
```

It supplies `32` as the `@value` parameter and prints `42` when SQL Server LocalDB is available. If LocalDB is unavailable or a SQL Server error occurs, the application prints an error message instead.

## Key files

- `Program.cs` — Creates the SQL connection, executes the parameterized query, and handles SQL exceptions.
- `VS2026Handbook_Chapter16_Example16_1.csproj` — Defines the .NET 10 console project and `Microsoft.Data.SqlClient` dependency.
- `VS2026Handbook_Chapter16_Example16_1.slnx` — Visual Studio solution file.
