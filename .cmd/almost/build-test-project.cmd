@echo off

set CmdMsg="Building %ProjectId% tests"
set CmdSep="--------------------------------------------------------------------------------"
set CmdLog=%ZDb%\logs\commands\z0.%ProjectId%.test.build.log

echo %CmdSep% >> %CmdLog%
echo %CmdMsg% >> %CmdLog%

set ZCmd=%ZDev%\.cmd
echo ZCmd:%ZCmd%

call %ZCmd%\config-test.cmd

@REM set ProjectPath=%ZDev%\test\%ProjectId%\z0.%ProjectId%.test.csproj
@REM echo ProjectPath:%ProjectPath%

@REM set TestExe=%ZDev%\.build\bin\Release\z0.%ProjectId%.test\netcoreapp3.1\win-x64\z0.%ProjectId%.test.exe
@REM echo TestExe:%TestExe%

@REM set BuildLog="%ZDb%\logs\build\z0.%ProjectId%.test.log"
@REM echo BuildLog:%BuildLog%

set CmdExec=dotnet build %TestProjectPath% /p:Configuration=Release /p:Platform="Any CPU" -fl -flp:logfile=%TestBuildLog%;verbosity=detailed -m:6 -graph:true

echo %CmdSep% >> %CmdLog%
echo CmdExec:%CmdExec% >> %CmdLog%

echo on
call %CmdExec%

