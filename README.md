# Pre req: 
Install .net 6 (.net 6 cli)
Install node.js, npm [optional]
Gitbash
Sourcetree or smartgit
Install Visual Studio Code with below extenstions [some are optional]

    c#
    c# extensions
    nuget gallery
    material icon theme
    Bracket Pair Colorizer

via nuget
>asset ( generate .net asset for build and debug)
> for Swagger dev interface
SwashBuckle.AspNetCore.MicrosoftExtensions 
Swashbuckle.AspNetCore.SwaggerGen  
Swashbuckle.AspNetCore.SwaggerUI  


# setup proj VSC
Autosave
hide bin or other unwanted folder

# dotnet cmds (gitbash)
$dotnet
$dotnet -h
$dotnet new -h
$dotnet new -l

# new proj setup - webapp
$cd [projects location dir]
$mkdir dotnet6projectname
$cd dotnet6projectname
$dotnet new sln
$dotnet new [templatename like web/webapp/webapi/angular/mvc/console] -o APP
$dotnet sln add APP
$dotnet new gitignore

# run dotnet project
-open project is VSC
-open terminal
-cd into APP directory of project
$dotnet run
* click on localhost url in console to see application in browser, if page is not loading ( might need to add path like /weatherforecast for some templates like webapi, others work directly) port can be any available unless you setup/update in APP\Properties\launchSettings.json
$dotnet watch run
- cd into client dir to run angular project with ng serve

# git repo - setup empty repo 
git init
git add README.md
git commit -m "first commit"
git branch -M main
git remote add origin https://github.com/xxxx/[reponame].git
git push -u origin main


# migrations in visual studio code

<PackageReference Include="Microsoft.EntityFrameworkCore" Version="6.0.1" />
<PackageReference Include="Microsoft.EntityFrameworkCore.Sqlite" Version="6.0.1" />
<PackageReference Include="Microsoft.EntityFrameworkCore.SqlServer" Version="6.0.1" />
<PackageReference Include="Microsoft.EntityFrameworkCore.Tools" Version="6.0.1">

$dotnet tool install --global dotnet-ef

#verify via dotnet ef

#run below (make sure app is not running via dotnet watch run or dotnet run)
$dotnet ef migrations add migration-name
$dotnet ef database update
$dotnet ef migrations remove

$ dotnet ef migrations add InitialCreate --context MvcMovieContext
$ dotnet ef database update --context MvcMovieContext

dotnet ef migrations add AddCategory --context ApplicationDbContext --output-dir Migrations/SqlServerMigrations
dotnet ef migrations add AddCategory --context ApplicationDbContextSqlite --output-dir Migrations/SqliteMigrations
dotnet ef database update --context ApplicationDbContext
dotnet ef database update --context ApplicationDbContextSqlite


Package Microsoft.AspNetCore.Mvc.Razor.RuntimeCompilation
 

scaffolded Razor Pages in ASP.NET Core
https://docs.microsoft.com/en-us/aspnet/core/tutorials/razor-pages/model?view=aspnetcore-6.0&tabs=visual-studio-code

# Add utility classlib project in same solution
 dotnet new classlib -o APP.Utility
 dotnet sln add APP.Utility

 Add SD - static detail static class
 Add EmailSender class : IEmailSender

 Add package Microsoft.AspNetCore.Identity.UI.Services and import 
 Implement Interface...


Google smtp settings: turn on less secure access from account security manager