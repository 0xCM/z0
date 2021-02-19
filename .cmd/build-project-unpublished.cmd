echo off

set ConfigPath=%ZDev%\src\%ProjectId%\.cmd\config.cmd
echo ConfigPath:%ConfigPath%

call %ConfigPath%

dotnet build %ProjectPath% -c Release