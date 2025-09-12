# Stage 1: Build
FROM mcr.microsoft.com/dotnet/sdk:9.0-windowsservercore-ltsc2022 AS build
WORKDIR /src

# Copy solution and project files


COPY UI/*.sln ./
COPY UI/UI.csproj ./
COPY DataAccess/DataAccess.csproj ../DataAccess/
COPY Business/Business.csproj ../Business/


# Restore dependencies
RUN dotnet restore

# Copy all code
COPY . .

# Build and publish the UI project (it includes references to Business & DataAccess)
RUN dotnet publish UI/UI.csproj -c Release -o /app/publish

# Stage 2: Runtime
FROM mcr.microsoft.com/dotnet/aspnet:9.0-windowsservercore-ltsc2022 AS runtime
WORKDIR /app

# Copy published output from build stage
COPY --from=build /app/publish .

# Expose the port your app listens on
EXPOSE 80

# Run the app
ENTRYPOINT ["dotnet", "UI.dll"]
