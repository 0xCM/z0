echo off
set ProjectId=konst
set ProjectFile=z0.%ProjectId%.csproj
set ProjectDir=%ZDev%\src\%ProjectId%
set ProjectPath=%ProjectDir%\%ProjectFile%
set Cmd=dotnet build %ProjectPath%

echo on
call %Cmd%
echo off

set PartList=part sys konst
set Cmd=z0 %PartList%

echo on
call %Cmd%
