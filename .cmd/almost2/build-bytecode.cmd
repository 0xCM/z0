@echo off

set ZCmd=%ZControl%\.cmd
set ProjectId=respack
set SlnId=z0.respack
call %ZCmd%\build-config.cmd

set SlnDir=J:\dev\projects\z0.generated\respack
set SlnPath=%SlnDir%\%SlnId%.sln

set TextLog="%ZDb%\logs\build\z0.%ProjectId%.log"

set BuildArgs=/p:Configuration=Release /p:Platform="Any CPU" -fl -flp:logfile=%TextLog%;verbosity=detailed -m:6 -graph:true
echo BuildArgs:%BuildArgs%

set BuildCmdLine=dotnet build %SlnPath% %BuildArgs%
echo BuildCmdLine:%BuildCmdLine%
echo %BuildCmdLine% >> %CmdLog%

echo on

call %BuildCmdLine%

@echo off

set PackageSrc=J:\dev\projects\z0.generated\respack\.build\bin\netcoreapp3.1
echo PackageSrc%PackageSrc%

set PackageDst=J:\packages\z0\respack
echo PackageDst:%PackageDst%

set PackageCmd=copy %PackageSrc%\*.* %PackageDst% /y
echo PackageCmd:%PackageCmd%

echo on
call %PackageCmd%


