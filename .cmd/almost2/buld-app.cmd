@echo off

set ZCmd=%ZControl%\.cmd
echo ZCmd:%ZCmd%

set CmdSep="--------------------------------------------------------------------------------"
set ProjectName=z0.%ProjectId%

set CmdLog=%ZDb%\logs\commands\%ProjectName%.build.log
echo %CmdSep% >> %CmdLog%

set ProjectPath="%ZDev%\src\%ProjectId%\%ProjectName%.csproj"
echo SlnPath:%SlnPath% >> %CmdLog%

set TextLog="%ZDb%\logs\build\%ProjectName%.log"
set CmdExec=dotnet build %ProjectPath% /p:Configuration=Release /p:Platform="Any CPU" -fl -flp:logfile=%TextLog%;verbosity=detailed -m:6 -graph:true
echo CmdExec:%CmdExec% >> %CmdLog%

echo on
call %CmdExec%
call %ZCmd%\deploy.cmd

