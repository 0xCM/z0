@echo off

call %~dp0config.cmd

dotnet publish %ProjectPath% -c Release -r win-x64

call %~dp0deploy.cmd