echo off

set ZCmd=%ZDev%\.cmd
echo ZCmd:%ZCmd%

set DataSrc=%ZDb%\tables
echo DataSrc:%DataSrc%

set DataDst=k:\z0.archives\data\tables
echo DataDst:%DataDst%

set CopyLog=%ZDb%\etl\table-archive.log
echo CopyLog:%CopyLog%

set CopyCmd=robocopy %DataSrc% %DataDst% /log:%CopyLog% /tee /TS /BYTES /V /MIR
echo CopyCmd:%CopyCmd%

echo on
call %CopyCmd%
