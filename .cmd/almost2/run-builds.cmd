@echo off

set ZCmd=%ZControl%\.cmd

echo on

call %ZCmd%\build.cmd
call capture.exe
call machine.exe
call %ZCmd%\build-bytecode.cmd



