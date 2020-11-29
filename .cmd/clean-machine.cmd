@echo off

set ZCmd=%ZDev%\.cmd
echo ZCmd:%ZCmd%

set ProjectId=machine
echo ProjectId:%ProjectId%

set BuildConfig=Release
echo BuildConfig:%BuildConfig%

call %ZCmd%\clean-project.cmd