@REM echo off

@REM set DataSrc=%ZDev%\.build\bin\release\z0.machine
@REM echo DataSrc:%DataSrc%

@REM set DataDst=k:\z0.archives\builds\release\machine
@REM echo DataDst:%DataDst%

@REM set CopyLog=%ZDb%\etl\build-archive.log
@REM echo CopyLog:%CopyLog%

@REM set CopyCmd=robocopy %DataSrc% %DataDst% /log:%CopyLog% /tee /TS /BYTES /V /MIR
@REM echo CopyCmd:%CopyCmd%

@REM echo on
@REM call %CopyCmd%
