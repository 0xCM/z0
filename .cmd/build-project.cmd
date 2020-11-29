@echo off

set ZCmd=%ZDev%\.cmd
echo ZCmd:%ZCmd%

set CmdSep="--------------------------------------------------------------------------------"
set CmdLog=%ZDb%\logs\commands\z0.%ProjectId%.build.log
echo %CmdSep% >> %CmdLog%

set ProjectPath="%ZDev%\src\%ProjectId%\z0.%ProjectId%.csproj"
echo SlnPath:%SlnPath% >> %CmdLog%

set TextLog="%ZDb%\logs\build\z0.%ProjectId%.log"

set CmdExec=dotnet build %ProjectPath% /p:Configuration=Release /p:Platform="Any CPU" -fl -flp:logfile=%TextLog%;verbosity=detailed -m:6 -graph:true
echo CmdExec:%CmdExec% >> %CmdLog%

echo on
call %CmdExec%

call %ZCmd%\deploy.cmd

