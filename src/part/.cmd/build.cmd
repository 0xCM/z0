@echo off
set ProjectId=part
set ZCmd=%ZControl%\.cmd

set BuildCmd=%ZCmd%\build-project-unpublished.cmd
echo BuildCmd:%BuildCmd%

call %BuildCmd%
