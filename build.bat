echo off
msbuild z0.sln /t:GenerateRestoreGraphFile /p:RestoreGraphOutputPath=needs.json -m
dotnet build -bl:bin/z0.binlog

set BinSrc=%ZDev%\bin\lib\netcoreapp3.0
set BinDst=%ZLogs%\builds\bin
set RoboLog="%ZLogs%\etl\stage-libs.log"
robocopy %BinSrc% %BinDst% /log:%RoboLog% /tee /TS /BYTES /V /MIR 

echo on

set Cmd=wf\il.bat
call %Cmd%

