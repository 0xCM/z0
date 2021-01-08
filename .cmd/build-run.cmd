@echo off

set ZCmd=%ZDev%\.cmd
echo ZCmd:%ZCmd%

set ProjectId=run

set BuildCmd=%ZCmd%\build-project.cmd
echo BuildCmd:%BuildCmd%

set DeployExeCmd=%ZCmd%\deploy-exe.cmd
echo DeployExeCmd:%DeployExeCmd%

call %BuildCmd%
call %DeployExeCmd%
