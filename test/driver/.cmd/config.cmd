echo off

set ProjectTargetType=exe
echo ProjectTargetType:%ProjectTargetType%

set ProjectSlnId=z0
echo ProjectSlnId:%ProjectSlnId%

set ProjectArea=test
echo ProjectArea:%ProjectArea%

set ProjectName=driver
echo ProjectName:%ProjectName%

set ProjectId=%ProjectSlnId%.%ProjectArea%.%ProjectName%
echo ProjectId:%ProjectId%

set ProjectType=csproj
echo ProjectType:%ProjectType%

set ProjectRuntimeId=win-x64
echo ProjectRuntimeId:%ProjectRuntimeId%

set ProjectConfigName=release
echo ProjectConfigName:%ProjectConfigName%

set ProjectFramework=netcoreapp3.1
echo ProjectFramework:%ProjectFramework%

set SlnRoot=%ZDev%
echo SlnRoot:%SlnRoot%

set SlnBuildRoot=%SlnRoot%\.build
echo SlnBuildRoot:%SlnBuildRoot%

set ProjectFile=%ProjectId%.%ProjectType%
echo ProjectFile:%ProjectFile%

set ProjectPath=%ZDev%\%ProjectArea%\%ProjectName%\%ProjectFile%
echo ProjectPath:%ProjectPath%

set ProjectTargetName=%ProjectId%.%ProjectTargetType%
echo ProjectTargetName:%ProjectTargetName%

set ProjectBinDir=%SlnBuildRoot%\bin\%ProjectConfigName%\%ProjectId%
echo ProjectBinDir:%ProjectBinDir%

set ProjectObjDir=%SlnBuildRoot%\obj\%ProjectConfigName%\%ProjectId%
echo ProjectOjbDir:%ProjectObjDir%

set ProjectTargetPath=%ProjectBinDir%\%ProjectFramework%\%ProjectRuntimeId%\%ProjectTargetName%
echo ProjectTargetPath:%ProjectTargetPath%