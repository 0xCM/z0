@echo off
set ZCmd=%ZDev%\.cmd
call %ZCmd%\config-lib-deploy.cmd
call %DeployCmd%
