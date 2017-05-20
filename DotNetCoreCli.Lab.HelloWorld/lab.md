# Not your daddy's DotNet workshop

Run the following in the console:

Check your version:
``` 
dotnet --version
```

Create new console project
``` 
dotnet new console
```

When running the Core 2.0 CLI, it will _automatically_ execute a package restore. Versions before 2.0 _do not_ do this.
To manually restore packages, run:
```
dotnet restore
```

Build the project:
```
dotnet build
```

Build and Run the app
```
dotnet run
```

Build to output
```
dotnet build --output MyAppje
```

Run the assembly
```
cd MyAppje
dotnet ASSEMBLYNAME.dll
```
