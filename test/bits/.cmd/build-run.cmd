@echo off
call %~dp0\config.cmd
call %~dp0\build.cmd
call %~dp0\run.cmd %1 %2 %3 %4