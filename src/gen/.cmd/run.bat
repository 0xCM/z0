@echo off

setlocal
call :find_dp0

call .cmd/build.bat

set ProjectId=gen
set ShellExePath=%DeployDst%\z0.%ProjectId%.shell.exe
echo ShellExePath:%ShellExePath%
call %ShellExePath% %*

:find_dp0
set dp0=%~dp0
exit /b
