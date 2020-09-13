echo off
call wf\vars.cmd

REM set BuildSrc="%StageBuild%"
REM set BuildDst="K:\z0\builds"
REM set BuildLog="%ZLogs%\etl\build-archive.log"
REM robocopy %BuildSrc% %BuildDst% /log:%BuildLog% /tee /TS /BYTES /V /MIR

set SrcDir="%ZLogs%\capture"
set DstDir="%ArchiveDir%\capture"
set LogPath="%ZLogs%\etl\archive-capture.log"
robocopy %SrcDir% %DstDir% /log:%LogPath% /tee /TS /BYTES /V /MIR

set SrcDir="%ZLogs%\respack\content"
set DstDir="%ArchiveDir%\emitted"
set LogPath="%ZLogs%\etl\emitted-archive.log"
robocopy %SrcDir% %DstDir% /log:%LogPath% /tee /TS /BYTES /V /MIR

set TestLogSrc="%ZLogs%\test"
set TestLogDst="%Archive%\test"
set TestLogLog="%ZLogs%\etl\test-archive.log"
robocopy %TestLogSrc% %TestLogDst% /log:%TestLogLog% /tee /TS /BYTES /V /MIR

set EtlLogSrc="%ZLogs%\etl"
set EtlLogDst="%Archive%\.logs"
set EltLogLog="%ZLogs%\etl\etl-archive.log"
robocopy %EtlLogSrc% %EtlLogDst% /log:%EltLogLog% /tee /TS /BYTES /V /MIR

set VerSrc="%ZDev%\version"
set VerDst="%Archive%\"
copy %VerSrc% /A %VerDst% /Y