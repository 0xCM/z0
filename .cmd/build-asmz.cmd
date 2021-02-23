@echo off

set ProjectId=asmz
call %~dp0\build-project.cmd
call %~dp0\deploy-tool.cmd

