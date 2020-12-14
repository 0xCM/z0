@REM echo off

@REM set ZCmd=%ZDev%\.cmd
@REM echo ZCmd:%ZCmd%

@REM set DataSrc=%ZDb%\tables
@REM echo DataSrc:%DataSrc%

@REM set DataDst=k:\z0.archives\data\tables
@REM echo DataDst:%DataDst%

@REM set CopyLog=%ZDb%\etl\table-archive.log
@REM echo CopyLog:%CopyLog%

@REM set CopyCmd=robocopy %DataSrc% %DataDst% /log:%CopyLog% /tee /TS /BYTES /V /MIR
@REM echo CopyCmd:%CopyCmd%

@REM echo on
@REM call %CopyCmd%
