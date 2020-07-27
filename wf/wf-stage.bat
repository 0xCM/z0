echo off

set BuildRootDir=%ZDev%\bin
set SdkAppVer=netcoreapp3.0
set LibSrc=%BuildRootDir%\lib\%SdkAppVer%
set StageDir=%ZLogs%\builds

set FileName=z0.binlog
set Src="%BuildRootDir%\%FileName%"
set Dst="%StageDir%\%FileName%"
copy %Src% /A %Dst% /Y

set FileName=z0.ProjectImports.zip
set Src="%BuildRootDir%\%FileName%"
set Dst="%StageDir%\%FileName%"
copy %Src% /A %Dst% /Y

set Src=%LibSrc%
set Dst=%ZLogs%\builds\bin
set RoboLog="%ZLogs%\etl\stage-bin.log"
robocopy %Src% %Dst% /log:%RoboLog% /tee /TS /BYTES /V /MIR 

set Src=%BuildRootDir%\obj
set Dst=%ZLogs%\builds\obj
set Log="%ZLogs%\etl\stage-obj.log"
robocopy %Src% %Dst% /log:%Log% /tee /TS /BYTES /V /MIR 

echo on