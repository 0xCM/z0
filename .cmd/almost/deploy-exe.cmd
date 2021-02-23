@echo off

set ZCmd=%ZControl%\.cmd
echo ZCmd:%ZCmd%

set ZBin=%ZTools%\z
echo ZBin:%ZBin%

set FrameworkMoniker=netcoreapp3.1
echo FrameworkMoniker:%FrameworkMoniker%

set RuntimeMoniker=win-x64
echo RuntimeMoniker:%RuntimeMoniker%

set BuildBinRoot=%ZDev%\.build\bin\release
echo BuildBinRoot:%BuildBinRoot%

set ProjectBinRoot=%BuildBinRoot%\z0.%ProjectId%\%FrameworkMoniker%\%RuntimeMoniker%
echo ProjectBinRoot:%ProjectBinRoot%

set DeploySrc=%ProjectBinRoot%
echo DeploySrc:%DeploySrc%

set DeployLog=%ZDb%\etl\deploy-%ProjectId%.log
echo DeployLog:%DeployLog%

set DeployCmd=robocopy %DeploySrc% %ZTools%\z /log:%DeployLog% /tee /TS /BYTES /V /e
echo DeployCmd:%DeployCmd%

call %DeployCmd%
