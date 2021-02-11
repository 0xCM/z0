@echo off

set ZC=%ZControl%\.cmd
call %ZC%\config.cmd

echo on
call %CleanEtlLogsCmd%