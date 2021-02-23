@echo off

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

set DeployDst=%ZBin%
echo DeployDst:%DeployDst%

set DeployLog=%ZDb%\etl\deploy-%ProjectId%.shell.log
echo DeployLog:%DeployLog%

set ProjectName=z0.%ProjectId%.shell
echo ProjectName:%ProjectName%

set ProjectPath="%ZDev%\src\%ProjectId%\shell\%ProjectName%.csproj"
echo ProjectPath:%ProjectPath%

set BuildLogPath="%ZDb%\logs\build\%ProjectName%.log"
echo BuildLogPath:%BuildLogPath%

set BuildCmd=dotnet build %ProjectPath% /p:Configuration=Release /p:Platform="Any CPU" -fl -flp:logfile=%BuildLogPath%;verbosity=detailed -m:6 -graph:true
echo BuildCmd:%BuildCmd%

set DeployCmd=robocopy %DeploySrc% %DeployDst% /log:%DeployLog% /tee /TS /BYTES /V /e
echo DeployCmd:%DeployCmd%