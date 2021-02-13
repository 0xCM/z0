@echo off

set ZCmd=%ZDev%\.cmd
echo ZCmd:%ZCmd%

call %ZCmd%\config-shell-bin.cmd

set DeploySrc=%ProjectBinRoot%
echo DeploySrc:%DeploySrc%

set DeployDst=j:\tools\z\bin
echo DeployDst:%DeployDst%

set DeployLog=%ZDb%\etl\deploy-%ProjectId%.shell.log
echo DeployLog:%DeployLog%

set DeployCmd=robocopy %DeploySrc% %DeployDst% /log:%DeployLog% /tee /TS /BYTES /V /e
echo DeployCmd:%DeployCmd%
