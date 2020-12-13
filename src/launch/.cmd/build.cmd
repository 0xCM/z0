@echo off

set ZCmd=%ZDev%\.cmd
echo ZCmd:%ZCmd%

set ProjectId=launch

set BuildCmd=%ZCmd%\build-project.cmd
echo BuildCmd:%BuildCmd%
call %BuildCmd%

call .cmd\deploy.cmd
