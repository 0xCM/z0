@echo off

set ZCmd=%ZControl%\.cmd

set ProjectId=control
echo ProjectId:%ProjectId%

call %ZCmd%\build-project.cmd
call %ZCmd%\deploy-tool.cmd
