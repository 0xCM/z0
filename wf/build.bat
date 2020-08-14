echo off
call wf\wf-vars.cmd
echo on
set Cmd=dotnet build -bl:bin/z0.binlog;ProjectImports=ZipFile
call %Cmd%
