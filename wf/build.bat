echo off

set CmdSep="--------------------------------------------------------------------------------"
set CmdLog=%ZDb%\logs\commands\command.build.log
echo %CmdSep% >> %CmdLog%

set SlnPath="%ZDev%\z0.machine.sln"
echo SlnPath:%SlnPath% >> %CmdLog%

set BuildLog="%ZDb%\logs\build\z0.machine.binlog"
echo BuildLog:%BuildLog% >> %CmdLog%

set CmdExec=dotnet build %SlnPath% -c Custom -bl:%BuildLog%;ProjectImports=ZipFile -m -detailedSummary -graph:true
echo CmdExec:%CmdExec% >> %CmdLog%

echo on
call %CmdExec%
