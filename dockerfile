#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["smart-meter.api/smart-meter.api.csproj", "smart-meter.api/"]
COPY ["smart-meter.application/smart-meter.application.csproj", "smart-meter.application/"]
COPY ["smart-meter.domain/smart-meter.domain.csproj", "smart-meter.domain/"]
COPY ["smart-meter.infrasturcture/smart-meter.infrasturcture.csproj", "smart-meter.infrasturcture/"]
RUN dotnet restore "smart-meter.api/smart-meter.api.csproj"
COPY . .
WORKDIR "/src/smart-meter.api"
RUN dotnet build "smart-meter.api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "smart-meter.api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "smart-meter.api.dll"]