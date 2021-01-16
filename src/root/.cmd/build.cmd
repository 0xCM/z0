@echo off
set ZCmd=%ZDev%\.cmd
set ProjectId=root

set BuildCmd=%ZCmd%\build-lib.cmd
echo BuildCmd:%BuildCmd%

call %BuildCmd%