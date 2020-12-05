@echo off

set DstDir=j:\cache\z0
set ProjectPath=%ZDev%\src\%ProjectId%\z0.%ProjectId%.csproj
set PackOptions=--include-symbols --include-source --verbosity detailed --output %DstDir%
set PackCmd=dotnet pack %ProjectPath% %PackOptions%

echo PackCmd:%PackCmd%
call %PackCmd%