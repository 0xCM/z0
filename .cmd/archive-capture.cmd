echo off

set DataSrc=%ZDb%\capture
echo DataSrc:%DataSrc%

set DataDst=k:\z0.archives\data\capture
echo DataDst:%DataDst%

set CopyLog=%ZDb%\etl\capture-archive.log
echo CopyLog:%CopyLog%

set CopyCmd=robocopy %DataSrc% %DataDst% /log:%CopyLog% /tee /TS /BYTES /V /MIR
echo CopyCmd:%CopyCmd%

echo on
call %CopyCmd%
