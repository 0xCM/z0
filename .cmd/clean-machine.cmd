@echo off

set ZCmd=%ZDev%\.cmd
echo ZCmd:%ZCmd%

set ProjectId=machine
echo ProjectId:%ProjectId%

set BuildConfig=Release
echo BuildConfig:%BuildConfig%

call %ZCmd%\clean-project.cmd

set CleanTools=rmdir %ZTools% /s/q
echo CleanTools:%CleanTools%

call %CleanTools%


