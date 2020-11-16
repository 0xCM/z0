echo off

set ProjectName=tools
echo ProjectName:%ProjectName%

call .cmd\config.cmd

dotnet build %ProjectPath% -c Release