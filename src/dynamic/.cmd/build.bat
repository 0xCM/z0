@echo off

set ProjectId=dynamic
set BuildCmd=%ZDev%\.cmd\build-shell.cmd
echo BuildCmd:%BuildCmd%
call %BuildCmd%

