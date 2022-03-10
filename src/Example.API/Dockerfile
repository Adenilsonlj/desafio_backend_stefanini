#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["src/Example.API/Example.API.csproj", "src/Example.API/"]
COPY ["src/Example.Application/Example.Application.csproj", "src/Example.Application/"]
COPY ["src/Example.Infra.Data/Example.Infra.Data.csproj", "src/Example.Infra.Data/"]
COPY ["src/Example.Domain/Example.Domain.csproj", "src/Example.Domain/"]
RUN dotnet restore "src/Example.API/Example.API.csproj"
COPY . .
WORKDIR "/src/src/Example.API"
RUN dotnet build "Example.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Example.API.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Example.API.dll"]
