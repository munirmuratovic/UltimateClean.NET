#!/bin/bash

MIGRATION_NAME=$1

if [ -z "$MIGRATION_NAME" ]; then
  echo "❌ Please provide a migration name!"
  exit 1
fi

dotnet ef migrations add "$MIGRATION_NAME" \
  --project UltimateClean.Persistence/UltimateClean.Persistence.csproj \
  --startup-project UltimateClean.WebApi/UltimateClean.WebApi.csproj \
  --output-dir Migrations
