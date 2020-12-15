@echo off

set ProjectId=xed

set BuildCmd=%ZDev%\.cmd\build-app.cmd
echo BuildCmd:%BuildCmd%

call %BuildCmd%

