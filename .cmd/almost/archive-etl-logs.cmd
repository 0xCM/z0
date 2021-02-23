@echo off

set ZC=%ZControl%\.cmd
call %ZC%\config.cmd

set CmdSpec=robocopy %EtlLogDir% %EtlLogArchive% /log:%EtlCopyLog% /tee /TS /BYTES /V /MIR
echo CmdSpec:%CmdSpec%

echo on
call %CmdSpec%