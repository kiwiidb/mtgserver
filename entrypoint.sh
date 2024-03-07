#!/bin/sh

dotnet ef database upgrade
dotnet /app/MtgServer.dll