@echo off

set ZCmd=%ZDev%\.cmd

set ControlRoot=j:\control
echo ControlRoot:%ControlRoot%

set ZCmd=%ZDev%\.cmd
echo ZCmd:%ZCmd%

set DeployRoot=%ControlRoot%\tools\z
echo DeployRoot:%DeployRoot%

set FrameworkMoniker=netcoreapp3.1
echo FrameworkMoniker:%FrameworkMoniker%

set RuntimeMoniker=win-x64
echo RuntimeMoniker:%RuntimeMoniker%

set BuildBinRoot=%ZDev%\.build\bin\release
echo BuildBinRoot:%BuildBinRoot%

set ProjectBinRoot=%BuildBinRoot%\z0.%ProjectId%.shell\%FrameworkMoniker%\%RuntimeMoniker%
echo ProjectBinRoot:%ProjectBinRoot%

set DeploySrc=%ProjectBinRoot%
echo DeploySrc:%DeploySrc%

set DeployDst=%DeployRoot%
echo DeployDst:%DeployDst%

set DeployLog=%ZDb%\etl\deploy-%ProjectId%-shell.log
echo DeployLog:%DeployLog%

set DeployCmd=robocopy %DeploySrc% %DeployDst% /log:%DeployLog% /tee /TS /BYTES /V /e
echo DeployCmd:%DeployCmd%
