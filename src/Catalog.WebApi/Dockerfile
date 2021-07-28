#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["src/Catalog.WebApi/Catalog.WebApi.csproj", "src/Catalog.WebApi/"]
COPY ["src/Catalog.Services/Catalog.Services.csproj", "src/Catalog.Services/"]
COPY ["src/Catalog.Repositories/Catalog.Repositories.csproj", "src/Catalog.Repositories/"]
COPY ["src/Catalog.Repositories.Abstractions/Catalog.Repositories.Abstractions.csproj", "src/Catalog.Repositories.Abstractions/"]
COPY ["src/Catalog.Entities/Catalog.Entities.csproj", "src/Catalog.Entities/"]
COPY ["src/Catalog.Entities.Abstractions/Catalog.Entities.Abstractions.csproj", "src/Catalog.Entities.Abstractions/"]
RUN dotnet restore "src/Catalog.WebApi/Catalog.WebApi.csproj"
COPY . .
WORKDIR "/src/src/Catalog.WebApi"
RUN dotnet build "Catalog.WebApi.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Catalog.WebApi.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Catalog.WebApi.dll"]