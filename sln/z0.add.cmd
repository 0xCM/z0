echo off
set SrcRoot=%ZDev%\src
set SlnRoot=%ZDev%\sln
set Scripts=%SlnRoot%

set SlnFile=z0.%SlnId%.sln
set SlnPath=%SlnRoot%\%SlnFile%

set ProjectFile=z0.%ProjectId%.csproj
set ProjectPath=%SrcRoot%\%ProjectId%\%ProjectFile%

set AddCmd=dotnet sln %SlnPath% add %ProjectPath%

echo on

call %AddCmd%