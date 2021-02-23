@echo off

set Archive=%ZArchive%
set ArchiveType=etl

set DataSrc=%ZDb%\%ArchiveType%
echo DataSrc:%DataSrc%

set DataDst=%Archive%\data\%ArchiveType%
echo DataDst:%DataDst%

set CopyCmd=robocopy %DataSrc% %DataDst% /tee /TS /BYTES /V /MIR
echo CopyCmd:%CopyCmd%

