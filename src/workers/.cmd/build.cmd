echo off

set ProjectId=workers
echo ProjectId:%ProjectId%

call %ZDev%\.cmd\project-config.cmd

dotnet build %ProjectPath% -c Release