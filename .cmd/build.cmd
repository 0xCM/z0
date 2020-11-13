echo off

set SlnId=z0.machine
echo SlnId:%SlnId%

set CmdSep="--------------------------------------------------------------------------------"
set CmdLog=%ZDb%\logs\commands\command.build.log
echo %CmdSep% >> %CmdLog%

set SlnPath="%ZDev%\%SlnId%.sln"
echo SlnPath:%SlnPath% >> %CmdLog%

set TextLog="%ZDb%\logs\build\%SlnId%.log"

set CmdExec=dotnet build %SlnPath% /p:Configuration=Release /p:Platform="Any CPU" -fl -flp:logfile=%TextLog%;verbosity=detailed -m:6 -graph:true

echo CmdExec:%CmdExec% >> %CmdLog%

echo on
call %CmdExec%
