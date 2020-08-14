#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["AKS_Workshop/AKS_Workshop.csproj", "AKS_Workshop/"]
RUN dotnet restore "AKS_Workshop/AKS_Workshop.csproj"
COPY . .
WORKDIR "/src/AKS_Workshop"
RUN dotnet build "AKS_Workshop.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "AKS_Workshop.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "AKS_Workshop.dll"]