call .cmd/build.bat

@echo off

set AppExePath=J:\dev\projects\z0\.build\bin\Release\z0.dynamic.shell\netcoreapp3.1\win-x64\z0.dynamic.shell.exe
echo AppExePath:%AppExePath%

echo on

call %AppExePath%