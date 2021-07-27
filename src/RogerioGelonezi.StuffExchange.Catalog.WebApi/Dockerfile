#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["src/RogerioGelonezi.StuffExchange.WebApi/RogerioGelonezi.StuffExchange.WebApi.csproj", "src/RogerioGelonezi.StuffExchange.WebApi/"]
RUN dotnet restore "src/RogerioGelonezi.StuffExchange.WebApi/RogerioGelonezi.StuffExchange.WebApi.csproj"
COPY . .
WORKDIR "/src/src/RogerioGelonezi.StuffExchange.WebApi"
RUN dotnet build "RogerioGelonezi.StuffExchange.WebApi.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "RogerioGelonezi.StuffExchange.WebApi.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "RogerioGelonezi.StuffExchange.WebApi.dll"]