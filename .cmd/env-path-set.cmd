@echo off
call %~dp0\env-path-config.cmd

echo on
setx /M %VarName% "%VarVal%"
