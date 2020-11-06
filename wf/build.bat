echo off

set CmdSep="--------------------------------------------------------------------------------"
set CmdLog=%ZDb%\logs\commands\command.build.log
echo %CmdSep% >> %CmdLog%

set SlnPath="%ZDev%\z0.machine.sln"
echo SlnPath:%SlnPath% >> %CmdLog%

set BinLog="%ZDb%\logs\build\z0.machine.binlog"
echo BinLog:%BinLog% >> %CmdLog%

::set CmdExec=dotnet build %SlnPath% -c Custom -bl:%BinLog%;ProjectImports=ZipFile -m -detailedSummary -graph:true
set TextLog="%ZDb%\logs\build\z0.machine.log"

set CmdExec=dotnet build %SlnPath% -c Release -fl -flp:logfile=%TextLog%;verbosity=normal -m -graph:true
echo CmdExec:%CmdExec% >> %CmdLog%

echo on
call %CmdExec%
