# Used nuget packages

Microsoft.AspNetCore.Diagnostics.EntityFrameworkCore 6.0.5\
Microsoft.AspNetCore.Identity.EntityFrameworkCore 6.0.5\
Microsoft.AspNetCore.Identity.UI 6.0.5\
Microsoft.EntityFrameworkCore.SqlServer 6.0.5\
Microsoft.EntityFrameworkCore.Tools 6.0.5\
Microsoft.VisualStudio.Web.CodeGeneration.Design 6.0.5\
Swashbuckle.AspNetCore 6.03

# Database generating script

The script generating database is located in Migrations file.

# Configuration
1. Run visual studio 2022
2. Click on 'Clone a repository' tab
3. Paste link https://github.com/Amooxiz/ThingsToReturn.git into repository location tab
4. Clone the project
5. Open nuget package console
6. Type command: update-database
7. Populate Category table in your database before running your application
8. You are ready to go
