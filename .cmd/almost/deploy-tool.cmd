@echo off
set ZCmd=%ZControl%\.cmd
call %ZCmd%\config-project-deploy.cmd
call %DeployCmd%
