@echo off

set SlnId=machine
call %~dp0\build-config.cmd

set BuildCmd=dotnet build %ProjectPath% /p:Configuration=Release /p:Platform="Any CPU" -fl -flp:logfile=%BuildLogPath%;verbosity=detailed -m:6 -graph:true
echo BuildCmd:%BuildCmd%

echo on
call %BuildCmd%