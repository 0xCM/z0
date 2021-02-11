@echo off
set Archive=%ZArchive%
set EtlLogs=%ZDb%\etl
set ZC=%ZControl%
set ZCmd=%ZC%\.cmd

set TableSrc=%ZDb%\tables
echo TableSrc:%TableSrc%

set TableDst=%Archive%\data\tables
echo TableDst:%TableDst%

set TableArchiveLog=%EtlLogs%\archive-tables.log
echo TableArchiveLog:%TableArchiveLog%

set TableArchiveCmd=robocopy %TableSrc% %TableDst% /log:%TableArchiveLog% /tee /TS /BYTES /V /MIR
echo TableArchiveCmd:%TableArchiveCmd%

call %TableArchiveCmd%
