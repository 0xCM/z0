@echo off
set ZCmd=%ZDev%\.cmd

set ProjectId=interop
set BuildCmd=%ZCmd%\build-lib.cmd
echo BuildCmd:%BuildCmd%

call %BuildCmd%

