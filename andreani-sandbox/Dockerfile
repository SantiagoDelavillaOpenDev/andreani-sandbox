# Etapa de compilación
FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build-env
WORKDIR /app

# Copiar y restaurar las dependencias
COPY *.csproj ./
RUN dotnet restore

# Copiar el resto de los archivos y compilar la aplicación
COPY . ./
RUN dotnet build -c Release -o out

# Etapa de publicación
FROM build-env AS publish
RUN dotnet publish -c Release -o /app/out

# Etapa de servicio
FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS service
WORKDIR /app
COPY --from=publish /app/out .

# Establecer el punto de entrada del servicio
ENTRYPOINT ["dotnet", "andreani-sandbox.dll"]
