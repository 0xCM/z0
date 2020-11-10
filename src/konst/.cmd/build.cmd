echo off

set ProjectId=konst
echo ProjectId:%ProjectId%

call %ZDev%\.cmd\project-config.cmd

dotnet build %ProjectPath% -c Release