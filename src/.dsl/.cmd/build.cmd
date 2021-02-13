@echo off
set ZCmd=%ZDev%\.cmd

set ProjectId=dsl
set BuildCmd=%ZCmd%\build-lib.cmd
echo BuildCmd:%BuildCmd%

call %BuildCmd%

