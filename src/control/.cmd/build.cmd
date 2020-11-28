echo off

set ProjectId=control
echo ProjectId:%ProjectId%

call %ZDev%\.cmd\project-config.cmd

dotnet build %ProjectPath% -c Release