@echo off
set ProjectId=asmrun
set ZFramework=net5.0
set ZRuntimeId=win-x64
set ConfigName=Release
set AppName=%ProjectId%.exe
set ProjectName=z0.%ProjectId%
set ProjectPath=%ZDev%\src\%ProjectId%\%ProjectName%.csproj

set BuildDir=%ZData%\builds
set PubDir=%BuildDir%\bin\%ConfigName%\%ProjectName%\%ZFramework%\%ZRuntimeId%\publish
set BinDir=%ZTools%\z5

set DeploySrc=%PubDir%
set DeployDst=%BinDir%
set EtlLogs=%ZDb%\etl
set DeployLog=%EtlLogs%\deploy-%ProjectId%.log

echo ProjectPath:%ProjectPath%
echo BuildTargetDir:%BuildTargetDir%
echo PubDir:%PubDir%
echo BinDir:%BinDir%
echo AppPubExe:%PubDir%\%AppName%
echo AppBinExe:%BinDir%\%AppName%

echo DeploySrc:%DeploySrc%
echo DeployDst:%DeployDst%
echo DeployLog:%DeployLog%
