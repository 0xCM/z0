@echo off

set CmdMsg="Building %ProjectId% tests"
set CmdSep="--------------------------------------------------------------------------------"
set CmdLog=%ZDb%\logs\commands\z0.%ProjectId%.test.build.log

echo %CmdSep% >> %CmdLog%
echo %CmdMsg% >> %CmdLog%

set ZCmd=%ZDev%\.cmd
echo ZCmd:%ZCmd%

set ProjectPath=%ZDev%\test\%ProjectId%\z0.%ProjectId%.test.csproj
echo ProjectPath:%ProjectPath%

set TestExe=%ZDev%\.build\bin\Release\z0.%ProjectId%.test\netcoreapp3.1\win-x64\z0.%ProjectId%.test.exe
echo TestExe:%TestExe%

set BuildLog="%ZDb%\logs\build\z0.%ProjectId%.test.log"
echo BuildLog:%BuildLog%

set CmdExec=dotnet build %ProjectPath% /p:Configuration=Release /p:Platform="Any CPU" -fl -flp:logfile=%BuildLog%;verbosity=detailed -m:6 -graph:true

echo %CmdSep% >> %CmdLog%
echo CmdExec:%CmdExec% >> %CmdLog%

echo on
call %CmdExec%

