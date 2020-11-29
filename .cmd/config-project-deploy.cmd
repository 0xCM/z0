@echo off

set ControlRoot=j:\control
echo ControlRoot:%ControlRoot%

set ZCmd=%ZDev%\.cmd
echo ZCmd:%ZCmd%

set DeployRoot=%ControlRoot%\tools\z
echo DeployRoot:%DeployRoot%

call %ZCmd%\config-project-bin

set DeploySrc=%ProjectBinRoot%
echo DeploySrc:%DeploySrc%

set DeployDst=%DeployRoot%
echo DeployDst:%DeployDst%

set DeployLog=%ZDb%\etl\deploy-%ProjectId%.log
echo DeployLog:%DeployLog%

set DeployCmd=robocopy %DeploySrc% %DeployDst% /log:%DeployLog% /tee /TS /BYTES /V /e
echo DeployCmd:%DeployCmd%
