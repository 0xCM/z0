@echo off
set Archive=%ZArchive%
set EtlLogs=%ZDb%\etl
set ZC=%ZControl%
set ZCmd=%ZControl%\.cmd
set ZDevCmd=%ZDev%\.cmd

set EtlLogDir=%ZDb%\etl
echo EtlLogDir:%EtlLogDir%

set EtlLogArchive=k:\z0.archives\logs\etl
echo EtlLogArchive:%EtlLogArchive%

set EtlCopyLog=%ZDb%\etl\archive-etl-logs.log
echo EtlCopyLog:%EtlCopyLog%

set CleanEtlLogsCmd=del %EtlLogDir%\*.log /q
echo CleanEtlLogsCmd:%CleanEtlLogsCmd%

set MachineBinSrc=%ZDev%\.build\bin\release\z0.machine
echo MachineBinSrc:%MachineBinSrc%

set MachineBinDst=%Archive%\bin\builds\release\machine
echo MachineBinDst:%MachineBinDst%

