@echo off

set ProjectPath=%ZDev%\test\%ProjectId%\z0.%ProjectId%.test.csproj
echo ProjectPath:%ProjectPath%

set TestExe=%ZDev%\.build\bin\Release\z0.%ProjectId%.test\netcoreapp3.1\win-x64\z0.%ProjectId%.test.exe
echo TestExe:%TestExe%

set BuildLogPath="%ZDb%\logs\build\z0.%ProjectId%.test.log"
echo BuildLogPath:%BuildLogPath%

set BuildCmd=dotnet build %ProjectPath% /p:Configuration=Release /p:Platform="Any CPU" -fl -flp:logfile=%BuildLogPath%;verbosity=detailed -m:6 -graph:true
echo BuildCmd:%BuildCmd%

echo on
call %BuildCmd%

