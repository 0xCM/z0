@echo off

set ZCmd=%ZDev%\.cmd
echo ZCmd:%ZCmd%

call %ZCmd%\clean-machine.cmd
call %ZCmd%\build.cmd