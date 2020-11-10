echo off

set ProjectId=external
echo ProjectId:%ProjectId%

call .cmd\config.cmd

dotnet build %ProjectPath% -c Release