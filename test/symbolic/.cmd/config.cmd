echo off

set ProjectId=symbolic
echo ProjectId:%ProjectId%

set ProjectPath=%ZDev%\test\%ProjectId%\z0.%ProjectId%.test.csproj
echo ProjectPath:%ProjectPath%

set ProjectExeName=z0.symbolic.test.exe
set ProjectExePath=%ZDev%\.build\bin\release\z0.symbolic.test\netcoreapp3.1\win-x64\%ProjectExeName%