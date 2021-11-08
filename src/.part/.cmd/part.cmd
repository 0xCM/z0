@echo off
set SlnId=part
set SlnDir=%~dp0..\%SlnId%
set SrcRoot=%ZDev%\src

set Sln=%SlnDir%\z0.%SlnId%.sln
echo Sln:%Sln%

set AddCmd=%~dp0add.cmd

set ProjectId=part
call %AddCmd%

set ProjectId=root
call %AddCmd%

set ProjectId=core
call %AddCmd%

set ProjectId=sys
call %AddCmd%

set ProjectId=external
call %AddCmd%

set ProjectId=interop
call %AddCmd%

set ProjectId=clr
call %AddCmd%



