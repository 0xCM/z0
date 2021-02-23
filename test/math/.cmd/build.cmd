@echo off

set ProjectId=math
echo ProjectId:%ProjectId%

call %ZControl%\.cmd\build-tests.cmd
