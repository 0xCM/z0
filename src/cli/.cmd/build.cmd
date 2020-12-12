@echo off
set ProjectId=cli

set BuildCmd=%ZDev%\.cmd\build-lib.cmd
echo BuildCmd:%BuildCmd%

call %BuildCmd%

