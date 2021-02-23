@echo off

set ProjectId=machine
set SlnId=z0.machine

call %~dp0\build-config.cmd

set BuildArgs=/p:Configuration=Release /p:Platform="Any CPU" -fl -flp:logfile=%BuildLogPath%;verbosity=detailed -m:6 -graph:true
echo BuildArgs:%BuildArgs%

set BuildCmdLine=dotnet build %SlnPath% %BuildArgs%
echo BuildCmdLine:%BuildCmdLine%

call %BuildCmdLine%

call %~dp0\deploy-tool.cmd
