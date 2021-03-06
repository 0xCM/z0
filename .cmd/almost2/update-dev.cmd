@echo off

set UpdateCmd=copy %~dp0*.cmd %ZDev%\.cmd /y
echo UpdateCmd:%UpdateCmd%

echo on

call %UpdateCmd%