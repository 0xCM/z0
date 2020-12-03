@echo off

set ZCmd=%ZDev%\.cmd
echo ZCmd:%ZCmd%

set ScriptCmd=%ZCmd%\archive-machine-capture.cmd
echo on
call %ScriptCmd%
echo on

set ScriptCmd=%ZCmd%\archive.tables.cmd
echo on
call %ScriptCmd%
echo on

set ScriptCmd=%ZCmd%\archive-logs.cmd
echo on
call %ScriptCmd%
echo on

set ScriptCmd=%ZCmd%\archive-build.cmd
echo on
call %ScriptCmd%
echo on
