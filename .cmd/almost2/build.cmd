@echo off

set ZCmd=%ZControl%\.cmd

echo on

call %ZCmd%\build-machine.cmd
::call %ZCmd%\build-capture.cmd