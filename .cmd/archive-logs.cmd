echo off

set DataSrc=%ZDb%\logs
echo DataSrc:%DataSrc%

set DataDst=k:\z0.archives\data\logs
echo DataDst:%DataDst%

set CopyLog=%ZDb%\etl\log-archive.log
echo CopyLog:%CopyLog%

set CopyCmd=robocopy %DataSrc% %DataDst% /log:%CopyLog% /tee /TS /BYTES /V /MIR
echo CopyCmd:%CopyCmd%

echo on
call %CopyCmd%

echo off

set DataSrc=%ZDb%\etl
echo DataSrc:%DataSrc%

set DataDst=k:\z0.archives\logs\etl
echo DataDst:%DataDst%

set CopyLog=%ZDb%\etl\etl-log-archive.log
echo CopyLog:%CopyLog%

set CopyCmd=robocopy %DataSrc% %DataDst% /log:%CopyLog% /tee /TS /BYTES /V /MIR
echo CopyCmd:%CopyCmd%

echo on
call %CopyCmd%
