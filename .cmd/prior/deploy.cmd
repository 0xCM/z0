@echo off
set ZCmd=%ZDev%\.cmd
call %ZCmd%\config-project-deploy.cmd
call %DeployCmd%
