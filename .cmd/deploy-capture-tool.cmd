@echo off

set ZCmd=%ZDev%\.cmd
echo ZCmd:%ZCmd%

set ProjectId=control
echo ProjectId:%ProjectId%

call %ZCmd%\config-project-deploy.cmd

echo on

call %DeployCmd%
