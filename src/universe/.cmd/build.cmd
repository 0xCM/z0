@echo off
set ProjectId=universe
call %ControlScripts%\build-lib.cmd
call %ControlScripts%\publish-lib.cmd