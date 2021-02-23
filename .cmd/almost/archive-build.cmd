@echo off

call %ZControl%\.config

set Archive=%ZArchive%
set ArchiveType=build

set DataSrc=%MachineBinSrc%
echo DataSrc:%DataSrc%

set DataDst=%MachineBinDst%
echo DataDst:%DataDst%

set CopyLog=%ZDb%\etl\archive-%ArchiveType%.log
echo CopyLog:%CopyLog%

set CopyCmd=robocopy %DataSrc% %DataDst% /log:%CopyLog% /tee /TS /BYTES /V /MIR
echo CopyCmd:%CopyCmd%

call %CopyCmd%
