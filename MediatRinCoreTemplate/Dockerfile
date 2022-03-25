#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base

FROM base AS final
WORKDIR /app/
EXPOSE 8081
ENV ASPNETCORE_URLS=http://+:8080
#COPY --from=publish /app/publish .
COPY . .
EXPOSE 8080
ENTRYPOINT ["dotnet", "MediatRinCoreTemplate.dll"]
