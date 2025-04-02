dotnet ef migrations add InitialMigration --project UltimateClean.Persistence/UltimateClean.Persistence.csproj --startup-project UltimateClean.WebApi/UltimateClean.WebApi.csproj --output-dir ./Migrations

dotnet ef database update --verbose --project UltimateClean.Persistence/UltimateClean.Persistence.csproj --startup-project UltimateClean.WebApi/UltimateClean.WebApi.csproj