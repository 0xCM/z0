echo off

set ProjectId=external

set SetupCmd=%ZDev%\.cmd\subsetup.cmd
echo SetupCmd:%CmdPath%

echo on
call %SetupCmd%
call %AddCmd%
