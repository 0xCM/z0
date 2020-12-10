@echo off
set ProjectId=dynamic

set BuildCmd=%ZDev%\.cmd\build-shell.cmd
echo BuildCmd:%BuildCmd%

call %BuildCmd%

set DeployCmd=%ZDev%\.cmd\deploy-shell.cmd
echo DeployCmd:%DeployCmd%

::call %DeployCmd%