@echo off

set ZCmd=%ZDev%\.cmd
echo ZCmd:%ZCmd%

set CmdSep="--------------------------------------------------------------------------------"
set CmdLog=%ZDb%\logs\commands\z0.%ProjectId%.build.log
echo %CmdSep% >> %CmdLog%

set ProjectPath="%ZDev%\src\%ProjectId%\z0.%ProjectId%.csproj"
echo ProjectPath:%ProjectPath% >> %CmdLog%

set TextLog="%ZDb%\logs\build\z0.%ProjectId%.log"

set BuildArgs=/p:Configuration=Release /p:Platform="Any CPU" -fl -flp:logfile=%TextLog%;verbosity=detailed -m:6 -graph:true
echo BuildArgs:%BuildArgs%

set CmdExec=dotnet build %ProjectPath% %BuildArgs%
echo CmdExec:%CmdExec% >> %CmdLog%

echo on
call %CmdExec%
call %ZCmd%\deploy-lib.cmd