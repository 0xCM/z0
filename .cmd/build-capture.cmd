@echo off

set ProjectId=control
echo ProjectId:%ProjectId%

call %~dp0\build-project.cmd
call %~dp0\deploy-tool.cmd
