echo off
set ProjectId=symbolic
set TestProject=%ZDev%\test\%ProjectId%\z0.%ProjectId%.test.csproj
set RunCmd=dotnet run %TestProject%

echo on
call %RunCmd%
