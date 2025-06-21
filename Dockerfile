FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

COPY CedarAPI.csproj ./
RUN dotnet restore

COPY . ./
RUN dotnet publish -c Release -o /app/publish

FROM rust:1.87.0-slim-bullseye AS cedar-build
RUN cargo install cedar-policy-cli@4.4.1

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS final
WORKDIR /app

COPY --from=build /app/publish .

COPY --from=cedar-build /usr/local/cargo/bin/cedar /usr/local/bin/cedar

COPY ./configs ./configs

EXPOSE 8080
ENTRYPOINT ["dotnet", "CedarAPI.dll"]
