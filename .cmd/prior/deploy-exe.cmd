@echo off

set ZCmd=%ZDev%\.cmd
echo ZCmd:%ZCmd%

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

set DeployCmd=robocopy %DeploySrc% %ZTools% /log:%DeployLog% /tee /TS /BYTES /V /e
echo DeployCmd:%DeployCmd%

call %DeployCmd%
