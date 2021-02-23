@echo off

set ZCmd=%ZControl%\.cmd
echo ZCmd:%ZCmd%

call %ZCmd%\config-project-bin.cmd

set DeploySrc=%ProjectBinRoot%
echo DeploySrc:%DeploySrc%

set DeployDst=j:\tools\z\bin
echo DeployDst:%DeployDst%

set DeployLog=%ZDb%\etl\deploy-%ProjectId%.log
echo DeployLog:%DeployLog%

set DeployCmd=robocopy %DeploySrc% %DeployDst% /log:%DeployLog% /tee /TS /BYTES /V /e
echo DeployCmd:%DeployCmd%