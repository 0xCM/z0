@echo off

set Archive=%ZArchive%
set ArchiveType=tools

set DataSrc=j:\tools\z\bin
echo DataSrc:%DataSrc%

set DataDst=%Archive%\bin\tools
echo DataDst:%DataDst%

set CopyLog=%ZDb%\etl\archive-%ArchiveType%.log
echo CopyLog:%CopyLog%

set CopyCmd=robocopy %DataSrc% %DataDst% /log:%CopyLog% /tee /TS /BYTES /V /MIR
echo CopyCmd:%CopyCmd%

call %CopyCmd%



