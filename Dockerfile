FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
WORKDIR /upprpo_lab1
COPY . .
RUN dotnet restore
RUN dotnet publish -c Release -o /application

FROM build AS runtime
WORKDIR /application
COPY --from=build /application .
ENTRYPOINT ["dotnet", "upprpo_lab1.dll"]