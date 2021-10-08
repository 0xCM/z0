@echo off
set PkgDst=j:\cache\dev
dotnet pack z0.core.sln --include-source -c Release --output %PkgDst%
