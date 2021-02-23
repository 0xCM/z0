@echo off

set TestProjectPath=%ZDev%\test\%ProjectId%\z0.%ProjectId%.test.csproj
echo TestProjectPath:%TestProjectPath%

set TestExe=%ZDev%\.build\bin\Release\z0.%ProjectId%.test\netcoreapp3.1\win-x64\z0.%ProjectId%.test.exe
echo TestExe:%TestExe%

set TestBuildLog="%ZDb%\logs\build\z0.%ProjectId%.test.log"
echo TestBuildLog:%TestBuildLog%