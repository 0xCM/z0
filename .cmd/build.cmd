@echo off

set ZCmd=%ZDev%\.cmd
echo ZCmd:%ZCmd%

set ProjectId=machine
echo ProjectId:%ProjectId%

set SlnId=z0.%ProjectId%
echo SlnId:%SlnId%

set CmdSep=--------------------------------------------------------------------------------
set CmdLog=%ZDb%\logs\commands\command.build.log

echo %CmdSep%
echo %CmdSep% >> %CmdLog%

set SlnPath="%ZDev%\%SlnId%.sln"
echo SlnPath:%SlnPath% >> %CmdLog%

set TextLog="%ZDb%\logs\build\%SlnId%.log"

set BuildArgs=/p:Configuration=Release /p:Platform="Any CPU" -fl -flp:logfile=%TextLog%;verbosity=detailed -m:6 -graph:true
echo BuildArgs:%BuildArgs%

set BuildCmdLine=dotnet build %SlnPath% %BuildArgs%
echo BuildCmdLine:%BuildCmdLine%
echo BuildCmdLine:%BuildCmdLine% >> %CmdLog%

call %BuildCmdLine%


::call .cmd\deploy.cmd
