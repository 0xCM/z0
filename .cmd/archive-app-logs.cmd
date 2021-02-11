@echo off

set DataSrc=%ZDb%\logs
echo DataSrc:%DataSrc%

set DataDst=k:\z0.archives\data\logs
echo DataDst:%DataDst%

set CopyLog=%ZDb%\etl\archive-app-logs.log
echo CopyLog:%CopyLog%

set CopyCmd=robocopy %DataSrc% %DataDst% /log:%CopyLog% /tee /TS /BYTES /V /MIR
echo CopyCmd:%CopyCmd%

call %CopyCmd%