echo off
call wf\vars.cmd

set SlnPath="%ZDev%\z0.sln"
set BuildLog="%ZLogs%\builds\logs\z0.main.binlog"
set Cmd=dotnet build %SlnPath% -bl:%BuildLog%;ProjectImports=ZipFile -m -detailedSummary -graph:true

echo on
call %Cmd%
echo off

set Cmd=%ZDev%\wf\stage.bat
echo on
call %Cmd%