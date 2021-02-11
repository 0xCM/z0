@echo off

set FrameworkMoniker=netcoreapp3.1
echo FrameworkMoniker:%FrameworkMoniker%

set BuildBinRoot=%ZDev%\.build\bin\release
echo BuildBinRoot:%BuildBinRoot%

set ProjectBinRoot=%BuildBinRoot%\z0.%ProjectId%\%FrameworkMoniker%
echo ProjectBinRoot:%ProjectBinRoot%
