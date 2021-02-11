@echo off

set ZC=%ZControl%\.cmd
call %ZC%\config.cmd

set UpdateDevScripts=copy %ZCmd%\*.cmd %ZDevCmd% /y
echo UpdateDevScripts:%UpdateDevScripts%

echo on

call %UpdateDevScripts%