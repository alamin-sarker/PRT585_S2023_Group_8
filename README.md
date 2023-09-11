# Installation Guide For VSCode
1. Changed the connection string to the local server in `WebAPIApp/appsettings.json`.
2. Build the application in VS Code.
3. Downloaded the required .NET SDK 5.0 version from [https://dotnet.microsoft.com/en-us/download/dotnet/5.0](https://dotnet.microsoft.com/en-us/download/dotnet/5.0).
4. Copy the `appsettings.json` file from `WebAPIApp` to `DAL`.
5. Run the following commands.

```
   dotnet build
   dotnet watch --project .\WebAPIApp\
```

6. Run the migrations

```
dotnet ef database update
```
# PRT585_S2023_Group_8
