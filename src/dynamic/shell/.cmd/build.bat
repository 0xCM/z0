@echo off
set ProjectId=dynamic

set BuildCmd=%ZDev%\.cmd\build-shell.cmd
echo BuildCmd:%BuildCmd%

call %BuildCmd%

set DeployCmd=%ZDev%\.cmd\deploy.cmd
echo DeplyCmd:%DeployCmd%

::call %DeployCmd%