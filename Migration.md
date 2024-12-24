```
cd C:\Users\KadirYilmaz\source\repos\BlazorTodoApp\Persistence

tool install dotnet-ef -g

dotnet ef migrations add init --help

Inside of your Persistence project, run the following command:
dotnet ef migrations add init -s ..\Api\Api.csproj

then, run the following command to update the database:
dotnet ef database update -s ..\Api\Api.csproj

```