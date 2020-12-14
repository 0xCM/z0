@REM echo off

@REM set DataSrc=%ZDb%\logs
@REM echo DataSrc:%DataSrc%

@REM set DataDst=k:\z0.archives\data\logs
@REM echo DataDst:%DataDst%

@REM set CopyLog=%ZDb%\etl\log-archive.log
@REM echo CopyLog:%CopyLog%

@REM set CopyCmd=robocopy %DataSrc% %DataDst% /log:%CopyLog% /tee /TS /BYTES /V /MIR
@REM echo CopyCmd:%CopyCmd%

@REM echo on
@REM call %CopyCmd%

@REM echo off

@REM set DataSrc=%ZDb%\etl
@REM echo DataSrc:%DataSrc%

@REM set DataDst=k:\z0.archives\logs\etl
@REM echo DataDst:%DataDst%

@REM set CopyLog=%ZDb%\etl\etl-log-archive.log
@REM echo CopyLog:%CopyLog%

@REM set CopyCmd=robocopy %DataSrc% %DataDst% /log:%CopyLog% /tee /TS /BYTES /V /MIR
@REM echo CopyCmd:%CopyCmd%

@REM echo on
@REM call %CopyCmd%
