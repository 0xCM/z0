echo off

call .cmd\config.cmd

dotnet build %ProjectPath% -c Release