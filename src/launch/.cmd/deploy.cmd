@echo off

set ZCmd=%ZDev%\.cmd
echo ZCmd:%ZCmd%

set ProjectId=launch

set DeployCmd=%ZCmd%\deploy.cmd
echo DeployCmd:%DeployCmd%
call %DeployCmd%

