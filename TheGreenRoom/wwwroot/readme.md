dotnet new webapp -o TheGreenRoom
code -r TheGreenRoom
dotnet dev-cert shttps --trust

##adding a branch to github
dotnet watch run
crtl+c
dotnet --list-sdks
dotnet new page --name Flower --namespace RazorPagesFlower.Pages --output Pages
dotnet tool install --global dotnet-ef
dotnet tool install --global dotnet-aspnet-codegenerator
dotnet add package Microsoft.EntityFrameworkCore.Design --version 5.0.13
dotnet add package Microsoft.EntityFrameworkCore.Sqlite --version 5.0.13
dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design --version 5.0.2
dotnet add package Microsoft.EntityFrameworkCore.SqlServer --version 5.0.13
dotnet-aspnet-codegenerator razorpage -m Flower -dc RazorPagesFlowerContext -udl -outDir Pages/Flowers --referenceScriptLibraries -sqlite
dotnet ef migrations add InitialCreate
dotnet ef database update
dotnet watch run
ctrl+c