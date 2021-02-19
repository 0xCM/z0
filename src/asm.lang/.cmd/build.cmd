@echo off
set ProjectId=asm.lang
set ZCmd=%ZControl%\.cmd

set BuildCmd=%ZCmd%\build-project-unpublished.cmd
echo BuildCmd:%BuildCmd%

call %BuildCmd%
