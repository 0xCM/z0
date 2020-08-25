echo off

set SlnPath="%ZLogs%\respack\z0.respack.sln"
set BuildLog="%ZLogs%\builds\logs\z0.respack.binlog"
set Cmd=dotnet build %SlnPath% -bl:%BuildLog%;ProjectImports=ZipFile
call %Cmd%
