dotnet tool install --global dotnet-ef
dotnet ef migrations add InitialCreate -p ../
dotnet ef database update -p ../