echo off
set Control=%ZControl%
set CmdRoot=%Control%\.cmd
call %CmdRoot%\clean-build.cmd
call %CmdRoot%\clean-zbin.cmd
call %CmdRoot%\clean-capture.cmd
call %CmdRoot%\clean-tables.cmd
