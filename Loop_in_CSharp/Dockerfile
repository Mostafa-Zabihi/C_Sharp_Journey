FROM mcr.microsoft.com/dotnet/runtime:10.0-nanoserver-ltsc2022 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:10.0-nanoserver-ltsc2022 AS build
ARG configuration=Release
WORKDIR /src
COPY ["Loop_in_CSharp/Loop_in_CSharp.csproj", "Loop_in_CSharp/"]
RUN dotnet restore "Loop_in_CSharp\Loop_in_CSharp.csproj"
COPY . .
WORKDIR "/src/Loop_in_CSharp"
RUN dotnet build "Loop_in_CSharp.csproj" -c $configuration -o /app/build

FROM build AS publish
ARG configuration=Release
RUN dotnet publish "Loop_in_CSharp.csproj" -c $configuration -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Loop_in_CSharp.dll"]
