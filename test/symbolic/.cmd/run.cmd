echo off

call .cmd\config.cmd
dotnet run %ProjectPath% -c Release