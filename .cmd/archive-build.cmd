echo off

set DataSrc=%ZDev%\.build\bin\release\z0.machine
echo DataSrc:%DataSrc%

set DataDst=k:\z0.archives\builds\release\machine
echo DataDst:%DataDst%

set CopyLog=%ZDb%\etl\build-archive.log
echo CopyLog:%CopyLog%

set CopyCmd=robocopy %DataSrc% %DataDst% /log:%CopyLog% /tee /TS /BYTES /V /MIR
echo CopyCmd:%CopyCmd%

echo on
call %CopyCmd%
