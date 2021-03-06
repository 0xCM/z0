@echo off

set ProjectId=libs
set SlnId=z0.libs

set SlnPath="%ZDev%\src\%ProjectId%\%SlnId%.sln"
echo SlnPath:%SlnPath%

set BuildLogPath="%ZDb%\logs\build\z0.%ProjectId%.log"
echo BuildLogPath:%BuildLogPath%

set BuildArgs=/p:Configuration=Release /p:Platform="Any CPU" -fl -flp:logfile=%BuildLogPath%;verbosity=detailed -m:6 -graph:true
echo BuildArgs:%BuildArgs%

set BuildCmdLine=dotnet build %SlnPath% %BuildArgs%
echo BuildCmdLine:%BuildCmdLine%
