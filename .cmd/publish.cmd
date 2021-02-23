@echo off

set ProjectId=machine
set SlnId=z0.machine

call %~dp0\build-config.cmd

set PubDst=%ZPack%\z0\machine
set PubCmd=dotnet publish %ProjectPath% -c Release --runtime win-x64 --output %PubDst% --verbosity detailed -p:PublishTrimmed=false -p:PublishReadyToRun=true
echo %PubCmd%

call %PubCmd% > pulish.log
