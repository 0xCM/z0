@echo off
set ZCmd=%ZDev%\.cmd
set ProjectId=machine
call %ZCmd%\config-project-deploy.cmd
call %DeployCmd%
