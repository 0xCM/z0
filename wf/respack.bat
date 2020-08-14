echo off

set TargetRoot="K:\z0\archives\respack"
set SlnPath="K:\z0\archives\respack\z0.respack.sln"

set ResSrc="%ZLogs%\respack\content"
set ResDst="%TargetRoot%\content"
set ResLog="%ZLogs%\etl\respack-content-archive.log"
robocopy %ResSrc% %ResDst% /log:%ResLog% /tee /TS /BYTES /V /MIR 

set ResSrc="%ZLogs%\respack\app"
set ResDst="%TargetRoot%\app"
set ResLog="%ZLogs%\etl\respack-app-archive.log"
robocopy %ResSrc% %ResDst% /log:%ResLog% /tee /TS /BYTES /V /MIR 

set ResSrc="%ZLogs%\respack\.props"
set ResDst="%TargetRoot%\.props"
set ResLog="%ZLogs%\etl\respack-props-archive.log"
robocopy %ResSrc% %ResDst% /log:%ResLog% /tee /TS /BYTES /V /MIR 

call dotnet.exe build %SlnPath%