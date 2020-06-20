dotnet core 3 setup
- Nuget: Microsoft.EntityFrameworkCore
- Nuget: Microsoft.EntityFrameworkCore.Sqlite
- Terminal: dotnet tool install --global dotnet-ef
  - Migration Tool
- Nuget: Microsoft.EntityFrameworkCore.Design
  - Needed for Migration Tool

Security
- Nuget: Microsoft.IdentityModel.
- Nuget: System.IdentityModel.Tokens.Jwt

Create Sqlite Database:
- dotnet ef migrations add <update name>
- dotnet ef database update
