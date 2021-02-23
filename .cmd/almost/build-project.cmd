@echo off

set ZCmd=%ZControl%\.cmd
echo ZCmd=%ZControl%

set SlnId=machine
call %ZCmd%\build-config.cmd

set BuildCmd=dotnet build %ProjectPath% /p:Configuration=Release /p:Platform="Any CPU" -fl -flp:logfile=%BuildLogPath%;verbosity=detailed -m:6 -graph:true
echo BuildCmd:%BuildCmd%
echo BuildCmd:%BuildCmd% >> %CmdLog%

echo on
call %BuildCmd%