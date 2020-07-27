echo off

set DstDir=%ZLogs%\builds
set DstFile=z0.aggregate.csproj
set DstPath="%DstDir%\%DstFile%"

set SlnFile=z0.sln
set SlnPath="%ZDev%\%SlnFile%"

set Cmd=msbuild %SlnPath% /preprocess /detailedSummary -m
call %Cmd%

echo on