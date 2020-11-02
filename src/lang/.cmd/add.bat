echo off

set ProjectId=lang

set SetupCmd=%ZDev%\.cmd\setup.cmd
echo SetupCmd:%CmdPath%

echo on
call %SetupCmd%
call %AddCmd%
