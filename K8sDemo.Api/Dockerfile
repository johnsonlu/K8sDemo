FROM microsoft/dotnet:2.1-aspnetcore-runtime-alpine AS base
WORKDIR /app
EXPOSE 80

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
COPY K8sDemo.Api/K8sDemo.Api.csproj K8sDemo.Api/
RUN dotnet restore K8sDemo.Api/K8sDemo.Api.csproj
COPY . .
WORKDIR /src/K8sDemo.Api
RUN dotnet build K8sDemo.Api.csproj -c Release -o /app

FROM build AS publish
RUN dotnet publish K8sDemo.Api.csproj -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "K8sDemo.Api.dll"]
