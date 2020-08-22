echo off
call wf\vars.cmd

set BuildSrc="%StageBuild%"
set BuildDst="K:\z0\builds"
set BuildLog="%ZLogs%\etl\build-archive.log"
robocopy %BuildSrc% %BuildDst% /log:%BuildLog% /tee /TS /BYTES /V /MIR

set CaptureSrc="%ZLogs%\apps\machine\capture"
set CaptureDst="K:\z0\archives\res\capture"
set CaptureLog="%ZLogs%\etl\capture-archive.log"
robocopy %CaptureSrc% %CaptureDst% /log:%CaptureLog% /tee /TS /BYTES /V /MIR

set ZDataSrc="%ZDev%\src\tables\data"
set ZDataDst="K:\z0\archives\tables"
set ZDataLog="%ZLogs%\etl\table-archive.log"
robocopy %ZDataSrc% %ZDataDst% /log:%ZDataLog% /tee /TS /BYTES /V /MIR

set ResBytesSrc="%ZLogs%\res\bytes"
set ResBytesDst="K:\z0\archives\res\bytes"
set ResBytesLog="%ZLogs%\etl\res-bytes-archive.log"
robocopy %ResBytesSrc% %ResBytesDst% /log:%ResBytesLog% /tee /TS /BYTES /V /MIR

set ResIdxSrc="%ZLogs%\res\index"
set ResIdxDst="K:\z0\archives\res\index"
set ResIdxLog="%ZLogs%\etl\res-index-archive.log"
robocopy %ResIdxSrc% %ResIdxDst% /log:%ResIdxLog% /tee /TS /BYTES /V /MIR

set RecapSrc="%ZLogs%\apps\machine\resbytes\asm"
set RecapDst="K:\z0\archives\res\recapture"
set RecapLog="%ZLogs%\etl\res-recapture-archive.log"
robocopy %RecapSrc% %RecapDst% /log:%RecapLog% /tee /TS /BYTES /V /MIR

set ResDocsSrc="%ZLogs%\res\docs"
set ResDocsDst="K:\z0\archives\res\docs"
set ResDocsLog="%ZLogs%\etl\res-docs-archive.log"
robocopy %ResDocsSrc% %ResDocsDst% /log:%ResDocsLog% /tee /TS /BYTES /V /MIR

set ResLitSrc="%ZLogs%\apps\machine\literals"
set ResLitDst="K:\z0\archives\res\literals"
set ResLitLog="%ZLogs%\etl\literal-archive.log"
robocopy %ResLitSrc% %ResLitDst% /log:%ResLitLog% /tee /TS /BYTES /V /MIR

set TableSrc="%ZLogs%\res\tables"
set TableDst="K:\z0\archives\res\tables"
set TableLog="%ZLogs%\etl\tables-archive.log"
robocopy %TableSrc% %TableDst% /log:%TableLog% /tee /TS /BYTES /V /MIR

set XedSrc="%ZLogs%\apps\xed"
set XedDst="K:\z0\archives\xed"
set XedLog="%ZLogs%\etl\xed-archive.log"
robocopy %XedSrc% %XedDst% /log:%XedLog% /tee /TS /BYTES /V /MIR

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