call .cmd/build.bat

@echo off

set AppExePath=J:\dev\projects\z0\.build\bin\Release\z0.dynoshell\netcoreapp3.1\win-x64\z0.dynoshell.exe
echo AppExePath:%AppExePath%

echo on

call %AppExePath%