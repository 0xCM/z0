@echo off
set ProjectId=konst
set ZCmd=%ZControl%\.cmd

set BuildCmd=%ZCmd%\build-project-unpublished.cmd
echo BuildCmd:%BuildCmd%

call %BuildCmd%
