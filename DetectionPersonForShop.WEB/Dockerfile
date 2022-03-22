#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["DetectionPersonForShop.WEB/DetectionPersonForShop.WEB.csproj", "DetectionPersonForShop.WEB/"]
RUN dotnet restore "DetectionPersonForShop.WEB/DetectionPersonForShop.WEB.csproj"
COPY . .
WORKDIR "/src/DetectionPersonForShop.WEB"
RUN dotnet build "DetectionPersonForShop.WEB.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "DetectionPersonForShop.WEB.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "DetectionPersonForShop.WEB.dll"]