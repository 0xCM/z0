echo off
call wf\vars.cmd

set BuildSrc="%StageBuild%"
set BuildDst="K:\z0\builds"
set BuildLog="%ZLogs%\etl\build-archive.log"
robocopy %BuildSrc% %BuildDst% /log:%BuildLog% /tee /TS /BYTES /V /MIR

set SrcDir="%ZLogs%\respack\content"
set DstDir="K:\z0\archives\respack\content"
set LogPath="%ZLogs%\etl\respack-archive.log"
robocopy %SrcDir% %DstDir% /log:%LogPath% /tee /TS /BYTES /V /MIR

set TestLogSrc="%ZLogs%\test"
set TestLogDst="K:\z0\archives\test"
set TestLogLog="%ZLogs%\etl\test-archive.log"
robocopy %TestLogSrc% %TestLogDst% /log:%TestLogLog% /tee /TS /BYTES /V /MIR

set EtlLogSrc="%ZLogs%\etl"
set EtlLogDst="K:\z0\archives\.logs"
set EltLogLog="%ZLogs%\etl\etl-archive.log"
robocopy %EtlLogSrc% %EtlLogDst% /log:%EltLogLog% /tee /TS /BYTES /V /MIR

set VerSrc="%ZDev%\version"
set VerDst="K:\z0\archives"
copy %VerSrc% /A %VerDst% /Y