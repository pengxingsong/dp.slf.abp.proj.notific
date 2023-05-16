FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build

WORKDIR /src
COPY ["src/DPNotific.Web.Host/DPNotific.Web.Host.csproj", "src/DPNotific.Web.Host/"]
COPY ["src/DPNotific.Web.Core/DPNotific.Web.Core.csproj", "src/DPNotific.Web.Core/"]
COPY ["src/DPNotific.Application/DPNotific.Application.csproj", "src/DPNotific.Application/"]
COPY ["src/DPNotific.Core/DPNotific.Core.csproj", "src/DPNotific.Core/"]
COPY ["src/DPNotific.EntityFrameworkCore/DPNotific.EntityFrameworkCore.csproj", "src/DPNotific.EntityFrameworkCore/"]
WORKDIR "/src/src/DPNotific.Web.Host"
RUN dotnet restore 

WORKDIR /src
COPY ["src/DPNotific.Web.Host", "src/DPNotific.Web.Host"]
COPY ["src/DPNotific.Web.Core", "src/DPNotific.Web.Core"]
COPY ["src/DPNotific.Application", "src/DPNotific.Application"]
COPY ["src/DPNotific.Core", "src/DPNotific.Core"]
COPY ["src/DPNotific.EntityFrameworkCore", "src/DPNotific.EntityFrameworkCore"]
WORKDIR "/src/src/DPNotific.Web.Host"
RUN dotnet publish -c Release -o /publish --no-restore

FROM mcr.microsoft.com/dotnet/aspnet:7.0
EXPOSE 80
WORKDIR /app
COPY --from=build /publish .
ENTRYPOINT ["dotnet", "DPNotific.Web.Host.dll"]
