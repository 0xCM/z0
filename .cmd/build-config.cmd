@echo off

echo ProjectId:%ProjectId%
echo SlnId:%SlnId%

set SlnPath="%ZDev%\%SlnId%.sln"
echo SlnPath:%SlnPath%

set ProjectPath="%ZDev%\src\%ProjectId%\z0.%ProjectId%.csproj"
echo ProjectPath:%ProjectPath%

set BuildLogPath="%ZDb%\logs\build\z0.%ProjectId%.log"
echo BuildLogPath:%BuildLogPath%