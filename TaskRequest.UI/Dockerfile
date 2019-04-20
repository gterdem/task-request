FROM mcr.microsoft.com/dotnet/core/aspnet:2.2-stretch-slim AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:2.2-stretch AS build
WORKDIR /src
COPY ["TaskRequest.UI/TaskRequest.UI.csproj", "TaskRequest.UI/"]
RUN dotnet restore "TaskRequest.UI/TaskRequest.UI.csproj"
COPY . .
WORKDIR "/src/TaskRequest.UI"
RUN dotnet build "TaskRequest.UI.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "TaskRequest.UI.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "TaskRequest.UI.dll"]