echo off

set SrcRoot=%ZDev%\src
echo SrcRoot:%SrcRoot%

set SlnRoot=%ZDev%\src\%SlnId%
echo SlnRoot:%SlnRoot%

set SlnFile=z0.%SlnId%.sln
set SlnPath=%SlnRoot%\%SlnFile%
echo SlnPath:%SlnPath%

set ProjectRoot=%SrcRoot%\%ProjectId%
echo ProjectRoot:%ProjectRoot%

set ProjectFile=z0.%ProjectId%.csproj
set ProjectPath=%ProjectRoot%\%ProjectFile%
echo ProjectPath:%ProjectPath%