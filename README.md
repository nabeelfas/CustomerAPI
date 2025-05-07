# CustomerAPI
Customer API in .net core 8
dotnet add package Microsoft.EntityFrameworkCore
dotnet add package Microsoft.EntityFrameworkCore.SqlServer
dotnet add package Microsoft.EntityFrameworkCore.Design
dotnet add package Microsoft.EntityFrameworkCore.Tools

dotnet ef dbcontext scaffold "Server=your_server;Database=your_db;User Id=your_user;Password=your_password;TrustServerCertificate=True" Microsoft.EntityFrameworkCore.SqlServer -o Models --context-dir Data --context AppDbContext --force
