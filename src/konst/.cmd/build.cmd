@echo off
set ProjectId=konst

set BuildCmd=%ZDev%\.cmd\build-lib.cmd
echo BuildCmd:%BuildCmd%

call %BuildCmd%

@echo off

if errorlevel 0 (
call capture %ProjectId%
)
