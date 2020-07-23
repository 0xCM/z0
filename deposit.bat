set CaptureSrc="%ZLogs%\apps\control\capture"
set CaptureDst=K:\z0\archives\capture
set CaptureLog="%ZLogs%\etl\capture-archive.log"

set ZDataSrc="%ZDev%\src\zdata\content"
set ZDataDst=K:\z0\archives\zdata
set ZDataLog="%ZLogs%\etl\zdata-archive.log"

set ResBytesSrc="%ZLogs%\res\bytes"
set ResBytesDst=K:\z0\archives\res\bytes
set ResBytesLog="%ZLogs%\etl\res-bytes-archive.log"

set ResDocsSrc="%ZLogs%\res\docs"
set ResDocsDst=K:\z0\archives\res\docs
set ResDocsLog="%ZLogs%\etl\res-docs-archive.log"

set ResMetaSrc="%ZLogs%\res\meta"
set ResMetaDst=K:\z0\archives\res\meta
set ResMetaLog="%ZLogs%\etl\res-meta-archive.log"

set ResLitSrc="%ZLogs%\apps\machine\literals"
set ResLitDst=K:\z0\archives\res\literals
set ResLitLog="%ZLogs%\etl\literal-archive.log"

set XedSrc="%ZLogs%\apps\xed"
set XedDst="K:\z0\archives\xed"
set XedLog="%ZLogs%\etl\xed-archive.log"

set TestLogSrc="%ZLogs%\test"
set TestLogDst="K:\z0\archives\test"
set TestLogLog="%ZLogs%\etl\test-archive.log"

set ExportSrc="%ZLogs%\exports"
set ExportDst="K:\z0\archives\exports"
set ExportLog="%ZLogs%\etl\exports-archive.log"

set EtlLogSrc="%ZLogs%\etl"
set EtlLogDst="K:\z0\archives\.logs"
set EltLogLog="%ZLogs%\etl\etl-archive.log"

robocopy %CaptureSrc% %CaptureDst% /log:%CaptureLog% /tee /TS /BYTES /V /MIR 
robocopy %ZDataSrc% %ZDataDst% /log:%ZDataLog% /tee /TS /BYTES /V /MIR 
robocopy %XedSrc% %XedDst% /log:%XedLog% /tee /TS /BYTES /V /MIR
robocopy %ResBytesSrc% %ResBytesDst% /log:%ResBytesLog% /tee /TS /BYTES /V /MIR 
robocopy %ResDocsSrc% %ResDocsDst% /log:%ResDocsLog% /tee /TS /BYTES /V /MIR 
robocopy %ResMetaSrc% %ResMetaDst% /log:%ResMetaLog% /tee /TS /BYTES /V /MIR 
robocopy %ResLitSrc% %ResLitDst% /log:%ResLitLog% /tee /TS /BYTES /V /MIR
robocopy %TestLogSrc% %TestLogDst% /log:%TestLogLog% /tee /TS /BYTES /V /MIR 
robocopy %ExportSrc% %ExportDst% /log:%ExportLog% /tee /TS /BYTES /V /MIR 
robocopy %EtlLogSrc% %EtlLogDst% /log:%EltLogLog% /tee /TS /BYTES /V /MIR

set VerSrc="%ZDev%\version"
set VerDst=K:\z0\archives
copy %VerSrc% /A %VerDst% /Y
