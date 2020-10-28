echo off


set CmdSep="--------------------------------------------------------------------------------"
set CmdLog=%ZDb%\logs\commands\command.build.%AppTarget%.log
echo %CmdSep% >> %CmdLog%

set TargetPath=%ZDev%\src\%AppTarget%\z0.%AppTarget%.csproj
echo TargetPath:%SlnPath% >> %CmdLog%

set BuildLog=%ZDb%\logs\build\z0.%AppTarget%.binlog
echo BuildLog:%BuildLog% >> %CmdLog%

set CmdExec=dotnet build %TargetPath% -bl:%BuildLog%;ProjectImports=ZipFile -m -detailedSummary -graph:true
echo CmdExec:%BuildCmd% >> %CmdLog%

echo on
call %CmdExec%
