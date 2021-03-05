@echo off

set ProjectId=bits
echo ProjectId:%ProjectId%
call %ZControl%\.cmd\build-test-project-config.cmd

