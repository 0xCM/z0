@echo off
set ProjectId=dynoshell

set BuildCmd=%ZDev%\.cmd\build-project.cmd
echo BuildCmd:%BuildCmd%

echo on
call %BuildCmd%