@echo off
set SrcRoot=%ZDev%\src
set Sln=%SrcRoot%\%SlnId%\z0.%SlnId%.sln

set ProjRoot=%SrcRoot%\%ProjId%
set Proj=%ProjRoot%\z0.%ProjId%.csproj

set CmdSpec=dotnet sln %Sln% add %Proj%
call %CmdSpec%
