@echo off


echo ProjectId:%ProjectId%
echo SlnId:%SlnId%

set CmdSep=--------------------------------------------------------------------------------
set CmdLog=%ZDb%\logs\commands\command.build.log

set SlnPath="%ZDev%\%SlnId%.sln"
echo SlnPath:%SlnPath% >> %CmdLog%

set ProjectPath="%ZDev%\src\%ProjectId%\z0.%ProjectId%.csproj"
echo ProjectPath:%ProjectPath% >> %CmdLog%

set BuildLogPath="%ZDb%\logs\build\z0.%ProjectId%.log"
echo BuildLogPath:%BuildLogPath%
