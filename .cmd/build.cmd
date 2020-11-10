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

:: set BinLog="%ZDb%\logs\build\%SlnId%.binlog"
:: echo BinLog:%BinLog% >> %CmdLog%
::set CmdExec=dotnet build %SlnPath% -c Custom -bl:%BinLog%;ProjectImports=ZipFile -m -detailedSummary -graph:true
::set CmdExec=msbuild %SlnPath% /p:Configuration=Release /p:Platform="Any CPU" -fl -flp:logfile=%TextLog%;verbosity=normal -m:1
::set CmdExec=dotnet build %SlnPath% -c Release -fl -flp:logfile=%TextLog%;verbosity=normal -graph:true -m:1
