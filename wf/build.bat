echo off

set CmdSep="--------------------------------------------------------------------------------"
set CmdLog=%ZDb%\logs\commands\command.build.log
echo %CmdSep% >> %CmdLog%

set SlnPath="%ZDev%\z0.sln"
echo SlnPath:%SlnPath% >> %CmdLog%

set BuildLog="%ZDb%\logs\build\z0.main.binlog"
echo BuildLog:%BuildLog% >> %CmdLog%

set CmdExec=dotnet build %SlnPath% -c Release -bl:%BuildLog%;ProjectImports=ZipFile -m -detailedSummary -graph:true
echo CmdExec:%CmdExec% >> %CmdLog%

echo on
call %CmdExec%
