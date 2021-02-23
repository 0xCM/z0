@echo off
set ZCmd=%ZControl%\.cmd
call %ZCmd%\config-lib-deploy.cmd
call %DeployCmd%
