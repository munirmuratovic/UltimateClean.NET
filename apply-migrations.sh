#!/bin/bash

dotnet ef database update \
  --project UltimateClean.Persistence/UltimateClean.Persistence.csproj \
  --startup-project UltimateClean.Api/UltimateClean.Api.csproj
