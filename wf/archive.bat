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

REM set SrcDir="%ZLogs%\respack\content"
REM set DstDir="%ArchiveDir%\emitted"
REM set LogPath="%ZLogs%\etl\emitted-archive.log"
REM robocopy %SrcDir% %DstDir% /log:%LogPath% /tee /TS /BYTES /V /MIR

REM set TestLogSrc="%ZLogs%\test"
REM set TestLogDst="%Archive%\test"
REM set TestLogLog="%ZLogs%\etl\test-archive.log"
REM robocopy %TestLogSrc% %TestLogDst% /log:%TestLogLog% /tee /TS /BYTES /V /MIR

REM set EtlLogSrc="%ZLogs%\etl"
REM set EtlLogDst="%Archive%\.logs"
REM set EltLogLog="%ZLogs%\etl\etl-archive.log"
REM robocopy %EtlLogSrc% %EtlLogDst% /log:%EltLogLog% /tee /TS /BYTES /V /MIR

REM set VerSrc="%ZDev%\version"
REM set VerDst="%Archive%\"
REM copy %VerSrc% /A %VerDst% /Y