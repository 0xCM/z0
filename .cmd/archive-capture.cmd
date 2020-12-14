@REM echo off

@REM set DataSrc=%ZDb%\capture
@REM echo DataSrc:%DataSrc%

@REM set DataDst=k:\z0.archives\data\capture
@REM echo DataDst:%DataDst%

@REM set CopyLog=%ZDb%\etl\capture-archive.log
@REM echo CopyLog:%CopyLog%

@REM set CopyCmd=robocopy %DataSrc% %DataDst% /log:%CopyLog% /tee /TS /BYTES /V /MIR
@REM echo CopyCmd:%CopyCmd%

@REM echo on
@REM call %CopyCmd%
