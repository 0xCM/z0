echo off

set ProjectId=machine
echo ProjectId:%ProjectId%

set SlnId=z0.%ProjectId%
echo SlnId:%SlnId%

set CmdSep="--------------------------------------------------------------------------------"
set CmdLog=%ZDb%\logs\commands\command.build.log
echo %CmdSep% >> %CmdLog%

set SlnPath="%ZDev%\%SlnId%.sln"
echo SlnPath:%SlnPath% >> %CmdLog%

set TextLog="%ZDb%\logs\build\%SlnId%.log"

set BuildCmdExec=dotnet build %SlnPath% /p:Configuration=Release /p:Platform="Any CPU" -fl -flp:logfile=%TextLog%;verbosity=detailed -m:6 -graph:true

echo BuildCmdExec:%BuildCmdExec% >> %CmdLog%

call %BuildCmdExec%


::call .cmd\deploy.cmd
