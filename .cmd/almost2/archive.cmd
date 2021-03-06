@echo off

call %~dp0\archive-capture.cmd
call %~dp0\archive-dumps.cmd
call %~dp0\archive-zbin.cmd
call %~dp0\archive-tables.cmd
call %~dp0\archive-build.cmd
call %~dp0\archive-z0-source.cmd
call %~dp0\archive-applogs.cmd
call %~dp0\archive-etllogs.cmd
call %~dp0\archive-control.cmd