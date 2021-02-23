@echo off

set Archive=%ZArchive%
set ArchiveType=builds

set DataSrc=%ZDev%\.build\bin\Release\z0.machine
echo DataSrc:%DataSrc%

set DataDst=%Archive%\bin\%ArchiveType%
echo DataDst:%DataDst%

set CopyLog=%ZDb%\etl\archive-%ArchiveType%.log
echo CopyLog:%CopyLog%

set CopyCmd=robocopy %DataSrc% %DataDst% /log:%CopyLog% /tee /TS /BYTES /V /MIR
echo CopyCmd:%CopyCmd%