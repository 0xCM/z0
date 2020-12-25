@echo off
set ProjectId=gen

set BuildCmd=%ZDev%\.cmd\build-shell.cmd
echo BuildCmd:%BuildCmd%

call %BuildCmd%

