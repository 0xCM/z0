@echo off

set ProjectId=run

set BuildCmd=%~dp0\build-project.cmd
echo BuildCmd:%BuildCmd%

set DeployExeCmd=%~dp0\deploy-exe.cmd
echo DeployExeCmd:%DeployExeCmd%

call %BuildCmd%
call %DeployExeCmd%
