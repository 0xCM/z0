echo off

set ProjectId=konst
echo ProjectId:%ProjectId%

set ConfigPath=%ZDev%\src\%ProjectId%\.cmd\config.cmd
echo ConfigPath:%ConfigPath%

call %ConfigPath%

dotnet build %ProjectPath% -c Release