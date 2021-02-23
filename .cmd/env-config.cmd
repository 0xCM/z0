@echo off

set WsRoot=c:\control
echo WsRoot%WsRoot%

set Tools=c:\tools
echo Tools:%Tools%

set ConfigCmd=%WSRoot%\config.cmd
echo ConfigCmd:%ConfigCmd%

@echo off
set VarName=ZTools
set VarVal=%Tools%
echo on
setx /M  %VarName% %VarVal%

@echo off
set VarName=ZBin
set VarVal=c:\tools\z
echo on
setx /M  %VarName% %VarVal%

@echo off
set VarName=ZLogs
set VarVal=c:\data\zdb\logs
echo on
setx /M  %VarName% %VarVal%

@echo off
set VarName=ZArchive
set VarVal=k:\z0.archives
echo on
setx /M  %VarName% %VarVal%

@echo off
set VarName=DOTNET_ROOT
set VarVal=c:\tools\netsdk
echo on
setx /M  %VarName% %VarVal%

@echo off
set VarName=ZControl
set VarVal=c:\control
echo on
setx /M  %VarName% %VarVal%

@echo off
set VarName=DevRoot
set VarVal=c:\dev
echo on
setx /M  %VarName% %VarVal%

@echo off
set VarName=ZDb
set VarVal=c:\data\zdb
echo on
setx /M  %VarName% %VarVal%

@echo off
set VarName=ZDev
set VarVal=c:\dev\z0
echo on
setx /M  %VarName% %VarVal%

@echo off
set VarName=ZLogs
set VarVal=c:\data\zdb\logs\apps
echo on
setx /M  %VarName% %VarVal%

@echo off
set VarName=ZPack
set VarVal=c:\packages
echo on
setx /M  %VarName% %VarVal%

@echo off
set VarName=ZCache
set VarVal=c:\cache
echo on
setx /M  %VarName% %VarVal%

@echo off
set VarName=NUGET_PACKAGES
set VarVal=c:\cache\nuget
echo on
setx /M  %VarName% %VarVal%

@echo off
set VarName=_NT_SYMBOL_PATH
set VarVal=srv*c:\cache\symbols*https://msdl.microsoft.com/download/symbols
echo on
setx /M  %VarName% %VarVal%

@echo off
set VarName=COMPlus_TC_QuickJit
set VarVal=0
echo on
setx /M  %VarName% %VarVal%

@echo off
set VarName=COMPlus_TieredCompilation
set VarVal=0
echo on
setx /M  %VarName% %VarVal%

@echo off
set VarName=path_vscode
set VarVal=%Tools%\vscode
echo on
setx /M  %VarName% %VarVal%

@echo off
set VarName=path_zbin
set VarVal=%Tools%\z
echo on
setx /M  %VarName% %VarVal%

@echo off
set VarName=path_git
set VarVal=%Tools%\git\bin
echo on
setx /M  %VarName% %VarVal%

@echo off
set VarName=path_netsdk
set VarVal=%Tools%\netsdk
echo on
setx /M  %VarName% %VarVal%
