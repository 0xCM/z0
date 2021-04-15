@echo off
call %~dp0config.cmd

echo on
rmdir %PubDir% /s/q
rmdir %BinDir% /s/q
