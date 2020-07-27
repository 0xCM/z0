echo off

set Cmd=wf\wf-needs.bat
call %Cmd%

set Cmd=dotnet build -bl:bin/z0.binlog;ProjectImports=ZipFile
call %Cmd%

set Cmd=wf\wf-stage.bat
call %Cmd%

set Cmd=wf\wf-ilpack.bat
echo on