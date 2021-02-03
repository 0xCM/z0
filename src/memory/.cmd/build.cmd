@echo off
set ZCmd=%ZDev%\.cmd
set ProjectId=memory

set BuildCmd=%ZCmd%\build-lib.cmd
echo BuildCmd:%BuildCmd%

call %BuildCmd%