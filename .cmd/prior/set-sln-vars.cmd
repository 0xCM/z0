echo off

set SlnRoot=%ZDev%
echo SlnRoot:%SlnRoot%

set SlnName=z0.%SlnId%.sln
echo SlnName:%SlnName%

set SlnPath=%SlnRoot%\%SlnName%
echo SlnPath:%SlnPath%

set SlnBinDir=%ZDev%.build\bin\Release\z0.%SlnId%\netcoreapp3.1\win-x64
echo SlnBinDir:%SlnBinDir%

set SlnExe=%SlnBinDir%\%SlnAppId%.exe
echo SlnExe:%SlnExe%