echo off
call wf\wf-vars.cmd

set DstDir=%ZLogs%\builds
set DstFile=z0.needs.json
set DstPath="%DstDir%\%DstFile%"

set Cmd=msbuild z0.sln /t:GenerateRestoreGraphFile /p:RestoreGraphOutputPath=%DstPath% -m /noAutoResponse /detailedSummary

echo on
call %Cmd%

echo off
set Cmd=dotnet build -bl:bin/z0.binlog;ProjectImports=ZipFile

echo on
call %Cmd%

echo off
set Cmd=%ZDev%\wf\stage.bat

echo on
call %Cmd%


