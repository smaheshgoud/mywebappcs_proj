# build.ps1

# Clean
dotnet clean

# Restore dependencies
dotnet restore

# Build
dotnet build

# Test
dotnet test test/MyWebApi.Tests
