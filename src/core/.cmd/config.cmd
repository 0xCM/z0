@echo off
set SlnId=core
set SlnAdd=%~dp0sln-add.cmd

set ProjId=core
call %SlnAdd%

set ProjId=root
call %SlnAdd%

set ProjId=sys
call %SlnAdd%

set ProjId=interop
call %SlnAdd%
