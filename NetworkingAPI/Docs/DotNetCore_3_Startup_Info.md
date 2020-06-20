dotnet core 3 setup
- Nuget: Microsoft.EntityFrameworkCore
- Nuget: Microsoft.EntityFrameworkCore.Sqlite
- Terminal: dotnet tool install --global dotnet-ef
  - Migration Tool
- Nuget: Microsoft.EntityFrameworkCore.Design
  - Needed for Migration Tool

Create Sqlite Database:
- dotnet ef migrations add <update name>
- dotnet ef database update

  "NetworkingAPI": {
      "commandName": "Project",
      "launchBrowser": true,
      "launchUrl": "api/values",
      "applicationUrl": "http://localhost:5000",
      "environmentVariables": {
        "ASPNETCORE_ENVIRONMENT": "Development"
      }
    },