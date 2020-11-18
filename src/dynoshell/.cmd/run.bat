call .cmd/build.bat

@echo off

set ShellPath=J:\dev\projects\z0\.build\bin\Release\z0.dynoshell\netcoreapp3.1\win-x64\z0.dynoshell.exe
echo ShellPath:%ShellPath%

echo on

call %ShellPath%