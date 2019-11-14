FROM mcr.microsoft.com/dotnet/core/aspnet:3.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:3.0 AS build
WORKDIR /src
COPY ["ConferenceManager/ConferenceManager.csproj", "ConferenceManager/"]

RUN dotnet restore "ConferenceManager/ConferenceManager.csproj"
COPY . .
WORKDIR "/src/ConferenceManager"
RUN dotnet build "ConferenceManager.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ConferenceManager.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ConferenceManager.dll"]