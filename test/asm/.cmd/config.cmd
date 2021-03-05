@echo off

set ProjectId=asm
echo ProjectId:%ProjectId%
call %ZControl%\.cmd\build-test-project-config.cmd

