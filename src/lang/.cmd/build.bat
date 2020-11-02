echo off
set ProjectId=lang

set SetupCmd=%ZDev%\.cmd\setup.cmd
echo SetupCmd:%SetupCmd%

echo on
call %SetupCmd%
call %BuildCmd%

z0 %ProjectId%