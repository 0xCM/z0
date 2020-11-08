echo off

set ProjectId=asm
echo ProjectId:%ProjectId%

call .cmd\config.cmd

dotnet build %ProjectPath% -c Release