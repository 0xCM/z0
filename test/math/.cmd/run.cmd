@echo off

set ProjectId=math
echo ProjectId:%ProjectId%

set ZCmd=%ZDev%\test\.cmd
echo ZCmd:%ZCmd%

call %ZCmd%\build-project.cmd
call %TestExe%