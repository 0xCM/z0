@echo off

set ProjectId=dynamic
call %~dp0\build-shell-config.cmd

echo on
call %BuildCmd%
call %DeployCmd%

