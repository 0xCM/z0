call .cmd/build.bat

@echo off

set ProjectId=dynamic

set ShellExePath=%DeployDst%\z0.%ProjectId%.shell.exe
echo ShellExePath:%ShellExePath%

call %ShellExePath%