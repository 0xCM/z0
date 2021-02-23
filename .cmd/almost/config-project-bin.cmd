@echo off

set FrameworkMoniker=netcoreapp3.1
echo FrameworkMoniker:%FrameworkMoniker%

set RuntimeMoniker=win-x64
echo RuntimeMoniker:%RuntimeMoniker%

set BuildBinRoot=%ZDev%\.build\bin\release
echo BuildBinRoot:%BuildBinRoot%

set ProjectBinRoot=%BuildBinRoot%\z0.%ProjectId%\%FrameworkMoniker%\%RuntimeMoniker%
echo ProjectBinRoot:%ProjectBinRoot%