echo off
set ProjectId=external

set SetupCmd=%ZDev%\.cmd\setup.cmd
echo SetupCmd:%SetupCmd%

echo on
call %SetupCmd%
call %RemoveCmd%
