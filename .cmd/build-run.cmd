@echo off

set DevCmd=%ZDev%\.cmd
echo DevCmd:%DevCmd%

call %DevCmd%\build-run.cmd
