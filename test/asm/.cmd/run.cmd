@echo off

set ProjectId=asm
echo ProjectId:%ProjectId%

set ZCmd=%ZDev%\.cmd
echo ZCmd:%ZCmd%

call %ZCmd%\build-tests.cmd
call %TestExe%