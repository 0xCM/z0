@echo off

set ZCmd=%ZDev%\.cmd
echo ZCmd:%ZCmd%

set ProjectId=control
echo ProjectId:%ProjectId%

call %ZCmd%\build-project.cmd
call %ZCmd%\deploy-capture-tool.cmd
