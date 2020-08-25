echo off
call wf\vars.cmd

set SlnPath="%ZDev%\z0.sln"
set BuildLog="%ZLogs%\builds\logs\z0.main.binlog"
set NeedsFile=z0.needs.json
set NeedsPath="%ZLogs%\builds\%NeedsFile%"

set Cmd=dotnet build %SlnPath% /detailedSummary /t:GenerateRestoreGraphFile /p:RestoreGraphOutputPath=%NeedsPath% -m

echo on
call %Cmd%
echo off

set Cmd=dotnet build %SlnPath% -bl:%BuildLog%;ProjectImports=ZipFile /detailedSummary -m

echo on
call %Cmd%
echo off

set Cmd=%ZDev%\wf\stage.bat
echo on
call %Cmd%


