@echo off
set ProjectId=dynoshell

set BuildCmd=%ZDev%\.cmd\build-project.cmd
echo BuildCmd:%BuildCmd%

call %BuildCmd%

set DeployCmd=%ZDev%\.cmd\deploy.cmd
echo DeplyCmd:%DeployCmd%

call %DeployCmd%