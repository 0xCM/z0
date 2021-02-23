@echo off

set Archive=%ZArchive%
set ArchiveType=zbin

set DataSrc=%ZBin%
echo DataSrc:%DataSrc%

set DataDst=%Archive%\bin\zbin
echo DataDst:%DataDst%

set CopyLog=%ZDb%\etl\archive-%ArchiveType%.log
echo CopyLog:%CopyLog%

set CopyCmd=robocopy %DataSrc% %DataDst% /log:%CopyLog% /tee /TS /BYTES /V /MIR
echo CopyCmd:%CopyCmd%


