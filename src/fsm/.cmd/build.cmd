echo off

set ProjectId=fsm
echo ProjectId:%ProjectId%

call %ZDev%\.cmd\project-config.cmd

dotnet build %ProjectPath% -c Release