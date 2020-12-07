@echo off
set ProjectId=part

set BuildCmd=%ZDev%\.cmd\build-lib.cmd
echo BuildCmd:%BuildCmd%

call %BuildCmd%

@echo off

if errorlevel 0 (
call capture %ProjectId%
)
