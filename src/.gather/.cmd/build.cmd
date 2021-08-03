@echo off
call %ControlScripts%\build-libs.cmd
set ProjectId=gather
call %ControlScripts%\build-app.cmd