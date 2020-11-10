echo off

set ProjectId=api
set SetupCmd=%ZDev%\.cmd\setup.cmd
call %SetupCmd%

echo on

call %AddCmd%
