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
- Nuget: Microsoft.AspNetCore.Authentication.JwtBearer

(Lookup Secret Store with <UserSecretsId>)
- Add Startup:  app.UseAuthentication();
            app.UseAuthorization();
- Add to <Project>.csproj:  <UserSecretsId>--- secret guid ---</UserSecretsId>
- dotnet user-secrets set "AppSettings:Token" "26f
bbc1f-58b1-421a-a76f-c8cb8ac7de60"

Create Sqlite Database:
- dotnet ef migrations add <update name>
- dotnet ef database update

Note:
- Dotnetcore expects Application/JSON type POST

