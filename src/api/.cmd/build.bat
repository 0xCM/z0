echo off
set ProjectId=tools
set SetupCmd=%ZDev%\.cmd\setup.cmd
echo SetupCmd:%SetupCmd%

echo on
call %SetupCmd%
call %BuildCmd%

z0 api