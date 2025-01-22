FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["ToDoList.csproj", "./"]
RUN dotnet restore "ToDoList.csproj"
COPY . .
RUN dotnet build "ToDoList.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ToDoList.csproj" -c Release -o /app/publish
RUN chmod -R 777 /app/publish
RUN dotnet ef database update --project ToDoList.csproj --startup-project ToDoList.csproj -c TodoList.Contexts.AppDbContext || echo "Database update failed with exit code $?"

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ToDoList.dll"]