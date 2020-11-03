echo off
set ProjectId=run
echo ProjectId:%ProjectId%

set SetupCmd=%ZDev%\.cmd\setup.cmd
echo SetupCmd:%SetupCmd%

echo on
call %SetupCmd%
call %AddCmd%
