@echo off

set Archive=%ZArchive%
set ArchiveType=capture

set DataSrc=%ZDb%\%ArchiveType%
echo DataSrc:%DataSrc%

set DataDst=%Archive%\data\%ArchiveType%
echo DataDst:%DataDst%

set CopyLog=%ZDb%\etl\archive-%ArchiveType%.log
echo CopyLog:%CopyLog%

set CopyCmd=robocopy %DataSrc% %DataDst% /log:%CopyLog% /tee /TS /BYTES /V /MIR
echo CopyCmd:%CopyCmd%
