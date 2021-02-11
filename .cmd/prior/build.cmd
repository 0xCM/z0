@echo off

set ZCmd=%ZDev%\.cmd
set ProjectId=machine
set SlnId=z0.machine

call %ZCmd%\build-config.cmd
echo %CmdSep%
echo %CmdSep% >> %CmdLog%

set TextLog="%ZDb%\logs\build\z0.%ProjectId%.log"

set BuildArgs=/p:Configuration=Release /p:Platform="Any CPU" -fl -flp:logfile=%TextLog%;verbosity=detailed -m:6 -graph:true
echo BuildArgs:%BuildArgs%

set BuildCmdLine=dotnet build %SlnPath% %BuildArgs%
echo BuildCmdLine:%BuildCmdLine%
echo BuildCmdLine:%BuildCmdLine% >> %CmdLog%

call %BuildCmdLine%

call %ZCmd%\deploy.cmd
