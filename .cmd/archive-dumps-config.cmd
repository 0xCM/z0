@echo off

set Archive=%ZArchive%
set ArchiveType=dumps

set DataSrc=%ZDb%\bin\dumps
echo DataSrc:%DataSrc%

set DataDst=%Archive%\bin\dumps
echo DataDst:%DataDst%

set CopyLog=%ZDb%\etl\archive-%ArchiveType%.log
echo CopyLog:%CopyLog%

set CopyCmd=robocopy %DataSrc% %DataDst% /log:%CopyLog% /tee /TS /BYTES /V /MIR
echo CopyCmd:%CopyCmd%