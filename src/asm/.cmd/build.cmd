@echo off
set ZCmd=%ZDev%\.cmd

set ProjectId=konst

set BuildCmd=%ZCmd%\build-lib.cmd
echo BuildCmd:%BuildCmd%

call %BuildCmd%

::@echo off

::call capture %ProjectId%
