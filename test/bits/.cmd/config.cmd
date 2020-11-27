echo off

set ProjectId=bits
echo ProjectId:%ProjectId%

set ProjectPath=%ZDev%\test\%ProjectId%\z0.%ProjectId%.test.csproj
echo ProjectPath:%ProjectPath%

set TestExe=%ZDev%\.build\bin\Release\z0.%ProjectId%.test\netcoreapp3.1\win-x64\z0.%ProjectId%.test.exe
echo TestExe:%TestExe%
