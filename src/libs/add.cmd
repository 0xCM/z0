@echo off
set SrcRoot=%ZDev%\src
set LibSln = %SrcRoot%\libs\z0.libs.sln
dotnet sln %LibSln% add %SrcRoot%\%Id%\z0.%Id%.csproj

