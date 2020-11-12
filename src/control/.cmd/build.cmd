echo off

set ProjectId=machine
echo ProjectId:%ProjectId%

call %ZDev%\.cmd\project-config.cmd

dotnet build %ProjectPath% -c Release